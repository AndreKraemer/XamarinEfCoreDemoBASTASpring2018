using Windows.Storage;
using Xamarin.Forms;
using XamarinEfCoreDemo.Data;
using XamarinEfCoreDemo.UWP.Data;

[assembly:Dependency(typeof(PathProvider))]
namespace XamarinEfCoreDemo.UWP.Data
{
    public class PathProvider : IPathProvider
    {
        public string GetDbFolder()
        {
            return ApplicationData.Current.LocalFolder.Path;
        }
    }
}