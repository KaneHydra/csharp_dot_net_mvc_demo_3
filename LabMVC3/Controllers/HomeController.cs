using LabMVC3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabMVC3.Controllers
{
    // ���ҬO�_�n�J�A�p�G�S���n�J�A�hredirect�^��n�J����
    // �p�G�o�{���ʤ�using,�b����i���B��Ctrl+.
    // �L�|���X�i��ݭnusing��lib
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // �o�ӭ������\�ΦW�A���εn�J�N���˵�
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
