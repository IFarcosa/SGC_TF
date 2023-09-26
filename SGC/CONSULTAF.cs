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

namespace SGC
{
    public partial class CONSULTAF : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static CONSULTAF form;
        public  static CONSULTAF ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new CONSULTAF();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public CONSULTAF()
        {
            InitializeComponent();
        }

        private void CONSULTAF_Load(object sender, EventArgs e)
        {
            //barButtonItem1.PerformClick();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // AUDITORIA
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    String FACTURA = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FACTURA").ToString();

                    // FACTURA                
                    AUDITORIAF.ins.textEdit2.Text = FACTURA;
                    AUDITORIAF.ins.textEdit3.Text = SQL.SCALAR(String.Format("SELECT FECHA FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    // ALMACEN
                    AUDITORIAF.ins.textEdit4.Text = SQL.SCALAR(String.Format("SELECT USUARIO_U2 FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    AUDITORIAF.ins.textEdit5.Text = SQL.SCALAR(String.Format("SELECT FECHA_U2 FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    // ENVIADO
                    AUDITORIAF.ins.textEdit10.Text = SQL.SCALAR(String.Format("SELECT ID FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    AUDITORIAF.ins.textEdit11.Text = SQL.SCALAR(String.Format("SELECT HRTA.FECHA_CREACION FROM FARCOSA.FACTURA AS FAC LEFT JOIN FARCOSA.HOJA_RUTA AS HRTA ON FAC.ID = HRTA.ID WHERE FAC.FACTURA = '{0}' ", FACTURA));
                    //RECIBIDO CLIENTE
                    AUDITORIAF.ins.textEdit12.Text = SQL.SCALAR(String.Format("SELECT ENTREGADA FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    AUDITORIAF.ins.textEdit13.Text = SQL.SCALAR(String.Format("SELECT FECHA_ENT FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    // CUENTAS POR COBRAR
                    AUDITORIAF.ins.textEdit6.Text = SQL.SCALAR(String.Format("SELECT USUARIO_U3 FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    AUDITORIAF.ins.textEdit7.Text = SQL.SCALAR(String.Format("SELECT FECHA_U3 FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    // COBRADOR
                    AUDITORIAF.ins.textEdit8.Text = SQL.SCALAR(String.Format("SELECT USUARIO_U4 FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));
                    AUDITORIAF.ins.textEdit9.Text = SQL.SCALAR(String.Format("SELECT FECHA_U4 FROM FARCOSA.FACTURA WHERE FACTURA = '{0}' ", FACTURA));

                    AUDITORIAF.ins.ShowDialog();
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
            // BTN REFRESCAR FECHAS 
            try
            {

                String FINICIO = Convert.ToDateTime(dateEdit1.EditValue).ToString("yyyyMMdd");
                String FFIN    = Convert.ToDateTime(dateEdit2.EditValue).ToString("yyyyMMdd");

                if (String.IsNullOrEmpty(dateEdit1.Text) || String.IsNullOrEmpty(dateEdit2.Text))
                {
                    MessageBox.Show("Verificar que los campos <fecha inicio> y <fecha fin> no se encuentran vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    String QUERY01 = String.Format(" SELECT	  FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                            " CASE WHEN FAC.MONEDA_FACTURA = 'D' Then 'Dólar' ELSE 'Córdoba' END AS MONEDA_FACTURA, " +
                                                            " CONVERT(decimal(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                            " FAC.CLIENTE, FAC.NOMBRE_CLIENTE, " +
                                                            " FAC.ZONA, REPLACE(FAC.DIRECCION_FACTURA, 'DETALLE: ', '') AS DIRECCION_FACTURA, CASE WHEN FAC.ANULADA = 'N' THEN 'No' ELSE 'Si' END AS ANULADA, FAC.ID," +
                                                            " FAC.CAMBIO2, FAC.CAMBIO3 " +
                                                   " FROM     FARCOSA.FACTURA AS FAC " +
                                                   " WHERE    FAC.TIPO_DOCUMENTO = 'F' AND CONVERT(date, FAC.FECHA) BETWEEN '{0}' AND '{1}' " +
                                                   " ORDER    BY FAC.FACTURA ASC ", FINICIO, FFIN);
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
                    MessageBox.Show("La <fecha finalización> no puede ser menor a la <fecha inicio>", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateEdit2.Focus();
                }
            }

        }

    }

}

