using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackathonVZ.Data.Migrations
{
    public partial class RoundQuestionnullableModifier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoundQuestions_Modifiers_ModifierId",
                table: "RoundQuestions");

            migrationBuilder.AlterColumn<long>(
                name: "ModifierId",
                table: "RoundQuestions",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_RoundQuestions_Modifiers_ModifierId",
                table: "RoundQuestions",
                column: "ModifierId",
                principalTable: "Modifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoundQuestions_Modifiers_ModifierId",
                table: "RoundQuestions");

            migrationBuilder.AlterColumn<long>(
                name: "ModifierId",
                table: "RoundQuestions",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundQuestions_Modifiers_ModifierId",
                table: "RoundQuestions",
                column: "ModifierId",
                principalTable: "Modifiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
