namespace SGC
{
    partial class APEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APEDIDOS));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FECHA_PEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CONFIRMADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOMBRE_CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MONEDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VENDEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.EditValue = "Cuentas por cobrar";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(9, 24);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DarkBlue;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Size = new System.Drawing.Size(831, 30);
            this.textEdit1.TabIndex = 23;
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
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
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
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            toolTipTitleItem2.Text = "Estado de cuenta";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.barButtonItem3.SuperTip = superToolTip2;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            toolTipTitleItem3.Text = "Confirmar pedido";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.barButtonItem5.SuperTip = superToolTip3;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(848, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(848, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(848, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(9, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 550);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.gridControl1.Size = new System.Drawing.Size(819, 524);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PEDIDO,
            this.FECHA_PEDIDO,
            this.ESTADO,
            this.CONFIRMADO,
            this.CLIENTE,
            this.NOMBRE_CLIENTE,
            this.MONEDA,
            this.TOTAL,
            this.VENDEDOR});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(2017, 506, 266, 243);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // PEDIDO
            // 
            this.PEDIDO.AppearanceCell.Options.UseTextOptions = true;
            this.PEDIDO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PEDIDO.AppearanceHeader.Options.UseTextOptions = true;
            this.PEDIDO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PEDIDO.Caption = "PEDIDO";
            this.PEDIDO.FieldName = "PEDIDO";
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.OptionsColumn.AllowEdit = false;
            this.PEDIDO.Visible = true;
            this.PEDIDO.VisibleIndex = 0;
            this.PEDIDO.Width = 103;
            // 
            // FECHA_PEDIDO
            // 
            this.FECHA_PEDIDO.AppearanceCell.Options.UseTextOptions = true;
            this.FECHA_PEDIDO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA_PEDIDO.AppearanceHeader.Options.UseTextOptions = true;
            this.FECHA_PEDIDO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA_PEDIDO.Caption = "FECHA PEDIDO";
            this.FECHA_PEDIDO.FieldName = "FECHA_PEDIDO";
            this.FECHA_PEDIDO.Name = "FECHA_PEDIDO";
            this.FECHA_PEDIDO.OptionsColumn.AllowEdit = false;
            this.FECHA_PEDIDO.Visible = true;
            this.FECHA_PEDIDO.VisibleIndex = 1;
            this.FECHA_PEDIDO.Width = 113;
            // 
            // ESTADO
            // 
            this.ESTADO.AppearanceCell.Options.UseTextOptions = true;
            this.ESTADO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ESTADO.AppearanceHeader.Options.UseTextOptions = true;
            this.ESTADO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ESTADO.Caption = "ESTADO";
            this.ESTADO.FieldName = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.OptionsColumn.AllowEdit = false;
            this.ESTADO.Visible = true;
            this.ESTADO.VisibleIndex = 2;
            this.ESTADO.Width = 108;
            // 
            // CONFIRMADO
            // 
            this.CONFIRMADO.AppearanceCell.Options.UseTextOptions = true;
            this.CONFIRMADO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CONFIRMADO.AppearanceHeader.Options.UseTextOptions = true;
            this.CONFIRMADO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CONFIRMADO.Caption = "CONFIRMADO";
            this.CONFIRMADO.FieldName = "CONFIRMADO";
            this.CONFIRMADO.Name = "CONFIRMADO";
            this.CONFIRMADO.OptionsColumn.AllowEdit = false;
            this.CONFIRMADO.Visible = true;
            this.CONFIRMADO.VisibleIndex = 3;
            this.CONFIRMADO.Width = 106;
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
            this.CLIENTE.VisibleIndex = 4;
            this.CLIENTE.Width = 107;
            // 
            // NOMBRE_CLIENTE
            // 
            this.NOMBRE_CLIENTE.Caption = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.FieldName = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.OptionsColumn.AllowEdit = false;
            this.NOMBRE_CLIENTE.Visible = true;
            this.NOMBRE_CLIENTE.VisibleIndex = 5;
            this.NOMBRE_CLIENTE.Width = 330;
            // 
            // MONEDA
            // 
            this.MONEDA.AppearanceCell.Options.UseTextOptions = true;
            this.MONEDA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MONEDA.AppearanceHeader.Options.UseTextOptions = true;
            this.MONEDA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MONEDA.Caption = "MONEDA";
            this.MONEDA.FieldName = "MONEDA";
            this.MONEDA.Name = "MONEDA";
            this.MONEDA.OptionsColumn.AllowEdit = false;
            this.MONEDA.Visible = true;
            this.MONEDA.VisibleIndex = 6;
            this.MONEDA.Width = 98;
            // 
            // TOTAL
            // 
            this.TOTAL.AppearanceCell.Options.UseTextOptions = true;
            this.TOTAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TOTAL.AppearanceHeader.Options.UseTextOptions = true;
            this.TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TOTAL.Caption = "TOTAL";
            this.TOTAL.DisplayFormat.FormatString = "{0:n2}";
            this.TOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TOTAL.FieldName = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.OptionsColumn.AllowEdit = false;
            this.TOTAL.Visible = true;
            this.TOTAL.VisibleIndex = 7;
            this.TOTAL.Width = 100;
            // 
            // VENDEDOR
            // 
            this.VENDEDOR.Caption = "VENDEDOR";
            this.VENDEDOR.FieldName = "VENDEDOR";
            this.VENDEDOR.Name = "VENDEDOR";
            this.VENDEDOR.Visible = true;
            this.VENDEDOR.VisibleIndex = 8;
            // 
            // APEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APEDIDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones / cuentas por cobrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.APEDIDOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PEDIDO;
        private DevExpress.XtraGrid.Columns.GridColumn ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn CONFIRMADO;
        private DevExpress.XtraGrid.Columns.GridColumn CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn NOMBRE_CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn FECHA_PEDIDO;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraGrid.Columns.GridColumn MONEDA;
        private DevExpress.XtraGrid.Columns.GridColumn TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn VENDEDOR;
    }
}