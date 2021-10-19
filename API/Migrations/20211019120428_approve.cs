using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class approve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d5eada3-3885-4283-b3c7-6098dce2a7f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44a40775-e3c4-42e3-86ff-0a06b8bf4726");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48bf027b-b94b-4458-9d2d-acbae3ca911d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d56af3c-d918-40ec-99de-0cd09727b87f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97d3f740-04e9-4cd9-a210-b9f822b70446");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c587024b-b5e5-4025-8ae3-b002dca358f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33c36851-0b83-452b-958e-aa7e3aa94b68", "588c39c8-f06f-443c-83e5-d1cfb4db74cc", "Administrator", "ADMINISTRATOR" },
                    { "b96826b3-93ce-4198-b2d1-7b17d800c383", "f50fee06-d89e-4c5e-9906-a00e9bb2993e", "Purchaser", "PURCHASER" },
                    { "5b8ca985-da25-45be-a0d8-0f044ea263b0", "330ccc4e-c3d9-4d6f-84cb-a8e375cc13fb", "StoreMan", "STOREMAN" },
                    { "fc0c9aa7-3722-4dda-989a-19de1e59558a", "b84904be-460b-4196-a34e-a793c40b9df5", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "3cd88934-a1fa-4ac3-baa7-21d220154057", "a9f34084-2275-412b-8767-79c4e64daf25", "FinanceManager", "FINANCEMANAGER" },
                    { "57f7ee13-8d24-4807-9708-929bfbcac5f0", "dd704767-b53b-4559-bc81-db2554c94c25", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33c36851-0b83-452b-958e-aa7e3aa94b68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cd88934-a1fa-4ac3-baa7-21d220154057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57f7ee13-8d24-4807-9708-929bfbcac5f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b8ca985-da25-45be-a0d8-0f044ea263b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b96826b3-93ce-4198-b2d1-7b17d800c383");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0c9aa7-3722-4dda-989a-19de1e59558a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c587024b-b5e5-4025-8ae3-b002dca358f5", "1ee26d50-d200-4f5e-a24c-78b688607af4", "Administrator", "ADMINISTRATOR" },
                    { "0d5eada3-3885-4283-b3c7-6098dce2a7f2", "f4dd2513-e4de-423f-8fae-d0f08e144bb2", "Purchaser", "PURCHASER" },
                    { "44a40775-e3c4-42e3-86ff-0a06b8bf4726", "83d7d16c-4251-4488-8ad3-6c90a0ab98c5", "StoreMan", "STOREMAN" },
                    { "48bf027b-b94b-4458-9d2d-acbae3ca911d", "58e265f8-32bf-4073-ba6c-356ca060e5aa", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "97d3f740-04e9-4cd9-a210-b9f822b70446", "1d638897-aa6f-4e18-9141-6ec9da96d875", "FinanceManager", "FINANCEMANAGER" },
                    { "5d56af3c-d918-40ec-99de-0cd09727b87f", "e93fbfac-5e7a-4dd6-a127-8d9deed019ca", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
