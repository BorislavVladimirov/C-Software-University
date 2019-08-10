using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly ICollection<T> models;

        protected Repository()
        {
            this.models = new List<T>();
        }

        protected IReadOnlyCollection<T> Models
            => this.models.ToList().AsReadOnly();

        public void Add(T model)
        {
            this.models.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return this.Models;
        }

        public abstract T GetByName(string name);

        public bool Remove(T model)
        {
            return this.models.Remove(model);
        }
    }
}
