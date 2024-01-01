using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTool
{
    internal class preguntasCarrier
    {
        public int ID { get; set; }
        public string pregunta { get; set; }
        public string respA { get; set; }
        public string respB { get; set; }
        public string respC { get; set; }
        public int respCorrecta { get; set; }
    }
}
