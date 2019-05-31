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
            // 模擬使用 EF 的 async 方法取得資料
            return await Task.Run(() => "market");
        }
    }
}