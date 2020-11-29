using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excurciseproject_Arv
{
    class Property
    {
        private string Address;
        private int Apartments;
        private double Pris;

        public Property(string iAddress, int iApartments, double iPris)
        {
            Address = iAddress;
            Apartments = iApartments;
            Pris = iPris;



        }
        public string GetAddress()
        {
            return Address;
        }
        public int GetApartments()
        {
            return Apartments;
        }
        public double GetPris()
        {
            return Pris;
        }
     

    }
}
