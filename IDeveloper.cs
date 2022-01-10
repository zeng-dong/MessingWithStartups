namespace MessingWithStartups
{
    public interface IDeveloper
    {
        string Do { get; }
    }

    public class AzureServiceBusDeveloper : IDeveloper
    {
        public string Do => "No. Azure Service Bus rocks!!!";
    }

    public class RabbitMQDeveloper : IDeveloper
    {
        public string Do => "No. Rabbit rocks!!!";
    }

    public class MediatorDeveloper : IDeveloper
    {
        public string Do => "No. In process mediator rocks!!!";
    }
}