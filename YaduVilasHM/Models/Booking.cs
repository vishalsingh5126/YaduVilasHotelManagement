using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaduVilasHM.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public string BookingPerson { get; set; }
        public string NationalIdType { get; set; }
        public string NationalIdNumber { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime BookingDate { get; set; }
        public bool Active { get; set; }
        public static List<Room> GetAvailableRooms(List<Room> rooms, List<Booking> bookings)
        {
            List<Room> availableRooms = new List<Room>();
            foreach (var room in rooms)
            {
                int count = 0;
                foreach (var booking in bookings)
                {
                    if(room.RoomId == booking.RoomId)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                    availableRooms.Add(room);
            }
            return availableRooms;
        }
    }
}
