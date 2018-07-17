using System.Linq;

//This is the file I am going to link up with my SQL database so that the data can be persistent and I will stop using FakeProductRepository.cs.

namespace ComicBookStore.Models
{
    public interface IProductRespository
    {
        IQueryable<Product> Products { get; }
    }
}
