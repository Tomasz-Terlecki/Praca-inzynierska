using SqlServerConnectorTemplate;
using SqlServerConnectorTemplate.Models;

public class Program
{
    public static bool childrenNumberEqualsToZero(Parent parent)
    {
        return parent.Children.Count() != 0;
    }

    public static void Main()
    {
        var dataRepository = new DataRepository();

        // var ch = await dataRepository.GetManyByConditionAsync<Parent>(Program.childrenNumberEqualsToZero, new string[] {});
    }
}
