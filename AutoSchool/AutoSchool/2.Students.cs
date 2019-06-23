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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void studentcard_b_lkm(object sender, EventArgs e)
        {
            StudentCard StudentCard = new StudentCard();
            StudentCard.Show();
        }
    }
}
