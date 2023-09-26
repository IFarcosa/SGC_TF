using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace SGC
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        SQL SQL = new SQL();

        private static Form1 form;
        public  static Form1 ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new Form1();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            PEDIDOS.ins.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            APEDIDOS.ins.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            CONSULTAP.ins.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            HOJAR.ins.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            CONSULTAHR.ins.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            LOCALIZACIONF.ins.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            CONSULTAF.ins.Show();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            TRAZABILIDADF.ins.Show();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            CONSULTAC.ins.Show();
        }

    }

}

