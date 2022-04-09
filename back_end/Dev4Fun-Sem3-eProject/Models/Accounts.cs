namespace Dev4Fun_Sem3_eProject.Models
{
    public class Accounts 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Thumbnail { get; set; }
        public int Role { get; set; }   //0 Admin // 1 manager // 2 mentor // 3 hr // 4 applicants
        public string Description { get; set; }
        public string DepartmentId { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfUpdate { get; set; }
    }
}
