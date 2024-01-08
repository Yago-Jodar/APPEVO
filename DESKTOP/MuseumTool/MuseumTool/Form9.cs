using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class gestorPreguntes : Form
    {
        public Boolean initializationMode { get; set; }
        public int numInventariSel { get; set; }

        public gestorPreguntes()
        {
            InitializeComponent();
        }

        private void buttonDesar_Click(object sender, EventArgs e)
        {
            // Ruta del archivo JSON
            string jsonFilePathCat = @"..\..\JSON\preguntes\preguntesCat.json";
            string jsonFilePathEsp = @"..\..\JSON\preguntes\preguntesEsp.json";
            string jsonFilePathEng = @"..\..\JSON\preguntes\preguntesEng.json";

            // Crear una lista para almacenar objetos InfoCarrierTransportPersonesMercaderies
            List<PreguntasCarrierCat> preguntaCat;
            List<PreguntasCarrierEsp> preguntaEsp;
            List<PreguntasCarrierEng> preguntaEng;

            // Verificar si el archivo JSON ya existe
            if (!File.Exists(jsonFilePathCat) && !File.Exists(jsonFilePathEsp) && !File.Exists(jsonFilePathEng))
            {
                // Si el archivo no existe, crear una nueva lista
                preguntaCat = new List<PreguntasCarrierCat>();
                preguntaEsp = new List<PreguntasCarrierEsp>();
                preguntaEng = new List<PreguntasCarrierEng>();
            }

            // Leer el contenido del archivo JSON existente
            JArray existingJsonCat = JArray.Parse(File.ReadAllText(jsonFilePathCat));
            JArray existingJsonEsp = JArray.Parse(File.ReadAllText(jsonFilePathEsp));
            JArray existingJsonEng = JArray.Parse(File.ReadAllText(jsonFilePathEng));

            // Deserializar el JSON existente a la lista de InfoCarrierTransportPersonesMercaderies
            preguntaCat = existingJsonCat.ToObject<List<PreguntasCarrierCat>>();
            preguntaEsp = existingJsonEsp.ToObject<List<PreguntasCarrierEsp>>();
            preguntaEng = existingJsonEng.ToObject<List<PreguntasCarrierEng>>();

            PreguntasCarrierCat guardarPreguntaCat = new PreguntasCarrierCat
            {
                preguntaCat = textBoxPreguntaEng.Text,
                respACat = textBoxRespostaAEng.Text,
                respBCat = textBoxRespostaBEng.Text,
                respCCat = textBoxRespostaCEng.Text,
                respCorrecta = respCorrecta(radioButtonA, radioButtonB, radioButtonC)
            };
            PreguntasCarrierEsp guardarPreguntaEsp = new PreguntasCarrierEsp
            {
                preguntaEsp = textBoxPreguntaEsp.Text,
                respAEsp = textBoxRespostaAEsp.Text,
                respBEsp = textBoxRespostaBEsp.Text,
                respCEsp = textBoxRespostaCEsp.Text,
                respCorrecta = respCorrecta(radioButtonA, radioButtonB, radioButtonC)
            }; 
            PreguntasCarrierEng guardarPreguntaEng = new PreguntasCarrierEng
            {
                preguntaEng = textBoxPreguntaEng.Text,
                respAEng = textBoxRespostaAEng.Text,
                respBEng = textBoxRespostaBEng.Text,
                respCEng = textBoxRespostaCEng.Text,
                respCorrecta = respCorrecta(radioButtonA, radioButtonB, radioButtonC)
            };

            preguntaCat.Add(guardarPreguntaCat);
            preguntaEsp.Add(guardarPreguntaEsp);
            preguntaEng.Add(guardarPreguntaEng);
        }

        private int respCorrecta(RadioButton radioButtonA, RadioButton radioButtonB, RadioButton radioButtonC)
        {
            int result;

            if (radioButtonA.Checked == true)
            {
                result = 0;
            }
            else if (radioButtonB.Checked == true)
            {
                result = 1;
            }
            else
            {
                result = 2;
            }

            return result;
        }
    }
}
