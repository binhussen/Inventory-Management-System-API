using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class requests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrchaseItems_PuschaseHeaders_RequestHeaderId",
                table: "PrchaseItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PuschaseHeaders",
                table: "PuschaseHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrchaseItems",
                table: "PrchaseItems");

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

            migrationBuilder.RenameTable(
                name: "PuschaseHeaders",
                newName: "RequestHeaders");

            migrationBuilder.RenameTable(
                name: "PrchaseItems",
                newName: "RequestItems");

            migrationBuilder.RenameIndex(
                name: "IX_PrchaseItems_RequestHeaderId",
                table: "RequestItems",
                newName: "IX_RequestItems_RequestHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestHeaders",
                table: "RequestHeaders",
                column: "RequestHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestItems",
                table: "RequestItems",
                column: "RequestItemId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RequestItems_RequestHeaders_RequestHeaderId",
                table: "RequestItems",
                column: "RequestHeaderId",
                principalTable: "RequestHeaders",
                principalColumn: "RequestHeaderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestItems_RequestHeaders_RequestHeaderId",
                table: "RequestItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestItems",
                table: "RequestItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestHeaders",
                table: "RequestHeaders");

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

            migrationBuilder.RenameTable(
                name: "RequestItems",
                newName: "PrchaseItems");

            migrationBuilder.RenameTable(
                name: "RequestHeaders",
                newName: "PuschaseHeaders");

            migrationBuilder.RenameIndex(
                name: "IX_RequestItems_RequestHeaderId",
                table: "PrchaseItems",
                newName: "IX_PrchaseItems_RequestHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrchaseItems",
                table: "PrchaseItems",
                column: "RequestItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PuschaseHeaders",
                table: "PuschaseHeaders",
                column: "RequestHeaderId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PrchaseItems_PuschaseHeaders_RequestHeaderId",
                table: "PrchaseItems",
                column: "RequestHeaderId",
                principalTable: "PuschaseHeaders",
                principalColumn: "RequestHeaderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
