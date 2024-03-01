using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
	/// <summary>
	/// The basic API Endpoints
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		/// <summary>
		/// Simulates a simple GET request
		/// Summary
		/// </summary>
		/// <param name="sleepTime">Amount of time, in miiliseconds, to wait before returning</param>
		/// <param name="statusCode">The http status code to return</param>
		/// <param name="body">Body to return</param>
		/// <returns></returns>
		[HttpGet(Name = "Get")]
		public IActionResult TestGet([FromQuery] int sleepTime = 10, [FromQuery] int statusCode = 204, [FromQuery] string? body = null)
		{
			Thread.Sleep(sleepTime);
			return StatusCode(statusCode, body);
		}

		/// <summary>
		/// Simulates a simple POST request
		/// Summary
		/// </summary>
		/// <param name="sleepTime">Amount of time, in miiliseconds, to wait before returning</param>
		/// <param name="statusCode">The http status code to return</param>
		/// <param name="body">Body to return</param>
		/// <returns></returns>
		[HttpPost(Name = "Post")]
		public StatusCodeResult TestPost([FromQuery] int sleepTime = 10, [FromQuery] int statusCode = 204, [FromQuery] string? body = null)
		{
			Thread.Sleep(sleepTime);
			return new StatusCodeResult(statusCode);
		}

		/// <summary>
		/// Simulates a simple PUT request
		/// Summary
		/// </summary>
		/// <param name="sleepTime">Amount of time, in miiliseconds, to wait before returning</param>
		/// <param name="statusCode">The http status code to return</param>
		/// <param name="body">Body to return</param>
		/// <returns></returns>
		[HttpPut(Name = "Put")]
		public StatusCodeResult TestPut([FromQuery] int sleepTime = 10, [FromQuery] int statusCode = 201, [FromQuery] string? body = null)
		{
			Thread.Sleep(sleepTime);
			return new StatusCodeResult(statusCode);
		}

		/// <summary>
		/// Simulates a simple DELETE request
		/// Summary
		/// </summary>
		/// <param name="sleepTime">Amount of time, in miiliseconds, to wait before returning</param>
		/// <param name="statusCode">The http status code to return</param>
		/// <param name="body">Body to return</param>
		/// <returns></returns>
		[HttpDelete(Name = "Delete")]
		public StatusCodeResult TestDelete([FromQuery] int sleepTime = 10, [FromQuery] int statusCode = 204, [FromQuery] string? body = null)
		{
			Thread.Sleep(sleepTime);
			return new StatusCodeResult(statusCode);
		}
	}
}