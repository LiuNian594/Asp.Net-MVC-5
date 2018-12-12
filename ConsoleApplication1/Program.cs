using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Commodity> CommodityList = new List<Commodity>();

            Commodity cd = new Commodity();
            cd.Name = "农夫山泉";
            cd.Price = 2;
            CommodityList.Add(cd);
            
            
            foreach (var item in CommodityList)
            {
                Console.WriteLine("Name:{0},Price:{1}", item.Name, item.Price);
            }
            Console.ReadKey();
        }
    }
}
