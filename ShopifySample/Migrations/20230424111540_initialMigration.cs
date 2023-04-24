using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopifySample.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shopify_Products",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shopify_Product_Variants",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shopify_ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_Product_Variants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shopify_Product_Variants_Shopify_Products_Shopify_ProductID",
                        column: x => x.Shopify_ProductID,
                        principalTable: "Shopify_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shopify_ProductImages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shopify_ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_ProductImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shopify_ProductImages_Shopify_Products_Shopify_ProductID",
                        column: x => x.Shopify_ProductID,
                        principalTable: "Shopify_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shopify_ProductOptions",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shopify_ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopify_ProductOptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shopify_ProductOptions_Shopify_Products_Shopify_ProductID",
                        column: x => x.Shopify_ProductID,
                        principalTable: "Shopify_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shopify_Product_Variants_Shopify_ProductID",
                table: "Shopify_Product_Variants",
                column: "Shopify_ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Shopify_ProductImages_Shopify_ProductID",
                table: "Shopify_ProductImages",
                column: "Shopify_ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Shopify_ProductOptions_Shopify_ProductID",
                table: "Shopify_ProductOptions",
                column: "Shopify_ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shopify_Product_Variants");

            migrationBuilder.DropTable(
                name: "Shopify_ProductImages");

            migrationBuilder.DropTable(
                name: "Shopify_ProductOptions");

            migrationBuilder.DropTable(
                name: "Shopify_Products");
        }
    }
}
