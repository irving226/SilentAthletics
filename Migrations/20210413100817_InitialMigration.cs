using Microsoft.EntityFrameworkCore.Migrations;

namespace SilentAthleticsWebApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<int>(type: "int", nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "FirstName", "LastName", "Neighborhood", "UserName" },
                values: new object[] { 1, "1333 AWS Ave, Denver CO 80111", 0, "Brianirv@outlook.com", "Brian", "Irving", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
