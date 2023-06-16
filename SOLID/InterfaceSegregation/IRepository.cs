namespace InterfaceSegregation
{
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);



    }

    public interface ISearchableByPrice<T>
    {
        IList<T> SearchEntitiesByPrice(decimal minPrice, decimal maxPrice);
    }

    //alternatifi:
    public interface IProductRepository : IRepository<Product>
    {
        public IList<Product> SearchEntitiesByPrice(decimal min, decimal max);
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    /*
     * Component tercihinize bağlı olarak; zorunlu olmadığınız fonksiyonu genel interface'i implemente eden başka bir interface'a aktarabilir veya tamamen başka bir interface inşa edebilirsiniz.
     * 
     * Aşağıda iki örnek de mevcut:
     */

    public class ProductRepository : IProductRepository // veya IRepository<Product>, ISearchableByPrice<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchEntitiesByPrice(decimal minPrice, decimal maxPrice)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }

    public class CustomerRepository : IRepository<Customer>
    {
        public void Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    public class Component
    {
        public IList<Product> SearchOnCache(IProductRepository repository)
        {
            return repository.SearchEntitiesByPrice(3, 10);
        }
    }

}
