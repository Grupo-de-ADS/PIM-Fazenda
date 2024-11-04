using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentosCrud.Migrations
{
    /// <inheritdoc />
    public partial class criacao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_phone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_is_juridic = table.Column<bool>(type: "bit", nullable: false),
                    customer_document = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    farm_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    farm_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    farm_uf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    farm_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    farm_distric = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    farm_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.farm_id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    sp_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sp_corporate_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sp_cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sp_responsible_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sp_responsible_cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sp_responsible_phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.sp_id);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    tp_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sp_corporate_name = table.Column<int>(type: "int", nullable: false),
                    tp_responsible_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tp_responsible_cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tp_responsible_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tp_plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tp_weight_supported = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tp_size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.tp_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Farm");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "Transport");
        }
    }
}
