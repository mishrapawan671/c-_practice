using System.Data;

namespace com.interfaces
{
    interface IVechicle
    {
        void saveToDb(dto.Vechicle vechicle);
        DataTable fetchFromDb(int id);
        event drive driveops;
    }
}
