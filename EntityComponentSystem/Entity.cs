using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityComponentSystem
{
    public interface IEntity
    {
        Guid Id { get; }

        T AddComponent<T>(T component) where T : IComponent;

        T AddComponent<T>() where T : IComponent, new();

        void RemoveComponent<T>(T component) where T : IComponent;

        T GetComponent<T>() where T : IComponent;

        bool HasComponent<T>() where T : IComponent;
    }

    public class Entity : IEntity
    {
        private readonly Guid _id;
        private readonly IDictionary<Type, IComponent> _components;

        public Guid Id => this._id;

        public Entity()
        {
            this._id = Guid.NewGuid();
            this._components = new Dictionary<Type, IComponent>();
        }

        public T AddComponent<T>(T component) where T : IComponent
        {
            if (component == null)
                throw new ArgumentNullException(nameof(component));

            this._components.Add(typeof(T), component);

            return component;
        }

        public T AddComponent<T>() where T : IComponent, new()
        {
            var newComponent = new T();

            return this.AddComponent(newComponent);
        }

        public void RemoveComponent<T>(T component) where T : IComponent
        {
            if (component == null)
                throw new ArgumentNullException(nameof(component));

            if (this._components.ContainsKey(typeof(T)))
                this._components.Remove(typeof(T));
        }

        public T GetComponent<T>() where T : IComponent
        {
            if (this._components.TryGetValue(typeof(T), out IComponent component))
                return (T)component;
            return default(T);
        }

        public bool HasComponent<T>() where T : IComponent
        {
            return this.GetComponent<T>() != null;
        }
    }
}