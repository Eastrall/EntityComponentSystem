namespace EntityComponentSystem
{
    public interface IComponent { }

    public sealed class SpeedComponent : IComponent
    {
        public float Speeed { get; set; }

        public SpeedComponent(float speed)
        {
            this.Speeed = speed;
        }
    }
}
