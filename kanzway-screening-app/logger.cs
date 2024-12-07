using log4net;

namespace kanzway_screening_app
{
    public static class logger
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));
    }
}
