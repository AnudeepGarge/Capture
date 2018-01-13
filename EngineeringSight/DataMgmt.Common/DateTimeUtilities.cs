using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.Common
{
    public class DateTimeUtilities
    {
        public static long GetUtcTime()
        {
            return (long) DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}
