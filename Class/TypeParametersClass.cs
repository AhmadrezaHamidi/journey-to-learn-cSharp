using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Pair<TFirst, TSecond, TThires>
    {
        public TFirst First { get; }
        public TSecond Second { get; }
        public TThires Thired { get; set; }

        public Pair(TFirst first, TSecond second) =>
            (First, Second) = (first, second);

        public Pair(TFirst first, TSecond second, TThires thired) : this(first, second) =>(Thired) = (thired);

    }



}
