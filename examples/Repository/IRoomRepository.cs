using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRoomRepository
    {
        List<Room> FindAllByHotelId(int hotelId);
    }
}
