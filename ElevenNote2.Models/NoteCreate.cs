using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote2.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters")]
        [MaxLength(50, ErrorMessage ="50 characters max")]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "500 characters max")]
        public string Content { get; set; }
    }
}
