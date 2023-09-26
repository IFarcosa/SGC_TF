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
using System.Data.SqlClient;

namespace SGC
{
    public partial class ACCESO : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        public ACCESO()
        {
            InitializeComponent();
        }

        private void ACCESO_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            String USUARIO = textBox1.Text;
            String CONTRA  = textBox2.Text;

            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Verificar que el campo <usuario> o <contraseña> no se encuentra vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    SQL.CONEXION.Open();

                    String QUERYA = string.Format(" SELECT	USUARIO, CONTRA  " +
                                                  " FROM    ERPADMIN.USUARIO " +
                                                  " WHERE   USUARIO = '{0}' AND CONTRA = '{1}' ", USUARIO, CONTRA);
                    SqlCommand EJECUTARA = new SqlCommand(QUERYA, SQL.CONEXION);
                    SqlDataReader DRACCESO = EJECUTARA.ExecuteReader();

                    if (DRACCESO.Read())
                    {
                        SQL.CONEXION.Close();
                        DRACCESO.Close();

                        // SE ASIGNA EL USUARIO A LA VARIABLE GLOBAL DEL USUARIO 
                        Form1.ins.accordionControlElement20.Text = USUARIO;
                        Form1.ins.Show();

                        // ASIGNACION DE TIPO DE ACCESO
                        String QUERYTA = String.Format(" SELECT	 TIPO_SGC " +
                                                       " FROM    ERPADMIN.USUARIO " +
                                                       " WHERE   USUARIO = '{0}' ", USUARIO);
                        String TIPOA = SQL.SCALAR(QUERYTA); 

                        if (TIPOA == "1") // ADMINISTRADOR
                        {
                            // OPERACIONES

                            // CONSULTAS

                            // REPORTES

                            // ADMINISTRACIÓN
                        }

                        else if (TIPOA == "2") // ALMACEN
                        {
                            // OPERACIONES
                            Form1.ins.accordionControlElement6.Enabled = false;

                            // CONSULTAS
                            Form1.ins.accordionControlElement12.Enabled = false;

                            // REPORTES
                            Form1.ins.accordionControlElement11.Enabled = false;

                            // ADMINISTRACIÓN
                            Form1.ins.accordionControlElement14.Enabled = false;
                        }

                        else if (TIPOA == "3") // CUENTAS POR COBRAR
                        {
                            // OPERACIONES
                            Form1.ins.accordionControlElement5.Enabled = false;
                            Form1.ins.accordionControlElement7.Enabled = false;

                            // CONSULTAS
                            Form1.ins.accordionControlElement9.Enabled = false;

                            // REPORTES
                            Form1.ins.accordionControlElement11.Enabled = false;

                            // ADMINISTRACIÓN
                            Form1.ins.accordionControlElement14.Enabled = false;

                        }

                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Contraseña o usuario incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    SQL.CONEXION.Close();
                }

            }

            catch (Exception ERROR)
            {
                MessageBox.Show("ERROR: " + ERROR, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }

            else
            {
                textBox2.PasswordChar = '*';
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    simpleButton1.PerformClick();
                }
            }

            catch (Exception ERROR)
            {
                MessageBox.Show("ERROR: " + ERROR, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}

