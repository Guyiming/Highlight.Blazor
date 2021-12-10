using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HighlightBlazor
{
    public class HighlightService
    {
        IJSRuntime _js;
        public HighlightService(IJSRuntime js)
        {
            _js = js;
        }
        public async Task SetStyleAsync(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                await _js.InvokeVoidAsync("loadCss", url);
            }
        }
    }
}
