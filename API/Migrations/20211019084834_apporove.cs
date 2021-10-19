using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class apporove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "RemainQuantity",
                table: "StoreItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedQuantity",
                table: "RequestItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "StoreItemId",
                table: "RequestItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RemainQuantity",
                table: "StoreItems");

            migrationBuilder.DropColumn(
                name: "ApprovedQuantity",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "StoreItemId",
                table: "RequestItems");

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
    }
}
