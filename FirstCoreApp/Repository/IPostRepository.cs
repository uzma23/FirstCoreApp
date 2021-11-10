using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp.Models;

namespace FirstCoreApp.Models.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
