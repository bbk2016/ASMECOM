﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Infrastructure.Logging
{
    public class LoggingService
    {
                 private Logger _logger;

        public LoggingService()
        {
            _logger = LogManager.CreateNullLogger();
        }
        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(Exception x)
        {
            Error(LogUtility.BuildExceptionMessage(x));
        }

        public void Error(string message, Exception x)
        {
            _logger.ErrorException(message, x);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(Exception x)
        {
            Fatal(LogUtility.BuildExceptionMessage(x));
        }
    }
}
