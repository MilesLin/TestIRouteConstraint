using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TestIRouteConstraint.Models;

namespace TestIRouteConstraint.Services
{
    public class NavService
    {
        public async Task<string> GetNav()
        {
            using (ProductContext db = new ProductContext())
            {
                var product = db.Product.AsQueryable();
                product = product.Where(x => 1 == 1);

                var result = await product.ToListAsync().ConfigureAwait(false);

                return result.Select(x => x.Name).FirstOrDefault();
            }
        }

        public async Task<string> TestChild()
        {
            using (ProductContext db = new ProductContext())
            {
                var product = db.Product.AsQueryable();
                product = product.Where(x => 1 == 1);

                var result = await product.ToListAsync();

                return result.Select(x => x.Name).FirstOrDefault();
            }
        }
    }
}