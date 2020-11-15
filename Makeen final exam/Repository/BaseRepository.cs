using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Makeen_final_exam.Repository
{
    public class BaseRepository
    {
        protected readonly UserDbContext Context;

        protected BaseRepository(UserDbContext context)
        {
            Context = context;
        }
    }
}
