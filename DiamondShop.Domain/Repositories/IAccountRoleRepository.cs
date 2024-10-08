﻿using DiamondShop.Domain.Models.RoleAggregate;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShop.Domain.Repositories
{
    public interface IAccountRoleRepository : IBaseRepository<AccountRole>
    {
        Task<List<AccountRole>> GetRoles();
    }
}
