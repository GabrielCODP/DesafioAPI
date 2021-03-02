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
        Task<ICollection<Todos>> GetPostagemTotal();

        [Get("/todos/{id}")]
        Task<Todos> GetId(int id);
    }
}
