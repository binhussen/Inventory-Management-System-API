using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class updatedescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f2ef88e-9c96-4ff9-8db9-e9f5ab984db9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3506e0c6-773a-438e-9a20-355621fa2235");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dc5803c-44bd-4a5c-acc2-ee2ee59c6108");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be17b04a-f853-49a1-9ee3-a130cafb025a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c65f9b16-3edb-4b9a-b6c3-6b8a6f062dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d73777b0-f0d9-4070-ae80-84db5b739b0e");

            migrationBuilder.RenameColumn(
                name: "Desciption",
                table: "Companies",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c243a5f7-8826-47cf-a526-7d13d984ee41", "66fe444b-8c7a-4967-b916-17965d1625b5", "Administrator", "ADMINISTRATOR" },
                    { "d2ee57b6-b0f6-4051-9957-2f369a57895c", "8a3eb7ea-e0eb-497e-8f3b-8ec69982c6e4", "Purchaser", "PURCHASER" },
                    { "bd223492-dd4f-4b32-beeb-b0f1d3e93878", "f057bab6-56b4-4f0a-ab7e-2f9e1149c37c", "StoreMan", "STOREMAN" },
                    { "f656125f-bf8a-42c6-8c6b-561b7d9113a4", "4524e808-83c5-4062-bf8a-da3f090daeeb", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "21383867-3b02-47a5-b4d2-d57be8cd156b", "80af7845-f697-4c56-8715-255cfdc63be1", "FinanceManager", "FINANCEMANAGER" },
                    { "a21affca-08c0-4818-8418-7c58281d1743", "cd1247ab-3e83-42bf-9dfc-18b3f6353972", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21383867-3b02-47a5-b4d2-d57be8cd156b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a21affca-08c0-4818-8418-7c58281d1743");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd223492-dd4f-4b32-beeb-b0f1d3e93878");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c243a5f7-8826-47cf-a526-7d13d984ee41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2ee57b6-b0f6-4051-9957-2f369a57895c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f656125f-bf8a-42c6-8c6b-561b7d9113a4");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Companies",
                newName: "Desciption");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be17b04a-f853-49a1-9ee3-a130cafb025a", "0bd4c41e-c338-427d-b69c-1d8a221c5de3", "Administrator", "ADMINISTRATOR" },
                    { "c65f9b16-3edb-4b9a-b6c3-6b8a6f062dad", "2518ed26-9c43-42b8-941f-5ad86e2e51b7", "Purchaser", "PURCHASER" },
                    { "3506e0c6-773a-438e-9a20-355621fa2235", "f5976670-2dce-4f7a-b461-f4f52af46443", "StoreMan", "STOREMAN" },
                    { "d73777b0-f0d9-4070-ae80-84db5b739b0e", "f194c682-bb84-42c5-954e-098f25ef7f16", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "0f2ef88e-9c96-4ff9-8db9-e9f5ab984db9", "76b23b52-f114-4484-ba11-f02715b0ee96", "FinanceManager", "FINANCEMANAGER" },
                    { "6dc5803c-44bd-4a5c-acc2-ee2ee59c6108", "7c0b96a0-fbe6-4c30-b7b2-e9c8511d3fe3", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
