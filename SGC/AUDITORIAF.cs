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
    public partial class AUDITORIAF : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static AUDITORIAF form;
        public  static AUDITORIAF ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new AUDITORIAF();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public AUDITORIAF()
        {
            InitializeComponent();
        }

        private void AUDITORIAF_Load(object sender, EventArgs e)
        {

        }

    }

}

