namespace Job.Domain.Model
{
    using System;
    using Enum;

    public class Job
    {
        public Guid JobId { get; set; }
        public JobReference JobReference  { get; set; }

        public EnJobStatus Status { get; set; }
        public DateTime StartTimeStamp { get; set; }
        public DateTime StopTimeStamp { get; set; }
    }
}
