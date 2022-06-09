namespace SqlServerConnectorTemplate.Models
{
    public class Parent : BaseModel
    {
        public string Name { get; set; }
        public IReadOnlyCollection<Child> Children { get; set; }
    }
}
