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
    public partial class DETALLEP : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static DETALLEP form;
        public  static DETALLEP ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new DETALLEP();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public DETALLEP()
        {
            InitializeComponent();
        }

        private void DETALLEP_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (gridView1.RowCount == 0)
                {

                }

                else
                {

                    ELOTE.ins.textEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString();
                    ELOTE.ins.textEdit2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO_LINEA").ToString();

                    String QUERY01 = String.Format(" SELECT	  ELOTE.BODEGA, ELOTE.LOCALIZACION, " +
                                                            " CASE WHEN ALO.USA_LOTES = 'N' THEN 'NULL' ELSE ELOTE.LOTE END AS LOTE, " +
                                                            " CONVERT(decimal(28, 2), ELOTE.CANT_DISPONIBLE) AS CANT_DISPONIBLE, L.FECHA_VENCIMIENTO " +
                                                   " FROM     FARCOSA.EXISTENCIA_LOTE AS ELOTE " +
                                                   "          LEFT JOIN FARCOSA.LOTE AS L ON ELOTE.ARTICULO = L.ARTICULO AND ELOTE.LOTE = L.LOTE " +
                                                            " LEFT JOIN FARCOSA.ARTICULO AS ALO ON ELOTE.ARTICULO = ALO.ARTICULO " +
                                                   " WHERE    ELOTE.ARTICULO = '{0}' AND ELOTE.CANT_DISPONIBLE > 0 " + /*AND ELOTE.LOTE != 'ND'*/
                                                   " ORDER    BY ELOTE.BODEGA, ELOTE.LOCALIZACION ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ARTICULO").ToString() );
                    ELOTE.ins.gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
                    ELOTE.ins.ShowDialog();

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
            // BTN DUPLICAR LINEA
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                        DialogResult RESULT = MessageBox.Show("¿Está seguro que desea duplicar el articulo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (RESULT == DialogResult.Yes)
                        {
                            String QIST01 = String.Format(" INSERT INTO FARCOSA.PEDIDO_LINEA (PEDIDO, PEDIDO_LINEA, BODEGA, LOTE, LOCALIZACION, ARTICULO, ESTADO, FECHA_ENTREGA, LINEA_USUARIO, PRECIO_UNITARIO, CANTIDAD_PEDIDA, CANTIDAD_A_FACTURA, CANTIDAD_FACTURADA, " +
                                                                                            " CANTIDAD_RESERVADA, CANTIDAD_BONIFICAD, CANTIDAD_CANCELADA, TIPO_DESCUENTO, MONTO_DESCUENTO, PORC_DESCUENTO, DESCRIPCION, COMENTARIO, PEDIDO_LINEA_BONIF, UNIDAD_DISTRIBUCIO, " +
                                                                                            " FECHA_PROMETIDA, LINEA_ORDEN_COMPRA, PROYECTO, FASE, CENTRO_COSTO, CUENTA_CONTABLE, RAZON_PERDIDA, TIPO_DESC) " +
                                                          " SELECT PEDIDO, ( SELECT MAX(PEDIDO_LINEA) + 1 FROM FARCOSA.PEDIDO_LINEA WHERE PEDIDO = '{0}' ), BODEGA, LOTE, LOCALIZACION, ARTICULO, ESTADO, FECHA_ENTREGA, ( SELECT MAX(LINEA_USUARIO) + 1 FROM FARCOSA.PEDIDO_LINEA WHERE PEDIDO = '{0}' ), PRECIO_UNITARIO, CANTIDAD_PEDIDA, CANTIDAD_A_FACTURA, CANTIDAD_FACTURADA, " +
                                                                 " CANTIDAD_RESERVADA, CANTIDAD_BONIFICAD, CANTIDAD_CANCELADA, TIPO_DESCUENTO, MONTO_DESCUENTO, PORC_DESCUENTO, DESCRIPCION, COMENTARIO, PEDIDO_LINEA_BONIF, UNIDAD_DISTRIBUCIO, " +
                                                                 " FECHA_PROMETIDA, LINEA_ORDEN_COMPRA, PROYECTO, FASE, CENTRO_COSTO, CUENTA_CONTABLE, RAZON_PERDIDA, TIPO_DESC " +
                                                          " FROM FARCOSA.PEDIDO_LINEA WHERE PEDIDO = '{0}' AND PEDIDO_LINEA = {1} ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO_LINEA").ToString());
                            SQL.NONQUERY(QIST01);

                            // SE REFRESCA GRID DE LAS LINEAS DEL PEDIDO
                            PEDIDOS.ins.DETALLPRE(2);
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            // BTN ELIMINAR LINEA
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    DialogResult RESULT = MessageBox.Show("¿Está seguro que desea eliminar el articulo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (RESULT == DialogResult.Yes)
                    {
                        String QDLT01 = String.Format(" DELETE FARCOSA.PEDIDO_LINEA WHERE PEDIDO = '{0}' AND PEDIDO_LINEA = {1} ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO_LINEA").ToString() );
                        SQL.NONQUERY(QDLT01);

                        // SE REFRESCA GRID DE LAS LINEAS DEL PEDIDO
                        PEDIDOS.ins.DETALLPRE(2);
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

        private void repositoryItemSpinEdit1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemSpinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemSpinEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void repositoryItemSpinEdit1_Leave(object sender, EventArgs e)
        {

            try
            {

                String CANTIDADP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CANTIDAD_PEDIDA").ToString();

                if ( String.IsNullOrEmpty( CANTIDADP ) )
                {

                }

                else
                {
                    // SE ACTUALIZA CANTIDAD PEDIDA DEL ARTICULO
                    String QUPT01 = String.Format(" UPDATE FARCOSA.PEDIDO_LINEA SET CANTIDAD_PEDIDA = {2}, CANTIDAD_A_FACTURA = {2} WHERE PEDIDO = '{0}' AND PEDIDO_LINEA = {1} ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString(), gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO_LINEA").ToString(), CANTIDADP);
                    SQL.NONQUERY(QUPT01);
                }

            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

