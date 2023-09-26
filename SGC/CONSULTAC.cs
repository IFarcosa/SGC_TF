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
    public partial class CONSULTAC : DevExpress.XtraEditors.XtraForm
    {
        SQL SQL = new SQL();

        private static CONSULTAC form;
        public static CONSULTAC ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new CONSULTAC();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public CONSULTAC()
        {
            InitializeComponent();
        }

        private void CONSULTAC_Load(object sender, EventArgs e)
        {
            barButtonItem1.PerformClick();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // BTN REFRESCAR
            try
            {
                String QUERY01 = String.Format(" SELECT	CFAC.ID, CFAC.USUARIO_CREACION, US.NOMBRE, CFAC.FECHA_CREACION " +
                                               " FROM    FARCOSA.CAMBIO_FACTURA AS CFAC LEFT JOIN ERPADMIN.USUARIO AS US ON CFAC.USUARIO_CREACION = US.USUARIO " +
                                               " ORDER   BY CFAC.ID ASC ");
                gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // SE GENERA REPORTE DE CAMBIO DE UBICACIONES
                    String CAMBIOFR = String.Format(" SELECT  CFAC.ID AS CAMBIO, CFAC.USUARIO_CREACION, US.NOMBRE, CFAC.FECHA_CREACION, " +
                                                         " FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, FAC.NOMBRE_CLIENTE, CFAC.UBICACIONA AS UBICACIONO, CFAC.UBICACIONA + 1 AS UBICACION  " +
                                                 " FROM    FARCOSA.CAMBIO_FACTURA AS CFAC LEFT JOIN ERPADMIN.USUARIO AS US ON CFAC.USUARIO_CREACION = US.USUARIO " +
                                                         " LEFT JOIN FARCOSA.FACTURA AS FAC ON CFAC.ID = FAC.CAMBIO2 OR CFAC.ID = FAC.CAMBIO3 " +
                                                 " WHERE   CFAC.ID = {0} ORDER BY CFAC.ID ASC ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() );

                    RUBICACION REPORTE3 = new RUBICACION();
                    REPORTE3.DataSource = SQL.DATAADAPTER(CAMBIOFR);
                    REPORTE3.ShowPreview();
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

