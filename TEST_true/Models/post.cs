using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_true.Models
{
    public class post
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string text { get; set; }
        public List<comment> comments { get; set; }
    }
}
