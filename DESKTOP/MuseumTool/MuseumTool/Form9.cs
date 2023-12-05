using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class visualizadorObjetos : Form
    {
        public visualizadorObjetos()
        {
            InitializeComponent();
        }

        private void buttonCercar_Click(object sender, EventArgs e)
        {
            string ambitName = comboBoxAmbit.Text;
            string ambitDir = "placeholder";

            switch (ambitName)
            {
                case "Transport de persones i mercaderies":
                    ambitDir = @"..\..\JSON\transportPersonesMercaderies.json";
                    List<transportPersonesMercaderies> transportPersonesMercaderies;
                    JArray ambitSeleccionat = JArray.Parse(File.ReadAllText(ambitDir));

                    dataGridViewObjectes.DataSource = ambitSeleccionat;
                    break;

                case "Bombers":
                    ambitDir = @"..\..\JSON\transportPersonesMercaderies.json";
                    break;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            dataGridViewObjectes.SelectedRows.
        }
    }
}
