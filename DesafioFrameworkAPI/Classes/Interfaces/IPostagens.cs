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
        Task<ICollection<Postagens>> GetPostagemTotal();

        [Get("/posts/{id}")]
        Task<Postagens> GetId(string id);
    }
}
