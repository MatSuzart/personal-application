using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PersonalApplication.Models
{
    public class Despesa
    {
        public int ID { get; set; }
        [Required, StringLength(20)]
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Data { get; set; }

    }
}