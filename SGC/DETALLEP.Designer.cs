namespace SGC
{
    partial class DETALLEP
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DETALLEP));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PEDIDO_LINEA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BODEGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOCALIZACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRIPCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CANTIDAD_PEDIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.CANTIDAD_BONIFICAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(945, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 292);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(945, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 292);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(945, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 292);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipTitleItem1.Text = "Grabar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barButtonItem1.SuperTip = superToolTip1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 238);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de pedido";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(915, 218);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PEDIDO,
            this.PEDIDO_LINEA,
            this.BODEGA,
            this.LOTE,
            this.LOCALIZACION,
            this.ARTICULO,
            this.DESCRIPCION,
            this.CANTIDAD_PEDIDA,
            this.CANTIDAD_BONIFICAD});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // PEDIDO
            // 
            this.PEDIDO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.PEDIDO.AppearanceCell.Options.UseFont = true;
            this.PEDIDO.AppearanceCell.Options.UseTextOptions = true;
            this.PEDIDO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PEDIDO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.PEDIDO.AppearanceHeader.Options.UseFont = true;
            this.PEDIDO.AppearanceHeader.Options.UseTextOptions = true;
            this.PEDIDO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PEDIDO.Caption = "PEDIDO";
            this.PEDIDO.FieldName = "PEDIDO";
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.OptionsColumn.AllowEdit = false;
            this.PEDIDO.Visible = true;
            this.PEDIDO.VisibleIndex = 0;
            this.PEDIDO.Width = 69;
            // 
            // PEDIDO_LINEA
            // 
            this.PEDIDO_LINEA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.PEDIDO_LINEA.AppearanceCell.Options.UseFont = true;
            this.PEDIDO_LINEA.AppearanceCell.Options.UseTextOptions = true;
            this.PEDIDO_LINEA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PEDIDO_LINEA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.PEDIDO_LINEA.AppearanceHeader.Options.UseFont = true;
            this.PEDIDO_LINEA.AppearanceHeader.Options.UseTextOptions = true;
            this.PEDIDO_LINEA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PEDIDO_LINEA.Caption = "LINEA";
            this.PEDIDO_LINEA.FieldName = "PEDIDO_LINEA";
            this.PEDIDO_LINEA.Name = "PEDIDO_LINEA";
            this.PEDIDO_LINEA.OptionsColumn.AllowEdit = false;
            this.PEDIDO_LINEA.Visible = true;
            this.PEDIDO_LINEA.VisibleIndex = 1;
            this.PEDIDO_LINEA.Width = 49;
            // 
            // BODEGA
            // 
            this.BODEGA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.BODEGA.AppearanceCell.Options.UseFont = true;
            this.BODEGA.AppearanceCell.Options.UseTextOptions = true;
            this.BODEGA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BODEGA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.BODEGA.AppearanceHeader.Options.UseFont = true;
            this.BODEGA.AppearanceHeader.Options.UseTextOptions = true;
            this.BODEGA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BODEGA.Caption = "BODEGA";
            this.BODEGA.FieldName = "BODEGA";
            this.BODEGA.Name = "BODEGA";
            this.BODEGA.OptionsColumn.AllowEdit = false;
            this.BODEGA.Visible = true;
            this.BODEGA.VisibleIndex = 2;
            this.BODEGA.Width = 55;
            // 
            // LOTE
            // 
            this.LOTE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.LOTE.AppearanceCell.Options.UseFont = true;
            this.LOTE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.LOTE.AppearanceHeader.Options.UseFont = true;
            this.LOTE.Caption = "LOTE";
            this.LOTE.FieldName = "LOTE";
            this.LOTE.Name = "LOTE";
            this.LOTE.OptionsColumn.AllowEdit = false;
            this.LOTE.Visible = true;
            this.LOTE.VisibleIndex = 8;
            this.LOTE.Width = 53;
            // 
            // LOCALIZACION
            // 
            this.LOCALIZACION.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.LOCALIZACION.AppearanceCell.Options.UseFont = true;
            this.LOCALIZACION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.LOCALIZACION.AppearanceHeader.Options.UseFont = true;
            this.LOCALIZACION.Caption = "LOCALIZACIÓN";
            this.LOCALIZACION.FieldName = "LOCALIZACION";
            this.LOCALIZACION.Name = "LOCALIZACION";
            this.LOCALIZACION.OptionsColumn.AllowEdit = false;
            this.LOCALIZACION.Visible = true;
            this.LOCALIZACION.VisibleIndex = 7;
            this.LOCALIZACION.Width = 56;
            // 
            // ARTICULO
            // 
            this.ARTICULO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.ARTICULO.AppearanceCell.Options.UseFont = true;
            this.ARTICULO.AppearanceCell.Options.UseTextOptions = true;
            this.ARTICULO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ARTICULO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.ARTICULO.AppearanceHeader.Options.UseFont = true;
            this.ARTICULO.AppearanceHeader.Options.UseTextOptions = true;
            this.ARTICULO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ARTICULO.Caption = "ARTICULO";
            this.ARTICULO.FieldName = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.OptionsColumn.AllowEdit = false;
            this.ARTICULO.Visible = true;
            this.ARTICULO.VisibleIndex = 3;
            this.ARTICULO.Width = 82;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.DESCRIPCION.AppearanceCell.Options.UseFont = true;
            this.DESCRIPCION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.DESCRIPCION.AppearanceHeader.Options.UseFont = true;
            this.DESCRIPCION.Caption = "DESCRIPCIÓN";
            this.DESCRIPCION.FieldName = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.OptionsColumn.AllowEdit = false;
            this.DESCRIPCION.Visible = true;
            this.DESCRIPCION.VisibleIndex = 4;
            this.DESCRIPCION.Width = 328;
            // 
            // CANTIDAD_PEDIDA
            // 
            this.CANTIDAD_PEDIDA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.CANTIDAD_PEDIDA.AppearanceCell.Options.UseFont = true;
            this.CANTIDAD_PEDIDA.AppearanceCell.Options.UseTextOptions = true;
            this.CANTIDAD_PEDIDA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CANTIDAD_PEDIDA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 6.5F);
            this.CANTIDAD_PEDIDA.AppearanceHeader.Options.UseFont = true;
            this.CANTIDAD_PEDIDA.AppearanceHeader.Options.UseTextOptions = true;
            this.CANTIDAD_PEDIDA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CANTIDAD_PEDIDA.Caption = "CANTIDAD PED.";
            this.CANTIDAD_PEDIDA.ColumnEdit = this.repositoryItemSpinEdit1;
            this.CANTIDAD_PEDIDA.DisplayFormat.FormatString = "{0:n2}";
            this.CANTIDAD_PEDIDA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.CANTIDAD_PEDIDA.FieldName = "CANTIDAD_PEDIDA";
            this.CANTIDAD_PEDIDA.Name = "CANTIDAD_PEDIDA";
            this.CANTIDAD_PEDIDA.Visible = true;
            this.CANTIDAD_PEDIDA.VisibleIndex = 5;
            this.CANTIDAD_PEDIDA.Width = 105;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.ValueChanged += new System.EventHandler(this.repositoryItemSpinEdit1_ValueChanged);
            this.repositoryItemSpinEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemSpinEdit1_EditValueChanged);
            this.repositoryItemSpinEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repositoryItemSpinEdit1_KeyPress);
            this.repositoryItemSpinEdit1.Leave += new System.EventHandler(this.repositoryItemSpinEdit1_Leave);
            // 
            // CANTIDAD_BONIFICAD
            // 
            this.CANTIDAD_BONIFICAD.Caption = "CANTIDAD BONIF";
            this.CANTIDAD_BONIFICAD.DisplayFormat.FormatString = "{0:n2}";
            this.CANTIDAD_BONIFICAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.CANTIDAD_BONIFICAD.FieldName = "CANTIDAD_BONIFICAD";
            this.CANTIDAD_BONIFICAD.Name = "CANTIDAD_BONIFICAD";
            this.CANTIDAD_BONIFICAD.Visible = true;
            this.CANTIDAD_BONIFICAD.VisibleIndex = 6;
            this.CANTIDAD_BONIFICAD.Width = 97;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(12, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 29);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Duplicar linea";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(106, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 29);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Eliminar linea";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DETALLEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 292);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DETALLEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de pedido";
            this.Load += new System.EventHandler(this.DETALLEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn PEDIDO;
        private DevExpress.XtraGrid.Columns.GridColumn PEDIDO_LINEA;
        private DevExpress.XtraGrid.Columns.GridColumn BODEGA;
        private DevExpress.XtraGrid.Columns.GridColumn LOTE;
        private DevExpress.XtraGrid.Columns.GridColumn LOCALIZACION;
        private DevExpress.XtraGrid.Columns.GridColumn ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRIPCION;
        private DevExpress.XtraGrid.Columns.GridColumn CANTIDAD_PEDIDA;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn CANTIDAD_BONIFICAD;
    }
}