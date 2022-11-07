using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryWithUOW.EF.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Country1" },
                    { 2, "Country2" },
                    { 3, "Country3" },
                    { 4, "Country4" },
                    { 5, "Country5" },
                    { 6, "Country6" },
                    { 7, "Country7" },
                    { 8, "Country8" },
                    { 9, "Country9" },
                    { 10, "Country10" },
                    { 11, "Country11" },
                    { 12, "Country12" },
                    { 13, "Country13" },
                    { 14, "Country14" },
                    { 15, "Country15" },
                    { 16, "Country16" },
                    { 17, "Country17" },
                    { 18, "Country18" },
                    { 19, "Country19" },
                    { 20, "Country20" },
                    { 21, "Country21" },
                    { 22, "Country22" },
                    { 23, "Country23" },
                    { 24, "Country24" },
                    { 25, "Country25" },
                    { 26, "Country26" },
                    { 27, "Country27" },
                    { 28, "Country28" },
                    { 29, "Country29" },
                    { 30, "Country30" },
                    { 31, "Country31" },
                    { 32, "Country32" },
                    { 33, "Country33" },
                    { 34, "Country34" },
                    { 35, "Country35" },
                    { 36, "Country36" },
                    { 37, "Country37" },
                    { 38, "Country38" },
                    { 39, "Country39" },
                    { 40, "Country40" },
                    { 41, "Country41" },
                    { 42, "Country42" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Country43" },
                    { 44, "Country44" },
                    { 45, "Country45" },
                    { 46, "Country46" },
                    { 47, "Country47" },
                    { 48, "Country48" },
                    { 49, "Country49" },
                    { 50, "Country50" },
                    { 51, "Country51" },
                    { 52, "Country52" },
                    { 53, "Country53" },
                    { 54, "Country54" },
                    { 55, "Country55" },
                    { 56, "Country56" },
                    { 57, "Country57" },
                    { 58, "Country58" },
                    { 59, "Country59" },
                    { 60, "Country60" },
                    { 61, "Country61" },
                    { 62, "Country62" },
                    { 63, "Country63" },
                    { 64, "Country64" },
                    { 65, "Country65" },
                    { 66, "Country66" },
                    { 67, "Country67" },
                    { 68, "Country68" },
                    { 69, "Country69" },
                    { 70, "Country70" },
                    { 71, "Country71" },
                    { 72, "Country72" },
                    { 73, "Country73" },
                    { 74, "Country74" },
                    { 75, "Country75" },
                    { 76, "Country76" },
                    { 77, "Country77" },
                    { 78, "Country78" },
                    { 79, "Country79" },
                    { 80, "Country80" },
                    { 81, "Country81" },
                    { 82, "Country82" },
                    { 83, "Country83" },
                    { 84, "Country84" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 85, "Country85" },
                    { 86, "Country86" },
                    { 87, "Country87" },
                    { 88, "Country88" },
                    { 89, "Country89" },
                    { 90, "Country90" },
                    { 91, "Country91" },
                    { 92, "Country92" },
                    { 93, "Country93" },
                    { 94, "Country94" },
                    { 95, "Country95" },
                    { 96, "Country96" },
                    { 97, "Country97" },
                    { 98, "Country98" },
                    { 99, "Country99" },
                    { 100, "Country100" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lang1" },
                    { 2, "Lang2" },
                    { 3, "Lang3" },
                    { 4, "Lang4" },
                    { 5, "Lang5" },
                    { 6, "Lang6" },
                    { 7, "Lang7" },
                    { 8, "Lang8" },
                    { 9, "Lang9" },
                    { 10, "Lang10" },
                    { 11, "Lang11" },
                    { 12, "Lang12" },
                    { 13, "Lang13" },
                    { 14, "Lang14" },
                    { 15, "Lang15" },
                    { 16, "Lang16" },
                    { 17, "Lang17" },
                    { 18, "Lang18" },
                    { 19, "Lang19" },
                    { 20, "Lang20" },
                    { 21, "Lang21" },
                    { 22, "Lang22" },
                    { 23, "Lang23" },
                    { 24, "Lang24" },
                    { 25, "Lang25" },
                    { 26, "Lang26" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 27, "Lang27" },
                    { 28, "Lang28" },
                    { 29, "Lang29" },
                    { 30, "Lang30" },
                    { 31, "Lang31" },
                    { 32, "Lang32" },
                    { 33, "Lang33" },
                    { 34, "Lang34" },
                    { 35, "Lang35" },
                    { 36, "Lang36" },
                    { 37, "Lang37" },
                    { 38, "Lang38" },
                    { 39, "Lang39" },
                    { 40, "Lang40" },
                    { 41, "Lang41" },
                    { 42, "Lang42" },
                    { 43, "Lang43" },
                    { 44, "Lang44" },
                    { 45, "Lang45" },
                    { 46, "Lang46" },
                    { 47, "Lang47" },
                    { 48, "Lang48" },
                    { 49, "Lang49" },
                    { 50, "Lang50" },
                    { 51, "Lang51" },
                    { 52, "Lang52" },
                    { 53, "Lang53" },
                    { 54, "Lang54" },
                    { 55, "Lang55" },
                    { 56, "Lang56" },
                    { 57, "Lang57" },
                    { 58, "Lang58" },
                    { 59, "Lang59" },
                    { 60, "Lang60" },
                    { 61, "Lang61" },
                    { 62, "Lang62" },
                    { 63, "Lang63" },
                    { 64, "Lang64" },
                    { 65, "Lang65" },
                    { 66, "Lang66" },
                    { 67, "Lang67" },
                    { 68, "Lang68" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 69, "Lang69" },
                    { 70, "Lang70" },
                    { 71, "Lang71" },
                    { 72, "Lang72" },
                    { 73, "Lang73" },
                    { 74, "Lang74" },
                    { 75, "Lang75" },
                    { 76, "Lang76" },
                    { 77, "Lang77" },
                    { 78, "Lang78" },
                    { 79, "Lang79" },
                    { 80, "Lang80" },
                    { 81, "Lang81" },
                    { 82, "Lang82" },
                    { 83, "Lang83" },
                    { 84, "Lang84" },
                    { 85, "Lang85" },
                    { 86, "Lang86" },
                    { 87, "Lang87" },
                    { 88, "Lang88" },
                    { 89, "Lang89" },
                    { 90, "Lang90" },
                    { 91, "Lang91" },
                    { 92, "Lang92" },
                    { 93, "Lang93" },
                    { 94, "Lang94" },
                    { 95, "Lang95" },
                    { 96, "Lang96" },
                    { 97, "Lang97" },
                    { 98, "Lang98" },
                    { 99, "Lang99" },
                    { 100, "Lang100" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
