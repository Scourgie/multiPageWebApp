using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace multiPageAdolfson.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Name", "address", "note", "phoneNumber" },
                values: new object[,]
                {
                    { 1, "Antony Adolfson", "123 Main Street", "Example of additional information", 1234567890L },
                    { 2, "Brindle", "456 Harvest Rd", "An amazing cat.", 1111111111L },
                    { 3, "VooDoo", "789 Best Cat Ave", "Fat, and a little troublemaker.", 4564654566L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
