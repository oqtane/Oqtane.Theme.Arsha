using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Oqtane.Theme.Arsha
{
    public class Interop
    {
        private readonly IJSRuntime _jsRuntime;

        public Interop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task Load()
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync(
                    "Oqtane.Arsha.load");
            }
            catch
            {
                // handle exception
            }
        }
    }
}
