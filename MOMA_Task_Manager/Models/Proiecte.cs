using System.ComponentModel.DataAnnotations;

namespace MOMA.Models
{
    public class Proiecte
    {
        [Key]
        public int Proiect_Id { get; set; }
        public string Nume { get; set; }
    }
}
