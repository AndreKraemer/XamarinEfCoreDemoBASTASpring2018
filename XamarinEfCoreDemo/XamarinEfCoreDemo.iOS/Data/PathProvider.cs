using System;
using System.IO;
using Xamarin.Forms;
using XamarinEfCoreDemo.Data;
using XamarinEfCoreDemo.iOS.Data;

[assembly: Dependency(typeof(PathProvider))]
namespace XamarinEfCoreDemo.iOS.Data
{
    public class PathProvider : IPathProvider
    {
        public string GetDbFolder()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "..",
                "Library");
            return path;
        }
    }
}