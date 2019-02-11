using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.View;

namespace Amortyzacja.Presenters
{
    public class WorkerPresenter
    {
        private IWorkerView _workerView;
        public WorkerPresenter(IWorkerView workerView)
        {
            _workerView = workerView;
            _workerView.Presenter = this;
        }
    }
}
