using System;
using System.Collections.Generic;
using System.Text;

namespace EntityComponentSystem
{
    public abstract class System
    {
        private readonly EntityManager _entityManager;

        protected EntityManager EntityManager => this._entityManager;

        protected System(EntityManager entityManager)
        {
            this._entityManager = entityManager;
        }

        public abstract void Update();
    }

    public sealed class MoveSystem : System
    {
        public MoveSystem(EntityManager entityManager) 
            : base(entityManager)
        {
        }

        public override void Update()
        {
            
        }
    }
}
