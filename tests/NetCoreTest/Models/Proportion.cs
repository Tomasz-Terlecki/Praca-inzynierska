using NetCoreTest_test.Interfaces;

namespace NetCoreTest_test.Models
{
    public class Proportion
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public IProportionScope ProportionScope { get; set; }
        public int ProportionScopeId { get; set; }
    }
}