using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO ;
using System.Runtime.Serialization.Formatters.Binary ;
using Banque.Controleur;
using Banque.Modele;

namespace Banque
{

    [Serializable]
    public partial class Gestion : Form
    {

        Mgr monManager;

          public   List<Compte> lstcpt = new List<Compte>();

       
        private List<Client> lstclt = new List<Client>();

        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void crediterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lab.Visible = true;
            lab.Text = "Montant à créditer";

            bouton.Visible = true;
            bouton.Text = "Valider le crédit";
            

            tb.Visible = true;




        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lstclt = monManager.chargementClBD();

        

            if (lstclt.Count != 0) { rafraichirListBox(0); }



        }

       

        private void debiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab.Visible = true;
            lab.Text = "Montant à débiter";

            bouton.Visible = true;
            bouton.Text = "Valider le débit";
            

            tb.Visible = true;
        }

        private void bouton_Click(object sender, EventArgs e)
        {

            try
            {
                int j;

                j = lBox1.SelectedIndex;
                if (j != -1)
                {

                    Compte c = lstcpt[j];


                    int i;

                    i = lBox.SelectedIndex;


                    Client cl = lstclt[i];

                    if (bouton.Text == "Valider le crédit")
                    {

                        c.crediter(Convert.ToDouble(tb.Text));

                        monManager.updateSolde(c);

                    }


         

                    if (bouton.Text == "Valider le débit")
                    {
                        c.debiter(Convert.ToDouble(tb.Text));

                         monManager.updateSolde(c); 

                        tb.Clear();
                    }



                    if (bouton.Text == "Valider le découvert")
                    {


                        if (c.GetType().Name == "CompteCourant")

                        {
                            ((CompteCourant)c).setDecouv(Convert.ToDouble(tb.Text));
                            monManager.updateDecouvert((CompteCourant)c);

                        }


                    }

                    lstcpt = monManager.chargementCBD(cl);



                    int index = lBox1.SelectedIndex;

                    rafraichirListBox1(index);

                }


            }

            catch (DebitException Ex)
            {
                MessageBox.Show("" + Ex.Message);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("" + Ex.Message);

            }


        }

        private void découvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab.Visible = true;
            lab.Text = "Montant du nouveau découvert";

            bouton.Visible = true;
            bouton.Text = "Valider le découvert";


            tb.Visible = true;

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            
            int i ;

            i = lBox.SelectedIndex ;

            Client cl = (Client)lBox.SelectedItem;


      FormClient fc = new FormClient(cl);

            
            fc.ShowDialog();

            monManager.updateClient(cl);

            lstclt = monManager.chargementClBD();

         

            rafraichirListBox(i);


        }

        private void rafraichirListBox(int index)
        {

           lBox.DataSource = null;
           lBox.DataSource = lstclt;
        
           lBox.SetSelected(index, true);

        }

        private void rafraichirListBox1(int index)
        {

            lBox1.DataSource = null;
            // lBox.DataSource = lstcpt.Values.ToList();
            lBox1.DataSource = lstcpt;
            lBox1.DisplayMember = "Description";
            lBox1.SetSelected(index, true);

            

        }

        private void rafraichirListBox1_Comptes_Vides()
        {

            lBox1.DataSource = null;
            lBox1.DisplayMember = "Description";
           



        }




        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = lBox.SelectedIndex;

           

            if (i!= -1) {
                    Client cl = lstclt[i];

                lstcpt = monManager.chargementCBD(cl);



                  if (lstcpt.Count != 0) { rafraichirListBox1(0); }

                  else { rafraichirListBox1_Comptes_Vides(); }

             

            }

            



        }
    }
}
