using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{

    public class Casino
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string casinoname { get; set; }
        public string clubname { get; set; }
        public string casinolocation { get; set; }
        public Guid userguid { get; set; }
    }
}
