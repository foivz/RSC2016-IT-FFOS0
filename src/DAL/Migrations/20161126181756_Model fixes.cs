using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackathonVZ.Data.Migrations
{
    public partial class Modelfixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoundQuestions_QuizRounds_RoundId",
                table: "RoundQuestions");

            migrationBuilder.DropIndex(
                name: "IX_RoundQuestions_RoundId",
                table: "RoundQuestions");

            migrationBuilder.AddColumn<bool>(
                name: "Correct",
                table: "TeamAnswers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Locked",
                table: "RoundQuestions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                table: "Questions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ImageId",
                table: "Questions",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Images_ImageId",
                table: "Questions",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Images_ImageId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ImageId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Correct",
                table: "TeamAnswers");

            migrationBuilder.DropColumn(
                name: "Locked",
                table: "RoundQuestions");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Questions");

            migrationBuilder.CreateIndex(
                name: "IX_RoundQuestions_RoundId",
                table: "RoundQuestions",
                column: "RoundId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoundQuestions_QuizRounds_RoundId",
                table: "RoundQuestions",
                column: "RoundId",
                principalTable: "QuizRounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
