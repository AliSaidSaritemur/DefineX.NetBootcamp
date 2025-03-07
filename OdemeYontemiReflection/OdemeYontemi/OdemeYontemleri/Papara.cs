using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeYontemi.OdemeYontemleri
{
    internal class Papara : IOdemeYontemi
    {
        public string OdemeYap(double tutar)
        {
            return "Papara ile " + tutar + " TL ödeme yapıldı.";
        }
    }
}
