namespace Job.Domain.Model
{
    using System;

    public class JobReference
    {
        public Guid ClientProfileId { get; set; }
        public Guid StylistProfileId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid LocationId { get; set; }
    }
}