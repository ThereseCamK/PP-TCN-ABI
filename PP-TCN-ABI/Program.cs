// See https://aka.ms/new-console-template for more information
//1) Bilforhandleren
//En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand.
//Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa,
//eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. 
//Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.
using PP_TCN_ABI;
using System.ComponentModel.Design;
CarShop abiAndTCarDealer = new CarShop();
Car audiA4 = new Car("Audi", "A4", 2020, 130000, "LS45678");
Car volvoV70 = new Car("Volvo", "V70", 2023, 13000, "LF45678");
Car volvoXC90 = new Car("Volvo", "XC90", 2023, 10000, "LS45454");
Car teslaX = new Car("Tesla", "modelX", 2025, 1000, "EJ45678");
Car teslaS = new Car("Tesla", "modelS", 2020, 13000, "ED45678");
Car volvo240 = new Car("Volvo", "240", 2004, 300000, "LY45454");

abiAndTCarDealer.addCar(audiA4);
abiAndTCarDealer.addCar(volvoV70);
abiAndTCarDealer.addCar(volvoXC90);
abiAndTCarDealer.addCar(teslaX);
abiAndTCarDealer.addCar(teslaS);
abiAndTCarDealer.addCar(volvo240);

menu();
void menu()
{
    Console.WriteLine("Velkommen til Abi og Thereses bilshappe, hva vil du gjøre? ");

    Console.WriteLine("tast 1 for å vise alle bilene ");
    Console.WriteLine("tast 2 for å søke etter merke ");
    Console.WriteLine("tast 3 for å søke etter max kmStand ");
    Console.WriteLine("tast 4 for å søke etter minste år ");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            abiAndTCarDealer.showAllCars();
            menu();
            break;
        case "2":
            Console.WriteLine("Skriv inn ønsket Merke: f.eks Audi, Volvo, Tesla");
            string userChoiseOfBrand =Console.ReadLine();
           abiAndTCarDealer.showCarsByBrand(userChoiseOfBrand);
            menu();
            break;
        case "3":
            // showCarsByKm()
            break;
        case "4":
            // showCarsByYear()
            break;

    }
}








