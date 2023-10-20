using Microsoft.EntityFrameworkCore.Migrations;

namespace TshirtChallenge.Infra.Seeds
{
    public class TypeSeed
    {
        public void InsertData(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Color", "Fabric", "TshirtId", "CreatedAt", "Deleted" },
                values: new object[,]
                {
                    { Guid.Parse("9dc6caaf-b2c3-4959-9867-d8d03ec716b4"), "Black", "Cotton", Guid.Parse("68cc4216-60c1-455e-a74e-c21b5bfe78f6"), "2023-10-20 12:00:00", false },
                    { Guid.Parse("cec79bb6-244d-4db4-a0bc-4376aee5dba5"), "White", "Linen", Guid.Parse("68cc4216-60c1-455e-a74e-c21b5bfe78f6"), "2023-10-20 12:00:00", false },
                    { Guid.Parse("0262d1d5-73b2-4052-9857-b5bc3da18dd4"), "Grey", "Silk", Guid.Parse("68cc4216-60c1-455e-a74e-c21b5bfe78f6"), "2023-10-20 12:00:00", false },

                    { Guid.Parse("c21f0a9b-60d3-4fec-b429-59504a41aeae"), "Black", "Cotton", Guid.Parse("93df55a1-a0e8-4fa2-a044-5e0224fba931"), "2023-10-20 12:00:00", false },
                    { Guid.Parse("c7558537-d1a4-4103-b9e4-e9fa62590824"), "Red", "Cotton", Guid.Parse("93df55a1-a0e8-4fa2-a044-5e0224fba931"), "2023-10-20 12:00:00", false },

                    { Guid.Parse("83ebc730-0850-45c9-aaca-128d5d255b6c"), "Blue", "Silk", Guid.Parse("9917758a-d96f-4f8b-9dbe-15fd43226087"), "2023-10-20 12:00:00", false },
                });
        }
    }
}
