using Microsoft.AspNetCore.Mvc;

namespace Accounts.API.Controllers.Secured;

public sealed class AccountsController : SecuredController
{
    public IActionResult Get()
    {
        return Ok();
    }
}