using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGlassTeste.Domain.Entity
{
    public class Base
    {
        [Required]
        [Key]
        public int CodigoProduto { get; set; }
    }
}
