using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace windows_pet
{
    class events
    {
        Random rnd = new Random();
        public int ran = 1;
        public int distancia = 0;
        bool mov = false;

        public int MovController(int x, int y)
        {
            int active = 0;
            if(mov == true)
            {
                if ( x == 650 && ran == 2 && distancia > 1)
                {
                    active = 5;
                    distancia -= 1;
                }
                else if (x <= 15 && ran == 1 && distancia > 1)
                {
                    active = 5;
                    distancia -= 1;
                }
                else if (distancia > 1)
                {
                    active = ran;
                    distancia -= 1;
                }
                else if (y != 385)
                {
                    active = 6;
                    distancia = 0;
                }
                else { mov = false; active = 0; }
            }

            return active;
        }

        public void DistController(int dist)
        {
            if (mov == false && distancia <= 1)
            {
                ran = rnd.Next(0, 4);//selector de accion
                mov = true;
                if(ran == 3) distancia = rnd.Next(0, 2000);
                else distancia = rnd.Next(0, dist);
            }
        }
    }
}
