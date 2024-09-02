using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPIAuthExample.Migrations
{
    /// <inheritdoc />
    public partial class initialScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurHeros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurHeros", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OurHeros",
                columns: new[] { "Id", "FirstName", "IsActive", "LastName" },
                values: new object[] { 1, "madhu", true, "dharani" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurHeros");
        }
    }
}
