using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class request : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00509cea-78d7-4b9c-b819-3bb373ac2fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "013a18ae-5590-47ab-8af5-39cdb0c0793d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b509329-bb80-444c-8b72-67d42f563a1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65e30576-ec66-446a-b5e7-d111b2c4fc19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81b82d0e-3fa0-479a-bf12-06674aa39871");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d088cf2f-7dd5-4ab5-88d2-36ac3f06f035");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddccb4b6-ef1b-4173-b079-9473681e7cf5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f32f2e0b-22bf-4495-8fff-917f68f772ca", "1382245a-8a3d-4fa0-971d-01c5cd43aac1", "Manager", "MANAGER" },
                    { "05afa4e0-14a5-44f3-b053-2f1402d9fb15", "f8744080-2772-49aa-b052-2aef0c15b36f", "Administrator", "ADMINISTRATOR" },
                    { "53bfd0f2-a516-4151-bc43-0647fc96a5b6", "e624857b-06b8-4212-b1e4-928a249ceee1", "Requestr", "RequestR" },
                    { "b1c24b5a-a67f-4827-80f2-7881167de3c3", "fca8e06a-b50f-4b7e-817d-c4b1ce71c912", "StoreMan", "STOREMAN" },
                    { "c546790b-6061-488b-a7f0-67f1d22e8f0e", "47b111a2-3b66-4d62-aa76-ab1d1fb7f3a5", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "3f74c9f3-05d0-4213-ae23-7f35991a9843", "29206c4a-7e4b-44fc-9869-b212220c48a2", "FinanceManager", "FINANCEMANAGER" },
                    { "55cacd4e-e903-4b6e-87ab-a31b4e732ef2", "a91956ea-7298-4fce-99d2-efb537154a51", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05afa4e0-14a5-44f3-b053-2f1402d9fb15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f74c9f3-05d0-4213-ae23-7f35991a9843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53bfd0f2-a516-4151-bc43-0647fc96a5b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55cacd4e-e903-4b6e-87ab-a31b4e732ef2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1c24b5a-a67f-4827-80f2-7881167de3c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c546790b-6061-488b-a7f0-67f1d22e8f0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f32f2e0b-22bf-4495-8fff-917f68f772ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ddccb4b6-ef1b-4173-b079-9473681e7cf5", "0b266759-d917-4df1-bef2-64b069bea5cb", "Manager", "MANAGER" },
                    { "d088cf2f-7dd5-4ab5-88d2-36ac3f06f035", "a230f800-0bca-4221-920b-00d25b992a12", "Administrator", "ADMINISTRATOR" },
                    { "00509cea-78d7-4b9c-b819-3bb373ac2fe0", "156d3d25-6dcd-4fa8-8bb4-a138ef6c1706", "Requestr", "RequestR" },
                    { "81b82d0e-3fa0-479a-bf12-06674aa39871", "2b76944c-7e01-4a8a-b1c9-d23696eee52e", "StoreMan", "STOREMAN" },
                    { "65e30576-ec66-446a-b5e7-d111b2c4fc19", "481c5c92-515b-4466-955f-ecf4b83ffb43", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "4b509329-bb80-444c-8b72-67d42f563a1b", "537cdff5-e9a3-46aa-bf28-2dbef2b212f3", "FinanceManager", "FINANCEMANAGER" },
                    { "013a18ae-5590-47ab-8af5-39cdb0c0793d", "922ba989-390e-4983-9cb1-5dc5944bdd62", "ProcurementManager", "PROCUREMENTMANAGER" }
                });
        }
    }
}
