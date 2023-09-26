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
    public partial class LOCALIZACIONF : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static LOCALIZACIONF form;
        public  static LOCALIZACIONF ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new LOCALIZACIONF();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public LOCALIZACIONF()
        {
            InitializeComponent();
        }

        private void LOCALIZACIONF_Load(object sender, EventArgs e)
        {


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {

                if (comboBox1.SelectedIndex + 1 == 3)
                {
                    MessageBox.Show("No es posible cambiar la ubicación de las facturas que se encuentran en cuentas por cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    String USUARIOL = Form1.ins.accordionControlElement20.Text;

                    DataTable DT1 = new DataTable();
                    DT1.Columns.Add("FACTURA");
                    DT1.Columns.Add("FECHA");
                    DT1.Columns.Add("NOMBRE_CLIENTE");
                    DT1.Columns.Add("TOTAL_FACTURA");
                    DT1.Columns.Add("UBICACION");
                    DT1.Columns.Add("UBICACIONO");
                    DT1.Columns.Add("CAMBIO");

                    if (gridView1.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {

                        if (gridView1.SelectedRowsCount == 0)
                        {
                            MessageBox.Show("Debe seleccionar al menos una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            // SE OBTIENE EL CONSECUTIVO DE CAMBIO DE UBICACION
                            String CAMBIOU = SQL.SCALAR( String.Format(" SELECT CAMBIOU FROM FARCOSA.GLOBALES_FA ") );  

                            // SE ACTUALIZA LA UBICACION DE LAS FACTURAS SELECCIONADA
                            String FACTURA = "";
                            foreach (int i in gridView1.GetSelectedRows())
                            {
                                FACTURA = gridView1.GetRowCellValue(i, "FACTURA").ToString();

                                DataRow DR1 = DT1.NewRow();
                                DR1["FACTURA"] = gridView1.GetRowCellValue(i, "FACTURA").ToString();
                                DR1["FECHA"] = Convert.ToDateTime(gridView1.GetRowCellValue(i, "FECHA")).ToString("dd/MM/yyyy");
                                DR1["NOMBRE_CLIENTE"] = gridView1.GetRowCellValue(i, "NOMBRE_CLIENTE").ToString();
                                DR1["TOTAL_FACTURA"] = gridView1.GetRowCellValue(i, "TOTAL_FACTURA").ToString();
                                DR1["UBICACION"] = Convert.ToInt16(gridView1.GetRowCellValue(i, "UBICACION").ToString()) + 1;
                                DR1["UBICACIONO"] = Convert.ToInt16(gridView1.GetRowCellValue(i, "UBICACION").ToString());
                                DR1["CAMBIO"] = CAMBIOU;

                                DT1.Rows.Add(DR1);

                                if (Convert.ToInt16(gridView1.GetRowCellValue(i, "UBICACION").ToString()) + 1 == 2)
                                {
                                    // SE GRABA AUDITORIA DE UBICACION
                                    String QUERYUPT02 = String.Format(" UPDATE FARCOSA.FACTURA SET USUARIO_U2 = '{1}', FECHA_U2 = GETDATE(), CAMBIO2 = {2} WHERE FACTURA = '{0}' ", FACTURA, USUARIOL, CAMBIOU);
                                    SQL.NONQUERY(QUERYUPT02);
                                }

                                else if (Convert.ToInt16(gridView1.GetRowCellValue(i, "UBICACION").ToString()) + 1 == 3)
                                {
                                    // SE GRABA AUDITORIA DE UBICACION
                                    String QUERYUPT03 = String.Format(" UPDATE FARCOSA.FACTURA SET USUARIO_U3 = '{1}', FECHA_U3 = GETDATE(), CAMBIO3 = {2} WHERE FACTURA = '{0}' ", FACTURA, USUARIOL, CAMBIOU);
                                    SQL.NONQUERY(QUERYUPT03);
                                }

                                else
                                {

                                }

                                // SE ACTUALIZA LA UBICACION ACTUAL DE LA FACTURA
                                String QUERYUPT01 = String.Format(" UPDATE FARCOSA.FACTURA SET UBICACION += 1 WHERE FACTURA = '{0}' ", FACTURA);
                                SQL.NONQUERY(QUERYUPT01);

                            }

                            // SE INSERTA ID DE CAMBIO DE UBICACION
                            String QUERYUPT05 = String.Format(" INSERT INTO FARCOSA.CAMBIO_FACTURA (ID, USUARIO_CREACION, FECHA_CREACION, UBICACIONA) VALUES ({0}, '{1}', GETDATE(), {2}) ", CAMBIOU, USUARIOL, comboBox1.SelectedIndex + 1);
                            SQL.NONQUERY(QUERYUPT05);

                            // SE ACTUALIZA CONSECUTIVO DE CAMBIO DE UBICACION
                            String QUERYUPT04 = String.Format(" UPDATE FARCOSA.GLOBALES_FA SET CAMBIOU += 1 ");
                            SQL.NONQUERY(QUERYUPT04);

                            MessageBox.Show("Se actualizo exitosamente la ubicación de las facturas seleccionadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            barButtonItem4.PerformClick();
                            //simpleButton1.PerformClick();

                            // SE IMPRIME REPORTE
                            RUBICACION REPORTE3 = new RUBICACION();
                            REPORTE3.DataSource = DT1;
                            REPORTE3.ShowPreview();

                        }

                    }

                }

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                String QUERY01 = String.Format(" SELECT	 FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                        " CASE WHEN FAC.MONEDA_FACTURA = 'D' THEN 'Dólar' ELSE 'Córdoba' END AS MONEDA_FACTURA, " +
                                                        " CONVERT(DECIMAL(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                        " FAC.CLIENTE, FAC.NOMBRE_CLIENTE,  " +
                                                        " FAC.UBICACION, VOR.NOMBRE AS VENDEDOR " +
                                               " FROM     FARCOSA.FACTURA AS FAC " +
                                                        " LEFT JOIN FARCOSA.VENDEDOR AS VOR ON FAC.VENDEDOR = VOR.VENDEDOR " +
                                               " WHERE    FAC.ANULADA = 'N' AND UBICACION = {0} " +
                                               " ORDER    BY FAC.FACTURA ASC  ", comboBox1.SelectedIndex + 1);
                gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                String QUERY01 = String.Format(" SELECT	 FAC.FACTURA, CONVERT(date, FAC.FECHA) AS FECHA, " +
                                                        " CASE WHEN FAC.MONEDA_FACTURA = 'D' THEN 'Dólar' ELSE 'Córdoba' END AS MONEDA_FACTURA, " +
                                                        " CONVERT(DECIMAL(28, 2), FAC.TOTAL_FACTURA) AS TOTAL_FACTURA, " +
                                                        " FAC.CLIENTE, FAC.NOMBRE_CLIENTE,  " +
                                                        " FAC.UBICACION " +
                                               " FROM     FARCOSA.FACTURA AS FAC " +
                                               " WHERE    FAC.ANULADA = 'N' AND UBICACION = {0} " +
                                               " ORDER    BY FAC.FACTURA ASC  ", comboBox1.SelectedIndex + 1);
                gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {

                if (comboBox1.SelectedIndex + 1 != 3)
                {
                    MessageBox.Show("Únicamente las facturas que se encuentran en cuentas por cobrar es posible asociarle vendedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (gridView1.SelectedRowsCount == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    AVENDEDOR.ins.ShowDialog();
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
