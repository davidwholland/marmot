using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marmot.Data.Migrations
{
    public partial class RenameUserTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AppUserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AppUserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AppUserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AppUserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AppRoleClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AppRole");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AppUserRole",
                newName: "IX_AppUserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AppUserLogin",
                newName: "IX_AppUserLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AppUserClaim",
                newName: "IX_AppUserClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AppRoleClaim",
                newName: "IX_AppRoleClaim_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserToken",
                table: "AppUserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserRole",
                table: "AppUserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserLogin",
                table: "AppUserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserClaim",
                table: "AppUserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleClaim",
                table: "AppRoleClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AppRole",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRoleClaim_AppRole_RoleId",
                table: "AppRoleClaim",
                column: "RoleId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserClaim_AppUser_UserId",
                table: "AppUserClaim",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserLogin_AppUser_UserId",
                table: "AppUserLogin",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserRole_AppRole_RoleId",
                table: "AppUserRole",
                column: "RoleId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserRole_AppUser_UserId",
                table: "AppUserRole",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppRoleClaim_AppRole_RoleId",
                table: "AppRoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserClaim_AppUser_UserId",
                table: "AppUserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserLogin_AppUser_UserId",
                table: "AppUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserRole_AppRole_RoleId",
                table: "AppUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserRole_AppUser_UserId",
                table: "AppUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserToken",
                table: "AppUserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserRole",
                table: "AppUserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserLogin",
                table: "AppUserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserClaim",
                table: "AppUserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleClaim",
                table: "AppRoleClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AppRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "AppUserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AppUserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AppUserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AppUserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AppRoleClaim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AppRole",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AspNetUsers");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserRole_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserLogin_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserClaim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AppRoleClaim_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
