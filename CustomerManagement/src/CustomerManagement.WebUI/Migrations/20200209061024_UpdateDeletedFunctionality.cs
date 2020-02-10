using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.WebUI.Migrations
{
    public partial class UpdateDeletedFunctionality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CustomerOrders",
                table: "CustomerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_CustomerOrder",
                table: "CustomerOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CustomerOrders",
                table: "CustomerOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CustomerOrder",
                table: "CustomerOrders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CustomerOrders",
                table: "CustomerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_CustomerOrder",
                table: "CustomerOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CustomerOrders",
                table: "CustomerOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CustomerOrder",
                table: "CustomerOrders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
