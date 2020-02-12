namespace Bao_Hanh
{
    partial class frm_QuanLyDichVu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkTinhTrang = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiaDV = new DevExpress.XtraEditors.TextEdit();
            this.cboThoiGianBaoHanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDichVu = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Data = new DevExpress.XtraGrid.GridControl();
            this.gv_Data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cGiaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cThoiGianBH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.rep_TinhTrang = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThoiGianBaoHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_TinhTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_TimKiem);
            this.panelControl1.Controls.Add(this.btn_Luu);
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Controls.Add(this.chkTinhTrang);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtGiaDV);
            this.panelControl1.Controls.Add(this.cboThoiGianBaoHanh);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtTenDV);
            this.panelControl1.Controls.Add(this.txtMaDichVu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1083, 236);
            this.panelControl1.TabIndex = 0;
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.Location = new System.Drawing.Point(599, 175);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTinhTrang.Properties.Appearance.Options.UseFont = true;
            this.chkTinhTrang.Properties.Caption = "  Kích hoạt dịch vụ";
            this.chkTinhTrang.Size = new System.Drawing.Size(231, 28);
            this.chkTinhTrang.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 167);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(217, 24);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "Thời gian bảo hành DV :";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.EditValue = "";
            this.txtGiaDV.Location = new System.Drawing.Point(251, 109);
            this.txtGiaDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtGiaDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtGiaDV.Properties.Appearance.Options.UseBackColor = true;
            this.txtGiaDV.Properties.Appearance.Options.UseFont = true;
            this.txtGiaDV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtGiaDV.Properties.DisplayFormat.FormatString = "n0";
            this.txtGiaDV.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaDV.Properties.EditFormat.FormatString = "n0";
            this.txtGiaDV.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaDV.Properties.Mask.EditMask = "n0";
            this.txtGiaDV.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGiaDV.Size = new System.Drawing.Size(284, 36);
            this.txtGiaDV.TabIndex = 2;
            // 
            // cboThoiGianBaoHanh
            // 
            this.cboThoiGianBaoHanh.Location = new System.Drawing.Point(251, 159);
            this.cboThoiGianBaoHanh.Margin = new System.Windows.Forms.Padding(4);
            this.cboThoiGianBaoHanh.Name = "cboThoiGianBaoHanh";
            this.cboThoiGianBaoHanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboThoiGianBaoHanh.Properties.Appearance.Options.UseFont = true;
            this.cboThoiGianBaoHanh.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cboThoiGianBaoHanh.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboThoiGianBaoHanh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboThoiGianBaoHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboThoiGianBaoHanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboThoiGianBaoHanh.Size = new System.Drawing.Size(153, 36);
            this.cboThoiGianBaoHanh.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(412, 167);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 24);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Tháng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(67, 117);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(114, 24);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Giá Dịch vụ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 70);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 24);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Tên Dịch Vụ :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 24);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Mã Dịch Vụ :";
            // 
            // txtTenDV
            // 
            this.txtTenDV.EditValue = "";
            this.txtTenDV.Location = new System.Drawing.Point(251, 59);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTenDV.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenDV.Properties.Appearance.Options.UseFont = true;
            this.txtTenDV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTenDV.Properties.Mask.EditMask = "n0";
            this.txtTenDV.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTenDV.Size = new System.Drawing.Size(284, 36);
            this.txtTenDV.TabIndex = 1;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.EditValue = "";
            this.txtMaDichVu.Location = new System.Drawing.Point(251, 15);
            this.txtMaDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMaDichVu.Properties.Appearance.Options.UseFont = true;
            this.txtMaDichVu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMaDichVu.Size = new System.Drawing.Size(284, 36);
            this.txtMaDichVu.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.gc_Data);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 236);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1083, 433);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_Data
            // 
            this.gc_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Data.Location = new System.Drawing.Point(0, 0);
            this.gc_Data.MainView = this.gv_Data;
            this.gc_Data.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Data.Name = "gc_Data";
            this.gc_Data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_TinhTrang});
            this.gc_Data.Size = new System.Drawing.Size(1083, 433);
            this.gc_Data.TabIndex = 0;
            this.gc_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Data});
            // 
            // gv_Data
            // 
            this.gv_Data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaDV,
            this.cTenDV,
            this.cGiaDichVu,
            this.cThoiGianBH,
            this.cTinhTrang});
            this.gv_Data.DetailHeight = 431;
            this.gv_Data.GridControl = this.gc_Data;
            this.gv_Data.Name = "gv_Data";
            this.gv_Data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Data_RowClick);
            // 
            // cMaDV
            // 
            this.cMaDV.Caption = "Mã Dịch Vụ";
            this.cMaDV.FieldName = "MaDV";
            this.cMaDV.MinWidth = 25;
            this.cMaDV.Name = "cMaDV";
            this.cMaDV.OptionsColumn.AllowEdit = false;
            this.cMaDV.Visible = true;
            this.cMaDV.VisibleIndex = 0;
            this.cMaDV.Width = 133;
            // 
            // cTenDV
            // 
            this.cTenDV.Caption = "Tên Dịch Vụ";
            this.cTenDV.FieldName = "TenDV";
            this.cTenDV.MinWidth = 25;
            this.cTenDV.Name = "cTenDV";
            this.cTenDV.OptionsColumn.AllowEdit = false;
            this.cTenDV.Visible = true;
            this.cTenDV.VisibleIndex = 1;
            this.cTenDV.Width = 313;
            // 
            // cGiaDichVu
            // 
            this.cGiaDichVu.Caption = "Giá Dịch Vụ";
            this.cGiaDichVu.DisplayFormat.FormatString = "n0";
            this.cGiaDichVu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cGiaDichVu.FieldName = "GiaDichVu";
            this.cGiaDichVu.MinWidth = 25;
            this.cGiaDichVu.Name = "cGiaDichVu";
            this.cGiaDichVu.OptionsColumn.AllowEdit = false;
            this.cGiaDichVu.Visible = true;
            this.cGiaDichVu.VisibleIndex = 2;
            this.cGiaDichVu.Width = 137;
            // 
            // cThoiGianBH
            // 
            this.cThoiGianBH.Caption = "Thời Gian Bảo Hành";
            this.cThoiGianBH.FieldName = "ThoiGianBaoHanh";
            this.cThoiGianBH.MinWidth = 25;
            this.cThoiGianBH.Name = "cThoiGianBH";
            this.cThoiGianBH.OptionsColumn.AllowEdit = false;
            this.cThoiGianBH.Visible = true;
            this.cThoiGianBH.VisibleIndex = 3;
            this.cThoiGianBH.Width = 236;
            // 
            // cTinhTrang
            // 
            this.cTinhTrang.AppearanceHeader.Options.UseTextOptions = true;
            this.cTinhTrang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cTinhTrang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cTinhTrang.Caption = "Tình Trạng";
            this.cTinhTrang.ColumnEdit = this.rep_TinhTrang;
            this.cTinhTrang.FieldName = "TinhTrang";
            this.cTinhTrang.MinWidth = 25;
            this.cTinhTrang.Name = "cTinhTrang";
            this.cTinhTrang.OptionsColumn.AllowEdit = false;
            this.cTinhTrang.Visible = true;
            this.cTinhTrang.VisibleIndex = 4;
            this.cTinhTrang.Width = 244;
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
            this.btn_Clear.Location = new System.Drawing.Point(599, 37);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(183, 51);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Luu.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Luu.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Luu.Appearance.Options.UseBackColor = true;
            this.btn_Luu.Appearance.Options.UseBorderColor = true;
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Location = new System.Drawing.Point(845, 37);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(183, 51);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Xoa.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Xoa.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Appearance.Options.UseBackColor = true;
            this.btn_Xoa.Appearance.Options.UseBorderColor = true;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Location = new System.Drawing.Point(599, 104);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(183, 51);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(845, 104);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(183, 51);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // rep_TinhTrang
            // 
            this.rep_TinhTrang.AutoHeight = false;
            this.rep_TinhTrang.Name = "rep_TinhTrang";
            // 
            // frm_QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 669);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QuanLyDichVu";
            this.ShowIcon = false;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.frm_QuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboThoiGianBaoHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_TinhTrang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_Data;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Data;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenDV;
        private DevExpress.XtraEditors.TextEdit txtMaDichVu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGiaDV;
        private DevExpress.XtraEditors.ComboBoxEdit cboThoiGianBaoHanh;
        private DevExpress.XtraGrid.Columns.GridColumn cMaDV;
        private DevExpress.XtraGrid.Columns.GridColumn cTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn cGiaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn cThoiGianBH;
        private DevExpress.XtraGrid.Columns.GridColumn cTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rep_TinhTrang;
    }
}