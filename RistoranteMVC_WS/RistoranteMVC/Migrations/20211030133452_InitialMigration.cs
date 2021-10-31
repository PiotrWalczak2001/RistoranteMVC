using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RistoranteMVC.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kcal = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recommended = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_Dishes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6", "0e58aecc-e646-4ac9-aa1b-30b394b5ad8b", "Admin", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "D174C90E-6C1D-452C-B91F-CA39C112B73E", 0, "4c33c472-3703-4baf-95bd-8980ce368de5", "admin@mail.com", true, "Janeczek", "Adminowy", false, null, "ADMIN@MAIL.COM", "JANECZEK", "AQAAAAEAACcQAAAAEMNDTvZPNYq01BZgw0OVjd7AlSzcAdgvkdNBTPMOMU/bWIicpdxHcGHdituW0lC3lw==", null, false, "4bb0b0d4-3774-4852-9002-367993eaf9ee", false, "Janeczek" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Pizzas" },
                    { new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Pastas" },
                    { new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Soups" },
                    { new Guid("10895537-2732-403b-87dc-047ec2535593"), "Desserts" },
                    { new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "BirthDate", "City", "Email", "FirstName", "Gender", "HireDate", "JobRole", "LastName", "PhoneNumber", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("343c45aa-6f76-4e21-a855-4b5c3ad9d2ab"), "Konopnicka 15", new DateTime(2021, 10, 30, 15, 34, 52, 54, DateTimeKind.Local).AddTicks(62), "Cracov", "jan@mail.com", "Jan", "Male", new DateTime(2021, 10, 30, 15, 34, 52, 57, DateTimeKind.Local).AddTicks(5112), "Cook", "Fajny", "111222333", "32-200" },
                    { new Guid("a089f74d-8169-45ab-9acd-3c32c56e190a"), "Rydla 59", new DateTime(2021, 10, 30, 15, 34, 52, 57, DateTimeKind.Local).AddTicks(5647), "Cracov", "ben@mail.com", "Ben", "Male", new DateTime(2021, 10, 30, 15, 34, 52, 57, DateTimeKind.Local).AddTicks(5659), "Driver", "Kierwoca", "444222333", "32-200" },
                    { new Guid("d16820d4-56d2-43e7-b786-010927874b93"), "Pawia 5", new DateTime(2021, 10, 30, 15, 34, 52, 57, DateTimeKind.Local).AddTicks(5681), "Cracov", "kasia@mail.com", "Katarzyna", "Female", new DateTime(2021, 10, 30, 15, 34, 52, 57, DateTimeKind.Local).AddTicks(5684), "Manager", "Obokmlyna", "999222333", "32-200" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6", "D174C90E-6C1D-452C-B91F-CA39C112B73E" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "CategoryId", "Description", "ImageUrl", "Kcal", "Name", "Price", "Recommended" },
                values: new object[,]
                {
                    { new Guid("27a5a65d-6743-4435-9c0a-14c915aa088f"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good tea", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Tea", 12.99m, false },
                    { new Guid("37d4da99-b860-4622-a388-de20a9e2d130"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good coffee", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Coffee", 12.99m, true },
                    { new Guid("3683ca21-8f12-487f-8945-010927470416"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "It is worth a try", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 270, "Granita", 10.05m, false },
                    { new Guid("ee239c12-9087-4d20-a710-ba82b2f22e28"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Sweet and cold what more could you want", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 260, "Ice-creams", 9.10m, false },
                    { new Guid("3c5c7c76-1d77-4fd8-afc6-8914d187469f"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Melts in your mouth", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 290, "Panna Cotta", 10.40m, false },
                    { new Guid("d47e1cac-1d38-4c93-b0d1-7b81fbffc1be"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "The best dessert that will impress your other half", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 300, "Tiramisu", 10.50m, true },
                    { new Guid("c70b1d34-bc12-4de0-916a-e6885642e7af"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Very aromatic dish that will delight everyone", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Mushroom soup", 14.49m, false },
                    { new Guid("86411cf0-88e8-4045-9232-c3aec8585736"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Tasty and nutritious", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Soup with meatballs", 15.95m, false },
                    { new Guid("883c5b6e-5a84-481a-9f1f-39cc2cb5eeaa"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just water", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Water", 12.99m, false },
                    { new Guid("4f4620c3-f1c1-4b6d-845b-211e898b3436"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Our novelty", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Curry soup", 13.30m, false },
                    { new Guid("a04b9671-82c3-40d8-b752-f8913b237667"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "This taste will surprise you", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 410, "Tagliatelle with spinach", 19.99m, false },
                    { new Guid("0e21c2f3-dfcd-4504-b6b7-c71ee9c4886c"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "For more hunger", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 840, "Lasagne", 36.99m, false },
                    { new Guid("3d8c236a-3f7f-4384-8c10-a81dfcc4439e"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Our kitchen's bestseller", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 550, "Spaghetti carbonara", 19.99m, true },
                    { new Guid("0e055b53-a388-4339-a037-841db09f17bc"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "The best pasta with classic bolognese sauce", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 450, "Spaghetti bolognese", 18.20m, false },
                    { new Guid("cdeae544-bae4-4a4d-b509-77214737f60d"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "the best cheeses on your favorite pizza", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 900, "Four cheeses pizza", 33.90m, false },
                    { new Guid("f0466e0b-222e-489a-815e-eb4f318b6037"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "American pizza in the Italian version", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 800, "Pizza americana", 32.20m, false },
                    { new Guid("8dc7a2e4-af20-41eb-b36f-d94ad3beb4bf"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "The best for meetings with friends", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 750, "Pizza salami", 31.50m, false },
                    { new Guid("a0ad35ef-635b-4230-ad0a-d1519f0b0c7c"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Delicious classic from the pizza family", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 600, "Pizza margherita", 25.99m, true },
                    { new Guid("e46aa963-cd4c-42ab-a80c-92ba5a272653"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Its taste comes from the best ingredients", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 180, "Creamy tomato soup", 12.99m, true },
                    { new Guid("fd596faa-6989-457f-a93e-c21ceba1d110"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just Coca-Cola", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 110, "Coca-Cola", 12.99m, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CategoryId",
                table: "Dishes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
