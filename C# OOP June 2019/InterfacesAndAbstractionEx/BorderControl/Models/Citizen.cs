using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthtable
    {
        public Citizen(string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }

        public string Age { get; private set; }

        public string Birthdate { get; private set; }
    }
}
