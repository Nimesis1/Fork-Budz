using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Algemeen
    {
        string WelGekomenInGegooienMetVeelVermogenEenTweeDriePianoHihi;

        public string Welkom(string taal)
        {
            string resultaat="";
            switch (taal)
                {
                
                case "Nederlands": resultaat = "Welkom";
                    break;
                case "Frans": resultaat = "Bienvenue";
                    break;
                case "Engels": resultaat = "Walecum";
                    break;
                case "Duits": resultaat ="Gutten tag mit ein lach";
                    break;

                   
            }
            return resultaat;
        }
    }
}
