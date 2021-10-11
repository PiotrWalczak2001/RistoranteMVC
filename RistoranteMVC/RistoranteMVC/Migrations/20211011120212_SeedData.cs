using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RistoranteMVC.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("acf3b296-e0b4-4ff6-a5b8-25492aa78ce0"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Delicious classic from the pizza family", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 600, "Pizza margherita", 25.99m, true },
                    { new Guid("2e76d6a2-ae95-4510-8d54-78919f6f86f0"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good tea", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Tea", 12.99m, false },
                    { new Guid("72417ead-7712-4783-b72f-cc3bc8f08977"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good coffee", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Coffee", 12.99m, true },
                    { new Guid("af208f65-15e0-49c4-80cf-1c113bcc7eb9"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "It is worth a try", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 270, "Granita", 10.05m, false },
                    { new Guid("94ec8d20-84d3-4f24-8d86-ed01c262884e"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Sweet and cold what more could you want", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 260, "Ice-creams", 9.10m, false },
                    { new Guid("5e5348fb-555b-4482-9ca6-2d23e2304851"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Melts in your mouth", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 290, "Panna Cotta", 10.40m, false },
                    { new Guid("6977356a-9b4f-4186-82d8-f62f5602e5e1"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "The best dessert that will impress your other half", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 300, "Tiramisu", 10.50m, true },
                    { new Guid("3848e429-9ed6-4243-bfcf-89784957fccb"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Very aromatic dish that will delight everyone", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Mushroom soup", 14.49m, false },
                    { new Guid("533ea5dd-039f-4485-a335-1f9f20ebb202"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Tasty and nutritious", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Soup with meatballs", 15.95m, false },
                    { new Guid("a6ebc683-3ff4-4942-90d3-a47fc1d9e3f9"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Our novelty", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Curry soup", 13.30m, false },
                    { new Guid("a8f27650-3dfa-4cb7-b1ea-3523be7a6209"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Its taste comes from the best ingredients", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 180, "Creamy tomato soup", 12.99m, true },
                    { new Guid("798e5316-7d84-49f7-81dc-b3d0d8457b6f"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "This taste will surprise you", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 410, "Tagliatelle with spinach", 19.99m, false },
                    { new Guid("8b7ae5da-da0b-4dee-884f-33a8d71ef761"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "For more hunger", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 840, "Lasagne", 36.99m, false },
                    { new Guid("6d866692-40d6-4a7d-bbdb-b66b14637c0a"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Our kitchen's bestseller", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 550, "Spaghetti carbonara", 19.99m, true },
                    { new Guid("e7346c59-22c7-48c5-8b75-7edd412a4cde"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "The best pasta with classic bolognese sauce", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 450, "Spaghetti bolognese", 18.20m, false },
                    { new Guid("e84aecdd-205f-4da3-9621-70799479b8ad"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "the best cheeses on your favorite pizza", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 900, "Four cheeses pizza", 33.90m, false },
                    { new Guid("6f9c3035-2056-413c-916b-80567f1e5ad1"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "American pizza in the Italian version", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 800, "Pizza americana", 32.20m, false },
                    { new Guid("1edde71e-4146-4db3-aa01-f0c822f89375"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "The best for meetings with friends", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 750, "Pizza salami", 31.50m, false },
                    { new Guid("61adeaf0-d3ed-4732-ab58-7ae83492abcc"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just water", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Water", 12.99m, false },
                    { new Guid("76529e74-8e95-4375-8479-c3c5aa778cc6"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just Coca-Cola", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 110, "Coca-Cola", 12.99m, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("1edde71e-4146-4db3-aa01-f0c822f89375"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("2e76d6a2-ae95-4510-8d54-78919f6f86f0"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("3848e429-9ed6-4243-bfcf-89784957fccb"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("533ea5dd-039f-4485-a335-1f9f20ebb202"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("5e5348fb-555b-4482-9ca6-2d23e2304851"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("61adeaf0-d3ed-4732-ab58-7ae83492abcc"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("6977356a-9b4f-4186-82d8-f62f5602e5e1"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("6d866692-40d6-4a7d-bbdb-b66b14637c0a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("6f9c3035-2056-413c-916b-80567f1e5ad1"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("72417ead-7712-4783-b72f-cc3bc8f08977"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("76529e74-8e95-4375-8479-c3c5aa778cc6"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("798e5316-7d84-49f7-81dc-b3d0d8457b6f"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("8b7ae5da-da0b-4dee-884f-33a8d71ef761"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("94ec8d20-84d3-4f24-8d86-ed01c262884e"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("a6ebc683-3ff4-4942-90d3-a47fc1d9e3f9"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("a8f27650-3dfa-4cb7-b1ea-3523be7a6209"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("acf3b296-e0b4-4ff6-a5b8-25492aa78ce0"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("af208f65-15e0-49c4-80cf-1c113bcc7eb9"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("e7346c59-22c7-48c5-8b75-7edd412a4cde"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("e84aecdd-205f-4da3-9621-70799479b8ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("10895537-2732-403b-87dc-047ec2535593"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"));
        }
    }
}
