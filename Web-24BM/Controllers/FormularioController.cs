using Microsoft.AspNetCore.Mvc;
using Web_24BM.Services;

namespace Web_24BM.Controllers
{
    public class FormularioController : Controller
    {
        private readonly IEmailSenderService _emailSenderService;

        public FormularioController(IEmailSenderService emailSenderService)
        {
            _emailSenderService = emailSenderService;
        }
        public IActionResult Index()
        {
            _emailSenderService.SendEmail("moises.torres@upqroo.edu.mx");
            return View();
        }
    }
}
