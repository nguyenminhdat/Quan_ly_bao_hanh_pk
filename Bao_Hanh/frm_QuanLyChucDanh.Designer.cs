namespace Bao_Hanh
{
    partial class frm_QuanLyChucDanh
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
            this.txt_GhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenChucDanh = new DevExpress.XtraEditors.TextEdit();
            this.txtMaChucDanh = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Data = new DevExpress.XtraGrid.GridControl();
            this.gv_Data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cMaChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTenChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_TinhTrang = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChucDanh.Properties)).BeginInit();
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
            this.panelControl1.Controls.Add(this.txt_GhiChu);
            this.panelControl1.Controls.Add(this.btn_TimKiem);
            this.panelControl1.Controls.Add(this.btn_Luu);
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtTenChucDanh);
            this.panelControl1.Controls.Add(this.txtMaChucDanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1083, 236);
            this.panelControl1.TabIndex = 0;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(251, 103);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(284, 100);
            this.txt_GhiChu.TabIndex = 48;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(845, 103);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(183, 50);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
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
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(183, 50);
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
            this.btn_Xoa.Location = new System.Drawing.Point(599, 103);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(183, 50);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(183, 50);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(67, 117);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 24);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Ghi chú :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 70);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 24);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Tên chức danh :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 24);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Mã chức danh :";
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.EditValue = "";
            this.txtTenChucDanh.Location = new System.Drawing.Point(251, 59);
            this.txtTenChucDanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenChucDanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTenChucDanh.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenChucDanh.Properties.Appearance.Options.UseFont = true;
            this.txtTenChucDanh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTenChucDanh.Properties.Mask.EditMask = "n0";
            this.txtTenChucDanh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTenChucDanh.Size = new System.Drawing.Size(284, 36);
            this.txtTenChucDanh.TabIndex = 1;
            // 
            // txtMaChucDanh
            // 
            this.txtMaChucDanh.EditValue = "";
            this.txtMaChucDanh.Location = new System.Drawing.Point(251, 15);
            this.txtMaChucDanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaChucDanh.Name = "txtMaChucDanh";
            this.txtMaChucDanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMaChucDanh.Properties.Appearance.Options.UseFont = true;
            this.txtMaChucDanh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMaChucDanh.Size = new System.Drawing.Size(284, 36);
            this.txtMaChucDanh.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.gc_Data);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 236);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1083, 434);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_Data
            // 
            this.gc_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc_Data.Location = new System.Drawing.Point(0, 0);
            this.gc_Data.MainView = this.gv_Data;
            this.gc_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gc_Data.Name = "gc_Data";
            this.gc_Data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_TinhTrang});
            this.gc_Data.Size = new System.Drawing.Size(1083, 434);
            this.gc_Data.TabIndex = 0;
            this.gc_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Data});
            // 
            // gv_Data
            // 
            this.gv_Data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cMaChucDanh,
            this.cTenChucDanh,
            this.cGhiChu});
            this.gv_Data.DetailHeight = 431;
            this.gv_Data.GridControl = this.gc_Data;
            this.gv_Data.Name = "gv_Data";
            this.gv_Data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Data_RowClick);
            // 
            // cMaChucDanh
            // 
            this.cMaChucDanh.Caption = "Mã chuc danh";
            this.cMaChucDanh.FieldName = "MaChucDanh";
            this.cMaChucDanh.MinWidth = 25;
            this.cMaChucDanh.Name = "cMaChucDanh";
            this.cMaChucDanh.OptionsColumn.AllowEdit = false;
            this.cMaChucDanh.Visible = true;
            this.cMaChucDanh.VisibleIndex = 0;
            this.cMaChucDanh.Width = 133;
            // 
            // cTenChucDanh
            // 
            this.cTenChucDanh.Caption = "Tên chức danh";
            this.cTenChucDanh.FieldName = "TenChucDanh";
            this.cTenChucDanh.MinWidth = 25;
            this.cTenChucDanh.Name = "cTenChucDanh";
            this.cTenChucDanh.OptionsColumn.AllowEdit = false;
            this.cTenChucDanh.Visible = true;
            this.cTenChucDanh.VisibleIndex = 1;
            this.cTenChucDanh.Width = 313;
            // 
            // cGhiChu
            // 
            this.cGhiChu.Caption = "Ghi chú";
            this.cGhiChu.FieldName = "GhiChu";
            this.cGhiChu.MinWidth = 27;
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.Visible = true;
            this.cGhiChu.VisibleIndex = 2;
            this.cGhiChu.Width = 100;
            // 
            // rep_TinhTrang
            // 
            this.rep_TinhTrang.AutoHeight = false;
            this.rep_TinhTrang.Name = "rep_TinhTrang";
            // 
            // frm_QuanLyChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_QuanLyChucDanh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý chức danh";
            this.Load += new System.EventHandler(this.frm_QuanLyChucDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChucDanh.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtTenChucDanh;
        private DevExpress.XtraEditors.TextEdit txtMaChucDanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn cMaChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn cTenChucDanh;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rep_TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn cGhiChu;
        private DevExpress.XtraEditors.MemoEdit txt_GhiChu;
    }
}