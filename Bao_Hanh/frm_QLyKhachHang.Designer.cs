namespace Bao_Hanh
{
    partial class frm_QLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.cSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_Data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Data = new DevExpress.XtraGrid.GridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoVaTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_GioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoVaTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cSDT
            // 
            this.cSDT.Caption = "Số điện thoại";
            this.cSDT.FieldName = "SDT";
            this.cSDT.Name = "cSDT";
            this.cSDT.OptionsColumn.AllowEdit = false;
            this.cSDT.Visible = true;
            this.cSDT.VisibleIndex = 5;
            this.cSDT.Width = 94;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.Caption = "Ngày Sinh";
            this.cNgaySinh.FieldName = "NgaySinh";
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.OptionsColumn.AllowEdit = false;
            this.cNgaySinh.Visible = true;
            this.cNgaySinh.VisibleIndex = 3;
            this.cNgaySinh.Width = 92;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(470, 100);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 19);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Ngày sinh :";
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.Caption = "Giới Tính";
            this.cGioiTinh.FieldName = "GioiTinh";
            this.cGioiTinh.Name = "cGioiTinh";
            this.cGioiTinh.OptionsColumn.AllowEdit = false;
            this.cGioiTinh.Visible = true;
            this.cGioiTinh.VisibleIndex = 2;
            this.cGioiTinh.Width = 78;
            // 
            // cTenKH
            // 
            this.cTenKH.Caption = "Tên KH";
            this.cTenKH.FieldName = "TenKhachHang";
            this.cTenKH.Name = "cTenKH";
            this.cTenKH.OptionsColumn.AllowEdit = false;
            this.cTenKH.Visible = true;
            this.cTenKH.VisibleIndex = 1;
            this.cTenKH.Width = 222;
            // 
            // cMaKH
            // 
            this.cMaKH.Caption = "MaKH";
            this.cMaKH.FieldName = "MaKH";
            this.cMaKH.Name = "cMaKH";
            this.cMaKH.OptionsColumn.AllowEdit = false;
            this.cMaKH.Visible = true;
            this.cMaKH.VisibleIndex = 0;
            this.cMaKH.Width = 59;
            // 
            // gv_Data
            // 
            this.gv_Data.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Data.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gv_Data.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gv_Data.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Data.Appearance.HeaderPanel.Options.UseFont = true;
            this.gv_Data.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.gv_Data.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaKH,
            this.cTenKH,
            this.cGioiTinh,
            this.cNgaySinh,
            this.cDiaChi,
            this.cSDT});
            this.gv_Data.GridControl = this.gc_Data;
            this.gv_Data.Name = "gv_Data";
            this.gv_Data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Data_RowClick);
            this.gv_Data.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_Data_CustomDrawRowIndicator);
            // 
            // cDiaChi
            // 
            this.cDiaChi.Caption = "Địa chỉ";
            this.cDiaChi.FieldName = "DiaChi";
            this.cDiaChi.Name = "cDiaChi";
            this.cDiaChi.OptionsColumn.AllowEdit = false;
            this.cDiaChi.Visible = true;
            this.cDiaChi.VisibleIndex = 4;
            this.cDiaChi.Width = 147;
            // 
            // gc_Data
            // 
            this.gc_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Data.Location = new System.Drawing.Point(2, 2);
            this.gc_Data.MainView = this.gv_Data;
            this.gc_Data.Name = "gc_Data";
            this.gc_Data.Size = new System.Drawing.Size(1025, 339);
            this.gc_Data.TabIndex = 1;
            this.gc_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Data});
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_Data);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 192);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1029, 343);
            this.panelControl2.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Location = new System.Drawing.Point(470, 62);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(111, 19);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Số Điện Thoại :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 19);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Họ Và Tên :";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.EditValue = "";
            this.txtHoVaTen.Location = new System.Drawing.Point(154, 53);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtHoVaTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtHoVaTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtHoVaTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoVaTen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHoVaTen.Properties.Mask.EditMask = "n0";
            this.txtHoVaTen.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(213, 30);
            this.txtHoVaTen.TabIndex = 22;
            // 
            // txtMaKH
            // 
            this.txtMaKH.EditValue = "";
            this.txtMaKH.Location = new System.Drawing.Point(154, 17);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMaKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMaKH.Size = new System.Drawing.Size(213, 30);
            this.txtMaKH.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(470, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 19);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Địa chỉ :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 19);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Giới Tính :";
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.Location = new System.Drawing.Point(154, 89);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbo_GioiTinh.Properties.Appearance.Options.UseFont = true;
            this.cbo_GioiTinh.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbo_GioiTinh.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbo_GioiTinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cbo_GioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_GioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo_GioiTinh.Size = new System.Drawing.Size(213, 30);
            this.cbo_GioiTinh.TabIndex = 29;
            // 
            // txtPhone
            // 
            this.txtPhone.EditValue = "";
            this.txtPhone.Location = new System.Drawing.Point(650, 53);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPhone.Properties.Appearance.Options.UseBackColor = true;
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPhone.Properties.Mask.EditMask = "n0";
            this.txtPhone.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPhone.Size = new System.Drawing.Size(213, 30);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.Leave += new System.EventHandler(this.txt_sdt_Leave);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_TimKiem);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.lblPhone);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbo_GioiTinh);
            this.panelControl1.Controls.Add(this.txtPhone);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtHoVaTen);
            this.panelControl1.Controls.Add(this.txtMaKH);
            this.panelControl1.Controls.Add(this.cboNgaySinh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1029, 192);
            this.panelControl1.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.EditValue = "";
            this.txtDiaChi.Location = new System.Drawing.Point(650, 17);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDiaChi.Size = new System.Drawing.Size(213, 30);
            this.txtDiaChi.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 19);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Mã Khách Hàng :";
            // 
            // cboNgaySinh
            // 
            this.cboNgaySinh.EditValue = null;
            this.cboNgaySinh.Location = new System.Drawing.Point(650, 93);
            this.cboNgaySinh.Name = "cboNgaySinh";
            this.cboNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.cboNgaySinh.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cboNgaySinh.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboNgaySinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.cboNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.cboNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboNgaySinh.Properties.Mask.EditMask = "";
            this.cboNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cboNgaySinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboNgaySinh.Size = new System.Drawing.Size(213, 30);
            this.cboNgaySinh.TabIndex = 39;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Clear.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Clear.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Clear.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Appearance.Options.UseBackColor = true;
            this.btn_Clear.Appearance.Options.UseBorderColor = true;
            this.btn_Clear.Appearance.Options.UseFont = true;
            this.btn_Clear.Location = new System.Drawing.Point(154, 134);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(137, 41);
            this.btn_Clear.TabIndex = 40;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Save.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Save.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseBorderColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new System.Drawing.Point(303, 134);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(137, 41);
            this.btn_Save.TabIndex = 41;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Delete.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Delete.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseBorderColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(444, 134);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(137, 41);
            this.btn_Delete.TabIndex = 42;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_TimKiem.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_TimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.Appearance.Options.UseBackColor = true;
            this.btn_TimKiem.Appearance.Options.UseBorderColor = true;
            this.btn_TimKiem.Appearance.Options.UseFont = true;
            this.btn_TimKiem.Location = new System.Drawing.Point(585, 134);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(137, 41);
            this.btn_TimKiem.TabIndex = 43;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // frm_QLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 535);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_QLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frm_QLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHoVaTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_GioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn cSDT;
        private DevExpress.XtraGrid.Columns.GridColumn cNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn cGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn cMaKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Data;
        private DevExpress.XtraGrid.Columns.GridColumn cDiaChi;
        private DevExpress.XtraGrid.GridControl gc_Data;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHoVaTen;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_GioiTinh;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit cboNgaySinh;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
    }
}