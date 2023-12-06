namespace MuseumTool
{
    partial class visualizadorObjetos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lavelAmbit = new System.Windows.Forms.Label();
            this.comboBoxAmbit = new System.Windows.Forms.ComboBox();
            this.dataGridViewObjectes = new System.Windows.Forms.DataGridView();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCercar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectes)).BeginInit();
            this.SuspendLayout();
            // 
            // lavelAmbit
            // 
            this.lavelAmbit.AutoSize = true;
            this.lavelAmbit.Location = new System.Drawing.Point(12, 16);
            this.lavelAmbit.Name = "lavelAmbit";
            this.lavelAmbit.Size = new System.Drawing.Size(33, 13);
            this.lavelAmbit.TabIndex = 5;
            this.lavelAmbit.Text = "Àmbit";
            // 
            // comboBoxAmbit
            // 
            this.comboBoxAmbit.AllowDrop = true;
            this.comboBoxAmbit.FormattingEnabled = true;
            this.comboBoxAmbit.Items.AddRange(new object[] {
            "Transport de persones i mercaderies",
            "Bombers",
            "Motocicletes Catalanes",
            "Microcotxes i prototips elèctrics",
            "La revolució de l\'utilitari",
            "Inicis de l\'aviació"});
            this.comboBoxAmbit.Location = new System.Drawing.Point(51, 11);
            this.comboBoxAmbit.Name = "comboBoxAmbit";
            this.comboBoxAmbit.Size = new System.Drawing.Size(373, 21);
            this.comboBoxAmbit.TabIndex = 4;
            // 
            // dataGridViewObjectes
            // 
            this.dataGridViewObjectes.AllowUserToAddRows = false;
            this.dataGridViewObjectes.AllowUserToDeleteRows = false;
            this.dataGridViewObjectes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjectes.Location = new System.Drawing.Point(15, 39);
            this.dataGridViewObjectes.MultiSelect = false;
            this.dataGridViewObjectes.Name = "dataGridViewObjectes";
            this.dataGridViewObjectes.ReadOnly = true;
            this.dataGridViewObjectes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewObjectes.Size = new System.Drawing.Size(547, 314);
            this.dataGridViewObjectes.TabIndex = 6;
            this.dataGridViewObjectes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjectes_RowEnter);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(15, 359);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(268, 46);
            this.buttonModificar.TabIndex = 9;
            this.buttonModificar.Text = "Modificar objecte";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(294, 359);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(268, 46);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar objecte";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonCercar
            // 
            this.buttonCercar.Location = new System.Drawing.Point(430, 11);
            this.buttonCercar.Name = "buttonCercar";
            this.buttonCercar.Size = new System.Drawing.Size(132, 21);
            this.buttonCercar.TabIndex = 11;
            this.buttonCercar.Text = "Cercar àmbit";
            this.buttonCercar.UseVisualStyleBackColor = true;
            this.buttonCercar.Click += new System.EventHandler(this.buttonCercar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(547, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Desar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // visualizadorObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCercar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewObjectes);
            this.Controls.Add(this.lavelAmbit);
            this.Controls.Add(this.comboBoxAmbit);
            this.Name = "visualizadorObjetos";
            this.Text = "Visualitzador  d\'objectes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjectes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lavelAmbit;
        private System.Windows.Forms.ComboBox comboBoxAmbit;
        private System.Windows.Forms.DataGridView dataGridViewObjectes;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCercar;
        private System.Windows.Forms.Button button1;
    }
}