using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderId",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "CustomerAccounts",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts",
                newName: "IX_CustomerAccounts_AppUserID");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "CustomerAccountProcesses",
                newName: "SenderID");

            migrationBuilder.RenameColumn(
                name: "ReceiverId",
                table: "CustomerAccountProcesses",
                newName: "ReceiverID");

            migrationBuilder.RenameColumn(
                name: "Processtype",
                table: "CustomerAccountProcesses",
                newName: "ProcessType");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesses_SenderId",
                table: "CustomerAccountProcesses",
                newName: "IX_CustomerAccountProcesses_SenderID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesses_ReceiverId",
                table: "CustomerAccountProcesses",
                newName: "IX_CustomerAccountProcesses_ReceiverID");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAccountNumber",
                table: "CustomerAccounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CustomerAccountProcesses",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses",
                column: "ReceiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesses",
                column: "SenderID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserID",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CustomerAccountProcesses");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "CustomerAccounts",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccounts_AppUserID",
                table: "CustomerAccounts",
                newName: "IX_CustomerAccounts_AppUserId");

            migrationBuilder.RenameColumn(
                name: "SenderID",
                table: "CustomerAccountProcesses",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "ReceiverID",
                table: "CustomerAccountProcesses",
                newName: "ReceiverId");

            migrationBuilder.RenameColumn(
                name: "ProcessType",
                table: "CustomerAccountProcesses",
                newName: "Processtype");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesses_SenderID",
                table: "CustomerAccountProcesses",
                newName: "IX_CustomerAccountProcesses_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAccountProcesses_ReceiverID",
                table: "CustomerAccountProcesses",
                newName: "IX_CustomerAccountProcesses_ReceiverId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAccountNumber",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverId",
                table: "CustomerAccountProcesses",
                column: "ReceiverId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderId",
                table: "CustomerAccountProcesses",
                column: "SenderId",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
