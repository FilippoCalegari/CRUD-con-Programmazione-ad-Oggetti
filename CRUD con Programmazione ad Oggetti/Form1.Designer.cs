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
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 95);
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
            this.btn_update.Location = new System.Drawing.Point(158, 95);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 140);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "MODIFICA";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(12, 241);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(140, 140);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "LEGGI";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(158, 241);
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
            this.list_records.Location = new System.Drawing.Point(325, 26);
            this.list_records.Name = "list_records";
            this.list_records.Size = new System.Drawing.Size(371, 355);
            this.list_records.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista Artisti e Album:";
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(719, 25);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(140, 170);
            this.btn_serialize.TabIndex = 10;
            this.btn_serialize.Text = "SALVA";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(719, 211);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(140, 170);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "ESCI";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
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
    }
}

