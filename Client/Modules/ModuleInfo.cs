using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Theme.Arsha
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Arsha - Content",
            Description = "Add professionally styled content to your page",
            Version = "6.0.0",
            PackageName = "Oqtane.Theme.Arsha"
        };
    }
}
