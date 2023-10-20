using Microsoft.EntityFrameworkCore.Migrations;

namespace TshirtChallenge.Infra.Seeds
{
    public class TshirtSeed
    {
        public void InsertData(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tshirts",
                columns: new[] { "Id", "Name", "CreatedAt", "Deleted" },
                values: new object[,]
                {
                    { Guid.Parse("93df55a1-a0e8-4fa2-a044-5e0224fba931"), "Star Wars T-Shirt", "2023-10-20 12:00:00", false },
                    { Guid.Parse("68cc4216-60c1-455e-a74e-c21b5bfe78f6"), "Demon Slayer T-Shirt", "2023-10-20 12:00:00", false },
                    { Guid.Parse("9917758a-d96f-4f8b-9dbe-15fd43226087"), "Attack on Titan T-Shirt", "2023-10-20 12:00:00", false },
                });
        }
    }
}
