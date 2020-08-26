using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DependencyCollector;
using Microsoft.ApplicationInsights.Extensibility;

namespace jamie_devops.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        public string Get(int id)
        {
            TelemetryConfiguration configuration = TelemetryConfiguration.CreateDefault();
            configuration.InstrumentationKey = "61b7fb78-d207-411d-b7c5-59df48e5703f";
            var telemetryClient = new TelemetryClient(configuration);
            telemetryClient.TrackTrace("Greeting Controller Get Id: " + id);
            return "Hello World! v5.0 " + id;
        }
    }
}