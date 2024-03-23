namespace APBD_02;

using Classes;

class Program
{
    static void Main() {
        
        //Tworzenie kontenerów
        Container cnt = new CoolingContainer(50, 10, 20, 10, 80, 20, LoadType.Bananas);
        Container cnt2 = new GasContainer(50, 10, 20, 10, 80, 20);
        Container cnt3 = new LiquidContainer(50, 10, 20, 10, 80, true);
        
        //Statek
        Ship ship = new Ship(10, 1000, 200, cnt, cnt2, cnt3);

        //Ładowanie
        cnt.Load(25);
        cnt2.Load(14);
        cnt3.Load(15);
        
        //Odładowanie
        cnt.Unload();
        cnt2.Unload();
        cnt3.Unload();

        //Odładowanie kontenera ze statku
        ship.UnloadContainer(cnt);
        ship.UnloadContainer(cnt2);
        ship.UnloadContainer(cnt3);
        
        //Załadowanie kontenera na statek
        ship.AddContainer(cnt);
        
        //Załadowanie listy kontenerów
        ship.AddContainer(cnt2, cnt3);

        ship.SwapContainer(cnt2.ID, cnt3);
        
        //Przeniesienie kontenera na inny statek
        Ship ship2 = new Ship(10, 1000, 200);
        ship.MoveToAnotherShip(ship2, cnt);
        
        //Wypisanie informacji o kontenerach
        Console.WriteLine(cnt);
        Console.WriteLine(cnt2);
        Console.WriteLine(cnt3);
        
        //Wypisanie informacji o statku i zawartości
        Console.WriteLine(ship);
    }
}