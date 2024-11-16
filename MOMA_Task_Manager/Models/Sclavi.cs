using System.ComponentModel.DataAnnotations;

namespace MOMA.Models
{
    public class Sclavi
    {
        [Key]
        public int Proiect_Id { get; set; }
        public int Utilizator_Id { get; set; }
    }
}
