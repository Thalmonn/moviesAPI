using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moviesAPI.Data.Dtos
{
    public class CreateMovieDto
    {
        [Required(ErrorMessage = "Title field is mandatory."), StringLength(208, ErrorMessage = "Title must contain a maximum of 208 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Genre field is mandatory.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Director field is mandatory.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Director field is mandatory."), Range(1, 43200, ErrorMessage = "Runtime must be between 1 and 43200 minutes.")]
        public int Runtime { get; set; }
    }
}
