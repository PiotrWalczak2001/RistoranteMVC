using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RistoranteMVC.Persistence.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("99e4dc7c-6a01-4b86-8931-0c942699bb0f"), "Konopnicka 15", new DateTime(2021, 11, 1, 22, 50, 32, 727, DateTimeKind.Local).AddTicks(3974), "Cracov", "jan@mail.com", "Jan", "Male", new DateTime(2021, 11, 1, 22, 50, 32, 730, DateTimeKind.Local).AddTicks(9622), "Cook", "Fajny", "111222333", "32-200" },
                    { new Guid("0b8758fb-c227-47c9-98a2-976d01732738"), "Rydla 59", new DateTime(2021, 11, 1, 22, 50, 32, 731, DateTimeKind.Local).AddTicks(7662), "Cracov", "ben@mail.com", "Ben", "Male", new DateTime(2021, 11, 1, 22, 50, 32, 731, DateTimeKind.Local).AddTicks(7676), "Driver", "Kierwoca", "444222333", "32-200" },
                    { new Guid("b87815c1-8312-4856-9335-a272a57dbd62"), "Pawia 5", new DateTime(2021, 11, 1, 22, 50, 32, 731, DateTimeKind.Local).AddTicks(7755), "Cracov", "kasia@mail.com", "Katarzyna", "Female", new DateTime(2021, 11, 1, 22, 50, 32, 731, DateTimeKind.Local).AddTicks(7758), "Manager", "Obokmlyna", "999222333", "32-200" }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "CategoryId", "Description", "ImageUrl", "Kcal", "Name", "Price", "Recommended" },
                values: new object[,]
                {
                    { new Guid("2589321d-a8bd-4b44-aaa9-7e7f7011c330"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Delicious classic from the pizza family", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 600, "Pizza margherita", 25.99m, true },
                    { new Guid("77bec339-3c5e-417c-875c-2374d18b059d"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good tea", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Tea", 12.99m, false },
                    { new Guid("70481e18-636a-4324-8cf0-5f09ccfd42fa"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good coffee", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Coffee", 12.99m, true },
                    { new Guid("d363c5b1-5ca3-4b25-a91b-76dc8c63939c"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "It is worth a try", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 270, "Granita", 10.05m, false },
                    { new Guid("57dbd2dc-9e46-4fdb-b783-140c464194c3"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Sweet and cold what more could you want", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 260, "Ice-creams", 9.10m, false },
                    { new Guid("9dd5b959-15ee-4a68-a04f-05ab599c2ca2"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Melts in your mouth", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 290, "Panna Cotta", 10.40m, false },
                    { new Guid("dda205fc-cedd-4318-aab7-f397485ca5eb"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "The best dessert that will impress your other half", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 300, "Tiramisu", 10.50m, true },
                    { new Guid("b1f70ce6-d15e-4784-ab6f-675c643ae967"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Very aromatic dish that will delight everyone", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Mushroom soup", 14.49m, false },
                    { new Guid("108320b7-6f59-4b64-bba1-67a4f60c00d5"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Tasty and nutritious", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Soup with meatballs", 15.95m, false },
                    { new Guid("907fd430-c17c-4226-b275-1182549acfda"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Our novelty", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Curry soup", 13.30m, false },
                    { new Guid("7a5454a8-2716-4be6-946f-6784bec135e0"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Its taste comes from the best ingredients", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 180, "Creamy tomato soup", 12.99m, true },
                    { new Guid("b971f859-5d2b-4a89-bd9c-0e314f77e325"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "This taste will surprise you", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 410, "Tagliatelle with spinach", 19.99m, false },
                    { new Guid("7d04d4d4-6d5a-4eeb-8732-18a12c3da0e0"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "For more hunger", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 840, "Lasagne", 36.99m, false },
                    { new Guid("d68402ff-95f6-40a4-9fc9-1584f650678f"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Our kitchen's bestseller", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 550, "Spaghetti carbonara", 19.99m, true },
                    { new Guid("fe07ee67-e796-4a87-bad8-e388677cdc5e"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "The best pasta with classic bolognese sauce", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 450, "Spaghetti bolognese", 18.20m, false },
                    { new Guid("5174dcc0-0853-4500-8094-be9f8df8b5d2"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "the best cheeses on your favorite pizza", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 900, "Four cheeses pizza", 33.90m, false },
                    { new Guid("82d27ad9-138b-40b9-add2-54d4fbc5f815"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "American pizza in the Italian version", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 800, "Pizza americana", 32.20m, false },
                    { new Guid("920c003c-15d9-4a64-87fa-f24fba522763"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "The best for meetings with friends", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 750, "Pizza salami", 31.50m, false },
                    { new Guid("6ab04d0e-e1ea-4633-9fa5-c6be43638979"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just water", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Water", 12.99m, false },
                    { new Guid("dd73a49b-efd4-4fa6-b2e8-21d3abef8831"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just Coca-Cola", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 110, "Coca-Cola", 12.99m, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CategoryId",
                table: "Dishes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
