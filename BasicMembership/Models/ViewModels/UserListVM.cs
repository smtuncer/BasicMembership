namespace BasicMembership.Models.ViewModels
{
    public class UserListVM
    {
        public string Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public IList<string> Roles { get; set; } = new List<string>();
    }
}
