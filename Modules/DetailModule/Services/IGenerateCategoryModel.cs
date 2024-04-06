﻿using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailModule.Services
{
    public interface IGenerateCategoryModel
    {

        Task<List<CategoryModel>> Generate();
    }
}