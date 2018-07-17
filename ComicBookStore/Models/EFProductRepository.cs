using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For Entity Framework.

namespace ComicBookStore.Models
{
    public class EFProductRepository : IProductRespository
    {
            private ApplicationDbContext context;

            public EFProductRepository(ApplicationDbContext ctx)
            {
                context = ctx;
            }

            public IQueryable<Product> Products => context.Products;

    }
}
