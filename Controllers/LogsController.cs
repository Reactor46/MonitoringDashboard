using Microsoft.AspNetCore.Mvc;

public class LogsController : Controller
{
    private readonly LogService _logService;

        public LogsController(LogService logService)
            {
                    _logService = logService;
                        }

                            public IActionResult Index()
                                {
                                        var logs = _logService.GetRecentLogs();
                                                return View(logs);
                                                    }
                                                    }
                                                    