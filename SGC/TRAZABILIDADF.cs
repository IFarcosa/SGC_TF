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
    public partial class TRAZABILIDADF : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static TRAZABILIDADF form;
        public  static TRAZABILIDADF ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new TRAZABILIDADF();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public TRAZABILIDADF()
        {
            InitializeComponent();
        }

        private void TRAZABILIDADF_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // BTN BUSCAR FACTURA
            try
            {

                if ( String.IsNullOrEmpty(dateEdit1.Text) || String.IsNullOrEmpty(dateEdit2.Text) )
                {
                    MessageBox.Show("Verificar que los campos <fecha inicio> y <fecha fin> no se encuentran vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    String FINICIO = Convert.ToDateTime(dateEdit1.EditValue).ToString("yyyyMMdd");
                    String FFIN = Convert.ToDateTime(dateEdit2.EditValue).ToString("yyyyMMdd");

                    String QUERY01 = String.Format(" SELECT	  PED.PEDIDO, PED.FECHA_HORA, CONVERT(time, PED.FECHA_HORA) AS HORAPE, PED.CLIENTE, PED.NOMBRE_CLIENTE, " +
                                                            " PED.CONFIRMADO, PED.USUARIO_CONFIRMACION, PED.FECHA_CONFIRMACION, CONVERT(time, PED.FECHA_CONFIRMACION) AS HORAC, " +
                                                            " PED.USUARIO_BOD, PED.FECHA_BOD, CONVERT(time, PED.FECHA_BOD) AS HORAA, " +
                                                            " PED.USUARIO_APROBACION, PED.FECHA_APROBACION, CONVERT(time, PED.FECHA_APROBACION) AS HORAP, " +
                                                            " FAC.FACTURA, FAC.FECHA, CONVERT(time, FAC.FECHA) AS HORAF, FAC.UBICACION, FAC.ID, " +
                                                            " FAC.USUARIO_U2, FAC.FECHA_U2, FAC.USUARIO_U3, FAC.FECHA_U3, FAC.USUARIO_U4, FAC.FECHA_U4, " +
                                                            " FAC.ENTREGADA, FAC.FECHA_ENT, FAC.COMENTARIO_ENT " +
                                                   " FROM     FARCOSA.PEDIDO AS PED " +
                                                            " LEFT JOIN FARCOSA.FACTURA AS FAC ON PED.PEDIDO = FAC.PEDIDO " +
                                                   " WHERE    CONVERT(DATE, FAC.FECHA) BETWEEN '{0}' AND '{1}' " + // FAC.FACTURA = '{0}'
                                                   " ORDER    BY PED.PEDIDO ASC ", FINICIO, FFIN );
                    gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
                }

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    simpleButton1.PerformClick();
                }
            }

            catch (Exception ERROR)
            {
                MessageBox.Show("ERROR: " + ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog2 = new SaveFileDialog();
            dialog2.Filter = "Excel Worksheets|*.xlsx;*.xls";
            dialog2.Title = "Guardar Archivo";

            if (dialog2.ShowDialog() == DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog2.FileName);
            }
        }

    }

}

