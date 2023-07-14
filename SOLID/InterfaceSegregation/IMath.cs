namespace InterfaceSegregation
{

    public interface ISimpleMath
    {
        double Sum(double x, double y);
        double Subtract(double x, double y);
    }

    public interface IComplexMath
    {
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }
    public interface IMath : ISimpleMath, IComplexMath
    {

    }




    public class FullMath : IMath
    {
        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return (x - y);
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }
    }


    public class OnlySimpleMath : ISimpleMath
    {


        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }
    }

    public class OnlyComplexMath : IComplexMath
    {
        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }

    public class DividerComponent
    {
        public double Divide(IComplexMath math, double x, double y)
        {
            return math.Divide(x, y);
        }
    }

}
