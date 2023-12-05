using MuseumTool.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class editorColleccions : Form
    {
        public editorColleccions()
        {
            InitializeComponent();
        }

        private void editorColleccions_Load(object sender, EventArgs e)
        {
            // Crear una lista para almacenar objetos Colleccions
            List<Colleccions> colleccioList;

            // Verificar si el archivo JSON ya existe
            if (File.Exists(Colleccions.colleccionsDir))
            {
                // Leer el contenido del archivo JSON existente
                string existingJson = File.ReadAllText(Colleccions.colleccionsDir);

                // Deserializar el JSON existente a la lista de Colleccions
                colleccioList = JsonConvert.DeserializeObject<List<Colleccions>>(existingJson);

                // Asigna las colecciones al ComboBox
                foreach (var collection in colleccioList)
                {
                    listBoxColleccions.Items.Add(collection.nombre);
                }
            }
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            string newColleccio = textBoxColleccio.Text;

            // Verify if the file already exists in listBoxMultimedia
            if (string.IsNullOrEmpty(newColleccio))
            {
                textBoxColleccio.Focus();
            }
            else if(!listBoxColleccions.Items.Contains(newColleccio))
            { 
                listBoxColleccions.Items.Add(newColleccio);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Elimina el ítem seleccionado en listBoxColleccions
            if (listBoxColleccions.SelectedItem != null)
            {
                listBoxColleccions.Items.Remove(listBoxColleccions.SelectedItem);
            }
        }

        private void buttonDesar_Click(object sender, EventArgs e)
        {
            // Crea una lista de objetos Colleccions a partir de los elementos de listBoxColleccions
            List<Colleccions> colleccioList = new List<Colleccions>();
            foreach (var item in listBoxColleccions.Items)
            {
                colleccioList.Add(new Colleccions { nombre = item.ToString() });
            }

            // Serializa la lista a formato JSON
            string json = JsonConvert.SerializeObject(colleccioList, Formatting.Indented);

            // Escribe el JSON al archivo
            File.WriteAllText(Colleccions.colleccionsDir, json);

            this.Close();
        }
    }
}