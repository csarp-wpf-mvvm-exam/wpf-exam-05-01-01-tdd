﻿using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SchoolClassRepo<TDbContext> : RepositoryBase<TDbContext, SchoolClass>, ISchoolClassRepo
        where TDbContext : DbContext
    {
        public SchoolClassRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<SchoolClass> SelectAllIncluded()
        {
            return FindAll().Include(schoolClass => schoolClass.TypeOfEducation);
        }

        public IQueryable<SchoolClass> GetSchoolClassBy(Guid typeOfEducationID)
        {
            return FindAll().Where(schoolClass => schoolClass.TypeOfEducationId == typeOfEducationID);
        }

        public IQueryable<SchoolClass> SelectWithoutTypeOfEducation()
        {
            return FindAll().Where(schoolClass =>
              schoolClass.TypeOfEducationId == null ||
              schoolClass.TypeOfEducationId == Guid.Empty);
        }
    }
}
