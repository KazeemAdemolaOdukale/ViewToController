using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(typeof(ViewToController.BundleConfigurationActivator), "Activate")]
namespace ViewToController
{
    public static class BundleConfigurationActivator
    {
        public static void Activate()
        {
            BundleTable.Bundles.RegisterConfigurationBundles();
        }
    }
}