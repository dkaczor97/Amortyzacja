﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Presenters;

namespace Amortyzacja.View
{
    interface IWorkerView
    {
        WorkerPresenter Presenter { set; get; }
    }
}
