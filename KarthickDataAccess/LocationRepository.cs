using KarthickDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickDataAccess
{

    public interface ILocationRepository
    {
        public void InsertLocation(Location loc);
        public List<Location> GetAllLocationInfo();
    }

 public  class LocationRepository: ILocationRepository
    {
        LocationDBContext DBContext = null;
        public LocationRepository(LocationDBContext Context)
        {
            DBContext = Context;
        }

        public void InsertLocation(Location  loc)
        {
            try
            {
                DBContext.Add(loc);
                DBContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<Location> GetAllLocationInfo()
        {
            try
            {
                return DBContext.Location.ToList();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Location GetLocationByName(string name)
        {
            try
            {
                return DBContext.Location.FirstOrDefault(X => X.LocationName == name);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
