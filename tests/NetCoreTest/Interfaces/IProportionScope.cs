using NetCoreTest_test.Models;

namespace NetCoreTest_test.Interfaces
{
    public interface IProportionScope
    {
        IDictionary<User, Proportion> UserProportion { get; set; }

        decimal GetProportionForUser(int userId);
        decimal GetProportionForAllUsersInScope();
    }
}