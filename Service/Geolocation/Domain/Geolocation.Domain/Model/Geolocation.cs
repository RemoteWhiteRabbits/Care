using System;

namespace Geolocation.Domain.Model
{
    public class Geolocation
    {
        public Guid LocationId { get; }
        public Guid ProfileId { get; }
        public string Direction { get; }
        public string Coordinates { get; }

        public Geolocation(Guid locationId, Guid profileId, string direction, string coordinates)
        {
            this.LocationId = locationId;
            this.ProfileId = profileId;
            this.Direction = direction;
            this.Coordinates = coordinates;
        }
    }
}
