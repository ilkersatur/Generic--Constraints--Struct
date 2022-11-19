using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints_Devam
{
    internal class Personel
    {
    }
    internal class Musteri
    {
        public Musteri(string ad)
        {

        }
    }
    internal class Kitap
    {
    }
    public class Yonetici<T> where T : /*new(), en sonda olmak zorunda*/class, new()
    {

    }
}
