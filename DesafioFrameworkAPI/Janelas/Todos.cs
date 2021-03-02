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
    public partial class Todos : Form
    {
        public Todos()
        {
            InitializeComponent();
        }

        private void richTextBoxTodos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarTodos_Click(object sender, EventArgs e)
        {
            EntradaDeDadosTodos();

            async Task EntradaDeDadosTodos()
            {
                var dadosAPI = RestService.For<ITodos>(UrlControle.BaseUrl);
                var resultado = await dadosAPI.GetPostagemTotal();

                foreach (var item in resultado)
                {
                    richTextBoxTodos.AppendText($"\n\n_UserId: {item.userId}\n_id:{item.id}\n_Title: {item.title}\n_Completed: {item.completed}");
                }

            }
        }
    }
}
