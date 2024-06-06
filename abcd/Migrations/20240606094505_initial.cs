using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace abcd.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    IdCustomers = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.IdCustomers);
                });

            migrationBuilder.CreateTable(
                name: "productsBrands",
                columns: table => new
                {
                    IdBrand = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandProductsQuanlity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsBrands", x => x.IdBrand);
                });

            migrationBuilder.CreateTable(
                name: "productsCameras",
                columns: table => new
                {
                    CameraID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CameraStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraSpecialFeature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsCameras", x => x.CameraID);
                });

            migrationBuilder.CreateTable(
                name: "productsDisplays",
                columns: table => new
                {
                    DisplayID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplaySize = table.Column<float>(type: "real", nullable: false),
                    DisplayPrice = table.Column<float>(type: "real", nullable: false),
                    DisplayBrightness = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsDisplays", x => x.DisplayID);
                });

            migrationBuilder.CreateTable(
                name: "vounchers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVouncher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quanlity = table.Column<int>(type: "int", nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vounchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    IdCart = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCustomers = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.IdCart);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_IdCustomers",
                        column: x => x.IdCustomers,
                        principalTable: "Customers",
                        principalColumn: "IdCustomers",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IMEI = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdBrand = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CameraID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IdCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    productsbrandsIdBrand = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductsCamerasCameraID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductsDisplaysDisplayID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_Products_Categories_IdCategory",
                        column: x => x.IdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_productsBrands_productsbrandsIdBrand",
                        column: x => x.productsbrandsIdBrand,
                        principalTable: "productsBrands",
                        principalColumn: "IdBrand");
                    table.ForeignKey(
                        name: "FK_Products_productsCameras_ProductsCamerasCameraID",
                        column: x => x.ProductsCamerasCameraID,
                        principalTable: "productsCameras",
                        principalColumn: "CameraID");
                    table.ForeignKey(
                        name: "FK_Products_productsDisplays_ProductsDisplaysDisplayID",
                        column: x => x.ProductsDisplaysDisplayID,
                        principalTable: "productsDisplays",
                        principalColumn: "DisplayID");
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Money = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdVouncher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VounchersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.IdBill);
                    table.ForeignKey(
                        name: "FK_Bills_Customers_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customers",
                        principalColumn: "IdCustomers",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_vounchers_VounchersId",
                        column: x => x.VounchersId,
                        principalTable: "vounchers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cart_Detail",
                columns: table => new
                {
                    IdCart_Detail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCart = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart_Detail", x => x.IdCart_Detail);
                    table.ForeignKey(
                        name: "FK_Cart_Detail_Carts_IdCart",
                        column: x => x.IdCart,
                        principalTable: "Carts",
                        principalColumn: "IdCart",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Detail_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_IdBill",
                        column: x => x.IdBill,
                        principalTable: "Bills",
                        principalColumn: "IdBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdBill",
                table: "BillDetails",
                column: "IdBill");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdProduct",
                table: "BillDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_IdCustomer",
                table: "Bills",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_VounchersId",
                table: "Bills",
                column: "VounchersId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Detail_IdCart",
                table: "Cart_Detail",
                column: "IdCart");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Detail_IdProduct",
                table: "Cart_Detail",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_IdCustomers",
                table: "Carts",
                column: "IdCustomers",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneNumber",
                table: "Customers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdCategory",
                table: "Products",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IMEI",
                table: "Products",
                column: "IMEI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_productsbrandsIdBrand",
                table: "Products",
                column: "productsbrandsIdBrand");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductsCamerasCameraID",
                table: "Products",
                column: "ProductsCamerasCameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductsDisplaysDisplayID",
                table: "Products",
                column: "ProductsDisplaysDisplayID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "Cart_Detail");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "vounchers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "productsBrands");

            migrationBuilder.DropTable(
                name: "productsCameras");

            migrationBuilder.DropTable(
                name: "productsDisplays");
        }
    }
}
