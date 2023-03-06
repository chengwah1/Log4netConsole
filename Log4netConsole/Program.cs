using log4net;
using log4net.Config;

namespace Log4netConsole
{
    internal class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));
        private static readonly Guid _requestId = Guid.NewGuid();
        static void Main(string[] args)
        {
            log4net.ThreadContext.Properties["RequestId"] = _requestId;
            // Configure log4net
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

            // Use log4net to log a message
            _log.Info("Hello, world!");
       
            Console.WriteLine("Hello, World!");
        }
    }
}