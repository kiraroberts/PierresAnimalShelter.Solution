using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresAnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Description", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "An orange tabby.", "Male", "Tony", "Cat" },
                    { 2, 10, "A gray terrier mix.", "Female", "Gretchen", "Dog" },
                    { 3, 4, "An orange tabby.", "Male", "Nacho", "Cat" },
                    { 4, 1, "A white mouse.", "Female", "Urusula", "Mouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
