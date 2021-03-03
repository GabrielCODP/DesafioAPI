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
    public partial class TabelaDeTodos : Form
    {
        public TabelaDeTodos()
        {
            InitializeComponent();
        }

        private void btnTabelaTodos_Click(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewTabelas.DataSource = null;
        }
    }
}
