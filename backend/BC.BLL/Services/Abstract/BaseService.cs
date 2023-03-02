using AutoMapper;
using BC.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.BLL.Services.Abstract
{
    public abstract class BaseService
    {
        private protected readonly BookCriticContext _context;
        private protected readonly IMapper _mapper;

        public BaseService(BookCriticContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
