using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TE.Core.Domain;
using TE.Core.Interfaces;
using TE.Core.Services;

namespace TE.UI.WEB.Controllers
{
    public class TacheController : Controller
    {
        IUnitOfWork UnitOfWork;
        IService<Tache> TacheService;
        IService<Sprint> SprintService;
        IService<Member> MemberService;
        public TacheController(IUnitOfWork unitOfWork, IService<Tache> tacheService, IService<Sprint> sprintService, IService<Member> memberService)
        {
            UnitOfWork = unitOfWork;
            TacheService = tacheService;
            SprintService = sprintService;
            MemberService = memberService;
        }


        // GET: TacheController
        public ActionResult Index()
        {
            return View(TacheService.GetAll().Where(e=>e.Etat==EtatTache.Ouverte).OrderBy(t=>t.Titre));
        }

        // GET: TacheController/Details/5
        public ActionResult Details(string id)
        {

            return View(MemberService.Get(id));
        }

        // GET: TacheController/Create
        public ActionResult Create()
        {
            @ViewBag.SprintKey = new SelectList(SprintService.GetAll(), "Id", "Id");
            @ViewBag.MemberKey = new SelectList(MemberService.GetAll(), "Matricule", "Matricule");
            return View();
        }

        // POST: TacheController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tache tache)
        {
            try
            {
                TacheService.Add(tache);
                UnitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TacheController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TacheController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TacheController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TacheController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
