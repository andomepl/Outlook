using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public interface IPaginatable<T>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
        string? Next { get; set; }

        List<T>? Items { get; set; }

    }

    public interface IPaginatable<T, TNext>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
        string? Next { get; set; }

        List<T>? Items { get; set; }
    }

}
