using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSubscriber = table.Column<bool>(type: "bit", nullable: false),
                    SubscribeType = table.Column<int>(type: "int", nullable: false),
                    SubscribeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscribeEndingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleofContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicles_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Materials_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WashingProcesses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    IsQueue = table.Column<bool>(type: "bit", nullable: false),
                    WashingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    VehiclePollution = table.Column<double>(type: "float", nullable: true),
                    WaterConsumption = table.Column<double>(type: "float", nullable: true),
                    ProcessType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashingProcesses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WashingProcesses_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WashingProcesses_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialWashingProcess",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    WashingProcessID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialWashingProcess", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaterialWashingProcess_Materials_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Materials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialWashingProcess_WashingProcesses_WashingProcessID",
                        column: x => x.WashingProcessID,
                        principalTable: "WashingProcesses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "IsActive", "IsSubscriber", "ModifiedDate", "Name", "SubscribeDate", "SubscribeEndingDate", "SubscribeType" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(442), null, true, false, null, "Mustafa Tez", null, null, 3 },
                    { 2, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(446), null, true, true, null, "Mert Demirci", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 3, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(450), null, true, true, null, "Levent Adnan", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 4, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(452), null, true, false, null, "Havva Temel", null, null, 3 },
                    { 5, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(453), null, true, true, null, "İdris Bahadır", new DateTime(2022, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 6, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(455), null, true, true, null, "Okan Şahin", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0 },
                    { 7, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(457), null, true, true, null, "Turgay Mert", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0 },
                    { 8, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(458), null, true, true, null, "Gözde Emrah", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 },
                    { 9, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(460), null, true, false, null, "Rıdvan Demir", null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Address", "CreatedDate", "DeletedDate", "FirstName", "IsActive", "LastName", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Unknown", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(596), null, "Unknown", true, "Unknown", null, "Unknown" },
                    { 2, "Aydın/Türkiye", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(598), null, "Kağan", true, "Eriş", null, "Washer" },
                    { 3, "Bursa/Türkiye", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(644), null, "Mehmet Mücahid", true, "Bilge", null, "Washer" },
                    { 4, "Ankara/Türkiye", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(645), null, "Ali Furkan", true, "Terzi", null, "Washer" },
                    { 5, "İzmir/Türkiye", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(646), null, "İsmail", true, "Tosun", null, "Washer" },
                    { 6, "İstanbul/Türkiye", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(647), null, "Hakan", true, "Varyemez", null, "Washer" },
                    { 7, "Mersin/Türkiye", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(648), null, "Metin", true, "Tekin", null, "Washer" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "CompanyName", "ContactName", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "TitleofContact" },
                values: new object[,]
                {
                    { 1, "Breitenberg", "Roob", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(690), null, true, null, "Manager" },
                    { 2, "Johnston and Sons", "Gutkowski", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(693), null, true, null, "Salesman" },
                    { 3, "Stroman Group", "Merlyn", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(694), null, true, null, "Manager" },
                    { 4, "Boehm LLC", "Ashley", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(695), null, true, null, "Owner" },
                    { 5, "West and Sons", "Tom", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(698), null, true, null, "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "IsActive", "MaterialName", "MaterialPrice", "ModifiedDate", "Stock", "SupplierID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(664), null, true, "Car wash brush", 50m, null, 200, 1 },
                    { 2, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(668), null, true, "High-pressure washer", 250m, null, 8, 3 },
                    { 3, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(669), null, true, "Foam cannon", 35m, null, 200, 2 },
                    { 4, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(670), null, true, "Buckets", 21m, null, 80, 2 },
                    { 5, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(671), null, true, "Water hoses", 8m, null, 25, 5 },
                    { 6, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(672), null, true, "Upholstery cleaners", 15m, null, 55, 1 },
                    { 7, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(673), null, true, "Wheel and tire brushes", 15m, null, 150, 4 },
                    { 8, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(674), null, true, "Vacuum cleaners", 5m, null, 200, 3 },
                    { 9, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(675), null, true, "Glass cleaner", 6m, null, 177, 4 },
                    { 10, new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(676), null, true, "Cleaning towels", 3m, null, 250, 2 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "ID", "BodyType", "Brand", "CreatedDate", "CustomerID", "DeletedDate", "IsActive", "Model", "ModifiedDate", "Plate", "ProductionDate" },
                values: new object[,]
                {
                    { 1, 1, "Volkswagen", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(567), 1, null, true, "Golf", null, "09 ZR 401", new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "Peugeot", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(570), 1, null, true, "3008", null, "45 KA 4045", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, "Fiat", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(572), 2, null, true, "Egea Cross", null, "34 RT 2401", new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, "Opel", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(573), 3, null, true, "Corsa", null, "35 TR 1985", new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 0, "Toyota", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(575), 4, null, true, "Corolla", null, "10 KA 3000", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, "Volvo", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(576), 5, null, true, "V90 Cross", null, "06 BG 732", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, "Toyota", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(577), 6, null, true, "Hilux", null, "07 UJ 121", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 5, "Ford", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(579), 7, null, true, "Tourneo", null, "03 ACC 665", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 6, "Citroen", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(580), 8, null, true, "Jumper", null, "46 RFV 321", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 7, "BMW", new DateTime(2023, 9, 28, 11, 1, 38, 837, DateTimeKind.Local).AddTicks(582), 9, null, true, "420D M Sport", null, "34 TG 221", new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_SupplierID",
                table: "Materials",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWashingProcess_MaterialID",
                table: "MaterialWashingProcess",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWashingProcess_WashingProcessID",
                table: "MaterialWashingProcess",
                column: "WashingProcessID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerID",
                table: "Vehicles",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_WashingProcesses_EmployeeID",
                table: "WashingProcesses",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_WashingProcesses_VehicleID",
                table: "WashingProcesses",
                column: "VehicleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialWashingProcess");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "WashingProcesses");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
