using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsEngine
{
    public static class ApplicationBuildInfo
    {
        public static bool IsDebug { get; } =
#if DEBUG
            true;
#else
            false;
#endif
    }
}
