using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace DAL_fil_rouge
{
    public class verif_mail
    {
       
       public bool verifmail(TextBox verification_adresse_mail)
        {
            Regex myRegex = new Regex(@"^(.+)@(.+)\.(.+)$");
            Match test = myRegex.Match(verification_adresse_mail.Text);
            if (test.Success)
            {
                Regex mypremierregex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_\-\.]{1,50}$");
                Match test1 = mypremierregex.Match(test.Groups[1].Value);
                if (test1.Success)
                {
                    Regex mydeuxiemeregex = new Regex(@"^[a-zA-Z][a-zA-Z0-9_\-\.]{1,50}$");
                    Match test2 = mydeuxiemeregex.Match(test.Groups[2].Value);
                    if (test2.Success)
                    {
                        Regex mytroisiemeregex = new Regex(@"^[a-z]{2,50}$");
                        Match test3 = mytroisiemeregex.Match(test.Groups[3].Value);
                        if (test3.Success)
                        {
                            return true;
                        }

                        else
                        {
                            MessageBox.Show("Erreur sur cette partie de l'adresse mail : . " + test.Groups[3].ToString());
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erreur sur cette partie de l'adresse mail :  @ " + test.Groups[2].ToString());
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur sur cette partie de l'adresse mail :  " + test.Groups[1].ToString());
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Adresse mail invalide , veuillez saisir une adresse type michel@gmail.com");
                return false;

            }
        }
    }
}
