using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TE.Data.Migrations
{
    /// <inheritdoc />
    public partial class tf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taches_Member_MemberMatricule",
                table: "Taches");

            migrationBuilder.DropForeignKey(
                name: "FK_Taches_Sprint_SprintId",
                table: "Taches");

            migrationBuilder.DropIndex(
                name: "IX_Taches_MemberMatricule",
                table: "Taches");

            migrationBuilder.DropIndex(
                name: "IX_Taches_SprintId",
                table: "Taches");

            migrationBuilder.DropColumn(
                name: "MemberMatricule",
                table: "Taches");

            migrationBuilder.DropColumn(
                name: "SprintId",
                table: "Taches");

            migrationBuilder.CreateIndex(
                name: "IX_Taches_MemberKey",
                table: "Taches",
                column: "MemberKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Taches_Member_MemberKey",
                table: "Taches",
                column: "MemberKey",
                principalTable: "Member",
                principalColumn: "Matricule",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taches_Sprint_SprintKey",
                table: "Taches",
                column: "SprintKey",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taches_Member_MemberKey",
                table: "Taches");

            migrationBuilder.DropForeignKey(
                name: "FK_Taches_Sprint_SprintKey",
                table: "Taches");

            migrationBuilder.DropIndex(
                name: "IX_Taches_MemberKey",
                table: "Taches");

            migrationBuilder.AddColumn<string>(
                name: "MemberMatricule",
                table: "Taches",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SprintId",
                table: "Taches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Taches_MemberMatricule",
                table: "Taches",
                column: "MemberMatricule");

            migrationBuilder.CreateIndex(
                name: "IX_Taches_SprintId",
                table: "Taches",
                column: "SprintId");

            migrationBuilder.AddForeignKey(
                name: "FK_Taches_Member_MemberMatricule",
                table: "Taches",
                column: "MemberMatricule",
                principalTable: "Member",
                principalColumn: "Matricule",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taches_Sprint_SprintId",
                table: "Taches",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
