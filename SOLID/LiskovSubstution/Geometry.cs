namespace LiskovSubstution
{
    public static class Geometry
    {
        public static IAreaCalcutable CreateRectangle(int unit1, int? unit2 = null)
        {
            //bir şekilde....
            if (unit2.HasValue)
            {
                return new Rectangle() { Width = unit1, Height = unit2.Value };
            }

            return new Square() { Edge = unit1 };
        }

        //public void GetArea(Rectangle rectangle)
        //{

        //}
    }

    public interface IAreaCalcutable
    {
        int GetArea();
    }
    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }

    public class Square : IAreaCalcutable //: Rectangle
    {
        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        //public override int Height { get => base.Height; set { base.Width = value; base.Height = value; } }
        public int Edge { get; set; }

        public int GetArea()
        {
            return Edge * Edge;
        }
    }
}
