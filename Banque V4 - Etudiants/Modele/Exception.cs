using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banque.Modele
{
    [Serializable]
    internal class DebitException : Exception
    {
        public DebitException()
        {
        }

        public DebitException(string message) : base(message)
        {


        }
    } 

    [Serializable]
    internal class DecouvertException : Exception
    {
        public DecouvertException()
        {
        }

        public DecouvertException(string message) : base(message)
        {


        }


    }
}
