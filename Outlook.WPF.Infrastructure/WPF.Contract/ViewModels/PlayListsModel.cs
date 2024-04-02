﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class PlayListsModel
    {

        public string ImageUri { get; set; }=default!;

        public string Name { get; set; } = default!;

        public string Owner { get; set; } = default!;
    }
}
