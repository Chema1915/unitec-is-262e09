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
   public static double Altura(double lado)
   {
      return (Math.Sqrt(3) / 2) * lado;
   }
   public static double Volumen(double area, double altura)
   {
      return (area * altura) / 3;
   }  
   
}
