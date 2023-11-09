namespace EF_Maraton_DAL.Entites
{
    public class Album : Base
    {
        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
        public int DiscountRate { get; set; }
        public bool IsActivelySold { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
