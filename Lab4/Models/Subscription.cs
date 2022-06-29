namespace Lab4.Models
{
    public class Subscription
    {
        public int ClientId { get; set; }
        public string BrokerageId { get; set; }
        public List<Client> Clients { get; set; }
        public List<Brokerage> Brokerages { get; set; }
    }
}
