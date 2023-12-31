﻿using Examples.Core.Interfaces.Database.Repositories;
using Examples.Core.Entities;
using Examples.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace Examples.Database.Repositories
{
    public class ExampleChildTableRepository : RepositoryBase<ExampleChildTableDB>, IExampleChildTableRepository
    {
        public ExampleChildTableRepository(ExamplesContext context)
            : base(context) { }

        public IExampleChildTableRepository IncludeParent()
        {
            Query = Query.Include(x => x.Parent);
            return this;
        }
    }
}
