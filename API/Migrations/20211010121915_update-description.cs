using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class updatedescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b4f3f14-ad72-4928-bb8f-3e3cfc0e9a96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "440f8117-ec44-404e-8b6e-43eb12a07874");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "510ce613-36b1-4386-a86d-def20a70f27d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "627609be-ff47-466f-8d11-5ac2db3b0cce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deca47a4-09eb-4e93-a63d-df9bf54f102c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecadcc98-8b69-414f-bd56-3a2c93466298");

            migrationBuilder.RenameColumn(
                name: "Discribtion",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "Discribtion");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ecadcc98-8b69-414f-bd56-3a2c93466298", "24286d0f-3a56-490e-9663-8143c126797b", "Administrator", "ADMINISTRATOR" },
                    { "627609be-ff47-466f-8d11-5ac2db3b0cce", "fca84f3a-8cff-4529-a796-51687982c47a", "Purchaser", "PURCHASER" },
                    { "510ce613-36b1-4386-a86d-def20a70f27d", "872171c2-f853-4a57-bf16-d637737424d3", "StoreMan", "STOREMAN" },
                    { "2b4f3f14-ad72-4928-bb8f-3e3cfc0e9a96", "4abd149b-197f-4e93-a622-e9accbe5332f", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "440f8117-ec44-404e-8b6e-43eb12a07874", "4cd2c647-e9df-4303-b529-e20d7f995cd9", "FinanceManager", "FINANCEMANAGER" },
                    { "deca47a4-09eb-4e93-a63d-df9bf54f102c", "f55926f9-ea06-469f-b493-0d985a37f5cd", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
