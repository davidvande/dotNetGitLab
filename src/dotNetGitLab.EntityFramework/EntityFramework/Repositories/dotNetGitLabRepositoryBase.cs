using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace dotNetGitLab.EntityFramework.Repositories
{
    public abstract class dotNetGitLabRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<dotNetGitLabDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected dotNetGitLabRepositoryBase(IDbContextProvider<dotNetGitLabDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class dotNetGitLabRepositoryBase<TEntity> : dotNetGitLabRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected dotNetGitLabRepositoryBase(IDbContextProvider<dotNetGitLabDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
