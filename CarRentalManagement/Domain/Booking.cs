using Microsoft.AspNetCore.Routing.Constraints;

namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public int Year { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int RentalRate { get; set; }

        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
    }
}
