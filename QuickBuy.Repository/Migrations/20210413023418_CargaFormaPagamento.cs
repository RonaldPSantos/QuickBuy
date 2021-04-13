using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repository.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Não definido", "Não definido" },
                    { 2, "Boleto", "Pagamento Boleto" },
                    { 3, "Cartão", "Pagamento Cartão" },
                    { 4, "Depósito", "Pagamento Depósito" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
