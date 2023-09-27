namespace EnalyzerATM.Models
{
    public class Transactions
    {

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int Amount { get; set; }
        public DateTime Time { get; set; }
    }
}
