using System;
using System.ComponentModel.DataAnnotations;

namespace OpenBUMPS.Models
{
    public class BUMP
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Context { get; set; }
        public decimal Value { get; set; }
        public string Rating { get; set; }

    }
}
