using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioFrameworkAPI.Classes
{
    class Albuns
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }

        public Albuns(int userId, int id, string title)
        {
            this.userId = userId;
            this.id = id;
            this.title = title;
        }
    }
}
