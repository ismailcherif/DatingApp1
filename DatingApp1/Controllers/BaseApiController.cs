using System;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BaseApiController: ControllerBase
	{
		public BaseApiController()
		{
		}
	}
}

