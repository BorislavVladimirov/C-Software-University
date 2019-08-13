using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly ICollection<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.models.ToList().AsReadOnly();

        public void Add(IGun model)
        {
            if (!this.models.Contains(model))
            {
                this.models.Add(model);
            }
        }

        public IGun Find(string name)
        {
            return this.models.FirstOrDefault(x => x.Name == name);
            //return GetGenericElement(name);
        }

        public bool Remove(IGun model)
        {
            return this.models.Remove(model);
        }

        private IGun GetGenericElement(string name)
        {
            IGun result = null;

            foreach (var elem in this.models)
            {
                if (elem is IGun gun)
                {
                    if (gun.Name == name)
                    {
                        result = (IGun)elem;
                    }
                }
            }

            return result;
        }
    }
}
