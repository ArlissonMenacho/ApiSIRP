using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteAPI.Migrations
{
    public partial class InicialProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Item",
            //    schema: "catmas");
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "catmas");

            //migrationBuilder.CreateTable(
            //    name: "Item",
            //    schema: "catmas",
            //    columns: table => new
            //    {
            //        Sequencial = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DescricaoBasica = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Item", x => x.Sequencial);
            //    });
        }
    }
}
