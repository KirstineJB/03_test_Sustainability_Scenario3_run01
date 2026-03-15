namespace _03_test_Sustainability_setup.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; } 
        public string Status { get; set; } 
        public DateTime DueDate { get; set; }
        public string Priority { get; set; } 
        public string Category { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AssignedTo { get; set; }
    }
}
