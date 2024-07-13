using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace category.CatData.migrations
{
    /// <inheritdoc />
    public partial class InitalCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cat_Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cat_Name = table.Column<string>(type: "TEXT", nullable: false),
                    cat_type = table.Column<string>(type: "TEXT", nullable: false),
                    cat_des = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cat_Table", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cat_Table");
        }
    }
}
