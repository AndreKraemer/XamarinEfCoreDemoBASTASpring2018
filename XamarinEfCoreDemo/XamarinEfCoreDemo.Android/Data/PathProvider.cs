
using System;
using Xamarin.Forms;
using XamarinEfCoreDemo.Data;
using XamarinEfCoreDemo.Droid.Data;

[assembly:Dependency(typeof(PathProvider))]
namespace XamarinEfCoreDemo.Droid.Data
{
    public class PathProvider : IPathProvider
    {
        public string GetDbFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}