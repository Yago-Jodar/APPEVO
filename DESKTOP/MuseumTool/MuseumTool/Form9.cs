﻿using Newtonsoft.Json.Linq;
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
                    JArray ambitSeleccionat = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitSeleccionat;
                    ambitGeneral = ambitSeleccionat;
                    break;

                case "Bombers":
                    ambitDir = @"..\..\JSON\transportPersonesMercaderies.json";
                    break;

                default:
                    MessageBox.Show($"Selecciona un àmbit vàlid per a llistar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        private void dataGridViewObjectes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en una celda válida
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewObjectes.Rows.Count)
            {
                // Obtiene el valor de la celda "numInventari" de la fila seleccionada
                int idSeleccionado = Convert.ToInt32(dataGridViewObjectes.Rows[e.RowIndex].Cells["numInventari"].Value);
                IdSeleccionado = idSeleccionado;
            }
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            switch (ambitName)
            {
                case "Transport de persones i mercaderies":
                    transportPersonesMercaderies enableEditMode = new transportPersonesMercaderies();

                    enableEditMode.initializationMode = true;
                    enableEditMode.numInventariSel = IdSeleccionado;

                    enableEditMode.Show();
                    this.Close();
                    break;

                case "Bombers":

                    break;

                default:
                    MessageBox.Show($"Selecciona un àmbit vàlid per a llistar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
