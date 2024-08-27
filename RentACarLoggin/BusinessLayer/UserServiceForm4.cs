using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarLoggin.BusinessLayer
{
        public class UserService
        {
            private UserService _userRepository;

            public UserService()
            {
                _userRepository = new UserService();
            }

            public bool AuthenticateUser(string username, string password)
            {
              
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("Kullanıcı adı ve şifre boş olamaz.");
                }
                return _userRepository.AuthenticateUser(username, password);
            }
        }
    }
