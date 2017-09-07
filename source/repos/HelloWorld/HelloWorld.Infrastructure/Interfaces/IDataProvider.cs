using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Infrastructure.Interfaces
{
    public interface IDataProvider
    {
        /// <summary>
        ///     Gets data
        /// </summary>
        string GetData();
    }
}
