
namespace DesafioFrameworkAPI.Janelas
{
    partial class TabelaDados
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
            this.dataGridViewTabelas = new System.Windows.Forms.DataGridView();
            this.btnTabelaPostagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlbuns = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabelas
            // 
            this.dataGridViewTabelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabelas.Location = new System.Drawing.Point(2, 58);
            this.dataGridViewTabelas.Name = "dataGridViewTabelas";
            this.dataGridViewTabelas.RowTemplate.Height = 25;
            this.dataGridViewTabelas.Size = new System.Drawing.Size(775, 327);
            this.dataGridViewTabelas.TabIndex = 0;
            // 
            // btnTabelaPostagem
            // 
            this.btnTabelaPostagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTabelaPostagem.Location = new System.Drawing.Point(2, 398);
            this.btnTabelaPostagem.Name = "btnTabelaPostagem";
            this.btnTabelaPostagem.Size = new System.Drawing.Size(179, 23);
            this.btnTabelaPostagem.TabIndex = 11;
            this.btnTabelaPostagem.Text = "Gerar Tabela de Postagem";
            this.btnTabelaPostagem.UseVisualStyleBackColor = true;
            this.btnTabelaPostagem.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tabelas De Dados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(557, 398);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar Tabela";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlbuns
            // 
            this.btnAlbuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlbuns.Location = new System.Drawing.Point(187, 398);
            this.btnAlbuns.Name = "btnAlbuns";
            this.btnAlbuns.Size = new System.Drawing.Size(179, 23);
            this.btnAlbuns.TabIndex = 14;
            this.btnAlbuns.Text = "Gerar Tabela de Albuns";
            this.btnAlbuns.UseVisualStyleBackColor = true;
            this.btnAlbuns.Click += new System.EventHandler(this.btnAlbuns_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTodos.Location = new System.Drawing.Point(372, 398);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(179, 23);
            this.btnTodos.TabIndex = 15;
            this.btnTodos.Text = "Gerar Tabela de Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // TabelaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(44)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnAlbuns);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTabelaPostagem);
            this.Controls.Add(this.dataGridViewTabelas);
            this.Name = "TabelaDados";
            this.Text = "TabelaDados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabelas;
        private System.Windows.Forms.Button btnTabelaPostagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlbuns;
        private System.Windows.Forms.Button btnTodos;
    }
}