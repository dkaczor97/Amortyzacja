using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.View;

namespace Amortyzacja
{
    public partial class AccountantForm : Form,IAccountantView
    {
        public AccountantForm()
        {
            InitializeComponent();
        }

     

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
