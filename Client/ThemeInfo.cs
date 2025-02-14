using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Themes;
using Oqtane.Shared;
using System;

namespace Oqtane.Theme.Arsha
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Arsha",
            Version = "6.0.0",
            PackageName = "Oqtane.Theme.Arsha",
            ThemeSettingsType = "Oqtane.Theme.Arsha.ThemeSettings, Oqtane.Theme.Arsha.Client.Oqtane",
            ContainerSettingsType = "Oqtane.Theme.Arsha.ContainerSettings, Oqtane.Theme.Arsha.Client.Oqtane",
            Resources = new List<Resource>()
            {
                // Google Fonts
                new Stylesheet("https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i%7CRaleway:300,300i,400,400i,500,500i,600,600i,700,700i%7CPoppins:300,300i,400,400i,500,500i,600,600i,700,700i"),
                // Vendor CSS Files
                new Stylesheet("~/assets/vendor/aos/aos.css"),
                new Stylesheet("~/assets/vendor/bootstrap/css/bootstrap.min.css"),
                new Stylesheet("~/assets/vendor/bootstrap-icons/bootstrap-icons.css"),
                new Stylesheet("~/assets/vendor/boxicons/css/boxicons.min.css"),
                new Stylesheet("~/assets/vendor/glightbox/css/glightbox.min.css"),
                new Stylesheet("~/assets/vendor/remixicon/remixicon.css"),
                new Stylesheet("~/assets/vendor/swiper/swiper-bundle.min.css"),
                // Template Main CSS File
                new Stylesheet("~/assets/css/style.css"),
                // Vendor JS Files
                new Script("~/assets/vendor/aos/aos.js"),
                new Script("~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js"),
                new Script("~/assets/vendor/glightbox/js/glightbox.min.js"),
                new Script("~/assets/vendor/isotope-layout/isotope.pkgd.min.js"),
                new Script("~/assets/vendor/swiper/swiper-bundle.min.js"),
                new Script("~/assets/vendor/waypoints/noframework.waypoints.js"),
                // Template Main JS File 
                new Script("~/assets/js/main.js", "", "", ResourceLocation.Body, ResourceLoadBehavior.Always, null, "", "", RenderModes.Static),
                new Script("~/assets/js/interop.js", "", "", ResourceLocation.Body, ResourceLoadBehavior.None, null, "", "", RenderModes.Interactive)
            }
        };
    }
}
