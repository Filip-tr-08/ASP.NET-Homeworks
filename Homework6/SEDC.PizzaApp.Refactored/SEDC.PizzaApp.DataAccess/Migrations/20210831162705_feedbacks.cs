using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.PizzaApp.DataAccess.Migrations
{
    public partial class feedbacks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name" },
                values: new object[] { 1, "guest1@yahoo.com", "Hello this is feedback from message from user 1", "filip" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name" },
                values: new object[] { 2, "guest1@yahoo.com", "Hello this is feedback from user 2", "ivana" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
