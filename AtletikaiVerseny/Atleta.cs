using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }

        public Atleta(string n)
        {
            string[] sor = n.Split(';');
            Rajtszam = sor[0];
            Nev = sor[1];
            Egyesulet = sor[2];
            Ugras = int.Parse(sor[3]);
            
        }
        

        
    }
}
