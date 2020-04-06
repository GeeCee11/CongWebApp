using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CongWebApp.Migrations
{
    public partial class Member_FieldServiceGroup_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FieldServiceGroup",
                columns: table => new
                {
                    FieldServiceGroupID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 30, nullable: true),
                    Suburb = table.Column<string>(maxLength: 30, nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: true),
                    ZIP = table.Column<string>(maxLength: 10, nullable: true),
                    Day = table.Column<int>(nullable: true),
                    Time = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldServiceGroup", x => x.FieldServiceGroupID);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(maxLength: 20, nullable: true),
                    Suffix = table.Column<string>(maxLength: 5, nullable: true),
                    FullName = table.Column<string>(maxLength: 60, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Baptised = table.Column<int>(nullable: false),
                    DateImmersed = table.Column<DateTime>(nullable: true),
                    Calling = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 30, nullable: true),
                    Suburb = table.Column<string>(maxLength: 30, nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: true),
                    ZIP = table.Column<string>(maxLength: 10, nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Home = table.Column<string>(nullable: true),
                    Work = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 200, nullable: true),
                    FieldServiceGroupID = table.Column<int>(nullable: true),
                    EcName = table.Column<string>(maxLength: 60, nullable: true),
                    EcRelationship = table.Column<string>(maxLength: 25, nullable: true),
                    EcMobile = table.Column<string>(nullable: true),
                    EcHome = table.Column<string>(nullable: true),
                    EcWork = table.Column<string>(nullable: true),
                    DcName = table.Column<string>(maxLength: 60, nullable: true),
                    DcRelationship = table.Column<string>(maxLength: 25, nullable: true),
                    DcMobile = table.Column<string>(nullable: true),
                    DcHome = table.Column<string>(nullable: true),
                    DcWork = table.Column<string>(nullable: true),
                    SpecialNeeds = table.Column<string>(maxLength: 1000, nullable: true),
                    Elderly = table.Column<int>(nullable: false),
                    Infirm = table.Column<int>(nullable: false),
                    Blind = table.Column<int>(nullable: false),
                    Deaf = table.Column<int>(nullable: false),
                    AssistancePlan = table.Column<string>(maxLength: 1000, nullable: true),
                    NonBelieving = table.Column<string>(maxLength: 1000, nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusDate = table.Column<DateTime>(nullable: false),
                    DC50 = table.Column<int>(nullable: false),
                    DC50Expiry = table.Column<DateTime>(nullable: true),
                    PublicWitnessing = table.Column<int>(nullable: false),
                    SMPW = table.Column<int>(nullable: false),
                    MovedIn = table.Column<DateTime>(nullable: false),
                    BeginPublisher = table.Column<DateTime>(nullable: false),
                    CAP = table.Column<int>(nullable: false),
                    FamilyHead = table.Column<int>(nullable: false),
                    FamilyHeadId = table.Column<int>(nullable: true),
                    Visible = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Member_FieldServiceGroup_FieldServiceGroupID",
                        column: x => x.FieldServiceGroupID,
                        principalTable: "FieldServiceGroup",
                        principalColumn: "FieldServiceGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_FieldServiceGroupID",
                table: "Member",
                column: "FieldServiceGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "FieldServiceGroup");
        }
    }
}
