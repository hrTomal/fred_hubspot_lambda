using Amazon.Lambda.AspNetCoreServer;

namespace FRED_Hubspot_lambda.Functions
{
    public class Function : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder
                .UseStartup<Startup>();  // Specify your Startup class for the app configuration
        }
    }
}
