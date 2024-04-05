using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class TopResultModel:BindableBase
    {

        public string ImageUri { get; set; }

        public string Name { get; set; }
  
        public string Type { get; set; }

    }
}
