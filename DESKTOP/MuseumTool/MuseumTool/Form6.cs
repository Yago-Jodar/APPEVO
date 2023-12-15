using MuseumTool.JSON;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class inicisAviacio : Form
    {
        public Boolean initializationMode { get; set; }
        public int numInventariSel { get; set; }

        public inicisAviacio()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            List<Colleccions> colleccioList;

            if (File.Exists(Colleccions.colleccionsDir))
            {
                string jsonColleccionsExists = File.ReadAllText(Colleccions.colleccionsDir);

                colleccioList = JsonConvert.DeserializeObject<List<Colleccions>>(jsonColleccionsExists);

                foreach (var collection in colleccioList)
                {
                    comboBoxColleccio.Items.Add(collection.nombre);
                }
            }

            if (initializationMode && numInventariSel != 0)
            {
                string existingJson = File.ReadAllText(@"..\..\JSON\motocicletesCatalanes.json");

                JArray jsonArray = JArray.Parse(existingJson);

                JObject selectedObject = jsonArray.FirstOrDefault(obj => (int)obj["numInventari"] == numInventariSel) as JObject;

                if (selectedObject != null)
                {
                    textBoxNumInventari.Text = (string)selectedObject["numInventari"];
                    comboBoxColleccio.SelectedItem = (string)selectedObject["collceccio"];
                    textBoxNom.Text = (string)selectedObject["name"];
                    textBoxAny.Text = (string)selectedObject["any"];
                    textBoxLlocFabricacio.Text = (string)selectedObject["llocFabricacio"];
                    textBoxLlocProcedencia.Text = (string)selectedObject["procedencia"];
                    textBoxFontEnergia.Text = (string)selectedObject["fontEnergia"];
                    textBoxLongitud.Text = (string)selectedObject["longitud"];
                    textBoxAlcada.Text = (string)selectedObject["alcada"];
                    textBoxEnvergadura.Text = (string)selectedObject["envergadura"];
                    textBoxPes.Text = (string)selectedObject["pes"];
                    textBoxPesEnlairament.Text = (string)selectedObject["pesMax"];
                    textBoxCicle.Text = (string)selectedObject["cicle"];
                    textBoxCilindrada.Text = (string)selectedObject["cilindrada"];
                    textBoxPotencia.Text = (string)selectedObject["potenciaVal"];
                    comboBoxPotencia.SelectedItem = (string)selectedObject["potenciaType"];
                    textBoxVelMax.Text = (string)selectedObject["velocitatMaxima"];
                    textBoxVelCreuer.Text = (string)selectedObject["velocitatCreuer"];
                    textBoxCapacitatDiposit.Text = (string)selectedObject["capacitatDiposit"];
                    textBoxAutonomia.Text = (string)selectedObject["autonomia"];
                    textBoxAutonomiaTemps.Text = (string)selectedObject["autonomiaTemps"];
                    textBoxQuilometresFets.Text = (string)selectedObject["quilometresFets"];
                    textBoxSostreMax.Text = (string)selectedObject["sostreMax"];
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
            file.Filter = "Imatges o videos amb format (*.jpg, *.jpeg, *.png, *.tiff, *.mp4)|*.jpg;*.jpeg;*.png;*.tiff;*.mp4";
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
            string jsonFilePath = @"..\..\JSON\motociclestesCatalanes.json";

            // Crear una lista para almacenar objetos InfoCarrierBombers
            List<InfoCarrierInicisAviacio> infoList;

            // Leer el contenido del archivo JSON existente
            JArray existingJson = JArray.Parse(File.ReadAllText(jsonFilePath));

            // Deserializar el JSON existente a la lista de InfoCarrierBombers
            infoList = existingJson.ToObject<List<InfoCarrierInicisAviacio>>();

            // Buscar el objeto correspondiente al número de inventario seleccionado
            JObject currentNumInventari = existingJson.FirstOrDefault(obj => (int)obj["numInventari"] == ParseInt(textBoxNumInventari.Text)) as JObject;

            if (textBoxNumInventari.Text == "" || ParseInt(textBoxNumInventari.Text) == 0)
            {
                MessageBox.Show($"El número d'inventari es un camp obligatori", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentNumInventari == null)
            {
                int numInventariExists = 0;

                if (numInventariExists == ParseInt(textBoxNumInventari.Text))
                {
                    DialogResult overwrite = MessageBox.Show("El valor sel·leccionat com a número d'inventari no es vàlid\nSi us plau, sel·lecciona un número d'invetari vàlid", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if ((int)currentNumInventari["numInventari"] == ParseInt(textBoxNumInventari.Text))
                {
                    DialogResult overwrite = MessageBox.Show("El número d'inventari sel·leccionat, ja existeix, pertany al objecte amb el nom " + currentNumInventari["name"] + ", si continues, s'esborrarà l'objecte " + currentNumInventari["name"] + ", i en el seu lloc s'aplicaràn les noves dades a l'objecte amb número d'inventari " + currentNumInventari["numInventari"] + "\nDesitja continuar?", "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (overwrite == DialogResult.Yes)
                    {
                        infoList.RemoveAt(existingJson.IndexOf(currentNumInventari));
                    }
                }
            }

            // Crear una instancia de InfoCarrier y poblar sus propiedades
            InfoCarrierInicisAviacio info = new InfoCarrierInicisAviacio
            {
                numInventari = ParseInt(textBoxNumInventari.Text),
                collceccio = comboBoxColleccio.SelectedItem?.ToString() ?? "", // Handle null for ComboBox
                name = textBoxNom.Text,
                any = ParseInt(textBoxAny.Text),
                llocFabricacio = textBoxLlocFabricacio.Text,
                procedencia = textBoxLlocProcedencia.Text,
                fontEnergia = textBoxFontEnergia.Text,
                longitud = ParseFloat(textBoxLongitud.Text),
                alcada = ParseFloat(textBoxAlcada.Text),
                envergadura = ParseFloat(textBoxEnvergadura.Text),
                pes = ParseFloat(textBoxPes.Text),
                pesMax = ParseFloat(textBoxPesEnlairament.Text),
                cicle = ParseInt(textBoxCicle.Text),
                cilindrada = ParseInt(textBoxCilindrada.Text),
                potencia = TipoPotencia(textBoxPotencia.Text, comboBoxPotencia.SelectedItem?.ToString() ?? ""),
                potenciaVal = ParseFloat(textBoxPotencia.Text),
                potenciaType = comboBoxPotencia.SelectedItem?.ToString() ?? "",
                velocitatMaxima = ParseInt(textBoxVelMax.Text),
                velocitatcreuer = ParseInt(textBoxVelCreuer.Text),
                autonomia = ParseFloat(textBoxAutonomia.Text),
                autonomiaTemps = ParseFloat(textBoxAutonomiaTemps.Text),
                capacitatDiposit = ParseInt(textBoxCapacitatDiposit.Text),
                quilometresFets = ParseFloat(textBoxQuilometresFets.Text),
                sostreMax = ParseInt(textBoxSostreMax.Text),
                fontIngres = textBoxFontIngres.Text,
                formaIngres = comboBoxFormaIngres.SelectedItem?.ToString() ?? "",
                multimedia = GetListBoxItems(listBoxMultimedia),
                descripcio = textBoxDescripcio.Text
            };

            infoList.Add(info);

            DialogResult result = MessageBox.Show($"Els camps que no posseeixin informació o en els quals aquests valors siguin incorrectes, seràn assignats a un valor estàndar: ", "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                // El usuario eligió no guardar la entrada, salir del método
                return;
            }

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
                MessageBox.Show($"Invalid numeric input, will be set at '0': {input}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.0f;
            }
        }

        private JArray GetListBoxItems(ListBox listBox)
        {
            JArray itemsArray = new JArray();
            foreach (var item in listBox.Items)
            {
                itemsArray.Add(item.ToString());
            }
            return itemsArray;
        }

        private string TipoPotencia(string text, string comboBox)
        {
            string output = text + " " + comboBox;

            return output;
        }
    }

}

