using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTicketAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addCartTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartTicket",
                columns: table => new
                {
                    CartsId = table.Column<int>(type: "integer", nullable: false),
                    TicketsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTicket", x => new { x.CartsId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_CartTicket_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartTicket_TicketsId",
                table: "CartTicket",
                column: "TicketsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartTicket");
        }
    }
}
