namespace Dev4Fun_SEM3_Project.Models
{
    public class Vacancies
    {
        public string Id { get; set; }
        public string DepartmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfJobs { get; set; }
        public int NumberOfHired { get; set; }
        public int Status { get; set; }
        public DateTime DateOfExperation { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public string OwnedID { get; set; }

    }
}
