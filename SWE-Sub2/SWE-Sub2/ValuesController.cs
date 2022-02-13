using Microsoft.AspNetCore.Mvc;

namespace SWE_Sub2
{
	[Route("api/values")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return this.Ok(new { time = DateTime.Now });
		}
	}
}
