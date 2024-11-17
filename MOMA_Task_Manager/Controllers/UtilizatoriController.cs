using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MOMA.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MOMA_Task_Manager.Controllers
{
    public class UtilizatoriController : Controller
    {
        private readonly MOMA_Db_Context _db;
        private readonly UserManager<IdentityUser> _userManager;

        public UtilizatoriController(MOMA_Db_Context db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var ut = from utilizator in _db.Utilizatoris
                     orderby utilizator.Nume
                     select utilizator;
            ViewBag.Utilizatoris = ut;
            return View();
        }
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Utilizatori s)
        {
            try
            {
                _db.Utilizatoris.Add(s);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public async Task<IActionResult> CopyAspNetUsersToUtilizatoris()
        {
            var aspNetUsers = _userManager.Users.ToList();

            foreach (var user in aspNetUsers)
            {
                var utilizator = new Utilizatori
                {
                    Nume = user.UserName,
                    Prenume = user.Email 
                };

                _db.Utilizatoris.Add(utilizator);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
