using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibContexte;

namespace Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetAll();

        Hotel FindById();
    }
}
