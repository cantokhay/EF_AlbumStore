using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Maraton_DAL.Entites
{
    public class Artist :Base
    {
        [NotMapped]
        public int AlbumId { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
