using System;
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
        public AdminPresenter Presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AdminForm()
        {
            InitializeComponent();
        }


        private void freeHardware_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter=new AdminPresenter(this);
            adminPresenter.FreeHardware();
           

            
        }

        private void occupiedHardware_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
            adminPresenter.OccupiedHardware();
        }

        private void occupiedSoftware_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
            adminPresenter.OccupiedSoftware();
        }

        private void freeSoftware_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
            adminPresenter.FreeSoftware();
        }

        private void tax_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
        }

        private void assetsCosts_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
        }

        private void registerHardware_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
        }

        private void registerSoftware_Click(object sender, EventArgs e)
        {
            AdminPresenter adminPresenter = new AdminPresenter(this);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
