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
    public partial class ECUENTA : DevExpress.XtraEditors.XtraForm
    {
        SQL SQL = new SQL();
        public String CLIENTE;

        private static ECUENTA form;
        public  static ECUENTA ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new ECUENTA();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public ECUENTA()
        {
            InitializeComponent();
        }

        private void ECUENTA_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

    }

}

