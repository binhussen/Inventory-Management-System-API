using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "RequestItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af69ef81-6f7d-4e31-a590-aa08b3ccdf9d", "ba59cd62-bd35-4a9f-a59b-52c4200c9805", "Administrator", "ADMINISTRATOR" },
                    { "d1f6f84d-06b8-44f2-b156-af50484f3567", "86589978-d403-4f7a-bcb2-3c0b549c8221", "Purchaser", "PURCHASER" },
                    { "e4ae7e7b-9554-46f3-919a-9492577fcd66", "1dbdac15-6f6b-456a-8721-df0ae42ebef3", "StoreMan", "STOREMAN" },
                    { "ab2a7833-902c-49c1-8019-5d8f431cff43", "2ed0d1e9-02e6-455c-834a-490d3a2e6aa2", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "7146b384-0433-4447-bec6-4c5f8e3d896b", "4ad9d258-ce14-4b01-a58b-28ccf6398d67", "FinanceManager", "FINANCEMANAGER" },
                    { "44cf48ff-6568-4c42-84a2-6bff60439f74", "f4cca900-4559-4f8f-97c5-bca74d75a50b", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44cf48ff-6568-4c42-84a2-6bff60439f74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7146b384-0433-4447-bec6-4c5f8e3d896b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab2a7833-902c-49c1-8019-5d8f431cff43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af69ef81-6f7d-4e31-a590-aa08b3ccdf9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f6f84d-06b8-44f2-b156-af50484f3567");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4ae7e7b-9554-46f3-919a-9492577fcd66");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "RequestItems");

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
    }
}
