using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class remain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "081db2e8-7517-46c5-b234-532c691ccd58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fa25baa-eecb-4b83-a9f6-e41def8e7725");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28971e07-6c4e-40df-910f-057fc9d0cd5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34a17897-a123-4ecd-931b-6716ee46e4bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f416b2c2-078d-40c2-8c38-22426bd2a141");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb9acd3a-83a3-4f27-b441-540406a1a313");

            migrationBuilder.RenameColumn(
                name: "RemainQuantity",
                table: "StoreItems",
                newName: "QtyRemain");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "QtyRemain",
                table: "StoreItems",
                newName: "RemainQuantity");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28971e07-6c4e-40df-910f-057fc9d0cd5b", "20b712a4-7a3c-4df3-b937-9ac3b0d3d72f", "Administrator", "ADMINISTRATOR" },
                    { "0fa25baa-eecb-4b83-a9f6-e41def8e7725", "af26d15e-c17c-4846-9c15-a175feded6a0", "Purchaser", "PURCHASER" },
                    { "fb9acd3a-83a3-4f27-b441-540406a1a313", "9ea8b1a1-98b7-4643-a560-52f7d3749439", "StoreMan", "STOREMAN" },
                    { "34a17897-a123-4ecd-931b-6716ee46e4bc", "effa7194-1c31-48ec-a3d8-d625048a32d6", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "f416b2c2-078d-40c2-8c38-22426bd2a141", "60af1af4-cc13-4946-a3de-49735956deeb", "FinanceManager", "FINANCEMANAGER" },
                    { "081db2e8-7517-46c5-b234-532c691ccd58", "a89806b0-d457-41b4-b2f1-0ea2ace31d00", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
