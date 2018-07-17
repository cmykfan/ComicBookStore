    // This is a fake respository that I used for testing, can be replaced with real database later called IProductRepository.cs.
    //using System;
using System.Collections.Generic;
using System.Linq;
    //using System.Threading.Tasks;

namespace ComicBookStore.Models
{
    public class FakeProductRepository : IProductRespository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Mjolnir", Description = "Want to be Thor, God of Thunder? Well now you can! Warning: Not responsible for spontaineous Storms or accidentally turning you into your alter ego Dr. Blake.", Price = 22 },
            new Product { Name = "Infinity Gauntlet", Description = "Be the envy of every galaxy dictator. Note: Infinity Gems not included.", Price = 25 },
            new Product { Name = "Jack Kirby Cigar", Description = "What every tough guy comic book artist needs. Get yourself a genuine Jack Kirby stoogie and create some characters that will last!", Price = 3 }
        }.AsQueryable<Product>();
    }
}


