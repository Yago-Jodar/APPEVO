using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTool
{
    internal class InfoCarrierMotocicletesCatalanes : InfoCarrier
    {
        public string llocFabricacio { get; set; }
        public int cicle { get; set; }
        public float cilindrada { get; set; }
        public string potencia { get; set; }
        public float potenciaVal { get; set; }
        public string potenciaType { get; set; }
        public int velocitatMaxima { get; set; }
        public int capacitatDiposit { get; set; }
        public float autonomia { get; set; }
        public float quilometresFets { get; set; }
        public string formaIngres { get; set; }
        public string fontIngres { get; set; }
    }
}
