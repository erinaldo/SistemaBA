﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class LoadingReportes : Form
    {
        public LoadingReportes()
        {
            InitializeComponent();
        }

        private void LoadingReportes_Load(object sender, EventArgs e)
        {
            MiLoading.Image = RecursosBA.loading;
        }
    }
}
