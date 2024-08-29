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
        public void UpdateLocation(Location detail);
        public void InsertLocation(Location loc);
        public Location GetLocationByName(string name);
        public List<Location> GetAllLocationInfo();
        public void DeleteLocation(int id);
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

        public void UpdateLocation(Location detail)
        {
          
            try {
                DBContext.Location.Update(detail);
                DBContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }
           
        }

        public void DeleteLocation(int id)
        {
           
            try
            {
                var locationID = DBContext.Location.Find(id);
                if (locationID != null)
                {
                    DBContext.Location.Remove(locationID);
                    DBContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }


        }
    }
}
