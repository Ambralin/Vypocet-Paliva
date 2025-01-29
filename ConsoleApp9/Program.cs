Console.WriteLine("Uděl délku cesty (km): ");
double delkaCesty = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Uděl spotřebu auta na 100km: ");
double spotreba = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kapacita nádrže: ");
double kapacita = Convert.ToInt32(Console.ReadLine());

double natankovat = Math.Floor(delkaCesty / spotreba / kapacita);
Console.WriteLine($"Je potřeba zastavit a natankovat {natankovat}x.");

double celkovaspotreba = Math.Floor(delkaCesty / spotreba);
Console.WriteLine($"Na celou cestu je potřeba {celkovaspotreba}L.");

double palivonakonec = Math.Floor(celkovaspotreba * natankovat / spotreba);
Console.WriteLine($"Na konci cesty je potřeba {palivonakonec}L.");