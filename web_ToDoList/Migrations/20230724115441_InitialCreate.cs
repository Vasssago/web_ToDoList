using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.AddColumn<string>(
			name: "NickName",
			table: "AspNetUsers",
			nullable: true);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropColumn(
			name: "NickName",
			table: "AspNetUsers");
		}
    }
}
