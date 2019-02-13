using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amortyzacja.View
{
    interface IAmortizationView
    {
        TextBox YearTextBox {  get; }
        TextBox SerialNumberTextBox { get; }

        ListView HardwareListView { get; }
    }
}
