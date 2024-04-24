using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Banque.Modele;

namespace Banque.DAL
{
    class ClientDao 
    {
      

        private  ConnexionSql maConnexionSql;


        private   MySqlCommand Ocom;


/*
        public  Client getClient(int unNumero)
        {

            try
            {
                Client cl = new Client(); ;

                

               maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from client where numero = " + unNumero);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int numero = (int)reader1.GetValue(0);
                    string nom = (string)reader1.GetValue(1);
                    string prenom = (string)reader1.GetValue(2);
                    string adresse = (string)reader1.GetValue(3);

                    cl = new Client(numero, nom, prenom, adresse);

                    
                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (cl);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
*/

        public void updateClient(Client c)
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


        public List<Client> getClients()
        {

            List<Client> lc = new List<Client>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from client");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Client c;

               


                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);

                    c = new Client(numero, nom, prenom, adresse);

                    lc.Add(c);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                
            }
           
               
            

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }
            
    return (lc);
        }

    }
}
