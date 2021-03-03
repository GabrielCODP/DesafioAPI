
namespace DesafioFrameworkAPI.Janelas
{
    partial class Todos
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
            this.richTextBoxTodos = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProcurarID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxTodos
            // 
            this.richTextBoxTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTodos.Location = new System.Drawing.Point(12, 61);
            this.richTextBoxTodos.Name = "richTextBoxTodos";
            this.richTextBoxTodos.Size = new System.Drawing.Size(741, 304);
            this.richTextBoxTodos.TabIndex = 4;
            this.richTextBoxTodos.Text = "";
            this.richTextBoxTodos.TextChanged += new System.EventHandler(this.richTextBoxTodos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todos";
            // 
            // btnGerarTodos
            // 
            this.btnGerarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarTodos.Location = new System.Drawing.Point(12, 371);
            this.btnGerarTodos.Name = "btnGerarTodos";
            this.btnGerarTodos.Size = new System.Drawing.Size(128, 23);
            this.btnGerarTodos.TabIndex = 7;
            this.btnGerarTodos.Text = "Gerar Todos";
            this.btnGerarTodos.UseVisualStyleBackColor = true;
            this.btnGerarTodos.Click += new System.EventHandler(this.btnGerarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Location = new System.Drawing.Point(158, 371);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Todos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(621, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Procurar ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProcurarID
            // 
            this.txtProcurarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcurarID.Location = new System.Drawing.Point(621, 371);
            this.txtProcurarID.Name = "txtProcurarID";
            this.txtProcurarID.Size = new System.Drawing.Size(132, 23);
            this.txtProcurarID.TabIndex = 14;
            // 
            // Todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(44)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.txtProcurarID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerarTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTodos);
            this.Name = "Todos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Todos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProcurarID;
    }
}