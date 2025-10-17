namespace Tita_Elisa_Lab2.Models
{
    public class Editura
    {
        public int ID { get; set; }
        public string NumeEditura { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
