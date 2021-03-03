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
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
        }

        private void btnGerarAlbum_Click(object sender, EventArgs e)
        {
            EntradaDeDadosAlbum();

            async Task EntradaDeDadosAlbum()
            {
                try
                {
                    var dadosAPI = RestService.For<IAlbums>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetAlbumTotal();

                    foreach (var item in resultado)
                        richTextBoxAlbuns.AppendText($"\n\n_UserId: {item.userId}\n_id:{item.id}\n_Title: {item.title}");
                }
                catch (Exception e)
                {

                    richTextBoxAlbuns.AppendText("Erro ao gerar dados: " + e);
                }

            }

            btnGerarAlbum.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxAlbuns.Clear();
            btnGerarAlbum.Visible = true;
        }

        private void textBoxProcurarID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnProcurarID_Click(object sender, EventArgs e)
        {
            
            EntradaDeDadosAlbum();

            async Task EntradaDeDadosAlbum()
            {
               
                try
                {
                    string texto = txtProcurarID.Text;

                    var dadosAPI = RestService.For<IAlbums>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetId(texto);

                    richTextBoxAlbuns.AppendText($"\n\n_UserId: {resultado.userId}\n_id:{resultado.id}\n_Title: {resultado.title}");

                }
                catch (Exception e)
                {

                    richTextBoxAlbuns.AppendText("Erro ao gerar dados: " + e);
                }

            }

            btnGerarAlbum.Visible = false;
        }
    }
}
