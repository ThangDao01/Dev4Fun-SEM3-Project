namespace Dev4Fun_Sem3_eProject.Models
{
    public class CurrentAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Thumbnail { get; set; }
        public int Role { get; set; }   //1 Admin // 2 manager // 3 mentor // 4 hr // 5 member
        public string Description { get; set; }
        public string DepartmentId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfUpdate { get; set; }
    }
}
