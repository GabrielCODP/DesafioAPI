using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFrameworkAPI.Classes.Interfaces
{
    interface IAlbums
    {
        [Get("/albums")]
        Task<ICollection<Albuns>> GetAlbumTotal();

        [Get("/albums/{id}")]
        Task<Albuns> GetId(string id);
    }
}
