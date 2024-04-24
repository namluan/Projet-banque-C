using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
  
    
    /// <summary>
    /// Classe Abstraite qui représente les comptes de la banque
    /// </summary>
    
    
    public abstract class Compte
    {
        protected int num;
        protected Client proprio;
        public double solde = 0;


        public int Num { get => num; }


        /// <summary>
        /// Constructeur de compte
        /// </summary>
        /// <param name="n">numéro du compte</param>
        /// <param name="c">Client propriétaire du compte</param>

        public Compte(int n, Client c)
        {
            this.num = n;
            this.solde = 0;
            this.proprio = c;
            // this.proprio.ajouterCompte(this);
        }


        /// <summary>
        /// 
        /// </summary>
        public virtual string Description
        {
            get => "Compte n° " + num + " " + " Client :  " + proprio + " " + " solde : " + solde + " €";
        }

        public Client Propriétaire
        {
            get { return proprio; }
        }

        public double Solde { get => solde; }

        public void crediter(double mont)
        {
            solde = solde + mont;
        }

        public abstract void debiter(double mont);

    }
}
