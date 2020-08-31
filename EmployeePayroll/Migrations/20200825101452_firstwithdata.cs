using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeePayroll.Migrations
{
    public partial class firstwithdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpenBalances_DeductionLines_DeductionLinesId",
                table: "OpenBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_OpenBalances_SuperLines_SuperLinesId",
                table: "OpenBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_PayTemplates_DeductionLines_DeductionLinesId",
                table: "PayTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_PayTemplates_SuperLines_SuperLinesId",
                table: "PayTemplates");

            migrationBuilder.AlterColumn<Guid>(
                name: "SuperLinesId",
                table: "PayTemplates",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeductionLinesId",
                table: "PayTemplates",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EarningId",
                table: "PayTemplates",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "PayTemplates",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LinesId",
                table: "PayTemplates",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReId",
                table: "PayTemplates",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SuperLinesId",
                table: "OpenBalances",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DeductionLinesId",
                table: "OpenBalances",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EarningId",
                table: "OpenBalances",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LinesId",
                table: "OpenBalances",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReId",
                table: "OpenBalances",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "Bank",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OpenBalances_DeductionLines_DeductionLinesId",
                table: "OpenBalances",
                column: "DeductionLinesId",
                principalTable: "DeductionLines",
                principalColumn: "DeductionLinesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpenBalances_SuperLines_SuperLinesId",
                table: "OpenBalances",
                column: "SuperLinesId",
                principalTable: "SuperLines",
                principalColumn: "SuperLinesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayTemplates_DeductionLines_DeductionLinesId",
                table: "PayTemplates",
                column: "DeductionLinesId",
                principalTable: "DeductionLines",
                principalColumn: "DeductionLinesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayTemplates_SuperLines_SuperLinesId",
                table: "PayTemplates",
                column: "SuperLinesId",
                principalTable: "SuperLines",
                principalColumn: "SuperLinesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpenBalances_DeductionLines_DeductionLinesId",
                table: "OpenBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_OpenBalances_SuperLines_SuperLinesId",
                table: "OpenBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_PayTemplates_DeductionLines_DeductionLinesId",
                table: "PayTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_PayTemplates_SuperLines_SuperLinesId",
                table: "PayTemplates");

            migrationBuilder.DropColumn(
                name: "EarningId",
                table: "PayTemplates");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "PayTemplates");

            migrationBuilder.DropColumn(
                name: "LinesId",
                table: "PayTemplates");

            migrationBuilder.DropColumn(
                name: "ReId",
                table: "PayTemplates");

            migrationBuilder.DropColumn(
                name: "EarningId",
                table: "OpenBalances");

            migrationBuilder.DropColumn(
                name: "LinesId",
                table: "OpenBalances");

            migrationBuilder.DropColumn(
                name: "ReId",
                table: "OpenBalances");

            migrationBuilder.AlterColumn<Guid>(
                name: "SuperLinesId",
                table: "PayTemplates",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "DeductionLinesId",
                table: "PayTemplates",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "SuperLinesId",
                table: "OpenBalances",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "DeductionLinesId",
                table: "OpenBalances",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "AccountNumber",
                table: "Bank",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OpenBalances_DeductionLines_DeductionLinesId",
                table: "OpenBalances",
                column: "DeductionLinesId",
                principalTable: "DeductionLines",
                principalColumn: "DeductionLinesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpenBalances_SuperLines_SuperLinesId",
                table: "OpenBalances",
                column: "SuperLinesId",
                principalTable: "SuperLines",
                principalColumn: "SuperLinesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayTemplates_DeductionLines_DeductionLinesId",
                table: "PayTemplates",
                column: "DeductionLinesId",
                principalTable: "DeductionLines",
                principalColumn: "DeductionLinesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayTemplates_SuperLines_SuperLinesId",
                table: "PayTemplates",
                column: "SuperLinesId",
                principalTable: "SuperLines",
                principalColumn: "SuperLinesId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
