using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAcess.Abstract
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAllHotels();
        Hotel GetHotelById(int id);

        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);

    }
}
