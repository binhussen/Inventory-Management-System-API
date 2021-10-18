using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class storestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "StoreItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "85a47be8-3d6b-464b-8b01-72c4eea49397", "e0779d75-bea5-4a24-89a4-b5c43a7bca1a", "Administrator", "ADMINISTRATOR" },
                    { "3b13210e-a630-4b4f-8afd-ad38fa40f016", "2d60f5cf-6111-442b-aab6-0af8daad2054", "Purchaser", "PURCHASER" },
                    { "f83d52c0-96a1-4c5d-94f0-2787b4700a93", "fc0c83f2-9ac4-495f-a470-35c2b1b7e605", "StoreMan", "STOREMAN" },
                    { "7c88cd02-d23c-4997-9c13-1879f379c8bc", "3cc156e2-0f63-4a2e-b485-65560351e6b7", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "ba78bd69-3b7d-43f6-b73a-33759245e64a", "0ab16e60-6d27-4e2b-aa4e-a32fa35594f5", "FinanceManager", "FINANCEMANAGER" },
                    { "050051e2-1547-4832-a49b-e9f5d8568f3f", "4fe03599-3a34-4b51-9e6b-d9a212e72384", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "050051e2-1547-4832-a49b-e9f5d8568f3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b13210e-a630-4b4f-8afd-ad38fa40f016");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c88cd02-d23c-4997-9c13-1879f379c8bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85a47be8-3d6b-464b-8b01-72c4eea49397");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba78bd69-3b7d-43f6-b73a-33759245e64a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f83d52c0-96a1-4c5d-94f0-2787b4700a93");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "StoreItems");

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
    }
}
