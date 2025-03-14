using AjaxOdev.Models;
using AjaxOdev.Repository;
using AjaxOdev.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

namespace AjaxOdev.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _UserRepository;
        private readonly UserProduceService _UserProduceService;
        public UsersController(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Index'e girdi");
            //UserProduceService userProduceService = new(new HttpClient());
            //userProduceService.MockDataUretAsync(5);
            var Users = _UserRepository.GetAll();
            return View(Users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public bool Create([FromBody] User user)
        {
            _UserRepository.Add(user);
                return true;
        }

        public IActionResult Delete(int id)
        {
            _UserRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateRandomUser(int miktar) {
            _UserProduceService.MockDataUretAsync(miktar);
            return View();
        }

        [HttpPost]
        public IActionResult GetUsersByKey([FromBody] SearchRequest request)
        {
            var users = _UserRepository.GetByNamewithKey(request.qUrunAdi);

            if (users == null || !users.Any())
            {
                return Json(new { d = "" }); // Eğer veri yoksa boş döndür
            }

            return Json(new
            {
                d = users.Select(u => new
                {
                    Id = u.Id,
                    AdSoyad = u.Name + " " + u.Surname
                })
            });
        }

        public class SearchRequest
        {
            public string qUrunAdi { get; set; }
        }
    }
}

