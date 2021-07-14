using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CustomAppSettings.Web.Utilities;
using Microsoft.Extensions.Options;

namespace CustomAppSettings.Web.Controllers
{
    [Route("appsettings")]
    public class AppSettingsController : Controller
    {
        protected readonly IConfiguration _configuration;
        protected readonly IOptions<PasswordValidator> _passwordValidatorOptions;

        public AppSettingsController(IConfiguration configuration, IOptions<PasswordValidator> passwordValidatorOptions)
        {
            _configuration = configuration;
            _passwordValidatorOptions = passwordValidatorOptions;
        }

        [Route("using-iconfiguration")]
        public IActionResult UsingIConfiguration()
        {
            return Content(_configuration.GetValue<string>("PasswordValidator:Pattern"), "text/plain");
        }

        [Route("using-ioptions")]
        public IActionResult UsingIOptions()
        {
            return Content(_passwordValidatorOptions.Value.PasswordString, "text/plain");
        }
    }
}
