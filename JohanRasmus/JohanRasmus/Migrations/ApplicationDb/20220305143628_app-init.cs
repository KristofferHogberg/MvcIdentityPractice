using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohanRasmus.Migrations.ApplicationDb
{
	public partial class appinit : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
					name: "UserNotes",
					columns: table => new
					{
						Id = table.Column<int>(type: "int", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
						IdentityId = table.Column<int>(type: "int", nullable: false),
						Note = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
						Created = table.Column<DateTime>(type: "datetime2", nullable: false)
					},
					constraints: table =>
					{
						table.PrimaryKey("PK_UserNotes", x => x.Id);
					});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
					name: "UserNotes");
		}
	}
}