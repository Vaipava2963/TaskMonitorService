using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingServices.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippedDate",
                table: "ShippingItems",
                newName: "ItemShippedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemShippedDate",
                table: "ShippingItems",
                newName: "ShippedDate");
        }
    }
}
