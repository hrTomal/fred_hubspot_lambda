using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FRED_Hubspot_lambda.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WebhookController : ControllerBase
{
    
    [HttpPost]
    [Route("receive")]
    public IActionResult ReceiveWebhook([FromBody] dynamic webhookData)
    {
        try
        {
            Console.WriteLine(webhookData);
            return Ok(new { message = "Webhook received successfully", data = webhookData });
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing webhook: " + ex.Message);
            return StatusCode(500, new { message = "Internal server error", error = ex.Message });
        }
    }

}
