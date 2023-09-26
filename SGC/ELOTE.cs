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
    public partial class ELOTE : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static ELOTE form;
        public  static ELOTE ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new ELOTE();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public ELOTE()
        {
            InitializeComponent();
        }

        private void ELOTEcs_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                // SE VALIDA SI EL ARTICULO UTILIZA O NO LOTE
                String LOTE = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LOTE").ToString();

                // SE ACTUALIZA LOS CAMPOS BODEGA, LOCALIZACION Y LOTE DE LA LINEA DEL PEDIDO
                if ( LOTE == "NULL" )
                {
                    String QUPDATE01 = String.Format(" UPDATE FARCOSA.PEDIDO_LINEA SET BODEGA = '{0}', LOCALIZACION = '{1}', LOTE = NULL WHERE PEDIDO = '{3}' AND PEDIDO_LINEA = '{4}' ",
                                                     gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BODEGA").ToString(),
                                                     gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LOCALIZACION").ToString(),
                                                     LOTE,
                                                     textEdit1.Text, textEdit2.Text);
                    SQL.NONQUERY(QUPDATE01);
                }

                else
                {
                    String QUPDATE01 = String.Format(" UPDATE FARCOSA.PEDIDO_LINEA SET BODEGA = '{0}', LOCALIZACION = '{1}', LOTE = '{2}' WHERE PEDIDO = '{3}' AND PEDIDO_LINEA = '{4}' ",
                                                     gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BODEGA").ToString(),
                                                     gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LOCALIZACION").ToString(),
                                                     LOTE,
                                                     textEdit1.Text, textEdit2.Text);
                    SQL.NONQUERY(QUPDATE01);
                }

                // SE REFRESCA GRID DETALLE DE PEDIDO
                String QUERY01 = String.Format(" SELECT	  PEDL.PEDIDO, PEDL.PEDIDO_LINEA, " +
                                                        " PEDL.ARTICULO, ALO.DESCRIPCION, " +
                                                        " PEDL.LOTE, " +
                                                        " PEDL.BODEGA, PEDL.LOCALIZACION, " +
                                                        " CONVERT(decimal(28, 2), PEDL.CANTIDAD_PEDIDA) AS CANTIDAD_PEDIDA " +
                                               " FROM     FARCOSA.PEDIDO_LINEA AS PEDL " +
                                                        " LEFT JOIN FARCOSA.ARTICULO AS ALO ON PEDL.ARTICULO = ALO.ARTICULO " +
                                               " WHERE    PEDL.PEDIDO = '{0}' " +
                                               " ORDER    BY PEDL.PEDIDO, PEDL.PEDIDO_LINEA ASC ", textEdit1.Text );
                DETALLEP.ins.gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);

                // SE CIERRA EL FORMULARIO EXISTENCIA LOTE
                this.Close();
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

