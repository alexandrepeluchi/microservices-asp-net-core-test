using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace UserService.Database.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Contact { get; set; }
    }
}
