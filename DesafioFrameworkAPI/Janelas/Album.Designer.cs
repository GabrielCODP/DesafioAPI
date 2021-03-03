
namespace DesafioFrameworkAPI.Janelas
{
    partial class Album
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
            this.btnGerarAlbum = new System.Windows.Forms.Button();
            this.richTextBoxAlbuns = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtProcurarID = new System.Windows.Forms.TextBox();
            this.btnProcurarID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Album";
            // 
            // btnGerarAlbum
            // 
            this.btnGerarAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarAlbum.Location = new System.Drawing.Point(11, 378);
            this.btnGerarAlbum.Name = "btnGerarAlbum";
            this.btnGerarAlbum.Size = new System.Drawing.Size(128, 23);
            this.btnGerarAlbum.TabIndex = 9;
            this.btnGerarAlbum.Text = "Gerar Album";
            this.btnGerarAlbum.UseVisualStyleBackColor = true;
            this.btnGerarAlbum.Click += new System.EventHandler(this.btnGerarAlbum_Click);
            // 
            // richTextBoxAlbuns
            // 
            this.richTextBoxAlbuns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAlbuns.Location = new System.Drawing.Point(12, 50);
            this.richTextBoxAlbuns.Name = "richTextBoxAlbuns";
            this.richTextBoxAlbuns.Size = new System.Drawing.Size(750, 322);
            this.richTextBoxAlbuns.TabIndex = 10;
            this.richTextBoxAlbuns.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(145, 378);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar Album";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtProcurarID
            // 
            this.txtProcurarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurarID.Location = new System.Drawing.Point(630, 378);
            this.txtProcurarID.Name = "txtProcurarID";
            this.txtProcurarID.Size = new System.Drawing.Size(132, 23);
            this.txtProcurarID.TabIndex = 12;
            this.txtProcurarID.TextChanged += new System.EventHandler(this.textBoxProcurarID_TextChanged);
            // 
            // btnProcurarID
            // 
            this.btnProcurarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarID.Location = new System.Drawing.Point(630, 407);
            this.btnProcurarID.Name = "btnProcurarID";
            this.btnProcurarID.Size = new System.Drawing.Size(128, 23);
            this.btnProcurarID.TabIndex = 13;
            this.btnProcurarID.Text = "Procurar ID";
            this.btnProcurarID.UseVisualStyleBackColor = true;
            this.btnProcurarID.Click += new System.EventHandler(this.btnProcurarID_Click);
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(44)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.btnProcurarID);
            this.Controls.Add(this.txtProcurarID);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.richTextBoxAlbuns);
            this.Controls.Add(this.btnGerarAlbum);
            this.Controls.Add(this.label1);
            this.Name = "Album";
            this.Text = "Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarAlbum;
        private System.Windows.Forms.RichTextBox richTextBoxAlbuns;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtProcurarID;
        private System.Windows.Forms.Button btnProcurarID;
    }
}