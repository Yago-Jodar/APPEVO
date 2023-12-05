using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumTool
{
    public partial class microcotxesElectricsProtoipsUnics : Form
    {
        public microcotxesElectricsProtoipsUnics()
        {
            InitializeComponent();
        }

        private void afegir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            DialogResult result = folder.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                
            }
        }

        private void listBoxMultimedia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
