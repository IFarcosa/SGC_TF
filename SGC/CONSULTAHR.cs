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
    public partial class CONSULTAHR : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static CONSULTAHR form;
        public  static CONSULTAHR ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new CONSULTAHR();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public CONSULTAHR()
        {
            InitializeComponent();
        }

        public void DETALLEHR(int TIPO)
        {

            try
            {
                if (gridView1.RowCount == 0)
                {

                }

                else
                {
                    String QUERY01 = String.Format(" SELECT	FAC.FACTURA, FAC.NOMBRE_CLIENTE, FAC.ENTREGADA, FAC.COMENTARIO_ENT, FAC.RECIBIDA FROM FARCOSA.FACTURA AS FAC " +
                                                   " WHERE   ID = {0} ORDER BY FAC.FACTURA ASC ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() );
                    FACTURA_HR.ins.gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);

                    if ( TIPO == 1)
                    {
                        FACTURA_HR.ins.ShowDialog();
                    }

                    else
                    {

                    }

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

        private void CONSULTAHR_Load(object sender, EventArgs e)
        {
            barButtonItem1.PerformClick();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                String QUERY01 = String.Format(" SELECT	  HRUTA.ID, " +
                                                        " HRUTA.USUARIO_CREACION, HRUTA.FECHA_CREACION, " +
                                                        " VHI.U_DESCRIP + ' - ' + VHI.U_U_PLACA AS VEHICULO, " +
                                                        " EMP.NOMBRE AS CONDUCTOR, HRUTA.RECIBIDA, HRUTA.FECHA_REC," +
                                                        " CASE WHEN HRUTA.TIPO = 1 THEN 'Flota vehicular' ELSE CASE WHEN HRUTA.TIPO = 2 THEN 'Tercerizado' ELSE 'No definido' END END AS TIPO, HRUTA.REFERENCIA " +
                                               " FROM     FARCOSA.HOJA_RUTA AS HRUTA " +
                                                        " LEFT JOIN FARCOSA.U_VEHICULO AS VHI ON HRUTA.VEHICULO = VHI.U_CODIGO " +
                                                        " LEFT JOIN FARCOSA.EMPLEADO AS EMP ON HRUTA.CONDUCTOR = EMP.EMPLEADO " +
                                               " ORDER    BY HRUTA.ID ASC ");
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
                    MessageBox.Show("Debe de seleccionar una hoja de ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // SE GENERA REPORTE DE HOJA DE RUTA
                    String RUTAR = String.Format(" SELECT	  FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                            " FAC.MONEDA_FACTURA, CONVERT(decimal(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                            " FAC.CLIENTE, FAC.NOMBRE_CLIENTE, " +
                                                            " ZA.NOMBRE AS ZONA, REPLACE(FAC.DIRECCION_FACTURA, 'DETALLE: ', '') AS DIRECCION_FACTURA, " +
                                                            " HRUTA.USUARIO_CREACION, HRUTA.FECHA_CREACION, HRUTA.VEHICULO, HRUTA.CONDUCTOR," +
                                                            " FACL.ARTICULO, ALO.DESCRIPCION, ALO.UNIDAD_ALMACEN, FACL.LOTE, FACL.CANTIDAD, " +
                                                            " EMP.IDENTIFICACION + ' - ' + EMP.NOMBRE AS NOMBRE, VEH.U_DESCRIP, VEH.U_U_PLACA, FAC.ID " +
                                                 " FROM       FARCOSA.FACTURA AS FAC " +
                                                            " LEFT JOIN FARCOSA.HOJA_RUTA AS HRUTA ON FAC.ID = HRUTA.ID " +
                                                            " LEFT JOIN FARCOSA.FACTURA_LINEA AS FACL ON FAC.FACTURA = FACL.FACTURA " +
                                                            " LEFT JOIN FARCOSA.ARTICULO AS ALO ON FAC.FACTURA = FACL.FACTURA AND FACL.ARTICULO = ALO.ARTICULO " +
                                                            " LEFT JOIN FARCOSA.EMPLEADO AS EMP ON HRUTA.CONDUCTOR = EMP.EMPLEADO " +
                                                            " LEFT JOIN FARCOSA.U_VEHICULO AS VEH ON HRUTA.VEHICULO = VEH.U_CODIGO " +
                                                            " LEFT JOIN FARCOSA.ZONA AS ZA ON FAC.ZONA = ZA.ZONA " +
                                                 " WHERE      FAC.ID = {0} " +
                                                 " ORDER      BY FAC.FACTURA ASC ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());

                    RHOJAR REPORTE2 = new RHOJAR();
                    REPORTE2.DataSource = SQL.DATAADAPTER(RUTAR);
                    REPORTE2.ShowPreview();
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // BTN RECIBIR HR
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar una hoja de ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RECIBIDA").ToString() == "S")
                    {
                        MessageBox.Show("La hoja de ruta seleccionada ya se encuentra recibida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {

                        DialogResult RESULT = MessageBox.Show("¿Está seguro que desea recibir la hoja de ruta seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (RESULT == DialogResult.Yes)
                        {
                            String QUPT01 = String.Format(" UPDATE FARCOSA.HOJA_RUTA SET RECIBIDA = 'S', FECHA_REC = GETDATE() WHERE ID = {0} ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() );
                            SQL.NONQUERY(QUPT01);

                            MessageBox.Show("Hoja de ruta recibida exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            barButtonItem1.PerformClick();
                        }

                        else
                        {

                        }
                    }
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DETALLEHR(1);
        }

    }

}

