using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Dapper;
using Jira.Microservice.Models;

namespace Jira.Ms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private string _connectionString { get; set; }
        private readonly MySqlConnection _conn;
        public TaskController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _conn = new MySqlConnection(_connectionString);
        }

        [HttpGet(Name = "GetTask")]
        public IActionResult GetTasks()
        {
            try
            {
                var sql = "Select * from TASK";
                var result = _conn.Query<Tasks>(sql).ToList();

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error message : {ex.Message} stack trace {ex.StackTrace}");
            }
        }

        [HttpPost(Name = "Task")]
        public IActionResult CreateTask([FromBody] Tasks task)
        {

            try
            {

                string insertQuery = "INSERT INTO `TASK` (`TITLE`, `DESCRIPTION`, `ACCEPTANCE_CRITERIA`, `STATUS`, `PRIORITY`, `ORIGINAL_ESTIMATE`, `COMPLETED`, `REMAINING`)" +
                                      "VALUES(@Title, @Description, @Acceptance_Criteria, @Status, @Priority, @Original_Estimate, @Completed, @Remaining); ";

                int rowsAffected = _conn.Execute(insertQuery,
                        new Tasks()
                        {
                            Title = task.Title,
                            Description = task.Description,
                            Acceptance_Criteria = task.Acceptance_Criteria,
                            Status = task.Status,
                            Priority = task.Priority,
                            Original_Estimate = task.Original_Estimate,
                            Completed = task.Completed,
                            Remaining = task.Remaining,
                        }
                    );
                return Created("created", rowsAffected);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"Internal server error message : {ex.Message} stack trace {ex.StackTrace}");

            }

        }
    }
}
