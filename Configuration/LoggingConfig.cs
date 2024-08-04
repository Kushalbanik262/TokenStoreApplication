using Serilog;

namespace TokenApp.Configuration
{
    public static class LoggingConfig
    {
        /// <summary>
        /// Configuring Serilog logger file 
        /// </summary>
        /// <param name="hostBuilder"></param>
        /// <returns>
        /// Current WebApplicationBuilder
        /// </returns>
        public static WebApplicationBuilder configureSerilog(this WebApplicationBuilder hostBuilder)
        {
            hostBuilder.Host.UseSerilog(
                (context, configuration) =>
                {
                    configuration.ReadFrom.Configuration(context.Configuration);
                });
            return hostBuilder;
        }
    }
}
