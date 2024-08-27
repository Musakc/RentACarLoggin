﻿using RentACarLoggin.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarLoggin.BusinessLayer
{

    public class UserServiceform3
    {
        private readonly UserRepository _userRepository;

        public UserServiceform3(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(string username, string password, string confirmPassword, string phoneNumber, string firstName, string lastName)
        {
            if (!ValidatePassword(password, confirmPassword))
            {
                throw new Exception("Şifreler eşleşmiyor1!");
            }

            _userRepository.AddUser(username, password,confirmPassword, phoneNumber, firstName, lastName);
        }

        private bool ValidatePassword(string password, string confirmPassword)
        {
            return password == confirmPassword; 
        }
    }
}
