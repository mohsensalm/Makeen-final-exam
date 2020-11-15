using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Makeen_final_exam.Repository;

namespace Makeen_final_exam.Service
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
