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

    public class StagingDeveloper : IDeveloper
    {
        public string Do => "No. Staging rocks!!!";
    }

    public class DevelopmentDeveloper : IDeveloper
    {
        public string Do => "No. Development rocks!!!";
    }

    public class AllPurposeDeveloper : IDeveloper
    {
        public string Do => "No. Anything rocks!!!";
    }
}