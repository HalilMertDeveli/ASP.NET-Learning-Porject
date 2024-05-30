using System.ComponentModel.DataAnnotations;

namespace middleware_edit.Models
{
    public class CustomerCreateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Write a name ")]
        [MaxLength(30, ErrorMessage = "Name had only 30 char")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please write last name")]
        [MinLength(3, ErrorMessage = "Min legnth of the last name is 3, please write more than 2 ")]
        public string LastName { get; set; }

        [Range(18, 40, ErrorMessage = "Max age could be 40 and min age range is could be 18")]
        public int Age { get; set; }
    }
}
