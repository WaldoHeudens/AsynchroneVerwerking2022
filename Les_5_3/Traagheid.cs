using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_5_3
{
    internal class Traagheid
    {
        int Id { get; set; }
        int Tijd { get; set; }

        public Traagheid (int id, int tijd)
        {
            Id = id;
            Tijd = tijd;
        }

        public string Wacht()
        {
            BlijfEvenWachten();
            return ("Klaar met " + (Id+1) + " na " + Tijd + "ms \r\n");
        }

        public void BlijfEvenWachten()
        {
            System.Threading.Thread.Sleep(Tijd);
        }
    }
}
