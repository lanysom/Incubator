using Incubator.UI.Model;
using Incubator.UI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incubator.UI.ViewModel
{
    public class MainViewModel 
    {
        private readonly IBatchRepository _batchRepository;

        public Batch CurrentBatch
        {
            get
            {
                return _batchRepository.GetCurrent();
            }
        }

        public MainViewModel(IBatchRepository batchRepository)
        {
            _batchRepository = batchRepository;
        }
    }
}
