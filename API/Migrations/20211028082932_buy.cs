using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class buy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d7c3c3f-726e-4e50-9090-0116f837b721");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e00bf4b-a4d9-4e5a-b71e-dfa65da223c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a009e38-e095-4f59-876a-c5a37f1c56c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "851a1039-cdc3-4065-8392-f74f0ff833d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca3d099-172c-4e70-92ef-bbe3a2a2992e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e642bd6a-6fef-4594-89ae-4b3c52e791ee");

            migrationBuilder.RenameColumn(
                name: "RejectDate",
                table: "RequestItems",
                newName: "BuyDate");

            migrationBuilder.RenameColumn(
                name: "RejectBy",
                table: "RequestItems",
                newName: "BuyBy");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee8ecc2b-c819-464c-a593-50ae78296396", "a81e5828-9a02-4630-8cc3-a2022002d670", "Administrator", "ADMINISTRATOR" },
                    { "e0e86b6d-ca7b-4873-865a-e5b9dcfb8e1e", "3093867c-6953-4724-88cd-1573905c725d", "Purchaser", "PURCHASER" },
                    { "753a6b4c-befd-44b0-8f1e-4080512124e4", "d5bafe2f-e1d0-4a50-8bf4-30d2aa8aab90", "StoreMan", "STOREMAN" },
                    { "0136bc41-82fd-44a9-83d8-bf3944aa90b5", "dc72e13d-5ce4-45b2-b8bd-7dae668477e1", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "38053954-d894-4e27-a595-5828f11a748e", "db84052c-77e4-4ff6-8de6-a5bff0336ee2", "FinanceManager", "FINANCEMANAGER" },
                    { "ece416d0-f36c-41ed-b092-98328b96761c", "e85b04a9-b30e-4579-9862-cbea46567db9", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0136bc41-82fd-44a9-83d8-bf3944aa90b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38053954-d894-4e27-a595-5828f11a748e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "753a6b4c-befd-44b0-8f1e-4080512124e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0e86b6d-ca7b-4873-865a-e5b9dcfb8e1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ece416d0-f36c-41ed-b092-98328b96761c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee8ecc2b-c819-464c-a593-50ae78296396");

            migrationBuilder.RenameColumn(
                name: "BuyDate",
                table: "RequestItems",
                newName: "RejectDate");

            migrationBuilder.RenameColumn(
                name: "BuyBy",
                table: "RequestItems",
                newName: "RejectBy");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d7c3c3f-726e-4e50-9090-0116f837b721", "09a59ff5-5666-4ebb-843f-b16a686dd693", "Administrator", "ADMINISTRATOR" },
                    { "3a009e38-e095-4f59-876a-c5a37f1c56c9", "0374532d-9b49-4dfd-b7eb-a38d4ea0abe2", "Purchaser", "PURCHASER" },
                    { "851a1039-cdc3-4065-8392-f74f0ff833d9", "cef8f178-9f55-432a-92ea-314d183cdc02", "StoreMan", "STOREMAN" },
                    { "e642bd6a-6fef-4594-89ae-4b3c52e791ee", "9bc3cd1f-8e55-4772-9af4-0855c6238c1d", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "0e00bf4b-a4d9-4e5a-b71e-dfa65da223c8", "42147f86-e868-49a9-99b7-71b2c2213552", "FinanceManager", "FINANCEMANAGER" },
                    { "bca3d099-172c-4e70-92ef-bbe3a2a2992e", "f286084b-bb79-44e2-8148-da73e9415e71", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
