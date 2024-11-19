using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Storage
    {
        public Seats seats;

        public Storage(Seats getSeat)
        {
            seats = getSeat;
        }

        public void deploy()
        {
            seats.start();
        }
    }
}
