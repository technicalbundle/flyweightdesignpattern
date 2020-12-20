namespace FlyweightDesignPattern
{
    public class Star : IGalaxy
    {
        public static Ellipse StarShape = new Ellipse(10, 10, "blue"); // Intrinsic State

        // These are the extrinsic states
        int positionX;
        int positionY;
        double brightness;

        public void SetBrightness(double brightness)
        {
            this.brightness = brightness;
        }

        public void SetPosition(int x, int y)
        {
            positionX = x;
            positionY = y; 
        }

        public override string ToString()
        {
            return string.Format($"A Star at [{positionX},{positionY}] coordinate and is shining with [{brightness}]% brightness");
        }
    }
}
