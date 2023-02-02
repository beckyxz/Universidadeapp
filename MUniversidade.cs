using System;
using System.Collections.Generic;
using System.Text;

namespace Universidade
{
    class MUniversidade
    {
        public int Id { get; set; }
        public string Universidade { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Universidade}";
        }
    }
}
