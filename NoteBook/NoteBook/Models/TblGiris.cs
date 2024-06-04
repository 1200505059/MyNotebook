using System.ComponentModel.DataAnnotations;

namespace NoteBook.Models
{
    public class TblGiris
    {
        [Key]
        public int GirisID { get; set; }
        public string AdSoyad { get; set; }
        public string ImageURL { get; set; }
    }
}
