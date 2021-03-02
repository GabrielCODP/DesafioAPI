using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFrameworkAPI.Classes.Interfaces
{
    interface IPostagens
    {
        [Get("/posts")]
        Task<ICollection<Postagem>> GetPostagemTotal();

        [Get("/posts/{id}")]
        Task<Postagem> GetId(int id);
    }
}
