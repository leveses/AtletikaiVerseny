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
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }

        public Atleta(string n)
        {
            string[] sor = n.Split(';');
            sor[0] = Rajtszam;
            sor[1] = VezNev;
            sor[2] = KerNev;
            sor[3] = Egyesulet;
            
        }
    }
}
