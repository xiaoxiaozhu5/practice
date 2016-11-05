using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    class Program
    {
        static void Main(string[] args) {
            LoggerFactory factory;
            //Logger logger;
            factory = new EEPROMLoggerFactory();
            //logger = factory.createLogger();
            //logger.writelog();
            factory.writeLog();
        }
    }

    public abstract class Logger
    {
        public abstract void writelog();
    }

    class DatabaseLogger : Logger
    {
        public override void writelog() {
            Console.WriteLine("数据库日志记录");
        }
    }

    class FileLogger : Logger
    {
        public override void writelog() {
            Console.WriteLine("文件日志记录");
        }
    }

    class  EEPROMLogger : Logger
    {
        public override void writelog() {
            Console.WriteLine("EEPROM日志记录");
        }
    }

    public abstract class LoggerFactory
    {
        public abstract Logger createLogger();
        public abstract Logger createLogger(string args);
        public abstract Logger createLogger(object obj);
        public void writeLog() {
            Logger logger = this.createLogger();
           logger.writelog();
        }
    }

    class DatabaseLoggerFactory : LoggerFactory
    {
        public override Logger createLogger() {
            Logger logger = new DatabaseLogger();
            return logger;
        }
        public override Logger createLogger(object obj) {
            Logger logger = new DatabaseLogger();
            return logger;
        }
        public override Logger createLogger(string args) {
            Logger logger = new DatabaseLogger();
            return logger;
        }
    }

    class FileLoggerFactory : LoggerFactory
    {
        public override Logger createLogger() {
            Logger logger = new FileLogger();
            return logger;
        }
        public override Logger createLogger(object obj) {
            Logger logger = new FileLogger();
            return logger;
        }
        public override Logger createLogger(string args) {
            Logger logger = new FileLogger();
            return logger;
        }
    }

    class EEPROMLoggerFactory : LoggerFactory
    {
        public override Logger createLogger() {
            Logger logger = new EEPROMLogger();
            return logger;
        }
        public override Logger createLogger(object obj) {
            Logger logger = new EEPROMLogger();
            return logger;
        }
        public override Logger createLogger(string args) {
            Logger logger = new EEPROMLogger();
            return logger;
        }
    }
}
