
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
            this.richTextBoxPostagem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarPostagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProcurarId = new System.Windows.Forms.Button();
            this.txtProcurarID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxPostagem
            // 
            this.richTextBoxPostagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxPostagem.Location = new System.Drawing.Point(12, 63);
            this.richTextBoxPostagem.Name = "richTextBoxPostagem";
            this.richTextBoxPostagem.Size = new System.Drawing.Size(723, 302);
            this.richTextBoxPostagem.TabIndex = 5;
            this.richTextBoxPostagem.Text = "";
            this.richTextBoxPostagem.TextChanged += new System.EventHandler(this.richTextBoxPostagem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Postagem";
            // 
            // btnGerarPostagem
            // 
            this.btnGerarPostagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarPostagem.Location = new System.Drawing.Point(12, 371);
            this.btnGerarPostagem.Name = "btnGerarPostagem";
            this.btnGerarPostagem.Size = new System.Drawing.Size(128, 23);
            this.btnGerarPostagem.TabIndex = 8;
            this.btnGerarPostagem.Text = "Gerar Postagem";
            this.btnGerarPostagem.UseVisualStyleBackColor = true;
            this.btnGerarPostagem.Click += new System.EventHandler(this.btnGerarPostagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(146, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar Postagem";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnProcurarId
            // 
            this.btnProcurarId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarId.Location = new System.Drawing.Point(603, 400);
            this.btnProcurarId.Name = "btnProcurarId";
            this.btnProcurarId.Size = new System.Drawing.Size(128, 23);
            this.btnProcurarId.TabIndex = 10;
            this.btnProcurarId.Text = "Procurar ID";
            this.btnProcurarId.UseVisualStyleBackColor = true;
            this.btnProcurarId.Click += new System.EventHandler(this.btnProcurarId_Click);
            // 
            // txtProcurarID
            // 
            this.txtProcurarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurarID.Location = new System.Drawing.Point(603, 371);
            this.txtProcurarID.Name = "txtProcurarID";
            this.txtProcurarID.Size = new System.Drawing.Size(132, 23);
            this.txtProcurarID.TabIndex = 13;
            this.txtProcurarID.TextChanged += new System.EventHandler(this.txtProcurarID_TextChanged);
            // 
            // Postagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(44)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(747, 451);
            this.Controls.Add(this.txtProcurarID);
            this.Controls.Add(this.btnProcurarId);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerarPostagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxPostagem);
            this.Name = "Postagem";
            this.Text = "Postagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPostagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarPostagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProcurarId;
        private System.Windows.Forms.TextBox txtProcurarID;
    }
}