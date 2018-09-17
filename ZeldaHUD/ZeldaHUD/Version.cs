using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace zeldaGui
{
    class Version
    {

        public static bool CheckUpdate()
        {
			bool result = false;
			try
			{
				WebClient web = new WebClient();
				//web.
				throw new NotImplementedException();
			}
			catch { result = false; }
			return result;
            //string CurrentVersion = "3.0";
            //string checkVersion = "";
            //using (WebClient wc = new WebClient())
            //{
            //    checkVersion = wc.DownloadString("https://github.com/Formedras/ZeldaHud/version.txt");
            //}
            //if (!checkVersion.Contains(CurrentVersion))
            //{
            //    return true;
            //}
            //return false;
        }

    }
}
