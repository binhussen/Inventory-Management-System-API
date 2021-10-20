using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class finish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "239f7ea7-53e6-4415-beeb-33d98b59b731");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76e93672-b323-40f1-a17e-ab135d6d6656");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d27dd72-0b3f-48af-b03b-d469cf3ce851");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5537d12-1d55-43a3-a5ea-4926aa3f4b6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7f5c3ab-6bc1-409d-8a6c-c5f5a7ed5592");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d05e087a-fdc9-4903-9196-ed56b41f567c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24d613e8-c1cc-4064-af1c-ead99cb3e580", "33cc57c6-5e7b-480a-8c75-616aede09930", "Administrator", "ADMINISTRATOR" },
                    { "7b86485b-db69-4955-bf83-e97cebfc23ba", "b281acc0-bd4f-4588-92e2-e60be31a503d", "Purchaser", "PURCHASER" },
                    { "93855cb8-3c98-45a6-8604-f56883a752cb", "1047556a-75fa-4d64-bac8-1b218871c582", "StoreMan", "STOREMAN" },
                    { "0ce8acf5-da74-4ad8-b5c6-7204444313a3", "b2329e88-1da3-4cdf-a833-66e6de5e3d3d", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "62c3ca30-8d7f-412c-b0ef-57a0d86eb0d9", "429d11a2-4d7b-41a1-b580-fcc8e4a5f8d1", "FinanceManager", "FINANCEMANAGER" },
                    { "e7c47599-e93a-41ff-b7c6-07bd8c7cdbc1", "8d07d5b2-fb02-40f3-bbde-c647784ff782", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ce8acf5-da74-4ad8-b5c6-7204444313a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d613e8-c1cc-4064-af1c-ead99cb3e580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62c3ca30-8d7f-412c-b0ef-57a0d86eb0d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b86485b-db69-4955-bf83-e97cebfc23ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93855cb8-3c98-45a6-8604-f56883a752cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7c47599-e93a-41ff-b7c6-07bd8c7cdbc1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "239f7ea7-53e6-4415-beeb-33d98b59b731", "7d285888-622a-49c3-b405-54410dd151eb", "Administrator", "ADMINISTRATOR" },
                    { "a5537d12-1d55-43a3-a5ea-4926aa3f4b6f", "36d973d4-1d3f-4883-9972-1ab932e2365f", "Purchaser", "PURCHASER" },
                    { "76e93672-b323-40f1-a17e-ab135d6d6656", "99c145c5-a4b9-4183-94ad-bfc827c39796", "StoreMan", "STOREMAN" },
                    { "d05e087a-fdc9-4903-9196-ed56b41f567c", "0b02202c-2ac0-458e-b38b-43b2fb1ea051", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "c7f5c3ab-6bc1-409d-8a6c-c5f5a7ed5592", "8c1ab39f-5cad-48db-955e-3324b4a9d07e", "FinanceManager", "FINANCEMANAGER" },
                    { "7d27dd72-0b3f-48af-b03b-d469cf3ce851", "5a168349-d9d6-4e7f-ac9f-0640bfe41c42", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
