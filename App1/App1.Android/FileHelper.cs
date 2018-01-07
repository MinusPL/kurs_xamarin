using App1.Helpers;
using System.IO;
using App1.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(FileHelper))]

namespace App1.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}