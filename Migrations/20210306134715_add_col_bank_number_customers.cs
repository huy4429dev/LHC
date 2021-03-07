using Microsoft.EntityFrameworkCore.Migrations;

namespace DVN.Migrations
{
    public partial class add_col_bank_number_customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankNumber",
                table: "Customers",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankNumber",
                table: "Customers");
        }
    }
}
