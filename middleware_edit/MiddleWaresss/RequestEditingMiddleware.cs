
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace middleware_edit.MiddleWaresss
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;
        

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;

        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Host.ToString() == "/HMD")
                await context.Response.WriteAsync("Welcome HMD");
            else
                await _requestDelegate.Invoke(context);
        }
    }
}
