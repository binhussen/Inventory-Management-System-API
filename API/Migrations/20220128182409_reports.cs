using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class reports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "CarSaving",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CloseLoan",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "HomeCarSaving",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "HomeSaving",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Interest",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Lejar",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "LostBook",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "MemeberOut",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "NormalSaving",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "TurntoShare",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "Wisdrowal",
                table: "Reports",
                newName: "Service");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37e66356-f7a6-469b-a3cd-4ec10bfb4075", "bad7aecd-3687-4cb6-8ff5-022e52b0a298", "Administrator", "ADMINISTRATOR" },
                    { "2d436ef4-eb26-47e2-acf9-7756f5d91d82", "083f31ee-2bd8-48ea-9c8f-4ee05fe203c6", "Purchaser", "PURCHASER" },
                    { "85020a3d-7615-44de-9817-615a7939152b", "f23c5c51-3199-4761-bbf0-8047c792c2ae", "StoreMan", "STOREMAN" },
                    { "7dbdc624-690d-458f-8583-dd3bfd74283d", "0fee25f4-82b2-4fd5-bacc-d42c30c2710f", "DepartmentHead", "DEPARTMENTHEAD" },
                    { "e0a657f5-9bed-4ad1-b979-b1a605c38243", "4b787a5e-9dd9-4687-9527-92ca05bc6b2d", "FinanceManager", "FINANCEMANAGER" },
                    { "38d7e7aa-0b5a-4925-bdac-e7573a9ce74c", "25b5ec59-8be6-4477-935c-e2946c5737af", "ProcurementManager", "PROCUREMENTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsEnabled", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "80313c3a-e55e-465f-9679-993a0d7f3544", 0, "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15", "admin@gmail.com", false, "Administrator", true, "Administrator", true, null, "ADMIN@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==", "+251-944-69-69-69", false, "AX4V5FQG663Z44N46VMUANNWRVJRMFHW", false, "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d436ef4-eb26-47e2-acf9-7756f5d91d82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37e66356-f7a6-469b-a3cd-4ec10bfb4075");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38d7e7aa-0b5a-4925-bdac-e7573a9ce74c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dbdc624-690d-458f-8583-dd3bfd74283d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85020a3d-7615-44de-9817-615a7939152b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a657f5-9bed-4ad1-b979-b1a605c38243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80313c3a-e55e-465f-9679-993a0d7f3544");

            migrationBuilder.RenameColumn(
                name: "Service",
                table: "Reports",
                newName: "Wisdrowal");

            migrationBuilder.AddColumn<string>(
                name: "CarSaving",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CloseLoan",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeCarSaving",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeSaving",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interest",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lejar",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LostBook",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemeberOut",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalSaving",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TurntoShare",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
