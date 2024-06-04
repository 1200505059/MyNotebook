using System.ComponentModel.DataAnnotations;

namespace NoteBook.Models
{
    public class TblAdmin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }

    }
}
