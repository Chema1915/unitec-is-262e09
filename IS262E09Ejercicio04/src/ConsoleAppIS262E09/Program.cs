 

using ApplicationIS262E09 ; // Add the ap  propriate namespace where FiguraIS262E09 is defined

double lado = 5.0; 

double altura = (Math.Sqrt(3) / 2) * lado;  

double perimetro = FiguraIS262E09.Perimetro(lado);
double area = FiguraIS262E09.Area(lado);
double areaRedondeada = Math.Round(area, 2); 

 

 

Console.WriteLine($"El Perimetro de un triangulo de {lado}cm de lado es: {perimetro}cm"); 

Console.WriteLine($"El Área de un triangulo de {lado}cm de lado es: {areaRedondeada}cm²"); 