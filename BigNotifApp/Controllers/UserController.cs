using System.Threading.Tasks;
using System.Web.Mvc;

namespace BigNotifApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public async Task<ActionResult> Index()
        {
            var users = await _userService.GetUsers();
            return View(users);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }

        public ActionResult DeleteUser()
        {
            return RedirectToAction("Index");
        }
    }
}