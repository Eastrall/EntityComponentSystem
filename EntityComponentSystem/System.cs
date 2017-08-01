using System;

namespace EntityComponentSystem
{
    public class MoveSystem : System
    {
        public override void Update(float tick)
        {

        }
    }

    public abstract class System
    {
        public abstract void Update(float tick);
    }
}