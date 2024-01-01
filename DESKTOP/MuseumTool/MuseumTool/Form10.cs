using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class visualizadorObjetos : Form
    {
        public int IdSeleccionado { get; private set; }
        public string ambitName {  get; private set; }
        public JArray ambitGeneral { get; set; }
        public int selectedRowIndex { get; private set; }
        public string ubicacioDesat {  get; private set; }

        public visualizadorObjetos()
        {
            InitializeComponent();
        }

        public void buttonCercar_Click(object sender, EventArgs e)
        {
            ambitName = comboBoxAmbit.Text;
            string ambitDir = "placeholder";

            switch (ambitName)
            {
                case "Transport de persones i mercaderies":
                    ambitDir = @"..\..\JSON\transportPersonesMercaderies.json";
                    ambitGeneral = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitGeneral;
                    ubicacioDesat = ambitDir;
                    break;

                case "Bombers":
                    ambitDir = @"..\..\JSON\bombers.json";
                    ambitGeneral = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitGeneral;
                    ubicacioDesat = ambitDir;
                    break;

                case "Motocicletes Catalanes":
                    ambitDir = @"..\..\JSON\motocicletesCatalanes.json";
                    ambitGeneral = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitGeneral;
                    ubicacioDesat = ambitDir;
                    break;

                case "Microcotxes i prototips elèctrics":
                    ambitDir = @"..\..\JSON\microcotxesElectricsIPrototips.json";
                    ambitGeneral = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitGeneral;
                    ubicacioDesat = ambitDir;
                    break;

                case "La revolució de l'utilitari":
                    ambitDir = @"..\..\JSON\revolucioUtilitari.json";
                    ambitGeneral = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitGeneral;
                    ubicacioDesat = ambitDir;
                    break;

                case "Inicis de l'aviació":
                    ambitDir = @"..\..\JSON\inicisAviacio.json";
                    ambitGeneral = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitGeneral;
                    ubicacioDesat = ambitDir;
                    break;

                default:
                    MessageBox.Show($"Selecciona un àmbit vàlid per a llistar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void dataGridViewObjectes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewObjectes.Rows.Count)
            {
                int idSeleccionado = Convert.ToInt32(dataGridViewObjectes.Rows[e.RowIndex].Cells["numInventari"].Value);
                IdSeleccionado = idSeleccionado;
                selectedRowIndex = e.RowIndex;
            }
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            switch (ambitName)
            {
                case "Transport de persones i mercaderies":
                    transportPersonesMercaderies enableEditModeTPM = new transportPersonesMercaderies();

                    enableEditModeTPM.initializationMode = true;
                    enableEditModeTPM.numInventariSel = IdSeleccionado;

                    enableEditModeTPM.Show();
                    this.Close();
                    break;

                case "Bombers":
                    bombers enableEditModeB = new bombers();

                    enableEditModeB.initializationMode = true;
                    enableEditModeB.numInventariSel = IdSeleccionado;

                    enableEditModeB.Show();
                    this.Close();
                    break;

                case "Motocicletes Catalanes":
                    motocicletesCatalanes enableEditModeM = new motocicletesCatalanes();

                    enableEditModeM.initializationMode = true;
                    enableEditModeM.numInventariSel = IdSeleccionado;

                    enableEditModeM.Show();
                    this.Close();
                    break;

                case "Microcotxes i prototips elèctrics":
                    microcotxesElectricsProtoipsUnics enableEditModeMPU = new microcotxesElectricsProtoipsUnics();

                    enableEditModeMPU.initializationMode = true;
                    enableEditModeMPU.numInventariSel = IdSeleccionado;

                    enableEditModeMPU.Show();
                    this.Close();
                    break;

                case "La revolució de l'utilitari":
                    Form7 enableEditModeRU = new Form7();

                    enableEditModeRU.initializationMode = true;
                    enableEditModeRU.numInventariSel = IdSeleccionado;

                    enableEditModeRU.Show();
                    this.Close();
                    break;

                case "Inicis de l'aviació":
                    inicisAviacio enableEditModeIA = new inicisAviacio();

                    enableEditModeIA.initializationMode = true;
                    enableEditModeIA.numInventariSel = IdSeleccionado;

                    enableEditModeIA.Show();
                    this.Close();
                    break;

                default:
                    MessageBox.Show($"Selecciona un àmbit vàlid per a llistar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ambitGeneral.RemoveAt(selectedRowIndex);
            dataGridViewObjectes.Refresh();
        }

        private void buttondesar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(ubicacioDesat, ambitGeneral.ToString());
            this.Close();
        }
    }
}
