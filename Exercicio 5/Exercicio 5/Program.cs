using System.ComponentModel;
using System.Reflection;

//Crie um método que receba um objeto genérico e liste as propriedades e métodos dele

//Crie um método que receba um objeto genérico e crie uma instância dele e a retorne


ListData(new Pessoa());
void ListData<T>(T obj)
{
    var objType = obj.GetType();
    var properties = objType.GetProperties();
    foreach(var item in properties)
    {
        Console.WriteLine($"{item.Name} - {item.GetValue(obj)}");
    }
    var methods = objType.GetMethods();
    foreach(var item in methods)
    {
        Console.WriteLine($"{item.Name} - {item.ReturnType}");
    }
}
T CreatObject<T>()
{
    return Activator.CreateInstance<T>();
}

class Pessoa
{
    public int Nome { get; set; }
    public double ID { get; set; }
}
