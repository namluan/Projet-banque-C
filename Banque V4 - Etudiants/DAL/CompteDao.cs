using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Banque.Modele;

namespace Banque.DAL
{
    class CompteDao 
    {

       

       

        private  ConnexionSql maConnexionSql;


        private  MySqlCommand Ocom;

        private ClientDao cld;




        public  List<Compte> getComptes(Client cl)
        {

            List<Compte> lc = new List<Compte>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();



                Ocom = maConnexionSql.reqExec("Select c.numCompte,c.solde,ccour.decouvert,c.numclient from compte c, comptecourant ccour where c.numcompte = ccour.numcompte and c.numClient = " + cl.Num);

                MySqlDataReader reader = Ocom.ExecuteReader();

        

                while (reader.Read())
                {

                    int numCompte = (int)reader.GetValue(0);
                    int solde = (int)reader.GetValue(1);
                    int decouvert = (int)reader.GetValue(2);
                    int numClient = (int)reader.GetValue(3);


                    Compte c = new CompteCourant(numCompte, cl);
                    c.crediter(solde);
                    ((CompteCourant)c).Decouv = decouvert; 

                    lc.Add(c);


                }

                reader.Close();

            

                Ocom = maConnexionSql.reqExec("Select c.numCompte,ce.tauxinteret,c.solde from compte c, compteepargne ce where c.numcompte=ce.numcompte and c.numClient = " + cl.Num);

                reader = Ocom.ExecuteReader();




                while (reader.Read())
                {

                    int numCompte = (int)reader.GetValue(0);
                    double taux = (double)reader.GetValue(1);
                    int solde = (int)reader.GetValue(2);



                    Compte c = new CompteEpargne(numCompte, cl, taux);
                    c.crediter(solde);
                    


                    lc.Add(c);

                  

                }

                reader.Close();

            }


            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

            return (lc);

        }


        

        public void updateSolde(Compte c)
        {

            try
            {

                // à compléter



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }



        public void updateDecouvert(CompteCourant c)
        {

            try
            {




               // à compléter



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


    }
}
