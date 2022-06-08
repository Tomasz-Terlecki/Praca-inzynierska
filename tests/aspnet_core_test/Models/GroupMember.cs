namespace aspnet_core_test.Models
{
    public class GroupMember : BaseModel
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}