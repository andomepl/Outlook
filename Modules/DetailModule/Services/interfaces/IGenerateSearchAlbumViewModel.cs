using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailModule.Services.interfaces
{
    public interface IGenerateSearchAlbumViewModel
    {

        Task<List<AlbumModel>> Generate(string searchText);
    }
}
