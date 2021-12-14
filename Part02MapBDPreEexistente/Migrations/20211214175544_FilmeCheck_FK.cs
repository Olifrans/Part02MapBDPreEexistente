﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Part02MapBDPreEexistente.Migrations
{
    public partial class FilmeCheck_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var slq = @"ALTER TABLE[dbo].[film]
                ADD CONSTRAINT[check_rating] CHECK (
                        [rating]='NC-17' OR 
                        [rating]='R' OR 
                        [rating]='PG-13' OR 
                        [rating]='PG' OR 
                        [rating]='G')";
            migrationBuilder.Sql(slq);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE[dbo].[film] DROP CONSTRAINT[check_rating]");
        }
    }
}
