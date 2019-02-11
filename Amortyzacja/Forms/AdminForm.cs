﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Presenter;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class AdminForm : Form,IAdminView
    {
        

        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminPresenter Presenter { get; set; }


        private void freeHardware_Click(object sender, EventArgs e)
        {
            
           

            
        }

        private void occupiedHardware_Click(object sender, EventArgs e)
        {
            
        }

        private void occupiedSoftware_Click(object sender, EventArgs e)
        {
            
        }

        private void freeSoftware_Click(object sender, EventArgs e)
        {
           
        }

        private void tax_Click(object sender, EventArgs e)
        {
            
        }

        private void assetsCosts_Click(object sender, EventArgs e)
        {
            
        }

        private void registerHardware_Click(object sender, EventArgs e)
        {
            
        }

        private void registerSoftware_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Presenter.Logout();
        }
    }
}
