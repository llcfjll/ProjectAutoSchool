using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSchool
{
    public partial class AutoSchool : Form
    {
        public AutoSchool()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CRM CRM = new CRM();
            CRM.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
