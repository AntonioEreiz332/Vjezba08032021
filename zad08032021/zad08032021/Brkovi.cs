using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad08032021
{
    class Brkovi
    {
        string ime, prezime,spol, dodatak;
        int god;

        public void setIme(string ime) {
            this.ime = ime;

        }
        public string getIme()
        {
            return this.ime;
        }
        //prezime
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        //god
        public void setGod(int god)
        {
            this.god = god;
        }
        public int getGod() {
            return this.god;
        }
        //spol
        public void setSpol(string spol){
            this.spol = spol;        
        }
        public string getSpol()
        {
            return this.spol;
        }
        //dodatak
        public void setDodatak(string dodatak)
        {
            this.dodatak = dodatak;
        }
        public string getDodatak()
        {
            return this.dodatak;
        }

        public Brkovi(string ime,string prezime,int god,string spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.god = god;
            this.spol = spol;
        }
        public string Ispis()
        {
            string ispis = ime + "\t" + prezime + "\t"
                + Convert.ToString(god) + "\t"
                + spol + "\t"+ dodatak + "\r\n";
            return ispis;
        }





    }
}
