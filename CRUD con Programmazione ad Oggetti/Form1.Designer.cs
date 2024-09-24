namespace CRUD_con_Programmazione_ad_Oggetti
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
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_artistName = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_artistName = new System.Windows.Forms.TextBox();
            this.tb_albumName = new System.Windows.Forms.TextBox();
            this.lbl_albumName = new System.Windows.Forms.Label();
            this.list_records = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_serialize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tb_newAlbumName = new System.Windows.Forms.TextBox();
            this.lbl_newAlbumName = new System.Windows.Forms.Label();
            this.tb_newArtistName = new System.Windows.Forms.TextBox();
            this.lbl_newArtistName = new System.Windows.Forms.Label();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 209);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(140, 140);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "AGGIUNGI";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_artistName
            // 
            this.lbl_artistName.AutoSize = true;
            this.lbl_artistName.Location = new System.Drawing.Point(12, 9);
            this.lbl_artistName.Name = "lbl_artistName";
            this.lbl_artistName.Size = new System.Drawing.Size(70, 13);
            this.lbl_artistName.TabIndex = 1;
            this.lbl_artistName.Text = "Nome Artista:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(158, 209);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 140);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "MODIFICA";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(12, 356);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(140, 140);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "LEGGI";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(158, 356);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 140);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "ELIMINA";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_artistName
            // 
            this.tb_artistName.Location = new System.Drawing.Point(12, 25);
            this.tb_artistName.Name = "tb_artistName";
            this.tb_artistName.Size = new System.Drawing.Size(286, 20);
            this.tb_artistName.TabIndex = 5;
            // 
            // tb_albumName
            // 
            this.tb_albumName.Location = new System.Drawing.Point(12, 69);
            this.tb_albumName.Name = "tb_albumName";
            this.tb_albumName.Size = new System.Drawing.Size(286, 20);
            this.tb_albumName.TabIndex = 7;
            // 
            // lbl_albumName
            // 
            this.lbl_albumName.AutoSize = true;
            this.lbl_albumName.Location = new System.Drawing.Point(12, 53);
            this.lbl_albumName.Name = "lbl_albumName";
            this.lbl_albumName.Size = new System.Drawing.Size(70, 13);
            this.lbl_albumName.TabIndex = 6;
            this.lbl_albumName.Text = "Nome Album:";
            // 
            // list_records
            // 
            this.list_records.FormattingEnabled = true;
            this.list_records.Location = new System.Drawing.Point(325, 25);
            this.list_records.Name = "list_records";
            this.list_records.Size = new System.Drawing.Size(371, 472);
            this.list_records.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista Artisti e Album:";
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(719, 25);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(140, 233);
            this.btn_serialize.TabIndex = 10;
            this.btn_serialize.Text = "SALVA";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(719, 263);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(140, 233);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "ESCI";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_newAlbumName
            // 
            this.tb_newAlbumName.Location = new System.Drawing.Point(12, 157);
            this.tb_newAlbumName.Name = "tb_newAlbumName";
            this.tb_newAlbumName.Size = new System.Drawing.Size(286, 20);
            this.tb_newAlbumName.TabIndex = 15;
            // 
            // lbl_newAlbumName
            // 
            this.lbl_newAlbumName.AutoSize = true;
            this.lbl_newAlbumName.Location = new System.Drawing.Point(12, 141);
            this.lbl_newAlbumName.Name = "lbl_newAlbumName";
            this.lbl_newAlbumName.Size = new System.Drawing.Size(105, 13);
            this.lbl_newAlbumName.TabIndex = 14;
            this.lbl_newAlbumName.Text = "Nuovo Nome Album:";
            // 
            // tb_newArtistName
            // 
            this.tb_newArtistName.Location = new System.Drawing.Point(12, 112);
            this.tb_newArtistName.Name = "tb_newArtistName";
            this.tb_newArtistName.Size = new System.Drawing.Size(286, 20);
            this.tb_newArtistName.TabIndex = 13;
            // 
            // lbl_newArtistName
            // 
            this.lbl_newArtistName.AutoSize = true;
            this.lbl_newArtistName.Location = new System.Drawing.Point(12, 97);
            this.lbl_newArtistName.Name = "lbl_newArtistName";
            this.lbl_newArtistName.Size = new System.Drawing.Size(105, 13);
            this.lbl_newArtistName.TabIndex = 12;
            this.lbl_newArtistName.Text = "Nuovo Nome Artista:";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(12, 503);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(845, 56);
            this.btn_openFile.TabIndex = 16;
            this.btn_openFile.Text = "APRI FILE";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 595);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.tb_newAlbumName);
            this.Controls.Add(this.lbl_newAlbumName);
            this.Controls.Add(this.tb_newArtistName);
            this.Controls.Add(this.lbl_newArtistName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_serialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_records);
            this.Controls.Add(this.tb_albumName);
            this.Controls.Add(this.lbl_albumName);
            this.Controls.Add(this.tb_artistName);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_artistName);
            this.Controls.Add(this.btn_create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_artistName;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_artistName;
        private System.Windows.Forms.TextBox tb_albumName;
        private System.Windows.Forms.Label lbl_albumName;
        private System.Windows.Forms.ListBox list_records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_serialize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tb_newAlbumName;
        private System.Windows.Forms.Label lbl_newAlbumName;
        private System.Windows.Forms.TextBox tb_newArtistName;
        private System.Windows.Forms.Label lbl_newArtistName;
        private System.Windows.Forms.Button btn_openFile;
    }
}

