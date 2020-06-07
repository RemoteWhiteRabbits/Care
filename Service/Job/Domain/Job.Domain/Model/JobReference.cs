namespace Job.Domain.Model
{
    using System;

    public class JobReference
    {
        public Guid ClientProfileId { get; }
        public Guid StylistProfileId { get; }
        public Guid ServiceId { get; }
        public Guid LocationId { get; }

        public JobReference(Guid clientProfileId, Guid stylistProfileId, Guid serviceId, Guid locationId)
        {
            this.ClientProfileId = clientProfileId;
            this.StylistProfileId = stylistProfileId;
            this.ServiceId = serviceId;
            this.LocationId = locationId;
        }
    }
}