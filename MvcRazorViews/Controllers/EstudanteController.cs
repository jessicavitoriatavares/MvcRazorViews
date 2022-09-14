using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>
    {
        new EstudanteViewModel(1, "Maria", "R. Ma, n.1", true),
        new EstudanteViewModel(2, "Pedro", "R. Pe, n.2", false),
        new EstudanteViewModel(3, "Isabella", "R. Isa, n.3", true),
    };

    public IActionResult Index()
    {
        //var estudantesVazia = new List<EstudanteViewModel>();

        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}