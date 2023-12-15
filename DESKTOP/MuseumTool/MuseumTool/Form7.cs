using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class Form7 : Form
    {
        public Boolean initializationMode { get; set; }
        public int numInventariSel { get; set; }

        public Form7()
        {
            InitializeComponent();
        }


        private void Form7_Load(object sender, EventArgs e)
        {

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

                    try
                    {
                        File.Copy(filePath, destinationPath);
                    }
                    catch
                    {
                        MessageBox.Show($"L'imatge ja existeix: {filename}", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!listBoxMultimedia.Items.Contains(destinationPath))
                    {
                        listBoxMultimedia.Items.Add(destinationPath);
                    }
                }
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (var selectedItem in listBoxMultimedia.SelectedItems)
            {
                selectedItems.Add(selectedItem.ToString());
            }

            foreach (var selectedItem in selectedItems)
            {
                listBoxMultimedia.Items.Remove(selectedItem);

                File.Delete(selectedItem);
            }
        }

        private void desar_Click(object sender, EventArgs e)
        {
            string jsonFilePath = @"..\..\JSON\InfoCarrierRevolucioUtilitari.json";

            List<InfoCarrierRevolucioUtilitari> infoList;

            if (!File.Exists(jsonFilePath))
            {
                infoList = new List<InfoCarrierRevolucioUtilitari>();
            }

            JArray existingJson = JArray.Parse(File.ReadAllText(jsonFilePath));

            infoList = existingJson.ToObject<List<InfoCarrierRevolucioUtilitari>>();

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

            InfoCarrierRevolucioUtilitari info = new InfoCarrierRevolucioUtilitari
            {
                numInventari = ParseInt(textBoxNumInventari.Text),
                collceccio = comboBoxColleccio.SelectedItem?.ToString() ?? "",
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
                formaIngres = comboBoxFormaIngres.SelectedItem?.ToString() ?? "",
                fontIngres = textBoxFontIngres.Text,
                multimedia = GetListBoxItems(listBoxMultimedia),
                descripcio = textBoxDescripcio.Text
            };

            infoList.Add(info);

            DialogResult result = MessageBox.Show($"Els camps que no posseeixin informació o en els quals aquests valors siguin incorrectes, seràn assignats a un valor estàndar: ", "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            JArray newJson = (JArray)JToken.FromObject(infoList);

            File.WriteAllText(jsonFilePath, newJson.ToString());

            this.Close();
        }

        private int ParseInt(string input)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                MessageBox.Show($"Invalid numeric input, will be set at '0': {input}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

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