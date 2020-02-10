using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.WebUI.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([CustomerName],[CustomerLastName],[CustomerPhone],[CustomerEmail],[CustomerStatus],[CustomerCreated])VALUES('Juan','Perez','22222222','juan.perez@test.com',1,getDate())");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([CustomerName],[CustomerLastName],[CustomerPhone],[CustomerEmail],[CustomerStatus],[CustomerCreated])VALUES('Jorge','Benitez','33333333','jorge.benitez@test.com',1,getDate())");
            migrationBuilder.Sql("INSERT INTO [dbo].[Customers]([CustomerName],[CustomerLastName],[CustomerPhone],[CustomerEmail],[CustomerStatus],[CustomerCreated])VALUES('Maria','Lopez','44444444','maria.lopez@test.com',1,getDate())");

            migrationBuilder.Sql("INSERT INTO [dbo].[Products]([ProductName],[Description],[Stock],[ProductCreated],[ProductStatus])VALUES('TV','TV Detail',10,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[Products]([ProductName],[Description],[Stock],[ProductCreated],[ProductStatus])VALUES('Telephone','Telephone Detail',10,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[Products]([ProductName],[Description],[Stock],[ProductCreated],[ProductStatus])VALUES('Internet','Internet Detail',10,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[Products]([ProductName],[Description],[Stock],[ProductCreated],[ProductStatus])VALUES('Cable','Cable Detail',10,getDate(),1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from [dbo].[Customers]");

            migrationBuilder.Sql("delete from [dbo].[Products]");
        }
    }
}
