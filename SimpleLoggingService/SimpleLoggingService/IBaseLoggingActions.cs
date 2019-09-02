using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLoggingService
{
    public interface IBaseLoggingActions
    {
        bool SaveMessage<T>(string message);
    }
}
