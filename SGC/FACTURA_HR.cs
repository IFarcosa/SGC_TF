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
    public partial class FACTURA_HR : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static FACTURA_HR form;
        public static  FACTURA_HR ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new FACTURA_HR();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public FACTURA_HR()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // BTN RECIBIR FACTURAS   
            try
            {

                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (gridView1.SelectedRowsCount == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // SE ACTUALIZAN LAS FACTURAS SELECCIONADA
                    String FACTURA = "";
                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        FACTURA = gridView1.GetRowCellValue(i, "FACTURA").ToString();

                        String QUPT01 = String.Format(" UPDATE FARCOSA.FACTURA SET RECIBIDA = 'S', FECHA_REC = GETDATE() WHERE FACTURA = '{0}' ", FACTURA);
                        SQL.NONQUERY(QUPT01);
                    }

                    MessageBox.Show("Facturas recibidas exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CONSULTAHR.ins.DETALLEHR(2);
                }

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

