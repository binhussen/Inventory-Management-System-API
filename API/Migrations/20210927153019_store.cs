using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class store : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f590313-6d67-4385-9bc3-49ada207a18b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb88014b-59c8-438d-92e5-2b0128eaad7d");

            migrationBuilder.CreateTable(
                name: "PuschaseHeaders",
                columns: table => new
                {
                    RequestHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AskedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuschaseHeaders", x => x.RequestHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "StoreHeaders",
                columns: table => new
                {
                    StoreHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReciverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GraNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcceptedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InspectedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreHeaders", x => x.StoreHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "PrchaseItems",
                columns: table => new
                {
                    RequestItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dicription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Use = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    BudgetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrchaseItems", x => x.RequestItemId);
                    table.ForeignKey(
                        name: "FK_PrchaseItems_PuschaseHeaders_RequestHeaderId",
                        column: x => x.RequestHeaderId,
                        principalTable: "PuschaseHeaders",
                        principalColumn: "RequestHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreItems",
                columns: table => new
                {
                    StoreItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemSpecification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    QtyOrdered = table.Column<int>(type: "int", nullable: false),
                    QtyRecived = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    StoreHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItems", x => x.StoreItemId);
                    table.ForeignKey(
                        name: "FK_StoreItems_StoreHeaders_StoreHeaderId",
                        column: x => x.StoreHeaderId,
                        principalTable: "StoreHeaders",
                        principalColumn: "StoreHeaderId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PrchaseItems_RequestHeaderId",
                table: "PrchaseItems",
                column: "RequestHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreItems_StoreHeaderId",
                table: "StoreItems",
                column: "StoreHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrchaseItems");

            migrationBuilder.DropTable(
                name: "StoreItems");

            migrationBuilder.DropTable(
                name: "PuschaseHeaders");

            migrationBuilder.DropTable(
                name: "StoreHeaders");

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
                values: new object[] { "bb88014b-59c8-438d-92e5-2b0128eaad7d", "cfe196f7-2105-402a-871b-95fb81f0695c", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f590313-6d67-4385-9bc3-49ada207a18b", "d38fcc37-9a31-4702-a0a3-9c0ef6ef82ae", "Administrator", "ADMINISTRATOR" });
        }
    }
}
