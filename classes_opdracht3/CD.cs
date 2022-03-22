using System;
using System.Collections.Generic;
using System.Text;

namespace classes_opdracht3
{
    class CD
    {
        private string strTitel;
        private string strUitgever;

        public string STRTITEL
        {
            get { return strTitel; }
            set { strTitel = value; }
        }
        public string STRUITGEVER
        {
            get { return strUitgever; }
            set { strUitgever = value; }
        }

        public CD(string Titel, string Uitgever)
        {
            strTitel = Titel;
            strUitgever = Uitgever;
        }
        public string getData()
        {
            return "Titel: " + this.strTitel + "            Uitgever: " + this.strUitgever;
        } 
    }
}
