using adibideaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace adibideaMVC.Controllers
{
    public class AgendaController : Controller
    {
        public ActionResult Details()
        {
            Kontaktua kontaktua = new Kontaktua("13456765", "izaskun", "Kortabitarte");
            kontaktua.Emaila = "ikortabitarte@uni.eus";
            return View(kontaktua);
        }

        public ActionResult Index()
        {
            List<Kontaktua> lstKontaktuak = new List<Kontaktua>();
            Kontaktua kontaktua1 = new Kontaktua("13456765", "izaskun", "Kortabitarte");
            kontaktua1.Emaila = "ikortabitarte@uni.eus";
            lstKontaktuak.Add(kontaktua1);

            Kontaktua kontaktua2 = new Kontaktua("13452345", "pepe", "Fernandez");
            kontaktua2.Emaila = "pfernandez@uni.eus";
            lstKontaktuak.Add(kontaktua2);

            Kontaktua kontaktua3 = new Kontaktua("14567874", "jon", "Perez");
            kontaktua3.Emaila = "jperez@uni.eus";
            lstKontaktuak.Add(kontaktua3);

            return View(lstKontaktuak);
        }
    }
}
