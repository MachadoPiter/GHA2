using GHA2.Service;
using Microsoft.AspNetCore.Mvc;

namespace GHA2.Controllers;

[ApiController]
[Route("[controller]")]
public class CalcController(ILogger<CalcController> logger, ICalcService calcService) : ControllerBase
{
    private readonly ILogger<CalcController> _logger = logger;

    [HttpGet(Name = "Add")]
    public int Add([FromQuery] int num1 = 1, [FromQuery] int num2 = 5)
    {
        _logger.LogInformation("Adding {num1}, {num2}", num1, num2);
        return calcService.Add(num1, num2);
    }
}
