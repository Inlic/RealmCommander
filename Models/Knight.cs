using System.ComponentModel.DataAnnotations;

namespace RealmCommander.Models
{
  public class Knight
  {
    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
  }
}