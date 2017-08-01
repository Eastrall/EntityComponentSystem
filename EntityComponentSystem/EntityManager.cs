using System;
using System.Collections.Generic;
using System.Text;

namespace EntityComponentSystem
{
    public static class EntityManager
    {
        public static T CreateEntity<T>() where T : IEntity, new()
        {
            return new T();
        }
    }
}
