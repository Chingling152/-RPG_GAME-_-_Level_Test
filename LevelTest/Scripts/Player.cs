using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest.Scripts
{
    public class Player
    {
        public float hp , stamina ,pesomax;
        public int forca , destreza , resistencia , vigor , magia;
        public int slotsmagia;

        public float danofisico, danofogo , danoraio , danoveneno , danomagico; // DANO
        public float defesafisica, defesafogo, defesaraio, defesaveneno, defesamagica;//DEFESA

        public int nivel;
        public int xp;

        public int xpcap;

        public int XpCap {
            get {
                while (xp > xpcap) {
                    xp-=xpcap;
                    nivel++;
                    xpcap += (int)Math.Floor(xpcap * 0.10f);
                }              
                return xpcap;
           }
        }

        //influencia da skill
        public void Influencias() { // 1 = influencia
            hp = (200 * 1) * (vigor * 0.25f);       
            stamina = (50 * 1)*(vigor * 0.10f);                                
            pesomax = (12 * 1) * (resistencia * 0.10f);
            slotsmagia = (int)Math.Floor((float)magia * 0.10f);

            danofisico = 
                (1 * (forca * destreza - (magia * 0.025f)) * 0.05f) >= 0.0f? 
                (1 * (forca * destreza - (magia * 0.025f)) * 0.05f) : 0.0f;
            danofogo = 0;
            danoraio = 0;
            danoveneno = 0;
            danomagico = 0;

            defesafisica = 
                (1 * (resistencia * vigor *0.05f) - (magia * 0.05f)) >= 0.0f ?
                (1 * (resistencia * vigor * 0.05f) - (magia * 0.05f)) : 0.0f;
            defesaraio = (1 * (resistencia * magia) * 0.025f);
            defesafogo = (1 * (resistencia * vigor) * 0.025f);
            defesaveneno = (1 * (vigor * vigor) * 0.0125f);
            defesamagica = 
                (1 * (magia * magia * 0.0125f) - ((vigor + resistencia) * 0.025f)) >= 0.0f?
                (1 * (magia * magia * 0.0125f) - ((vigor + resistencia) * 0.025f)) : 0.0f;
        }

        public Player(){
            nivel = 5;
            forca = 1;
            destreza = 1;
            resistencia = 1;
            vigor = 1;
            magia = 1;
            xp = 0;
            xpcap = 100 * nivel;
            Influencias();
        }
        
    }
}
