using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.Infrastructure;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Outlook.WPF.SpotifyAPI.ApiServices.Category;
using Outlook.WPF.SpotifyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DetailModule.Services
{
    public class GenerateCategoryModel : IGenerateCategoryModel
    {
        public async Task<List<CategoryModel>> Generate()
        {

            List<CategoryModel> categoryModels = new List<CategoryModel>();
            await Task.Run(async() =>
            {
                var service=DependencyInjection.serviceProvider.GetService<ICategoriesApi>();

                var categories =await service.Get();

                categoryModels.AddRange(categories.Categories.Items.Select(c => new CategoryModel { Name = c.Name, ImageUri = c.Icons[0].Url }));
            }).ConfigureAwait(false);

            return categoryModels;
        }
    }
}
