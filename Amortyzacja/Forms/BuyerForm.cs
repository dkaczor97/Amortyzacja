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
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class BuyerForm : Form,IBuyerView
    {
        public BuyerForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void addHardware_Click(object sender, EventArgs e)
        {
            BuyerPresenter buyerPresenter=new BuyerPresenter();
            buyerPresenter.AddHardware();
        }

        private void addSoftware_Click(object sender, EventArgs e)
        {
            BuyerPresenter buyerPresenter=new BuyerPresenter();
            buyerPresenter.AddSoftware();
        }

        private void registerHardware_Click(object sender, EventArgs e)
        {
            BuyerPresenter buyerPresenter=new BuyerPresenter();
            buyerPresenter.RegisterHardware();

        }

        private void registerSoftware_Click(object sender, EventArgs e)
        {
            
        }

        private void freeHardware_Click(object sender, EventArgs e)
        {

        }

        private void freeSoftware_Click(object sender, EventArgs e)
        {

        }
    }
}
