namespace ShoppingApi.Middleware
{
    public static class UseCustomExceptionMiddleware
    {
        public static IApplicationBuilder ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomExceptionMiddleware>();

        }
    }
}
