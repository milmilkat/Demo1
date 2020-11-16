using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Logic
    {
        int Bullet;

        public int LoadGun()
        {
            Bullet = 0;
            return Bullet;
        }

        public int SpinGun()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
            return Bullet;
        }

    }
}
