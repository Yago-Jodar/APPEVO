using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTool
{
    internal class InfoCarrierInicisAviacio : InfoCarrier
    {
        public string llocFabricacio { get; set; }
        public string procedencia { get; set; }
        public string fontEnergia { get; set; }
        public float longitud { get; set; }
        public float alcada { get; set; }
        public float envergadura { get; set; }
        public float pes { get; set; }
        public float pesMax { get; set; }
        public int cicle { get; set; }
        public float cilindrada { get; set; }
        public string potencia { get; set; }
        public float potenciaVal { get; set; }
        public string potenciaType { get; set; }
        public int velocitatMaxima { get; set; }
        public int velocitatcreuer { get; set; }
        public int capacitatDiposit { get; set; }
        public float autonomia { get; set; }
        public float autonomiaTemps { get; set; }
        public float quilometresFets { get; set; }
        public int sostreMax {  get; set; }
        public string formaIngres { get; set; }
        public string fontIngres { get; set; }
    }
}
