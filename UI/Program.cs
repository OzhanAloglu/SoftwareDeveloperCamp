﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

class Program
{
    //SOLID
    //Open-Closed Principle------->>Yeni bir kod eklediğin zaman varolan kodu değiştirmeme.



    static void Main(string[] args)
    {
        ProductTest();
        //IoC yapılacak şimdilik böyle.
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll())
        {

            Console.WriteLine(category.CategoryName);

        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        var result = productManager.GetProductDetails();

        if (result.Success==true)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName + "/" + product.UnitsInStock);
            }

        }
        else
        {
            Console.WriteLine(result.Message);
        }

        
    }
}