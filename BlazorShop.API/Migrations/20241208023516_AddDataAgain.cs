using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShop.API.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 829.69211569321m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Wooden Chair" },
                    { 2, "The Football Is Good For Training And Recreational Purposes", 809.405762481226m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Concrete Shirt" },
                    { 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 709.097133107994m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Plastic Soap" },
                    { 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 81.4732414532794m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Metal Tuna" },
                    { 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 94.2114411504992m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Wooden Chicken" },
                    { 6, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 555.185653864027m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Steel Chair" },
                    { 7, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839.010165513032m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Rubber Salad" },
                    { 8, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 654.671920178305m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Metal Shoes" },
                    { 9, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 352.596239197346m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Soft Car" },
                    { 10, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 323.865960146238m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Metal Hat" },
                    { 11, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 748.444204432165m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Cotton Mouse" },
                    { 12, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 501.996134493964m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Cotton Keyboard" },
                    { 13, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 415.404153104594m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Concrete Chicken" },
                    { 14, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 608.053980309541m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Cotton Shoes" },
                    { 15, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 904.862362861569m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Concrete Bike" },
                    { 16, "The Football Is Good For Training And Recreational Purposes", 15.5544429773253m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Steel Tuna" },
                    { 17, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 105.673176613018m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Rubber Chips" },
                    { 18, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 708.693462394501m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Cotton Computer" },
                    { 19, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 245.962609125284m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Rubber Bike" },
                    { 20, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 862.080620113332m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Steel Car" },
                    { 21, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 164.222560433309m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Concrete Bike" },
                    { 22, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2.78363074072806m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Wooden Mouse" },
                    { 23, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 875.8188480571m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Soft Tuna" },
                    { 24, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 415.003923908344m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Concrete Gloves" },
                    { 25, "The Football Is Good For Training And Recreational Purposes", 938.297015022625m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Plastic Computer" },
                    { 26, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 914.857621214286m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Frozen Gloves" },
                    { 27, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 372.747086040558m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Steel Chips" },
                    { 28, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 867.608266204879m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Plastic Towels" },
                    { 29, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 651.903613111891m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Concrete Bike" },
                    { 30, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 408.146957589848m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Frozen Chips" },
                    { 31, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 780.833553182349m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Metal Mouse" },
                    { 32, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 574.473502345138m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Wooden Chicken" },
                    { 33, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 298.386307173588m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Fresh Shirt" },
                    { 34, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 469.501929254039m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Soft Chips" },
                    { 35, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 594.964523955232m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Rubber Computer" },
                    { 36, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 75.3175114869687m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Wooden Cheese" },
                    { 37, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 124.945433597521m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Steel Ball" },
                    { 38, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 50.9498826078837m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Fresh Cheese" },
                    { 39, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 619.436015201004m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Metal Computer" },
                    { 40, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 598.702104720148m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Fresh Bike" },
                    { 41, "The Football Is Good For Training And Recreational Purposes", 900.72720358508m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Frozen Car" },
                    { 42, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 935.218737876144m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Rubber Keyboard" },
                    { 43, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 928.928430071533m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Plastic Cheese" },
                    { 44, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 318.468743743593m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Rubber Chair" },
                    { 45, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 158.274787332991m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Steel Car" },
                    { 46, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 659.444339313286m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Granite Shoes" },
                    { 47, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 24.4800570232235m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Fresh Chicken" },
                    { 48, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 959.929376889453m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Frozen Chicken" },
                    { 49, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 825.280794893988m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Metal Keyboard" },
                    { 50, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 397.066580663m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Fresh Chicken" },
                    { 51, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 366.261149519245m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Fresh Shirt" },
                    { 52, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 41.4314823357535m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Fresh Bike" },
                    { 53, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 932.084656792732m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Wooden Cheese" },
                    { 54, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 265.845927546195m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Rubber Shoes" },
                    { 55, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 955.910155062522m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Frozen Towels" },
                    { 56, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 175.470937178224m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Fresh Keyboard" },
                    { 57, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 354.181844998701m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Fresh Cheese" },
                    { 58, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 13.018628124622m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Granite Chips" },
                    { 59, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 325.633172737729m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Metal Ball" },
                    { 60, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 452.957613846267m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Fresh Mouse" },
                    { 61, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 126.128098112125m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Cotton Gloves" },
                    { 62, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 790.255418849296m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Concrete Shoes" },
                    { 63, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 49.3102131664335m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Soft Bike" },
                    { 64, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 749.617618066546m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Cotton Cheese" },
                    { 65, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 503.599965264369m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Metal Hat" },
                    { 66, "The Football Is Good For Training And Recreational Purposes", 743.778957995949m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Metal Computer" },
                    { 67, "The Football Is Good For Training And Recreational Purposes", 814.14169213648m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Metal Computer" },
                    { 68, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 995.993675721806m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Granite Gloves" },
                    { 69, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 891.072066501748m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Frozen Mouse" },
                    { 70, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 523.583176072493m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Granite Chair" },
                    { 71, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 541.352525547311m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Wooden Towels" },
                    { 72, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 570.016798921403m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Fresh Sausages" },
                    { 73, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 109.426027889562m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Wooden Sausages" },
                    { 74, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 453.033994781335m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Metal Tuna" },
                    { 75, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 836.61455178336m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Steel Salad" },
                    { 76, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 511.4611624067m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Granite Shirt" },
                    { 77, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 921.40434159171m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Metal Fish" },
                    { 78, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 111.58742027338m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Wooden Pizza" },
                    { 79, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 320.499838554068m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Rubber Pants" },
                    { 80, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 477.23973976925m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Steel Keyboard" },
                    { 81, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 236.52831808316m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Fresh Soap" },
                    { 82, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 594.062734325446m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Concrete Sausages" },
                    { 83, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 507.616215421639m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Granite Shoes" },
                    { 84, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 562.513954995439m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Cotton Salad" },
                    { 85, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 722.632455745075m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Soft Tuna" },
                    { 86, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 74.0515276445316m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Metal Towels" },
                    { 87, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 173.512130046502m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Plastic Pants" },
                    { 88, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 174.53033953371m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Steel Bacon" },
                    { 89, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 886.4473893109m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Wooden Table" },
                    { 90, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 299.652775749868m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Steel Sausages" },
                    { 91, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 198.399696447141m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Wooden Chair" },
                    { 92, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 510.421478093798m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Concrete Ball" },
                    { 93, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 683.277290017008m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Metal Tuna" },
                    { 94, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 277.339567055153m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Wooden Shoes" },
                    { 95, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 271.131943586344m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Rubber Car" },
                    { 96, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 479.238835633378m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Cotton Bike" },
                    { 97, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 721.773541800572m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Soft Cheese" },
                    { 98, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 639.029853083207m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Plastic Pizza" },
                    { 99, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 126.71586487755m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Soft Soap" },
                    { 100, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5.92080863142424m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Granite Car" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
