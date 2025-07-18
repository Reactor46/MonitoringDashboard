using System.Collections.Generic;
using System.IO;
using System.Linq;

public class LogService
{
    private readonly string _logPath = "C:\\Logs\\app.log";

        public IEnumerable<string> GetRecentLogs(int lineCount = 50)
            {
                    if (!File.Exists(_logPath)) return new List<string>();
                            return File.ReadLines(_logPath).Reverse().Take(lineCount);
                                }
                                }
                                