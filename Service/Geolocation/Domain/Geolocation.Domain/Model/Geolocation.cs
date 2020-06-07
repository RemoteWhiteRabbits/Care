using System;
using System.Collections.Generic;
using System.Text;

namespace Geolocation.Domain.Model
{
    public class Geolocation
    {
        public Guid LocationId { get; set; }
        public Guid ProfileId { get; set; }
        public string Direction { get; set; }
        public string Coordinates { get; set; }
    }
}
