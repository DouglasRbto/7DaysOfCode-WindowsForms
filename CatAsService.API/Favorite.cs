using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.API
{
    public class Favorite
    {
        public int? id { get; set; }
        public string? user_id { get; set; }
        public string? image_id { get; set; }
        public string? sub_id { get; set; }
    }
}
