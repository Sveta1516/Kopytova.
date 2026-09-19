using _Kopytova;

Class1 pribor = new Class1();
Thermometer termometr = new Thermometer();
Weight vesy = new Weight();
Barometr barometr = new Barometr();

Console.WriteLine("Введите Инв.Номер");
pribor.i_Nomer = Console.ReadLine();

Console.WriteLine("Введите название");
pribor.naz = Console.ReadLine();

Console.WriteLine("Введите цвет");
pribor.color = Console.ReadLine();

Console.WriteLine("Введите исполнение");
pribor.ispol= Console.ReadLine();

termometr.WarningSound();
termometr.TempSearch();

vesy.WarningSound();
vesy.WeightSearch();

barometr.WarningSound();
barometr.BarSearch();