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
    public partial class HOJAR : DevExpress.XtraEditors.XtraForm
    {
        SQL SQL = new SQL();

        private static HOJAR form;
        public  static HOJAR ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new HOJAR();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public HOJAR()
        {
            InitializeComponent();
        }

        private void HOJAR_Load(object sender, EventArgs e)
        {           
            barButtonItem2.PerformClick(); 
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // SE LLENA EL GRID PRINCIPAL (FACTURAS)
            try
            {
                String QUERY01 = String.Format(" SELECT	  FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                        " CASE WHEN FAC.MONEDA_FACTURA = 'D' Then 'Dólar' ELSE 'Córdoba' END AS MONEDA_FACTURA, " +
                                                        " CONVERT(decimal(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                        " FAC.CLIENTE, FAC.NOMBRE_CLIENTE, " +
                                                        " ZA.NOMBRE AS ZONA, REPLACE(FAC.DIRECCION_FACTURA, 'DETALLE: ', '') AS DIRECCION_FACTURA " +
                                               " FROM     FARCOSA.FACTURA AS FAC LEFT JOIN FARCOSA.ZONA AS ZA ON FAC.ZONA = ZA.ZONA " +
                                               " WHERE    FAC.TIPO_DOCUMENTO = 'F' " +
                                                        " AND FAC.ANULADA = 'N' " +
                                                        " AND ID IS NULL " +
                                                        " AND UBICACION = 2 " +
                                               " ORDER   BY FAC.FACTURA ASC ");
                gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if ( gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if ( gridView1.SelectedRowsCount == 0 )
                {
                    MessageBox.Show("Debe seleccionar al menos una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // SE OBTIENE EL VALOR DE LA SIGUIENTE HOJA DE RUTA    
                    NUEVAHR.ins.textEdit1.Text = SQL.SCALAR(String.Format(" SELECT HOJAR FROM FARCOSA.GLOBALES_FA "));
                    NUEVAHR.ins.ShowDialog();
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

