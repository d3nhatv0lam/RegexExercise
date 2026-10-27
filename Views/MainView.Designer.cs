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
        lblTableName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lblTableName.Location = new System.Drawing.Point(16, 16);
        lblTableName.Name = "lblTableName";
        lblTableName.Size = new System.Drawing.Size(300, 32);
        lblTableName.TabIndex = 0;
        lblTableName.Text = "DANH SÁCH NHÂN VIÊN";
        // 
        // tblStaff
        // 
        tblStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tblStaff.Bordered = true;
        tblStaff.EmptyText = "Chưa có dữ liệu nhân viên";
        tblStaff.Gap = 8;
        tblStaff.Location = new System.Drawing.Point(16, 56);
        tblStaff.Name = "tblStaff";
        tblStaff.Size = new System.Drawing.Size(680, 592);
        tblStaff.TabIndex = 1;
        tblStaff.Columns.Add(new AntdUI.Column("Id", "ID", AntdUI.ColumnAlign.Center) { Width = "60" });
        tblStaff.Columns.Add(new AntdUI.Column("FullName", "Họ và Tên") { Width = "150" });
        tblStaff.Columns.Add(new AntdUI.Column("Email", "Email") { Width = "180" });
        tblStaff.Columns.Add(new AntdUI.Column("PhoneNumber", "Số Điện Thoại", AntdUI.ColumnAlign.Center) { Width = "120" });
        tblStaff.Columns.Add(new AntdUI.Column("StartWorkDay", "Ngày Vào Làm", AntdUI.ColumnAlign.Center) { Width = "120", DisplayFormat = "yyyy-MM-dd" });
        tblStaff.Columns.Add(new AntdUI.Column("Photo", "Ảnh") { Width = "110" });
        // 
        // panelDetail
        // 
        panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right));
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
        panelDetail.Location = new System.Drawing.Point(712, 16);
        panelDetail.Name = "panelDetail";
        panelDetail.Radius = 8;
        panelDetail.Size = new System.Drawing.Size(432, 632);
        panelDetail.TabIndex = 2;
        panelDetail.Text = "panelDetail";
        // 
        // lblErrorPhoto
        // 
        lblErrorPhoto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
        lblErrorPhoto.ForeColor = System.Drawing.Color.FromArgb(255, 77, 79);
        lblErrorPhoto.Location = new System.Drawing.Point(160, 492);
        lblErrorPhoto.Name = "lblErrorPhoto";
        lblErrorPhoto.Size = new System.Drawing.Size(252, 20);
        lblErrorPhoto.TabIndex = 23;
        lblErrorPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblErrorPhoto.Text = "";
        lblErrorPhoto.Visible = false;
        // 
        // lblErrorPhoneNumber
        // 
        lblErrorPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
        lblErrorPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(255, 77, 79);
        lblErrorPhoneNumber.Location = new System.Drawing.Point(160, 368);
        lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
        lblErrorPhoneNumber.Size = new System.Drawing.Size(252, 20);
        lblErrorPhoneNumber.TabIndex = 22;
        lblErrorPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblErrorPhoneNumber.Text = "";
        lblErrorPhoneNumber.Visible = false;
        // 
        // lblErrorEmail
        // 
        lblErrorEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
        lblErrorEmail.ForeColor = System.Drawing.Color.FromArgb(255, 77, 79);
        lblErrorEmail.Location = new System.Drawing.Point(160, 306);
        lblErrorEmail.Name = "lblErrorEmail";
        lblErrorEmail.Size = new System.Drawing.Size(252, 20);
        lblErrorEmail.TabIndex = 21;
        lblErrorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblErrorEmail.Text = "";
        lblErrorEmail.Visible = false;
        // 
        // lblErrorFullName
        // 
        lblErrorFullName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
        lblErrorFullName.ForeColor = System.Drawing.Color.FromArgb(255, 77, 79);
        lblErrorFullName.Location = new System.Drawing.Point(160, 244);
        lblErrorFullName.Name = "lblErrorFullName";
        lblErrorFullName.Size = new System.Drawing.Size(252, 20);
        lblErrorFullName.TabIndex = 20;
        lblErrorFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        lblErrorFullName.Text = "";
        lblErrorFullName.Visible = false;
        // 
        // btnSave
        // 
        btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnSave.Location = new System.Drawing.Point(320, 574);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(92, 36);
        btnSave.TabIndex = 17;
        btnSave.Text = "Lưu";
        btnSave.Type = AntdUI.TTypeMini.Primary;
        btnSave.Visible = false;
        // 
        // btnEdit
        // 
        btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnEdit.Location = new System.Drawing.Point(320, 574);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new System.Drawing.Size(92, 36);
        btnEdit.TabIndex = 16;
        btnEdit.Text = "Chỉnh sửa";
        btnEdit.Visible = true;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btnCancel.Location = new System.Drawing.Point(212, 574);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 36);
        btnCancel.TabIndex = 15;
        btnCancel.Text = "Hủy";
        btnCancel.Visible = false;
        // 
        // txtPhoto
        // 
        txtPhoto.Location = new System.Drawing.Point(20, 514);
        txtPhoto.Name = "txtPhoto";
        txtPhoto.PlaceholderText = "Tên tệp ảnh (vd: avatar.png)";
        txtPhoto.ReadOnly = true;
        txtPhoto.Size = new System.Drawing.Size(392, 32);
        txtPhoto.TabIndex = 14;
        // 
        // lblImage
        // 
        lblImage.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblImage.Location = new System.Drawing.Point(20, 492);
        lblImage.Name = "lblImage";
        lblImage.Size = new System.Drawing.Size(150, 20);
        lblImage.TabIndex = 13;
        lblImage.Text = "Tên tệp ảnh:";
        // 
        // dpStartWorkDay
        // 
        dpStartWorkDay.Format = "dd/MM/yyyy";
        dpStartWorkDay.Location = new System.Drawing.Point(20, 452);
        dpStartWorkDay.Name = "dpStartWorkDay";
        dpStartWorkDay.ReadOnly = true;
        dpStartWorkDay.Size = new System.Drawing.Size(392, 32);
        dpStartWorkDay.TabIndex = 12;
        // 
        // lblStartDate
        // 
        lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStartDate.Location = new System.Drawing.Point(20, 430);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new System.Drawing.Size(200, 20);
        lblStartDate.TabIndex = 11;
        lblStartDate.Text = "Ngày bắt đầu làm việc:";
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new System.Drawing.Point(20, 390);
        txtPhoneNumber.MaxLength = 10;
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.PlaceholderText = "09xxxxxxxx";
        txtPhoneNumber.ReadOnly = true;
        txtPhoneNumber.Size = new System.Drawing.Size(392, 32);
        txtPhoneNumber.TabIndex = 10;
        // 
        // lblPhoneNumber
        // 
        lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblPhoneNumber.Location = new System.Drawing.Point(20, 368);
        lblPhoneNumber.Name = "lblPhoneNumber";
        lblPhoneNumber.Size = new System.Drawing.Size(150, 20);
        lblPhoneNumber.TabIndex = 9;
        lblPhoneNumber.Text = "Số điện thoại:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(20, 328);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "example@domain.com";
        txtEmail.ReadOnly = true;
        txtEmail.Size = new System.Drawing.Size(392, 32);
        txtEmail.TabIndex = 8;
        // 
        // lblEmail
        // 
        lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblEmail.Location = new System.Drawing.Point(20, 306);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(150, 20);
        lblEmail.TabIndex = 7;
        lblEmail.Text = "Email:";
        // 
        // txtFullName
        // 
        txtFullName.Location = new System.Drawing.Point(20, 266);
        txtFullName.Name = "txtFullName";
        txtFullName.PlaceholderText = "Nhập họ và tên...";
        txtFullName.ReadOnly = true;
        txtFullName.Size = new System.Drawing.Size(392, 32);
        txtFullName.TabIndex = 6;
        // 
        // lblStaffName
        // 
        lblStaffName.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStaffName.Location = new System.Drawing.Point(20, 244);
        lblStaffName.Name = "lblStaffName";
        lblStaffName.Size = new System.Drawing.Size(150, 20);
        lblStaffName.TabIndex = 5;
        lblStaffName.Text = "Họ và tên:";
        // 
        // txtStaffId
        // 
        txtStaffId.Location = new System.Drawing.Point(20, 204);
        txtStaffId.Name = "txtStaffId";
        txtStaffId.PlaceholderText = "Mã nhân viên (tự động)";
        txtStaffId.ReadOnly = true;
        txtStaffId.Size = new System.Drawing.Size(392, 32);
        txtStaffId.TabIndex = 4;
        // 
        // lblStaffId
        // 
        lblStaffId.Font = new System.Drawing.Font("Segoe UI", 9F);
        lblStaffId.Location = new System.Drawing.Point(20, 182);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.Size = new System.Drawing.Size(150, 20);
        lblStaffId.TabIndex = 3;
        lblStaffId.Text = "Mã nhân viên (ID):";
        // 
        // btnSelectPhoto
        // 
        btnSelectPhoto.Enabled = false;
        btnSelectPhoto.Location = new System.Drawing.Point(156, 144);
        btnSelectPhoto.Name = "btnSelectPhoto";
        btnSelectPhoto.Size = new System.Drawing.Size(120, 30);
        btnSelectPhoto.TabIndex = 2;
        btnSelectPhoto.Text = "Chọn ảnh...";
        // 
        // picAvatar
        // 
        picAvatar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        picAvatar.Location = new System.Drawing.Point(171, 46);
        picAvatar.Name = "picAvatar";
        picAvatar.Radius = 45;
        picAvatar.Round = true;
        picAvatar.Size = new System.Drawing.Size(90, 90);
        picAvatar.TabIndex = 1;
        picAvatar.Text = "Ảnh";
        // 
        // lblStaffForm
        // 
        lblStaffForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        lblStaffForm.Location = new System.Drawing.Point(16, 14);
        lblStaffForm.Name = "lblStaffForm";
        lblStaffForm.Size = new System.Drawing.Size(400, 26);
        lblStaffForm.TabIndex = 0;
        lblStaffForm.Text = "THÔNG TIN CHI TIẾT";
        // 
        // MainView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1160, 664);
        Controls.Add(panelDetail);
        Controls.Add(tblStaff);
        Controls.Add(lblTableName);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        MinimumSize = new System.Drawing.Size(1020, 680);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
