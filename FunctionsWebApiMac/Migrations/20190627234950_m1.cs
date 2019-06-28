using Microsoft.EntityFrameworkCore.Migrations;

namespace FunctiionsWebAPI.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "8892196a-37cd-4b3e-80b2-f7adcf845e96", "Jane", "Smith", "Medicine" },
                    { "c528d619-3b7e-4147-a702-dd478e59e131", "John", "Fisher", "Engineering" },
                    { "652701d7-7c1b-4784-bf3e-7fbe58c3277a", "Pamela", "Baker", "Food Science" },
                    { "dd538cc5-5346-4262-a3ed-22e393f1b06c", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
