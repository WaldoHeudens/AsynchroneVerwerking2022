using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Les_5_3
{

    public class TraagheidAsynchroon
    { 
        int Id { get; set; }
        int Tijd { get; set; }

        TextBox Tb { get; set; }

        public TraagheidAsynchroon(int id, int tijd, TextBox tb)
        {
            Id = id;
            Tijd = tijd;
            Tb = tb;
        }

        public async void Wacht()
        {
            await Task.Factory.StartNew(new Func<int>(BlijfEvenWachten));
            Tb.Text += "Klaar met " + (Id + 1) + " na " + Tijd + "ms \r\n";
        }

        public int BlijfEvenWachten()
        {
            System.Threading.Thread.Sleep(Tijd);
            return Tijd;
        }
    }
}
