using System;
using System.Collections.Generic;
using System.Text;

namespace EntityComponentSystem
{
    public interface IComponent
    {
    }

    public class PositionComponent : IComponent
    {
        public Vector3 Position { get; private set; }

        public PositionComponent()
        {
            this.Position = new Vector3();
        }
    }

    public class VelocityComponent : IComponent
    {
        public float Speed { get; set; }

        public VelocityComponent()
            : this(0f)
        {
        }

        public VelocityComponent(float speed)
        {
            this.Speed = speed;
        }
    }
}
