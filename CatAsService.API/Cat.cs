using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.API
{
    public class Cat
    {
        public string reference_image_id { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string origin { get; set; }
        public string description { get; set; }
        public string temperament { get; set; }
    }
}
