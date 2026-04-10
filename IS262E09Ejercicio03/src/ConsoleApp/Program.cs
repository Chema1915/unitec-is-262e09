

double lado = 5.0;
double perimetro = 3 * lado; 
double area = (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
double areaRedondeada = Math.Round(area, 2);


Console.WriteLine($"El Perimetro de un triangulo de {lado}cm de lado es: {perimetro}cm");
Console.WriteLine($"El Área de un triangulo de {lado}cm de lado es: {areaRedondeada}cm²");
