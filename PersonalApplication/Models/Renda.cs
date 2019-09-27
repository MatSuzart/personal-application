using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PersonalApplication.Models
{
    public class Renda
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double ValorFixo { get; set; }
        public double ValorVariavel { get; set; }
        public double ValorOutros { get; set; }

    }
}