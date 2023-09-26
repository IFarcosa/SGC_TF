namespace SGC
{
    partial class ELOTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELOTE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BODEGA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOCALIZACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FECHA_VENCIMIENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CANT_DISPONIBLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existencia lote";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(6, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(412, 173);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BODEGA,
            this.LOCALIZACION,
            this.LOTE,
            this.FECHA_VENCIMIENTO,
            this.CANT_DISPONIBLE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BODEGA
            // 
            this.BODEGA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.BODEGA.AppearanceCell.Options.UseFont = true;
            this.BODEGA.AppearanceCell.Options.UseTextOptions = true;
            this.BODEGA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BODEGA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7F);
            this.BODEGA.AppearanceHeader.Options.UseFont = true;
            this.BODEGA.AppearanceHeader.Options.UseTextOptions = true;
            this.BODEGA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BODEGA.Caption = "BODEGA";
            this.BODEGA.FieldName = "BODEGA";
            this.BODEGA.Name = "BODEGA";
            this.BODEGA.OptionsColumn.AllowEdit = false;
            this.BODEGA.Visible = true;
            this.BODEGA.VisibleIndex = 0;
            this.BODEGA.Width = 137;
            // 
            // LOCALIZACION
            // 
            this.LOCALIZACION.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.LOCALIZACION.AppearanceCell.Options.UseFont = true;
            this.LOCALIZACION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7F);
            this.LOCALIZACION.AppearanceHeader.Options.UseFont = true;
            this.LOCALIZACION.Caption = "LOCALIZACIÓN";
            this.LOCALIZACION.FieldName = "LOCALIZACION";
            this.LOCALIZACION.Name = "LOCALIZACION";
            this.LOCALIZACION.OptionsColumn.AllowEdit = false;
            this.LOCALIZACION.Visible = true;
            this.LOCALIZACION.VisibleIndex = 1;
            this.LOCALIZACION.Width = 229;
            // 
            // LOTE
            // 
            this.LOTE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.LOTE.AppearanceCell.Options.UseFont = true;
            this.LOTE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7F);
            this.LOTE.AppearanceHeader.Options.UseFont = true;
            this.LOTE.Caption = "LOTE";
            this.LOTE.FieldName = "LOTE";
            this.LOTE.Name = "LOTE";
            this.LOTE.OptionsColumn.AllowEdit = false;
            this.LOTE.Visible = true;
            this.LOTE.VisibleIndex = 2;
            this.LOTE.Width = 251;
            // 
            // FECHA_VENCIMIENTO
            // 
            this.FECHA_VENCIMIENTO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.FECHA_VENCIMIENTO.AppearanceCell.Options.UseFont = true;
            this.FECHA_VENCIMIENTO.AppearanceCell.Options.UseTextOptions = true;
            this.FECHA_VENCIMIENTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA_VENCIMIENTO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7F);
            this.FECHA_VENCIMIENTO.AppearanceHeader.Options.UseFont = true;
            this.FECHA_VENCIMIENTO.AppearanceHeader.Options.UseTextOptions = true;
            this.FECHA_VENCIMIENTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FECHA_VENCIMIENTO.Caption = "FECHA VENC.";
            this.FECHA_VENCIMIENTO.FieldName = "FECHA_VENCIMIENTO";
            this.FECHA_VENCIMIENTO.Name = "FECHA_VENCIMIENTO";
            this.FECHA_VENCIMIENTO.OptionsColumn.AllowEdit = false;
            this.FECHA_VENCIMIENTO.Visible = true;
            this.FECHA_VENCIMIENTO.VisibleIndex = 3;
            this.FECHA_VENCIMIENTO.Width = 229;
            // 
            // CANT_DISPONIBLE
            // 
            this.CANT_DISPONIBLE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.CANT_DISPONIBLE.AppearanceCell.Options.UseFont = true;
            this.CANT_DISPONIBLE.AppearanceCell.Options.UseTextOptions = true;
            this.CANT_DISPONIBLE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CANT_DISPONIBLE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7F);
            this.CANT_DISPONIBLE.AppearanceHeader.Options.UseFont = true;
            this.CANT_DISPONIBLE.AppearanceHeader.Options.UseTextOptions = true;
            this.CANT_DISPONIBLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CANT_DISPONIBLE.Caption = "CANT. DISPONIBLE";
            this.CANT_DISPONIBLE.DisplayFormat.FormatString = "{0:n2}";
            this.CANT_DISPONIBLE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.CANT_DISPONIBLE.FieldName = "CANT_DISPONIBLE";
            this.CANT_DISPONIBLE.Name = "CANT_DISPONIBLE";
            this.CANT_DISPONIBLE.OptionsColumn.AllowEdit = false;
            this.CANT_DISPONIBLE.Visible = true;
            this.CANT_DISPONIBLE.VisibleIndex = 4;
            this.CANT_DISPONIBLE.Width = 219;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(419, 48);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(250, 12);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(157, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(51, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(156, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(419, 48);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(199, 28);
            this.layoutControlItem1.Text = "Pedido:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(199, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 28);
            this.layoutControlItem2.Text = "Linea:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 13);
            // 
            // ELOTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ELOTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Existencia lote";
            this.Load += new System.EventHandler(this.ELOTEcs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn BODEGA;
        private DevExpress.XtraGrid.Columns.GridColumn LOCALIZACION;
        private DevExpress.XtraGrid.Columns.GridColumn LOTE;
        private DevExpress.XtraGrid.Columns.GridColumn CANT_DISPONIBLE;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        public DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn FECHA_VENCIMIENTO;
    }
}