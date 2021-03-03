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
    public partial class TabelaDados : Form
    {
        public TabelaDados()
        {
            InitializeComponent();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            EntradaDeDadosPostagem();

            async Task EntradaDeDadosPostagem()
            {
                try
                {
                    List<Postagens> postagensDados = new List<Postagens>();
                    var dadosAPI = RestService.For<IPostagens>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetPostagemTotal();

                    foreach (var item in resultado)
                        postagensDados.Add(new Postagens(item.userId, item.id, item.title, item.body));

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

        private void btnAlbuns_Click(object sender, EventArgs e)
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
                catch (Exception e )
                {
                    dataGridViewTabelas.DataSource = $"Erro ao gerar dados {e}";
                }
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            EntradaDeDadosTodos();

            async Task EntradaDeDadosTodos()
            {
                try
                {
                    List<TodosC> todosDados = new List<TodosC>();
                    var dadosAPI = RestService.For<ITodos>(UrlControle.BaseUrl);
                    var resultado = await dadosAPI.GetPostagemTotal();

                    foreach (var item in resultado)
                        todosDados.Add(new TodosC(item.userId, item.id, item.title, item.completed));

                    dataGridViewTabelas.DataSource = resultado;
                }
                catch (Exception e)
                {
                    dataGridViewTabelas.DataSource = $"Erro ao gerar dados {e}"; 
                }
            }
        }
    }
}
