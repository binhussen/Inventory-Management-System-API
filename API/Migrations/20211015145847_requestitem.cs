using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class requestitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Qty",
                table: "RequestItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Dicription",
                table: "RequestItems",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b50ba110-210d-4b25-9128-e704f7cd038c", "f7c88fb9-d78a-4b31-9590-fcfd6cc5d3a2", "Administrator", "ADMINISTRATOR" },
                    { "33daaefb-053d-4534-964f-fc21dc6e2f1c", "63c0b312-6024-4fbb-a06c-10bf61d22cef", "Purchaser", "PURCHASER" },
                    { "fac595e1-2316-45fb-b9f3-3ccb45833337", "93de7933-b0c6-4735-8510-a616dc921814", "StoreMan", "STOREMAN" },
                    { "c6ea3b33-b335-47b4-a422-3ef6582d454c", "4a92e026-98d1-4338-b382-99552e1c207c", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "df52191a-0f6b-43c8-ade9-da06014df95f", "c5d511c6-17b9-4623-9bad-9dced9484fcb", "FinanceManager", "FINANCEMANAGER" },
                    { "1d39e678-7604-46b0-a6a8-80f7ef625dfd", "fbfe5e3a-71ee-43da-a85a-623dce5dbeb8", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d39e678-7604-46b0-a6a8-80f7ef625dfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33daaefb-053d-4534-964f-fc21dc6e2f1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50ba110-210d-4b25-9128-e704f7cd038c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6ea3b33-b335-47b4-a422-3ef6582d454c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df52191a-0f6b-43c8-ade9-da06014df95f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fac595e1-2316-45fb-b9f3-3ccb45833337");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "RequestItems",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "RequestItems",
                newName: "Dicription");

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
    }
}
