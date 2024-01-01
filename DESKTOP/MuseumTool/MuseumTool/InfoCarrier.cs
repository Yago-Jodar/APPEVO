using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumTool
{
    public class InfoCarrier
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new museumToolGeneral());
        }

        public int numInventari { get; set; }
        public string collceccio { get; set; }
        public string name { get; set; }
        public int any { get; set; }
        public JArray multimedia { get; set; }
        public string descripcio { get; set; }
    }
}
