using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace CustomAppSettings.Web.Controllers
{
    [Route("appsettings")]
    public class AppSettingsController : Controller
    {
        protected readonly IConfiguration _configuration;

        public AppSettingsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("using-iconfiguration")]
        public IActionResult UsingIConfiguration()
        {
            return Content(_configuration.GetValue<string>("PasswordValidator:Pattern"), "text/plain");
        }

    }

}
