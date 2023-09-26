namespace SGC
{
    partial class HOJAR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOJAR));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOMBRE_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MONEDA_FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTAL_FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ZONA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIRECCION_FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            toolTipTitleItem1.Text = "Refrescar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barButtonItem2.SuperTip = superToolTip1;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipTitleItem2.Text = "Grabar hoja de ruta";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.barButtonItem1.SuperTip = superToolTip2;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(870, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(870, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 596);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(870, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.EditValue = "Hoja de ruta";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(8, 24);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DarkBlue;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Size = new System.Drawing.Size(853, 30);
            this.textEdit1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(8, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 559);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturas";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(6, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(841, 536);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FACTURA,
            this.FECHA,
            this.NOMBRE_CLIENTE,
            this.MONEDA_FACTURA,
            this.TOTAL_FACTURA,
            this.ZONA,
            this.DIRECCION_FACTURA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FACTURA
            // 
            this.FACTURA.AppearanceCell.Options.UseTextOptions = true;
            this.FACTURA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FACTURA.AppearanceHeader.Options.UseTextOptions = true;
            this.FACTURA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FACTURA.Caption = "FACTURA";
            this.FACTURA.FieldName = "FACTURA";
            this.FACTURA.Name = "FACTURA";
            this.FACTURA.OptionsColumn.AllowEdit = false;
            this.FACTURA.Visible = true;
            this.FACTURA.VisibleIndex = 1;
            this.FACTURA.Width = 83;
            // 
            // FECHA
            // 
            this.FECHA.AppearanceCell.Options.UseTextOptions = true;
            this.FECHA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA.AppearanceHeader.Options.UseTextOptions = true;
            this.FECHA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA.Caption = "FECHA";
            this.FECHA.FieldName = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.OptionsColumn.AllowEdit = false;
            this.FECHA.Visible = true;
            this.FECHA.VisibleIndex = 2;
            this.FECHA.Width = 87;
            // 
            // NOMBRE_CLIENTE
            // 
            this.NOMBRE_CLIENTE.Caption = "NOMBRE";
            this.NOMBRE_CLIENTE.FieldName = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.OptionsColumn.AllowEdit = false;
            this.NOMBRE_CLIENTE.Visible = true;
            this.NOMBRE_CLIENTE.VisibleIndex = 3;
            this.NOMBRE_CLIENTE.Width = 288;
            // 
            // MONEDA_FACTURA
            // 
            this.MONEDA_FACTURA.AppearanceCell.Options.UseTextOptions = true;
            this.MONEDA_FACTURA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MONEDA_FACTURA.AppearanceHeader.Options.UseTextOptions = true;
            this.MONEDA_FACTURA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MONEDA_FACTURA.Caption = "MONEDA";
            this.MONEDA_FACTURA.FieldName = "MONEDA_FACTURA";
            this.MONEDA_FACTURA.Name = "MONEDA_FACTURA";
            this.MONEDA_FACTURA.OptionsColumn.AllowEdit = false;
            this.MONEDA_FACTURA.Visible = true;
            this.MONEDA_FACTURA.VisibleIndex = 4;
            this.MONEDA_FACTURA.Width = 84;
            // 
            // TOTAL_FACTURA
            // 
            this.TOTAL_FACTURA.AppearanceCell.Options.UseTextOptions = true;
            this.TOTAL_FACTURA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TOTAL_FACTURA.AppearanceHeader.Options.UseTextOptions = true;
            this.TOTAL_FACTURA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TOTAL_FACTURA.Caption = "TOTAL";
            this.TOTAL_FACTURA.DisplayFormat.FormatString = "{0:n2}";
            this.TOTAL_FACTURA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TOTAL_FACTURA.FieldName = "TOTAL_FACTURA";
            this.TOTAL_FACTURA.Name = "TOTAL_FACTURA";
            this.TOTAL_FACTURA.OptionsColumn.AllowEdit = false;
            this.TOTAL_FACTURA.Visible = true;
            this.TOTAL_FACTURA.VisibleIndex = 5;
            this.TOTAL_FACTURA.Width = 86;
            // 
            // ZONA
            // 
            this.ZONA.AppearanceCell.Options.UseTextOptions = true;
            this.ZONA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZONA.AppearanceHeader.Options.UseTextOptions = true;
            this.ZONA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ZONA.Caption = "ZONA";
            this.ZONA.FieldName = "ZONA";
            this.ZONA.Name = "ZONA";
            this.ZONA.OptionsColumn.AllowEdit = false;
            this.ZONA.Visible = true;
            this.ZONA.VisibleIndex = 6;
            this.ZONA.Width = 117;
            // 
            // DIRECCION_FACTURA
            // 
            this.DIRECCION_FACTURA.Caption = "DIRECCIÓN";
            this.DIRECCION_FACTURA.FieldName = "DIRECCION_FACTURA";
            this.DIRECCION_FACTURA.Name = "DIRECCION_FACTURA";
            this.DIRECCION_FACTURA.OptionsColumn.AllowEdit = false;
            this.DIRECCION_FACTURA.Visible = true;
            this.DIRECCION_FACTURA.VisibleIndex = 7;
            this.DIRECCION_FACTURA.Width = 245;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // HOJAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOJAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones / hoja de ruta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HOJAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn FACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn MONEDA_FACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn TOTAL_FACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn NOMBRE_CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn ZONA;
        private DevExpress.XtraGrid.Columns.GridColumn DIRECCION_FACTURA;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}