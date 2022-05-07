using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWPFkfcICE
{
    class ProductData
    {
        public ProductData(String[] ProductName, int[] ProductPrice, int Total, String Cart)
        {
         
        }

        public static List<Products> Products = new List<Products>();


        
    }

    public class Products
    {
        public String[] ProductName= {"Streetwise 1", "Streetwise 2", "Streetwise 3" , "Streetwise 4" };
        public int[] ProductPrice= {20,40,60,80};
        public static int Total = 0; //Final Cart balance
        public String Cart = "";

        public void Streetwise1()
        {
            Total += ProductPrice[0];
            Cart += ProductName[0] + "\n";
        }
        public void Streetwise2()
        {
            Total += ProductPrice[1];
            Cart +=  ProductName[1] + "\n";
        }
        public void Streetwise3()
        {
            Total += ProductPrice[2];
            Cart += ProductName[2] + "\n";
        }
        public void Streetwise4()
        {
            Total += ProductPrice[3];
            Cart += ProductName[3] + "\n";
        }

        public int CartTotal()
        {
            return Total;
        }
        public String CartItems() //returns the items in the cart
        {
            return "You have ordered: \n" + Cart;
        }

    }
   


}
