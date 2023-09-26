namespace SGC
{
    partial class PEDIDOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PEDIDOS));
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.PEDIDO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.FECHA_PEDIDO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ESTADO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CONFIRMADO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CLIENTE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.NOMBRE_CLIENTE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ZONA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.USUARIO_BOD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.FECHA_BOD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.HORA_BOD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            this.barButtonItem4,
            this.barButtonItem3 });
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
            toolTipTitleItem4.Text = "Refrescar";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.barButtonItem4.SuperTip = superToolTip4;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipTitleItem5.Text = "Asignar usuario";
            superToolTip5.Items.Add(toolTipTitleItem5);
            this.barButtonItem1.SuperTip = superToolTip5;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            toolTipTitleItem6.Text = "Aprobar pedido";
            superToolTip6.Items.Add(toolTipTitleItem6);
            this.barButtonItem3.SuperTip = superToolTip6;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem2
            //
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
            this.textEdit1.EditValue = "Almacen";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(8, 28);
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
            this.textEdit1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 546);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(6, 20);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(841, 520);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.PEDIDO,
            this.FECHA_PEDIDO,
            this.ESTADO,
            this.CONFIRMADO,
            this.CLIENTE,
            this.NOMBRE_CLIENTE,
            this.USUARIO_BOD,
            this.FECHA_BOD,
            this.HORA_BOD,
            this.ZONA});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.PEDIDO);
            this.gridBand1.Columns.Add(this.FECHA_PEDIDO);
            this.gridBand1.Columns.Add(this.ESTADO);
            this.gridBand1.Columns.Add(this.CONFIRMADO);
            this.gridBand1.Columns.Add(this.CLIENTE);
            this.gridBand1.Columns.Add(this.NOMBRE_CLIENTE);
            this.gridBand1.Columns.Add(this.ZONA);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 763;
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
            this.PEDIDO.Width = 82;
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
            this.FECHA_PEDIDO.Width = 86;
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
            this.ESTADO.Width = 84;
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
            this.CONFIRMADO.Width = 83;
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
            this.CLIENTE.Width = 89;
            // 
            // NOMBRE_CLIENTE
            // 
            this.NOMBRE_CLIENTE.Caption = "NOMBRE CLIENTE";
            this.NOMBRE_CLIENTE.FieldName = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.Name = "NOMBRE_CLIENTE";
            this.NOMBRE_CLIENTE.OptionsColumn.AllowEdit = false;
            this.NOMBRE_CLIENTE.Visible = true;
            this.NOMBRE_CLIENTE.Width = 250;
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
            this.ZONA.Width = 89;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "ALISTO Y DESPACHO";
            this.gridBand2.Columns.Add(this.USUARIO_BOD);
            this.gridBand2.Columns.Add(this.FECHA_BOD);
            this.gridBand2.Columns.Add(this.HORA_BOD);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 214;
            // 
            // USUARIO_BOD
            // 
            this.USUARIO_BOD.Caption = "USUARIO";
            this.USUARIO_BOD.FieldName = "USUARIO_BOD";
            this.USUARIO_BOD.Name = "USUARIO_BOD";
            this.USUARIO_BOD.OptionsColumn.AllowEdit = false;
            this.USUARIO_BOD.Visible = true;
            this.USUARIO_BOD.Width = 74;
            // 
            // FECHA_BOD
            // 
            this.FECHA_BOD.AppearanceCell.Options.UseTextOptions = true;
            this.FECHA_BOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA_BOD.AppearanceHeader.Options.UseTextOptions = true;
            this.FECHA_BOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA_BOD.Caption = "FECHA";
            this.FECHA_BOD.FieldName = "FECHA_BOD";
            this.FECHA_BOD.Name = "FECHA_BOD";
            this.FECHA_BOD.OptionsColumn.AllowEdit = false;
            this.FECHA_BOD.Visible = true;
            this.FECHA_BOD.Width = 73;
            // 
            // HORA_BOD
            // 
            this.HORA_BOD.AppearanceCell.Options.UseTextOptions = true;
            this.HORA_BOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HORA_BOD.AppearanceHeader.Options.UseTextOptions = true;
            this.HORA_BOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HORA_BOD.Caption = "HORA";
            this.HORA_BOD.FieldName = "HORA_BOD";
            this.HORA_BOD.Name = "HORA_BOD";
            this.HORA_BOD.OptionsColumn.AllowEdit = false;
            this.HORA_BOD.Visible = true;
            this.HORA_BOD.Width = 67;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PEDIDOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones / Almacen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PEDIDOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PEDIDO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn FECHA_PEDIDO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ESTADO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CONFIRMADO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CLIENTE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NOMBRE_CLIENTE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn USUARIO_BOD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn FECHA_BOD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn HORA_BOD;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ZONA;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
     
    }
}