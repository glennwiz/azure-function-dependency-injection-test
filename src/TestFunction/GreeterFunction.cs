using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;

namespace ExampleFunction
{
    public static class GreeterFunction
    {
        [FunctionName("Greeter")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")]HttpRequest req,
            [Inject]ISingletonGreeter singletonGreeter1,
            ILogger logger)
        {
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var result = String.Join(Environment.NewLine, new[] {
                $"Singleton: {singletonGreeter1.Greet()}"
            });
            return new OkObjectResult(result);
        }
    }
}
