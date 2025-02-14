﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MuseumTool.JSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

    
namespace MuseumTool
{
    public partial class transportPersonesMercaderies : Form
    {
        public Boolean initializationMode { get; set; }
        public int numInventariSel { get; set; }

        public transportPersonesMercaderies()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Crear una lista para almacenar objetos InfoCarrierTransportPersonesMercaderies
            List<Colleccions> colleccioList;

            // Verificar si el archivo JSON ya existe
            if (File.Exists(Colleccions.colleccionsDir))
            {
                // Leer el contenido del archivo JSON existente
                string jsonColleccionsExists = File.ReadAllText(Colleccions.colleccionsDir);

                // Deserializar el JSON existente a la lista de InfoCarrierTransportPersonesMercaderies
                colleccioList = JsonConvert.DeserializeObject<List<Colleccions>>(jsonColleccionsExists);

                // Asigna las colecciones al ComboBox
                foreach (var collection in colleccioList)
                {
                    comboBoxColleccio.Items.Add(collection.nombre);
                }
            }

            if (initializationMode && numInventariSel != 0)
            {
                // Cargar el JSON
                string existingJson = File.ReadAllText(@"..\..\JSON\transportPersonesMercaderies.json");

                // Deserializar a un array de objetos JSON
                JArray jsonArray = JArray.Parse(existingJson);

                // Buscar el objeto correspondiente al número de inventario seleccionado
                JObject selectedObject = jsonArray.FirstOrDefault(obj => (int)obj["numInventari"] == numInventariSel) as JObject;

                if (selectedObject != null)
                {
                    // Rellenar los campos con los datos del objeto encontrado
                    textBoxNumInventari.Text = (string)selectedObject["numInventari"];
                    comboBoxColleccio.SelectedItem = (string)selectedObject["collceccio"];
                    textBoxNom.Text = (string)selectedObject["name"];
                    textBoxAny.Text = (string)selectedObject["any"];
                    textBoxLlocFabricacio.Text = (string)selectedObject["llocFabricacio"];
                    textBoxProcedencia.Text = (string)selectedObject["procedencia"];
                    textBoxFontEnergia.Text = (string)selectedObject["fontEnergia"];
                    textBoxCicle.Text = (string)selectedObject["cicle"];
                    textBoxCilindrada.Text = (string)selectedObject["cilindrada"];
                    textBoxPotencia.Text = (string)selectedObject["potenciaVal"];
                    comboBoxPotencia.SelectedItem = (string)selectedObject["potenciaType"];
                    textBoxVelMax.Text = (string)selectedObject["velocitatMaxima"];
                    textBoxCapacitatDiposit.Text = (string)selectedObject["capacitatDiposit"];
                    textBoxAutonomia.Text = (string)selectedObject["autonomia"];
                    textBoxFontIngres.Text = (string)selectedObject["fontIngres"];
                    comboBoxFormaIngres.SelectedItem = (string)selectedObject["formaIngres"];
                    textBoxFontIngres.Text = (string)selectedObject["fontIngres"];
                    foreach (string path in selectedObject["multimedia"])
                    {
                        listBoxMultimedia.Items.Add(path);
                    }
                    textBoxDescripcio.Text = (string)selectedObject["descripcio"];
                }
                else
                {
                    MessageBox.Show("Objeto no encontrado para el número de inventario seleccionado.");
                }
            }

        }


        private void afegir_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Imatges amb format (*.jpg, *.jpeg, *.png, *.tiff)|*.jpg;*.jpeg;*.png;*.tiff";
            file.Multiselect = true;

            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string filePath in file.FileNames)
                {
                    string filename = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(@"..\..\multimedia", filename);

                        //Handle already existent file error
                        try
                        {
                            File.Copy(filePath, destinationPath);
                        }
                        catch
                        {
                            MessageBox.Show($"L'imatge ja existeix: {filename}", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    // Verify if the file already exists in listBoxMultimedia
                    if (!listBoxMultimedia.Items.Contains(destinationPath))
                    {
                        listBoxMultimedia.Items.Add(destinationPath);
                    }
                }
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            // Create a copy of the selected items to avoid modifying the collection during iteration
            List<string> selectedItems = new List<string>();
            foreach (var selectedItem in listBoxMultimedia.SelectedItems)
            {
                selectedItems.Add(selectedItem.ToString());
            }

            // Remove the selected items from the listBoxMultimedia
            foreach (var selectedItem in selectedItems)
            {
                listBoxMultimedia.Items.Remove(selectedItem);

                // Eliminar el archivo correspondiente
                File.Delete(selectedItem);
            }
        }

        private void desar_Click(object sender, EventArgs e)
        {
            // Ruta del archivo JSON
            string jsonFilePath = @"..\..\JSON\transportPersonesMercaderies.json";

            // Crear una lista para almacenar objetos InfoCarrierTransportPersonesMercaderies
            List<InfoCarrierTransportPersonesMercaderies> infoList;

            // Verificar si el archivo JSON ya existe
            if (File.Exists(jsonFilePath))
            {
                // Leer el contenido del archivo JSON existente
                JArray existingJson = JArray.Parse(File.ReadAllText(jsonFilePath));

                // Deserializar el JSON existente a la lista de InfoCarrierTransportPersonesMercaderies
                infoList = existingJson.ToObject<List<InfoCarrierTransportPersonesMercaderies>>();
            }
            else
            {
                // Si el archivo no existe, crear una nueva lista
                infoList = new List<InfoCarrierTransportPersonesMercaderies>();
            }


            // Crear una instancia de InfoCarrier y poblar sus propiedades
            InfoCarrierTransportPersonesMercaderies info = new InfoCarrierTransportPersonesMercaderies
            {
                collceccio = comboBoxColleccio.SelectedItem?.ToString() ?? "", // Handle null for ComboBox
                name = textBoxNom.Text,
                any = ParseInt(textBoxAny.Text),
                llocFabricacio = textBoxLlocFabricacio.Text,
                procedencia = textBoxProcedencia.Text,
                fontEnergia = textBoxFontEnergia.Text,
                cicle = ParseInt(textBoxCicle.Text),
                cilindrada = ParseInt(textBoxCilindrada.Text),
                potencia = TipoPotencia(textBoxPotencia.Text, comboBoxPotencia.SelectedItem?.ToString() ?? ""),
                potenciaVal = ParseFloat(textBoxPotencia.Text),
                potenciaType = comboBoxPotencia.SelectedItem?.ToString() ?? "",
                velocitatMaxima = ParseInt(textBoxVelMax.Text),
                autonomia = ParseFloat(textBoxAutonomia.Text),
                capacitatDiposit = ParseInt(textBoxCapacitatDiposit.Text),
                formaIngres = comboBoxFormaIngres.SelectedItem?.ToString() ?? "", // Handle null for ComboBox
                fontIngres = textBoxFontIngres.Text,
                numInventari = ParseInt(textBoxNumInventari.Text),
                multimedia = GetListBoxItems(listBoxMultimedia),
                descripcio = textBoxDescripcio.Text
            };

            DialogResult result = MessageBox.Show($"Els camps que no posseeixin informació o en els quals aquests valors siguin incorrectes, seràn assignats a un valor estàndar: ", "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.No)
            {
                // El usuario eligió no sobrescribir, salir del método
                return;
            }

            infoList.Add(info);

            // Serializar la lista completa a JSON
            JArray newJson = (JArray)JToken.FromObject(infoList);

            // Escribir el JSON de vuelta al archivo
            File.WriteAllText(jsonFilePath, newJson.ToString());

            this.Close();
        }


        // Helper method to parse integers with error handling
        private int ParseInt(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                // Handle parsing error as needed
                MessageBox.Show($"Invalid numeric input, will be set at '0': {input}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // or throw an exception or handle differently
            }
        }

        // Helper method to parse floats with error handling
        private float ParseFloat(string input)
        {
            float result;
            if (float.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                // Handle parsing error as needed
                MessageBox.Show($"Invalid numeric input, will be set at '0': { input}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.0f; // or throw an exception or handle differently
            }
        }

        // Helper method to get selected items from a ListBox
        private string[] GetListBoxItems(ListBox listBox)
        {
            List<string> items = new List<string>();
            foreach (var item in listBox.Items)
            {
                items.Add(item.ToString());
            }
            return items.ToArray();
        }

        //Helper method to add potencia to its specific power type
        private string TipoPotencia(string text, string comboBox)
        {
            string output = text + " " + comboBox;

            return output;
        }
    }
}