using DesafioFrameworkAPI.Classes;
using DesafioFrameworkAPI.Classes.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFrameworkAPI.Janelas
{
    public partial class Postagem : Form
    {
        public Postagem()
        {
            InitializeComponent();
        }

        private void btnGerarPostagem_Click(object sender, EventArgs e)
        {
            EntradaDeDadosPostagem();

            async Task EntradaDeDadosPostagem()
            {
                var dadosAPI = RestService.For<IPostagens>(UrlControle.BaseUrl);
                var resultado = await dadosAPI.GetPostagemTotal();

                foreach (var item in resultado)
                {
                    richTextBoxPostagem.AppendText($"\n\n_UserId: {item.userId}\n_id:{item.id}\n_Title: {item.title}\n_Body:{item.body}");
                }

            }

            btnGerarPostagem.Visible = false;
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxPostagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxPostagem.Clear();
            btnGerarPostagem.Visible = true;
        }
    }
}
