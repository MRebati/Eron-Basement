using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eron.Core.ManagementSettings
{
    public static class ApplicationSettings
    {
        public static string DefaultKey = "3a4f836a-7603-4009-b2b1-e7b88e94cd13";

        public static TimeSpan TransactionTimeout = new TimeSpan(0, 5, 0);
    }
}
