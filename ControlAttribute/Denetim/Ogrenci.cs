using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Denetim
{
    public class Ogrenci: IKontrolEdilebilir
    {
        [ZorunluAlan]
        public string Adi;
        [ZorunluAlan]
        public string Soyadi;
        [ZorunluAlan]
        public string Bolum;

        public bool KontrolEt()
        {
          Type type = this.GetType();

            foreach (var property in type.GetFields())
            {
                var attributes = property.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (attributes.Length > 0)
                {
                    if (property.GetValue(this) == null|| String.IsNullOrEmpty((string)property.GetValue(this)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}