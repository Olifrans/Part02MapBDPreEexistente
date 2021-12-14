﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Part02MapBDPreEexistente.Migrations
{
    public partial class IndiceAtorUltimoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "idx_actor_last_name",
                table: "actor",
                column: "last_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idx_actor_last_name",
                table: "actor");
        }
    }
}
