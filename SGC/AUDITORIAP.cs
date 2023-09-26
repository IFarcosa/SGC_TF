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
    public partial class AUDITORIAP : DevExpress.XtraEditors.XtraForm
    {

        SQL SQL = new SQL();

        private static AUDITORIAP form;
        public  static AUDITORIAP ins
        {

            get
            {
                if (form == null || form.IsDisposed)
                    form = new AUDITORIAP();
                return form;
            }

            set
            {
                form = value;
            }

        }

        public AUDITORIAP()
        {
            InitializeComponent();
        }

        private void AUDITORIAP_Load(object sender, EventArgs e)
        {

        }

    }

}

