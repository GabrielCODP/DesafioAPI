
namespace DesafioFrameworkAPI.Janelas
{
    partial class Postagem
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
            this.btnGerarPostagem = new System.Windows.Forms.Button();
            this.richTextBoxPostagem = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postagem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGerarPostagem
            // 
            this.btnGerarPostagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarPostagem.Location = new System.Drawing.Point(667, 12);
            this.btnGerarPostagem.Name = "btnGerarPostagem";
            this.btnGerarPostagem.Size = new System.Drawing.Size(128, 23);
            this.btnGerarPostagem.TabIndex = 2;
            this.btnGerarPostagem.Text = "Gerar Postagem";
            this.btnGerarPostagem.UseVisualStyleBackColor = true;
            this.btnGerarPostagem.Click += new System.EventHandler(this.btnGerarPostagem_Click);
            // 
            // richTextBoxPostagem
            // 
            this.richTextBoxPostagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxPostagem.Location = new System.Drawing.Point(12, 85);
            this.richTextBoxPostagem.Name = "richTextBoxPostagem";
            this.richTextBoxPostagem.Size = new System.Drawing.Size(776, 327);
            this.richTextBoxPostagem.TabIndex = 3;
            this.richTextBoxPostagem.Text = "";
            this.richTextBoxPostagem.TextChanged += new System.EventHandler(this.richTextBoxPostagem_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(667, 41);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar Postagem";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Postagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(807, 436);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.richTextBoxPostagem);
            this.Controls.Add(this.btnGerarPostagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Postagem";
            this.Text = "Postagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarPostagem;
        private System.Windows.Forms.RichTextBox richTextBoxPostagem;
        private System.Windows.Forms.Button btnLimpar;
    }
}