using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Browser_game.Models.Logger
{
    public class FileLoggerProvider:ILoggerProvider
    {
        
            private string filePath;

            public FileLoggerProvider(string _filePath)
            {
                this.filePath = _filePath;
            }
            public ILogger CreateLogger(string categoryName)
            {
                return new FileLogger(filePath);
            }

            public void Dispose()
            {
            }
        
    }
}
