using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Migrations
{
    public partial class UserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("147e4c5e-a228-4188-abfc-8f612b1b7096"),
                column: "Price",
                value: 2.89m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1623b63d-db67-4447-8460-52a840ac6f68"),
                column: "Price",
                value: 5.04m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2c013e77-4d8e-412e-9492-f3c2d0be748b"),
                column: "Price",
                value: 25.85m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2d410954-d770-4d8f-865a-63f26e58c757"),
                column: "Price",
                value: 22.69m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2dd4bedb-b7e7-4f05-9941-66bb2b4b7886"),
                column: "Price",
                value: 9.35m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("31d1631a-0478-4843-8055-66114c5c79ee"),
                column: "Price",
                value: 27.52m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("38df74cf-bbf1-4c47-a513-b51192162675"),
                column: "Price",
                value: 6.17m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3964bb46-b21a-473e-81c2-8d9e648822fe"),
                column: "Price",
                value: 16.04m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3b45bc7d-b6a7-4915-8007-fffee5bc1dd6"),
                column: "Price",
                value: 8.86m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("41ab0c59-04a6-45d6-ac20-ef15e8a10d4e"),
                column: "Price",
                value: 27.42m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("46c6ec94-41e2-4564-a99b-f67e487ae7ff"),
                column: "Price",
                value: 4.43m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5b682ec6-40dc-4e71-a10f-4a0d9dff6b31"),
                column: "Price",
                value: 2.42m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5ce4210a-a73f-464a-9cef-86df80fa3ea7"),
                column: "Price",
                value: 10.06m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6acd2a47-4f54-483e-bda5-6e8845024ef0"),
                column: "Price",
                value: 29.7m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6f596be2-8b26-48ac-b85d-3a4fb3a647a4"),
                column: "Price",
                value: 7.94m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8a234d72-6b32-44c2-b7c1-51b5186f0750"),
                column: "Price",
                value: 3.21m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("908dfa2f-45b5-480f-82a0-a0ac0eb8c72d"),
                column: "Price",
                value: 24.26m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9f52b74d-70ff-42cd-8166-42b4d4227dce"),
                column: "Price",
                value: 2.08m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ad99c2eb-beab-4a2b-85eb-fba15ea45864"),
                column: "Price",
                value: 24.78m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bea953df-7d78-4364-b2c8-953d1467aef9"),
                column: "Price",
                value: 27.28m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c0d623b7-6dc2-47a5-90fe-bb266d338e76"),
                column: "Price",
                value: 8.31m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c292141a-2104-4afc-8431-596e40b0e783"),
                column: "Price",
                value: 21.03m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cb91f1d0-726f-4a84-96d1-419e3fe1582d"),
                column: "Price",
                value: 18.05m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0c03fda-1183-4a9e-ba50-abb0dc0e466d"),
                column: "Price",
                value: 14.97m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d9470a0f-ee73-41ff-85f6-fd9fc76d4bec"),
                column: "Price",
                value: 23.09m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("da436ba6-0830-4e4f-8037-dc7875df8285"),
                column: "Price",
                value: 24.58m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dcb96166-3eff-4d2d-b79f-06315ec3f2be"),
                column: "Price",
                value: 15.11m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f9fa7a55-28ef-4dac-a938-170bc8c8e86e"),
                column: "Price",
                value: 10.56m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fe7edab4-2b64-416a-b020-5bfe8b0790bd"),
                column: "Price",
                value: 4.74m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("147e4c5e-a228-4188-abfc-8f612b1b7096"),
                column: "Price",
                value: 5.76m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1623b63d-db67-4447-8460-52a840ac6f68"),
                column: "Price",
                value: 14.96m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2c013e77-4d8e-412e-9492-f3c2d0be748b"),
                column: "Price",
                value: 25.19m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2d410954-d770-4d8f-865a-63f26e58c757"),
                column: "Price",
                value: 19.98m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2dd4bedb-b7e7-4f05-9941-66bb2b4b7886"),
                column: "Price",
                value: 13.79m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("31d1631a-0478-4843-8055-66114c5c79ee"),
                column: "Price",
                value: 24.97m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("38df74cf-bbf1-4c47-a513-b51192162675"),
                column: "Price",
                value: 6.95m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3964bb46-b21a-473e-81c2-8d9e648822fe"),
                column: "Price",
                value: 16.95m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3b45bc7d-b6a7-4915-8007-fffee5bc1dd6"),
                column: "Price",
                value: 9.58m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("41ab0c59-04a6-45d6-ac20-ef15e8a10d4e"),
                column: "Price",
                value: 22.01m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("46c6ec94-41e2-4564-a99b-f67e487ae7ff"),
                column: "Price",
                value: 24.15m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5b682ec6-40dc-4e71-a10f-4a0d9dff6b31"),
                column: "Price",
                value: 22.38m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5ce4210a-a73f-464a-9cef-86df80fa3ea7"),
                column: "Price",
                value: 28.74m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6acd2a47-4f54-483e-bda5-6e8845024ef0"),
                column: "Price",
                value: 12.83m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6f596be2-8b26-48ac-b85d-3a4fb3a647a4"),
                column: "Price",
                value: 8.74m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8a234d72-6b32-44c2-b7c1-51b5186f0750"),
                column: "Price",
                value: 14.43m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("908dfa2f-45b5-480f-82a0-a0ac0eb8c72d"),
                column: "Price",
                value: 3.23m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9f52b74d-70ff-42cd-8166-42b4d4227dce"),
                column: "Price",
                value: 8.48m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ad99c2eb-beab-4a2b-85eb-fba15ea45864"),
                column: "Price",
                value: 20.15m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bea953df-7d78-4364-b2c8-953d1467aef9"),
                column: "Price",
                value: 11.79m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c0d623b7-6dc2-47a5-90fe-bb266d338e76"),
                column: "Price",
                value: 1.11m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c292141a-2104-4afc-8431-596e40b0e783"),
                column: "Price",
                value: 4.38m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cb91f1d0-726f-4a84-96d1-419e3fe1582d"),
                column: "Price",
                value: 28.72m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d0c03fda-1183-4a9e-ba50-abb0dc0e466d"),
                column: "Price",
                value: 29.69m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d9470a0f-ee73-41ff-85f6-fd9fc76d4bec"),
                column: "Price",
                value: 28.18m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("da436ba6-0830-4e4f-8037-dc7875df8285"),
                column: "Price",
                value: 12.11m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dcb96166-3eff-4d2d-b79f-06315ec3f2be"),
                column: "Price",
                value: 28.78m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f9fa7a55-28ef-4dac-a938-170bc8c8e86e"),
                column: "Price",
                value: 27.65m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fe7edab4-2b64-416a-b020-5bfe8b0790bd"),
                column: "Price",
                value: 27.01m);
        }
    }
}
