
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyDados.Models
{
    [Table("users")]
    public class User : Base
    {
        [Column("name")]
        public string? Name { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("password")]
        public string? Password { get; set; }
    }
}
