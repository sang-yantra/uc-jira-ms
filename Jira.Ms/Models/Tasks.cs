namespace Jira.Microservice.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Acceptance_Criteria { get; set; }
        public string NFR { get; set; }

        public string Status { get; set; }
        public string Priority { get; set; }
        public int Original_Estimate { get; set; }
        public int Completed { get; set; }
        public int Remaining { get; set; }

    }
}
