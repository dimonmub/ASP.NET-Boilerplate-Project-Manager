using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ProjectManager.EntityFramework.Repositories
{
    public abstract class ProjectManagerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProjectManagerDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProjectManagerRepositoryBase(IDbContextProvider<ProjectManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProjectManagerRepositoryBase<TEntity> : ProjectManagerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProjectManagerRepositoryBase(IDbContextProvider<ProjectManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
