using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Migrations
{
    public partial class ProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Price" },
                values: new object[,]
                {
                    { new Guid("38df74cf-bbf1-4c47-a513-b51192162675"), "Adriática", 23.02m },
                    { new Guid("41ab0c59-04a6-45d6-ac20-ef15e8a10d4e"), "Stella Artois", 13.77m },
                    { new Guid("da436ba6-0830-4e4f-8037-dc7875df8285"), "Skol", 21.5m },
                    { new Guid("9f52b74d-70ff-42cd-8166-42b4d4227dce"), "Serrana", 17.65m },
                    { new Guid("d9470a0f-ee73-41ff-85f6-fd9fc76d4bec"), "Serramalte", 29.09m },
                    { new Guid("2dd4bedb-b7e7-4f05-9941-66bb2b4b7886"), "Quilmes", 3.66m },
                    { new Guid("5ce4210a-a73f-464a-9cef-86df80fa3ea7"), "Polar", 28.07m },
                    { new Guid("dcb96166-3eff-4d2d-b79f-06315ec3f2be"), "Patagonia", 5.17m },
                    { new Guid("d0c03fda-1183-4a9e-ba50-abb0dc0e466d"), "Original", 17.67m },
                    { new Guid("2d410954-d770-4d8f-865a-63f26e58c757"), "Nossa", 10.71m },
                    { new Guid("c0d623b7-6dc2-47a5-90fe-bb266d338e76"), "Norteña", 19.34m },
                    { new Guid("3964bb46-b21a-473e-81c2-8d9e648822fe"), "Magnífica do Maranhão", 12.03m },
                    { new Guid("2c013e77-4d8e-412e-9492-f3c2d0be748b"), "Löwenbräu", 23.95m },
                    { new Guid("8a234d72-6b32-44c2-b7c1-51b5186f0750"), "Três Fidalgas", 26.49m },
                    { new Guid("ad99c2eb-beab-4a2b-85eb-fba15ea45864"), "Legítima", 24.46m },
                    { new Guid("908dfa2f-45b5-480f-82a0-a0ac0eb8c72d"), "Hoegaarden", 22.29m },
                    { new Guid("46c6ec94-41e2-4564-a99b-f67e487ae7ff"), "Hertog Jan", 12.25m },
                    { new Guid("6f596be2-8b26-48ac-b85d-3a4fb3a647a4"), "Goose Island", 3.26m },
                    { new Guid("31d1631a-0478-4843-8055-66114c5c79ee"), "Franziskaner", 26.37m },
                    { new Guid("6acd2a47-4f54-483e-bda5-6e8845024ef0"), "Corona", 15.15m },
                    { new Guid("fe7edab4-2b64-416a-b020-5bfe8b0790bd"), "Cervejaria Colorado", 2.89m },
                    { new Guid("1623b63d-db67-4447-8460-52a840ac6f68"), "Caracu", 22.87m },
                    { new Guid("bea953df-7d78-4364-b2c8-953d1467aef9"), "Budweiser", 4.39m },
                    { new Guid("5b682ec6-40dc-4e71-a10f-4a0d9dff6b31"), "Brahma", 8.56m },
                    { new Guid("c292141a-2104-4afc-8431-596e40b0e783"), "Bohemia", 12.89m },
                    { new Guid("cb91f1d0-726f-4a84-96d1-419e3fe1582d"), "Beck's", 13.41m },
                    { new Guid("f9fa7a55-28ef-4dac-a938-170bc8c8e86e"), "Antarctica", 5.48m },
                    { new Guid("3b45bc7d-b6a7-4915-8007-fffee5bc1dd6"), "Leffe", 5.78m },
                    { new Guid("147e4c5e-a228-4188-abfc-8f612b1b7096"), "Wäls", 19.87m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("147e4c5e-a228-4188-abfc-8f612b1b7096"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1623b63d-db67-4447-8460-52a840ac6f68"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2c013e77-4d8e-412e-9492-f3c2d0be748b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2d410954-d770-4d8f-865a-63f26e58c757"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2dd4bedb-b7e7-4f05-9941-66bb2b4b7886"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("31d1631a-0478-4843-8055-66114c5c79ee"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("38df74cf-bbf1-4c47-a513-b51192162675"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3964bb46-b21a-473e-81c2-8d9e648822fe"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3b45bc7d-b6a7-4915-8007-fffee5bc1dd6"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("41ab0c59-04a6-45d6-ac20-ef15e8a10d4e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("46c6ec94-41e2-4564-a99b-f67e487ae7ff"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5b682ec6-40dc-4e71-a10f-4a0d9dff6b31"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5ce4210a-a73f-464a-9cef-86df80fa3ea7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6acd2a47-4f54-483e-bda5-6e8845024ef0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6f596be2-8b26-48ac-b85d-3a4fb3a647a4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8a234d72-6b32-44c2-b7c1-51b5186f0750"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("908dfa2f-45b5-480f-82a0-a0ac0eb8c72d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9f52b74d-70ff-42cd-8166-42b4d4227dce"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ad99c2eb-beab-4a2b-85eb-fba15ea45864"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bea953df-7d78-4364-b2c8-953d1467aef9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c0d623b7-6dc2-47a5-90fe-bb266d338e76"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c292141a-2104-4afc-8431-596e40b0e783"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cb91f1d0-726f-4a84-96d1-419e3fe1582d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0c03fda-1183-4a9e-ba50-abb0dc0e466d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d9470a0f-ee73-41ff-85f6-fd9fc76d4bec"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("da436ba6-0830-4e4f-8037-dc7875df8285"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dcb96166-3eff-4d2d-b79f-06315ec3f2be"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f9fa7a55-28ef-4dac-a938-170bc8c8e86e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fe7edab4-2b64-416a-b020-5bfe8b0790bd"));
        }
    }
}
