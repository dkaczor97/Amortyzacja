using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amortyzacja.Enums;

namespace Amortyzacja.View
{
    interface IRegisterAssetsView
    {
        TextBox SerialNumberTextBox { get; }
        EAssets AssetsType { get; }
    }
}
