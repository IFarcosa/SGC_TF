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
    public partial class AUSUARIO : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static AUSUARIO form;
        public static  AUSUARIO ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new AUSUARIO();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public AUSUARIO()
        {
            InitializeComponent();
        }

        private void AUSUARIO_Load(object sender, EventArgs e)
        {

            try
            {
                // LLENADO DE COMBOBOX (USUARIOS)
                //String QUERYCBX1 = String.Format("SELECT USUARIO, NOMBRE FROM ERPADMIN.USUARIO WHERE ACTIVO = 'S' AND TIPO != 'G' ");
                String QUERYCBX1 = String.Format("SELECT EMPLEADO, NOMBRE FROM FARCOSA.EMPLEADO WHERE DEPARTAMENTO = 'D06' AND ACTIVO = 'S' ");
                comboBox1.ValueMember = "EMPLEADO";
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
                String PEDIDO = textEdit1.Text;

                String QUPT01 = String.Format(" UPDATE FARCOSA.PEDIDO SET USUARIO_BOD = '{0}', FECHA_BOD = GETDATE() WHERE PEDIDO = '{1}' ", comboBox1.SelectedValue, PEDIDO);
                SQL.NONQUERY(QUPT01);

                MessageBox.Show("Usuario asignado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

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
                                               " ORDER   BY PEDL.PEDIDO, PEDL.PEDIDO_LINEA ASC ", PEDIDO);

                RPEDIDO REPORTEP = new RPEDIDO();
                REPORTEP.DataSource = SQL.DATAADAPTER(PEDIDOR);
                REPORTEP.ShowPreview();

                // SE REFRESCA EL GRID (PEDIDOS)
                PEDIDOS.ins.gridControl1.DataSource = SQL.GPRINCIPAL();
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

