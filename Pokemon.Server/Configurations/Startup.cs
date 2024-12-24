namespace Pokemon.Server.Configurations
{
    internal static class Startup
    {
        internal static WebApplicationBuilder AddConfigurations(this WebApplicationBuilder builder)
        {
            const string configurationsDirectory = "Configurations";
            var env = builder.Environment;
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"{configurationsDirectory}/apisettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"{configurationsDirectory}/apisettings.{env.EnvironmentName}.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();

            return builder;
        }
    }
}
