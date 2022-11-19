using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Constraints
{
    internal class Islem<T> where T : struct
    {
        //sadece struct tipinde herhangi birşey olabir
        public void IslemA(T t)
        {

        }
    }
}