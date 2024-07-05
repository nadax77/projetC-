using System;

namespace examan
{
    partial class joueur
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
            this.nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_nom = new System.Windows.Forms.TextBox();
            this.Txt_age = new System.Windows.Forms.TextBox();
            this.Txt_position = new System.Windows.Forms.TextBox();
            this.Txt_prime = new System.Windows.Forms.TextBox();
            this.cmb_experience = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_afficher = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(63, 35);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(33, 16);
            this.nom.TabIndex = 0;
            this.nom.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "experience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "prime";
            // 
            // Txt_nom
            // 
            this.Txt_nom.Location = new System.Drawing.Point(148, 28);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(100, 22);
            this.Txt_nom.TabIndex = 7;
            // 
            // Txt_age
            // 
            this.Txt_age.Location = new System.Drawing.Point(148, 67);
            this.Txt_age.Name = "Txt_age";
            this.Txt_age.Size = new System.Drawing.Size(100, 22);
            this.Txt_age.TabIndex = 8;
            // 
            // Txt_position
            // 
            this.Txt_position.Location = new System.Drawing.Point(148, 105);
            this.Txt_position.Name = "Txt_position";
            this.Txt_position.Size = new System.Drawing.Size(100, 22);
            this.Txt_position.TabIndex = 9;
            // 
            // Txt_prime
            // 
            this.Txt_prime.Location = new System.Drawing.Point(148, 189);
            this.Txt_prime.Name = "Txt_prime";
            this.Txt_prime.Size = new System.Drawing.Size(100, 22);
            this.Txt_prime.TabIndex = 10;
            this.Txt_prime.TextChanged += new System.EventHandler(this.Txt_prime_TextChanged);
            // 
            // cmb_experience
            // 
            this.cmb_experience.FormattingEnabled = true;
            this.cmb_experience.Location = new System.Drawing.Point(148, 144);
            this.cmb_experience.Name = "cmb_experience";
            this.cmb_experience.Size = new System.Drawing.Size(100, 24);
            this.cmb_experience.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(388, 34);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(75, 23);
            this.bt_ajouter.TabIndex = 15;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_afficher
            // 
            this.bt_afficher.Location = new System.Drawing.Point(388, 74);
            this.bt_afficher.Name = "bt_afficher";
            this.bt_afficher.Size = new System.Drawing.Size(75, 23);
            this.bt_afficher.TabIndex = 16;
            this.bt_afficher.Text = "afficher";
            this.bt_afficher.UseVisualStyleBackColor = true;
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(388, 117);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(75, 23);
            this.bt_supprimer.TabIndex = 17;
            this.bt_supprimer.Text = "supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(388, 160);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(75, 23);
            this.bt_quitter.TabIndex = 18;
            this.bt_quitter.Text = "quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_afficher);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_experience);
            this.Controls.Add(this.Txt_prime);
            this.Controls.Add(this.Txt_position);
            this.Controls.Add(this.Txt_age);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Name = "joueur";
            this.Text = "joueur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Txt_prime_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_nom;
        private System.Windows.Forms.TextBox Txt_age;
        private System.Windows.Forms.TextBox Txt_position;
        private System.Windows.Forms.TextBox Txt_prime;
        private System.Windows.Forms.ComboBox cmb_experience;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_afficher;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_quitter;
    }
}