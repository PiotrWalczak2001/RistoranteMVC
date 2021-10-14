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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6", "c8594eb9-e8fc-4f9e-8cf9-a122ffc7d837", "Admin", "ADMINISTRATOR" });

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
                table: "Dishes",
                columns: new[] { "DishId", "CategoryId", "Description", "ImageUrl", "Kcal", "Name", "Price", "Recommended" },
                values: new object[,]
                {
                    { new Guid("14849acc-cc85-41b4-8766-494262635eca"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Delicious classic from the pizza family", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 600, "Pizza margherita", 25.99m, true },
                    { new Guid("b2c50814-3222-4e2d-b3e0-f7c0f66a717a"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good tea", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Tea", 12.99m, false },
                    { new Guid("df9e7226-4df1-46cf-84bb-74128ca8ac5a"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good coffee", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Coffee", 12.99m, true },
                    { new Guid("4e8a7dd7-9954-4f92-824c-a81454e1c247"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "It is worth a try", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 270, "Granita", 10.05m, false },
                    { new Guid("1e73f4aa-5115-4bd9-be16-255c4898e789"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Sweet and cold what more could you want", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 260, "Ice-creams", 9.10m, false },
                    { new Guid("f330dd1e-4d8a-4317-95ad-84afad8aa5ee"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Melts in your mouth", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 290, "Panna Cotta", 10.40m, false },
                    { new Guid("f278f545-72e5-4455-84ea-c93b1658d1ec"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "The best dessert that will impress your other half", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 300, "Tiramisu", 10.50m, true },
                    { new Guid("2d18db44-b812-44b3-9eab-7a3dd31b5dfe"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Very aromatic dish that will delight everyone", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Mushroom soup", 14.49m, false },
                    { new Guid("96601e4f-bab3-4a8b-873f-eda798c8a683"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Tasty and nutritious", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Soup with meatballs", 15.95m, false },
                    { new Guid("472f8c7e-c560-41b0-a816-c5dda1beafd7"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Our novelty", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Curry soup", 13.30m, false },
                    { new Guid("2473317c-36ba-4d81-8232-8897f830caca"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Its taste comes from the best ingredients", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 180, "Creamy tomato soup", 12.99m, true },
                    { new Guid("66ccba18-2e43-4e85-9e4c-9507d9ad8f22"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "This taste will surprise you", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 410, "Tagliatelle with spinach", 19.99m, false },
                    { new Guid("0dc345ab-cb02-4fe2-837b-814e383f70db"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "For more hunger", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 840, "Lasagne", 36.99m, false },
                    { new Guid("110d8eaa-25b5-47aa-8168-030a9fda783e"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Our kitchen's bestseller", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 550, "Spaghetti carbonara", 19.99m, true },
                    { new Guid("88b9c79c-1409-456d-ba43-cdc90e67e289"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "The best pasta with classic bolognese sauce", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 450, "Spaghetti bolognese", 18.20m, false },
                    { new Guid("dc0cc3ac-ce43-4635-832b-10ff23fa1495"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "the best cheeses on your favorite pizza", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 900, "Four cheeses pizza", 33.90m, false },
                    { new Guid("092ac275-7d68-42f3-8e23-2385788ae304"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "American pizza in the Italian version", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 800, "Pizza americana", 32.20m, false },
                    { new Guid("c48dcf3e-1dc0-4dd7-8337-69d51feff5bc"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "The best for meetings with friends", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 750, "Pizza salami", 31.50m, false },
                    { new Guid("40dd5d10-a7a7-405b-b984-1fdc90ccc67a"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just water", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Water", 12.99m, false },
                    { new Guid("cf82c88a-8753-42af-b4b3-7b246868f52e"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just Coca-Cola", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 110, "Coca-Cola", 12.99m, false }
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DishId",
                table: "OrderDetails",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_DishId",
                table: "ShoppingCartItems",
                column: "DishId");
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
