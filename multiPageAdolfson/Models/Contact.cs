using System.ComponentModel.DataAnnotations;

namespace multiPageAdolfson.Models
{
    public class Contact
    {

        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number, including area code.")]
        [Range(1000000000, 9999999999, ErrorMessage = "Phone number must be 10 digits long and valid.")]
        public long? phoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string? address { get; set; }

        public string? note { get; set; }

    }
}
