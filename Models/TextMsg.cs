using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

// A text message has a destination mobile phone number (10 digits) and content (max 140 characters).
namespace MVC_ex3.Models
{
    public class TextMsg
    {
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Number must be 10 digits!")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Number must be 10 digits!")]
        [DisplayName("To")]
        public string ToNumber { get; set; }
        [Required]
        [StringLength(140, ErrorMessage = "140 characters max!")]
        [DisplayName("Message")]
        public string Message { get; set; }
    }
}
