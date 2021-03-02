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
        Task<ICollection<Album>> GetAlbumTotal();

        [Get("/albums/{id}")]
        Task<Album> GetId(int id);
    }
}
