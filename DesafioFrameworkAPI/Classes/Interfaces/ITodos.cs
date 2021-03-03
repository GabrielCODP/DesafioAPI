using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFrameworkAPI.Classes.Interfaces
{
    interface ITodos
    {
        [Get("/todos")]
        Task<ICollection<TodosC>> GetPostagemTotal();

        [Get("/todos/{id}")]
        Task<TodosC> GetId(string id);
    }
}
