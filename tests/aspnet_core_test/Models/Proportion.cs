using aspnet_core_test.Interfaces;

namespace aspnet_core_test.Models
{
    public class Proportion
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public IProportionScope ProportionScope { get; set; }
        public int ProportionScopeId { get; set; }
    }
}