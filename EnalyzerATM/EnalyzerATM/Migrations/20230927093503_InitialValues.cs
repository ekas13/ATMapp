using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnalyzerATM.Migrations
{
    /// <inheritdoc />
    public partial class InitialValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Notes('Id','Value','Count') Values(1,1000,1000)");
            migrationBuilder.Sql("INSERT INTO Notes('Id','Value','Count') Values(2,500,1000)");
            migrationBuilder.Sql("INSERT INTO Notes('Id','Value','Count') Values(3,200,1000)");
            migrationBuilder.Sql("INSERT INTO Notes('Id','Value','Count') Values(4,100,1000)");
            migrationBuilder.Sql("INSERT INTO Notes('Id','Value','Count') Values(5,50,1000)");
            migrationBuilder.Sql("INSERT INTO Coins('Id','Value','Count','Diameter') Values(1,20,1000,40)");
            migrationBuilder.Sql("INSERT INTO Coins('Id','Value','Count','Diameter') Values(2,10,1000,20)");
            migrationBuilder.Sql("INSERT INTO Coins('Id','Value','Count','Diameter') Values(3,5,1000,50)");
            migrationBuilder.Sql("INSERT INTO Coins('Id','Value','Count','Diameter') Values(4,2,1000,30)");
            migrationBuilder.Sql("INSERT INTO Coins('Id','Value','Count','Diameter') Values(5,1,1000,10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Notes;");
            migrationBuilder.Sql("DELETE FROM Coins;");
        }
    }
}
