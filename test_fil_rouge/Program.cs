using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_fil_rouge;
namespace test_fil_rouge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string texte = Console.ReadLine();
            fonction_mail test = new fonction_mail();
            test.verificationmail(texte);
            Console.ReadLine();
        }
    }
}
