namespace ArtistsChart
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_countryFilter = new System.Windows.Forms.Button();
            this.btn_genreFilter = new System.Windows.Forms.Button();
            this.btn_listenersSort = new System.Windows.Forms.Button();
            this.btn_alphabeticSort = new System.Windows.Forms.Button();
            this.btn_compareArtists = new System.Windows.Forms.Button();
            this.btn_higher = new System.Windows.Forms.Button();
            this.btn_lower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(424, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 349);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_countryFilter
            // 
            this.btn_countryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_countryFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_countryFilter.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_countryFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_countryFilter.Location = new System.Drawing.Point(12, 12);
            this.btn_countryFilter.Name = "btn_countryFilter";
            this.btn_countryFilter.Size = new System.Drawing.Size(406, 65);
            this.btn_countryFilter.TabIndex = 1;
            this.btn_countryFilter.Text = "Filtra per paese di provenienza";
            this.btn_countryFilter.UseVisualStyleBackColor = false;
            // 
            // btn_genreFilter
            // 
            this.btn_genreFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_genreFilter.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_genreFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_genreFilter.Location = new System.Drawing.Point(12, 83);
            this.btn_genreFilter.Name = "btn_genreFilter";
            this.btn_genreFilter.Size = new System.Drawing.Size(406, 65);
            this.btn_genreFilter.TabIndex = 2;
            this.btn_genreFilter.Text = "Filtra per genere di appartenenza";
            this.btn_genreFilter.UseVisualStyleBackColor = false;
            // 
            // btn_listenersSort
            // 
            this.btn_listenersSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_listenersSort.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_listenersSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_listenersSort.Location = new System.Drawing.Point(12, 154);
            this.btn_listenersSort.Name = "btn_listenersSort";
            this.btn_listenersSort.Size = new System.Drawing.Size(270, 65);
            this.btn_listenersSort.TabIndex = 3;
            this.btn_listenersSort.Text = "Ordina per numero di ascoltatori";
            this.btn_listenersSort.UseVisualStyleBackColor = false;
            // 
            // btn_alphabeticSort
            // 
            this.btn_alphabeticSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_alphabeticSort.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_alphabeticSort.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_alphabeticSort.Location = new System.Drawing.Point(12, 225);
            this.btn_alphabeticSort.Name = "btn_alphabeticSort";
            this.btn_alphabeticSort.Size = new System.Drawing.Size(406, 65);
            this.btn_alphabeticSort.TabIndex = 4;
            this.btn_alphabeticSort.Text = "Ordina alfabeticamente";
            this.btn_alphabeticSort.UseVisualStyleBackColor = false;
            // 
            // btn_compareArtists
            // 
            this.btn_compareArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_compareArtists.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_compareArtists.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_compareArtists.Location = new System.Drawing.Point(12, 296);
            this.btn_compareArtists.Name = "btn_compareArtists";
            this.btn_compareArtists.Size = new System.Drawing.Size(406, 65);
            this.btn_compareArtists.TabIndex = 5;
            this.btn_compareArtists.Text = "Effettua una comparazione tra due artisti";
            this.btn_compareArtists.UseVisualStyleBackColor = false;
            // 
            // btn_higher
            // 
            this.btn_higher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_higher.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_higher.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_higher.Location = new System.Drawing.Point(288, 154);
            this.btn_higher.Name = "btn_higher";
            this.btn_higher.Size = new System.Drawing.Size(130, 31);
            this.btn_higher.TabIndex = 6;
            this.btn_higher.Text = "Crescente";
            this.btn_higher.UseVisualStyleBackColor = false;
            // 
            // btn_lower
            // 
            this.btn_lower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btn_lower.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_lower.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_lower.Location = new System.Drawing.Point(288, 188);
            this.btn_lower.Name = "btn_lower";
            this.btn_lower.Size = new System.Drawing.Size(130, 31);
            this.btn_lower.TabIndex = 7;
            this.btn_lower.Text = "Decrescente";
            this.btn_lower.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1101, 606);
            this.Controls.Add(this.btn_lower);
            this.Controls.Add(this.btn_higher);
            this.Controls.Add(this.btn_compareArtists);
            this.Controls.Add(this.btn_alphabeticSort);
            this.Controls.Add(this.btn_listenersSort);
            this.Controls.Add(this.btn_genreFilter);
            this.Controls.Add(this.btn_countryFilter);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_genreFilter;
        private System.Windows.Forms.Button btn_listenersSort;
        private System.Windows.Forms.Button btn_alphabeticSort;
        private System.Windows.Forms.Button btn_compareArtists;
        private System.Windows.Forms.Button btn_higher;
        private System.Windows.Forms.Button btn_lower;
        private System.Windows.Forms.Button btn_countryFilter;
    }
}

