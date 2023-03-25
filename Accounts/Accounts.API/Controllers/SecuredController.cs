using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.API.Controllers;

[Authorize]
[ApiController]
[Route("Secured/api/[controller]")]
public abstract class SecuredController : ControllerBase
{
}