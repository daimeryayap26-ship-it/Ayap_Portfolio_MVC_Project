using MyPortfolio.Models;

namespace MyPortfolio.Services
{
    public class PortfolioService
    {
        private static List<Project> _projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "BSIT31E1 Prelim H1",
                Description = "Prelim hands-on activity for BSIT 31E1 focusing on core Web Development.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/BSIT31E1_PRELIM_H1_AYAP_DAIMERY",
                ImageUrl = "/images/project1.jpg",
                Comments = new List<string> { "Initial submission." }
            },
            new Project
            {
                Id = 2,
                Title = "Weather Forecast App",
                Description = "A sleek weather forecast application that tracks live climate data.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/Weather_Forecast_Ayap",
                ImageUrl = "/images/project2.jpg",
                Comments = new List<string> { "Very useful app!", "Clean code structure." }
            },
            new Project
            {
                Id = 3,
                Title = "IT Elective BSIT 31E3",
                Description = "Coursework and project repository for IT Elective BSIT 31E3.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_BSIT_31E3_ayap_daimerygold",
                ImageUrl = "/images/project3.jpg",
                Comments = new List<string> { "Well documented." }
            },
            new Project
            {
                Id = 4,
                Title = "IT Elective 2 Midterm H1-H3",
                Description = "Midterm hands-on activities 1 to 3 for IT Elective 2.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                ImageUrl = "/images/project4.jpg",
                Comments = new List<string> { "Completed hands-on tasks." }
            },
            new Project
            {
                Id = 5,
                Title = "IT Elective 2 Midterm Exam",
                Description = "Midterm examination project implementation for IT Elective 2.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_MIDTERM_EXAM_9_DaimeryAyap",
                ImageUrl = "/images/project5.jpg",
                Comments = new List<string> { "Great job on the exam project!" }
            },
            new Project
            {
                Id = 6,
                Title = "IT Elective 2 Midterm Q3",
                Description = "Midterm quiz 3 hands-on repository.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_MIDTERM_Q3",
                ImageUrl = "/images/project6.jpg",
                Comments = new List<string> { "All requirements met." }
            },
            new Project
            {
                Id = 7,
                Title = "IT Elective 2 Assignment One",
                Description = "First assignment submission for IT Elective 2.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/Ayap_IT_ELECTIVE_2_Assignment_One",
                ImageUrl = "/images/project7.jpg",
                Comments = new List<string> { "Good logic implementation." }
            },
            new Project
            {
                Id = 8,
                Title = "IT Elective 2 Prefinal Exam",
                Description = "Prefinal examination project repository for BSIT 31E3.",
                GitHubUrl = "https://github.com/daimeryayap26-ship-it/IT_ELECTIVE_2_BSIT-31E3_PREFINAL_EXAM_Ayap_DaimeryGold",
                ImageUrl = "/images/project8.jpg",
                Comments = new List<string> { "Complete implementation for prefinals." }
            }
        };

        public List<Project> GetAllProjects() => _projects;

        public Project? GetProjectById(int id) => _projects.FirstOrDefault(p => p.Id == id);

        public void AddComment(int projectId, string comment)
        {
            var project = GetProjectById(projectId);
            if (project != null && !string.IsNullOrWhiteSpace(comment))
            {
                project.Comments.Add(comment);
            }
        }
    }
}