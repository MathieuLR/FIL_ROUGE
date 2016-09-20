using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL_fil_rouge
{
   public class fonction_mail
    {
        /// <summary>
        /// Fonction de vérification d'adresse mail
        /// </summary>
        /// <param name="email">parametre email nécéssite une chaine de caractere type adresse mail</param>
        /// <returns></returns>
        public string verificationmail(string email)
        {

            Regex regex = new Regex(@"^([\w\d\-\.]+)@{1}(([\w\d\-]{1,67})|([\w\d\-]+\.[\w\d\-]{1,67}))\.(([a-zA-Z\d]{2,4})(\.[a-zA-Z\d]{2})?)$");
            Match match = regex.Match(email);
            if (match.Success)
                Console.WriteLine("");
            else
                Console.WriteLine(email + " est incorrect");

            return email;
        }
    }
}
