using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityComponentSystem
{
    public interface IEntity
    {
        Guid Id { get; }
        T AddComponent<T>(T component) where T : IComponent;
        void RemoveComponent<T>(T component) where T : IComponent;
        T GetComponent<T>() where T : IComponent;
    }

    public class Entity : IEntity
    {
        private Guid _id;

        public Guid Id => this._id;

        public List<IComponent> Components { get; private set; }

        public Entity()
        {
            this._id = Guid.NewGuid();
            this.Components = new List<IComponent>();
        }

        public T AddComponent<T>(T component) where T : IComponent
        {
            if (this.Components.Contains(component))
                throw new Exception("Component already exists.");

            this.Components.Add(component);

            return component;
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            if (this.Components.Contains(component))
                this.Components.Remove(component);
        }

        public T GetComponent<T>() where T : IComponent
        {
            return (T)this.Components.FirstOrDefault(x => x.GetType() == typeof(T));
        }
    }

    public class PlayerEntity : Entity
    {
    }

    public class MonsterEntity : Entity
    {
    }
}