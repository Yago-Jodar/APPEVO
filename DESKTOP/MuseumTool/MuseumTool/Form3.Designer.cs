namespace MuseumTool
{
    partial class bombers
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
            this.desar = new System.Windows.Forms.Button();
            this.groupBoxDescripcio = new System.Windows.Forms.GroupBox();
            this.textBoxDescripcio = new System.Windows.Forms.TextBox();
            this.groupBoxMedia = new System.Windows.Forms.GroupBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.afegir = new System.Windows.Forms.Button();
            this.groupBoxFitxaTecnica = new System.Windows.Forms.GroupBox();
            this.comboBoxPotencia = new System.Windows.Forms.ComboBox();
            this.capacitatDiposit = new System.Windows.Forms.Label();
            this.textBoxCapacitatDiposit = new System.Windows.Forms.TextBox();
            this.autonomia = new System.Windows.Forms.Label();
            this.textBoxAutonomia = new System.Windows.Forms.TextBox();
            this.velMax = new System.Windows.Forms.Label();
            this.textBoxVelMax = new System.Windows.Forms.TextBox();
            this.potencia = new System.Windows.Forms.Label();
            this.textBoxPotencia = new System.Windows.Forms.TextBox();
            this.cilindrada = new System.Windows.Forms.Label();
            this.textBoxCilindrada = new System.Windows.Forms.TextBox();
            this.cicle = new System.Windows.Forms.Label();
            this.textBoxCicle = new System.Windows.Forms.TextBox();
            this.llocFabricacio = new System.Windows.Forms.Label();
            this.textBoxLlocFabricacio = new System.Windows.Forms.TextBox();
            this.textBoxAny = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.any = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.groupBoxConfigBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colleccio = new System.Windows.Forms.Label();
            this.textBoxNumInventari = new System.Windows.Forms.TextBox();
            this.comboBoxColleccio = new System.Windows.Forms.ComboBox();
            this.listBoxMultimedia = new System.Windows.Forms.ListBox();
            this.comboBoxFormaIngres = new System.Windows.Forms.ComboBox();
            this.formaIngres = new System.Windows.Forms.Label();
            this.fontIngres = new System.Windows.Forms.Label();
            this.textBoxFontIngres = new System.Windows.Forms.TextBox();
            this.groupBoxDescripcio.SuspendLayout();
            this.groupBoxMedia.SuspendLayout();
            this.groupBoxFitxaTecnica.SuspendLayout();
            this.groupBoxConfigBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // desar
            // 
            this.desar.Location = new System.Drawing.Point(394, 371);
            this.desar.Name = "desar";
            this.desar.Size = new System.Drawing.Size(268, 46);
            this.desar.TabIndex = 11;
            this.desar.Text = "Desar";
            this.desar.UseVisualStyleBackColor = true;
            this.desar.Click += new System.EventHandler(this.desar_Click);
            // 
            // groupBoxDescripcio
            // 
            this.groupBoxDescripcio.Controls.Add(this.textBoxDescripcio);
            this.groupBoxDescripcio.Location = new System.Drawing.Point(394, 185);
            this.groupBoxDescripcio.Name = "groupBoxDescripcio";
            this.groupBoxDescripcio.Size = new System.Drawing.Size(268, 180);
            this.groupBoxDescripcio.TabIndex = 10;
            this.groupBoxDescripcio.TabStop = false;
            this.groupBoxDescripcio.Text = "Descripció";
            // 
            // textBoxDescripcio
            // 
            this.textBoxDescripcio.Location = new System.Drawing.Point(7, 20);
            this.textBoxDescripcio.Multiline = true;
            this.textBoxDescripcio.Name = "textBoxDescripcio";
            this.textBoxDescripcio.Size = new System.Drawing.Size(255, 149);
            this.textBoxDescripcio.TabIndex = 0;
            // 
            // groupBoxMedia
            // 
            this.groupBoxMedia.Controls.Add(this.listBoxMultimedia);
            this.groupBoxMedia.Controls.Add(this.eliminar);
            this.groupBoxMedia.Controls.Add(this.afegir);
            this.groupBoxMedia.Location = new System.Drawing.Point(394, 12);
            this.groupBoxMedia.Name = "groupBoxMedia";
            this.groupBoxMedia.Size = new System.Drawing.Size(268, 164);
            this.groupBoxMedia.TabIndex = 9;
            this.groupBoxMedia.TabStop = false;
            this.groupBoxMedia.Text = "Multimedia";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(186, 133);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 2;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // afegir
            // 
            this.afegir.Location = new System.Drawing.Point(105, 133);
            this.afegir.Name = "afegir";
            this.afegir.Size = new System.Drawing.Size(75, 23);
            this.afegir.TabIndex = 1;
            this.afegir.Text = "Afegir";
            this.afegir.UseVisualStyleBackColor = true;
            this.afegir.Click += new System.EventHandler(this.afegir_Click);
            // 
            // groupBoxFitxaTecnica
            // 
            this.groupBoxFitxaTecnica.Controls.Add(this.comboBoxFormaIngres);
            this.groupBoxFitxaTecnica.Controls.Add(this.formaIngres);
            this.groupBoxFitxaTecnica.Controls.Add(this.fontIngres);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxFontIngres);
            this.groupBoxFitxaTecnica.Controls.Add(this.comboBoxPotencia);
            this.groupBoxFitxaTecnica.Controls.Add(this.capacitatDiposit);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxCapacitatDiposit);
            this.groupBoxFitxaTecnica.Controls.Add(this.autonomia);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxAutonomia);
            this.groupBoxFitxaTecnica.Controls.Add(this.velMax);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxVelMax);
            this.groupBoxFitxaTecnica.Controls.Add(this.potencia);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxPotencia);
            this.groupBoxFitxaTecnica.Controls.Add(this.cilindrada);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxCilindrada);
            this.groupBoxFitxaTecnica.Controls.Add(this.cicle);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxCicle);
            this.groupBoxFitxaTecnica.Controls.Add(this.llocFabricacio);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxLlocFabricacio);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxAny);
            this.groupBoxFitxaTecnica.Controls.Add(this.textBoxNom);
            this.groupBoxFitxaTecnica.Controls.Add(this.any);
            this.groupBoxFitxaTecnica.Controls.Add(this.nom);
            this.groupBoxFitxaTecnica.Location = new System.Drawing.Point(12, 111);
            this.groupBoxFitxaTecnica.Name = "groupBoxFitxaTecnica";
            this.groupBoxFitxaTecnica.Size = new System.Drawing.Size(366, 306);
            this.groupBoxFitxaTecnica.TabIndex = 8;
            this.groupBoxFitxaTecnica.TabStop = false;
            this.groupBoxFitxaTecnica.Text = "Fitxa Tècnica";
            // 
            // comboBoxPotencia
            // 
            this.comboBoxPotencia.FormattingEnabled = true;
            this.comboBoxPotencia.Items.AddRange(new object[] {
            "cv",
            "HP",
            "KW"});
            this.comboBoxPotencia.Location = new System.Drawing.Point(308, 149);
            this.comboBoxPotencia.Name = "comboBoxPotencia";
            this.comboBoxPotencia.Size = new System.Drawing.Size(52, 21);
            this.comboBoxPotencia.TabIndex = 48;
            // 
            // capacitatDiposit
            // 
            this.capacitatDiposit.AutoSize = true;
            this.capacitatDiposit.Location = new System.Drawing.Point(6, 204);
            this.capacitatDiposit.Name = "capacitatDiposit";
            this.capacitatDiposit.Size = new System.Drawing.Size(85, 13);
            this.capacitatDiposit.TabIndex = 39;
            this.capacitatDiposit.Text = "Capacitat dipòsit";
            // 
            // textBoxCapacitatDiposit
            // 
            this.textBoxCapacitatDiposit.Location = new System.Drawing.Point(140, 201);
            this.textBoxCapacitatDiposit.Name = "textBoxCapacitatDiposit";
            this.textBoxCapacitatDiposit.Size = new System.Drawing.Size(220, 20);
            this.textBoxCapacitatDiposit.TabIndex = 38;
            // 
            // autonomia
            // 
            this.autonomia.AutoSize = true;
            this.autonomia.Location = new System.Drawing.Point(6, 230);
            this.autonomia.Name = "autonomia";
            this.autonomia.Size = new System.Drawing.Size(57, 13);
            this.autonomia.TabIndex = 35;
            this.autonomia.Text = "Autonomia";
            // 
            // textBoxAutonomia
            // 
            this.textBoxAutonomia.Location = new System.Drawing.Point(140, 227);
            this.textBoxAutonomia.Name = "textBoxAutonomia";
            this.textBoxAutonomia.Size = new System.Drawing.Size(220, 20);
            this.textBoxAutonomia.TabIndex = 34;
            // 
            // velMax
            // 
            this.velMax.AutoSize = true;
            this.velMax.Location = new System.Drawing.Point(6, 178);
            this.velMax.Name = "velMax";
            this.velMax.Size = new System.Drawing.Size(86, 13);
            this.velMax.TabIndex = 31;
            this.velMax.Text = "Velocitat màxima";
            // 
            // textBoxVelMax
            // 
            this.textBoxVelMax.Location = new System.Drawing.Point(140, 175);
            this.textBoxVelMax.Name = "textBoxVelMax";
            this.textBoxVelMax.Size = new System.Drawing.Size(220, 20);
            this.textBoxVelMax.TabIndex = 30;
            // 
            // potencia
            // 
            this.potencia.AutoSize = true;
            this.potencia.Location = new System.Drawing.Point(6, 152);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(49, 13);
            this.potencia.TabIndex = 29;
            this.potencia.Text = "Potència";
            // 
            // textBoxPotencia
            // 
            this.textBoxPotencia.Location = new System.Drawing.Point(140, 149);
            this.textBoxPotencia.Name = "textBoxPotencia";
            this.textBoxPotencia.Size = new System.Drawing.Size(162, 20);
            this.textBoxPotencia.TabIndex = 28;
            // 
            // cilindrada
            // 
            this.cilindrada.AutoSize = true;
            this.cilindrada.Location = new System.Drawing.Point(6, 126);
            this.cilindrada.Name = "cilindrada";
            this.cilindrada.Size = new System.Drawing.Size(53, 13);
            this.cilindrada.TabIndex = 27;
            this.cilindrada.Text = "Cilindrada";
            // 
            // textBoxCilindrada
            // 
            this.textBoxCilindrada.Location = new System.Drawing.Point(140, 123);
            this.textBoxCilindrada.Name = "textBoxCilindrada";
            this.textBoxCilindrada.Size = new System.Drawing.Size(220, 20);
            this.textBoxCilindrada.TabIndex = 26;
            // 
            // cicle
            // 
            this.cicle.AutoSize = true;
            this.cicle.Location = new System.Drawing.Point(6, 100);
            this.cicle.Name = "cicle";
            this.cicle.Size = new System.Drawing.Size(30, 13);
            this.cicle.TabIndex = 25;
            this.cicle.Text = "Cicle";
            // 
            // textBoxCicle
            // 
            this.textBoxCicle.Location = new System.Drawing.Point(140, 97);
            this.textBoxCicle.Name = "textBoxCicle";
            this.textBoxCicle.Size = new System.Drawing.Size(220, 20);
            this.textBoxCicle.TabIndex = 24;
            // 
            // llocFabricacio
            // 
            this.llocFabricacio.AutoSize = true;
            this.llocFabricacio.Location = new System.Drawing.Point(6, 74);
            this.llocFabricacio.Name = "llocFabricacio";
            this.llocFabricacio.Size = new System.Drawing.Size(91, 13);
            this.llocFabricacio.TabIndex = 9;
            this.llocFabricacio.Text = "Lloc de fabricació";
            // 
            // textBoxLlocFabricacio
            // 
            this.textBoxLlocFabricacio.Location = new System.Drawing.Point(140, 71);
            this.textBoxLlocFabricacio.Name = "textBoxLlocFabricacio";
            this.textBoxLlocFabricacio.Size = new System.Drawing.Size(220, 20);
            this.textBoxLlocFabricacio.TabIndex = 8;
            // 
            // textBoxAny
            // 
            this.textBoxAny.Location = new System.Drawing.Point(140, 45);
            this.textBoxAny.Name = "textBoxAny";
            this.textBoxAny.Size = new System.Drawing.Size(220, 20);
            this.textBoxAny.TabIndex = 7;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(140, 19);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(220, 20);
            this.textBoxNom.TabIndex = 6;
            // 
            // any
            // 
            this.any.AutoSize = true;
            this.any.Location = new System.Drawing.Point(6, 48);
            this.any.Name = "any";
            this.any.Size = new System.Drawing.Size(25, 13);
            this.any.TabIndex = 5;
            this.any.Text = "Any";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(6, 22);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(29, 13);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom";
            // 
            // groupBoxConfigBox
            // 
            this.groupBoxConfigBox.Controls.Add(this.label1);
            this.groupBoxConfigBox.Controls.Add(this.colleccio);
            this.groupBoxConfigBox.Controls.Add(this.textBoxNumInventari);
            this.groupBoxConfigBox.Controls.Add(this.comboBoxColleccio);
            this.groupBoxConfigBox.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfigBox.Name = "groupBoxConfigBox";
            this.groupBoxConfigBox.Size = new System.Drawing.Size(366, 78);
            this.groupBoxConfigBox.TabIndex = 12;
            this.groupBoxConfigBox.TabStop = false;
            this.groupBoxConfigBox.Text = "Configuració";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Número d\'inventari";
            // 
            // colleccio
            // 
            this.colleccio.AutoSize = true;
            this.colleccio.Location = new System.Drawing.Point(6, 49);
            this.colleccio.Name = "colleccio";
            this.colleccio.Size = new System.Drawing.Size(53, 13);
            this.colleccio.TabIndex = 3;
            this.colleccio.Text = "Col·lecció";
            // 
            // textBoxNumInventari
            // 
            this.textBoxNumInventari.Location = new System.Drawing.Point(111, 19);
            this.textBoxNumInventari.Name = "textBoxNumInventari";
            this.textBoxNumInventari.Size = new System.Drawing.Size(249, 20);
            this.textBoxNumInventari.TabIndex = 1;
            // 
            // comboBoxColleccio
            // 
            this.comboBoxColleccio.AllowDrop = true;
            this.comboBoxColleccio.FormattingEnabled = true;
            this.comboBoxColleccio.Location = new System.Drawing.Point(111, 45);
            this.comboBoxColleccio.Name = "comboBoxColleccio";
            this.comboBoxColleccio.Size = new System.Drawing.Size(249, 21);
            this.comboBoxColleccio.TabIndex = 2;
            // 
            // listBoxMultimedia
            // 
            this.listBoxMultimedia.FormattingEnabled = true;
            this.listBoxMultimedia.Location = new System.Drawing.Point(6, 19);
            this.listBoxMultimedia.Name = "listBoxMultimedia";
            this.listBoxMultimedia.Size = new System.Drawing.Size(255, 108);
            this.listBoxMultimedia.TabIndex = 3;
            // 
            // comboBoxFormaIngres
            // 
            this.comboBoxFormaIngres.FormattingEnabled = true;
            this.comboBoxFormaIngres.Items.AddRange(new object[] {
            "Donació",
            "Compra",
            "Dipòsit",
            "Cessió"});
            this.comboBoxFormaIngres.Location = new System.Drawing.Point(140, 253);
            this.comboBoxFormaIngres.Name = "comboBoxFormaIngres";
            this.comboBoxFormaIngres.Size = new System.Drawing.Size(220, 21);
            this.comboBoxFormaIngres.TabIndex = 52;
            // 
            // formaIngres
            // 
            this.formaIngres.AutoSize = true;
            this.formaIngres.Location = new System.Drawing.Point(6, 256);
            this.formaIngres.Name = "formaIngres";
            this.formaIngres.Size = new System.Drawing.Size(72, 13);
            this.formaIngres.TabIndex = 55;
            this.formaIngres.Text = "Forma d\'ingés";
            // 
            // fontIngres
            // 
            this.fontIngres.AutoSize = true;
            this.fontIngres.Location = new System.Drawing.Point(6, 283);
            this.fontIngres.Name = "fontIngres";
            this.fontIngres.Size = new System.Drawing.Size(67, 13);
            this.fontIngres.TabIndex = 54;
            this.fontIngres.Text = "Font d\'ingrés";
            // 
            // textBoxFontIngres
            // 
            this.textBoxFontIngres.Location = new System.Drawing.Point(140, 280);
            this.textBoxFontIngres.Name = "textBoxFontIngres";
            this.textBoxFontIngres.Size = new System.Drawing.Size(220, 20);
            this.textBoxFontIngres.TabIndex = 53;
            // 
            // bombers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 428);
            this.Controls.Add(this.groupBoxConfigBox);
            this.Controls.Add(this.desar);
            this.Controls.Add(this.groupBoxDescripcio);
            this.Controls.Add(this.groupBoxMedia);
            this.Controls.Add(this.groupBoxFitxaTecnica);
            this.Name = "bombers";
            this.Text = "Bombers";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBoxDescripcio.ResumeLayout(false);
            this.groupBoxDescripcio.PerformLayout();
            this.groupBoxMedia.ResumeLayout(false);
            this.groupBoxFitxaTecnica.ResumeLayout(false);
            this.groupBoxFitxaTecnica.PerformLayout();
            this.groupBoxConfigBox.ResumeLayout(false);
            this.groupBoxConfigBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button desar;
        private System.Windows.Forms.GroupBox groupBoxDescripcio;
        private System.Windows.Forms.TextBox textBoxDescripcio;
        private System.Windows.Forms.GroupBox groupBoxMedia;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button afegir;
        private System.Windows.Forms.GroupBox groupBoxFitxaTecnica;
        private System.Windows.Forms.ComboBox comboBoxPotencia;
        private System.Windows.Forms.Label capacitatDiposit;
        private System.Windows.Forms.TextBox textBoxCapacitatDiposit;
        private System.Windows.Forms.Label autonomia;
        private System.Windows.Forms.TextBox textBoxAutonomia;
        private System.Windows.Forms.Label velMax;
        private System.Windows.Forms.TextBox textBoxVelMax;
        private System.Windows.Forms.Label potencia;
        private System.Windows.Forms.TextBox textBoxPotencia;
        private System.Windows.Forms.Label cilindrada;
        private System.Windows.Forms.TextBox textBoxCilindrada;
        private System.Windows.Forms.Label cicle;
        private System.Windows.Forms.TextBox textBoxCicle;
        private System.Windows.Forms.Label llocFabricacio;
        private System.Windows.Forms.TextBox textBoxLlocFabricacio;
        private System.Windows.Forms.TextBox textBoxAny;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label any;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.GroupBox groupBoxConfigBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label colleccio;
        private System.Windows.Forms.TextBox textBoxNumInventari;
        private System.Windows.Forms.ComboBox comboBoxColleccio;
        private System.Windows.Forms.ListBox listBoxMultimedia;
        private System.Windows.Forms.ComboBox comboBoxFormaIngres;
        private System.Windows.Forms.Label formaIngres;
        private System.Windows.Forms.Label fontIngres;
        private System.Windows.Forms.TextBox textBoxFontIngres;
    }
}