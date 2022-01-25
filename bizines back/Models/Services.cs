using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bizines_back.Models
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Logo { get; set; }
        [MaxLength(150)]
        public string Uptitle { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }

    }
}
