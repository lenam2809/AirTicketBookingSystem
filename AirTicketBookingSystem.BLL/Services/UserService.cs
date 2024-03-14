using AirTicketBookingSystem.BLL.DTOs;
using AirTicketBookingSystem.DAL;
using AirTicketBookingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.BLL.Services
{
    public class UserService
    {
        private readonly IRepository<User> customerRepository;

        public UserService()
        {
            this.customerRepository = new Repository<User>(new AirticketBookingDatabaseEntities());
        }

        public List<UserDTO> GetAllUsers()
        {
            var result = new List<UserDTO>();
            var users = customerRepository.GetAll();
            foreach(var item in users)
            {
                var userDTO = new UserDTO
                {
                    ID = item.ID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Active = item.Active,
                    Birthdate = item.Birthdate,
                    Email = item.Email
                };
                result.Add(userDTO);
            }
            return result;
        }

        // Các phương thức khác đây...
    }
}
