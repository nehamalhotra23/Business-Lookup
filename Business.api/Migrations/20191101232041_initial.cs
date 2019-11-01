using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RestaurantName = table.Column<string>(nullable: true),
                    Cuisines = table.Column<string>(nullable: true),
                    RestaurantAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopName = table.Column<string>(nullable: true),
                    ShopAddress = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ReviewRestaurants",
                columns: table => new
                {
                    ReviewRestaurantId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlurbRestaurant = table.Column<string>(maxLength: 255, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewRestaurants", x => x.ReviewRestaurantId);
                    table.ForeignKey(
                        name: "FK_ReviewRestaurants_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Blurb = table.Column<string>(maxLength: 255, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ShopId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Cuisines", "RestaurantAddress", "RestaurantName" },
                values: new object[] { 1, "Italian", "Downtown", "Seerato" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Cuisines", "RestaurantAddress", "RestaurantName" },
                values: new object[] { 2, "American", "Downtown Portland", "Portland City Grill" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Cuisines", "RestaurantAddress", "RestaurantName" },
                values: new object[] { 3, "American", "Stark", "Deeny's" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "ShopAddress", "ShopName", "Type" },
                values: new object[] { 1, "stark", "Anna's Flower", "flower Shop" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "ShopAddress", "ShopName", "Type" },
                values: new object[] { 2, "164th street Vancover", "Angel's Donut and Ice Cream", "Donut Shop" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "ShopAddress", "ShopName", "Type" },
                values: new object[] { 3, "122 ave portland 97236", "Ace Hardware", "Hardware Tools" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 1, "Dom" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 2, "Jen" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 3, "Anita" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 4, "Devin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserName" },
                values: new object[] { 5, "Kira" });

            migrationBuilder.InsertData(
                table: "ReviewRestaurants",
                columns: new[] { "ReviewRestaurantId", "BlurbRestaurant", "RestaurantId", "UserId" },
                values: new object[] { 1, "One of my favorite places to dine in Portland.  The staff, especially Fernando, who always remembers us, is extremely friendly and attentive.  I've never had less than an amazing meal here. The atmosphere is beautiful, and they have a great bar area along with outside seating and a large space for a private party.", 1, 1 });

            migrationBuilder.InsertData(
                table: "ReviewRestaurants",
                columns: new[] { "ReviewRestaurantId", "BlurbRestaurant", "RestaurantId", "UserId" },
                values: new object[] { 5, "One of my favorite places to dine in Portland.  The staff, especially Fernando, who always remembers us, is extremely friendly and attentive.  I've never had less than an amazing meal here. The atmosphere is beautiful, and they have a great bar area along with outside seating and a large space for a private party.", 1, 5 });

            migrationBuilder.InsertData(
                table: "ReviewRestaurants",
                columns: new[] { "ReviewRestaurantId", "BlurbRestaurant", "RestaurantId", "UserId" },
                values: new object[] { 2, "We had the best server! I wish I remembered his name. The view is amazing, the food is delicious, the service is great. It is an amazing place to go. I've gone here both dressed up and more casual depending on the occasion. It's such a great place!", 2, 3 });

            migrationBuilder.InsertData(
                table: "ReviewRestaurants",
                columns: new[] { "ReviewRestaurantId", "BlurbRestaurant", "RestaurantId", "UserId" },
                values: new object[] { 3, "I've been enjoying the food from this establishment since I was a young boy, and I'm 36yrs old now. Recently revisited them for a to-go order and couldn't be happier with the quality, quantity, or service. Canton Grill, y'all are AWESOME and I plan on being one of your customers as long as I can! Thanks :-)", 3, 4 });

            migrationBuilder.InsertData(
                table: "ReviewRestaurants",
                columns: new[] { "ReviewRestaurantId", "BlurbRestaurant", "RestaurantId", "UserId" },
                values: new object[] { 4, "I've been enjoying the food from this establishment since I was a young boy, and I'm 36yrs old now. Recently revisited them for a to-go order and couldn't be happier with the quality, quantity, or service. Canton Grill, y'all are AWESOME and I plan on being one of your customers as long as I can! Thanks :-)", 3, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Blurb", "ShopId", "UserId" },
                values: new object[] { 1, "Susie was AWESOME!!!! I came in last minute for a memorial service with a holiday weekend in two days. Not only did she get it done but her idea for the bunches turned out great!!!!.", 1, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Blurb", "ShopId", "UserId" },
                values: new object[] { 2, "Perfect donuts. Light and fluffy perfect evenly distributed glaze. I love just a classic glazed donut but had their apple fritter recently and it was heavenly. The coffee goes perfectly with the donuts. Great shop to hang out/work in, decent WiFi, not too loud so it's easy to focus.", 2, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Blurb", "ShopId", "UserId" },
                values: new object[] { 3, "t vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero", 3, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Blurb", "ShopId", "UserId" },
                values: new object[] { 5, "Susie was AWESOME!!!! I came in last minute for a memorial service with a holiday weekend in two days. Not only did she get it done but her idea for the bunches turned out great!!!!.", 2, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Blurb", "ShopId", "UserId" },
                values: new object[] { 4, "Susie was AWESOME!!!! I came in last minute for a memorial service with a holiday weekend in two days. Not only did she get it done but her idea for the bunches turned out great!!!!.", 2, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewRestaurants_RestaurantId",
                table: "ReviewRestaurants",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ShopId",
                table: "Reviews",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewRestaurants");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
