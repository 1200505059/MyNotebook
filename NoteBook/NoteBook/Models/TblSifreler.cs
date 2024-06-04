using System.ComponentModel.DataAnnotations;

namespace NoteBook.Models
{
    public class TblSifreler
    {
        [Key]
        public int SifreId { get; set; }
        public string SifreTitle { get; set; }
        public string SifreText { get; set; }
    }
}
