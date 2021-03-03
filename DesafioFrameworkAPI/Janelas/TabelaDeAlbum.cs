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
    public partial class TabelaDeAlbum : Form
    {
        public TabelaDeAlbum()
        {
            InitializeComponent();
        }

        private void btnTabelaAlbum_Click(object sender, EventArgs e)
        {
            EntradaDeDadosAlbum();

            async Task EntradaDeDadosAlbum()
            {
                try
                {
                    List<Albuns> albunsDados = new List<Albuns>();
                    var dadosAPI = RestService.For<IAlbums>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetAlbumTotal();

                    foreach (var item in resultado)
                        albunsDados.Add(new Albuns(item.userId, item.id, item.title));

                    dataGridViewTabelas.DataSource = resultado;
                }
                catch (Exception e)
                {
                    dataGridViewTabelas.DataSource = $"Erro ao gerar dados {e}";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewTabelas.DataSource = null;
        }
    }
}
