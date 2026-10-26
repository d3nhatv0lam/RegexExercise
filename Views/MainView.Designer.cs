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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTableName = new AntdUI.Label();
        tblStaff = new AntdUI.Table();
        lblStaffForm = new AntdUI.Label();
        btnEdit = new AntdUI.Button();
        btnSave = new AntdUI.Button();
        btnCancel = new AntdUI.Button();
        panel1 = new AntdUI.Panel();
        image3d1 = new AntdUI.Image3D();
        datePicker1 = new AntdUI.DatePicker();
        input3 = new AntdUI.Input();
        input2 = new AntdUI.Input();
        input1 = new AntdUI.Input();
        lblImage = new AntdUI.Label();
        lblStartDate = new AntdUI.Label();
        lblPhoneNumber = new AntdUI.Label();
        lblEmail = new AntdUI.Label();
        lblStaffName = new AntdUI.Label();
        lblStaffId = new AntdUI.Label();
        input4 = new AntdUI.Input();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // lblTableName
        // 
        lblTableName.HandDragFolder = false;
        lblTableName.Location = new Point(12, 12);
        lblTableName.Name = "lblTableName";
        lblTableName.Size = new Size(204, 29);
        lblTableName.TabIndex = 0;
        lblTableName.Text = "DANH SÁCH NHÂN VIÊN";
        lblTableName.UseWaitCursor = true;
        // 
        // tblStaff
        // 
        tblStaff.Gap = 12;
        tblStaff.Location = new Point(12, 56);
        tblStaff.Name = "tblStaff";
        tblStaff.Size = new Size(660, 562);
        tblStaff.TabIndex = 1;
        tblStaff.Text = "table1";
        // 
        // lblStaffForm
        // 
        lblStaffForm.HandDragFolder = false;
        lblStaffForm.Location = new Point(694, 12);
        lblStaffForm.Name = "lblStaffForm";
        lblStaffForm.Size = new Size(204, 29);
        lblStaffForm.TabIndex = 3;
        lblStaffForm.Text = "THÔNG TIN NHÂN VIÊN";
        lblStaffForm.UseWaitCursor = true;
        // 
        // btnEdit
        // 
        btnEdit.Location = new Point(1014, 624);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(94, 29);
        btnEdit.TabIndex = 4;
        btnEdit.Text = "Chỉnh sửa";
        // 
        // btnSave
        // 
        btnSave.Location = new Point(1014, 624);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 29);
        btnSave.TabIndex = 4;
        btnSave.Text = "Lưu";
        btnSave.TextCenterHasIcon = true;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(914, 624);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Hủy";
        btnCancel.TextCenterHasIcon = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(input4);
        panel1.Controls.Add(image3d1);
        panel1.Controls.Add(datePicker1);
        panel1.Controls.Add(input3);
        panel1.Controls.Add(input2);
        panel1.Controls.Add(input1);
        panel1.Controls.Add(lblImage);
        panel1.Controls.Add(lblStartDate);
        panel1.Controls.Add(lblPhoneNumber);
        panel1.Controls.Add(lblEmail);
        panel1.Controls.Add(lblStaffName);
        panel1.Controls.Add(lblStaffId);
        panel1.Location = new Point(694, 56);
        panel1.Name = "panel1";
        panel1.Size = new Size(414, 562);
        panel1.TabIndex = 6;
        panel1.Text = "panel1";
        // 
        // image3d1
        // 
        image3d1.Location = new Point(99, 340);
        image3d1.Name = "image3d1";
        image3d1.Size = new Size(215, 198);
        image3d1.TabIndex = 13;
        image3d1.Text = "image3d1";
        // 
        // datePicker1
        // 
        datePicker1.Location = new Point(10, 276);
        datePicker1.Name = "datePicker1";
        datePicker1.Size = new Size(276, 29);
        datePicker1.TabIndex = 11;
        // 
        // input3
        // 
        input3.Location = new Point(6, 159);
        input3.Name = "input3";
        input3.Size = new Size(276, 29);
        input3.TabIndex = 8;
        input3.Text = "input3";
        // 
        // input2
        // 
        input2.Location = new Point(3, 97);
        input2.Name = "input2";
        input2.Size = new Size(276, 29);
        input2.TabIndex = 7;
        input2.Text = "input2";
        // 
        // input1
        // 
        input1.Location = new Point(3, 29);
        input1.Name = "input1";
        input1.Size = new Size(285, 27);
        input1.TabIndex = 6;
        input1.Text = "input1";
        // 
        // lblImage
        // 
        lblImage.Location = new Point(5, 305);
        lblImage.Name = "lblImage";
        lblImage.Size = new Size(147, 29);
        lblImage.TabIndex = 5;
        lblImage.Text = "Ảnh nhân viên:";
        // 
        // lblStartDate
        // 
        lblStartDate.Location = new Point(10, 250);
        lblStartDate.Name = "lblStartDate";
        lblStartDate.Size = new Size(167, 29);
        lblStartDate.TabIndex = 4;
        lblStartDate.Text = "Ngày bắt đầu làm việc:";
        // 
        // lblPhoneNumber
        // 
        lblPhoneNumber.Location = new Point(7, 190);
        lblPhoneNumber.Name = "lblPhoneNumber";
        lblPhoneNumber.Size = new Size(94, 29);
        lblPhoneNumber.TabIndex = 3;
        lblPhoneNumber.Text = "Số điện thoại:";
        // 
        // lblEmail
        // 
        lblEmail.Location = new Point(3, 136);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(94, 20);
        lblEmail.TabIndex = 2;
        lblEmail.Text = "Email";
        // 
        // lblStaffName
        // 
        lblStaffName.Location = new Point(3, 62);
        lblStaffName.Name = "lblStaffName";
        lblStaffName.Size = new Size(94, 29);
        lblStaffName.TabIndex = 1;
        lblStaffName.Text = "Họ và tên:";
        // 
        // lblStaffId
        // 
        lblStaffId.Location = new Point(3, 3);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.Size = new Size(94, 20);
        lblStaffId.TabIndex = 0;
        lblStaffId.Text = "ID:";
        // 
        // input4
        // 
        input4.Location = new Point(6, 225);
        input4.Name = "input4";
        input4.Size = new Size(405, 29);
        input4.TabIndex = 14;
        input4.Text = "input4";
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1120, 665);
        Controls.Add(panel1);
        Controls.Add(btnCancel);
        Controls.Add(btnEdit);
        Controls.Add(btnSave);
        Controls.Add(lblStaffForm);
        Controls.Add(tblStaff);
        Controls.Add(lblTableName);
        Name = "MainView";
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Label lblTableName;
    private AntdUI.Table tblStaff;
    private AntdUI.Label lblStaffForm;
    private AntdUI.Button btnEdit;
    private AntdUI.Button btnSave;
    private AntdUI.Button btnCancel;
    private AntdUI.Panel panel1;
    private AntdUI.Label lblImage;
    private AntdUI.Label lblStartDate;
    private AntdUI.Label lblPhoneNumber;
    private AntdUI.Label lblEmail;
    private AntdUI.Label lblStaffName;
    private AntdUI.Label lblStaffId;
    private AntdUI.Input input2;
    private AntdUI.Input input1;
    private AntdUI.DatePicker datePicker1;
    private AntdUI.Input input3;
    private AntdUI.Image3D image3d1;
    private AntdUI.Input input4;
    private AntdUI.Button button3;
}
