using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyApiWithToken.Domain.Repositories
{
    public class BaseRepository
    {
        protected readonly UdemyApiWithTokenContext _udemyApiWithTokenContext;
        public BaseRepository(UdemyApiWithTokenContext udemyApiWithTokenContext)
        {
            _udemyApiWithTokenContext = udemyApiWithTokenContext;
        }
    }
}
