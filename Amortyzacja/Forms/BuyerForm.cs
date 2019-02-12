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
        BuyerPresenter presenter;

        public BuyerForm()
        {
            InitializeComponent();
        }

        private BuyerPresenter Presenter
        {
            get
            {
                if (presenter == null)
                {
                    presenter = new BuyerPresenter(this);
                }
                return presenter;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void addHardware_Click(object sender, EventArgs e)
        {
           
        }

        private void addSoftware_Click(object sender, EventArgs e)
        {
            
        }

        private void registerHardware_Click(object sender, EventArgs e)
        {
            
            

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
