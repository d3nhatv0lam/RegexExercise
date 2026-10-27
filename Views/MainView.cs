using System.Diagnostics;
using AntdUI;
using RegexExercise.Models;

namespace RegexExercise.Views;

public partial class MainView : Form, IMainView
{
    private readonly Dictionary<string, (Input Input, AntdUI.Label? ErrorLabel)> _uiValidateElements;
    private System.Windows.Forms.Timer? _debounceTimer;
    private readonly Dictionary<string, string> _pendingChanges = new();
    private Staff? _selectedStaff;

    public MainView()
    {
        InitializeComponent();
        SetupUIEvents();
        SetEditMode(false);

        _uiValidateElements = new Dictionary<string, (Input Input, AntdUI.Label? ErrorLabel)>
        {
            { nameof(Staff.Id), (txtStaffId, null) },
            { nameof(Staff.FullName), (txtFullName, lblErrorFullName) },
            { nameof(Staff.Email), (txtEmail, lblErrorEmail) },
            { nameof(Staff.PhoneNumber), (txtPhoneNumber, lblErrorPhoneNumber) },
            { nameof(Staff.StartWorkDay), (dpStartWorkDay, null) },
            { nameof(Staff.Photo), (txtPhoto, lblErrorPhoto) },
        };

        SetupDebounce();
    }

    private void SetupUIEvents()
    {
        btnSelectPhoto.Click += BtnSelectPhoto_Click;
        tblStaff.CellClick += TblStaff_CellClick;

        btnEdit.Click += BtnEdit_Click;
        btnCancel.Click += BtnCancel_Click;
        btnSave.Click += BtnSave_Click;
    }

    private void SetupDebounce()
    {
        // Gắn components để WinForms tự giải phóng Timer khi Form đóng
        components ??= new System.ComponentModel.Container();
        _debounceTimer = new System.Windows.Forms.Timer(components) { Interval = 350 };
        _debounceTimer.Tick += (s, e) =>
        {
            _debounceTimer.Stop();

            // Duyệt và bắn sự kiện validate cho tất cả các trường vừa thay đổi
            foreach (var (fieldName, value) in _pendingChanges)
            {
                UpdateFieldChanged?.Invoke(this, new FieldChangedEventArgs(fieldName, value));
            }

            _pendingChanges.Clear();
        };

        // Tự động gắn TextChanged cho các input trong _uiValidateElements
        foreach (var (propName, element) in _uiValidateElements)
        {
            if (propName != nameof(Staff.Id))
            {
                element.Input.TextChanged += (s, e) =>
                {
                    if (!btnSave.Visible) return; // Chỉ validate khi đang ở chế độ Chỉnh sửa
                    _pendingChanges[propName] = element.Input.Text;
                    _debounceTimer?.Stop();
                    _debounceTimer?.Start();
                };
            }
        }
    }

    private void SetEditMode(bool isEditing)
    {
        txtStaffId.ReadOnly = true;

        txtFullName.ReadOnly = !isEditing;
        txtEmail.ReadOnly = !isEditing;
        txtPhoneNumber.ReadOnly = !isEditing;
        dpStartWorkDay.ReadOnly = !isEditing;
        txtPhoto.ReadOnly = !isEditing;
        btnSelectPhoto.Enabled = isEditing;

        btnEdit.Visible = !isEditing;
        btnCancel.Visible = isEditing;
        btnSave.Visible = isEditing;

        if (!isEditing)
        {
            ClearValidationErrors();
            if (_selectedStaff is not null)
                DisplayStaff(_selectedStaff);
        }
    }

    private void ClearValidationErrors()
    {
        if (_uiValidateElements == null) return;
        foreach (var (_, element) in _uiValidateElements)
        {
            element.Input.Status = TType.None;
            if (element.ErrorLabel != null)
            {
                element.ErrorLabel.Text = "";
                element.ErrorLabel.Visible = false;
            }
        }
    }

    private void BtnEdit_Click(object? sender, EventArgs e)
    {
        SetEditMode(true);
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        SetEditMode(false);
    }

    private void BtnSave_Click(object? sender, EventArgs e)
    {
        UpdateEmployeeClicked?.Invoke(this, GetStaffFromForm());
        SetEditMode(false);
    }

    private void TblStaff_CellClick(object? sender, AntdUI.TableClickEventArgs e)
    {
        if (e.Record is Staff staff)
        {
            _selectedStaff = staff;
            DisplayStaff(staff);
        }
    }

    private void BtnSelectPhoto_Click(object? sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog
        {
            Title = "Chọn ảnh nhân viên",
            Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*"
        };

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            txtPhoto.Text = Path.GetFileName(ofd.FileName);
            picAvatar.Image?.Dispose();
            picAvatar.Image = LoadImageWithoutLocking(ofd.FileName);
        }
    }

    private void DisplayStaff(Staff staff)
    {
        txtStaffId.Text = staff.Id.ToString();
        txtFullName.Text = staff.FullName;
        txtEmail.Text = staff.Email;
        txtPhoneNumber.Text = staff.PhoneNumber;
        dpStartWorkDay.Value = staff.StartWorkDay;
        txtPhoto.Text = staff.Photo;

        picAvatar.Text = string.IsNullOrWhiteSpace(staff.FullName) ? "Ảnh" : staff.FullName.Trim()[..1].ToUpper();
        picAvatar.Image?.Dispose();
        picAvatar.Image = null;

        if (!string.IsNullOrWhiteSpace(staff.Photo))
        {
            picAvatar.Image = LoadImageWithoutLocking(staff.Photo);
        }
    }

    private static Image? LoadImageWithoutLocking(string filePath)
    {
        if (!File.Exists(filePath)) return null;
        try
        {
            using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using var ms = new MemoryStream();
            fs.CopyTo(ms);
            ms.Position = 0;
            return Image.FromStream(ms);
        }
        catch
        {
            return null;
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        picAvatar.Image?.Dispose();
        base.OnFormClosed(e);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        Loaded?.Invoke(this, EventArgs.Empty);
    }

    public event EventHandler? Loaded;
    public event EventHandler<FieldChangedEventArgs>? UpdateFieldChanged;
    public event EventHandler<Staff>? UpdateEmployeeClicked;

    public void SetFieldError(string propertyName, string? errorMessage)
    {
        if (_uiValidateElements.TryGetValue(propertyName, out var element))
        {
            bool hasError = !string.IsNullOrWhiteSpace(errorMessage);

            // Viền đỏ phát sáng AntdUI
            element.Input.Status = hasError ? TType.Error : TType.None;

            // Nhãn chữ đỏ hiển thị thông báo
            if (element.ErrorLabel != null)
            {
                element.ErrorLabel.Text = hasError ? errorMessage! : "";
                element.ErrorLabel.Visible = hasError;
            }
        }
    }

    public void SetFieldError(Dictionary<string, string> validationErrors)
    {
        foreach (var (propName, _) in _uiValidateElements)
        {
            SetFieldError(propName, validationErrors.GetValueOrDefault(propName));
        }
    }

    public void UpdateChangeStatus(bool isSuccess, string message)
    {
        AntdUI.Message.info(this, message);
        if (!isSuccess)
        {
            if (_selectedStaff is not null)
                DisplayStaff(_selectedStaff);
        }
    }

    public void LoadStaffs(IReadOnlyList<Staff> staffs)
    {
        tblStaff.Binding(new AntdUI.AntList<Staff>(staffs.ToList()));
    }

    private Staff GetStaffFromForm()
    {
        int.TryParse(txtStaffId.Text, out int id);
        return new Staff
        {
            Id = id,
            FullName = txtFullName.Text,
            Email = txtEmail.Text,
            PhoneNumber = txtPhoneNumber.Text,
            StartWorkDay = dpStartWorkDay.Value ?? DateTime.Now,
            Photo = txtPhoto.Text,
        };
    }
}