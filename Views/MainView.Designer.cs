namespace RegexExercise.Views;

partial class MainView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTableName = new AntdUI.Label();
        tblStaff = new AntdUI.Table();
        panelDetail = new AntdUI.Panel();
        lblErrorPhoto = new AntdUI.Label();
        lblErrorPhoneNumber = new AntdUI.Label();
        lblErrorEmail = new AntdUI.Label();
        lblErrorFullName = new AntdUI.Label();
        btnSave = new AntdUI.Button();
        btnEdit = new AntdUI.Button();
        btnCancel = new AntdUI.Button();
        txtPhoto = new AntdUI.Input();
        lblImage = new AntdUI.Label();
        dpStartWorkDay = new AntdUI.DatePicker();
        lblStartDate = new AntdUI.Label();
        txtPhoneNumber = new AntdUI.Input();
        lblPhoneNumber = new AntdUI.Label();
        txtEmail = new AntdUI.Input();
        lblEmail = new AntdUI.Label();
        txtFullName = new AntdUI.Input();
        lblStaffName = new AntdUI.Label();
        txtStaffId = new AntdUI.Input();
        lblStaffId = new AntdUI.Label();
        btnSelectPhoto = new AntdUI.Button();
        picAvatar = new AntdUI.Avatar();
        lblStaffForm = new AntdUI.Label();
        panelDetail.SuspendLayout();
        SuspendLayout();
        // 
        // lblTableName
        // 
        lblTableName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTableName.Location = new Point(16, 16);
        lblTableName.Name = "lblTableName";
        lblTableName.Size = new Size(300, 32);
        lblTableName.TabIndex = 0;
        lblTableName.Text = "DANH SÁCH NHÂN VIÊN";
        // 
        // tblStaff
        // 
        tblStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tblStaff.Bordered = true;
        tblStaff.EmptyText = "Chưa có dữ liệu nhân viên";
        tblStaff.Gap = 8;
        tblStaff.Gaps = new Size(8, 8);
        tblStaff.Location = new Point(16, 56);
        tblStaff.Name = "tblStaff";
        tblStaff.Size = new Size(825, 625);
        tblStaff.TabIndex = 1;
        // 
        // panelDetail
        // 
        panelDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        panelDetail.BorderWidth = 1F;
        panelDetail.Controls.Add(lblErrorPhoto);
        panelDetail.Controls.Add(lblErrorPhoneNumber);
        panelDetail.Controls.Add(lblErrorEmail);
        panelDetail.Controls.Add(lblErrorFullName);
        panelDetail.Controls.Add(btnSave);
        panelDetail.Controls.Add(btnEdit);
        panelDetail.Controls.Add(btnCancel);
        panelDetail.Controls.Add(txtPhoto);
        panelDetail.Controls.Add(lblImage);
        panelDetail.Controls.Add(dpStartWorkDay);
        panelDetail.Controls.Add(lblStartDate);
        panelDetail.Controls.Add(txtPhoneNumber);
        panelDetail.Controls.Add(lblPhoneNumber);
        panelDetail.Controls.Add(txtEmail);
        panelDetail.Controls.Add(lblEmail);
        panelDetail.Controls.Add(txtFullName);
        panelDetail.Controls.Add(lblStaffName);
        panelDetail.Controls.Add(txtStaffId);
        panelDetail.Controls.Add(lblStaffId);
        panelDetail.Controls.Add(btnSelectPhoto);
        panelDetail.Controls.Add(picAvatar);
        panelDetail.Controls.Add(lblStaffForm);
        panelDetail.Location = new Point(838, 16);
        panelDetail.Name = "panelDetail";
        panelDetail.Radius = 8;
        panelDetail.Size = new Size(451, 665);
        panelDetail.TabIndex = 2;
        panelDetail.Text = "panelDetail";
        // 
        // lblErrorPhoto
        // 
        lblErrorPhoto.BackColor = SystemColors.Window;
        lblErrorPhoto.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
        lblErrorPhoto.ForeColor = Color.FromArgb(255, 77, 79);
        lblErrorPhoto.Location = new Point(121, 533);
        lblErrorPhoto.Name = "lblErrorPhoto";
        lblErrorPhoto.Size = new Size(316, 20);
        lblErrorPhoto.TabIndex = 23;
        lblErrorPhoto.Text = "";
        lblErrorPhoto.TextAlign = ContentAlignment.MiddleRight;
        lblErrorPhoto.Visible = false;
        // 
        // lblErrorPhoneNumber
        // 
        lblErrorPhoneNumber.BackColor = SystemColors.Window;
        lblErrorPhoneNumber.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
        lblErrorPhoneNumber.ForeColor = Color.FromArgb(255, 77, 79);
        lblErrorPhoneNumber.Location = new Point(106, 405);
        lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
        lblErrorPhoneNumber.Size = new Size(325, 20);
        lblErrorPhoneNumber.TabIndex = 22;
        lblErrorPhoneNumber.Text = "";
        lblErrorPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
        lblErrorPhoneNumber.Visible = false;
        // 
        // lblErrorEmail
        // 
        lblErrorEmail.BackColor = SystemColors.Window;
        lblErrorEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
        lblErrorEmail.ForeColor = Color.FromArgb(255, 77, 79);
        lblErrorEmail.Location = new Point(95, 341);
        lblErrorEmail.Name = "lblErrorEmail";
        lblErrorEmail.Size = new Size(327, 20);
        lblErrorEmail.TabIndex = 21;
        lblErrorEmail.Text = "";
        lblErrorEmail.TextAlign = ContentAlignment.MiddleRight;
        lblErrorEmail.Visible = false;
        // 
        // lblErrorFullName
        // 
        lblErrorFullName.BackColor = SystemColors.Window;
        lblErrorFullName.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
        lblErrorFullName.ForeColor = Color.FromArgb(255, 77, 79);
        lblErrorFullName.Location = new Point(95, 277);
        lblErrorFullName.Name = "lblErrorFullName";
        lblErrorFullName.Size = new Size(327, 20);
        lblErrorFullName.TabIndex = 20;
        lblErrorFullName.Text = "";
        lblErrorFullName.TextAlign = ContentAlignment.MiddleRight;
        lblErrorFullName.Visible = false;
        // 
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSave.Location = new Point(339, 624);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(92, 36);
        btnSave.TabIndex = 17;
        btnSave.Text = "Lưu";
        btnSave.Type = AntdUI.TTypeMini.Primary;
        btnSave.Visible = false;
        // 
        // btnEdit
        // 
        btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnEdit.Location = new Point(339, 624);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(92, 36);
        btnEdit.TabIndex = 16;
        btnEdit.Text = "Chỉnh sửa";
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.Location = new Point(233, 624);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(100, 36);
        btnCancel.TabIndex = 15;
        btnCancel.Text = "Hủy";
        btnCancel.Visible = false;
        // 
        // txtPhoto
        // 
        txtPhoto.Location = new Point(20, 559);
        txtPhoto.Name = "txtPhoto";
        txtPhoto.PlaceholderText = "Tên tệp ảnh (vd: avatar.png)";
        txtPhoto.ReadOnly = true;
        txtPhoto.Size = new Size(422, 32);
        txtPhoto.TabIndex = 14;
        // 
        // lblImage
        // 
        lblImage.BackColor = SystemColors.Window;
        lblImage.Font = new Font("Segoe UI", 9F);
        lblImage.Location = new Point(20, 533);
        lblImage.Name = "lblImage";
        lblImage.Size = new Size(107, 20);
        lblImage.TabIndex = 13;
        lblImage.Text = "Tên tệp ảnh:";
        // 
        // dpStartWorkDay
        // 
        dpStartWorkDay.Format = "dd/MM/yyyy";
        dpStartWorkDay.Location = new Point(20, 495);
        dpStartWorkDay.Name = "dpStartWorkDay";
        dpStartWorkDay.ReadOnly = true;
        dpStartWorkDay.Size = new Size(417, 32);
        dpStartWorkDay.TabIndex = 12;
        // 
        // lblStartDate
        // 
        lblStartDate.BackColor = SystemColors.Window;
        lblStartDate.Font = new Font("Segoe UI", 9F);
        lblStartDate.Location = new Point(20, 469);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new Size(159, 20);
        lblStartDate.TabIndex = 11;
        lblStartDate.Text = "Ngày bắt đầu làm việc:";
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new Point(20, 431);
        txtPhoneNumber.MaxLength = 10;
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.PlaceholderText = "09xxxxxxxx";
        txtPhoneNumber.ReadOnly = true;
        txtPhoneNumber.Size = new Size(417, 32);
        txtPhoneNumber.TabIndex = 10;
        // 
        // lblPhoneNumber
        // 
        lblPhoneNumber.BackColor = SystemColors.Window;
        lblPhoneNumber.Font = new Font("Segoe UI", 9F);
        lblPhoneNumber.Location = new Point(20, 405);
        lblPhoneNumber.Name = "lblPhoneNumber";
        lblPhoneNumber.Size = new Size(107, 20);
        lblPhoneNumber.TabIndex = 9;
        lblPhoneNumber.Text = "Số điện thoại:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(20, 367);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "example@domain.com";
        txtEmail.ReadOnly = true;
        txtEmail.Size = new Size(417, 32);
        txtEmail.TabIndex = 8;
        // 
        // lblEmail
        // 
        lblEmail.BackColor = SystemColors.Window;
        lblEmail.Font = new Font("Segoe UI", 9F);
        lblEmail.Location = new Point(20, 341);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(60, 20);
        lblEmail.TabIndex = 7;
        lblEmail.Text = "Email:";
        // 
        // txtFullName
        // 
        txtFullName.Location = new Point(20, 303);
        txtFullName.Name = "txtFullName";
        txtFullName.PlaceholderText = "Nhập họ và tên...";
        txtFullName.ReadOnly = true;
        txtFullName.Size = new Size(417, 32);
        txtFullName.TabIndex = 6;
        // 
        // lblStaffName
        // 
        lblStaffName.BackColor = SystemColors.Window;
        lblStaffName.Font = new Font("Segoe UI", 9F);
        lblStaffName.Location = new Point(20, 277);
        lblStaffName.Name = "lblStaffName";
        lblStaffName.Size = new Size(107, 20);
        lblStaffName.TabIndex = 5;
        lblStaffName.Text = "Họ và tên:";
        // 
        // txtStaffId
        // 
        txtStaffId.Location = new Point(16, 239);
        txtStaffId.Name = "txtStaffId";
        txtStaffId.PlaceholderText = "Mã nhân viên (tự động)";
        txtStaffId.ReadOnly = true;
        txtStaffId.Size = new Size(421, 32);
        txtStaffId.TabIndex = 4;
        // 
        // lblStaffId
        // 
        lblStaffId.BackColor = SystemColors.Window;
        lblStaffId.Font = new Font("Segoe UI", 9F);
        lblStaffId.Location = new Point(20, 213);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.ShadowOpacity = 0F;
        lblStaffId.Size = new Size(150, 20);
        lblStaffId.TabIndex = 3;
        lblStaffId.Text = "Mã nhân viên (ID):";
        // 
        // btnSelectPhoto
        // 
        btnSelectPhoto.Type = AntdUI.TTypeMini.Primary;
        btnSelectPhoto.Enabled = false;
        btnSelectPhoto.Location = new Point(180, 168);
        btnSelectPhoto.Name = "btnSelectPhoto";
        btnSelectPhoto.Size = new Size(120, 30);
        btnSelectPhoto.TabIndex = 2;
        btnSelectPhoto.Text = "Chọn ảnh...";
        // 
        // picAvatar
        // 
        picAvatar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        picAvatar.Location = new Point(177, 46);
        picAvatar.Name = "picAvatar";
        picAvatar.Radius = 45;
        picAvatar.Round = true;
        picAvatar.Size = new Size(121, 116);
        picAvatar.TabIndex = 1;
        picAvatar.Text = "Ả";
        // 
        // lblStaffForm
        // 
        lblStaffForm.BackColor = SystemColors.Window;
        lblStaffForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblStaffForm.Location = new Point(16, 14);
        lblStaffForm.Name = "lblStaffForm";
        lblStaffForm.Size = new Size(400, 26);
        lblStaffForm.TabIndex = 0;
        lblStaffForm.Text = "THÔNG TIN CHI TIẾT";
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1305, 697);
        Controls.Add(panelDetail);
        Controls.Add(tblStaff);
        Controls.Add(lblTableName);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(1020, 680);
        Name = "MainView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản Lý Nhân Viên";
        panelDetail.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Label lblTableName;
    private AntdUI.Table tblStaff;
    private AntdUI.Panel panelDetail;
    private AntdUI.Label lblStaffForm;
    private AntdUI.Avatar picAvatar;
    private AntdUI.Button btnSelectPhoto;
    private AntdUI.Label lblStaffId;
    private AntdUI.Input txtStaffId;
    private AntdUI.Label lblStaffName;
    private AntdUI.Input txtFullName;
    private AntdUI.Label lblEmail;
    private AntdUI.Input txtEmail;
    private AntdUI.Label lblPhoneNumber;
    private AntdUI.Input txtPhoneNumber;
    private AntdUI.Label lblStartDate;
    private AntdUI.DatePicker dpStartWorkDay;
    private AntdUI.Label lblImage;
    private AntdUI.Input txtPhoto;
    private AntdUI.Button btnCancel;
    private AntdUI.Button btnEdit;
    private AntdUI.Button btnSave;
    private AntdUI.Label lblErrorFullName;
    private AntdUI.Label lblErrorEmail;
    private AntdUI.Label lblErrorPhoneNumber;
    private AntdUI.Label lblErrorPhoto;
}
