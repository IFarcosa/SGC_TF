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
    public partial class PEDIDOS : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static PEDIDOS form;
        public  static PEDIDOS ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new PEDIDOS();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public PEDIDOS()
        {
            InitializeComponent();
        }

        public void DETALLPRE(int TIPO)
        {

            try
            {
                if (bandedGridView1.RowCount == 0)
                {

                }

                else
                {
                    String QUERY01 = String.Format(" SELECT	  PEDL.PEDIDO, PEDL.PEDIDO_LINEA, " +
                                                            " PEDL.ARTICULO, ALO.DESCRIPCION, " +
                                                            " PEDL.LOTE, " +
                                                            " PEDL.BODEGA, PEDL.LOCALIZACION, " +
                                                            " CONVERT(decimal(28, 2), PEDL.CANTIDAD_PEDIDA) AS CANTIDAD_PEDIDA " +
                                                   " FROM     FARCOSA.PEDIDO_LINEA AS PEDL " +
                                                            " LEFT JOIN FARCOSA.ARTICULO AS ALO ON PEDL.ARTICULO = ALO.ARTICULO " +
                                                   " WHERE    PEDL.PEDIDO = '{0}' " +
                                                   " ORDER    BY PEDL.PEDIDO, PEDL.PEDIDO_LINEA ASC ", bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "PEDIDO").ToString());
                    DETALLEP.ins.gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);

                    if ( TIPO == 1 )
                    {
                        DETALLEP.ins.ShowDialog();
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

        private void PEDIDOS_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQL.GPRINCIPAL();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (bandedGridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (String.IsNullOrEmpty(bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "USUARIO_BOD").ToString()))
                    {

                        if ( bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "CONFIRMADO").ToString() == "N" )
                        {
                            MessageBox.Show("Únicamente a los pedidos confirmados es posible asociarles usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            AUSUARIO.ins.textEdit1.Text = bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "PEDIDO").ToString();
                            AUSUARIO.ins.ShowDialog();
                        }

                    }

                    else
                    {
                        MessageBox.Show("El pedido selecionado ya posee un usuario asociado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                gridControl1.DataSource = SQL.GPRINCIPAL();
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (bandedGridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if ( String.IsNullOrEmpty(bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "USUARIO_BOD").ToString()) )
                    {
                        MessageBox.Show("No es posible aprobar el pedido seleccionado porque no tiene usuario asociado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        DialogResult RESULT = MessageBox.Show("¿Está seguro que desea aprobar el pedido seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (RESULT == DialogResult.Yes)
                        {
                            String QUPT01 = String.Format(" UPDATE FARCOSA.PEDIDO SET ESTADO = 'A', USUARIO_APROBACION = '{1}', FECHA_APROBACION = GETDATE() WHERE PEDIDO = '{0}' ", bandedGridView1.GetRowCellValue(bandedGridView1.FocusedRowHandle, "PEDIDO").ToString(), Form1.ins.accordionControlElement20.Text);
                            SQL.NONQUERY(QUPT01);

                            MessageBox.Show("Pedido aprobado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            barButtonItem4.PerformClick();
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
            DETALLPRE(1);
        }

      
    }

}

