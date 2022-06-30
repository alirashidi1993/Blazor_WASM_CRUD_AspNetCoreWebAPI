﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCrudApp.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "People",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(512)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People",
                schema: "dbo");
        }
    }
}
