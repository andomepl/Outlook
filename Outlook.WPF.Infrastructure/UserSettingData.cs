using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure
{
    public static class UserSettingData
    {
        public const string defaultApplicationSuffix= "OutlookWPF";

        public static readonly string UserDataPath=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),defaultApplicationSuffix);
    
        

        static UserSettingData()
        {
            if(Directory.Exists(UserDataPath))
            {
                return;
            }

            else
            {
                var directoryInfo= Directory.CreateDirectory(UserDataPath);
               
            }

        }


    
    }
}
