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
    public partial class NUEVAHR : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static NUEVAHR form;
        public  static NUEVAHR ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new NUEVAHR();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public NUEVAHR()
        {
            InitializeComponent();
        }

        private void NUEVAHR_Load(object sender, EventArgs e)
        {

            try
            {
                // LLENADO DE USUARIO CREACIÓN
                textEdit2.Text = Form1.ins.accordionControlElement20.Text;

                // LLENADO DE COMBOBOX (VEHICULOS)
                String QUERYCBX1 = String.Format(" SELECT U_CODIGO, U_U_PLACA FROM FARCOSA.U_VEHICULO ");
                comboBox1.ValueMember = "U_CODIGO";
                comboBox1.DisplayMember = "U_U_PLACA";
                comboBox1.DataSource = SQL.DATAADAPTER(QUERYCBX1);

                // LLENADO DE COMBOBOX (EMPLEADOS)
                String QUERYCBX2 = String.Format(" SELECT EMPLEADO, NOMBRE FROM FARCOSA.EMPLEADO WHERE ACTIVO = 'S' AND PUESTO = '007' ");
                comboBox2.ValueMember = "EMPLEADO";
                comboBox2.DisplayMember = "NOMBRE";
                comboBox2.DataSource = SQL.DATAADAPTER(QUERYCBX2);                
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // BTN GRABAR HOJA DE RUTA        
            try
            {
                if (comboBox3.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar un tipo de hoja de ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    // SE OBTIENE EL VALOR DE LA SIGUIENTE HOJA DE RUTA    
                    String HRURTA = textEdit1.Text;
                    int TIPO = comboBox3.SelectedIndex + 1;
                    String VEHICULO = comboBox1.SelectedValue.ToString();
                    String CONDUCTOR = comboBox2.SelectedValue.ToString();

                    if ( TIPO == 2 )
                    {
                        VEHICULO = ""; CONDUCTOR = "";
                    }

                    // SE REGISTRA LA HOJA DE RUTA
                    String QUERYIST01 = String.Format(" INSERT INTO FARCOSA.HOJA_RUTA (ID, USUARIO_CREACION, FECHA_CREACION, VEHICULO, CONDUCTOR, TIPO, REFERENCIA) " +
                                                      " VALUES ({3}, '{0}', GETDATE(), '{1}', '{2}', {4}, '{5}') ", textEdit2.Text, VEHICULO, CONDUCTOR, HRURTA, TIPO, textEdit3.Text);
                    SQL.NONQUERY(QUERYIST01);

                    // SE ACTUALIZAN LAS FACTURAS SELECCIONADA
                    String FACTURA = "";
                    foreach (int i in HOJAR.ins.gridView1.GetSelectedRows())
                    {
                        FACTURA = /*+=*/ HOJAR.ins.gridView1.GetRowCellValue(i, "FACTURA").ToString(); //+ "\n";

                        String QUERYUPT01 = String.Format(" UPDATE FARCOSA.FACTURA SET ID = {0} WHERE FACTURA = '{1}' ", HRURTA, FACTURA);
                        SQL.NONQUERY(QUERYUPT01);
                    }

                    //MessageBox.Show(FACTURA);               
                    MessageBox.Show("Hoja de ruta registrada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    // SE GENERA REPORTE DE HOJA DE RUTA
                    String RUTAR = String.Format(" SELECT	  FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                            " CASE WHEN FAC.MONEDA_FACTURA = 'D' Then 'Dólar' ELSE 'Córdoba' END AS MONEDA_FACTURA, " +
                                                            " CONVERT(decimal(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                            " FAC.CLIENTE, FAC.NOMBRE_CLIENTE, " +
                                                            " ZA.NOMBRE AS ZONA, REPLACE(FAC.DIRECCION_FACTURA, 'DETALLE: ', '') AS DIRECCION_FACTURA, " +
                                                            " HRUTA.USUARIO_CREACION, HRUTA.FECHA_CREACION, HRUTA.VEHICULO, HRUTA.CONDUCTOR," +
                                                            " FACL.ARTICULO, ALO.DESCRIPCION, ALO.UNIDAD_ALMACEN, FACL.LOTE, FACL.LOCALIZACION, FACL.CANTIDAD, " +
                                                            " EMP.IDENTIFICACION + ' - ' + EMP.NOMBRE AS NOMBRE, VEH.U_DESCRIP, VEH.U_U_PLACA, FAC.ID," +
                                                            " CASE WHEN HRUTA.TIPO = 1 THEN 'Flota vehicular' ELSE CASE WHEN HRUTA.TIPO = 2 THEN 'Tercerizado' ELSE 'No definido' END END AS TIPO, HRUTA.REFERENCIA " +
                                                   " FROM     FARCOSA.FACTURA AS FAC " +
                                                            " LEFT JOIN FARCOSA.HOJA_RUTA AS HRUTA ON FAC.ID = HRUTA.ID " +
                                                            " LEFT JOIN FARCOSA.FACTURA_LINEA AS FACL ON FAC.FACTURA = FACL.FACTURA " +
                                                            " LEFT JOIN FARCOSA.ARTICULO AS ALO ON FAC.FACTURA = FACL.FACTURA AND FACL.ARTICULO = ALO.ARTICULO " +
                                                            " LEFT JOIN FARCOSA.EMPLEADO AS EMP ON HRUTA.CONDUCTOR = EMP.EMPLEADO " +
                                                            " LEFT JOIN FARCOSA.U_VEHICULO AS VEH ON HRUTA.VEHICULO = VEH.U_CODIGO " +
                                                            " LEFT JOIN FARCOSA.ZONA AS ZA ON FAC.ZONA = ZA.ZONA " +
                                                   " WHERE    FAC.ID = {0} " +
                                                   " ORDER    BY FAC.FACTURA ASC ", HRURTA);

                    RHOJAR REPORTE2 = new RHOJAR();
                    REPORTE2.DataSource = SQL.DATAADAPTER(RUTAR);
                    REPORTE2.ShowPreview();

                    // SE GENERA REPORTE DE RUTA 2 (CONSOLIDADO DE ARTICULOS)
                    String RUTAR2 = String.Format(" SELECT	  {0} AS ID, FACL.ARTICULO, ALO.DESCRIPCION, ALO.UNIDAD_ALMACEN, CONVERT(decimal(28,2), SUM (FACL.CANTIDAD) ) AS CANT_TOTAL " +
                                                  " FROM      FARCOSA.FACTURA AS FAC " +
                                                            " LEFT JOIN FARCOSA.FACTURA_LINEA AS FACL ON FAC.FACTURA = FACL.FACTURA " +
                                                            " LEFT JOIN FARCOSA.ARTICULO AS ALO ON FACL.ARTICULO = ALO.ARTICULO " +
                                                  " WHERE     FAC.ID = {0} " +
                                                  " GROUP     BY FACL.ARTICULO, ALO.DESCRIPCION, ALO.UNIDAD_ALMACEN " +
                                                  " ORDER     BY FACL.ARTICULO ASC  ", HRURTA);

                    RHOJAR2 REPORTE3 = new RHOJAR2();
                    REPORTE3.DataSource = SQL.DATAADAPTER(RUTAR2);
                    REPORTE3.ShowPreview();

                    // SE ACTUALIZA EL CONSECUTIVO DE HOJA DE RUTA
                    String QUERYUPT02 = String.Format(" UPDATE FARCOSA.GLOBALES_FA SET HOJAR += 1 ");
                    SQL.NONQUERY(QUERYUPT02);

                    HOJAR.ins.barButtonItem2.PerformClick();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                if ( comboBox3.SelectedIndex == 1 )
                {
                    textEdit3.Enabled = true;
                }

                else 
                {
                    textEdit3.Enabled = false;
                }

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

