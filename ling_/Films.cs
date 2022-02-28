using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ling_
{
    class Films
    {
        public string Name { get; set; }   /*получается использовать только когда публичные*/
        public int Box_office { get; set; }
        public string Horror_movie {get;set;}

        public Films(string a,int b,string c)
        {
            this.Name = a;
            this.Box_office = b;
            this.Horror_movie = c;
        }
        public virtual string ToString()
        {
            return $"{Name},{Box_office},{Horror_movie}";
        }
    }
}
