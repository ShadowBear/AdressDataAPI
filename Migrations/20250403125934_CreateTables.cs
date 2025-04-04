using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdressDataAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Contacts",
                newName: "FileID");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "Contacts",
                newName: "Typ");

            migrationBuilder.RenameColumn(
                name: "ContactValue",
                table: "Contacts",
                newName: "Kommunikationsadresse");

            migrationBuilder.RenameColumn(
                name: "CaseNumber",
                table: "Contacts",
                newName: "ImportDatum");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Addresses",
                newName: "Vorname");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Addresses",
                newName: "Titel");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Addresses",
                newName: "Straße");

            migrationBuilder.RenameColumn(
                name: "IsCurrent",
                table: "Addresses",
                newName: "AktuelleAnschrift");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "Addresses",
                newName: "Rechtsform");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Addresses",
                newName: "PLZ");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Addresses",
                newName: "Ort");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Addresses",
                newName: "Nachname");

            migrationBuilder.RenameColumn(
                name: "CaseNumber",
                table: "Addresses",
                newName: "Land");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Anmerkung",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gehoert",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressStatus",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Aktenzeichen",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Anrede",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Datenquelle",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FileID",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Hausnummer",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Import",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anmerkung",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Gehoert",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AddressStatus",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Aktenzeichen",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Anrede",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Datenquelle",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "FileID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Hausnummer",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Import",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Typ",
                table: "Contacts",
                newName: "Owner");

            migrationBuilder.RenameColumn(
                name: "Kommunikationsadresse",
                table: "Contacts",
                newName: "ContactValue");

            migrationBuilder.RenameColumn(
                name: "ImportDatum",
                table: "Contacts",
                newName: "CaseNumber");

            migrationBuilder.RenameColumn(
                name: "FileID",
                table: "Contacts",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Vorname",
                table: "Addresses",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Titel",
                table: "Addresses",
                newName: "PostalCode");

            migrationBuilder.RenameColumn(
                name: "Straße",
                table: "Addresses",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Rechtsform",
                table: "Addresses",
                newName: "HouseNumber");

            migrationBuilder.RenameColumn(
                name: "PLZ",
                table: "Addresses",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Ort",
                table: "Addresses",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Nachname",
                table: "Addresses",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Land",
                table: "Addresses",
                newName: "CaseNumber");

            migrationBuilder.RenameColumn(
                name: "AktuelleAnschrift",
                table: "Addresses",
                newName: "IsCurrent");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
