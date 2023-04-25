using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTicketAz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addEventPriceType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventPriceType",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "integer", nullable: false),
                    PriceTypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPriceType", x => new { x.EventsId, x.PriceTypesId });
                    table.ForeignKey(
                        name: "FK_EventPriceType_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventPriceType_PriceTypes_PriceTypesId",
                        column: x => x.PriceTypesId,
                        principalTable: "PriceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventPriceType_PriceTypesId",
                table: "EventPriceType",
                column: "PriceTypesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventPriceType");
        }
    }
}
