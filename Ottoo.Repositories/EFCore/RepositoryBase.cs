using Microsoft.EntityFrameworkCore;
using Ottoo.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Repositories.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public IQueryable<T> FindAll() => _context.Set<T>();

        public IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression) =>

            _context.Set<T>().Where(expression);

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
