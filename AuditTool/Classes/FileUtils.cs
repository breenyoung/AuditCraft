using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;

namespace AuditTool.Classes
{
    public class FileUtils
    {
        public static bool RetrieveImageFromUrl(string url, string destinationPath, string destinationFile)
        {
            bool result = true;

            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();

                Stream stream = res.GetResponseStream();

                Image img = Image.FromStream(stream);

                img.Save(destinationPath + "\\" + destinationFile);            

            }
            catch (Exception ex)
            {
                result = false;
                //throw;
            }

            return result;
        }

        public static bool DoesFileExist(string file)
        {
            return File.Exists(file);
        }
    }
}
