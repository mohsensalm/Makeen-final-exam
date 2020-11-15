using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makeen_final_exam.Repository
{
    public class UserRepository: BaseRepository,IUserRepository

    {
        protected UserRepository(UserDbContext context) : base(context)
        {
        }

    }
}
