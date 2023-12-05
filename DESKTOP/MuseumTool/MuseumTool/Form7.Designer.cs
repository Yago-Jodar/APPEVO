namespace MuseumTool
{
    partial class editorColleccions
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
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonDesar = new System.Windows.Forms.Button();
            this.textBoxColleccio = new System.Windows.Forms.TextBox();
            this.listBoxColleccions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Location = new System.Drawing.Point(12, 244);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(180, 45);
            this.buttonAfegir.TabIndex = 12;
            this.buttonAfegir.Text = "Afeigr";
            this.buttonAfegir.UseVisualStyleBackColor = true;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(198, 244);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(180, 45);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonDesar
            // 
            this.buttonDesar.Location = new System.Drawing.Point(12, 295);
            this.buttonDesar.Name = "buttonDesar";
            this.buttonDesar.Size = new System.Drawing.Size(366, 45);
            this.buttonDesar.TabIndex = 15;
            this.buttonDesar.Text = "Desar";
            this.buttonDesar.UseVisualStyleBackColor = true;
            this.buttonDesar.Click += new System.EventHandler(this.buttonDesar_Click);
            // 
            // textBoxColleccio
            // 
            this.textBoxColleccio.Location = new System.Drawing.Point(12, 13);
            this.textBoxColleccio.Name = "textBoxColleccio";
            this.textBoxColleccio.Size = new System.Drawing.Size(366, 20);
            this.textBoxColleccio.TabIndex = 16;
            // 
            // listBoxColleccions
            // 
            this.listBoxColleccions.FormattingEnabled = true;
            this.listBoxColleccions.Location = new System.Drawing.Point(12, 39);
            this.listBoxColleccions.Name = "listBoxColleccions";
            this.listBoxColleccions.Size = new System.Drawing.Size(366, 199);
            this.listBoxColleccions.TabIndex = 17;
            // 
            // editorColleccions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 351);
            this.Controls.Add(this.listBoxColleccions);
            this.Controls.Add(this.textBoxColleccio);
            this.Controls.Add(this.buttonDesar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAfegir);
            this.Name = "editorColleccions";
            this.Text = "Editor de col·elccions";
            this.Load += new System.EventHandler(this.editorColleccions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonDesar;
        private System.Windows.Forms.TextBox textBoxColleccio;
        private System.Windows.Forms.ListBox listBoxColleccions;
    }
}