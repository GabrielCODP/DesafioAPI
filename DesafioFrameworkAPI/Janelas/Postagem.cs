using DesafioFrameworkAPI.Classes;
using DesafioFrameworkAPI.Classes.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
                try
                {
                    var dadosAPI = RestService.For<IPostagens>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetPostagemTotal();

                    foreach (var item in resultado)
                        richTextBoxPostagem.AppendText($"\n\n_UserId: {item.userId}\n_id:{item.id}\n_Title: {item.title}\n_Body:{item.body}");
                }
                catch (Exception e)
                {
                    richTextBoxPostagem.AppendText("Erro ao gerar dados: " + e);
                }
            }

            btnGerarPostagem.Visible = false;

        }



        private void richTextBoxPostagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            richTextBoxPostagem.Clear();
            btnGerarPostagem.Visible = true;
        }

        private void txtProcurarID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurarId_Click(object sender, EventArgs e)
        {
            EntradaDeDadosPostagem();

            async Task EntradaDeDadosPostagem()
            {
                try
                {
                    string texto = txtProcurarID.Text;
                    var dadosAPI = RestService.For<IPostagens>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetId(texto);

                    richTextBoxPostagem.AppendText($"\n\n_UserId: {resultado.userId}\n_id:{resultado.id}\n_Title: {resultado.title}\n_Body:{resultado.body}");
                }
                catch (Exception e)
                {
                    richTextBoxPostagem.AppendText("Erro ao gerar dados: " + e);
                }
            }

            btnGerarPostagem.Visible = false;
        }
    }
}
