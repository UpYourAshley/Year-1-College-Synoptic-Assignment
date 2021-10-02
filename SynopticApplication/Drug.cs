using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynopticApplication.Enum;

namespace SynopticApplication
{
    public class Drug
    {
        public string Name { get; set; }

        public DrugClass Class { get; set; }

        public int ID { get; set; }
    }
}
