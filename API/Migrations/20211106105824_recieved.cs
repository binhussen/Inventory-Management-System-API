using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class recieved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fbf24c9-dcee-4376-a42d-2f22c006e797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39a16872-c0f4-4611-8b9a-22d0c1779067");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a16b401c-2320-40af-9c9f-dfd336826761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf7bfa49-42b7-49f5-9411-64c5010fa8db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d29ceab7-5733-477e-b97b-f8fe337b80d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65b8fc3-96d9-4d75-b1ca-a216b965f4e3");

            migrationBuilder.RenameColumn(
                name: "QtyRecived",
                table: "StoreItems",
                newName: "QtyReceived");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9901c3a-dde1-4535-8bde-98771dc9f5a8", "d4a5d540-98fe-439c-9e64-4e0e7db1c57a", "Administrator", "ADMINISTRATOR" },
                    { "ddfed3a4-4b75-414b-a0c5-b547a891c85f", "402a725a-041a-4c77-8c24-7c844fc228e0", "Purchaser", "PURCHASER" },
                    { "b3ec3890-cf5f-42ea-ba61-86abc4a035fc", "3604937a-aabb-446d-8eda-baa383f989ab", "StoreMan", "STOREMAN" },
                    { "0c0230d6-af19-4c60-bed5-cb48de32db61", "cf24855e-83b4-4298-b9f4-cc9044ad8d9d", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "84186bcb-9e88-4fbc-9cfb-12c942cf58e7", "287a3d15-b0d0-4d24-b105-bc78d5e2a5d8", "FinanceManager", "FINANCEMANAGER" },
                    { "9d70eacf-a1b0-4380-a328-a62bf30e3fd1", "d5d9931d-25cf-422d-9f15-55010013f74e", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c0230d6-af19-4c60-bed5-cb48de32db61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84186bcb-9e88-4fbc-9cfb-12c942cf58e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d70eacf-a1b0-4380-a328-a62bf30e3fd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9901c3a-dde1-4535-8bde-98771dc9f5a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3ec3890-cf5f-42ea-ba61-86abc4a035fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddfed3a4-4b75-414b-a0c5-b547a891c85f");

            migrationBuilder.RenameColumn(
                name: "QtyReceived",
                table: "StoreItems",
                newName: "QtyRecived");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fbf24c9-dcee-4376-a42d-2f22c006e797", "00d7f89d-fdbf-482b-856b-e6419c6b0df6", "Administrator", "ADMINISTRATOR" },
                    { "cf7bfa49-42b7-49f5-9411-64c5010fa8db", "46fd3857-2006-41a7-a4e8-9f62f874b2c2", "Purchaser", "PURCHASER" },
                    { "39a16872-c0f4-4611-8b9a-22d0c1779067", "5c555b89-def4-451e-a7df-90a8d2aefe01", "StoreMan", "STOREMAN" },
                    { "d29ceab7-5733-477e-b97b-f8fe337b80d7", "504ecc58-3157-4d90-be79-bb3931b9c2e5", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "a16b401c-2320-40af-9c9f-dfd336826761", "9be5b1b4-47c6-4096-b96b-0e2f9e9ed3eb", "FinanceManager", "FINANCEMANAGER" },
                    { "e65b8fc3-96d9-4d75-b1ca-a216b965f4e3", "1b4c7e37-416f-47b7-8b16-eb778c7d06cb", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
