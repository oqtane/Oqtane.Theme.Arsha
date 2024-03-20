using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Themes;
using Oqtane.Shared;

namespace Oqtane.Theme.Arsha
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Arsha",
            Version = "1.0.0",
            PackageName = "Oqtane.Theme.Arsha",
            ThemeSettingsType = "Oqtane.Theme.Arsha.ThemeSettings, Oqtane.Theme.Arsha.Client.Oqtane",
            Resources = new List<Resource>()
            {
                // Google Fonts
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i%7CRaleway:300,300i,400,400i,500,500i,600,600i,700,700i%7CPoppins:300,300i,400,400i,500,500i,600,600i,700,700i" },
                // Vendor CSS Files
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/aos/aos.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/bootstrap/css/bootstrap.min.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/bootstrap-icons/bootstrap-icons.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/boxicons/css/boxicons.min.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/glightbox/css/glightbox.min.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/remixicon/remixicon.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/vendor/swiper/swiper-bundle.min.css" },
                // Template Main CSS File
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/assets/css/style.css" },
                // Vendor JS Files
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/aos/aos.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/glightbox/js/glightbox.min.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/isotope-layout/isotope.pkgd.min.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/swiper/swiper-bundle.min.js", Location = ResourceLocation.Body },
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/vendor/waypoints/noframework.waypoints.js", Location = ResourceLocation.Body },
                // Template Main JS File 
                new Resource { ResourceType = ResourceType.Script, Url = "~/assets/js/main.js", Location = ResourceLocation.Body, Reload = true }
            }
        };
    }
}
