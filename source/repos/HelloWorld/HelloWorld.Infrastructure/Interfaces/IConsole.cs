using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Infrastructure.Interfaces
{
    public interface IConsole
    {
        /// <summary>
        ///     Writes to the Console
        /// </summary>
        /// <param name="message">Message to write</param>
        void Write(string message);

        /// <summary>
        ///     Writes a line to the Console
        /// </summary>
        /// <param name="message">Message to write</param>
        void WriteLine(string message);

        /// <summary>
        ///     Writes to the Console.Error (standard error)
        /// </summary>
        /// <param name="message">Message to write</param>
        void ErrorWrite(string message);

        /// <summary>
        ///     Writes a line to the Console.Error (standard error)
        /// </summary>
        /// <param name="message">Message to write</param>
        void ErrorWriteLine(string message);
    }
}
