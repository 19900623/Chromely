﻿/**
 MIT License

 Copyright (c) 2017 Kola Oyewumi

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 SOFTWARE.
 */

namespace Chromely.Infrastructure
{
    using Serilog;
    using System;

    public class ChromelyDefaultLogger : ILogger
    {
        private Serilog.Core.Logger m_logger;
        public string LoggerName { get; set; }

        public ChromelyDefaultLogger(string rollingFile = null)
        {
            if (string.IsNullOrEmpty(rollingFile))
            {
                rollingFile = "logs\\chromely.txt";
            }

            m_logger = new LoggerConfiguration()
             .MinimumLevel.Debug()
             .WriteTo.Console()
             .WriteTo.RollingFile(rollingFile)
             .CreateLogger();
        }

        public void LogInfo(string message)
        {
            m_logger.Information(message);
        }

        public void LogDebug(string message)
        {
            m_logger.Debug(message);
        }

        public void LogVerbose(string message)
        {
            m_logger.Verbose(message);
        }

        public void LogWarn(string message)
        {
            m_logger.Warning(message);
        }

        public void LogError(string message)
        {
            m_logger.Error(message);
        }

        public void LogError(Exception exception, string message = null)
        {
            if (string.IsNullOrEmpty(message))
            {
                message = exception.Message;
            }

            m_logger.Error(message, exception);
        }

        public void LogFatal(string message)
        {
            m_logger.Fatal(message);
        }

        public void LogCritial(string message)
        {
            m_logger.Fatal(message);
        }
    }
}
