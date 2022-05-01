﻿using Microsoft.Extensions.Logging;
using NLog;

namespace RegisterAndLoginApp.Services.Utility
{
    public class MyLogger : Ilogger
    {
        private static MyLogger instance;
        private static Logger logger;


        public static MyLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new MyLogger();
            }
            return instance;
        }

        private Logger GetLogger()
        {
            if(MyLogger.logger == null)
            {
                MyLogger.logger = LogManager.GetLogger("LoginAppLoggerrule");
            }
            return MyLogger.logger;
        }

        public void Debug(string messsage)
        {
            GetLogger().Debug(messsage);
        }

        public void Error(string message)
        {
            GetLogger().Error(message);
        }

        public void Info(string message)
        {
            GetLogger().Info(message);
        }

        public void Warning(string message)
        {
            GetLogger().Warn(message);
        }

    }
}
