using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.WebUI.Migrations
{
    public partial class AddCustomerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(1,1,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(2,1,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(3,1,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(2,2,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(3,2,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(1,3,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(2,1,getDate(),1)");
            migrationBuilder.Sql("INSERT INTO [dbo].[CustomerOrders]([ProductId],[CustomerId],[OrderCreated],[OrderStatus]) VALUES(3,1,getDate(),1)");            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from [dbo].[CustomerOrders]");
        }
    }
}
