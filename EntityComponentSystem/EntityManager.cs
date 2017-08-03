using System;
using System.Collections.Generic;

namespace EntityComponentSystem
{
    public class EntityManager
    {
        private readonly Dictionary<Guid, Entity> _entities;

        public IEnumerable<Entity> Entites => this._entities.Values;

        public Entity this[Guid id] => this._entities[id];

        public EntityManager()
        {
            this._entities = new Dictionary<Guid, Entity>();
        }

        public Entity CreateEntity()
        {
            var newEntity = new Entity();

            this._entities.Add(newEntity.Id, newEntity);

            return newEntity;
        }

        public void DeleteEntity(Guid id)
        {
            this._entities.Remove(id);
        }
    }
}