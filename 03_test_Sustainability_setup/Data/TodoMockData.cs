namespace _03_test_Sustainability_setup.Data
{
    using _03_test_Sustainability_setup.Models;

    public static class TodoMockData
    {
        public static List<TodoItem> Items { get; } = new()
        {
            new TodoItem
            {
                Id = 1,
                Title = "Shopping liste",
                Description = "Æg, Smør,mel",
                Status = "In Progress",
                DueDate = new DateTime(2026, 3, 20),
                Priority = "Høj",
                Category = "Indkøb",
                CreatedAt = new DateTime(2026, 3, 10),
                UpdatedAt = new DateTime(2026, 3, 14),
                AssignedTo = "Dennis"
            },
            new TodoItem
            {
                Id = 2,
                Title = "Fix hønsehuset",
                Description = "Hønsehuset er gået i stykker. Stakkels hønsehus.",
                Status = "Not Started",
                DueDate = new DateTime(2026, 3, 22),
                Priority = "Medium",
                Category = "Have",
                CreatedAt = new DateTime(2026, 3, 11),
                UpdatedAt = new DateTime(2026, 3, 14),
                AssignedTo = "Mikkel"
            },
            new TodoItem
            {
                Id = 3,
                Title = "Nyt tøj",
                Description = "Køb nye T-shirts.",
                Status = "Done",
                DueDate = new DateTime(2026, 3, 18),
                Priority = "Lav",
                Category = "Indkøb",
                CreatedAt = new DateTime(2026, 3, 9),
                UpdatedAt = new DateTime(2026, 3, 13),
                AssignedTo = "Mikkel"
            }
        };
    }
}
