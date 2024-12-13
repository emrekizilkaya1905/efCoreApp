using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
namespace efcoreApp.Controllers
{

  public class CourseController : Controller
  {
    private readonly DataContext _context;
    public CourseController(DataContext context)
    {
      _context = context;
    }
       public IActionResult Create()
    {
        return View();
    }
  }

}