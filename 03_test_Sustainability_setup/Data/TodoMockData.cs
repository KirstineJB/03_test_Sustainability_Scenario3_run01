namespace _03_test_Sustainability_setup.Data
{
    using _03_test_Sustainability_setup.Models;

    public static class TodoMockData
    {
        public static List<TodoTask> Tasks { get; } = new()
        {
            new TodoTask
            {
                Id = 1,
                Title = "indkøbing",
                TodoDetailId = 101
            },
            new TodoTask
            {
                Id = 2,
                Title = "Lav noget",
                TodoDetailId = 102
            },
            new TodoTask
            {
                Id = 3,
                Title = "Tag opvasken",
                TodoDetailId = 103
            }
        };

        public static List<TodoDetail> Details { get; } = new()
        {
            new TodoDetail
            {
                Id = 101,
                Description = "Æg, skinke,brød",
                Deadline = new DateTime(2026, 3, 20),
                Priority = "Høj",
                Status = "Done"
            },
            new TodoDetail
            {
                Id = 102,
                Description = "Lang beskrivelse af hvad der skal laves",
                Deadline = new DateTime(2026, 3, 22),
                Priority = "Medium",
                Status = "In Progress"
            },
            new TodoDetail
            {
                Id = 103,
                Description = "Husk sæbe",
                Deadline = new DateTime(2026, 3, 18),
                Priority = "Lav",
                Status = "To do"
            }
        };
    }
}
