using System.ComponentModel.DataAnnotations;

namespace TodoA.Model.Entities.Base
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
