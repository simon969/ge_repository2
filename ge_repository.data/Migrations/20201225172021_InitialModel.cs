using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ge_repository.data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ge_group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    managerId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    homepageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    project_operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    createdId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    createdDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    editedId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    editedDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pflag = table.Column<int>(type: "int", nullable: false),
                    locName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locPostcode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locMapReference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locEast = table.Column<double>(type: "float", nullable: true),
                    locNorth = table.Column<double>(type: "float", nullable: true),
                    locLevel = table.Column<double>(type: "float", nullable: true),
                    datumProjection = table.Column<int>(type: "int", nullable: false),
                    locLatitude = table.Column<double>(type: "float", nullable: true),
                    locLongitude = table.Column<double>(type: "float", nullable: true),
                    locHeight = table.Column<double>(type: "float", nullable: true),
                    locX = table.Column<double>(type: "float", nullable: true),
                    locY = table.Column<double>(type: "float", nullable: true),
                    locZ = table.Column<double>(type: "float", nullable: true),
                    folder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locOtherDb = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ge_user",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastLoggedIn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ge_project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    keywords = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    homepageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cstatus = table.Column<int>(type: "int", nullable: false),
                    pstatus = table.Column<int>(type: "int", nullable: false),
                    managerId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    verex = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    otherDbConnectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    esriConnectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    groupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    createdId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    createdDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    editedId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    editedDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pflag = table.Column<int>(type: "int", nullable: false),
                    locName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locPostcode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locMapReference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locEast = table.Column<double>(type: "float", nullable: true),
                    locNorth = table.Column<double>(type: "float", nullable: true),
                    locLevel = table.Column<double>(type: "float", nullable: true),
                    datumProjection = table.Column<int>(type: "int", nullable: false),
                    locLatitude = table.Column<double>(type: "float", nullable: true),
                    locLongitude = table.Column<double>(type: "float", nullable: true),
                    locHeight = table.Column<double>(type: "float", nullable: true),
                    locX = table.Column<double>(type: "float", nullable: true),
                    locY = table.Column<double>(type: "float", nullable: true),
                    locZ = table.Column<double>(type: "float", nullable: true),
                    folder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locOtherDb = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ge_project_ge_group_groupId",
                        column: x => x.groupId,
                        principalTable: "ge_group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ge_event",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    createdDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    returnUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ge_event_ge_user_createdId",
                        column: x => x.createdId,
                        principalTable: "ge_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ge_data",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    data_binary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    data_string = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_xml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filename = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    filesize = table.Column<long>(type: "bigint", nullable: true),
                    fileext = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    filetype = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    encoding = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    filedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    cstatus = table.Column<int>(type: "int", nullable: true),
                    pstatus = table.Column<int>(type: "int", nullable: true),
                    qstatus = table.Column<int>(type: "int", nullable: true),
                    version = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    vstatus = table.Column<int>(type: "int", nullable: true),
                    createdId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    createdDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    editedId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    editedDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pflag = table.Column<int>(type: "int", nullable: true),
                    locName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locPostcode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locMapReference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locEast = table.Column<double>(type: "float", nullable: true),
                    locNorth = table.Column<double>(type: "float", nullable: true),
                    locLevel = table.Column<double>(type: "float", nullable: true),
                    datumProjection = table.Column<int>(type: "int", nullable: true),
                    locLatitude = table.Column<double>(type: "float", nullable: true),
                    locLongitude = table.Column<double>(type: "float", nullable: true),
                    locHeight = table.Column<double>(type: "float", nullable: true),
                    locX = table.Column<double>(type: "float", nullable: true),
                    locY = table.Column<double>(type: "float", nullable: true),
                    locZ = table.Column<double>(type: "float", nullable: true),
                    folder = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    locOtherDb = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ge_data_ge_project_projectId",
                        column: x => x.projectId,
                        principalTable: "ge_project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ge_user_ops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    user_operations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    groupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    createdId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    createdDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    editedId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    editedDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pflag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_user_ops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ge_user_ops_ge_group_groupId",
                        column: x => x.groupId,
                        principalTable: "ge_group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ge_user_ops_ge_project_projectId",
                        column: x => x.projectId,
                        principalTable: "ge_project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ge_user_ops_ge_user_userId1",
                        column: x => x.userId1,
                        principalTable: "ge_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ge_transform",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    queryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    styleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    add_data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storedprocedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_endpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cstatus = table.Column<int>(type: "int", nullable: false),
                    pstatus = table.Column<int>(type: "int", nullable: false),
                    qstatus = table.Column<int>(type: "int", nullable: false),
                    version = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    vstatus = table.Column<int>(type: "int", nullable: false),
                    createdId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    createdDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    editedId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    editedDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    operations = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    pflag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_transform", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ge_transform_ge_data_dataId",
                        column: x => x.dataId,
                        principalTable: "ge_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ge_transform_ge_data_queryId",
                        column: x => x.queryId,
                        principalTable: "ge_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ge_transform_ge_data_styleId",
                        column: x => x.styleId,
                        principalTable: "ge_data",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ge_transform_ge_project_projectId",
                        column: x => x.projectId,
                        principalTable: "ge_project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ge_data_projectId",
                table: "ge_data",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_event_createdId",
                table: "ge_event",
                column: "createdId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_project_groupId",
                table: "ge_project",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_transform_dataId",
                table: "ge_transform",
                column: "dataId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_transform_projectId",
                table: "ge_transform",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_transform_queryId",
                table: "ge_transform",
                column: "queryId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_transform_styleId",
                table: "ge_transform",
                column: "styleId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_user_ops_groupId",
                table: "ge_user_ops",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_user_ops_projectId",
                table: "ge_user_ops",
                column: "projectId");

            migrationBuilder.CreateIndex(
                name: "IX_ge_user_ops_userId1",
                table: "ge_user_ops",
                column: "userId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ge_event");

            migrationBuilder.DropTable(
                name: "ge_transform");

            migrationBuilder.DropTable(
                name: "ge_user_ops");

            migrationBuilder.DropTable(
                name: "ge_data");

            migrationBuilder.DropTable(
                name: "ge_user");

            migrationBuilder.DropTable(
                name: "ge_project");

            migrationBuilder.DropTable(
                name: "ge_group");
        }
    }
}
