namespace ApplicationIS262E09;

public class FiguraIS262E09
{
   public static double Perimetro(double lado)
   {
      return 3 * lado;
   }

 public static double Area(double lado)
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
    }
   
   public static double Volumen(double lado)
   {
      return (Math.Sqrt(2) / 12) * Math.Pow(lado, 3);
   }
}
