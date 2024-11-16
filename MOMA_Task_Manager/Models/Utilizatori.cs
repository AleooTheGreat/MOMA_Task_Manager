using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOMA.Models
{
    public class Utilizatori
    {
        [Key]
        public int Utilizator_Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public int? Maresal_Id { get; set; }

        [ForeignKey("Maresal_Id")]
        public Utilizatori Maresal { get; set; }
        //public Utilizatori Cadet { get; set; }
        //public Utilizatori Comandant { get; set; }
        //public Utilizatori Soldat { get; set; }
        //public Utilizatori General { get; set; }
    }
}
