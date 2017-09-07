using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Infrastructure.Interfaces
{
    public interface ILogger
    {
        /// <summary>
        ///     Write an INFO message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="otherProperties">Other properties</param>
        void Info(string message, Dictionary<string, object> otherProperties);

        /// <summary>
        ///     Write an DEBUG message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="otherProperties">Other properties</param>
        void Debug(string message, Dictionary<string, object> otherProperties);

        /// <summary>
        ///     Write an ERROR message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="otherProperties">Other properties</param>
        /// <param name="exception">Exception instance</param>
        void Error(string message, Dictionary<string, object> otherProperties, Exception exception);
    }
}
