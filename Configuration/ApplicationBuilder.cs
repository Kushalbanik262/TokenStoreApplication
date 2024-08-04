using TokenApp.Services;
using TokenApp.Services.Interfaces;

namespace TokenApp.Configuration
{
    public static class ApplicationBuilder
    {
        public static WebApplicationBuilder configureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<ITokenBuilder, TokenBuilderService>();
            builder.Services.AddSingleton<ITokenOperation,InMemoryTokenStorageService>();
            //builder.AddSingleton<ITokenBuilder,>
            return builder;
        }
    }
}
