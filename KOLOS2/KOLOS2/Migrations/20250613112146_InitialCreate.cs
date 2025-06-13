using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOLOS2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Nursery",
                columns: table => new
                {
                    NurseryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstablishsedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nursery", x => x.NurseryId);
                });

            migrationBuilder.CreateTable(
                name: "Tree_Species",
                columns: table => new
                {
                    SpaciesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LatinName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GrowthTimeInYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tree_Species", x => x.SpaciesId);
                });

            migrationBuilder.CreateTable(
                name: "Seedling_Batch",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NurseryId = table.Column<int>(type: "int", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SownDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TreeSpeciesSpaciesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seedling_Batch", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_Seedling_Batch_Nursery_NurseryId",
                        column: x => x.NurseryId,
                        principalTable: "Nursery",
                        principalColumn: "NurseryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seedling_Batch_Tree_Species_TreeSpeciesSpaciesId",
                        column: x => x.TreeSpeciesSpaciesId,
                        principalTable: "Tree_Species",
                        principalColumn: "SpaciesId");
                });

            migrationBuilder.CreateTable(
                name: "Responsible",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsible", x => new { x.BatchId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_Responsible_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responsible_Seedling_Batch_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Seedling_Batch",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "adam", new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jesion" },
                    { 2, "adam", new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jesion" }
                });

            migrationBuilder.InsertData(
                table: "Nursery",
                columns: new[] { "NurseryId", "EstablishsedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nur1" },
                    { 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nur2" }
                });

            migrationBuilder.InsertData(
                table: "Tree_Species",
                columns: new[] { "SpaciesId", "GrowthTimeInYears", "LatinName" },
                values: new object[,]
                {
                    { 1, 12, "dab" },
                    { 2, 12, "wierzba" },
                    { 3, 12, "jesion" }
                });

            migrationBuilder.InsertData(
                table: "Seedling_Batch",
                columns: new[] { "BatchId", "NurseryId", "Quantity", "ReadyDate", "SownDate", "SpeciesId", "TreeSpeciesSpaciesId" },
                values: new object[,]
                {
                    { 1, 1, 20, null, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, 2, 20, null, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 3, 1, 20, null, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null },
                    { 4, 1, 20, null, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null }
                });

            migrationBuilder.InsertData(
                table: "Responsible",
                columns: new[] { "BatchId", "EmployeeId", "Role" },
                values: new object[,]
                {
                    { 1, 1, "role1" },
                    { 2, 1, "role1" },
                    { 3, 1, "role2" },
                    { 3, 2, "role2" },
                    { 4, 1, "role1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responsible_EmployeeId",
                table: "Responsible",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Seedling_Batch_NurseryId",
                table: "Seedling_Batch",
                column: "NurseryId");

            migrationBuilder.CreateIndex(
                name: "IX_Seedling_Batch_TreeSpeciesSpaciesId",
                table: "Seedling_Batch",
                column: "TreeSpeciesSpaciesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responsible");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Seedling_Batch");

            migrationBuilder.DropTable(
                name: "Nursery");

            migrationBuilder.DropTable(
                name: "Tree_Species");
        }
    }
}
