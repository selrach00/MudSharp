using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudSharp.Data.Migrations
{
    public partial class RenameActorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_ActorStats_StatsId",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Actor_OwnerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Actor_ActorId",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Actor_ActorId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_StatsId",
                table: "Actors",
                newName: "IX_Actors_StatsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_ActorStats_StatsId",
                table: "Actors",
                column: "StatsId",
                principalTable: "ActorStats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Actors_OwnerId",
                table: "Items",
                column: "OwnerId",
                principalTable: "Actors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Actors_ActorId",
                table: "NPCs",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Actors_ActorId",
                table: "Players",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_ActorStats_StatsId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Actors_OwnerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Actors_ActorId",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Actors_ActorId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_StatsId",
                table: "Actor",
                newName: "IX_Actor_StatsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_ActorStats_StatsId",
                table: "Actor",
                column: "StatsId",
                principalTable: "ActorStats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Actor_OwnerId",
                table: "Items",
                column: "OwnerId",
                principalTable: "Actor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Actor_ActorId",
                table: "NPCs",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Actor_ActorId",
                table: "Players",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
