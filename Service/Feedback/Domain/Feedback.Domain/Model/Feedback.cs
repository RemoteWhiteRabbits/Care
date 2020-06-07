using System;
using System.Collections.Generic;
using System.Text;

namespace Feedback.Domain.Model
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public Guid StylistProfileId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }

        public Feedback(Guid id, Guid stylistProfileId, int rate, string comment)
        {
            Id = id;
            StylistProfileId = stylistProfileId;
            Rate = rate;
            Comment = comment;
        }
    }
}
