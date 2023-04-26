using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.CheckConstraint("CK_Email", "[Email] LIKE '%@%.%'");
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "jeremy.bazin@email.com", "Jeremy", "Bazin", "Test123=" },
                    { 2, "bob.martin@email.com", "Bob", "Martin", "5Gh#zBvKw3PxYrE" },
                    { 3, "charlie.nguyen@email.com", "Charlie", "Nguyen", "fT7#eRm2QxLz9Dy$" },
                    { 4, "david.lee@email.com", "David", "Lee", "V6b$UwPcNz @hM8xK" },
                    { 5, "emma.garcia@email.com", "Emma", "Garcia", "aH5%kXjL9$qBm2W" },
                    { 6, "frank.chen@email.com", "Frank", "Chen", "qJ9@fM8cWu5$xLrE" },
                    { 7, "grace.wong@email.com", "Grace", "Wong", "7Km&zRb#vGy2hNj" },
                    { 8, "henry.zhang@email.com", "Henry", "Zhang", "T4c#nSv@wGj2RkF" },
                    { 9, "isabella.lopez@email.com", "Isabella", "Lopez", "H8f$kL3q#sVp9Xy" },
                    { 10, "jack.kim@email.com", "Jack", "Kim", "3ZgY*6tLx#pVfDhN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
