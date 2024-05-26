using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public class GuestResponse
{
    [Required(ErrorMessage = "Please enter ur name !")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please enter ur Email !")]
    [EmailAddress]
    public string? Email { get; set; }

    
    [Required(ErrorMessage = "Please enter ur phone !")]

    public string? Phone { get; set; }

    [Required(ErrorMessage = "Please specify whether You'll attend !")]
    public bool? WillAttend { get; set; }
}



// using System.ComponentModel.DataAnnotations;
// namespace PartyInvites.Models {
//     public class GuestResponse {
//         [Required(ErrorMessage = "Please enter your name")]
//         public string? Name { get; set; }
//         [Required(ErrorMessage = "Please enter your email address")]
//         [EmailAddress]
//         public string? Email { get; set; }
//         [Required(ErrorMessage = "Please enter your phone number")]
//         public string? Phone { get; set; }
//         [Required(ErrorMessage = "Please specify whether you'll attend")]
//         public bool? WillAttend { get; set; }
//     }
// }