﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Core.DataAccess.Abstracts;
using MioBlog.Entities.ComplexTypes;
using MioBlog.Entities.Concretes;

namespace MioBlog.DataAccess.Abstracts
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
