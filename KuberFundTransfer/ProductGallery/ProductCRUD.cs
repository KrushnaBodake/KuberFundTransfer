using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.ProductGallery
{
    public class ProductCRUD
    {
        private List<Products> Productlist = new List<Products>();

        public ProductCRUD()
        {
            Productlist = new List<Products>();
        }
        public void AddProducts(Products prod)
        {
            Productlist.Add(prod);
        }

       
        public void UpdateProduct( Products prod)        
        {
            foreach (Products item in Productlist)
            {
                if(item.ProductNo==prod.ProductNo)
                {
                    item.ProductDetails = prod.ProductDetails;
                    item.Price = prod.Price;
                    break;
                }
            }
        }

        public List<Products> ListProduct()
        {
            return Productlist;
        }

    }
}



