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
    public partial class TabelaDePostagem : Form
    {
        public TabelaDePostagem()
        {
            InitializeComponent();
        }

        private void btnTabelaPostagem_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
