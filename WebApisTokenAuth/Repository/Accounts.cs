using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApisTokenAuth.Models;

namespace WebApisTokenAuth.Repository
{
    public class Accounts
    {

        //Varifying user credentials
        public bool Login(string userName, string password)
        {
            try
            {

                var userInfo = SimulationBase.Usuarios().Where(x => x.UserName == userName).FirstOrDefault();
                if (userInfo != null)
                {
                    string stringPwd = Encoding.ASCII.GetString(userInfo.Password);
                    return stringPwd == password;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //To get user role provided with username
        public string GetUserRole(string userName)
        {
            return SimulationBase.Usuarios().Where(x => x.UserName == userName).Select(y => y.UserRole.RoleName).FirstOrDefault();
        }

        public List<string> GetUserRoles()
        {
            return SimulationBase.UserRoles().Select(x => x.RoleName).ToList();
        }

    }
}