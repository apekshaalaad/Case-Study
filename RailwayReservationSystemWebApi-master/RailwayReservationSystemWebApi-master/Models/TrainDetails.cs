using System.ComponentModel.DataAnnotations;

namespace Railway_Reservationsystem_WebAPI.Models
{
    public class TrainDetails
    {
        [Key]
        public int TrainId { get; set; }
        public string? TrainName { get; set; }
        public string? TrainType { get; set; }
        public string? From { get; set; }
        public string? TO { get; set; }
        public string? ArrivalTime { get; set; }
        public string? DepartureTime { get; set; }
        public int Distance { get; set; }
        public int TrainCharges { get; set; }

    }
}
