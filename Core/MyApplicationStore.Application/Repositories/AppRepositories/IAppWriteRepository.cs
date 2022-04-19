﻿using MyApplicationStore.Application.Repositories.Base;
using MyApplicationStore.Domain.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplicationStore.Application.Repositories.AppRepositories
{
    public interface IAppWriteRepository : IEntityWriteRepository<App>
    {

    }
}
