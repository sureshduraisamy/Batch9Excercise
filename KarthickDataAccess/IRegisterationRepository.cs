using KarthickDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickDataAccess
{
    public interface IRegisterationRepository
    {
        public List<Registration> SelectALLUser();
        public void UpdateUser(Registration reg);
        public void RegisterUser(Registration reg);
        public Registration SelectUserByUsername(string username);
        public void DeleteUserRecord(long regId);
    }
}
