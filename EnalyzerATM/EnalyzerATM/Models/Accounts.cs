namespace EnalyzerATM.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pin { get; set; }
        public float Balance { get; set; }
        public string CardNumber { get; set; }
    }
}
