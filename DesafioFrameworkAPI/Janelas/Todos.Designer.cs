
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
            this.SuspendLayout();
            // 
            // richTextBoxTodos
            // 
            this.richTextBoxTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTodos.Location = new System.Drawing.Point(31, 102);
            this.richTextBoxTodos.Name = "richTextBoxTodos";
            this.richTextBoxTodos.Size = new System.Drawing.Size(719, 305);
            this.richTextBoxTodos.TabIndex = 4;
            this.richTextBoxTodos.Text = "";
            this.richTextBoxTodos.TextChanged += new System.EventHandler(this.richTextBoxTodos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todos";
            // 
            // btnGerarTodos
            // 
            this.btnGerarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarTodos.Location = new System.Drawing.Point(654, 12);
            this.btnGerarTodos.Name = "btnGerarTodos";
            this.btnGerarTodos.Size = new System.Drawing.Size(128, 23);
            this.btnGerarTodos.TabIndex = 7;
            this.btnGerarTodos.Text = "Gerar Todos";
            this.btnGerarTodos.UseVisualStyleBackColor = true;
            this.btnGerarTodos.Click += new System.EventHandler(this.btnGerarTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(654, 41);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Todos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(794, 450);
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
    }
}