﻿using System;
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

        private void students_b_lkm(object sender, EventArgs e)
        {
            Students Students = new Students();
            Students.Show();
        }
        private void teachers_b_lkm(object sender, EventArgs e)
        {
            Teachers Teachers = new Teachers();
            Teachers.Show();
        }
    }
}
