using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOMA.Models
{
    public class Taskuri
    {
        [Key]
        public int Task_Id { get; set; }
        public string Descriere { get; set; }
        public int Status { get; set; }
        public DateTime Data_start { get; set; }
        public DateTime Data_end { get; set; }
        //public List<FileInfo> Continut_media { get; set; } = new List<FileInfo>();

        [ForeignKey("General_Id")]

        public int? General_Id { get; set; }

        [ForeignKey("Proiect_Id")]
        public int? Proiect_Id { get; set; }
        
    }

    
}
