using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {




        //retrieve one product by id
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (product.ProductId == 1)
            {
                product.ProductName = "Napas";
                product.ProductDescription = "smachnyi dyzhe";
                product.CurrentPrice = 2500;
            }

            return product;
        }

        //retrieve list of all products in db
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        //save product (new or changes to existing)
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //insert new
                    }
                    else
                    {
                        //update existing
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
                
        }

    }
}
