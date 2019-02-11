using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Presenters;
using Amortyzacja.View;

namespace Amortyzacja.Forms
{
    public partial class AddWorkerForm : Form,IAddWorkerView
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        public AddWorkerPresenter Presenter { set; get; }
    }
}
