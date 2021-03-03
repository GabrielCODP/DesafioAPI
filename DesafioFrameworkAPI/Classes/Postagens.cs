using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioFrameworkAPI.Classes
{
    class Postagens
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }


        public Postagens(int userId, int id, string title, string body)
        {
            this.userId = userId;
            this.id = id;
            this.title = title;
            this.body = body;
        }

    }
}
