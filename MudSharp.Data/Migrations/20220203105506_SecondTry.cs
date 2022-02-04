using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudSharp.Data.Migrations
{
    public partial class SecondTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Actor_NonPlayerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Actor_PlayerId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Actor");

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NPCs_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    InstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NPCs_ActorId",
                table: "NPCs",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_ActorId",
                table: "Players",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NPCs_NonPlayerId",
                table: "Items",
                column: "NonPlayerId",
                principalTable: "NPCs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Players_PlayerId",
                table: "Items",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NPCs_NonPlayerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Players_PlayerId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Actor_NonPlayerId",
                table: "Items",
                column: "NonPlayerId",
                principalTable: "Actor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Actor_PlayerId",
                table: "Items",
                column: "PlayerId",
                principalTable: "Actor",
                principalColumn: "Id");
        }
    }
}
