using Domain.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p = new Produit()
            {


            };
            ServiceProduit sp = new ServiceProduit();
            // sp.AddProduct(p);
            //sp.Commit();
            sp.Add(p);
            sp.Commit();
            Console.WriteLine("base crée");
            Console.ReadKey();
        }
    }
}
