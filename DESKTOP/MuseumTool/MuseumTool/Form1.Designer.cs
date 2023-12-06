namespace MuseumTool
{
    partial class museumToolGeneral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(museumToolGeneral));
            this.revolucioUtilitari = new System.Windows.Forms.Button();
            this.microcotxesPrototipsElectrics = new System.Windows.Forms.Button();
            this.motocicletesCatalanes = new System.Windows.Forms.Button();
            this.bombers = new System.Windows.Forms.Button();
            this.TransportPersonesMercaderies = new System.Windows.Forms.Button();
            this.inicisAviacio = new System.Windows.Forms.Button();
            this.groupBoxCrear = new System.Windows.Forms.GroupBox();
            this.groupBoxAdministracio = new System.Windows.Forms.GroupBox();
            this.buttonEditarColleccions = new System.Windows.Forms.Button();
            this.buttonModificarPreguntes = new System.Windows.Forms.Button();
            this.buttonCrearPregunta = new System.Windows.Forms.Button();
            this.buttonEliminarObjecte = new System.Windows.Forms.Button();
            this.buttonMostrarInfoItemsMuseu = new System.Windows.Forms.Button();
            this.tancar = new System.Windows.Forms.Button();
            this.groupBoxCrear.SuspendLayout();
            this.groupBoxAdministracio.SuspendLayout();
            this.SuspendLayout();
            // 
            // revolucioUtilitari
            // 
            this.revolucioUtilitari.Location = new System.Drawing.Point(6, 227);
            this.revolucioUtilitari.Name = "revolucioUtilitari";
            this.revolucioUtilitari.Size = new System.Drawing.Size(268, 46);
            this.revolucioUtilitari.TabIndex = 5;
            this.revolucioUtilitari.Text = "La revolució de l\'utilitari";
            this.revolucioUtilitari.UseVisualStyleBackColor = true;
            this.revolucioUtilitari.Click += new System.EventHandler(this.revolucioUtilitari_Click);
            // 
            // microcotxesPrototipsElectrics
            // 
            this.microcotxesPrototipsElectrics.Location = new System.Drawing.Point(6, 175);
            this.microcotxesPrototipsElectrics.Name = "microcotxesPrototipsElectrics";
            this.microcotxesPrototipsElectrics.Size = new System.Drawing.Size(268, 46);
            this.microcotxesPrototipsElectrics.TabIndex = 4;
            this.microcotxesPrototipsElectrics.Text = "Microcotxes i prototips elèctrics";
            this.microcotxesPrototipsElectrics.UseVisualStyleBackColor = true;
            this.microcotxesPrototipsElectrics.Click += new System.EventHandler(this.microcotxesPrototipsElectrics_Click);
            // 
            // motocicletesCatalanes
            // 
            this.motocicletesCatalanes.Location = new System.Drawing.Point(6, 123);
            this.motocicletesCatalanes.Name = "motocicletesCatalanes";
            this.motocicletesCatalanes.Size = new System.Drawing.Size(268, 46);
            this.motocicletesCatalanes.TabIndex = 3;
            this.motocicletesCatalanes.Text = "Motocicletes Catalanes";
            this.motocicletesCatalanes.UseVisualStyleBackColor = true;
            this.motocicletesCatalanes.Click += new System.EventHandler(this.motocicletesCatalanes_Click);
            // 
            // bombers
            // 
            this.bombers.Location = new System.Drawing.Point(6, 71);
            this.bombers.Name = "bombers";
            this.bombers.Size = new System.Drawing.Size(268, 46);
            this.bombers.TabIndex = 2;
            this.bombers.Text = "Bombers";
            this.bombers.UseVisualStyleBackColor = true;
            this.bombers.Click += new System.EventHandler(this.bombers_Click);
            // 
            // TransportPersonesMercaderies
            // 
            this.TransportPersonesMercaderies.Location = new System.Drawing.Point(6, 19);
            this.TransportPersonesMercaderies.Name = "TransportPersonesMercaderies";
            this.TransportPersonesMercaderies.Size = new System.Drawing.Size(268, 46);
            this.TransportPersonesMercaderies.TabIndex = 1;
            this.TransportPersonesMercaderies.Text = "Transport de persones i mercaderies";
            this.TransportPersonesMercaderies.UseVisualStyleBackColor = true;
            this.TransportPersonesMercaderies.Click += new System.EventHandler(this.TransportPersonesMercaderies_Click);
            // 
            // inicisAviacio
            // 
            this.inicisAviacio.Location = new System.Drawing.Point(6, 279);
            this.inicisAviacio.Name = "inicisAviacio";
            this.inicisAviacio.Size = new System.Drawing.Size(268, 46);
            this.inicisAviacio.TabIndex = 6;
            this.inicisAviacio.Text = "Inicis de l\'aviació";
            this.inicisAviacio.UseVisualStyleBackColor = true;
            this.inicisAviacio.Click += new System.EventHandler(this.inicisAviacio_Click);
            // 
            // groupBoxCrear
            // 
            this.groupBoxCrear.Controls.Add(this.TransportPersonesMercaderies);
            this.groupBoxCrear.Controls.Add(this.inicisAviacio);
            this.groupBoxCrear.Controls.Add(this.revolucioUtilitari);
            this.groupBoxCrear.Controls.Add(this.bombers);
            this.groupBoxCrear.Controls.Add(this.microcotxesPrototipsElectrics);
            this.groupBoxCrear.Controls.Add(this.motocicletesCatalanes);
            this.groupBoxCrear.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCrear.Name = "groupBoxCrear";
            this.groupBoxCrear.Size = new System.Drawing.Size(280, 331);
            this.groupBoxCrear.TabIndex = 1;
            this.groupBoxCrear.TabStop = false;
            this.groupBoxCrear.Text = "Crear";
            // 
            // groupBoxAdministracio
            // 
            this.groupBoxAdministracio.Controls.Add(this.buttonEditarColleccions);
            this.groupBoxAdministracio.Controls.Add(this.buttonModificarPreguntes);
            this.groupBoxAdministracio.Controls.Add(this.buttonCrearPregunta);
            this.groupBoxAdministracio.Controls.Add(this.buttonEliminarObjecte);
            this.groupBoxAdministracio.Controls.Add(this.buttonMostrarInfoItemsMuseu);
            this.groupBoxAdministracio.Location = new System.Drawing.Point(298, 12);
            this.groupBoxAdministracio.Name = "groupBoxAdministracio";
            this.groupBoxAdministracio.Size = new System.Drawing.Size(280, 331);
            this.groupBoxAdministracio.TabIndex = 8;
            this.groupBoxAdministracio.TabStop = false;
            this.groupBoxAdministracio.Text = "Administració";
            // 
            // buttonEditarColleccions
            // 
            this.buttonEditarColleccions.Location = new System.Drawing.Point(6, 123);
            this.buttonEditarColleccions.Name = "buttonEditarColleccions";
            this.buttonEditarColleccions.Size = new System.Drawing.Size(268, 46);
            this.buttonEditarColleccions.TabIndex = 12;
            this.buttonEditarColleccions.Text = "Editar col·leccions";
            this.buttonEditarColleccions.UseVisualStyleBackColor = true;
            this.buttonEditarColleccions.Click += new System.EventHandler(this.buttonEditarColleccions_Click);
            // 
            // buttonModificarPreguntes
            // 
            this.buttonModificarPreguntes.Location = new System.Drawing.Point(6, 227);
            this.buttonModificarPreguntes.Name = "buttonModificarPreguntes";
            this.buttonModificarPreguntes.Size = new System.Drawing.Size(268, 46);
            this.buttonModificarPreguntes.TabIndex = 10;
            this.buttonModificarPreguntes.Text = "Modificar/Eliminar Preguntes";
            this.buttonModificarPreguntes.UseVisualStyleBackColor = true;
            // 
            // buttonCrearPregunta
            // 
            this.buttonCrearPregunta.Location = new System.Drawing.Point(6, 175);
            this.buttonCrearPregunta.Name = "buttonCrearPregunta";
            this.buttonCrearPregunta.Size = new System.Drawing.Size(268, 46);
            this.buttonCrearPregunta.TabIndex = 9;
            this.buttonCrearPregunta.Text = "Crear Pregunta";
            this.buttonCrearPregunta.UseVisualStyleBackColor = true;
            this.buttonCrearPregunta.Click += new System.EventHandler(this.buttonCrearPreguna_Click);
            // 
            // buttonEliminarObjecte
            // 
            this.buttonEliminarObjecte.Location = new System.Drawing.Point(6, 71);
            this.buttonEliminarObjecte.Name = "buttonEliminarObjecte";
            this.buttonEliminarObjecte.Size = new System.Drawing.Size(268, 46);
            this.buttonEliminarObjecte.TabIndex = 8;
            this.buttonEliminarObjecte.Text = "Eliminar objecte";
            this.buttonEliminarObjecte.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarInfoItemsMuseu
            // 
            this.buttonMostrarInfoItemsMuseu.Location = new System.Drawing.Point(6, 19);
            this.buttonMostrarInfoItemsMuseu.Name = "buttonMostrarInfoItemsMuseu";
            this.buttonMostrarInfoItemsMuseu.Size = new System.Drawing.Size(268, 46);
            this.buttonMostrarInfoItemsMuseu.TabIndex = 7;
            this.buttonMostrarInfoItemsMuseu.Text = "Modificar informació objectes museu";
            this.buttonMostrarInfoItemsMuseu.UseVisualStyleBackColor = true;
            this.buttonMostrarInfoItemsMuseu.Click += new System.EventHandler(this.buttonMostrarInfoItemsMuseu_Click);
            // 
            // tancar
            // 
            this.tancar.Location = new System.Drawing.Point(12, 349);
            this.tancar.Name = "tancar";
            this.tancar.Size = new System.Drawing.Size(566, 46);
            this.tancar.TabIndex = 7;
            this.tancar.Text = "Tancar";
            this.tancar.UseVisualStyleBackColor = true;
            this.tancar.Click += new System.EventHandler(this.tancar_Click);
            // 
            // museumToolGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 408);
            this.Controls.Add(this.tancar);
            this.Controls.Add(this.groupBoxAdministracio);
            this.Controls.Add(this.groupBoxCrear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(606, 447);
            this.MinimumSize = new System.Drawing.Size(606, 447);
            this.Name = "museumToolGeneral";
            this.Text = "Museum Tool General";
            this.Load += new System.EventHandler(this.museumToolGeneral_Load);
            this.groupBoxCrear.ResumeLayout(false);
            this.groupBoxAdministracio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button revolucioUtilitari;
        private System.Windows.Forms.Button microcotxesPrototipsElectrics;
        private System.Windows.Forms.Button motocicletesCatalanes;
        private System.Windows.Forms.Button bombers;
        private System.Windows.Forms.Button TransportPersonesMercaderies;
        private System.Windows.Forms.Button inicisAviacio;
        private System.Windows.Forms.GroupBox groupBoxCrear;
        private System.Windows.Forms.GroupBox groupBoxAdministracio;
        private System.Windows.Forms.Button tancar;
        private System.Windows.Forms.Button buttonMostrarInfoItemsMuseu;
        private System.Windows.Forms.Button buttonModificarPreguntes;
        private System.Windows.Forms.Button buttonCrearPregunta;
        private System.Windows.Forms.Button buttonEditarColleccions;
        private System.Windows.Forms.Button buttonEliminarObjecte;
    }
}

