using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackathonVZ.Data.Migrations
{
    public partial class RemovedAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Images_AvatarId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_Images_AvatarId",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_UserProfiles_AvatarId",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Teams_AvatarId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "Teams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AvatarId",
                table: "UserProfiles",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AvatarId",
                table: "Teams",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_AvatarId",
                table: "UserProfiles",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_AvatarId",
                table: "Teams",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Images_AvatarId",
                table: "Teams",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_Images_AvatarId",
                table: "UserProfiles",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
