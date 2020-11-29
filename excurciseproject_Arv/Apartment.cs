using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excurciseproject_Arv
{
    class Apartment : Property
    {
        private int Room;
       

        private double KvadratMeter;


        

        public Apartment(int iRoom, double iKvadratMeter, string iAddress, int iApartments,double iPris):base(iAddress, iApartments, iPris)
        {
            Room = iRoom;
            KvadratMeter = iKvadratMeter;
        }
        public int GetRoom()
        {
            return Room;
        }
        public double GetKvadratMeter()
        {
            return KvadratMeter;
        }
      
    }
}
