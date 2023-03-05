using Newtonsoft.Json;
using System.Net;

namespace ShoppingApi.Middleware
{
    public class CustomExceptionMiddleware
    {
        public RequestDelegate _next { get; set; }

        public CustomExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                await HandleException(context,ex);
            }

        }

        public Task HandleException(HttpContext context,Exception ex)
        {
            context.Response.StatusCode=(int)HttpStatusCode.InternalServerError;
            context.Response.ContentType="application/json";

            string message = $"Error {context.Request.Method}  {context.Response.StatusCode} Error message{ex.Message} ";

            JsonConvert.SerializeObject(new { error = ex.Message }, Formatting.None);
            
            return context.Response.WriteAsync(message);    
        }


            
    }
}
