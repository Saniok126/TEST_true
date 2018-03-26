using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_true.Models
{
    public class comment
    {
        public int ID { get; set; }
        public int post_ID { get; set; }
        public string author { get; set; }
        public string text { get; set; }
    }
}
