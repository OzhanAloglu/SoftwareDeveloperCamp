using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

class Program
{
    //SOLID
    //Open-Closed Principle------->>Yeni bir kod eklediğin zaman varolan kodu değiştirmeme.



    static void Main(string[] args)
    {
        ProductManager productManager=new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetByUnitPrice(10, 400))
        {
            Console.WriteLine(product.ProductName);

        }
    }
}