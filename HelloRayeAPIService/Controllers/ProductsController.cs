using HelloRayeAPIService.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloRayeAPIService.Controllers
{
    // copy this .cs file as many times as you would like to create multiple controllers. This allows you to generate as many apis as you would like
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // look here for your example: https://www.connectionstrings.com/
            string sqlConnection = "Data Source=localhost;Initial Catalog=HelloRaye;Integrated Security=true;";

            // sql query you wish to export
            string sqlQuery = "select Name as ProductName, " + // getting product name
                " 'category' as 'Seating'," + // hard code category example
                " 'subCategory' as 'Lounge Chair'," + // hard code subcategory example
                " case " +
                " when Grade = 1 then 'Residential'" + // getting grade:Residential with case
                " when Grade = 2 then 'Commercial'" + // getting grade:Commercial with case
                " end as Grade" +
                " from Products where ActivityState = 1";


            // method that will convert your sql to JSON
            return Ok(SQLToJson.Execute(sqlConnection, sqlQuery));
        }
    }
}
