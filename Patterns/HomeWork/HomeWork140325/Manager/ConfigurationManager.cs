// Вариант 2: Создайте класс ConfigurationManager, который будет использовать паттерн Singleton для
// управления конфигурацией приложения. Убедитесь, что конфигурация загружается только один
// раз.
namespace Patterns.HomeWork.HomeWork140325.Manager;

public class ConfigurationManager 
{
  private Config _config = new Config(); //чего-то там в конфиге
  private static ConfigurationManager instance; // ссылка на объект
  
  private ConfigurationManager() 
  {
    // тут будет какая-то логика конструктора
  }

  public void ShowConfig()
  {
    Console.WriteLine($"Строковый параметр из настроек: {_config._param1}");
    Console.WriteLine($"Числовой параметр из настроек: {_config._param2}");
  }

  public void setConfig(string param1, int param2)
  {
    _config._param1 = param1;
    _config._param2 = param2;
  }

  public static ConfigurationManager GetInstance()
  {
    if (instance == null)
    {
      instance = new ConfigurationManager();
    }
    return instance;
  }
}
