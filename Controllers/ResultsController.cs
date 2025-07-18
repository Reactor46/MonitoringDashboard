using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class ResultsController : Controller
{
    private readonly AppDbContext _context;

        public ResultsController(AppDbContext context)
            {
                    _context = context;
                        }

                            public async Task<IActionResult> Index()
                                {
                                        var results = await _context.Results.ToListAsync();
                                                return View(results);
                                                    }
                                                    }
                                                    