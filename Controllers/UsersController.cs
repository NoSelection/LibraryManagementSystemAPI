using Dapper;
using LibraryManagementSystemAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace LibraryManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _config;

        public UsersController(IConfiguration config) 
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            IEnumerable<Users> users = await SelectAllUsers(connection);
            return Ok(users);
        }

        private static async Task<IEnumerable<Users>> SelectAllUsers(SqlConnection connection)
        {
            return await connection.QueryAsync<Users>("select * from Library_USERS");
        }

        [HttpGet("{UserID}")]
        public async Task<ActionResult<List<Users>>> GetUser(int UserID)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var user = await connection.QueryFirstAsync<Users>("select * from Users where ID = @ID",
                new {ID = UserID });
            return Ok(user);
        }
        [HttpPost]
        public async Task<ActionResult<List<Users>>> CreateUser(Users user)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("insert into Library_USERS(First_Name, Last_Name, Phone, Email, Password, Age) values (@FirstName, @LastName, @Phone, @Email, @Password, @Age)", user);
            return Ok(await SelectAllUsers(connection));
        }
    }
}
