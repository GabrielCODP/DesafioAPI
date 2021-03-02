
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
            this.richTextBoxAlbuns = new System.Windows.Forms.RichTextBox();
            this.btnGerarAlbum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxAlbuns
            // 
            this.richTextBoxAlbuns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAlbuns.Location = new System.Drawing.Point(12, 93);
            this.richTextBoxAlbuns.Name = "richTextBoxAlbuns";
            this.richTextBoxAlbuns.Size = new System.Drawing.Size(776, 327);
            this.richTextBoxAlbuns.TabIndex = 0;
            this.richTextBoxAlbuns.Text = "";
            this.richTextBoxAlbuns.TextChanged += new System.EventHandler(this.richTextBoxAlbuns_TextChanged);
            // 
            // btnGerarAlbum
            // 
            this.btnGerarAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarAlbum.Location = new System.Drawing.Point(660, 23);
            this.btnGerarAlbum.Name = "btnGerarAlbum";
            this.btnGerarAlbum.Size = new System.Drawing.Size(128, 23);
            this.btnGerarAlbum.TabIndex = 3;
            this.btnGerarAlbum.Text = "Gerar Album";
            this.btnGerarAlbum.UseVisualStyleBackColor = true;
            this.btnGerarAlbum.Click += new System.EventHandler(this.btnGerarAlbum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Album";
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarAlbum);
            this.Controls.Add(this.richTextBoxAlbuns);
            this.Name = "Album";
            this.Text = "Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAlbuns;
        private System.Windows.Forms.Button btnGerarAlbum;
        private System.Windows.Forms.Label label1;
    }
}