namespace CopterShooter.Properties
{
    using System.Drawing;
    using System.Resources;

    internal class Resources
    {
        private static readonly ResourceManager ResourceManager = new ResourceManager("Helicopter_Shooter_Game_MOO_ICT.Properties.Resources", typeof(Resources).Assembly);

        public static Bitmap alien1 => (Bitmap)ResourceManager.GetObject("alien1");
        public static Bitmap alien2 => (Bitmap)ResourceManager.GetObject("alien2");
        public static Bitmap alien3 => (Bitmap)ResourceManager.GetObject("alien3");
        public static Bitmap Halicopter => (Bitmap)ResourceManager.GetObject("Halicopter");
        public static Bitmap pillar => (Bitmap)ResourceManager.GetObject("pillar");
    }
}
