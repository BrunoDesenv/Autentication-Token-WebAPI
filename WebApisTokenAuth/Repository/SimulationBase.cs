using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using WebApisTokenAuth.Models;

namespace WebApisTokenAuth.Repository
{
    public static class SimulationBase
    {
        public static List<ApplicationUser> Usuarios()
        {
            var usuarios = new List<ApplicationUser>();

            usuarios.Add(new ApplicationUser
            {
                UserName = "Bruno",
                Password = Encoding.UTF8.GetBytes("teste123"),
                UserRole = new UserRole
                {
                    ID = 1,
                    RoleName = "Teste1"
                }
            });
            usuarios.Add(new ApplicationUser
            {
                UserName = "Bruno",
                Password = Encoding.UTF8.GetBytes("teste123")
                ,
                UserRole = new UserRole
                {
                    ID = 1,
                    RoleName = "Teste1"
                }
            });
            usuarios.Add(new ApplicationUser
            {
                UserName = "Bruno",
                Password = Encoding.UTF8.GetBytes("teste123")
                ,
                UserRole = new UserRole
                {
                    ID = 1,
                    RoleName = "Teste1"
                }
            });
            usuarios.Add(new ApplicationUser
            {
                UserName = "Bruno",
                Password = Encoding.UTF8.GetBytes("123teste")
                ,
                UserRole = new UserRole
                {
                    ID = 1,
                    RoleName = "Teste1"
                }
            });


            return usuarios;
        }


        public static List<UserRole> UserRoles()
        {
            var roles = new List<UserRole>();

            roles.Add(new UserRole
            {
                ID = 1,
                RoleName = "Admin",
                ApplicationUsers = Usuarios()
            });

            return roles;

        }


        public static List<Employee> Employees()
        {
            var employees = new List<Employee>();

            employees.Add(new Employee
            {
                Designation = "1",
                EmloyeeName = "Admin",
                Salary = "100.00"
            });

            return employees;

        }

    }
}