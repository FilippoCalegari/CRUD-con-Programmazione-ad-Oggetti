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
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(18, 322);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(210, 215);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "AGGIUNGI";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_artistName
            // 
            this.lbl_artistName.AutoSize = true;
            this.lbl_artistName.Location = new System.Drawing.Point(18, 14);
            this.lbl_artistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_artistName.Name = "lbl_artistName";
            this.lbl_artistName.Size = new System.Drawing.Size(105, 20);
            this.lbl_artistName.TabIndex = 1;
            this.lbl_artistName.Text = "Nome Artista:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(237, 322);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(210, 215);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "MODIFICA";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(18, 547);
            this.btn_read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(210, 215);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "LEGGI";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(237, 547);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(210, 215);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "ELIMINA";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_artistName
            // 
            this.tb_artistName.Location = new System.Drawing.Point(18, 38);
            this.tb_artistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_artistName.Name = "tb_artistName";
            this.tb_artistName.Size = new System.Drawing.Size(427, 26);
            this.tb_artistName.TabIndex = 5;
            // 
            // tb_albumName
            // 
            this.tb_albumName.Location = new System.Drawing.Point(18, 106);
            this.tb_albumName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_albumName.Name = "tb_albumName";
            this.tb_albumName.Size = new System.Drawing.Size(427, 26);
            this.tb_albumName.TabIndex = 7;
            // 
            // lbl_albumName
            // 
            this.lbl_albumName.AutoSize = true;
            this.lbl_albumName.Location = new System.Drawing.Point(18, 82);
            this.lbl_albumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_albumName.Name = "lbl_albumName";
            this.lbl_albumName.Size = new System.Drawing.Size(104, 20);
            this.lbl_albumName.TabIndex = 6;
            this.lbl_albumName.Text = "Nome Album:";
            // 
            // list_records
            // 
            this.list_records.FormattingEnabled = true;
            this.list_records.ItemHeight = 20;
            this.list_records.Location = new System.Drawing.Point(488, 38);
            this.list_records.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_records.Name = "list_records";
            this.list_records.Size = new System.Drawing.Size(554, 724);
            this.list_records.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista Artisti e Album:";
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(1078, 38);
            this.btn_serialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(210, 358);
            this.btn_serialize.TabIndex = 10;
            this.btn_serialize.Text = "SALVA";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1078, 404);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(210, 358);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "ESCI";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_newAlbumName
            // 
            this.tb_newAlbumName.Location = new System.Drawing.Point(18, 241);
            this.tb_newAlbumName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_newAlbumName.Name = "tb_newAlbumName";
            this.tb_newAlbumName.Size = new System.Drawing.Size(427, 26);
            this.tb_newAlbumName.TabIndex = 15;
            // 
            // lbl_newAlbumName
            // 
            this.lbl_newAlbumName.AutoSize = true;
            this.lbl_newAlbumName.Location = new System.Drawing.Point(18, 217);
            this.lbl_newAlbumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newAlbumName.Name = "lbl_newAlbumName";
            this.lbl_newAlbumName.Size = new System.Drawing.Size(153, 20);
            this.lbl_newAlbumName.TabIndex = 14;
            this.lbl_newAlbumName.Text = "Nuovo Nome Album:";
            // 
            // tb_newArtistName
            // 
            this.tb_newArtistName.Location = new System.Drawing.Point(18, 173);
            this.tb_newArtistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_newArtistName.Name = "tb_newArtistName";
            this.tb_newArtistName.Size = new System.Drawing.Size(427, 26);
            this.tb_newArtistName.TabIndex = 13;
            // 
            // lbl_newArtistName
            // 
            this.lbl_newArtistName.AutoSize = true;
            this.lbl_newArtistName.Location = new System.Drawing.Point(18, 149);
            this.lbl_newArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newArtistName.Name = "lbl_newArtistName";
            this.lbl_newArtistName.Size = new System.Drawing.Size(154, 20);
            this.lbl_newArtistName.TabIndex = 12;
            this.lbl_newArtistName.Text = "Nuovo Nome Artista:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 878);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

