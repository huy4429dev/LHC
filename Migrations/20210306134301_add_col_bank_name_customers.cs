using Microsoft.EntityFrameworkCore.Migrations;

namespace DVN.Migrations
{
    public partial class add_col_bank_name_customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BankNumber",
                table: "Customers",
                newName: "BankName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BankName",
                table: "Customers",
                newName: "BankNumber");
        }
    }
}
