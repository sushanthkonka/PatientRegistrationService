using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientRegistrationService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marital_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insurance_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Of_Birth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medical_History = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
