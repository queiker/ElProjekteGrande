using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace El_Projekte_Grande.Models

{
    public class ChatRepository : IChatRepositories
    {
        
        public IEnumerable<News> GetNews => new List<News> { new News {Nick = "Grzegorz Płonka", Message = "Hello world!" },
         new News {Nick = "Dominika Barret", Message = "Hello world!" }

        };

    }
}
