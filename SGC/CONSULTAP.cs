using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace SGC
{
    public partial class CONSULTAP : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static CONSULTAP form;
        public  static CONSULTAP ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new CONSULTAP();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public CONSULTAP()
        {
            InitializeComponent();
        }

        private void CONSULTAP_Load(object sender, EventArgs e)
        {
                     
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // BTN AUDITORIA
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    String PEDIDO = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString();

                    // PEDIDO                
                    AUDITORIAP.ins.textEdit3.Text = PEDIDO;
                    AUDITORIAP.ins.textEdit4.Text = SQL.SCALAR(String.Format("SELECT FECHA_HORA FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    AUDITORIAP.ins.textEdit5.Text = SQL.SCALAR(String.Format("SELECT USUARIO FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    // ASIGNACION
                    AUDITORIAP.ins.textEdit6.Text = SQL.SCALAR(String.Format("SELECT USUARIO_BOD FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    AUDITORIAP.ins.textEdit7.Text = SQL.SCALAR(String.Format("SELECT FECHA_BOD FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    // CONFIRMACION
                    AUDITORIAP.ins.textEdit9.Text  = SQL.SCALAR(String.Format("SELECT USUARIO_CONFIRMACION FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    AUDITORIAP.ins.textEdit10.Text = SQL.SCALAR(String.Format("SELECT FECHA_CONFIRMACION FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    // APROBACION
                    AUDITORIAP.ins.textEdit12.Text = SQL.SCALAR(String.Format("SELECT USUARIO_APROBACION FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    AUDITORIAP.ins.textEdit13.Text = SQL.SCALAR(String.Format("SELECT FECHA_APROBACION FROM FARCOSA.PEDIDO WHERE PEDIDO = '{0}' ", PEDIDO));
                    // FACTURA
                    //AUDITORIAP.ins.textEdit2.Text  = SQL.SCALAR(String.Format("SELECT FACTURA FROM MECHNIKOV.FACTURA WHERE PEDIDO = '{0}' ", PEDIDO));
                    //AUDITORIAP.ins.textEdit15.Text = SQL.SCALAR(String.Format("SELECT FECHA FROM MECHNIKOV.FACTURA WHERE PEDIDO = '{0}' ", PEDIDO));
                    //AUDITORIAP.ins.textEdit8.Text  = SQL.SCALAR(String.Format("SELECT USUARIO FROM MECHNIKOV.FACTURA WHERE PEDIDO = '{0}' ", PEDIDO));

                    AUDITORIAP.ins.ShowDialog();
                }
            }

            catch (NullReferenceException)
            {

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // REFRESCAR FECHAS
            try
            {

                if (String.IsNullOrEmpty(dateEdit1.Text) || String.IsNullOrEmpty(dateEdit2.Text))
                {
                    MessageBox.Show("Verificar que los campos <fecha inicio> y <fecha fin> no se encuentran vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    String FINICIO = Convert.ToDateTime(dateEdit1.EditValue).ToString("yyyyMMdd");
                    String FFIN = Convert.ToDateTime(dateEdit2.EditValue).ToString("yyyyMMdd");

                    String QUERY01 = String.Format(" SELECT	  PED.PEDIDO, " +
                                                            " CONVERT(date, PED.FECHA_PEDIDO) AS FECHA_PEDIDO, " +
                                                            " CASE WHEN PED.ESTADO = 'A' THEN 'Aprobado'  ELSE CASE WHEN PED.ESTADO = 'B' THEN 'Backorder' ELSE " +
                                                            " CASE WHEN PED.ESTADO = 'C' THEN 'Cancelado' ELSE CASE WHEN PED.ESTADO = 'F' THEN 'Facturado' ELSE " +
                                                            " CASE WHEN PED.ESTADO = 'N' THEN 'Normal' ELSE 'No definido' END END END END END AS ESTADO, " +
                                                            " PED.CLIENTE, PED.NOMBRE_CLIENTE, " +
                                                            " FAC.FACTURA, FAC.FECHA AS FECHA_FACTURA " +
                                                   " FROM     FARCOSA.PEDIDO AS PED LEFT JOIN FARCOSA.FACTURA AS FAC ON PED.PEDIDO = FAC.PEDIDO " +
                                                   " WHERE    CONVERT(date, PED.FECHA_PEDIDO) BETWEEN '{0}' AND '{1}' " +
                                                   " ORDER    BY PED.FECHA_PEDIDO, PED.PEDIDO ASC ", FINICIO, FFIN);
                    gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
                }

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateEdit1_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dateEdit1.Text) || String.IsNullOrEmpty(dateEdit2.Text))
            {

            }

            else
            {
                DateTime DI = Convert.ToDateTime(dateEdit1.EditValue.ToString());
                DateTime DF = Convert.ToDateTime(dateEdit2.EditValue.ToString());
                int RESULTADO = DateTime.Compare(DI, DF);

                if (RESULTADO > 0)
                {
                    MessageBox.Show("La <fecha inicio> no puede ser mayor a la <fecha finalización>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateEdit1.Focus();
                }

            }

        }

        private void dateEdit2_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dateEdit1.Text) || String.IsNullOrEmpty(dateEdit2.Text))
            {

            }

            else
            {
                DateTime DI = Convert.ToDateTime(dateEdit1.EditValue.ToString());
                DateTime DF = Convert.ToDateTime(dateEdit2.EditValue.ToString());
                int RESULTADO = DateTime.Compare(DI, DF);

                if (RESULTADO > 0)
                {
                    MessageBox.Show("La <fecha finalización> no puede ser menor a la <fecha inicio>", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateEdit2.Focus();
                }

            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {

                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    // SE GENERA REPORTE DE PEDIDO (REPORTE1)
                    String PEDIDOR = String.Format(" SELECT  PEDL.PEDIDO, PED.FECHA_HORA, " +
                                                           " PED.USUARIO_BOD, PED.FECHA_BOD, " +
                                                           " PEDL.PEDIDO_LINEA, PEDL.ARTICULO, ALO.DESCRIPCION, ALO.UNIDAD_ALMACEN, " +
                                                           " PEDL.LOTE, L.FECHA_VENCIMIENTO, PEDL.LOCALIZACION, " +
                                                           " CONVERT(decimal(28, 2), PEDL.CANTIDAD_PEDIDA) AS CANTIDAD_PEDIDA, " +
                                                           " CONVERT(decimal(28, 2), PEDL.PRECIO_UNITARIO) AS PRECIO_UNITARIO, " +
                                                           " CONVERT(decimal(28, 2), PEDL.CANTIDAD_PEDIDA * PEDL.PRECIO_UNITARIO) AS TOTAL_LINEA, " +
                                                           " PED.MONEDA_PEDIDO, " +
                                                           " PED.CLIENTE, PED.NOMBRE_CLIENTE, " +
                                                           " CONVERT(decimal(28, 2), PED.TOTAL_MERCADERIA) AS TOTAL_MERCADERIA, CONVERT(decimal(28, 2), PED.MONTO_DESCUENTO1) AS MONTO_DESCUENTO1, " +
                                                           " CONVERT(decimal(28, 2), PED.TOTAL_IMPUESTO1) AS TOTAL_IMPUESTO1, CONVERT(decimal(28, 2), PED.TOTAL_A_FACTURAR) AS TOTAL_A_FACTURAR, " +
                                                           " PED.OBSERVACIONES " +
                                                   " FROM    FARCOSA.PEDIDO_LINEA AS PEDL " +
                                                           " LEFT JOIN FARCOSA.PEDIDO AS PED ON PEDL.PEDIDO = PED.PEDIDO " +
                                                           " LEFT JOIN FARCOSA.ARTICULO AS ALO ON PEDL.ARTICULO = ALO.ARTICULO " +
                                                           " LEFT JOIN FARCOSA.LOTE AS L ON PEDL.ARTICULO = L.ARTICULO AND PEDL.LOTE = L.LOTE " +
                                                   " WHERE   PEDL.PEDIDO = '{0}' " +
                                                   " ORDER   BY PEDL.PEDIDO, PEDL.PEDIDO_LINEA ASC ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString());

                    RPEDIDO REPORTE1 = new RPEDIDO();
                    REPORTE1.DataSource = SQL.DATAADAPTER(PEDIDOR);
                    REPORTE1.ShowPreview();

                }

            }

            catch (NullReferenceException)
            {

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

