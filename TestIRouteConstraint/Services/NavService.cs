using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TestIRouteConstraint.Services
{
    public class NavService
    {
        public async Task<string> GetNav()
        {
            return await Task.Run(() => "market");
        }
    }
}