using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaduVilasHM.Models;
using YaduVilasHM.Repository;

namespace YaduVilasHM.DataService
{
    public class BookingService : BaseRepository
    {
        public BookingService() : base()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        }
        public static List<Room> rooms = new List<Room>();
        private string ConnectionString { get; set; }
        public async Task<List<Booking>> GetAllBookings(DateTime fromDate, DateTime toDate)
        {
            List<Booking> bookings = new List<Booking> ();

            var parameter = new DynamicParameters();
            parameter.Add("@fromDate", fromDate);
            parameter.Add("@toDate", toDate);
            return await WithConnection(async conn =>
            {
                var result = await conn.QueryMultipleAsync(CommandText.BookingsGet, param: parameter, null, null, CommandType.StoredProcedure);
                bookings = result.Read<Booking>().ToList();
                rooms = result.Read<Room>().ToList();
                return bookings;
            });
        }
        public async Task<Booking> BookingInsert(Booking booking)
        {
            List<Booking> bookings = new List<Booking>();

            var parameter = new DynamicParameters();
            parameter.Add("@fromDate", booking.FromDate);
            parameter.Add("@toDate", booking.ToDate);
            parameter.Add("@roomId", booking.RoomId);
            parameter.Add("@bookingPerson", booking.BookingPerson);
            parameter.Add("@nationalIdType", booking.NationalIdType);
            parameter.Add("@nationalIdNumber", booking.NationalIdNumber);
            return await WithConnection(async conn =>
            {
                var result = await conn.QueryMultipleAsync(CommandText.BookingInsert, param: parameter, null, null, CommandType.StoredProcedure);
                bookings = result.Read<Booking>().ToList();
                return bookings.FirstOrDefault();
            });
        }
    }
}
