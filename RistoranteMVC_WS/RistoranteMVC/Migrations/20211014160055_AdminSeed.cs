using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RistoranteMVC.Migrations
{
    public partial class AdminSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("092ac275-7d68-42f3-8e23-2385788ae304"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("0dc345ab-cb02-4fe2-837b-814e383f70db"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("110d8eaa-25b5-47aa-8168-030a9fda783e"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("14849acc-cc85-41b4-8766-494262635eca"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("1e73f4aa-5115-4bd9-be16-255c4898e789"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("2473317c-36ba-4d81-8232-8897f830caca"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("2d18db44-b812-44b3-9eab-7a3dd31b5dfe"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("40dd5d10-a7a7-405b-b984-1fdc90ccc67a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("472f8c7e-c560-41b0-a816-c5dda1beafd7"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("4e8a7dd7-9954-4f92-824c-a81454e1c247"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("66ccba18-2e43-4e85-9e4c-9507d9ad8f22"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("88b9c79c-1409-456d-ba43-cdc90e67e289"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("96601e4f-bab3-4a8b-873f-eda798c8a683"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("b2c50814-3222-4e2d-b3e0-f7c0f66a717a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("c48dcf3e-1dc0-4dd7-8337-69d51feff5bc"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("cf82c88a-8753-42af-b4b3-7b246868f52e"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("dc0cc3ac-ce43-4635-832b-10ff23fa1495"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("df9e7226-4df1-46cf-84bb-74128ca8ac5a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("f278f545-72e5-4455-84ea-c93b1658d1ec"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("f330dd1e-4d8a-4317-95ad-84afad8aa5ee"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6",
                column: "ConcurrencyStamp",
                value: "9bd03e3b-6978-4417-8796-5df6c82e5be9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "D174C90E-6C1D-452C-B91F-CA39C112B73E", 0, "7ab47d50-786f-4f43-ad92-216c3ea4d3e1", "admin@mail.com", true, "Janeczek", "Adminowy", false, null, "ADMIN@MAIL.COM", "JANECZEK", "AQAAAAEAACcQAAAAEFYO2d2OfMl4SCMZR33E6qIvEi3ba4QHrGCjDF3decpN7xuZoSZC8bHtobtq+6oZOA==", null, false, "290e675b-ed16-466d-9773-372c0bc25282", false, "Janeczek" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "CategoryId", "Description", "ImageUrl", "Kcal", "Name", "Price", "Recommended" },
                values: new object[,]
                {
                    { new Guid("cd03beb0-66e8-443b-8abd-60872dfc6648"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "The best for meetings with friends", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 750, "Pizza salami", 31.50m, false },
                    { new Guid("27f14300-856c-40d0-8472-56e9015ee9c5"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just water", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Water", 12.99m, false },
                    { new Guid("c7ae4b88-2d8d-4882-89e5-a7a829845dce"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good tea", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Tea", 12.99m, false },
                    { new Guid("0dd36b3c-1644-41c9-8cbd-87e81d0e7361"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good coffee", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Coffee", 12.99m, true },
                    { new Guid("caf8fc1d-dcf4-4256-a40e-bff0c983b503"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "It is worth a try", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 270, "Granita", 10.05m, false },
                    { new Guid("c516421d-9979-4909-a5e7-a2800cca08a5"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Sweet and cold what more could you want", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 260, "Ice-creams", 9.10m, false },
                    { new Guid("8df4866e-fddb-4703-a220-193c3a7c03ca"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Melts in your mouth", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 290, "Panna Cotta", 10.40m, false },
                    { new Guid("4ef63506-74d4-4509-985f-9f49324f5bf3"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "The best dessert that will impress your other half", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 300, "Tiramisu", 10.50m, true },
                    { new Guid("256e241d-6d1b-4241-a025-6fb64032bf3b"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Very aromatic dish that will delight everyone", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Mushroom soup", 14.49m, false },
                    { new Guid("b32bebc8-eb24-4c6b-bb61-847c980de1a7"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Tasty and nutritious", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Soup with meatballs", 15.95m, false },
                    { new Guid("a93c301b-9819-43c4-85a2-b8c8367d2338"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just Coca-Cola", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 110, "Coca-Cola", 12.99m, false },
                    { new Guid("3e387e55-6c23-45b9-b73c-cba6f9cb95c1"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Its taste comes from the best ingredients", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 180, "Creamy tomato soup", 12.99m, true },
                    { new Guid("12c579b6-f3cb-44c5-ad6b-dc81691e8d76"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "This taste will surprise you", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 410, "Tagliatelle with spinach", 19.99m, false },
                    { new Guid("ce45c5fd-f45a-4283-ac7b-f13f77372b9e"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "For more hunger", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 840, "Lasagne", 36.99m, false },
                    { new Guid("f28f54e4-cf96-45ad-9129-bc8d6065c279"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Our kitchen's bestseller", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 550, "Spaghetti carbonara", 19.99m, true },
                    { new Guid("9e42e50a-7677-4619-8066-6f6d3075e763"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "The best pasta with classic bolognese sauce", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 450, "Spaghetti bolognese", 18.20m, false },
                    { new Guid("cc2e74ab-0551-4039-9797-4b7c144278cb"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "the best cheeses on your favorite pizza", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 900, "Four cheeses pizza", 33.90m, false },
                    { new Guid("cc3f8164-319b-44b1-a737-d51b5f816ebc"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "American pizza in the Italian version", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 800, "Pizza americana", 32.20m, false },
                    { new Guid("d265c662-fa5d-4cd8-93db-a5cbd764bb53"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Delicious classic from the pizza family", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 600, "Pizza margherita", 25.99m, true },
                    { new Guid("fb0e6246-a277-4085-8222-4c4a544ad2c0"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Our novelty", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Curry soup", 13.30m, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6", "D174C90E-6C1D-452C-B91F-CA39C112B73E" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6", "D174C90E-6C1D-452C-B91F-CA39C112B73E" });

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("0dd36b3c-1644-41c9-8cbd-87e81d0e7361"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("12c579b6-f3cb-44c5-ad6b-dc81691e8d76"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("256e241d-6d1b-4241-a025-6fb64032bf3b"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("27f14300-856c-40d0-8472-56e9015ee9c5"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("3e387e55-6c23-45b9-b73c-cba6f9cb95c1"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("4ef63506-74d4-4509-985f-9f49324f5bf3"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("8df4866e-fddb-4703-a220-193c3a7c03ca"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("9e42e50a-7677-4619-8066-6f6d3075e763"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("a93c301b-9819-43c4-85a2-b8c8367d2338"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("b32bebc8-eb24-4c6b-bb61-847c980de1a7"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("c516421d-9979-4909-a5e7-a2800cca08a5"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("c7ae4b88-2d8d-4882-89e5-a7a829845dce"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("caf8fc1d-dcf4-4256-a40e-bff0c983b503"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("cc2e74ab-0551-4039-9797-4b7c144278cb"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("cc3f8164-319b-44b1-a737-d51b5f816ebc"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("cd03beb0-66e8-443b-8abd-60872dfc6648"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("ce45c5fd-f45a-4283-ac7b-f13f77372b9e"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("d265c662-fa5d-4cd8-93db-a5cbd764bb53"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("f28f54e4-cf96-45ad-9129-bc8d6065c279"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: new Guid("fb0e6246-a277-4085-8222-4c4a544ad2c0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D174C90E-6C1D-452C-B91F-CA39C112B73E");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DAFF313F-89DD-4621-BC3F-B6EE1F2A23C6",
                column: "ConcurrencyStamp",
                value: "c8594eb9-e8fc-4f9e-8cf9-a122ffc7d837");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "CategoryId", "Description", "ImageUrl", "Kcal", "Name", "Price", "Recommended" },
                values: new object[,]
                {
                    { new Guid("40dd5d10-a7a7-405b-b984-1fdc90ccc67a"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just water", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Water", 12.99m, false },
                    { new Guid("b2c50814-3222-4e2d-b3e0-f7c0f66a717a"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good tea", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Tea", 12.99m, false },
                    { new Guid("df9e7226-4df1-46cf-84bb-74128ca8ac5a"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just good coffee", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 10, "Coffee", 12.99m, true },
                    { new Guid("4e8a7dd7-9954-4f92-824c-a81454e1c247"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "It is worth a try", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 270, "Granita", 10.05m, false },
                    { new Guid("1e73f4aa-5115-4bd9-be16-255c4898e789"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Sweet and cold what more could you want", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 260, "Ice-creams", 9.10m, false },
                    { new Guid("f330dd1e-4d8a-4317-95ad-84afad8aa5ee"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "Melts in your mouth", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 290, "Panna Cotta", 10.40m, false },
                    { new Guid("f278f545-72e5-4455-84ea-c93b1658d1ec"), new Guid("10895537-2732-403b-87dc-047ec2535593"), "The best dessert that will impress your other half", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 300, "Tiramisu", 10.50m, true },
                    { new Guid("2d18db44-b812-44b3-9eab-7a3dd31b5dfe"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Very aromatic dish that will delight everyone", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Mushroom soup", 14.49m, false },
                    { new Guid("cf82c88a-8753-42af-b4b3-7b246868f52e"), new Guid("d99c5243-4815-4722-9fe3-e27623b8232b"), "Just Coca-Cola", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 110, "Coca-Cola", 12.99m, false },
                    { new Guid("96601e4f-bab3-4a8b-873f-eda798c8a683"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Tasty and nutritious", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Soup with meatballs", 15.95m, false },
                    { new Guid("2473317c-36ba-4d81-8232-8897f830caca"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Its taste comes from the best ingredients", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 180, "Creamy tomato soup", 12.99m, true },
                    { new Guid("66ccba18-2e43-4e85-9e4c-9507d9ad8f22"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "This taste will surprise you", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 410, "Tagliatelle with spinach", 19.99m, false },
                    { new Guid("0dc345ab-cb02-4fe2-837b-814e383f70db"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "For more hunger", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 840, "Lasagne", 36.99m, false },
                    { new Guid("110d8eaa-25b5-47aa-8168-030a9fda783e"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "Our kitchen's bestseller", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 550, "Spaghetti carbonara", 19.99m, true },
                    { new Guid("88b9c79c-1409-456d-ba43-cdc90e67e289"), new Guid("a4b49c2f-93b6-42c7-99c6-524638667afd"), "The best pasta with classic bolognese sauce", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 450, "Spaghetti bolognese", 18.20m, false },
                    { new Guid("dc0cc3ac-ce43-4635-832b-10ff23fa1495"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "the best cheeses on your favorite pizza", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 900, "Four cheeses pizza", 33.90m, false },
                    { new Guid("092ac275-7d68-42f3-8e23-2385788ae304"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "American pizza in the Italian version", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 800, "Pizza americana", 32.20m, false },
                    { new Guid("c48dcf3e-1dc0-4dd7-8337-69d51feff5bc"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "The best for meetings with friends", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 750, "Pizza salami", 31.50m, false },
                    { new Guid("472f8c7e-c560-41b0-a816-c5dda1beafd7"), new Guid("c85f1ad9-cef4-4bab-94da-e4dfb466c158"), "Our novelty", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 210, "Curry soup", 13.30m, false },
                    { new Guid("14849acc-cc85-41b4-8766-494262635eca"), new Guid("9bcd1113-6b23-4493-bc83-0c80a436430a"), "Delicious classic from the pizza family", "https://cdn.pixabay.com/photo/2016/09/13/18/38/silverware-1667988_960_720.png", 600, "Pizza margherita", 25.99m, true }
                });
        }
    }
}
