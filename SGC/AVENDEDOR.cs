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
    public partial class AVENDEDOR : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static AVENDEDOR form;
        public  static AVENDEDOR ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new AVENDEDOR();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public AVENDEDOR()
        {
            InitializeComponent();
        }

        private void AVENDEDOR_Load(object sender, EventArgs e)
        {

            try
            {

                // LLENADO DE COMBOBOX (VENDEDOR)
                String QUERYCBX1 = String.Format(" SELECT VENDEDOR, NOMBRE FROM FARCOSA.VENDEDOR ");
                comboBox1.ValueMember = "VENDEDOR";
                comboBox1.DisplayMember = "NOMBRE";
                comboBox1.DataSource = SQL.DATAADAPTER(QUERYCBX1);

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

                // SE ACTUALIZAN LAS FACTURAS SELECCIONADA
                String FACTURA = "";
                foreach (int i in LOCALIZACIONF.ins.gridView1.GetSelectedRows())
                {
                    FACTURA = LOCALIZACIONF.ins.gridView1.GetRowCellValue(i, "FACTURA").ToString(); 

                    String QUERYUPT01 = String.Format(" UPDATE FARCOSA.FACTURA SET USUARIO_U4 = '{0}', FECHA_U4 = GETDATE(), UBICACION = 4 WHERE FACTURA = '{1}' ", comboBox1.SelectedValue, FACTURA);
                    SQL.NONQUERY(QUERYUPT01);
                }
                
                MessageBox.Show("Facturas asociadas al vendedor exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                // SE GENERA REPORTE DE RUTA (REPORTE2)
                /*String RUTAR = String.Format(" SELECT	  FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                        " CASE WHEN FAC.MONEDA_FACTURA = 'D' Then 'Dólar' ELSE 'Córdoba' END AS MONEDA_FACTURA, " +
                                                        " CONVERT(decimal(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                        " FAC.CLIENTE, FAC.NOMBRE_CLIENTE, " +
                                                        " FAC.ZONA, REPLACE(FAC.DIRECCION_FACTURA, 'DETALLE: ', '') AS DIRECCION_FACTURA, " +
                                                        " HRUTA.USUARIO_CREACION, HRUTA.FECHA_CREACION, HRUTA.VEHICULO, HRUTA.CONDUCTOR," +
                                                        " FACL.ARTICULO, ALO.DESCRIPCION, ALO.UNIDAD_ALMACEN, FACL.LOTE, FACL.CANTIDAD, " +
                                                        " EMP.NOMBRE, VEH.U_DESCRIP, VEH.U_U_PLACA " +
                                               " FROM     MECHNIKOV.FACTURA AS FAC " +
                                                        " LEFT JOIN MECHNIKOV.HOJA_RUTA AS HRUTA ON FAC.ID = HRUTA.ID " +
                                                        " LEFT JOIN MECHNIKOV.FACTURA_LINEA AS FACL ON FAC.FACTURA = FACL.FACTURA " +
                                                        " LEFT JOIN MECHNIKOV.ARTICULO AS ALO ON FAC.FACTURA = FACL.FACTURA AND FACL.ARTICULO = ALO.ARTICULO " +
                                                        " LEFT JOIN MECHNIKOV.EMPLEADO AS EMP ON HRUTA.CONDUCTOR = EMP.EMPLEADO " +
                                                        " LEFT JOIN MECHNIKOV.U_VEHICULO AS VEH ON HRUTA.VEHICULO = VEH.U_CODIGO " +
                                               " WHERE    FAC.ID = {0} " +
                                               " ORDER    BY FAC.FACTURA ASC ", HRURTA);

                RHOJAR REPORTE2 = new RHOJAR();
                REPORTE2.DataSource = SQL.DATAADAPTER(RUTAR);
                REPORTE2.ShowPreview();*/

                // SE REFRESCA EL GRID
                LOCALIZACIONF.ins.barButtonItem4.PerformClick();
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

