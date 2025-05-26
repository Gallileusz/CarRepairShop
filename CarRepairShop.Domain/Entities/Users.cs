using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRepairShop.Domain.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Surname")]
        public string Surname { get; set; }

        [Column("Admin")]
        public bool Admin { get; set; }

        internal UserCredentials Credentials { get; set; }
    }
}