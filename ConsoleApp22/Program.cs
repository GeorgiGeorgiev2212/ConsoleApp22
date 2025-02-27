

double suma = 100.0;

int n = 12;
Console.WriteLine($"Star: {suma:F2} lv");

for (int month = 1; month <= n; month++ )
{
    
    suma *= 1.3;
    Console.WriteLine($"Month {month} : {suma} lv");
    

}
double pechalba = (suma - 100.0) * 0.5;
Console.WriteLine($"He will invest {pechalba:F} lv");