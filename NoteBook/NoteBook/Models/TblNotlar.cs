using System.ComponentModel.DataAnnotations;

namespace NoteBook.Models
{
    public class TblNotlar
    {
        [Key]
        public int NotID { get; set; }
        public string NotTitle { get; set; }
        public string NotText { get; set; }
       
    }
}
