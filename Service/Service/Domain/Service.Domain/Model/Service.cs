using System;


namespace Service.Domain.Model
{
    public class Service
    {
        public Guid Id { get; }
        public Guid StylistProfileId { get; }
        public string ServiceType { get; }

        public Service(Guid id, Guid stylistProfileId, string serviceType)
        {
            Id = id;
            StylistProfileId = stylistProfileId;
            ServiceType = serviceType;
        }
    }
}
