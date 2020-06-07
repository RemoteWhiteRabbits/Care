namespace Job.Domain.Model
{
    using System;
    using Enum;

    public class Job
    {
        public Guid JobId { get; }
        public JobReference JobReference  { get; }

        public EnJobStatus Status { get; }
        public DateTime StartTimeStamp { get; }
        public DateTime StopTimeStamp { get; }

        public Job(Guid jobId, JobReference jobReference, EnJobStatus status, DateTime startTimeStamp, DateTime stopTimeStamp)
        {
            this.JobId = jobId;
            this.JobReference = jobReference;
            this.Status = status;
            this.StartTimeStamp = startTimeStamp;
            this.StopTimeStamp = stopTimeStamp;
        }
    }
}
