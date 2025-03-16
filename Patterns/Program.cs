using Patterns.HomeWork.HomeWork140325.Manager;

var config1 =  ConfigurationManager.GetInstance();
var config2 =  ConfigurationManager.GetInstance();

// проверка того, что запускается один экземпляр объекта

Console.Write("Текущий конфиг:");
config1.ShowConfig();
Console.WriteLine("-------------");
Console.WriteLine("Меняем конфиг в config1");
//записываем настройку в конфиг
config1.setConfig("Запись в конфиг-1", 1);
// тот же результат и в config2
Console.WriteLine("Смотрим, что в config2");
config2.ShowConfig();