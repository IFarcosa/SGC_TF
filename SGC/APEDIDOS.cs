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
    public partial class APEDIDOS : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();
       
        private static APEDIDOS form;
        public  static APEDIDOS ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new APEDIDOS();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public APEDIDOS()
        {
            InitializeComponent();
        }

        private void APEDIDOS_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = SQL.GPRINCIPAL2();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // BTN ESTADO DE CUENTA
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    String CLIENTE = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CLIENTE").ToString();

                    ECUENTA.ins.textEdit1.Text = CLIENTE;
                    ECUENTA.ins.textEdit3.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOMBRE_CLIENTE").ToString();
                    ECUENTA.ins.textEdit4.Text = SQL.SCALAR(String.Format("SELECT CONVERT(VARCHAR,CAST(SALDO_LOCAL AS MONEY),1) FROM FARCOSA.CLIENTE WHERE CLIENTE = '{0}' ", CLIENTE));
                    ECUENTA.ins.textEdit5.Text = SQL.SCALAR(String.Format("SELECT CONVERT(VARCHAR,CAST(SALDO_DOLAR AS MONEY),1) FROM FARCOSA.CLIENTE WHERE CLIENTE = '{0}' ", CLIENTE));
                    ECUENTA.ins.textEdit2.Text = SQL.SCALAR(String.Format("SELECT CASE WHEN CLT.MOROSO = 'S' THEN 'Si' ELSE 'No' END AS MOROSO FROM FARCOSA.CLIENTE AS CLT WHERE CLT.CLIENTE = '{0}' ", CLIENTE));
                    ECUENTA.ins.textEdit6.Text = SQL.SCALAR(String.Format("SELECT CONVERT(VARCHAR,CAST(CLT.LIMITE_CREDITO AS MONEY),1) FROM FARCOSA.CLIENTE AS CLT WHERE CLT.CLIENTE = '{0}' ", CLIENTE));

                    String QUERY01 = String.Format(" SELECT	  DCC.DOCUMENTO, " +
                                                            " DCC.TIPO, " +
                                                            " DATEDIFF( DAY, CONVERT(date, FECHA_VENCE), CONVERT(date, GETDATE()) ) AS DIAS, " +
                                                            " CONVERT(date, DCC.FECHA_DOCUMENTO) AS FECHA_DOCUMENTO, " +
                                                            " CONVERT(date, DCC.FECHA_VENCE) AS FECHA_VENCE, " +
                                                            " DCC.MONEDA, " +
                                                            " CONVERT(decimal(28, 2), DCC.MONTO) AS MONTO, " +
                                                            " CONVERT(decimal(28, 2), DCC.SALDO_LOCAL) AS SALDO_LOCAL, " +
                                                            " CONVERT(decimal(28, 2), DCC.SALDO_DOLAR) AS SALDO_DOLAR " +
                                                   " FROM     FARCOSA.DOCUMENTOS_CC AS DCC " +
                                                   " WHERE    /*DCC.TIPO IN('FAC', 'N/D', 'O/D') AND*/ DCC.CLIENTE = '{0}' AND DCC.SALDO > 0 " +
                                                   " ORDER    BY DCC.FECHA ASC ", CLIENTE);
                    ECUENTA.ins.gridControl1.DataSource = SQL.DATAADAPTER(QUERY01);
                    ECUENTA.ins.ShowDialog();
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    DialogResult RESULT = MessageBox.Show("¿Está seguro que desea aprobar el pedido seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (RESULT == DialogResult.Yes)
                    {
                        String QUPT01 = String.Format(" UPDATE FARCOSA.PEDIDO SET ESTADO = 'A', FECHA_APROBACION = GETDATE(), USUARIO_APROBACION = '{1}' WHERE PEDIDO = '{0}' ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString(), Form1.ins.accordionControlElement20.Text);
                        SQL.NONQUERY(QUPT01);

                        MessageBox.Show("Pedido aprobado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        barButtonItem4.PerformClick();
                    }

                    else
                    {

                    }
                }
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
                gridControl1.DataSource = SQL.GPRINCIPAL2();
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
                    MessageBox.Show("Debe de seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    DialogResult RESULT = MessageBox.Show("¿Está seguro que desea cancelar el pedido seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (RESULT == DialogResult.Yes)
                    {
                        String QUPT01 = String.Format(" UPDATE FARCOSA.PEDIDO SET ESTADO = 'C', FECHA_ULT_CANCELAC = GETDATE() WHERE PEDIDO = '{0}' ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString());
                        SQL.NONQUERY(QUPT01);

                        String QUPT02 = String.Format(" UPDATE FARCOSA.PEDIDO_LINEA SET ESTADO = 'C' WHERE PEDIDO = '{0}' ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString());
                        SQL.NONQUERY(QUPT02);

                        MessageBox.Show("Pedido cancelado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        barButtonItem4.PerformClick();
                    }

                    else
                    {

                    }
                }
            }

            catch (Exception Error)
            {
                MessageBox.Show("Excepción: " + Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // BTN CONFIRMAR
            try
            {
                if (gridView1.RowCount == 0)
                {
                    MessageBox.Show("Debe de seleccionar un pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if ( gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CONFIRMADO").ToString() == "S" )
                    {
                        MessageBox.Show("El pedido seleccionado ya se encuentra confirmado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {

                        DialogResult RESULT = MessageBox.Show("¿Está seguro que desea confirmar el pedido seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (RESULT == DialogResult.Yes)
                        {
                            String QUPT01 = String.Format(" UPDATE FARCOSA.PEDIDO SET CONFIRMADO = 'S', USUARIO_CONFIRMACION = '{1}', FECHA_CONFIRMACION = GETDATE() WHERE PEDIDO = '{0}' ", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PEDIDO").ToString(), Form1.ins.accordionControlElement20.Text);
                            SQL.NONQUERY(QUPT01);

                            MessageBox.Show("Pedido confirmado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

    }

}

