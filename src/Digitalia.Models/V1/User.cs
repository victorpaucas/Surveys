using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digitalia.Models.V1;

public class User : Base
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
	public int ProfileId { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}