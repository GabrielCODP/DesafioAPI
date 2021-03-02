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
                var dadosAPI = RestService.For<IAlbums>(UrlControle.BaseUrl);
                var resultado = await dadosAPI.GetAlbumTotal();

                foreach (var item in resultado)
                {
                    richTextBoxAlbuns.AppendText($"\n\n_UserId: {item.userId}\n_id:{item.id}\n_Title: {item.title}");
                }

            }

            btnGerarAlbum.Visible = false;
        }

        private void richTextBoxAlbuns_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBoxAlbuns.Clear();
            btnGerarAlbum.Visible = true;
        }
    }
}
