﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_Kelompok21_PABD
{
    public partial class Data_Kendaraan : Form
    {
        public Data_Kendaraan()
        {
            InitializeComponent();
        }

        private void Data_Kendaraan_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
        }
    }
}
