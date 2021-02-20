using Microsoft.EntityFrameworkCore.Migrations;

namespace DVN.Migrations
{
    public partial class update_orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders"
            );

            migrationBuilder.AddColumn<byte>(
                name: "Status",
                table: "Orders",
                nullable: false
         );

            migrationBuilder.AddColumn<int>(
                name: "UserverifyId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserverifyId",
                table: "Orders",
                column: "UserverifyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserverifyId",
                table: "Orders",
                column: "UserverifyId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserverifyId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserverifyId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserverifyId",
                table: "Orders");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Orders",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(byte));
        }
    }
}
