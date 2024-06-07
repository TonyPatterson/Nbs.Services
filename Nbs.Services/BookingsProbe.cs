using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Nbs.Services;

public class BookingsProbe(ILogger<BookingsProbe> _logger)
{
    [Function(nameof(BookingsProbe))]
    public IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "bookings-probe")] HttpRequestData request)
    {
        _logger.LogInformation("Healthcheck probe hit.");

        return new OkObjectResult("Healthcheck probe responded.");
    }
}
