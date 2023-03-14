using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.DisplayProducts
{
    public class MaClass
    {
        static void Main(string[] args)
        {
            ProductsDat data = new ProductsDat();

            // Add Product
            ProductInfo p1 = new ProductInfo();
            Console.WriteLine("Enter Product no --- Product Name ----- Brand Name  ----- Enter Price");
            p1.ProductNo = Convert.ToInt32(Console.ReadLine());
            p1.ProductName = Console.ReadLine();           
            p1.BrandName = Console.ReadLine();           
            p1.ProductPrice = Convert.ToDouble(Console.ReadLine());
            data.AddProducts(p1);

            ProductInfo p3 = new ProductInfo();
            Console.WriteLine("Enter 2nd Product Details--------Product Name ----- Brand Name  ----- Enter Price");
            p3.ProductNo = Convert.ToInt32(Console.ReadLine());
            p3.ProductName = Console.ReadLine();
            p3.BrandName = Console.ReadLine();
            p3.ProductPrice = Convert.ToDouble(Console.ReadLine());
            data.AddProducts(p3);

            ProductInfo p4 = new ProductInfo();
            Console.WriteLine("Enter 3rd Product Details--------Product Name ----- Brand Name  ----- Enter Price");
            p4.ProductNo = Convert.ToInt32(Console.ReadLine());
            p4.ProductName = Console.ReadLine();
            p4.BrandName = Console.ReadLine();
            p4.ProductPrice = Convert.ToDouble(Console.ReadLine());
            data.AddProducts(p4);

            ProductInfo p5 = new ProductInfo();
            Console.WriteLine("Enter 4th Product Details--------Product Name ----- Brand Name  ----- Enter Price");
            p5.ProductNo = Convert.ToInt32(Console.ReadLine());
            p5.ProductName = Console.ReadLine();
            p5.BrandName = Console.ReadLine();
            p5.ProductPrice = Convert.ToDouble(Console.ReadLine());
            data.AddProducts(p5);


            List<ProductInfo> List1= data.ListProduct();
            foreach (ProductInfo item in List1)
            {
                Console.WriteLine($" {item.ProductNo}   {item.ProductName} {item.BrandName}  {item.ProductPrice}");
            }

           
           
            // Update Products
            ProductInfo p2 = new ProductInfo();
            Console.WriteLine("Enter-- Product No to Update-----> Product Name ----- Brand Name ------ Product Price");
            p2.ProductNo = Convert.ToInt32(Console.ReadLine());
            p2.ProductName = Console.ReadLine();
            p2.BrandName = Console.ReadLine();        
            p2.ProductPrice = Convert.ToDouble(Console.ReadLine());
            data.UpdateProduct(p2);
            List1 = data.ListProduct();
            foreach (ProductInfo item in List1)
            {
                Console.WriteLine($"{item.ProductNo}  {item.ProductName} {item.BrandName}   {item.ProductPrice}");
            }

            // Delete Product
            Console.WriteLine("Enter Product No to remove");
            int no = Convert.ToInt32(Console.ReadLine());
            data.DeleteProduct(no);
            List1 = data.ListProduct();
            foreach (ProductInfo item in List1)
            {
                Console.WriteLine($"{item.ProductNo}  {item.BrandName} {item.ProductName}   {item.ProductPrice}");
            }

            // Price in Between
            Console.WriteLine("Product Price in Between 1000 t0 2000");
           List<ProductInfo> List3= data.CheckPrice();
            foreach (ProductInfo item in List3)
            {
                Console.WriteLine($"{item.ProductNo}  {item.BrandName} {item.ProductName}   {item.ProductPrice}");
            }

        }
        

    }
}
