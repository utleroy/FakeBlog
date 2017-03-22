using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBlog.DAL.Repository
{
    interface IRepository
    {
        void addPost(string userId);
    }
}
