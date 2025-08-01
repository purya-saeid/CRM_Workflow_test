using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_Workflow_test.Migrations
{
    /// <inheritdoc />
    public partial class addedforeignkeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "initiatorUserId",
                table: "WFInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WFInitiations_initiatorUserId",
                table: "WFInitiations",
                column: "initiatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WFInitiations_taskId",
                table: "WFInitiations",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksTransition_childId",
                table: "TasksTransition",
                column: "childId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksTransition_taskId",
                table: "TasksTransition",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskInstances_inChargeUserId",
                table: "TaskInstances",
                column: "inChargeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskInstances_taskId",
                table: "TaskInstances",
                column: "taskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskInstances_Tasks_taskId",
                table: "TaskInstances",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskInstances_Users_inChargeUserId",
                table: "TaskInstances",
                column: "inChargeUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TasksTransition_Tasks_childId",
                table: "TasksTransition",
                column: "childId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TasksTransition_Tasks_taskId",
                table: "TasksTransition",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WFInitiations_Tasks_taskId",
                table: "WFInitiations",
                column: "taskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WFInitiations_Users_initiatorUserId",
                table: "WFInitiations",
                column: "initiatorUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskInstances_Tasks_taskId",
                table: "TaskInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskInstances_Users_inChargeUserId",
                table: "TaskInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksTransition_Tasks_childId",
                table: "TasksTransition");

            migrationBuilder.DropForeignKey(
                name: "FK_TasksTransition_Tasks_taskId",
                table: "TasksTransition");

            migrationBuilder.DropForeignKey(
                name: "FK_WFInitiations_Tasks_taskId",
                table: "WFInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_WFInitiations_Users_initiatorUserId",
                table: "WFInitiations");

            migrationBuilder.DropIndex(
                name: "IX_WFInitiations_initiatorUserId",
                table: "WFInitiations");

            migrationBuilder.DropIndex(
                name: "IX_WFInitiations_taskId",
                table: "WFInitiations");

            migrationBuilder.DropIndex(
                name: "IX_TasksTransition_childId",
                table: "TasksTransition");

            migrationBuilder.DropIndex(
                name: "IX_TasksTransition_taskId",
                table: "TasksTransition");

            migrationBuilder.DropIndex(
                name: "IX_TaskInstances_inChargeUserId",
                table: "TaskInstances");

            migrationBuilder.DropIndex(
                name: "IX_TaskInstances_taskId",
                table: "TaskInstances");

            migrationBuilder.DropColumn(
                name: "initiatorUserId",
                table: "WFInitiations");
        }
    }
}
