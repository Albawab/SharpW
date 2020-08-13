using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_GetStart.Data
{
    public class Seconds
    {

        public static Task<int> GetSec()
        {
            return Task.FromResult(DateTime.Now.Second);
        }
    }
}
