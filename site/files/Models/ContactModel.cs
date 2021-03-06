using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
  public class ContactModel : BaseEntity
  {
    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string FilePath { get; set; }

    public bool SendError { get; set; }

    public override string EntityName => "Contact";
  }
}