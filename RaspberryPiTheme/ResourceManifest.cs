using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.RaspberryPiTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("RaspberryPiTheme-bootstrap-oc")
                .SetUrl("~/RaspberryPiTheme/css/bootstrap-oc.min.css", "~/RaspberryPiTheme/css/bootstrap-oc.css")
                .SetVersion("1.0.0");

        }
    }
}
