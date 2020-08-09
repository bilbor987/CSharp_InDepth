using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_InDepth
{
    public class MainClass
    {
        static void Main(string[] args)
        {

        }

        static List<string> GenerateNamesGeneric()
        {
            List<string> names = new List<string>();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static ArrayList GenerateNames()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }
        static void PrintNames(ArrayList names)
        {
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
