namespace SGC
{
    partial class LOCALIZACIONF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOCALIZACIONF));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MONEDA_FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTAL_FACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOMBRE_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UBICACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            toolTipTitleItem1.Text = "Refrescar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barButtonItem4.SuperTip = superToolTip1;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipTitleItem2.Text = "Cambiar ubicación";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.barButtonItem1.SuperTip = superToolTip2;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            toolTipTitleItem3.Text = "Asignar cobrador";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.barButtonItem3.SuperTip = superToolTip3;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(988, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(988, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(988, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            toolTipTitleItem4.Text = "Refrescar";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.barButtonItem2.SuperTip = superToolTip4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 521);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factruas";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(6, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(952, 495);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FACTURA,
            this.FECHA,
            this.MONEDA_FACTURA,
            this.TOTAL_FACTURA,
            this.CLIENTE,
            this.NOMBRE_CLIENTE,
            this.UBICACION,
            this.VENDEDOR});
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
            this.FACTURA.Width = 87;
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
            this.FECHA.Width = 88;
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
            this.MONEDA_FACTURA.VisibleIndex = 3;
            this.MONEDA_FACTURA.Width = 91;
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
            this.TOTAL_FACTURA.VisibleIndex = 4;
            this.TOTAL_FACTURA.Width = 92;
            // 
            // CLIENTE
            // 
            this.CLIENTE.AppearanceCell.Options.UseTextOptions = true;
            this.CLIENTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CLIENTE.AppearanceHeader.Options.UseTextOptions = true;
            this.CLIENTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CLIENTE.Caption = "CLIENTE";
            this.CLIENTE.FieldName = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.OptionsColumn.AllowEdit = false;
            this.CLIENTE.Visible = true;
            this.CLIENTE.VisibleIndex = 5;
            this.CLIENTE.Width = 90;
            // 
            // NOMBRE_CLIENTE
            // 
            this.NOMBRE_CLIENTE.Caption = "NOMBRE CLIENTE";
            this.NOMBRE_CLIENTE.FieldName = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.OptionsColumn.AllowEdit = false;
            this.NOMBRE_CLIENTE.Visible = true;
            this.NOMBRE_CLIENTE.VisibleIndex = 6;
            this.NOMBRE_CLIENTE.Width = 357;
            // 
            // UBICACION
            // 
            this.UBICACION.AppearanceCell.Options.UseTextOptions = true;
            this.UBICACION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UBICACION.AppearanceHeader.Options.UseTextOptions = true;
            this.UBICACION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UBICACION.Caption = "UBICACION";
            this.UBICACION.FieldName = "UBICACION";
            this.UBICACION.Name = "UBICACION";
            this.UBICACION.OptionsColumn.AllowEdit = false;
            this.UBICACION.Visible = true;
            this.UBICACION.VisibleIndex = 8;
            this.UBICACION.Width = 91;
            // 
            // VENDEDOR
            // 
            this.VENDEDOR.AppearanceCell.Options.UseTextOptions = true;
            this.VENDEDOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VENDEDOR.AppearanceHeader.Options.UseTextOptions = true;
            this.VENDEDOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VENDEDOR.Caption = "VENDEDOR";
            this.VENDEDOR.FieldName = "VENDEDOR";
            this.VENDEDOR.Name = "VENDEDOR";
            this.VENDEDOR.OptionsColumn.AllowEdit = false;
            this.VENDEDOR.Visible = true;
            this.VENDEDOR.VisibleIndex = 7;
            this.VENDEDOR.Width = 94;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Facturación",
            "Almacen",
            "Cuentas por cobrar"});
            this.comboBox1.Location = new System.Drawing.Point(15, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 52);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ubicación";
            // 
            // LOCALIZACIONF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOCALIZACIONF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones / remitir facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOCALIZACIONF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn FACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn MONEDA_FACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn TOTAL_FACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn NOMBRE_CLIENTE;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Columns.GridColumn UBICACION;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.Columns.GridColumn VENDEDOR;
    }
}