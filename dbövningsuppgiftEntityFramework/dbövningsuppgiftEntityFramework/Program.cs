using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbövningsuppgiftEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var cmd = new NORTHWNDEntities())
            {
                var cat = (from c in cmd.Categories
                           where c.CategoryName == "Beverages"
                           select c).First();

                foreach(var pr in cat.Products)
                {
                    Console.WriteLine(pr.ProductName+" "+ pr.UnitPrice);
                }
                foreach (var p in cat.Products)
                {
                    p.UnitPrice *= 1.05M;
                }
                Console.WriteLine(" ");
                
                cmd.SaveChanges();
                foreach (var upd in cat.Products)
                {
                    Console.WriteLine(upd.ProductName+" "+upd.UnitPrice);
                }
                Console.ReadLine();
            }
            
        }
    }
}
