using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class report : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b1a17b-6959-402c-bc94-8fa5be8013c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f2d9255-9910-47d1-b063-9f11272f03a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ac00fc1-f248-4e80-b5db-ac6fd2d9ea64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b351b3e5-cf3c-4c0b-af70-14ca110b2cde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbbda86d-0e9a-416a-9e9b-f9d9b6305f58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecdd3b09-b9e5-447c-b7c3-40d4b89d7170");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb84a19b-a060-4a14-9e74-d6c0ebb89e49");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemeberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalSaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeCarSaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeSaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarSaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseLoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurntoShare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LostBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lejar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wisdrowal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemeberOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd5614d1-d4cf-4018-8a2c-1a95c9b1dfce", "3cd3a032-114b-4d0e-ab2b-77b683db187a", "Administrator", "ADMINISTRATOR" },
                    { "6bb73dab-68ef-45c7-97cc-d18753654de6", "78668535-4f46-4e84-b05f-fe3f5a79ff08", "Purchaser", "PURCHASER" },
                    { "3b7a1657-5702-491b-b883-d55a5205f7fe", "5c5e7f49-6b55-42ad-9338-5c63054f45c3", "StoreMan", "STOREMAN" },
                    { "d060dcd6-b089-408d-a65d-9598d29a93b8", "01e1e236-6626-443a-b138-398563b5b290", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "a8ce2055-1d64-4bf0-a69c-11e6f2cbddf5", "902dd281-6bf7-47a8-9071-15bf3934560f", "FinanceManager", "FINANCEMANAGER" },
                    { "db6d76ba-3e37-4922-9469-a0b468822816", "14b0a364-8d8b-43ce-9954-6550402e3ce9", "ProcurementManager", "PROCUREMENTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2a4b36a9-d8bb-43ed-acb0-444003d23a98", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b7a1657-5702-491b-b883-d55a5205f7fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb73dab-68ef-45c7-97cc-d18753654de6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8ce2055-1d64-4bf0-a69c-11e6f2cbddf5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d060dcd6-b089-408d-a65d-9598d29a93b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db6d76ba-3e37-4922-9469-a0b468822816");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd5614d1-d4cf-4018-8a2c-1a95c9b1dfce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a4b36a9-d8bb-43ed-acb0-444003d23a98");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dbbda86d-0e9a-416a-9e9b-f9d9b6305f58", "28d614fa-93ba-4838-a813-9213368f74db", "Administrator", "ADMINISTRATOR" },
                    { "b351b3e5-cf3c-4c0b-af70-14ca110b2cde", "ed3f1fb3-db6a-426a-928b-c0ecf42cb534", "Purchaser", "PURCHASER" },
                    { "45b1a17b-6959-402c-bc94-8fa5be8013c7", "1f8364c3-12fe-4b95-8cf9-7b627be83056", "StoreMan", "STOREMAN" },
                    { "8ac00fc1-f248-4e80-b5db-ac6fd2d9ea64", "8610dafa-f276-4c6e-ae10-0184ac193930", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "ecdd3b09-b9e5-447c-b7c3-40d4b89d7170", "609f22ae-3be4-40ce-b632-db5d5c18dc9a", "FinanceManager", "FINANCEMANAGER" },
                    { "4f2d9255-9910-47d1-b063-9f11272f03a3", "26887660-acae-49b2-b277-5f5ba03086c3", "ProcurementManager", "PROCUREMENTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb84a19b-a060-4a14-9e74-d6c0ebb89e49", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }
    }
}
