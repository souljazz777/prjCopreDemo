using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prjCoreDemo.Migrations
{
    public partial class AddTCustomerToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCustomer",
                columns: table => new
                {
                    FId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCustomer", x => x.FId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TCustomer");
        }
    }
}
