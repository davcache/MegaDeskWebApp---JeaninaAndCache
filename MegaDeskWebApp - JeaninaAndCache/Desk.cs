public class Desk
{

        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public SurfaceMaterial DeskMaterial { get; set; }

    }

