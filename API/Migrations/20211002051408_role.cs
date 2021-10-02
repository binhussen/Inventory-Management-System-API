using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a85155d-295e-4e71-b713-ef57b85d8d06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e3dba6c-5e3c-4803-bc77-161fb5baa74d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55957a91-132d-415d-ab04-09b338bb3ee6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa7eb82-d87d-4bef-bfca-d5194a62131d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1a536b3-16b4-43f1-bd8a-af2ef7c60e5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efb083cb-5ec9-48d7-98cf-b2d5b51f741f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7f78184-6024-4976-9498-9a3a304e4efc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ef4908cf-dbb3-44d0-b636-2bb48c5ba437", "f46e8921-8ebe-4cbc-a86b-cde4e7710f2f", "Administrator", "ADMINISTRATOR" },
                    { "dd714947-01a3-4133-b0c7-f6c09d61c904", "f8f39c4f-e5f4-414f-ba1e-4acd355e2d4e", "Purchaser", "PURCHASER" },
                    { "ae4f165c-9e12-466d-bbd9-8ec382ecb88f", "19f7b117-3516-4ecd-8a15-d420d00a54b4", "StoreMan", "STOREMAN" },
                    { "9d3a5c77-7bf0-4384-9f45-699905debf10", "a76797db-b22e-41a0-82b9-253643161dd0", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "c4ba2b5a-4d07-48b2-8637-161d72453c41", "3c1de7a6-978b-4e58-b5fd-2b5e9fc6c32a", "FinanceManager", "FINANCEMANAGER" },
                    { "75eb7914-b53f-410f-b618-e82b2b78220d", "d8d2a846-9583-4a4d-9751-8744890ad0b6", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75eb7914-b53f-410f-b618-e82b2b78220d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3a5c77-7bf0-4384-9f45-699905debf10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae4f165c-9e12-466d-bbd9-8ec382ecb88f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ba2b5a-4d07-48b2-8637-161d72453c41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd714947-01a3-4133-b0c7-f6c09d61c904");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef4908cf-dbb3-44d0-b636-2bb48c5ba437");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e3dba6c-5e3c-4803-bc77-161fb5baa74d", "5311f1d2-ab2a-43c2-8451-8798c060c099", "Manager", "MANAGER" },
                    { "efb083cb-5ec9-48d7-98cf-b2d5b51f741f", "8b7d9f1f-681a-482f-899f-36b5908eecd2", "Administrator", "ADMINISTRATOR" },
                    { "2a85155d-295e-4e71-b713-ef57b85d8d06", "0ab3c6f1-e7ca-44a4-8b45-2a9be14aa8d6", "Requestr", "RequestR" },
                    { "baa7eb82-d87d-4bef-bfca-d5194a62131d", "be9a4953-6567-414e-bfc4-9495fdb7f802", "StoreMan", "STOREMAN" },
                    { "e1a536b3-16b4-43f1-bd8a-af2ef7c60e5a", "734bea12-68ee-4bc5-8724-37128be3dc20", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "55957a91-132d-415d-ab04-09b338bb3ee6", "784ff12e-e0c7-4bac-8294-5f2956b271c8", "FinanceManager", "FINANCEMANAGER" },
                    { "f7f78184-6024-4976-9498-9a3a304e4efc", "fe823e80-cb8c-4c5f-8e78-554c1308bd6f", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
