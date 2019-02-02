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

namespace Amortyzacja
{
    public partial class LoginForm : Form,ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPresenter loginPresenter=new LoginPresenter(this);
        }

        public string Login
        {
            get => LoginBox.Text;
            set => LoginBox.Text = value;
        }

        public string Password
        {
            get => PasswordBox.Text;
            set => PasswordBox.Text = value;
        }
    }
}
