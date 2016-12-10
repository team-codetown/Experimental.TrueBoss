using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibrary
{
    public interface IBackup_Log
    {
        bool SaveLogToServer(object actionObject);
    }
}
