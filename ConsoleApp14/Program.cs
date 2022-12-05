using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {

        List<People> collection = new List<People>();
        People x = new("Денис Ехиванов Олегович ", new DateOnly(2004,11,12));
        People y= new("Денис Ехиванов Олегович ", new DateOnly(2004, 11, 12));
        People z = new("Денис Ехиванов Олегович ", new DateOnly(2004, 11, 12));

        collection.Add(x);
        collection.Add(y);
        collection.Add(z);

        foreach (var item in collection)
        {
            Console.WriteLine(item.GetPassport());
        }



    }
}



class People
{
    private string _name;
    private string _family;
    private string _patronomic;

    private DateOnly _birhtdate;

    private int _age;

    public People(string fio,DateOnly date)
    {
        var fio_arr = fio.Split(" ");
        if (fio_arr.Length <= 2)
            return;
        _name = fio_arr[0];
        _family = fio_arr[1];
        _patronomic = fio_arr[2];

        _age = DateTime.Now.Year - date.Year;

    }

    public string GetPassport()
    {
        string info = $"Имя {_name}\nФамилия {_family}\nОтчество {_patronomic}\nВозраст {_age}";
        return info;
    }


}




