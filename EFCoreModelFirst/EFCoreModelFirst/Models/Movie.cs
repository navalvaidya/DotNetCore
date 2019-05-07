using EFCoreModelFirst.Models.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Small Title Please!")]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [ReleaseDateValidator]
        public DateTime ReleaseDate { get; set; }

        public string Genere { get; set; }

        public decimal Price { get; set; }
    }
}
