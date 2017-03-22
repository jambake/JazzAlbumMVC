using Microsoft.AspNetCore.Mvc;
using JazzAlbumMVC.ViewModels;
using JazzAlbumMVC.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace JazzAlbumMVC.Controllers
{
    public class JazzAlbumController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            AllJazzAlbumsViewModel allJazzAlbumsViewModel = new AllJazzAlbumsViewModel();

            return View(allJazzAlbumsViewModel);
        }

        public IActionResult Add()
        {
            AddJazzAlbumViewModel addJazzAlbumViewModel = new AddJazzAlbumViewModel();

            return View(addJazzAlbumViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddJazzAlbumViewModel addJazzAlbumViewModel)
        {
            if (ModelState.IsValid)
            {
                JazzAlbum newJazzAlbum = new Models.JazzAlbum
                {
                    Artist = addJazzAlbumViewModel.Artist,
                    Title = addJazzAlbumViewModel.Title,
                    Year = addJazzAlbumViewModel.Year,
                    Tracks = addJazzAlbumViewModel.Tracks,
                    BandMembers = addJazzAlbumViewModel.BandMembers
                };

                JazzAlbumData.Add(newJazzAlbum);

                return Redirect("/");
            }

            return View(addJazzAlbumViewModel);

        }

        public IActionResult Remove()
        {
            ViewBag.JazzAlbums = JazzAlbumData.GetAll();

            return View();
        }
        [HttpPost]
        [Route("/JazzAlbum/Remove")]
        public IActionResult RemoveAlbum(int[] albumIds)
        {
            foreach (int id in albumIds)
            {
                JazzAlbumData.Remove(id);
            }
            return Redirect("/");
        }


        public IActionResult Detail(int id)
        {
            JazzAlbum jazzAlbum = JazzAlbumData.GetById(id);
            return View(jazzAlbum);
        }
    }
}
