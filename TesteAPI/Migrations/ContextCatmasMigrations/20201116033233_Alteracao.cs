using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteAPI.Migrations.ContextCatmasMigrations
{
    public partial class Alteracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Item",
            //    schema: "catmas",
            //    table: "Item");

            //migrationBuilder.RenameTable(
            //    name: "Item",
            //    schema: "catmas",
            //    newName: "TB_Item",
            //    newSchema: "catmas");

            //migrationBuilder.AlterColumn<long>(
            //    name: "Sequencial",
            //    schema: "catmas",
            //    table: "TB_Item",
            //    type: "bigint",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_TB_Item",
            //    schema: "catmas",
            //    table: "TB_Item",
            //    column: "Sequencial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_TB_Item",
            //    schema: "catmas",
            //    table: "TB_Item");

            //migrationBuilder.RenameTable(
            //    name: "TB_Item",
            //    schema: "catmas",
            //    newName: "Item",
            //    newSchema: "catmas");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Sequencial",
            //    schema: "catmas",
            //    table: "Item",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(long),
            //    oldType: "bigint")
            //    .Annotation("SqlServer:Identity", "1, 1")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Item",
            //    schema: "catmas",
            //    table: "Item",
            //    column: "Sequencial");
        }
    }
}
