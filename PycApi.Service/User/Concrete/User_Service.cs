using AutoMapper;
using NHibernate;
using System.Collections.Generic;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;

namespace PycApi.Service
{
    public class User_Service : BaseService<UserDto, User>, IUser_Service
    {
        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<User> hibernateRepository;

        public User_Service(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<User>(session);
        }

        public override BaseResponse<IEnumerable<UserDto>> GetAll()
        {
            return base.GetAll();
        }

        public override BaseResponse<UserDto> GetById(long id)
        {
            return base.GetById(id);
        }

        public override BaseResponse<UserDto> Insert(UserDto insertResource)
        {
            return base.Insert(insertResource);
        }
    }
}
