using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		/// <summary>
		/// Summary
		/// </summary>
		/// <param name="sleepTime">Amount of time to wait before returning</param>
		/// <param name="statusCode">Status code to return</param>
		/// <param name="body">Body to return</param>
		/// <returns></returns>
		[HttpGet(Name = "Get")]
		public IActionResult TestGet([FromQuery] int sleepTime, [FromQuery] int statusCode = 200, [FromQuery] string body="hello")
		{
			Thread.Sleep(sleepTime);
			return StatusCode(statusCode, body);
		}

		[HttpPost(Name = "Post")]
		public StatusCodeResult TestPost([FromQuery] int sleepTime, [FromQuery] int statusCode = 204)
		{
			Thread.Sleep(sleepTime);
			return new StatusCodeResult(statusCode);
		}

		[HttpPut(Name = "Put")]
		public StatusCodeResult TestPut([FromQuery] int sleepTime, [FromQuery] int statusCode = 201)
		{
			Thread.Sleep(sleepTime);
			return new StatusCodeResult(statusCode);
		}

		/// <summary>
		/// Simulates a HTTP DELETE call
		/// </summary>
		/// <param name="sleepTime">The amout of time the call will wait bedore returning</param>
		/// <param name="statusCode"></param>
		/// <returns></returns>
		[HttpDelete(Name = "Delete")]
		public StatusCodeResult TestDelete([FromQuery] int sleepTime, [FromQuery] int statusCode = 204)
		{
			Thread.Sleep(sleepTime);
			return new StatusCodeResult(statusCode);
		}
	}
}