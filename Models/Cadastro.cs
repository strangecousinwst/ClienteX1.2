using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKX.Models
{
    public class Cadastro
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        [Display(Name = "Descritivo")]
        public string? Texto { get; set; }

        // chave estrangeira para Cliente:
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

    }
}
