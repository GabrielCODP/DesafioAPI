﻿
namespace DesafioFrameworkAPI.Janelas
{
    partial class TabelaDeAlbum
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTabelas = new System.Windows.Forms.DataGridView();
            this.btnTabelaAlbum = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tabela De Álbum";
            // 
            // dataGridViewTabelas
            // 
            this.dataGridViewTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelas.Location = new System.Drawing.Point(13, 62);
            this.dataGridViewTabelas.Name = "dataGridViewTabelas";
            this.dataGridViewTabelas.RowTemplate.Height = 25;
            this.dataGridViewTabelas.Size = new System.Drawing.Size(775, 326);
            this.dataGridViewTabelas.TabIndex = 15;
            // 
            // btnTabelaAlbum
            // 
            this.btnTabelaAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTabelaAlbum.Location = new System.Drawing.Point(13, 403);
            this.btnTabelaAlbum.Name = "btnTabelaAlbum";
            this.btnTabelaAlbum.Size = new System.Drawing.Size(179, 23);
            this.btnTabelaAlbum.TabIndex = 16;
            this.btnTabelaAlbum.Text = "Gerar Tabela";
            this.btnTabelaAlbum.UseVisualStyleBackColor = true;
            this.btnTabelaAlbum.Click += new System.EventHandler(this.btnTabelaAlbum_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(198, 403);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar Tabela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // TabelaDeAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(44)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTabelaAlbum);
            this.Controls.Add(this.dataGridViewTabelas);
            this.Controls.Add(this.label1);
            this.Name = "TabelaDeAlbum";
            this.Text = "TabelaDeAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTabelas;
        private System.Windows.Forms.Button btnTabelaAlbum;
        private System.Windows.Forms.Button btnLimpar;
    }
}