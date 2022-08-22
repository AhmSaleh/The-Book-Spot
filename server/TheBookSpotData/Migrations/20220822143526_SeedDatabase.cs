using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookSpotData.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_price",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("00816f3c-710f-4fce-8b8b-694aa62bf2c0"), "Erma", "Balderson" },
                    { new Guid("0085af40-772e-43d4-a744-781e8ac7ade1"), "Ernestine", "Ilchenko" },
                    { new Guid("00d9a9b2-5d08-4bd3-b854-28228db24210"), "Gerome", "Tarr" },
                    { new Guid("013a3381-b4bc-43ab-9298-bbb8baa91078"), "Reynard", "Humphrey" },
                    { new Guid("0177be2d-065e-4507-874c-82ce6135f402"), "Claiborne", "Parbrook" },
                    { new Guid("01c064e1-88aa-48c6-be0e-b12ea47cab70"), "Derward", "Georgeot" },
                    { new Guid("02089dca-80a6-4eeb-8f9f-e6b392f76f9d"), "Elfrieda", "Empringham" },
                    { new Guid("020c5e81-7f10-431e-9c35-a9529f348081"), "Brocky", "Dilkes" },
                    { new Guid("025dc1c9-55c4-48ef-b265-7ac3a06628eb"), "Leonidas", "Lazare" },
                    { new Guid("031938d9-385e-4e78-bddc-ee7720f60ec2"), "Jacinta", "Taffurelli" },
                    { new Guid("03a5bd12-ef92-4d66-91bb-9da8d3666f82"), "Annaliese", "Verdie" },
                    { new Guid("045ec6f1-6dc5-487b-94b4-359a852b3f00"), "Ethelda", "Deave" },
                    { new Guid("04a51c1b-ad90-4882-9acd-377c0ed077c6"), "Lavinie", "Issard" },
                    { new Guid("04b7cc90-df69-4d6d-afe1-7e164354ddbc"), "Orren", "Richford" },
                    { new Guid("04bac9d9-63bd-45c5-8499-dbf7fa5e0f31"), "Lewiss", "McCready" },
                    { new Guid("05365b7d-37f5-4893-bac9-536e00a91350"), "Nessa", "Blaxland" },
                    { new Guid("053e626e-3b2e-44b7-8740-d69df744a58d"), "Jozef", "Bedson" },
                    { new Guid("056cf996-5b34-438f-a9d9-e6d8d32bc285"), "Corrina", "Gabbidon" },
                    { new Guid("05a64888-2a8f-43e6-8920-3b4591773c9d"), "Catha", "Spriggen" },
                    { new Guid("05b3f385-b1fc-43ce-bd6d-a26e54b8c9fc"), "Christyna", "Berard" },
                    { new Guid("05d0f14e-1751-4aba-8edb-191c74e42643"), "Glynn", "Skein" },
                    { new Guid("05d49ba6-ec42-4d3c-b113-dbb22bc64d74"), "Ephraim", "Drohane" },
                    { new Guid("069bf751-30ca-4d11-b39d-6c60d55ee78d"), "Nikos", "Lundy" },
                    { new Guid("06c39c93-720b-45fb-9f20-cde1c13a709a"), "Velvet", "Rosenshine" },
                    { new Guid("06c4b13d-acd4-48a5-b197-f6ec2ddaad03"), "Stephana", "Delhanty" },
                    { new Guid("06f039be-bfad-4af7-8f6a-586cefe656cc"), "Alvan", "Beccera" },
                    { new Guid("0713193a-10bb-4d6d-99f5-81e8261f06f3"), "Ami", "Toohey" },
                    { new Guid("0714e1e9-744c-4789-8f3b-c2e82f2370d4"), "Kimbell", "Haughan" },
                    { new Guid("075bf738-c0bc-489e-8645-bdb671aab4f5"), "Lilith", "McSorley" },
                    { new Guid("079aafe1-97db-4416-8a2d-7e598149b737"), "Gaelan", "Beange" },
                    { new Guid("08932960-8d61-42f1-952f-3ce019f67547"), "Lenci", "Colafate" },
                    { new Guid("089a6b64-5114-4c56-902e-fe2fbd8df7ef"), "Casie", "Kincey" },
                    { new Guid("08fc654a-4ce7-43ea-bed1-17e42473c8b0"), "Nissa", "Tockell" },
                    { new Guid("09399070-fd8f-4a0e-9d27-261fe7b3a288"), "Immanuel", "Gelland" },
                    { new Guid("093dfc93-5266-4d68-bf48-163fde59163b"), "Benedick", "Stenner" },
                    { new Guid("099b4dc2-bb45-4315-97dc-cf885108c8a0"), "Charley", "Draysay" },
                    { new Guid("09c7e67f-0a4d-49ae-9267-ec26fe174214"), "Oswell", "Espasa" },
                    { new Guid("09d8248f-b84f-4482-81ec-38e4bdde66a0"), "Devinne", "Spofforth" },
                    { new Guid("09e76b31-202b-49d4-b117-e28c6e21a6db"), "Kylila", "Voysey" },
                    { new Guid("09fb7285-88de-43b4-8581-ddf8c748ab4b"), "Ed", "Murrhardt" },
                    { new Guid("0a3e68b8-cf73-4ccb-bf6c-ad3c6423163f"), "Elga", "Lorenzo" },
                    { new Guid("0a3f38b0-6c38-4a4c-b93f-92e97944e3b6"), "Sunshine", "Gullefant" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0ae2a8e7-e3d7-40d2-b5de-f8827665d132"), "Essa", "Morit" },
                    { new Guid("0b1719df-a53d-4a59-960e-2b319cb4da9f"), "Mala", "Silcock" },
                    { new Guid("0b511322-90cd-4686-afdc-aa7aac98b223"), "Samaria", "Bondesen" },
                    { new Guid("0b7d3b5a-89dc-4204-8bc7-5e0c36fa5cd1"), "Tully", "Tincey" },
                    { new Guid("0b933755-3929-4970-9e65-924c1ad9d427"), "Teador", "Beilby" },
                    { new Guid("0c6cc63a-5f5a-4ca5-a554-1efa8ee2b26f"), "Alanson", "Flooks" },
                    { new Guid("0caf8876-db7b-46a8-92d6-051d3eea8492"), "Modestine", "Kelle" },
                    { new Guid("0cbf4fbf-23c7-4390-b013-dda8b87e6753"), "Brennen", "Chansonne" },
                    { new Guid("0ceed50a-7558-4742-baf6-d1a2d9f834ef"), "Sybila", "Attryde" },
                    { new Guid("0cf94f39-c58f-40de-b848-abb34fcdab11"), "Liana", "Clunie" },
                    { new Guid("0d58b3e0-a68f-4f3b-b29e-772ec822bc5c"), "Felita", "Darrigoe" },
                    { new Guid("0d59cbda-6661-4c32-ad19-91e1fe7a71d4"), "Costa", "Parrott" },
                    { new Guid("0d5ffc92-f835-466a-b57b-bb5539613e8b"), "Cloris", "Chewter" },
                    { new Guid("0d685706-c9a5-412c-b296-4e4f99d25500"), "Torr", "Wrixon" },
                    { new Guid("0d7ae1b5-0102-4baf-8737-986b483b50e7"), "Eustacia", "Yonnie" },
                    { new Guid("0d9e7fb6-7bcf-4d62-99c4-8e7a80d6de1a"), "Bobbie", "Vakhlov" },
                    { new Guid("0da6eb62-f87b-4b8d-8f56-84cf0ffcfdbc"), "Avis", "Siemon" },
                    { new Guid("0dac362a-1165-4e88-9be0-e55bdb044a6a"), "Bran", "Culleford" },
                    { new Guid("0e55e315-750c-4df9-a03e-d1e073851bb0"), "Bette", "Wannell" },
                    { new Guid("0eaf9d32-8a14-4fe6-976d-fb9038f41908"), "Nelle", "Creane" },
                    { new Guid("0ec95507-4f2c-4f67-97fb-83d41b418265"), "Alla", "Greenslade" },
                    { new Guid("0ecb8f16-d362-47aa-bd8f-aba5cb67891e"), "Heidie", "Jojic" },
                    { new Guid("0ede6111-ad59-4a97-934f-5d61431aa610"), "Nadine", "Sandeland" },
                    { new Guid("0f417ffa-764e-44c1-b64f-85d8a7bef5db"), "Baily", "Rutherforth" },
                    { new Guid("0f4c7d67-67dd-454e-a5db-9c1130586739"), "Karlie", "Chislsett" },
                    { new Guid("0fc15f39-9ca1-45ef-9dc8-bc55ae19717a"), "Stu", "Daybell" },
                    { new Guid("0fd926b9-6943-41db-ac79-0973843f33bf"), "Angy", "OGorman" },
                    { new Guid("0fe2def8-3847-4d6b-8c1d-d5d589df242b"), "Pearl", "Pitchford" },
                    { new Guid("1025d60f-045d-4d18-bf8b-b55c79d4a9d1"), "Bucky", "Plumridge" },
                    { new Guid("1087b4c4-fff3-4ebe-86b0-36ab5acd10cb"), "Shelley", "Crippill" },
                    { new Guid("10e2d254-60a5-4300-a66e-25b9aa678b23"), "Hashim", "Jickells" },
                    { new Guid("11ecfdac-364e-4f75-b894-e9f5472c2fa4"), "Wald", "Sexton" },
                    { new Guid("1248c46b-9feb-4d57-99e2-8e6e5722dfd5"), "Madelle", "McGaugie" },
                    { new Guid("1281db96-f078-4e2a-8489-9a052b33aab3"), "Kendal", "Cohalan" },
                    { new Guid("12a0e90d-070c-497a-a73f-2e9d898f5208"), "Ulrick", "Roll" },
                    { new Guid("12d34635-3f95-4e86-9234-3a40e388cc0a"), "Mahala", "Prahl" },
                    { new Guid("12eaf5da-5225-450b-8e2c-aa2c07209f8f"), "Reamonn", "Bundey" },
                    { new Guid("12fd54e3-89da-45e6-bf8c-327e1b0a67c5"), "Deane", "Cockhill" },
                    { new Guid("1302068e-8d80-4358-8e25-160a6b4503b1"), "Augustina", "Riquet" },
                    { new Guid("131b5100-5a51-4590-818b-b3512bfd116d"), "Muhammad", "Humbatch" },
                    { new Guid("134b63da-10c7-47e2-bffc-d9e99a4024fc"), "Livy", "Redish" },
                    { new Guid("138735b3-9b6a-407d-ad6b-3fe6bfd1eb83"), "Rosalynd", "Simionescu" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("13bdcc94-9328-45bc-b159-2961df06d42a"), "Mela", "Dickinson" },
                    { new Guid("14a25339-ec69-4e6a-a2c5-df9a233a70fa"), "Nelia", "Sivess" },
                    { new Guid("14c27e44-1b6b-4a1d-95fc-7334b67264f7"), "Celene", "Demelt" },
                    { new Guid("14cdbcd0-aba0-4976-9935-3c320185257c"), "Peta", "Fullilove" },
                    { new Guid("14df66ca-3089-4fbd-8eeb-896a46ff93b8"), "Chelsie", "Espinheira" },
                    { new Guid("1514bec2-cfcb-4d94-be36-672110cc179e"), "Shandee", "McMackin" },
                    { new Guid("1515ffc8-490c-4321-a8d3-db551e56e3d7"), "Erma", "Late" },
                    { new Guid("152a58d8-76ac-43d1-9fcc-ad5a524c8ce2"), "Ainslie", "Wilmott" },
                    { new Guid("157466fa-afb7-4076-ad21-530717018e26"), "Paulina", "VanderHoeven" },
                    { new Guid("15a49315-552f-4f6a-9f25-001a5f13ce07"), "Timothy", "Goldspink" },
                    { new Guid("15de9758-2ea5-4d54-8fa0-4c12dbad4f1c"), "Dewie", "Olerenshaw" },
                    { new Guid("15f10e87-dc54-4e4b-91f6-a67402891ca9"), "Nedda", "Tregale" },
                    { new Guid("162cf5c3-1c9a-431c-b077-9b33c9b224ec"), "Currey", "Anster" },
                    { new Guid("16460b51-2fcf-470c-bb00-276ba2bade53"), "Guenevere", "Plett" },
                    { new Guid("167f9d00-6d9e-4aa8-a8b0-5b23b2d059bb"), "Karina", "Arend" },
                    { new Guid("16a44947-d397-431f-8435-e515f5820b02"), "Alvan", "McOwen" },
                    { new Guid("16ff18f0-4057-4958-8507-3c9771cc9c58"), "Bobbette", "Myton" },
                    { new Guid("17720fce-3f27-4378-b9ee-6894e41e52ef"), "Ado", "Burkett" },
                    { new Guid("17c501fe-3fbe-4b4b-b9ea-b7d854aaa76b"), "Nickola", "Sazio" },
                    { new Guid("18213b33-c03e-4116-963d-0eef7df6eb1a"), "Cal", "Paskin" },
                    { new Guid("1839b6d3-6a99-421d-b005-7e4bb9d8c01b"), "Barnabe", "Janway" },
                    { new Guid("183d095f-9bea-4436-a306-81d396201c95"), "Arie", "Richford" },
                    { new Guid("18792222-9315-474a-9dc7-cc10354b7b18"), "Emmerich", "Hutchence" },
                    { new Guid("18895baf-1493-463f-8c5a-690cd89b3232"), "Jena", "Gounod" },
                    { new Guid("18d5a51c-632e-451d-a3e1-9ca5fb484154"), "Uri", "Hannan" },
                    { new Guid("18fbea11-549c-41ea-907a-3c687ee0654f"), "Emelen", "Mitchel" },
                    { new Guid("19fe27c7-6493-4426-9659-576f5fd3f56e"), "Melli", "Jeavon" },
                    { new Guid("1a43890f-a96f-4b0f-bef3-be5b12f574bb"), "Page", "Jeffress" },
                    { new Guid("1a5d8925-407a-4ca7-bc00-66e78e78d0a1"), "Harcourt", "Riepl" },
                    { new Guid("1abaaf66-3244-437d-ab52-41f4ce76d36e"), "Randolf", "King" },
                    { new Guid("1acdd02d-b47f-4259-ae8c-a39fe7028d02"), "Pris", "Russell" },
                    { new Guid("1af6bab8-73c9-4ee7-b2bd-5a24daa9ffa2"), "Enos", "Stowell" },
                    { new Guid("1b8a9a93-d1eb-4ef6-a4c2-dac636d6e3de"), "Amalea", "Moore" },
                    { new Guid("1baac1e0-8286-4bcc-9052-f00e443893af"), "Beverlee", "Derisly" },
                    { new Guid("1bd5a605-a9aa-4a11-91de-fe75aa18bb5f"), "Shanta", "Raspison" },
                    { new Guid("1c698679-a452-4b49-b00c-0a7781948e64"), "Broderic", "Andrelli" },
                    { new Guid("1cb011e1-4010-48db-992f-0e990cdb0c14"), "Abigale", "Francesc" },
                    { new Guid("1ccffb1f-9a1c-4638-87c5-5c2c550de5e8"), "Ivory", "Goldin" },
                    { new Guid("1cdafbde-7fb3-4e75-91c9-c2b69ccdc54d"), "Whit", "Mossom" },
                    { new Guid("1d3986e7-7cf7-4ba5-aa56-0c54870bc6c3"), "Sibella", "Andell" },
                    { new Guid("1d7920d7-15ce-4044-8504-1751bfbe535b"), "Chloette", "Winstanley" },
                    { new Guid("1d8155f9-dcd6-4fd0-97b1-969ad9798e77"), "Ginger", "Segge" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1e335e2a-e61b-40e1-82bf-09ba0aa86177"), "Ramonda", "Huyton" },
                    { new Guid("1e3a8a89-44b4-4d29-890c-e23c910e6685"), "Rosalind", "Such" },
                    { new Guid("1e5a8cd3-90b4-4446-94bf-d3cbe087b2fd"), "Finley", "Bottelstone" },
                    { new Guid("1e7e5813-9339-4efd-b20a-11f9b29156f6"), "Aron", "Lazenby" },
                    { new Guid("1f86b4a1-d352-489d-825a-37236dcbed23"), "Waylon", "Burcombe" },
                    { new Guid("1fc9d5bc-6f28-405b-8a9e-1dcc73e883d6"), "Jonis", "Griffen" },
                    { new Guid("1fd4846d-b277-4efe-b9af-04ff8d7e8697"), "Beverie", "ODornan" },
                    { new Guid("20206b09-011c-4284-bb73-c69919062c7a"), "Ursala", "Reichartz" },
                    { new Guid("20b52943-cc85-4aca-846f-79f990d0a7b1"), "Putnam", "Conneau" },
                    { new Guid("213aa447-ee90-4a85-80b8-355431d61d95"), "Michaela", "Chainey" },
                    { new Guid("2145fbbf-8504-4e49-9a46-7748608fef9d"), "Darn", "LeGalle" },
                    { new Guid("21968877-5f38-4f92-b81d-5cb9a7a9ab0f"), "Tamra", "Aberchirder" },
                    { new Guid("21f89634-1e67-487b-b4c1-479f1ef43b52"), "Walton", "Bate" },
                    { new Guid("22094962-1789-45e3-8249-c6859c8fbcad"), "Reeva", "Brumwell" },
                    { new Guid("22231497-c3c4-43c6-8764-e008fe5062dc"), "Brock", "Springall" },
                    { new Guid("222d1b79-8267-4798-b881-bab5f6813f71"), "Anny", "Pescott" },
                    { new Guid("228ae30e-cfed-4656-afd7-8dfe93e0ae84"), "Wesley", "Reyne" },
                    { new Guid("232f5d75-8488-447f-8b6a-8de60c3673af"), "Odille", "Ivanenkov" },
                    { new Guid("235398bd-d54e-4f55-b134-3f2b2b5efaba"), "Sigmund", "Warbys" },
                    { new Guid("23a5465f-f6dc-4d8c-a9cd-b93146938735"), "Alina", "McDirmid" },
                    { new Guid("23bccf95-eecf-467e-b675-1b6a3e9d1b79"), "Emmeline", "Daniaud" },
                    { new Guid("247a16b3-599b-43f3-949c-f1b87758891c"), "Erl", "Brockway" },
                    { new Guid("24878f0f-b893-41d7-a296-c054d1b26475"), "Opal", "Jacquemet" },
                    { new Guid("24add69c-3868-4d74-9824-66a915cd9044"), "Casie", "Schouthede" },
                    { new Guid("24bfb9c5-10cd-494a-9749-4f4fa3b42baa"), "Emmit", "Scola" },
                    { new Guid("24cc8724-f4c5-4971-95e3-413639453775"), "Dniren", "Jerrems" },
                    { new Guid("25088fd5-59e3-4bab-a47a-d3773560a484"), "Mechelle", "Kermath" },
                    { new Guid("25505d2f-a02a-48ab-a65f-22976eeb59f2"), "Zollie", "Filan" },
                    { new Guid("25758eb3-93ba-486c-adc6-5695cb1c1873"), "Chane", "McCourtie" },
                    { new Guid("25b44da4-0905-40c9-8f98-1be78cb9a2cf"), "Kassi", "Lander" },
                    { new Guid("25b79ec2-1697-4225-8c1b-300f80dc54b2"), "Marven", "Marien" },
                    { new Guid("2640240e-6ecc-435f-b3a4-b18cd07e35e6"), "Giorgi", "Kench" },
                    { new Guid("267cbc06-0ea5-4809-81e6-fd425fabc167"), "Bellanca", "Liddell" },
                    { new Guid("26b4373c-35d5-4274-b8f5-590785de3a88"), "Benedicta", "Cubbon" },
                    { new Guid("2720957e-ba8f-4a82-9e53-48813dc91b3b"), "Davon", "Houlston" },
                    { new Guid("274308b0-313a-4a35-96e2-9b64a633f169"), "Annamarie", "Stoner" },
                    { new Guid("27979bf2-f76e-43b6-b1a3-00f018bc28f9"), "Hermia", "Filby" },
                    { new Guid("27c832f5-d940-4133-ac35-6349f6c4b59f"), "Kiersten", "Kitcat" },
                    { new Guid("27e4a68f-3394-4846-963b-e4fead16dedb"), "Lena", "Beedle" },
                    { new Guid("27f5d1db-4c36-40ac-bbc2-abf4ff04c750"), "Neely", "Quibell" },
                    { new Guid("28c0521f-97a0-4e21-a7bc-45028ef1eb09"), "Franny", "Cordeau" },
                    { new Guid("28d902f4-3165-458a-9f9c-3293035f1381"), "Wang", "Gianinotti" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("2911d037-b839-4428-8fcc-e15ea3474c7e"), "Doro", "Cowoppe" },
                    { new Guid("2937fa44-1847-4019-8daf-f043717fadc4"), "Freemon", "Wallworke" },
                    { new Guid("2952c40c-a21f-464b-9cc2-94e1d06ab28c"), "Fidela", "Dumbell" },
                    { new Guid("29844e4c-916d-4b4f-a837-a12d8ef9ba3b"), "Alistair", "Woolfitt" },
                    { new Guid("29d8ddaa-49cc-44aa-bf86-c9d8d6118375"), "Art", "Charte" },
                    { new Guid("2a34e65f-7434-4e61-8409-bfd527d2b8b9"), "Dorey", "Trundler" },
                    { new Guid("2a4361b4-782d-4a0e-8a50-1f9112da9434"), "Den", "Stolting" },
                    { new Guid("2a7a38f8-86ed-4624-9ef6-cbd38b764b54"), "Rina", "Chantillon" },
                    { new Guid("2af7736a-a2ec-40a6-95b1-522d6da0c69e"), "Constancia", "Woltering" },
                    { new Guid("2b2cf338-5bdc-48d4-9cf9-80126702734d"), "Alika", "Fetherston" },
                    { new Guid("2b43a6b1-51dc-41ec-8525-6f9fc8e73da7"), "Lelah", "Leverington" },
                    { new Guid("2badfc36-6962-4324-ba12-be4bbc4117a4"), "Emory", "Welch" },
                    { new Guid("2be92935-580e-4f3e-b46b-c3c456f44655"), "Rhona", "Kohrsen" },
                    { new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"), "Morry", "Aksell" },
                    { new Guid("2c6ecb2e-93ac-4488-a27f-94e1e3c102b6"), "Rycca", "Broomer" },
                    { new Guid("2c928f36-1aa2-4e1f-8cda-b48b1a695b4c"), "Lorain", "Fawlkes" },
                    { new Guid("2ca0a633-a9d0-4acd-8441-de22f7bf1298"), "Tynan", "Seneschal" },
                    { new Guid("2cc1f126-5932-4d44-afd3-72f90be1be82"), "Vikki", "Spread" },
                    { new Guid("2ce550aa-3863-40af-bccf-d04b52b65334"), "Price", "Rosie" },
                    { new Guid("2d99176a-fc73-4fc7-a0d3-d46731af0e4c"), "Joelle", "Rayner" },
                    { new Guid("2db3fd3c-76ed-4f66-9561-9704b50c904d"), "Sonny", "Meugens" },
                    { new Guid("2dbd7137-b243-4c35-b500-3f08fab32dea"), "Dannie", "Beattie" },
                    { new Guid("2dc83419-8e8e-4dc1-acef-20ecc8af7807"), "Justine", "Vigar" },
                    { new Guid("2e358a53-53f0-42ae-b5fb-1efcc26a831f"), "Catherina", "Coaster" },
                    { new Guid("2e795847-4b82-493d-981f-aa0aecbaf839"), "Tremain", "Bartlam" },
                    { new Guid("2ec7f4df-06b1-4018-8435-d6c4cbb8b29f"), "Arly", "Simounet" },
                    { new Guid("2eefb633-abad-4f17-83a1-ff1e8cd24f4d"), "Sher", "Risen" },
                    { new Guid("2f9afb16-d08e-4cb5-9b1e-69a0a4d55491"), "Henri", "Armitage" },
                    { new Guid("2fdca055-7193-44bf-b351-e06794b8fb71"), "Win", "Shadbolt" },
                    { new Guid("305e2668-f54d-4e67-b930-2164c75eb94a"), "Slade", "Haxell" },
                    { new Guid("30813594-a5fb-4ba2-8148-90387fa5c107"), "Kaitlyn", "Davisson" },
                    { new Guid("31733822-f95a-4803-8b75-472e7ba84b7a"), "Nixie", "Dinnis" },
                    { new Guid("3220ed37-c604-47ae-a724-fd7b68bd6e83"), "Klemens", "Camelli" },
                    { new Guid("325fe720-a257-4bb1-9e29-eb8d8a67965f"), "Thia", "Durden" },
                    { new Guid("3290f419-20f9-4364-aaff-2279b09abe4d"), "Anitra", "Willman" },
                    { new Guid("32f68714-7d03-46c1-9ae9-3230ab1015a1"), "Tessa", "Pimerick" },
                    { new Guid("330c2709-1b56-457f-bd1e-1c5bb27cda53"), "Reta", "Julian" },
                    { new Guid("33de038c-80de-4beb-b44b-c6a129a9a2dc"), "Pierre", "Rivenzon" },
                    { new Guid("33f626ac-032d-4421-8550-7f459134496b"), "Aguste", "Lamming" },
                    { new Guid("341a5b3b-f616-4bec-a433-50a0b13065b8"), "Murray", "Risso" },
                    { new Guid("349749c3-e70b-4fea-b33b-35b913726b2e"), "Graham", "Chaplain" },
                    { new Guid("34b4c9ac-5700-4e88-914a-e2da78e1b8bd"), "Karry", "Caswill" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("3509cb67-69dc-4549-8169-e4d6b06df798"), "Pat", "Birkwood" },
                    { new Guid("3514789e-51e1-4e7e-9cd3-7ca5a3896a00"), "Caldwell", "Bather" },
                    { new Guid("356b1cdb-dc3e-43c8-bf59-633b1679855d"), "Mil", "OKynsillaghe" },
                    { new Guid("358b3e0c-5255-429b-b66f-060aba39988d"), "Osmund", "Dunphie" },
                    { new Guid("35a17d4c-3203-4643-b237-4578b56c5877"), "Walt", "VanderBrugge" },
                    { new Guid("35f2624c-ea35-4a3c-af63-4715ff521161"), "Eldridge", "Skarman" },
                    { new Guid("35fc9aec-1fc0-4244-85e8-cca3e336a731"), "Dilly", "Headland" },
                    { new Guid("36145858-c78b-4ad6-a4bd-5a798e488495"), "Donn", "Marrison" },
                    { new Guid("36175c6b-85bd-4615-bb1f-456391811718"), "Velma", "Kunat" },
                    { new Guid("3642ed63-03e4-4012-a8e9-fc206a02681d"), "Luci", "Enticknap" },
                    { new Guid("3644c802-73b7-4f56-8412-1baf23ca1244"), "Lucina", "Taynton" },
                    { new Guid("3658895a-82dc-4179-94ef-700fdb6d98de"), "Eadith", "Hartzogs" },
                    { new Guid("36aea91c-acb2-4370-911f-21ba7e1bdcc7"), "Algernon", "Nowlan" },
                    { new Guid("370d0b40-5b28-48de-b0b6-e24fd817d873"), "Charlotte", "Gueste" },
                    { new Guid("371a9bc8-1fd8-40fb-980d-735602eae2dd"), "Hollyanne", "Skeldinge" },
                    { new Guid("371cdd5f-b1b9-484f-ab3d-e9122dd0779f"), "Mason", "Kolak" },
                    { new Guid("374715bf-08ee-4a85-ad2b-3fb4da8d99bf"), "Vivyan", "Drysdale" },
                    { new Guid("37473f61-a6c9-4c13-84e6-05645f6554a9"), "Tobey", "Hanlin" },
                    { new Guid("379ee703-1eab-44d6-891a-45e9d3fc2217"), "Quent", "Arkil" },
                    { new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), "Stormi", "Tortis" },
                    { new Guid("37fad513-a1b0-4330-ba5c-37b735bcbeff"), "Bunny", "Spawell" },
                    { new Guid("383b0277-d263-4ca6-a895-2e83d2c6983e"), "Humberto", "McAllaster" },
                    { new Guid("38509b37-9a4a-46e2-9941-87e047cfb7ac"), "Jelene", "Casillas" },
                    { new Guid("385601f4-44e9-48b5-87fa-58391eedfdaa"), "Parry", "Celes" },
                    { new Guid("3868539d-b516-43d0-8b14-5153d2b034bb"), "Dniren", "Hairsnape" },
                    { new Guid("387b13a1-f1f2-4684-9b2c-64c45234258a"), "Miles", "Priden" },
                    { new Guid("38c88310-d2d4-4503-965c-e679f83b87cc"), "Herschel", "Dunridge" },
                    { new Guid("3910cab4-adc0-410f-ba56-90626ba23684"), "Gianni", "Keeping" },
                    { new Guid("3921fbaf-b6aa-41c6-9d4e-b06c1b251d95"), "Doy", "Pauer" },
                    { new Guid("394b5eca-1ebd-4ea2-a9ac-b03cbaa71e07"), "Lilla", "Gaitone" },
                    { new Guid("39c6d354-bbc8-4bfc-b956-57554d54af7d"), "Paige", "Gueny" },
                    { new Guid("39fdd714-0017-43e9-9610-4d750008a7fa"), "Meris", "Endle" },
                    { new Guid("3a207398-ffb8-4fdf-973b-0858c6e96fb2"), "Blair", "Round" },
                    { new Guid("3a9d347a-b343-4b5d-a379-66546b1d7b69"), "Averill", "Treeby" },
                    { new Guid("3bcc229e-c552-40d7-b152-9c42eb013fe7"), "Edwina", "Casajuana" },
                    { new Guid("3bd9fb5b-8397-41a0-9705-c5d3e8ece4c6"), "Trueman", "Farnon" },
                    { new Guid("3c58eb92-fbd8-4b60-8565-eecde6a26a71"), "Chariot", "Gerholz" },
                    { new Guid("3c7e8b86-0230-4938-8f76-67c099167185"), "Daven", "Winterbotham" },
                    { new Guid("3c9796ad-61d6-4007-a9bc-f3216873d9fc"), "Gerty", "Dunstone" },
                    { new Guid("3cae8445-8772-461b-955f-4e2533a663da"), "Calli", "Armand" },
                    { new Guid("3cd90b43-7ca5-41b3-a60c-bdcdf3b005ff"), "Malchy", "Widmore" },
                    { new Guid("3d3119d2-49b5-4360-93f8-a48b28e1bae2"), "Hurlee", "Birkett" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("3d4edeb6-3baf-447e-bae8-d8ee8655b1bd"), "Tiffany", "Kennon" },
                    { new Guid("3d6a3581-5b67-44da-a0db-effa4d1bd91b"), "Flossi", "Boddie" },
                    { new Guid("3d78729b-0a4f-4e86-a707-15d5be2e328e"), "Aviva", "Botterell" },
                    { new Guid("3d7e2d73-9253-44d4-bb85-e5fc99eab549"), "Kort", "Chell" },
                    { new Guid("3d87651d-5ad3-4d27-9f7c-cb805478c936"), "Calhoun", "DAgostino" },
                    { new Guid("3db30207-0111-4b34-8697-15e686b8ab44"), "Henrik", "Ithell" },
                    { new Guid("3de047cf-aa52-4347-be26-027bd8ee3bc5"), "Zach", "Ubach" },
                    { new Guid("3de133f0-d8f0-4114-a2f5-83c51e166f2a"), "Tobi", "Hovee" },
                    { new Guid("3e361ce1-6757-4b44-844a-4d4da9b40abe"), "Steffen", "Gilhoolie" },
                    { new Guid("3e9fde8a-0dd7-401b-9a87-fab3fab8fa55"), "Odette", "Whitely" },
                    { new Guid("3f0365b6-2f2e-40c0-83a5-5eff7d3d09cf"), "Dedra", "Chastand" },
                    { new Guid("3f97f8fc-0010-4b5b-92f7-e8b37a295be0"), "Dayna", "Buntain" },
                    { new Guid("40c60bfa-4f66-40fb-b6cd-01dc4ed76aa6"), "Neysa", "Forder" },
                    { new Guid("4196a6be-f3b9-4bb5-a7f6-8c97cd627cf3"), "Livvie", "Geake" },
                    { new Guid("41e33482-b76d-45b7-a5fb-8b1e9e891895"), "Tucky", "Tomblin" },
                    { new Guid("423541fd-c7ae-4a69-95a8-b2e79e738b66"), "Olenka", "Cassely" },
                    { new Guid("42ad2b90-d981-4f4a-a669-33d0a199be28"), "Jacques", "Dalgleish" },
                    { new Guid("42fc2e5a-e070-48cf-b745-9a24952184cb"), "Basilio", "Reaveley" },
                    { new Guid("433e73be-034b-4d0a-9c6e-ca790e39da25"), "Hanson", "Pentelo" },
                    { new Guid("439741a8-1697-4aec-92a1-1dbf2cb3ea18"), "Denver", "Crotty" },
                    { new Guid("43ba9cdb-cd9f-4186-949d-7e826615e6cf"), "Bettina", "Rewbottom" },
                    { new Guid("43ff06a8-3279-409a-a9b4-2ac91b1fa6b5"), "Jess", "Mostin" },
                    { new Guid("44276ff4-d34d-4aaf-82c3-97e66c20e6ec"), "Chantalle", "Prin" },
                    { new Guid("4452c6c0-a983-4da0-bcc5-181563d50429"), "Leone", "Collumbell" },
                    { new Guid("44f1042a-a088-40ed-beb4-523704d4a286"), "Florinda", "Luffman" },
                    { new Guid("44fca0fd-a199-40dd-91a0-c93ff17297cf"), "Tamma", "Jolley" },
                    { new Guid("457fd473-fb7b-4c01-acbf-664cd679f4a8"), "Zitella", "Chasemoore" },
                    { new Guid("4695ed5b-6bde-476f-8064-ddf4e324b944"), "Reinaldo", "Hasell" },
                    { new Guid("476fe0f7-149c-4156-b46d-519d01fa7bb1"), "Lauritz", "Degoix" },
                    { new Guid("481e43ff-7810-4116-bc5f-9b268f2b76c7"), "Britni", "Sellers" },
                    { new Guid("482f6dd8-d1d5-445d-8212-4aa87065958d"), "Ulrika", "Blanking" },
                    { new Guid("48352e11-cf84-4d45-98be-4c9795501413"), "Orelee", "Isselee" },
                    { new Guid("48ca3dda-0ab9-4a6b-825b-8b839212ace8"), "Myrta", "KnollesGreen" },
                    { new Guid("497cd05c-cd43-44bf-9df8-3876ffebd95d"), "Ashlee", "Lummus" },
                    { new Guid("49964dad-e5c5-46d7-8baf-7d75dd8676df"), "Dev", "Clynter" },
                    { new Guid("49a1dc0e-6bc2-4289-80b3-4c61a85dd633"), "Emmalynn", "Voden" },
                    { new Guid("49f0344a-8b7f-4753-a7b4-7e7c66adfe94"), "Clemens", "Wiz" },
                    { new Guid("4a11fb02-8185-4c0e-bce0-bf56db2436ec"), "Daile", "Croxon" },
                    { new Guid("4a89df1e-4263-4bd3-b3f5-ec47d399ef7f"), "Yehudi", "Oldford" },
                    { new Guid("4a992285-9c76-4376-a679-b8f5ec61d400"), "Laney", "Spaducci" },
                    { new Guid("4ab0609d-4af7-43fa-9c0c-8c7cff1b8816"), "Dianne", "Shrieve" },
                    { new Guid("4ace9e98-1fd4-4e77-b8da-3c1f869cb6b2"), "Erinn", "Pifford" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("4ae04aad-e4d4-4ca9-9e4d-4be17f55f3a8"), "Clemens", "Westcott" },
                    { new Guid("4af595bf-6ead-4e5a-a962-d53f372eafca"), "Dukey", "Forstall" },
                    { new Guid("4afb4e18-de8f-44f7-bde6-422d9dacec45"), "Ailey", "Bartelli" },
                    { new Guid("4b3fa199-ecd1-4625-8f9d-079ecd2fc0f5"), "Rolf", "Hunnaball" },
                    { new Guid("4b9f8008-3206-48fa-a09a-c1b641ccf4b5"), "Vonni", "Twinbourne" },
                    { new Guid("4ba66e69-3930-44a2-b803-cecb3cee3097"), "Isidor", "Brooksbie" },
                    { new Guid("4c0edd26-bedc-4870-b288-62221a0d5652"), "Olenka", "Stuther" },
                    { new Guid("4c538209-246d-4705-ae9e-415a4779fdec"), "Gaspar", "Veldman" },
                    { new Guid("4ce4ce9b-9e65-4e56-94d6-958b404eaab9"), "Phil", "Corpes" },
                    { new Guid("4cf0792f-472e-467b-8bd0-32451ed50579"), "Evanne", "Pettwood" },
                    { new Guid("4df3514a-e3e2-429e-9f96-4adf3b3872f7"), "Torey", "Sidden" },
                    { new Guid("4e2a968f-ca49-4ba1-8f4d-550092163bc5"), "Herta", "Vequaud" },
                    { new Guid("4efcad9f-201a-49c5-a612-e6fd0f8d6c31"), "Catherin", "Scarasbrick" },
                    { new Guid("4f5171c4-53c4-4d07-b73b-58cb27343ba6"), "Gavin", "Duffit" },
                    { new Guid("4f9796dc-a434-418a-b96a-03b9b5af3475"), "Laurene", "Dovidian" },
                    { new Guid("4faa4f23-0f75-441f-8048-d9f0338101c0"), "Rubia", "Lacheze" },
                    { new Guid("4fb98fcc-c5bd-4d8d-ac3f-7cabf3954ac8"), "Cyb", "Mathelin" },
                    { new Guid("4fd2d3fc-0528-446e-afb3-ccc29bca2a35"), "Jessee", "Eatock" },
                    { new Guid("4fd76409-8e66-43aa-9261-da0cb238c689"), "Letizia", "Mills" },
                    { new Guid("50067643-6f49-4dc7-b1ef-f16b78da8ad5"), "Bee", "Gough" },
                    { new Guid("503981ad-b428-4fe9-bc56-a1a96ebd17f0"), "Rolando", "Faldo" },
                    { new Guid("504a498e-074e-4ced-b80e-361475578816"), "Lisa", "Dalrymple" },
                    { new Guid("5057382f-432b-44db-a982-e6cb06a028d2"), "Marthena", "Hickeringill" },
                    { new Guid("509a3022-49d7-4a78-ac78-ae17f4246dc5"), "Saraann", "Killough" },
                    { new Guid("5153f2b1-06af-4b0b-a683-38adda2bd667"), "Ursuline", "Litton" },
                    { new Guid("51e6b040-8c0e-4b6c-b643-a08fb84cafdf"), "Tarrance", "McGurgan" },
                    { new Guid("523558b3-2f92-4869-85d6-99d47981492c"), "Alister", "Duggary" },
                    { new Guid("5254d9b7-7a75-4c43-a74c-6f8a0f450099"), "Terrance", "Wisden" },
                    { new Guid("5274cc8f-58b7-46e6-94db-26bc98c974a0"), "Gordie", "Brittles" },
                    { new Guid("52b06a3d-6e38-4e84-9b33-01111f9d4502"), "Sandy", "Roderick" },
                    { new Guid("52b5af62-ca26-428e-9815-bc5800c6cbce"), "Zebulon", "Gonthard" },
                    { new Guid("532f0956-d9ac-48e0-9932-a552b774eac3"), "Edin", "Jefford" },
                    { new Guid("53433646-0e07-4145-bedb-0db50cb74707"), "Charla", "Kachel" },
                    { new Guid("5380659f-2ce3-4bfe-a1db-003100941591"), "Gabriell", "Demeza" },
                    { new Guid("5380e8bf-636b-4486-9044-eb53527f2e05"), "Neall", "Claussen" },
                    { new Guid("538191e8-5115-410a-8979-245eaf2ee054"), "Rori", "MacBean" },
                    { new Guid("53b5046d-795f-434b-89c8-7a8c7d3087de"), "Barb", "Rickword" },
                    { new Guid("53c4b47d-9534-485f-a0ad-6a0c9cceba1a"), "Broddie", "Wagge" },
                    { new Guid("53d20252-1c2e-4146-ba5c-f5f192bd3bfd"), "Zarah", "Karp" },
                    { new Guid("541f723f-f1e7-40cd-98f4-31c16306cde0"), "Carey", "Osman" },
                    { new Guid("54648055-58e3-4fc6-85f7-717b68affa82"), "Lorry", "Fearnley" },
                    { new Guid("54eb640f-d92b-45de-b45b-afbe3e6d36ac"), "Erinna", "Jirick" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("554a5b67-3cde-4096-8085-d5c87c86515e"), "Effie", "Maddick" },
                    { new Guid("55b8b7d9-5078-4e2e-9a0f-bbace7d2ba4b"), "Peyter", "Craghead" },
                    { new Guid("55d8b245-4396-4afb-811a-166e6dc1eccd"), "Ebony", "Kitteman" },
                    { new Guid("55d8d918-c387-4b88-b778-01c183d4d854"), "Robin", "Ilieve" },
                    { new Guid("55e42d75-f0bc-4547-a313-97e33359f669"), "Ranice", "Lorriman" },
                    { new Guid("5607be63-ecb4-40f0-82ad-dcac05d2826a"), "Missy", "Neames" },
                    { new Guid("561bd8c4-a03d-4be9-a2e8-78ed46ca4274"), "Tarrah", "Langtry" },
                    { new Guid("5718aa57-4dca-446b-84da-827670e66495"), "Latashia", "Paolazzi" },
                    { new Guid("5769ccb3-2d3a-4406-8ed5-74ea1f965053"), "Talyah", "Rowcastle" },
                    { new Guid("58426ca4-5446-47d5-b91a-d317fbfdc525"), "Giselbert", "Wenban" },
                    { new Guid("587c4769-f9f4-4071-a4aa-5657ff07f98d"), "Jarret", "Jakov" },
                    { new Guid("58d8058e-ba3b-43b6-ad64-efceeff7caf5"), "Jean", "Whiteley" },
                    { new Guid("59416f28-e187-40ea-b26e-fc26dc0022ea"), "Bertine", "Sword" },
                    { new Guid("5954eb33-a4fc-462e-b69a-c4b35b2d23b4"), "Dyane", "Jodlkowski" },
                    { new Guid("59925d21-b3e0-40a3-9c3e-47ec00ca09c8"), "Ulrika", "Borgars" },
                    { new Guid("59dd2652-6f89-428c-a402-bff4121455ab"), "Bebe", "Clemmett" },
                    { new Guid("5a3b9687-1549-4621-ad51-4636f86394fc"), "Adelaide", "LeFranc" },
                    { new Guid("5a431516-a853-4511-b84a-092c5e7a4fa7"), "Hendrick", "Arnaud" },
                    { new Guid("5a46e5ca-65b6-4a88-affe-1e0a14bd2429"), "Brannon", "Rollings" },
                    { new Guid("5a5738b3-0076-4100-9a95-4a0bc0b0e837"), "Calli", "Hayley" },
                    { new Guid("5a7ea557-47a8-4b28-be39-90b80c104170"), "Mata", "Scrinage" },
                    { new Guid("5aaced39-ca84-49f5-9c8a-ca860048d28b"), "Gregg", "Goodread" },
                    { new Guid("5ae767a4-63a4-4b2e-b342-857fa81f8377"), "Ryley", "Yarnold" },
                    { new Guid("5aef495f-a566-46f1-aae2-66d7c497630e"), "Susannah", "Alty" },
                    { new Guid("5be3f749-a4f7-41c8-b624-f8efac62bdcc"), "Kahaleel", "Martignon" },
                    { new Guid("5ca106d7-50f8-47df-9a69-300ab6c1530c"), "Lorna", "Orrobin" },
                    { new Guid("5cf81ef7-3334-4fd4-b443-da781fa1bfe9"), "Parrnell", "Havard" },
                    { new Guid("5d47bba2-ee33-4b27-8c81-15e59c1608e8"), "Howie", "MacFadden" },
                    { new Guid("5d497ab4-fa1a-405e-9c7b-13d86705e5f5"), "Neall", "Wissby" },
                    { new Guid("5d57707b-c549-4e16-8198-210e6540eea7"), "Moyna", "Phebey" },
                    { new Guid("5d925066-b8ce-4bba-b3d4-7d179a339e13"), "Brandie", "Sandford" },
                    { new Guid("5da160eb-89a8-404c-b939-ce802b541766"), "Nani", "Featherston" },
                    { new Guid("5da62672-34c8-4dac-9284-39f4a3970123"), "Lanny", "OosthoutdeVree" },
                    { new Guid("5de4c448-dc13-496c-8858-8031eb4c71de"), "Elizabet", "McPhelimey" },
                    { new Guid("5e4fc82e-3f7d-42e2-ba87-eb965f69c078"), "Pavla", "Noir" },
                    { new Guid("5eba6825-745d-4bf9-ae68-5216f0e7d617"), "Wallis", "Lackey" },
                    { new Guid("5f2473f9-6856-49e5-acef-f4a50d346d2e"), "Hyacinth", "Sheeres" },
                    { new Guid("5f2c982d-53fd-4c4c-aaba-b79976b44c95"), "Alard", "Vader" },
                    { new Guid("5f3cf3d6-a7db-46b8-abd2-96ece5ebf854"), "Simmonds", "Dartnell" },
                    { new Guid("5f60403f-58da-4f23-9b17-66a4f26aff24"), "Archie", "Ricco" },
                    { new Guid("5f7219c5-694a-4792-860a-852f7bfddfff"), "Gladys", "Willoughby" },
                    { new Guid("5f913e8d-0608-4065-950d-e15db08fcdfd"), "Alfy", "Coil" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("5fe724a4-5c20-42b4-8b11-44f965dba446"), "Atlante", "Castelletti" },
                    { new Guid("607c1b35-4a88-41c8-ae7f-f044b90330da"), "Alix", "Verny" },
                    { new Guid("60c76f03-5291-4455-a0d6-f45def618472"), "Deanna", "Arderne" },
                    { new Guid("60cc65d0-a79d-4980-b433-343607cd3112"), "Ronica", "Zmitruk" },
                    { new Guid("60e941b1-867d-4475-9821-b11f97b8481c"), "Jerrie", "Wattam" },
                    { new Guid("60fef97d-b154-4e77-8ed3-a6279306bb6d"), "Karlens", "Brito" },
                    { new Guid("61999025-8149-4529-bbd7-c82935d20bc8"), "Nicoli", "Tyas" },
                    { new Guid("619f0308-56f1-4a69-8153-146abac23621"), "Rosabel", "Estick" },
                    { new Guid("61b67117-c535-4c4e-8e48-05d59cb76ad7"), "Dominik", "Sevier" },
                    { new Guid("61df6d79-e875-4971-b333-787a5bc6043c"), "Audy", "Vankov" },
                    { new Guid("620a9cd1-b46f-46a0-8989-25d4d2884537"), "Sammy", "Dumbleton" },
                    { new Guid("623cc4dc-88d3-4e98-bad1-deea8652ddda"), "Dougie", "Haydney" },
                    { new Guid("6250a70d-db50-4fe2-9eb0-9220dc1a68ac"), "Erich", "Averies" },
                    { new Guid("62822695-503e-4e61-85ad-8e19d7bbc2d3"), "Shelbi", "Huett" },
                    { new Guid("62cb760c-f45e-4b29-8937-cb84398e32a7"), "Moria", "Patley" },
                    { new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"), "Isac", "Baudains" },
                    { new Guid("6362ec8b-4798-4485-9d78-09a367dbd7ae"), "Hube", "Stetson" },
                    { new Guid("63d55e93-538b-4c21-84b9-9d51a8e0ffff"), "Rob", "Vivyan" },
                    { new Guid("646c41f6-2b19-4daa-abc9-f0c268f910ef"), "Kit", "Hows" },
                    { new Guid("64d755cc-f6d2-44dd-a7c4-9e55610a81c4"), "Cori", "Paolinelli" },
                    { new Guid("64ee323f-e840-493b-bfaf-cdab9400466d"), "Jillana", "McGee" },
                    { new Guid("64fe9ab9-6403-43a8-a1d7-0cfc98c6657f"), "Creight", "Stopforth" },
                    { new Guid("65059c5b-9872-49bb-b477-ce1c89bd0cce"), "Sherwin", "Keningley" },
                    { new Guid("65214b58-0906-4204-bdec-0d4128324bb4"), "Humberto", "Silverlock" },
                    { new Guid("6525bcaa-77c5-4154-9729-c72d64a06d71"), "Gwenore", "Wabersinke" },
                    { new Guid("65a7332c-313e-48e6-a284-76e83c40d9df"), "Cory", "Codeman" },
                    { new Guid("6619fec9-914f-40c6-8fc6-1610dc8a2564"), "Holly", "Harcase" },
                    { new Guid("661a88a2-7a90-4349-b093-dce3b409d450"), "Katinka", "Ceci" },
                    { new Guid("666fdd39-a35e-40a5-b61f-52fbf324895b"), "Wylie", "Hayden" },
                    { new Guid("66950e8a-cbd7-4a3e-bde7-3acfe719c9b1"), "Goldina", "Scroggs" },
                    { new Guid("66cb2283-2b80-45fb-9418-3867cb2af3d5"), "Cale", "Mottinelli" },
                    { new Guid("66d8b486-0875-40cf-8227-d731fddc8694"), "Jacquetta", "Byer" },
                    { new Guid("67196654-85c4-4562-9e22-8f48353d1177"), "Sterne", "Aiton" },
                    { new Guid("6727637f-0d96-41bb-8a71-3ed377bff5bf"), "Ginger", "Wren" },
                    { new Guid("672b28a5-1143-41ce-a548-128fedebbe25"), "Keelia", "Hastwell" },
                    { new Guid("67454c28-8495-457f-8b7e-37afc6ca598f"), "Lodovico", "Seson" },
                    { new Guid("6770bc5b-adf0-4128-98eb-5467c5941bbe"), "Tyson", "Bere" },
                    { new Guid("67cd07fc-a2c7-4630-9512-fd8a0a807b14"), "Launce", "Keogh" },
                    { new Guid("67d73496-4831-4b92-a231-4ac7866fc28e"), "Raddie", "Neno" },
                    { new Guid("67f34eac-49bc-4026-9284-5c883217d957"), "Easter", "Ragot" },
                    { new Guid("680a3b2a-4b5c-4888-a511-a2d91c501804"), "Flori", "LeProvost" },
                    { new Guid("683f62ac-33ee-45f8-8a5e-721d1b0fbd56"), "Juana", "Edwick" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("6856ba53-2c1e-4512-a802-1f41f6477f07"), "Markos", "Bachshell" },
                    { new Guid("68906ff8-ef6e-4d26-8534-7601ad9b0fcd"), "Jere", "Coat" },
                    { new Guid("689130df-80ce-4f32-b945-4e0ce3ed0c02"), "Aline", "Feldheim" },
                    { new Guid("68a44f88-d6b2-4874-bf57-3cbcae869b15"), "Nicolina", "Kydde" },
                    { new Guid("690ae88c-955a-42d6-8bae-cb437f7ffe58"), "Roana", "Bader" },
                    { new Guid("697085a0-dcc7-4d69-988c-6bb0e1ec1880"), "Gloriane", "Pagel" },
                    { new Guid("69a396b6-43f2-416e-a00e-b3adfea00c88"), "Erena", "Shillitto" },
                    { new Guid("6b5226fe-b18e-4e81-a136-e5c8e6ad4f23"), "Price", "Pentecost" },
                    { new Guid("6b751a89-1e62-43ca-b754-2a4123355c9f"), "Leanora", "Schoffel" },
                    { new Guid("6b7ca30b-d7af-4952-8e4e-2a9fe020eda9"), "Aeriel", "Poznanski" },
                    { new Guid("6b8771aa-7664-4f7b-87f6-b3457b68374a"), "Oran", "Petrovsky" },
                    { new Guid("6b98801c-0e77-48cb-b9c3-0a1fbf103f53"), "Chloe", "Evens" },
                    { new Guid("6bf33252-eb9b-4b3a-914b-c05a1a74d4d6"), "Madelon", "Vitall" },
                    { new Guid("6c0a9641-7993-45c5-a852-d3268ac224f2"), "Charil", "Crambie" },
                    { new Guid("6c116e93-222e-4813-bd35-97af4e0626eb"), "Lauren", "Doodney" },
                    { new Guid("6c29785f-2e10-4cff-93e5-d0b57852cf95"), "Nerte", "Gilder" },
                    { new Guid("6cb305f3-eb38-473b-ae50-2e968e995935"), "Leanora", "Delafoy" },
                    { new Guid("6cfb8b0f-4343-4357-b2e4-55d75b510f38"), "Rosalind", "Richardot" },
                    { new Guid("6d53ec25-c1e2-4bf8-8881-b51b5117e43d"), "Corbett", "Cavaney" },
                    { new Guid("6d97826a-b01a-483c-ad18-7b3b3da99f01"), "Mack", "Durston" },
                    { new Guid("6deeb509-6c19-4323-b2f7-c86349a2b003"), "Von", "Haylock" },
                    { new Guid("6df697c7-6939-4f33-a82e-0dcc75fdca4f"), "Emlyn", "Miskimmon" },
                    { new Guid("6e4ba9be-2758-4b3b-857d-6bb5d3f815fa"), "Brad", "Robic" },
                    { new Guid("6e82bd0a-0023-42c7-9e46-6a5bb95b7484"), "Wilek", "Smewing" },
                    { new Guid("6ec740d7-b9cf-46a0-8c42-2c83d3f030b4"), "Felice", "Meier" },
                    { new Guid("6ed19bdd-2cb4-43d9-b830-420cfbe2c180"), "Van", "Kemm" },
                    { new Guid("6f8c9362-a796-4179-9707-638ee0ea0ec1"), "Danika", "Tenaunt" },
                    { new Guid("6fb52fae-c0ba-40aa-bdd6-86304d63a1e5"), "Nert", "Chicotti" },
                    { new Guid("6fcb4eaa-f56c-4565-99ae-6c2d42b448ce"), "Cindra", "Grocutt" },
                    { new Guid("6fcf8b1c-e7a0-496b-a86a-c8c6222a2e98"), "Lynette", "Saer" },
                    { new Guid("6ff2f920-c56c-419e-bdf5-789e30e08605"), "Vikky", "Concannon" },
                    { new Guid("70139c7a-6c13-4bdb-87d4-c1694e025026"), "Tripp", "Budgey" },
                    { new Guid("70775228-96a5-4e00-af62-c230349def0f"), "Agatha", "Huske" },
                    { new Guid("71114bb2-2230-4e41-9533-6d3b34a213ee"), "Tamas", "Downe" },
                    { new Guid("7177638d-3369-4b4d-b812-408159198a4f"), "Giselle", "Loveman" },
                    { new Guid("71883c85-5cca-49b7-bf9d-ae437f3ba3c4"), "Cory", "Burdekin" },
                    { new Guid("71ed4c21-9db1-4a27-b2ba-abbf9baf89f8"), "Collie", "MacAlpin" },
                    { new Guid("726c8369-0e31-4509-b56f-933e165dd42c"), "Karleen", "Guillot" },
                    { new Guid("72794b1d-5453-47ac-96e8-bb37f6e483eb"), "Ingunna", "Goodbarne" },
                    { new Guid("72b841d4-68b1-4e9b-a767-fb498485e408"), "Jemmy", "Greenly" },
                    { new Guid("72ddafc0-9849-40cc-b04c-10050d485c26"), "Ravid", "Winger" },
                    { new Guid("7304daf2-8df7-451e-b35d-56e6cc94d092"), "Padgett", "Firth" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("7380d008-4710-45ee-aff4-9b69627d8fa0"), "Hilde", "Mahady" },
                    { new Guid("738ba564-a099-4749-8af6-f13e46b494d2"), "Reginald", "Ivakin" },
                    { new Guid("7394db23-0068-4c8b-9c51-8106f9a7731a"), "Dulcine", "Broun" },
                    { new Guid("73a57c91-2933-4f5b-9754-c542bd143feb"), "Rita", "Grassi" },
                    { new Guid("73a974f3-4c0a-4160-8832-631bdcf99123"), "Antonietta", "Ernshaw" },
                    { new Guid("73aebb7c-0cd6-4af3-8fc8-51b3355c8501"), "Stillman", "Selvester" },
                    { new Guid("73bfa88b-6da0-41d0-8e7f-2b344dcc75b2"), "Joelly", "Wingatt" },
                    { new Guid("741323c4-4349-492d-aeb5-0d1877ea2383"), "Zack", "McFater" },
                    { new Guid("746ae46b-0158-4ccb-ae3a-4e5a0f76a1c4"), "Andrey", "Laudham" },
                    { new Guid("74b56546-b19f-4d74-97cc-c73c6f7055fa"), "Gonzales", "Newvill" },
                    { new Guid("75068271-5119-49f7-8c2a-c8aafe5db994"), "Cairistiona", "Boydle" },
                    { new Guid("75219ab1-3a27-46dd-b651-797b6a6f20d9"), "Othilie", "Forsyde" },
                    { new Guid("755a51dd-260e-4cc7-88cb-0d7efd06ca45"), "Hyacinthia", "Rabbet" },
                    { new Guid("76057b1c-a66f-45ab-ac1d-c4747aab6c4b"), "Reggie", "DeryeBarrett" },
                    { new Guid("76393834-3cfc-4e90-86a9-f2ca27953f07"), "Anastasia", "Jaskiewicz" },
                    { new Guid("767be4eb-dc82-4a86-9c72-9938f0c1a54a"), "Clarence", "Acory" },
                    { new Guid("76b85efc-72bf-4480-bef3-e80c4a3c3617"), "Ingaberg", "Brookzie" },
                    { new Guid("76d4abc7-148b-41fc-aab6-06f05c220f36"), "Bendick", "Williment" },
                    { new Guid("76e57b14-7f0c-4110-9fe5-ae82a426fa1a"), "Hilario", "Baudains" },
                    { new Guid("7745a287-443b-411e-85a1-97ca5a4ecd48"), "Alfi", "Brill" },
                    { new Guid("784b8758-1e5e-471c-a029-24b42a018a3b"), "Dell", "Riccardo" },
                    { new Guid("7859aa81-14a9-4735-b1f8-f00960d3b342"), "Diarmid", "Sebrens" },
                    { new Guid("78cc65b6-2bc6-4a36-87c7-6f0a5a375243"), "Giacobo", "Rodenburg" },
                    { new Guid("78d3412c-6e99-4217-805a-51c60a6e5242"), "Hillyer", "Lenoir" },
                    { new Guid("78e11718-4856-4720-9590-c7b7d1d4b413"), "Storm", "McDuff" },
                    { new Guid("794c30e1-5ab6-41c7-b562-0683c0b7875e"), "Bond", "Fraschetti" },
                    { new Guid("7956045e-3602-448a-862c-336200d8df8e"), "Keefe", "Sommers" },
                    { new Guid("79fd3b14-3e12-4d26-a6d3-ef93f0aa8be0"), "Farica", "Abramcik" },
                    { new Guid("7a0b2670-2351-46f0-9e4e-545685bdbf24"), "Dotti", "Blankau" },
                    { new Guid("7aa41135-6051-486d-8eee-4ae624f43516"), "Dacey", "Worsnip" },
                    { new Guid("7b304e1b-e26c-4448-a5e4-aedf31c439a9"), "Grannie", "Murgatroyd" },
                    { new Guid("7b728c79-dc06-4871-aa28-aaad2a702afb"), "Sherilyn", "Cochrane" },
                    { new Guid("7b930168-81b1-4535-a095-c9d7d86e53c4"), "Jennilee", "Benjamin" },
                    { new Guid("7bd14181-3064-45eb-8a57-735bbb4f3ee1"), "Fleurette", "Doughty" },
                    { new Guid("7c4434be-d2f7-4d8d-9933-8e4a0e09cf75"), "Emili", "Silman" },
                    { new Guid("7c9d8b2b-cec8-401f-ac51-d35b2fbe0a59"), "Moishe", "Telfer" },
                    { new Guid("7cbe2473-2c54-43f1-9e26-f8cb6c345898"), "Mabelle", "Manske" },
                    { new Guid("7cbe3881-44c6-4a91-96ab-9acafa35f716"), "Jenica", "Abram" },
                    { new Guid("7cede0b5-02ca-4398-913c-54c50bbf4cfd"), "Thomasina", "Palphreyman" },
                    { new Guid("7d025fa4-0ce3-4792-bf95-d6362c98db02"), "Brittany", "Swendell" },
                    { new Guid("7d0729ab-628c-437a-9b0c-d4386076caa6"), "Cozmo", "Chesson" },
                    { new Guid("7d27004e-7607-4591-ad14-71f4504b044d"), "Augy", "Ortiga" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("7d3ef2f1-b0a7-492d-bd40-e5194229ce2b"), "Emlynne", "Lehr" },
                    { new Guid("7d55c58f-59b0-4a25-9592-ed64c2b4e8ee"), "Lillis", "Arguile" },
                    { new Guid("7d761b80-085d-43e6-bb2c-effe2393d35f"), "Kile", "Giacomini" },
                    { new Guid("7d8d17aa-6d08-4a17-a703-953a180e2ccb"), "Sherwynd", "Croston" },
                    { new Guid("7de4bc97-05f9-48e2-a848-f1971a19706a"), "Adrian", "Briers" },
                    { new Guid("7e11d767-ea63-4a2e-9aea-77f04bb39b83"), "Goldia", "Maty" },
                    { new Guid("7e150311-319a-49a9-83c2-192c32b1363b"), "Shea", "Wibrow" },
                    { new Guid("7e38a4c3-5fcd-412e-ad26-2caf8d60b5cf"), "Derrick", "Bourthoumieux" },
                    { new Guid("7e6bcbed-066d-4a21-858d-44e864ee2280"), "Feliza", "Pendlenton" },
                    { new Guid("7eb7f2e8-ad00-4e34-a20c-2ceaddaee834"), "Flory", "Esparza" },
                    { new Guid("7f60ac25-699a-4e94-8529-4e4e2649e4ee"), "Roldan", "Dillon" },
                    { new Guid("7f9f6415-2a54-4e46-8886-af514168de43"), "Moises", "Lawranson" },
                    { new Guid("7fd9d8ba-dbd0-45aa-8459-ac3e049912c3"), "Scott", "Swenson" },
                    { new Guid("7fed3ea5-9f37-4543-a2c1-64718dac6142"), "Sari", "Gremane" },
                    { new Guid("80506364-36c8-4cdd-8719-7a786f31f2a7"), "Josefina", "Stigger" },
                    { new Guid("80b82dd4-245c-4c16-afb1-df3b54d52d3d"), "Rodina", "Patton" },
                    { new Guid("816e54ab-c013-4211-82dd-4c7cf3c5f5b3"), "Suzi", "Dungate" },
                    { new Guid("81a5b860-3cbf-42a8-948c-46e22d7d0d0b"), "Harvey", "Gribbin" },
                    { new Guid("81de9bef-1643-4cb7-8700-10cb9b09cef4"), "Izaak", "Ganford" },
                    { new Guid("8222e14d-e58d-42f2-94f1-0f20706eb0ac"), "Pam", "Gallgher" },
                    { new Guid("823a039d-8fad-45c2-b7e3-51fa4bb63afa"), "Chaddie", "Cowland" },
                    { new Guid("82885a6f-ba33-4b00-9d73-0a808222a75d"), "Hewet", "Kettles" },
                    { new Guid("82932cb1-0765-466d-940c-55c2bc0ae54e"), "Martainn", "Mingus" },
                    { new Guid("836f5da6-02f6-401d-8b9e-68088a91dfad"), "Rhianna", "Ipwell" },
                    { new Guid("8396720b-3f4e-412a-8b5a-1053cfa69961"), "Durante", "Forsdyke" },
                    { new Guid("83aa75c9-fafe-43e2-adf7-5e0acb1977e7"), "Tamara", "Bootherstone" },
                    { new Guid("83d89db5-7204-46ef-93bf-fd6e9df782cd"), "Ginnifer", "Kienlein" },
                    { new Guid("84e31a7b-7d34-4849-9767-a0acde0bc8d0"), "Luci", "Dawkes" },
                    { new Guid("84e4ce3d-6234-4e46-93f1-cddb7624e95b"), "Ernaline", "Carff" },
                    { new Guid("84f921ca-680a-4203-8346-9e8972ebb1a3"), "Reube", "Ranaghan" },
                    { new Guid("852d7462-b700-4af6-b686-bf1e001de35b"), "Candis", "Petrenko" },
                    { new Guid("858e6f78-5fe3-484a-b874-7289abb29a4a"), "Odelinda", "Lehrmann" },
                    { new Guid("8591b231-6db6-4249-9461-4bbaf0a1aa95"), "Reynolds", "Geekin" },
                    { new Guid("85f36fb3-82f1-4955-9850-77c4b336cc5e"), "Basil", "Sunley" },
                    { new Guid("865234d8-9947-4df8-9883-6079fba39957"), "Dorolice", "Bedham" },
                    { new Guid("86ed9210-beca-4454-8457-15c80ef05071"), "Barthel", "Brose" },
                    { new Guid("86fc3e99-46c5-4df5-90fb-651d673a831e"), "Brett", "Seely" },
                    { new Guid("8707f668-e06e-4352-97a2-a573054ca001"), "Christy", "Parlor" },
                    { new Guid("8736b406-20a0-431a-aa2c-69b69fe7f7a4"), "Shanon", "Brunsden" },
                    { new Guid("8744a906-2952-4236-b56d-f60d81c02330"), "Osmond", "Mandal" },
                    { new Guid("876412d0-5548-4a28-ab47-e97e5b02876c"), "Degoix", "Kit" },
                    { new Guid("8788e433-0f31-4de0-a887-6e1e8e88a9ee"), "Opalina", "Tregensoe" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("87fe015d-8af6-45b2-bc90-7fcd7e5a4d68"), "Kayle", "Merrell" },
                    { new Guid("881b2f04-5fd0-4d33-9d04-f91f6780391b"), "Xylina", "Arnaez" },
                    { new Guid("888f4e1a-d257-4352-b778-0844eae5bdea"), "Gaspar", "Redman" },
                    { new Guid("889ef92f-5075-477b-a2e9-2e844824e416"), "Theadora", "Mosedall" },
                    { new Guid("88b01291-97a9-4c27-950c-40b66c115795"), "Martynne", "Arnley" },
                    { new Guid("88e7f720-a7e7-467d-a261-9915cc1772fd"), "Corie", "Crosham" },
                    { new Guid("8a14e59a-fb73-45e6-8d47-682aa5f20285"), "Kally", "McNelis" },
                    { new Guid("8a626998-9601-4e54-a607-3144cbc8c87f"), "Camile", "Pietrasik" },
                    { new Guid("8a92accf-e38a-40fb-baa4-2287dcf88d61"), "Valentin", "Smaile" },
                    { new Guid("8aaec912-0f85-4234-ab59-8b1a503684b6"), "Biddie", "Yorston" },
                    { new Guid("8af7a947-e742-4f20-93c1-56c546a3aed2"), "Debi", "Campo" },
                    { new Guid("8b0997b9-5d4f-48d8-b9ac-7ea47e9ffdef"), "Eldon", "Juppe" },
                    { new Guid("8b09f7ee-f33a-4e45-a7c7-1b50743f9ace"), "Federico", "Truswell" },
                    { new Guid("8b7497a2-eced-4fa7-a661-90d5dd230d44"), "Blinny", "Segar" },
                    { new Guid("8b89fda6-c83d-432e-be22-d212bd97e6de"), "Stefania", "Haxell" },
                    { new Guid("8b97e58c-c963-4ff6-96fd-98165b7ddd57"), "Kalvin", "Tester" },
                    { new Guid("8bbcf7a2-58b9-44b6-8195-4607a4ace18a"), "Colby", "Critcher" },
                    { new Guid("8bc2fbf2-b8be-420a-ab41-e49c44123753"), "Eilis", "Calbreath" },
                    { new Guid("8c2457e6-d528-4cca-9965-b47a47643d55"), "Tonya", "McFaul" },
                    { new Guid("8c3cb427-b57f-4700-aee0-42ab7e62cb98"), "Debera", "Claybourn" },
                    { new Guid("8d325859-3e3a-4f81-a33d-222d73760e31"), "Artus", "Pirkis" },
                    { new Guid("8d6350f3-2a44-4db3-8181-8147e830fbea"), "Ximenes", "Vest" },
                    { new Guid("8dd79e82-1d71-4b5d-bba7-7528558497ee"), "Melli", "Whellans" },
                    { new Guid("8e172b22-464d-4821-9e44-42930a56bba8"), "Nannette", "Elijah" },
                    { new Guid("8e327be4-3ed7-43ff-8c05-6dbaa197a0f7"), "Romain", "Yacob" },
                    { new Guid("8e3c13b0-12ad-4e03-a097-560841a5733e"), "Geno", "Micka" },
                    { new Guid("8e4ca83c-b184-4f17-a313-218ebb721134"), "Aviva", "Batiste" },
                    { new Guid("8e96d060-1f56-496e-a327-467a75d663af"), "Avram", "Pinchin" },
                    { new Guid("8eb3b3ab-dc56-4722-8307-63aeaab37f60"), "Gilberto", "Trimble" },
                    { new Guid("8fd75b4f-e4c5-4e9e-83be-1e239089f8b9"), "Zoe", "Louedey" },
                    { new Guid("8fe1c98e-5a98-4269-95c6-95c4ae010ce5"), "Vince", "McGloin" },
                    { new Guid("8febbd9c-e667-47c8-a486-495b3f4a49f6"), "Lorry", "Elderton" },
                    { new Guid("90215e51-afaf-46f1-8559-0afd4052b8b7"), "Mellicent", "Favell" },
                    { new Guid("904e3806-0725-427b-b997-d746feebfb6a"), "Lyn", "McMeekin" },
                    { new Guid("9058208b-65e0-4908-a6b9-f5d1c5bc867c"), "Lishe", "Drage" },
                    { new Guid("9080b474-faaa-44ea-8c3d-66cbcc59c686"), "Marcia", "Gladwell" },
                    { new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"), "Guglielma", "Ripon" },
                    { new Guid("908f231f-dfb5-456d-847a-a2959286b9ef"), "Winona", "ONion" },
                    { new Guid("90b53bcd-c664-4424-870e-f26a379f38fc"), "Viv", "Regnard" },
                    { new Guid("90dff086-d88e-483d-bf30-8d535f84b21f"), "Malanie", "Rigmond" },
                    { new Guid("90fc885d-7fb1-46d0-8a1b-c77c9bd0dc58"), "Klarika", "Mangeot" },
                    { new Guid("9150f2b1-ae54-42a7-b70c-c9c1bf768ba3"), "Cyril", "Giovannazzi" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("9196f1a3-d6d5-4a1d-a167-040c85293f4a"), "Edsel", "Radnedge" },
                    { new Guid("91a2908f-52e1-4282-87f6-c740f6497403"), "Georgeanne", "Hatcliffe" },
                    { new Guid("91ce4849-8394-4fd6-b4e0-22dba815f48e"), "Win", "Milkins" },
                    { new Guid("91cf8bd5-b2a7-49a9-8166-95b73559ad5a"), "Reid", "Marchelli" },
                    { new Guid("92428c0e-a8be-442c-ae47-1127aaf2f5de"), "Madelena", "Boulton" },
                    { new Guid("927cb894-93d9-42bd-bcd7-ff508507030f"), "Tabb", "Hayesman" },
                    { new Guid("92dcb42a-2d2a-405b-b9f8-a43981b4e6c5"), "Faydra", "Powdrell" },
                    { new Guid("936d84fc-1467-4857-979e-6908ec86a62f"), "Maurene", "Romao" },
                    { new Guid("93b68c62-977c-4fe1-be91-347a8fdb5c65"), "Jesse", "Goodding" },
                    { new Guid("93bb9671-13f7-4d67-82a6-fcaa7d85951a"), "Shena", "Linebarger" },
                    { new Guid("9415ada1-b693-4542-9f42-cd7ece208df1"), "Waite", "Aps" },
                    { new Guid("9499012b-9ded-443e-9a92-5166d7d9adc7"), "Daron", "Blowne" },
                    { new Guid("94ce3336-7efc-423a-8242-1ac0168b4d47"), "Noby", "Lys" },
                    { new Guid("95063ef9-dfb2-482c-8b95-2d990034e231"), "Felix", "Ducaen" },
                    { new Guid("95432bd9-5969-437c-b45d-939e6a3114b1"), "Silvanus", "Tantrum" },
                    { new Guid("956dfc48-c43b-4e91-9353-9105e1860300"), "Gordon", "Lunny" },
                    { new Guid("95736e11-e4eb-4cdc-810b-a7aa18ff212c"), "Lorens", "Elcott" },
                    { new Guid("95b96ad3-3c42-4563-a5fa-7642b9b9a706"), "Ewen", "Mannakee" },
                    { new Guid("95d596b1-15d9-4ed4-975d-14c571a12a24"), "Bond", "Gauvain" },
                    { new Guid("962e6ef8-9552-4e43-9a2d-7eccbeaef6d5"), "Anastassia", "Royall" },
                    { new Guid("96813ea2-1794-4df1-86e0-640f94734e5d"), "Bron", "Eitter" },
                    { new Guid("97b72887-c52f-4d19-ac99-6b772416e084"), "Colline", "Floris" },
                    { new Guid("983c17af-b529-482f-8334-38e66884d9c6"), "Hobard", "Kinloch" },
                    { new Guid("9850d853-a4ee-4886-a453-d9a1c5f59adf"), "Dorena", "Melwall" },
                    { new Guid("9865dd11-ee6d-4395-99b7-72165467ea93"), "Ferguson", "Bissex" },
                    { new Guid("987950eb-5ff5-4be8-8328-495ad2cf7a68"), "Madelin", "Manthroppe" },
                    { new Guid("991640fc-0443-4c08-9a22-7dbce915318a"), "Farra", "Streetfield" },
                    { new Guid("991fc667-d805-4de6-9cb3-3081766f90ac"), "Roz", "Alford" },
                    { new Guid("994545f1-93a4-4482-a9e1-98a76169206f"), "Kin", "Kingzet" },
                    { new Guid("99771a9f-d0de-49cd-a9b0-c84e9b4bdf8a"), "Alessandro", "Bruty" },
                    { new Guid("99aa0c17-bd53-4170-a9c3-b8405978d00f"), "Federico", "Attenbrough" },
                    { new Guid("99cdb186-3402-4bb5-8322-06008018c667"), "Shalna", "Gheorghe" },
                    { new Guid("9a497959-c231-4b93-a051-d2d3f921ee41"), "Miran", "Schustl" },
                    { new Guid("9ab2d015-bca6-4ef4-9772-bd7fcb4e2c85"), "Lethia", "Arro" },
                    { new Guid("9ad9a6eb-7a2f-4eec-89a5-eb7500e746cf"), "Justen", "Puttick" },
                    { new Guid("9b72a576-6ff8-40e1-aeeb-6740223e9a77"), "Athene", "Breit" },
                    { new Guid("9b7ff001-51a8-4076-9c0d-66aa23171398"), "Trip", "Braundt" },
                    { new Guid("9bb405db-a1e2-4a9d-be4b-d2680922068f"), "Rycca", "Maxwaile" },
                    { new Guid("9bba696d-9d79-4338-a1ab-e214d32254a0"), "Hammad", "Alliker" },
                    { new Guid("9c06d170-1d58-4df3-bed9-072b992f086e"), "Jessa", "Gaynes" },
                    { new Guid("9c9eb9df-a946-4a61-8ea7-51c5520c10ad"), "Dolorita", "Gascoigne" },
                    { new Guid("9cce06ba-9a83-4c39-b49e-47be72ac656e"), "Riva", "Laible" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("9d5149ef-0c19-4db1-8c79-40121d5d7e21"), "Alys", "Kretschmer" },
                    { new Guid("9d5b08b1-dee6-4e69-817e-a8bf92d81124"), "Ertha", "Lynthal" },
                    { new Guid("9d863819-1a15-444a-9ba0-d32368d0a290"), "Ellsworth", "Bordessa" },
                    { new Guid("9ea07d3d-fb8c-4593-a762-ed8f0ed73b5a"), "Eimile", "McLeish" },
                    { new Guid("9eaecb0c-d67b-4a3f-9295-28c30aaa7ba7"), "Sashenka", "Gateland" },
                    { new Guid("9ebc83e7-1f11-4aa5-8404-ebb078632f29"), "Loutitia", "Pretsell" },
                    { new Guid("9f47d237-06e8-4131-be82-fa976f77ba89"), "Ailina", "Tellesson" },
                    { new Guid("9f928a8b-4416-48ec-a03f-3c6df811724b"), "Kermie", "Churchlow" },
                    { new Guid("9fad2647-6ef9-45d0-9a84-7b97aa226c7e"), "Myer", "Hamlin" },
                    { new Guid("9fdac1dc-cdbe-4e69-9eff-8cf64d570eeb"), "Catlee", "Bowden" },
                    { new Guid("9ffc0977-37fd-4219-add9-9a25b073a10d"), "Annis", "Sneden" },
                    { new Guid("a03622bc-f35f-440f-9cc4-cb1076fe2528"), "Gasparo", "Bowller" },
                    { new Guid("a0712bbe-47b4-4ddb-a39a-fa82d285db15"), "Win", "Rubega" },
                    { new Guid("a0b4c6dd-b63e-4341-8f10-2cbcd0bda92a"), "Auberta", "Hartopp" },
                    { new Guid("a10a0a76-ecda-4236-b6db-cb91c89ac080"), "Kalil", "VanCassel" },
                    { new Guid("a136d6b3-28a6-43b4-912a-7bd9c4fd48de"), "Jillana", "Lune" },
                    { new Guid("a163169f-2cae-4d36-a28c-dc3a3dece569"), "Elysha", "Dransfield" },
                    { new Guid("a170014a-f0ea-438e-abda-dc4076c93a6a"), "Gunter", "Gajownik" },
                    { new Guid("a185dc5f-bec3-434e-8b92-44113233ff39"), "Ryun", "Fevier" },
                    { new Guid("a1ceb583-6417-4664-aac4-193be893832b"), "Gill", "Drewell" },
                    { new Guid("a1e54121-e8e2-4973-b49c-1f74c10ed69e"), "Flo", "Jozefiak" },
                    { new Guid("a24f5065-0904-4ac8-8d98-30979ee24fd9"), "Noami", "Stallard" },
                    { new Guid("a255f733-b873-4c45-8d80-ee885b918755"), "Hugo", "Bettinson" },
                    { new Guid("a2694f20-9b07-4ce2-8933-d83180ff8e2f"), "Jennifer", "Tregust" },
                    { new Guid("a2f76f52-8aa5-4ce4-b11b-138586c1af09"), "Genny", "Ambrogiotti" },
                    { new Guid("a329886f-2f4c-423e-a779-3ccb89e61080"), "Corabel", "Firpo" },
                    { new Guid("a3611cbc-276a-4874-b226-e3c31d91610f"), "Kathryn", "Coppo" },
                    { new Guid("a37d1a36-2bfe-4673-9811-5337c1231fd2"), "Olivie", "Marchetti" },
                    { new Guid("a3bcc27e-daa4-45dd-bc82-5e6711d8e425"), "Marlane", "Allden" },
                    { new Guid("a41acf41-2425-429a-8bc3-d47574f1dc82"), "Thomasine", "Millward" },
                    { new Guid("a4262159-a8c9-4350-8f70-4a09698a6a0d"), "Frasco", "Clawe" },
                    { new Guid("a43f4893-ee73-413d-9004-09c6cf5dfe6c"), "Harp", "Trimming" },
                    { new Guid("a44875d4-7608-4c3b-837b-bc7d912760b9"), "Dacia", "Doveston" },
                    { new Guid("a47af692-2999-45c7-88a5-75f81a07256f"), "Allison", "Byles" },
                    { new Guid("a47b7a85-b2fd-4ead-bc91-22a6c68f4363"), "Celisse", "Aleksashin" },
                    { new Guid("a4fa69ca-095c-4f86-97eb-445be94e9a85"), "Ashton", "MacArd" },
                    { new Guid("a5114f33-615c-4c6f-8e19-d1d06ca3ee9a"), "Renato", "Lambrook" },
                    { new Guid("a5359350-4d68-4343-be09-afe4b4f0e42d"), "Delmor", "Arnault" },
                    { new Guid("a5496f8d-e857-4ea5-bf27-8e7b533bb0e4"), "Colin", "Perle" },
                    { new Guid("a576b36e-56fc-4347-8d67-2898a18a047f"), "Kathe", "Gewer" },
                    { new Guid("a588eb99-4369-4ba9-83a3-76d84a4bed74"), "Sonja", "Abramof" },
                    { new Guid("a59d0611-a60b-479c-b95e-d49076a61694"), "Josey", "Lindstedt" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("a62532c0-0ac2-4680-bfce-462ba0a5a924"), "Cedric", "Pepall" },
                    { new Guid("a678f50c-92eb-46d9-a079-99b86cd5cdf2"), "Janelle", "Callen" },
                    { new Guid("a6e9a2da-b223-44d9-be33-1d1f3ef18b2e"), "Martguerita", "Doolan" },
                    { new Guid("a736f98a-bd72-42cb-bfc6-c9e9dd56490a"), "Shaw", "Owenson" },
                    { new Guid("a7a7194e-dc36-496c-81c4-cd1a4ab2c12f"), "Gare", "Browning" },
                    { new Guid("a7ff2067-4b59-4e9a-8a89-a328132c95f5"), "Bond", "Heeran" },
                    { new Guid("a8716f3a-676a-4e2a-a028-604b8ba2af4c"), "Linea", "Lawton" },
                    { new Guid("a8aa50b5-fdf3-4655-8949-92fe84eb9f79"), "Gabby", "Prinett" },
                    { new Guid("a900d174-abb0-4072-9fce-61a249bac951"), "Daisy", "Astin" },
                    { new Guid("a95c8910-d83a-4869-a4cf-08ee55be3f05"), "Susanetta", "Harrema" },
                    { new Guid("aa1a2ded-0229-4f1a-ae8c-5f80d0cbee38"), "Katheryn", "Trendle" },
                    { new Guid("aa904e6a-473f-464e-97bd-74c58ff115c6"), "Edmund", "Droogan" },
                    { new Guid("aad272d6-59a0-47c6-944e-58fc5dd8ba0e"), "Jaimie", "Aicheson" },
                    { new Guid("aae74c34-8c53-42d6-af9a-08d855388f1d"), "Jonie", "Bantick" },
                    { new Guid("aafbe801-5353-4a9c-88b9-6844e8211e62"), "Anallise", "Gulliman" },
                    { new Guid("ab65ff79-1d13-4682-b804-f37ffbff5317"), "Boony", "Twiddell" },
                    { new Guid("abd82b74-0280-4b2d-9877-cf13fbcac533"), "Dotty", "Fowls" },
                    { new Guid("abda4420-2bce-41c4-afbc-17fe3add6235"), "Gabbi", "Beven" },
                    { new Guid("ac1d0e46-93e9-4e8f-bd42-fd8776817650"), "Stefano", "Salterne" },
                    { new Guid("ac8bc911-2e4b-4c26-8f73-1e3bee913b24"), "Dunn", "Taplin" },
                    { new Guid("ac92d821-cfcb-447a-9b8e-db0cac64522a"), "Randy", "Rutherford" },
                    { new Guid("acd774db-b92d-4b71-a6a9-462262f6bd94"), "Rolando", "Hafford" },
                    { new Guid("ace3e3d5-bf0c-4164-a962-d9e5ac5e8bd6"), "Niall", "Kynnd" },
                    { new Guid("ace68f80-9a57-4129-9e09-436ea1d736c2"), "Johannes", "Shildrake" },
                    { new Guid("ad1e5cb4-e2a4-437f-87c2-e76a78e4d0e5"), "Demetria", "Ingerith" },
                    { new Guid("ad533211-4ff4-4ce9-828d-082346666f62"), "Kacey", "Gourley" },
                    { new Guid("ad5bcddb-97d2-44fa-92f9-d052bd6c04b7"), "Susette", "Ponnsett" },
                    { new Guid("add8b096-6816-4e92-a968-2b4ddd795f1c"), "Ryun", "Hadlee" },
                    { new Guid("aebf2bd6-1904-43fd-9b2f-c06fdc04f541"), "Leonardo", "Fetherstone" },
                    { new Guid("af027d77-54e8-417e-b2b0-e40479c99b94"), "Deane", "Barnewell" },
                    { new Guid("af118cbd-3803-4e0a-a6ce-62ac0e32fd34"), "Merrel", "Ternott" },
                    { new Guid("af862d57-03a2-4c61-8839-02eb30a1b1b1"), "Urbanus", "Urpeth" },
                    { new Guid("afdc2c84-da2b-4484-9418-19a304712224"), "Lonna", "Pratten" },
                    { new Guid("b04e2b34-77da-4cee-960f-af5210956e72"), "Giuditta", "Mulvey" },
                    { new Guid("b08257b8-25a2-4afb-a578-9d7600243614"), "Pietrek", "Worg" },
                    { new Guid("b09e3406-dd10-4ff6-adf1-ba651a14e7a5"), "Randolph", "Beaglehole" },
                    { new Guid("b0bcd89e-c1a5-4178-a26d-71439538c3f4"), "Elyssa", "McAvinchey" },
                    { new Guid("b0c12556-4a63-4d58-8b36-c06a4bd04bb4"), "Amelita", "Adamthwaite" },
                    { new Guid("b0c354b9-70e3-4f31-a6f4-a3d1da30d4a7"), "Fabiano", "Junkin" },
                    { new Guid("b164b077-7332-44dc-a1ab-ada58c3bcb0c"), "Wakefield", "Krout" },
                    { new Guid("b1f1c10e-7853-47cd-9718-517038b33496"), "Lenka", "Burndred" },
                    { new Guid("b294c6c8-d7b7-424c-a33b-2be6ebc9f87a"), "Wallie", "Tripett" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("b2dd0d9b-02d7-4549-96cd-c0350e9f28a5"), "Jenny", "Mycroft" },
                    { new Guid("b30756ae-be0c-4f72-8e06-2d13237d55ca"), "Juditha", "Gallone" },
                    { new Guid("b332f0d9-946f-4d7d-b546-60bc208688d6"), "Karel", "Eastbury" },
                    { new Guid("b38cbbbe-6a26-4b6f-adde-28d0db595c87"), "Gerardo", "Rosso" },
                    { new Guid("b38d2732-a57c-43fa-b4a2-d0d2eda608ef"), "Mab", "Matthias" },
                    { new Guid("b39bc32c-dd43-4027-b289-dad680195b2e"), "Brennan", "Calfe" },
                    { new Guid("b39e93b0-2b2a-4aae-acf2-1dc9f5955151"), "Desdemona", "Rubica" },
                    { new Guid("b3d74b2b-99f2-4082-9d3d-e8ea53a6f7e6"), "Freddy", "Seville" },
                    { new Guid("b443a348-9799-4c2b-9f05-95869e08f40d"), "Kaspar", "Mark" },
                    { new Guid("b45fe7f9-7bbe-48f2-864e-520814d0628e"), "Jedidiah", "Dasent" },
                    { new Guid("b4b2e261-47f1-42fa-9571-439cb8214205"), "Holly", "Presley" },
                    { new Guid("b509ccd3-ed6a-43f0-9222-c6f06303c6b5"), "Gusti", "Leask" },
                    { new Guid("b5175300-5141-40a8-beb3-0e0cc8c6fd91"), "Arabelle", "Abba" },
                    { new Guid("b56a5ef6-7988-4e61-9944-beb232f4e3e2"), "Winston", "Rigmond" },
                    { new Guid("b5b0ae08-8e52-45ca-bf68-5a9ef7819577"), "Meaghan", "Kuban" },
                    { new Guid("b6492e83-2cc9-4841-828b-4e195b88325e"), "Rozele", "Swanbourne" },
                    { new Guid("b6512279-6547-4ed2-87fc-c77ab6abef87"), "Ania", "Rake" },
                    { new Guid("b67bf06c-e412-494e-88e9-e4744e067843"), "Maurice", "Castellucci" },
                    { new Guid("b692b225-621b-40b3-965a-91d9b4931ba7"), "Alyce", "Kahn" },
                    { new Guid("b6b28f2c-b552-4d7c-9e16-39404a01f374"), "Tammy", "Chastan" },
                    { new Guid("b6c36cb9-0939-417d-b2c9-2223332af34e"), "Genna", "Trustie" },
                    { new Guid("b72ed5a4-9f8e-476a-800f-003e445eb4fd"), "Jillene", "Quartly" },
                    { new Guid("b7757b09-09fa-40cf-8ba0-09231500e6ac"), "Bidget", "Franchi" },
                    { new Guid("b77e350a-0e9c-43cf-9cbd-b8b0d4ca029b"), "Demetra", "Conelly" },
                    { new Guid("b79722bb-068e-479f-bf3c-b214034a1e48"), "Melloney", "Yeandel" },
                    { new Guid("b7b4b1f0-135c-44c7-9eea-e7dc75c051bc"), "Denis", "Beining" },
                    { new Guid("b86e04b9-9004-4bee-b812-83971e671945"), "Agata", "Hastwall" },
                    { new Guid("b8a0c27d-d0d5-4daa-a960-5f1b595a55ca"), "Coriss", "Darmody" },
                    { new Guid("b8a88fec-cbca-408e-ae8f-46beccafa8f9"), "Sherwood", "Artz" },
                    { new Guid("b8c3d832-e24d-470d-8d87-e3ab5da9ee79"), "Kriste", "Aldcorn" },
                    { new Guid("b9095f71-97c5-4d8c-8f9b-69b11d459a38"), "Johann", "Shimwell" },
                    { new Guid("b927ec44-cac5-4e04-bf0b-ab8b6e63d0d8"), "Liana", "Vasilchenko" },
                    { new Guid("b961a7c6-29e1-4642-8802-dbbda19a809c"), "Bryn", "Lamswood" },
                    { new Guid("bb14916a-0ff3-42c5-a08f-e5dcf7653dc6"), "Amata", "Runsey" },
                    { new Guid("bb7396ad-9f1f-4e73-bd22-2a465dc1d957"), "Thorsten", "Patria" },
                    { new Guid("bb954696-fb7c-4349-a554-8c5f629aff19"), "Joelie", "Cornillot" },
                    { new Guid("bb96be95-e286-4bd8-b7d7-640bc350018f"), "Hadley", "Hyde" },
                    { new Guid("bbfb9626-f9f1-4837-8c72-fbbd4e5d49ad"), "Dorris", "Tyght" },
                    { new Guid("bc5c6376-48e7-4814-97c8-ccb63d2b47d6"), "Bobinette", "Copland" },
                    { new Guid("bc65bda2-f50a-4cd8-a1c4-ede9e5b53b99"), "Andros", "Heare" },
                    { new Guid("bcf9085b-d4e1-423b-9276-d89d520aeb82"), "Wendi", "Czaja" },
                    { new Guid("bd936aea-5632-4ec9-9bde-ce8eca0fb7e4"), "Haley", "Seger" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("bd9e488f-ec59-459b-98f8-cec2351d2982"), "Averill", "Turner" },
                    { new Guid("bdb31640-a03f-4d73-bcb8-ca9f07c27385"), "Pascale", "Gunning" },
                    { new Guid("bdbfb312-e3f0-43da-8f7f-9f4de500cb37"), "Opal", "McGilroy" },
                    { new Guid("bde49538-eadc-4a44-8565-cf835cb82819"), "Roldan", "Swett" },
                    { new Guid("be11a97e-53b4-4c38-8731-1a2ea714a27f"), "Emera", "Hutsby" },
                    { new Guid("be5902e9-595e-4743-8004-bb0e46b60b7a"), "Elyse", "Davidovic" },
                    { new Guid("bec5d41c-ddfa-43b3-9d5f-ee594db919a6"), "Jared", "Rossant" },
                    { new Guid("bedc959a-ea91-4220-8b7e-71dff6e099bc"), "Ki", "Burnes" },
                    { new Guid("bfc6616c-448f-4347-a108-3e2bc25e3b6c"), "Joni", "Doidge" },
                    { new Guid("c04bbafd-405b-4d69-85ce-3675e5d36372"), "Lisa", "Fenech" },
                    { new Guid("c061d7e5-4b72-41b4-8c19-8835f83a3e45"), "Lizabeth", "Shiels" },
                    { new Guid("c076d896-0ef2-4c15-9990-9617ca805457"), "Marris", "Manston" },
                    { new Guid("c08aec6f-289a-4bdc-aff2-a454cf2b0e97"), "Mel", "Bridat" },
                    { new Guid("c1046597-72fa-4425-bbe4-1bd54f39436e"), "Doris", "Grills" },
                    { new Guid("c1aa4f4b-b64d-448f-a23a-9b71528541b5"), "Orton", "Pavlata" },
                    { new Guid("c1c5bb1b-8d69-4598-b93c-a4bf48066d24"), "Amabelle", "Pawelski" },
                    { new Guid("c1e6f4e7-5bc8-4371-8064-5fb4223d8f44"), "Florida", "Coase" },
                    { new Guid("c1edd66b-8a9b-47e1-9e05-f38b31f6a079"), "Mac", "Silversmidt" },
                    { new Guid("c218b30b-d85b-4c81-b63e-42c0fa14107b"), "Olga", "Brookz" },
                    { new Guid("c30d297c-daed-48ef-a4f1-8950291e56ff"), "Guy", "Fulun" },
                    { new Guid("c3df19ea-6117-4897-8002-2a5290491803"), "Clementina", "Dendle" },
                    { new Guid("c3edc96c-896f-4475-a3c7-38fd3e4741a8"), "Lynne", "Donovin" },
                    { new Guid("c41f1dc4-f199-498a-b4a8-0786fb4fbc79"), "Jolyn", "Strain" },
                    { new Guid("c4dc1d58-a9be-4a62-96c4-ac463860f179"), "Kenyon", "Pavy" },
                    { new Guid("c4f3e616-6dde-4be6-a88b-e49a1b290833"), "Silvana", "Jeffcoate" },
                    { new Guid("c50a4572-f75c-4f89-8725-27d22731d2d7"), "Antonella", "Tindall" },
                    { new Guid("c52fbd37-2cb3-44ce-b647-757eb53a1573"), "Garold", "Postians" },
                    { new Guid("c5526c67-3078-4eca-98c6-5e1ae428d9f8"), "Edithe", "Wellstead" },
                    { new Guid("c555b899-cda9-4422-a2a6-2713973199bd"), "Wilmar", "Elcocks" },
                    { new Guid("c5698bf9-f96c-4df8-aa13-3df76a2cb879"), "Evan", "Mcwhinnie" },
                    { new Guid("c56f9194-091d-4166-ba46-b6d9cbfb608f"), "Jocko", "Monk" },
                    { new Guid("c623c617-f77b-4bdb-b49c-9caaa774480b"), "Lexis", "Lucius" },
                    { new Guid("c663e806-ddba-462a-a1c7-5b2a4c197de7"), "Carola", "Dawe" },
                    { new Guid("c691ae42-7764-47df-a354-1ed5df0230a3"), "Benn", "Starcks" },
                    { new Guid("c70ba4b6-6477-4542-a5e1-eacf1a011afd"), "Nanette", "Lafferty" },
                    { new Guid("c7739201-0190-4f2d-80d9-ddc77ccbb2ce"), "Ivor", "Ledger" },
                    { new Guid("c7a255f8-61a6-4738-bd62-225887638aa4"), "Aristotle", "MacNeilley" },
                    { new Guid("c7ce58f3-b2c6-4d5d-a91b-05c7e9ef5ae0"), "Gae", "Birdseye" },
                    { new Guid("c7df2366-2784-450c-b014-d58ed22de0a7"), "Maris", "Falla" },
                    { new Guid("c81f9470-e030-4c03-9473-11f887816e16"), "Jacinthe", "Harries" },
                    { new Guid("c82d6da0-3934-410a-ae20-cfb9dfbb0aec"), "Herman", "Hawley" },
                    { new Guid("c8461714-1444-44df-99ac-584134223147"), "Fonz", "Halloran" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("c95a0c28-04b3-416b-8315-533b24625c62"), "Ludvig", "Yankeev" },
                    { new Guid("c95a5b6e-2c40-41a5-b044-0351e979eb24"), "Price", "Stanway" },
                    { new Guid("c9894e9c-9b66-427c-92f0-30648a1e5810"), "Gabriello", "Greaser" },
                    { new Guid("c9cc59b9-915e-4c4b-8400-d7eac6f724f8"), "Brose", "Ridger" },
                    { new Guid("ca619031-f834-451a-bb11-b9af6c099ebb"), "Fin", "Neiland" },
                    { new Guid("caced371-71f9-4c30-bee7-c57932a9e55f"), "Janene", "Momery" },
                    { new Guid("cb081f39-a330-43f8-bf31-8fa8d4b23320"), "Ailey", "Gawthrop" },
                    { new Guid("cb2bbd63-0980-4ee8-beab-c0f7ab872383"), "Charin", "Winterbotham" },
                    { new Guid("cb68656a-1d75-47bb-a1fb-14a2ef54aa05"), "Gusta", "Threader" },
                    { new Guid("cbb1171f-85e2-439c-8518-73a89fc94ec8"), "Rudy", "Wix" },
                    { new Guid("cc9ec432-7cda-4aec-954a-c61e80b62f92"), "Leontyne", "Dwire" },
                    { new Guid("cdb9dfb7-70ab-4066-bf0a-a4efbccb1500"), "Myer", "Ilem" },
                    { new Guid("cdff4303-21bf-4d90-a886-6335de74f006"), "Shalom", "Drewery" },
                    { new Guid("ce0335a6-7aaa-4a48-8060-030b77484b3b"), "Tanner", "Camillo" },
                    { new Guid("ce32cece-a2aa-4783-85c9-4a9932d9a571"), "Seth", "Rudolfer" },
                    { new Guid("ce4c8ea0-afab-453a-8211-88636888940e"), "Mellisent", "Espinha" },
                    { new Guid("ce6cca0b-4a61-4dcb-8f0d-f6f0d36df456"), "Durante", "Semiraz" },
                    { new Guid("ce84a6d9-f560-45fb-ac5d-fe2d3b8f72ac"), "Noellyn", "Linthead" },
                    { new Guid("ceab4e73-213b-494e-b74c-4dc371eff1aa"), "Irvine", "Salvage" },
                    { new Guid("d013dfc1-9487-4ad2-8b83-63d752461ef8"), "Tabbie", "Sandhill" },
                    { new Guid("d08834f2-8e18-444f-a680-32c89b201ba3"), "Bealle", "Sellor" },
                    { new Guid("d098e30a-0cd8-45fa-b30b-d2b5d6cc028c"), "Charlena", "Futty" },
                    { new Guid("d1366bc9-d394-4617-a7da-855969af4d93"), "Barbette", "Gay" },
                    { new Guid("d1c444b8-aab3-4966-bebd-e8f98c51eb26"), "Arda", "Stoacley" },
                    { new Guid("d1cc6af7-d846-479e-8b2d-afc96327c3f7"), "Conrado", "Dumphries" },
                    { new Guid("d1fc24de-dca0-46dc-b6e6-f93704434293"), "Ameline", "Heckner" },
                    { new Guid("d202b471-780e-48f2-951d-5eff11f6c5c4"), "Arney", "Pavitt" },
                    { new Guid("d22a10fa-799e-4002-8f44-114d84f49a1f"), "Eolanda", "Purse" },
                    { new Guid("d3b1c94b-b992-4ed7-b559-8e94f675137d"), "Koressa", "Burree" },
                    { new Guid("d411c9c1-4b5f-47c1-b9bb-1adbfdb4966d"), "Gradey", "Dominichetti" },
                    { new Guid("d44986d3-cdf8-43bb-8e86-a74826170ec5"), "Tad", "Volk" },
                    { new Guid("d48b87a8-75e5-4161-8f28-5cae1dfa0c22"), "Alric", "Henzer" },
                    { new Guid("d4bded3a-e447-420d-9769-0bd2a7f1f583"), "Schuyler", "Davern" },
                    { new Guid("d4d2e293-5511-4e22-9df3-b688af486135"), "Merrill", "MacAllester" },
                    { new Guid("d518d01c-9858-447d-858a-9d69fd9c45a4"), "Theresina", "Dohmer" },
                    { new Guid("d5c90918-40ef-414e-9aad-d424a395b95b"), "Craggie", "Bowman" },
                    { new Guid("d5ca6334-a710-4952-9344-a3592a88d221"), "Anderson", "Braiden" },
                    { new Guid("d62abc74-1046-407b-b009-84458788871a"), "Olin", "Rillstone" },
                    { new Guid("d632f5b1-a7a1-4d4a-8dd5-40f20cafaede"), "Brnaba", "Camsey" },
                    { new Guid("d63bbf5d-554d-4a1a-a33f-6b249925f6a8"), "Rhianon", "Celes" },
                    { new Guid("d685d683-feb2-41ef-a3de-36399b342371"), "Belia", "Baglan" },
                    { new Guid("d6f4586d-0a34-4775-bc5f-c5a4c5d29e9b"), "Kellina", "Cawsby" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("d7f6c836-8b85-4391-93a4-d3a9e7ac2888"), "Lenore", "Clace" },
                    { new Guid("d8e0d053-6f19-4a44-9028-4353a001d71a"), "Kora", "Klarzynski" },
                    { new Guid("d8e9849e-557f-4593-b9e5-d4e6b0198199"), "Mattie", "Dible" },
                    { new Guid("d9165e31-be69-48aa-82e5-23c8b75e6949"), "Pia", "Rewan" },
                    { new Guid("d985943d-8277-460d-8c71-708f9093fb3f"), "Sandro", "Bungey" },
                    { new Guid("da54428c-88c4-4f90-9406-476c66a66dde"), "Kaspar", "Skyme" },
                    { new Guid("da5c2227-bcee-4e5c-921b-89e0a4c20615"), "Olympe", "Baise" },
                    { new Guid("da68975d-212e-451c-b657-5bdafeb21a46"), "Trude", "Perrott" },
                    { new Guid("db1d1a4b-eb62-4326-8a80-4c89565eaa8c"), "Mollie", "Fountain" },
                    { new Guid("dbb45e0d-e5fc-462e-b783-62a2c2dc8d87"), "Kiri", "Lammerding" },
                    { new Guid("dbe83457-7531-455f-b744-3d3a84708905"), "Sarajane", "Trundler" },
                    { new Guid("dc0553d6-4402-4148-81c5-2d0d228c3902"), "Cecilla", "Trayte" },
                    { new Guid("dc08d55d-bfc3-458b-8ad7-3bd5e9e9d7da"), "Kathlin", "Corselles" },
                    { new Guid("dc355786-5053-47f3-a4f3-1f485701f484"), "Myrtie", "Caller" },
                    { new Guid("dc7642e1-db94-4d35-b5e3-84706d0884af"), "Siffre", "Phelipeaux" },
                    { new Guid("dcda500f-6c1a-4a52-ab83-38a6c437f55c"), "Bar", "Falk" },
                    { new Guid("dd0d613b-d3d8-4bd4-b2c0-35cc5aeb3309"), "Hadleigh", "Kissack" },
                    { new Guid("de4b219a-bdb4-4477-9deb-9586b48c1045"), "Eldredge", "Grisbrook" },
                    { new Guid("de50ff19-01f2-49f1-9ea5-2e779b0486ac"), "Abie", "Hubbucks" },
                    { new Guid("debcaea6-d40d-4fe7-9d7c-9bf0aeded429"), "Rab", "Standen" },
                    { new Guid("dec7cdcf-a00a-4776-9bff-b7e63fe38b2f"), "Renato", "Lowey" },
                    { new Guid("df3a8976-6ee1-4af4-88b3-4592271df72e"), "Clare", "Allner" },
                    { new Guid("df56863e-741c-4633-b28b-5b9246e1857f"), "Sher", "Salvidge" },
                    { new Guid("df8d9830-ffbb-422e-b69c-6c3014088345"), "Ludovico", "Coleiro" },
                    { new Guid("dfd42b4c-7722-41b8-96f3-fece9dedf0e9"), "Gayler", "Blaker" },
                    { new Guid("dfde4eb9-101f-4eed-a857-1ac43ff5be27"), "Viv", "Bank" },
                    { new Guid("dfefe5e8-a2e4-4e86-aead-0a32f2f118fc"), "Fay", "Calcut" },
                    { new Guid("dff52e48-ba03-46a1-a2a4-e346fdb52b1c"), "Oberon", "Salvadori" },
                    { new Guid("e107a237-8154-4ef5-9557-843e1f486af6"), "Latrina", "Memory" },
                    { new Guid("e1402f0a-6f80-4867-9fbe-1672924d80ee"), "Philippine", "Vynall" },
                    { new Guid("e20ec806-ab19-45e5-a878-919cce82288f"), "Wayland", "Dorbin" },
                    { new Guid("e23c6d4a-94aa-4bda-8a09-4f3a00c1d2a8"), "Joann", "Grayshon" },
                    { new Guid("e2647342-e8fd-4f39-98e6-7a01b82683e6"), "Elizabet", "Dinsey" },
                    { new Guid("e28f015d-7c7c-4811-9f57-bedbbccc1cbd"), "Avie", "Mangon" },
                    { new Guid("e3254490-0e4e-4b4c-b6ef-4616256790a4"), "Skell", "Jaffray" },
                    { new Guid("e32e909d-9766-4659-8656-be448c2ce8df"), "Les", "Gipp" },
                    { new Guid("e369fca0-2e05-447b-b86f-c322c81af86f"), "Augusto", "Scogin" },
                    { new Guid("e3e89c5e-d1e3-4e08-9e9f-2e3d6498196a"), "Val", "Schrader" },
                    { new Guid("e3edb88d-789e-4c88-87b1-0c9f6f0284db"), "Zaccaria", "Gryglewski" },
                    { new Guid("e3f10016-7502-4a71-bdc0-9c22cf6a5bd8"), "Merwyn", "Whaites" },
                    { new Guid("e4b031df-f012-4bab-884f-df14decc7f16"), "Ardelia", "Hoston" },
                    { new Guid("e50d82e5-c38c-49fe-aef4-4f54d0e75951"), "Ram", "Churms" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("e52bd501-3258-4414-a396-b891f047dac9"), "Clare", "Littlejohns" },
                    { new Guid("e53a96e4-5c39-4739-94b2-cabdced13469"), "Weber", "Charette" },
                    { new Guid("e5928360-c189-4a52-b461-ebe0ec2507d5"), "Malvin", "Henrie" },
                    { new Guid("e5b35dcb-548d-45d2-93ba-41128094afab"), "Beulah", "Bartlam" },
                    { new Guid("e5c5d7d3-25cf-4f74-a202-75ac70a95a42"), "Jacky", "Gainfort" },
                    { new Guid("e61caebe-1e1d-444e-9273-3d6cc9b00293"), "Viviene", "Adhams" },
                    { new Guid("e625ce4e-cec8-433c-bb00-38923eab6db5"), "Susy", "Taile" },
                    { new Guid("e69428c6-d43f-4e1f-bb3a-b95aaa0642ea"), "Mirelle", "Sinnat" },
                    { new Guid("e6d2c155-9c3c-463c-98f3-0f7699e65c49"), "Leoine", "Royce" },
                    { new Guid("e6f25aa2-1e44-4a96-84af-8c2840980f8b"), "Theresa", "McNeachtain" },
                    { new Guid("e80fd575-c9eb-408d-8f1d-cb9d434c7ea6"), "Mason", "Carn" },
                    { new Guid("e8359f44-1a23-43a4-924a-8cf59a84a3a1"), "Emilee", "Thonason" },
                    { new Guid("e8788c82-352f-46d1-ad4a-b793fb8fdd83"), "Zsazsa", "Dubery" },
                    { new Guid("e8e1e594-ab50-4f08-9a3b-50e404969608"), "Ashil", "Ellings" },
                    { new Guid("e900592c-8ffa-4c84-90b4-ae353b292558"), "Giacomo", "Harrop" },
                    { new Guid("e940cd56-6009-4fff-a9fa-2aa0c1d1df4d"), "Andrea", "Simon" },
                    { new Guid("e9773d5e-d00e-4a3e-854c-6ced5a41ca60"), "Tate", "Carcass" },
                    { new Guid("e9829cd2-b11e-4e81-8920-df37bec75c68"), "Riva", "Fasler" },
                    { new Guid("e9ec1912-5d14-4338-a6eb-68a554e18720"), "Shandee", "Raffels" },
                    { new Guid("ea0c9879-b19b-4e47-8879-1b1ac5b9536b"), "Bondie", "Aylin" },
                    { new Guid("ea2797dd-7097-4cd1-8ff5-ee735807634e"), "Eldridge", "Treagus" },
                    { new Guid("ea6064fb-bd57-435f-a88d-f9b36ecdc366"), "Misty", "Leebetter" },
                    { new Guid("ea899a8e-0e39-4b1f-9e0b-6eb5934aca53"), "Chery", "Hartin" },
                    { new Guid("eadec3b1-2ad4-4b78-86a8-d56dd9247e64"), "Dacey", "Frensche" },
                    { new Guid("eb024ae4-629f-4f49-a420-27c6e5c354ed"), "Haslett", "Mylechreest" },
                    { new Guid("eb5c449a-303e-4f73-a386-cd79ea2e5d88"), "Cristi", "Lammers" },
                    { new Guid("eb7e4fca-a451-4452-a2dd-7b83e372311a"), "Saree", "Scardafield" },
                    { new Guid("eba42403-dce5-470b-a1da-63687b6ed5f6"), "Vinny", "Caudell" },
                    { new Guid("ebaa6cfc-6263-43c8-98a3-ffde8195c21d"), "Berti", "Cerith" },
                    { new Guid("ebc99ac8-f30f-4b67-b09a-0a5af6bf6dc7"), "Lucina", "Airth" },
                    { new Guid("ec266772-d14c-4450-a84f-4425483a41f4"), "Trix", "Muffin" },
                    { new Guid("ec431d1f-308a-49a9-88ef-4f97349a9a6a"), "Neal", "Gaffer" },
                    { new Guid("ec4aa741-496b-4a52-822f-1099d218f328"), "Filmer", "Dodd" },
                    { new Guid("ec7c2556-312d-4658-ab4a-cba11638f75d"), "Olenolin", "Leverson" },
                    { new Guid("ec8e4ccd-bd7a-4690-827c-f75973e8d465"), "Lorettalorna", "Wakeham" },
                    { new Guid("ecdd311d-8fde-46b4-82c2-3505281d8c33"), "Gillian", "Cino" },
                    { new Guid("ed3a8060-b3db-4a19-8c33-20be4acb9208"), "Sybyl", "Audry" },
                    { new Guid("ed535116-8f89-4908-a7eb-ccd855dfa020"), "Locke", "Labitt" },
                    { new Guid("ed700c11-0c4a-4e26-b52e-fa295301c2d3"), "Gauthier", "Geare" },
                    { new Guid("ed8fcd57-ffda-47db-8107-65c730b642f3"), "Woody", "Leyninye" },
                    { new Guid("edc1ba6b-4403-46f5-bc5d-1ee8ec9a353a"), "Annamaria", "Neno" },
                    { new Guid("ede20578-f3bb-4b60-aec8-208e6470772d"), "Chad", "Howsam" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("ee1423ed-70c0-4621-bb0c-e01c043a7197"), "Elyssa", "Yarranton" },
                    { new Guid("ee4227c5-ee55-4a41-b8e2-f68c4ff24908"), "Ashbey", "Burchatt" },
                    { new Guid("ee7ac866-ac0a-4e21-8a39-f9819fb2f33d"), "Kit", "Ollett" },
                    { new Guid("ee8e3c8c-a3df-430b-8e07-98267892abe7"), "Amery", "Gowanson" },
                    { new Guid("ee8f5d1f-564b-4c7f-afa7-9cd722d21fe9"), "Bethany", "McIver" },
                    { new Guid("eefaccd4-7127-4085-88bc-6a27306b7ab8"), "Reynolds", "Dunkley" },
                    { new Guid("eefb6f8b-75e3-4bb3-80f2-97bfbe76c4aa"), "Yorgos", "Thurgood" },
                    { new Guid("ef76794a-1c1b-4b5f-aea6-66120cdd4c87"), "Adara", "Forrestor" },
                    { new Guid("ef7b31d4-5bd2-4689-abe2-6073c1f11a90"), "Cory", "Bracken" },
                    { new Guid("ef8cbeb8-2b81-4c0b-a651-8b5e485b29ed"), "Joe", "Alessandone" },
                    { new Guid("efaea93d-8add-41e5-8601-8521541c9b1f"), "Bobbi", "Vassar" },
                    { new Guid("effd3f5a-67b3-40c0-8126-bd22a3012ef4"), "Rickey", "Gobell" },
                    { new Guid("f0598ad7-cab3-4ed1-a011-d813a8e38769"), "Ericka", "Stave" },
                    { new Guid("f0c7c138-352f-4efe-953f-87acb4782acf"), "Elizabet", "Proschke" },
                    { new Guid("f16a91ae-51db-4475-910e-c03a1d35d225"), "Goldina", "Christoffersen" },
                    { new Guid("f1e93272-da66-4117-b84f-21a4c154ee71"), "Bo", "MacNally" },
                    { new Guid("f219697e-0a19-466d-9afe-1bc6802dbb6a"), "Virgina", "Cota" },
                    { new Guid("f22a03fb-97ad-45d2-9e53-a6f7da00cc13"), "Corty", "Bugby" },
                    { new Guid("f23e51a1-c7bc-48c0-ac59-1160a4ef636a"), "Eveleen", "Costanza" },
                    { new Guid("f27a9091-2656-4dab-bea3-4053184a42d3"), "Bunnie", "Monnelly" },
                    { new Guid("f344d0a6-bd6e-41d2-8e8e-4ee6626cd34b"), "Corrie", "Butterley" },
                    { new Guid("f395f87d-59a7-4559-b33e-ffd6db9dc3b5"), "Chiquia", "Ecob" },
                    { new Guid("f3a2d422-e9ce-4bda-93b1-6c6c05d9bb1e"), "Renard", "Easby" },
                    { new Guid("f3a7d97c-16be-4402-8c8a-978a85d6b254"), "Gerard", "Kelso" },
                    { new Guid("f3b7ee80-0c64-4e01-a409-ef6a88cc9cfb"), "Joan", "Sheekey" },
                    { new Guid("f3bf4c79-af62-4b46-9113-eda5243d5701"), "Frazer", "Matthew" },
                    { new Guid("f3c84ba8-01c8-4fd2-a47c-0f213462fa28"), "Niccolo", "Leftridge" },
                    { new Guid("f3cc37bd-f9a5-49c3-88bf-ec360a245f6f"), "Amerigo", "Denkin" },
                    { new Guid("f48e6883-2966-4822-8433-b18d619808ea"), "Elli", "Southward" },
                    { new Guid("f4d81451-d91b-488e-b971-c7a88411d61b"), "Kort", "Darington" },
                    { new Guid("f4e8c5d0-6100-4be5-9750-9f23679b9c1d"), "Sonia", "Chinnock" },
                    { new Guid("f4f7b50b-338f-4dba-9b86-69291c154f66"), "Lay", "Hynam" },
                    { new Guid("f5010ba3-bb59-464d-8e72-ee74f7b08868"), "Arny", "Chazelle" },
                    { new Guid("f56d177d-ecbb-4c89-a471-1fe563e170ee"), "Pren", "Mossman" },
                    { new Guid("f5e7a255-e954-42cd-a2b4-6cd8508bb20e"), "Ram", "Wooster" },
                    { new Guid("f6e096c7-976b-4659-8b1b-19e99fce4cea"), "Gardy", "Shackell" },
                    { new Guid("f6e1ed45-6cd2-41f2-985d-8c144810f820"), "Diena", "Dockray" },
                    { new Guid("f7136f79-d7ca-4cc7-b807-06c874736a5e"), "Richie", "Luetchford" },
                    { new Guid("f7781d83-6905-4865-aac2-ba841334fe0c"), "Rayna", "Crowcher" },
                    { new Guid("f7986027-cfa1-4c10-8f34-bf95cb5b812c"), "Bonnie", "Goldbourn" },
                    { new Guid("f7adf1dc-1cdc-4bc9-bc5e-cc5f3caaa2dc"), "Brien", "Pow" },
                    { new Guid("f7fffbc2-345e-4c2e-a748-ffba11a2d367"), "May", "Sowley" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("f80135ad-8130-4f9c-b9b1-f32613c74b43"), "Inessa", "Milsap" },
                    { new Guid("f809364e-a8b1-4540-8b15-f870cd80026b"), "Eldon", "Love" },
                    { new Guid("f81a29bc-1557-4b3e-948e-bd604a683e1f"), "Stacie", "Tollit" },
                    { new Guid("f845aa53-c634-4a31-a8f9-d71b14fbeffe"), "Boris", "Ure" },
                    { new Guid("f87ea182-306a-448f-803f-d3c91f5a6dca"), "Skye", "Claire" },
                    { new Guid("f8bb7e04-e493-45b0-b323-4db8818a4473"), "Adaline", "Otham" },
                    { new Guid("f8e2e376-bf17-435d-925c-69570dc1311b"), "Cyrill", "Speer" },
                    { new Guid("f9306978-8fc1-47dc-ba7b-b2aed6f94a67"), "Forester", "Shinton" },
                    { new Guid("f95d7010-b4a9-4323-ae24-6ae08f6c8973"), "Amory", "Pressland" },
                    { new Guid("f9f5f912-3053-4fd6-af8b-82aab72026b8"), "Terrijo", "Brugden" },
                    { new Guid("f9fba363-d267-4248-955f-f9bc632d6737"), "Isiahi", "Colaco" },
                    { new Guid("fa9a2f64-0908-49c8-8afe-d2fc45a83df4"), "Gwenore", "Malinson" },
                    { new Guid("fabd77ff-2ad4-4544-b230-3d126e61d213"), "Eadmund", "Ayre" },
                    { new Guid("faecf514-a004-4871-a454-2495cb150348"), "Alister", "Kalberer" },
                    { new Guid("fb315e98-151b-4164-9e0a-fea62de9253b"), "Ferrell", "Capron" },
                    { new Guid("fba0c2f7-a70d-4d0e-b8f9-cab54c5e4752"), "Inez", "Leipelt" },
                    { new Guid("fbbffb5e-56cf-44cd-815a-d1a00a0eafa9"), "Odie", "Dowda" },
                    { new Guid("fbd14cbb-a961-4de7-b7e3-c40c2cf65528"), "Mayor", "Ivons" },
                    { new Guid("fbfecfaa-f915-4006-ae69-6960f7bd5a0f"), "Veda", "Yurshev" },
                    { new Guid("fc5d433e-16f2-49e8-96fc-46d1ebdacd59"), "Ellyn", "Quiddington" },
                    { new Guid("fcab4449-d994-4b52-b97a-d2e5ac311fc3"), "Coop", "Kemery" },
                    { new Guid("fcb3c996-c794-454a-9a16-4a2565f65288"), "Hermie", "Lodford" },
                    { new Guid("fcb9f33c-06d2-4c1a-8673-5d6f62342a4b"), "Elayne", "Zanetello" },
                    { new Guid("fd773f34-1f6b-4b48-994f-400d3850459f"), "Aldous", "Sine" },
                    { new Guid("fd9f2dda-7909-465c-b6f9-b93316a50bd9"), "Grace", "Dunlop" },
                    { new Guid("fe5b31a6-ab2d-41e0-94e8-b39659490107"), "Shaine", "Instrell" },
                    { new Guid("fe5d6a86-54ea-4fd8-826e-4b95cb093b4d"), "Haleigh", "Clacey" },
                    { new Guid("fe69727f-3a9c-45b6-98ff-40e2fcabf918"), "Callie", "Eicheler" },
                    { new Guid("fe7c3a03-2532-4d05-b18c-cfcc0138ef77"), "Dalila", "Coot" },
                    { new Guid("ff1a42cd-0526-42cc-9308-15f2d60709c3"), "Nanci", "Kindell" },
                    { new Guid("ff54134d-ee85-4c4f-b8f6-60d704d65ecf"), "Selene", "Lambrecht" },
                    { new Guid("ff5f61e3-2bf2-4fa9-b9c4-a3af97670bfb"), "Janie", "Battson" },
                    { new Guid("ff733029-b575-43d4-b993-ffc9e0cf1feb"), "Dennis", "Squirrel" },
                    { new Guid("ffcdf6aa-9382-4a22-a21e-3b65a984e28f"), "Harley", "Crier" },
                    { new Guid("fff80cde-6282-46a9-b2ad-9f92d546c8d3"), "Rozele", "Scimoni" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("005d39dc-c7f9-4fdd-abb9-2c6ae12874c6"), new Guid("dc355786-5053-47f3-a4f3-1f485701f484"), 0, "310561398-6", 95m, 1987, "Civil Brand", 10 },
                    { new Guid("005f19a3-fb37-4680-bcd5-e3dba13a9aab"), new Guid("7859aa81-14a9-4735-b1f8-f00960d3b342"), 1, "961943999-6", 46m, 2000, "Triad Election (Election 2) (Hak se wui yi wo wai kwai)", 13 },
                    { new Guid("006b7334-164c-47c8-ba44-6b60ecf6192f"), new Guid("12eaf5da-5225-450b-8e2c-aa2c07209f8f"), 0, "844489349-8", 71m, 2009, "Split. The", 9 },
                    { new Guid("008f49eb-7d4d-4d74-9250-b4290d519718"), new Guid("bb954696-fb7c-4349-a554-8c5f629aff19"), 0, "210790921-0", 46m, 1995, "True Stories", 0 },
                    { new Guid("00dd680e-95a4-4e59-bbc7-b989c0852a23"), new Guid("bb14916a-0ff3-42c5-a08f-e5dcf7653dc6"), 0, "920317706-X", 61m, 1993, "Big Broadcast of 1938. The", 2 },
                    { new Guid("00e066b7-10e7-46e0-8539-aacdb35d412f"), new Guid("031938d9-385e-4e78-bddc-ee7720f60ec2"), 0, "058951307-9", 50m, 2011, "Intruders", 7 },
                    { new Guid("00e7f6bc-f8a8-4bfb-ad68-6848c87c971a"), new Guid("1af6bab8-73c9-4ee7-b2bd-5a24daa9ffa2"), 0, "009679026-1", 6m, 2005, "Night Walker. The", 12 },
                    { new Guid("0133f5b4-af09-4af6-8fde-093335e2a027"), new Guid("14c27e44-1b6b-4a1d-95fc-7334b67264f7"), 0, "564040002-1", 36m, 1992, "Gozu (Gokudô kyôfu dai-gekijô: Gozu)", 11 },
                    { new Guid("01da40bc-8c4a-4036-a1af-7643f3ce3057"), new Guid("746ae46b-0158-4ccb-ae3a-4e5a0f76a1c4"), 0, "646333451-0", 72m, 1993, "Julian Po", 5 },
                    { new Guid("01e4aee4-6126-45a5-9135-5c3db3af386b"), new Guid("587c4769-f9f4-4071-a4aa-5657ff07f98d"), 1, "207694536-9", 77m, 2011, "Brooklyn Dodgers: The Ghosts of Flatbush", 12 },
                    { new Guid("0229e1ed-54bc-4d08-9932-c835af5a3bb3"), new Guid("b961a7c6-29e1-4642-8802-dbbda19a809c"), 0, "890363647-3", 74m, 2006, "Breaker! Breaker!", 14 },
                    { new Guid("022b9ae9-64c3-4b82-9ae0-6a6bb5e2cd12"), new Guid("e52bd501-3258-4414-a396-b891f047dac9"), 1, "712836921-X", 31m, 1997, "Soapdish", 3 },
                    { new Guid("02453b3e-1d51-4f41-b6df-7a678da90bfe"), new Guid("62cb760c-f45e-4b29-8937-cb84398e32a7"), 0, "187933870-X", 67m, 2007, "Friendly Persuasion", 5 },
                    { new Guid("02936ebc-4df7-4271-9478-fbbdcd537f9f"), new Guid("4faa4f23-0f75-441f-8048-d9f0338101c0"), 0, "846985187-X", 16m, 2002, "San Quentin", 8 },
                    { new Guid("0294c444-6b39-42f4-90eb-029dbcfd45b0"), new Guid("3d3119d2-49b5-4360-93f8-a48b28e1bae2"), 1, "725145919-1", 79m, 2011, "The Fat Spy", 2 },
                    { new Guid("043fb5d8-b194-4c3c-ac89-0648f718cf0f"), new Guid("acd774db-b92d-4b71-a6a9-462262f6bd94"), 0, "304070415-X", 41m, 2002, "Alan Smithee Film: Burn Hollywood Burn. An", 8 },
                    { new Guid("04456375-4711-41b5-96ad-f4f92b4f174e"), new Guid("5eba6825-745d-4bf9-ae68-5216f0e7d617"), 1, "287178539-2", 2m, 1992, "Judy Moody and the Not Bummer Summer", 14 },
                    { new Guid("045956ae-06b6-4e77-9a6d-ac3ffe1caebb"), new Guid("3db30207-0111-4b34-8697-15e686b8ab44"), 0, "928596173-8", 8m, 2012, "Pennies from Heaven", 10 },
                    { new Guid("04ad5574-7b1c-41c3-8b78-f3ed04f2d8a6"), new Guid("b164b077-7332-44dc-a1ab-ada58c3bcb0c"), 0, "824484942-8", 78m, 2000, "Hierro ", 6 },
                    { new Guid("04cb2b5d-e4d0-4c16-a943-4af86ccbee9c"), new Guid("7de4bc97-05f9-48e2-a848-f1971a19706a"), 1, "482138427-2", 65m, 1995, "Chocolate Strawberry Vanilla", 1 },
                    { new Guid("04ee5d9d-f5f2-4a81-99f4-692d4ff7df30"), new Guid("5380659f-2ce3-4bfe-a1db-003100941591"), 0, "686260007-9", 46m, 1987, "Boy. Did I Get a Wrong Number!", 3 },
                    { new Guid("0587cabf-f146-4761-b62c-31be16b7cc3e"), new Guid("ed8fcd57-ffda-47db-8107-65c730b642f3"), 0, "880087575-0", 64m, 2006, "Little Dieter Needs to Fly", 10 },
                    { new Guid("05a54480-ebfc-4c6f-85ba-0f3f5dd26dd8"), new Guid("093dfc93-5266-4d68-bf48-163fde59163b"), 0, "074607339-9", 44m, 2010, "Alex and Emma", 9 },
                    { new Guid("05b77698-54d6-4eab-83b6-db58a4f810cd"), new Guid("fcb9f33c-06d2-4c1a-8673-5d6f62342a4b"), 0, "326943794-3", 4m, 1996, "Motorcycle Diaries. The (Diarios de motocicleta)", 13 },
                    { new Guid("05bd86ce-fb08-4318-8349-c8b101f85ea8"), new Guid("a7a7194e-dc36-496c-81c4-cd1a4ab2c12f"), 1, "838530500-9", 81m, 1998, "By the Light of the Silvery Moon", 10 },
                    { new Guid("05cd042b-5a2f-40dc-8cea-211857dd10a5"), new Guid("0fd926b9-6943-41db-ac79-0973843f33bf"), 1, "856637173-9", 23m, 1989, "All About Lola (Ce que je sais de Lola) (Lo que sé de Lola)", 12 },
                    { new Guid("06016b2f-bbdd-4629-b988-c61608b70a61"), new Guid("9c9eb9df-a946-4a61-8ea7-51c5520c10ad"), 0, "766791762-0", 15m, 2008, "Plaisir. Le", 6 },
                    { new Guid("062a6998-b339-4e57-baa8-fb4446ab6daa"), new Guid("51e6b040-8c0e-4b6c-b643-a08fb84cafdf"), 1, "995334185-0", 35m, 2006, "Secret Life of Walter Mitty. The", 4 },
                    { new Guid("06681220-7877-4329-81ea-2c8afb24c371"), new Guid("069bf751-30ca-4d11-b39d-6c60d55ee78d"), 0, "810730733-X", 91m, 2001, "Peacekeeper. The", 5 },
                    { new Guid("0681684c-3688-405c-9e8c-9fddd5a1e26c"), new Guid("2dc83419-8e8e-4dc1-acef-20ecc8af7807"), 1, "946091249-4", 90m, 2010, "P2", 9 },
                    { new Guid("0682d919-a7ab-4401-9106-ed27765e0db6"), new Guid("b0c354b9-70e3-4f31-a6f4-a3d1da30d4a7"), 0, "076861368-X", 95m, 2006, "Rembrandt's J'accuse", 13 },
                    { new Guid("06b35d72-2fc9-4d4d-8765-03e15d8a2294"), new Guid("aafbe801-5353-4a9c-88b9-6844e8211e62"), 1, "640446628-7", 23m, 2006, "Tank Girl", 2 },
                    { new Guid("06c196ca-4a1a-4d10-ab76-3e94433e4058"), new Guid("6b751a89-1e62-43ca-b754-2a4123355c9f"), 1, "712173187-8", 19m, 1995, "Outlaw. The (Lope)", 6 },
                    { new Guid("06f0e7b9-4d0f-43c9-9bec-c88c93a77abb"), new Guid("2e358a53-53f0-42ae-b5fb-1efcc26a831f"), 1, "853662662-3", 52m, 2012, "Rocker", 13 },
                    { new Guid("07120b63-921e-43a9-b67b-cfc45d08355b"), new Guid("e61caebe-1e1d-444e-9273-3d6cc9b00293"), 0, "867677030-1", 65m, 1994, "Rude Boy", 2 },
                    { new Guid("07197013-60ba-4006-8b72-e0cf0eb26712"), new Guid("6f8c9362-a796-4179-9707-638ee0ea0ec1"), 1, "794489779-3", 83m, 1999, "No Man's Land", 14 },
                    { new Guid("073568ea-0832-4f95-af6f-cb6d594619b7"), new Guid("ad533211-4ff4-4ce9-828d-082346666f62"), 0, "623896680-7", 3m, 2012, "Olivier. Olivier", 1 },
                    { new Guid("07bdaeec-3a2f-4ac9-a8d3-458f10a9aab8"), new Guid("62cb760c-f45e-4b29-8937-cb84398e32a7"), 0, "434881680-8", 37m, 1994, "Saving Shiloh", 6 },
                    { new Guid("07d03a25-1aae-4284-a166-06d8ee6bd358"), new Guid("a2f76f52-8aa5-4ce4-b11b-138586c1af09"), 0, "798966015-6", 80m, 2009, "Airport", 13 },
                    { new Guid("08199b71-e045-4e06-ac09-12568cf1c4e6"), new Guid("49964dad-e5c5-46d7-8baf-7d75dd8676df"), 1, "340593404-4", 26m, 2009, "Ernest Goes to Camp", 7 },
                    { new Guid("087c206f-d31c-4852-85a5-af7172b5ad3d"), new Guid("aebf2bd6-1904-43fd-9b2f-c06fdc04f541"), 0, "103702430-3", 75m, 1980, "All About the Feathers (Por Las Plumas)", 7 },
                    { new Guid("09176063-7f52-4ce3-945d-b5309218c95a"), new Guid("43ba9cdb-cd9f-4186-949d-7e826615e6cf"), 1, "248108676-7", 41m, 2008, "Ultimate Warrior. The", 6 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("091fb77a-26d8-4bdf-84e1-8f6f1a6ea162"), new Guid("852d7462-b700-4af6-b686-bf1e001de35b"), 1, "244009010-7", 83m, 1993, "Poison Ivy", 7 },
                    { new Guid("093dc345-56ed-4b48-a8bb-5753cc6fdd9e"), new Guid("b79722bb-068e-479f-bf3c-b214034a1e48"), 0, "109938075-8", 13m, 1995, "Tis kakomoiras", 10 },
                    { new Guid("09830c99-8900-486b-86c6-dd0153489340"), new Guid("c3df19ea-6117-4897-8002-2a5290491803"), 1, "616984752-2", 90m, 2007, "Cherish", 10 },
                    { new Guid("0a1fba26-7176-4593-a320-3fd48765d7f7"), new Guid("55d8b245-4396-4afb-811a-166e6dc1eccd"), 1, "226399438-6", 77m, 2009, "Berserk: The Golden Age Arc 2 - The Battle for Doldrey", 8 },
                    { new Guid("0ad77d8d-456a-49a9-8cca-2f2c5973eee0"), new Guid("25758eb3-93ba-486c-adc6-5695cb1c1873"), 0, "201244386-9", 92m, 2013, "Cutting Edge: The Magic of Movie Editing. The", 12 },
                    { new Guid("0afd8264-82b5-4c1d-9eb1-54d7c7100329"), new Guid("2af7736a-a2ec-40a6-95b1-522d6da0c69e"), 1, "051248571-2", 53m, 2012, "Alone in the Dark II", 3 },
                    { new Guid("0b534599-a0dc-4ce2-82fd-f4aac0e6cb06"), new Guid("0b933755-3929-4970-9e65-924c1ad9d427"), 0, "156499078-8", 3m, 1994, "Beach Blanket Bingo", 10 },
                    { new Guid("0b9b70b6-4d46-4d03-a8c2-f5db494f698a"), new Guid("3868539d-b516-43d0-8b14-5153d2b034bb"), 1, "240213919-6", 53m, 2006, "My Way Home (Így jöttem) ", 4 },
                    { new Guid("0bc7793e-c405-4309-8ea6-c986cb2c0895"), new Guid("b294c6c8-d7b7-424c-a33b-2be6ebc9f87a"), 1, "621147774-0", 54m, 2007, "Just Friends", 5 },
                    { new Guid("0c08b845-ae0c-40cb-a83a-b90138d328eb"), new Guid("90b53bcd-c664-4424-870e-f26a379f38fc"), 0, "607464106-4", 27m, 1957, "Over Your Cities Grass Will Grow", 5 },
                    { new Guid("0c2471a0-5cae-4ec6-bc5d-2612fd7c7d90"), new Guid("157466fa-afb7-4076-ad21-530717018e26"), 0, "980379487-6", 81m, 2000, "Passionate Friends. The (a.k.a. One Woman's Story)", 0 },
                    { new Guid("0c536162-10ce-48b7-9058-24dc070ead93"), new Guid("0d5ffc92-f835-466a-b57b-bb5539613e8b"), 0, "055890471-8", 29m, 2000, "Dynamite Girl (Dynamiittityttö)", 10 },
                    { new Guid("0c90e866-2409-488d-bfcb-33f2db891f22"), new Guid("1abaaf66-3244-437d-ab52-41f4ce76d36e"), 0, "782751201-1", 73m, 1999, "U-571", 3 },
                    { new Guid("0c93dc7c-2424-4099-a6c8-40f4c5a70b30"), new Guid("2b43a6b1-51dc-41ec-8525-6f9fc8e73da7"), 1, "730294215-3", 82m, 1997, "Bells. The", 5 },
                    { new Guid("0c9df34f-715b-47f0-8535-f5c86ef121a5"), new Guid("53d20252-1c2e-4146-ba5c-f5f192bd3bfd"), 1, "177509160-0", 36m, 2005, "Never Met Picasso", 4 },
                    { new Guid("0cae6f49-1a4e-4514-aa60-246e1823e794"), new Guid("8d325859-3e3a-4f81-a33d-222d73760e31"), 1, "535169283-X", 92m, 1997, "Hard Word. The", 12 },
                    { new Guid("0d9f08de-75ca-4432-ab73-36ba33b79f64"), new Guid("70139c7a-6c13-4bdb-87d4-c1694e025026"), 1, "059053081-X", 92m, 1995, "Prisoners of the Lost Universe", 6 },
                    { new Guid("0e54e324-3e5f-4e6c-8c2d-ceb25bfdc6bf"), new Guid("5f2c982d-53fd-4c4c-aaba-b79976b44c95"), 1, "553731505-X", 30m, 2003, "Escape to Athena", 11 },
                    { new Guid("0e894f50-a12b-43be-a230-0a1013115532"), new Guid("bec5d41c-ddfa-43b3-9d5f-ee594db919a6"), 1, "254702945-6", 45m, 2000, "Superstar", 10 },
                    { new Guid("0e93e52e-f579-42d1-adfb-96d0845d9e61"), new Guid("690ae88c-955a-42d6-8bae-cb437f7ffe58"), 1, "513134824-2", 26m, 2000, "All Over the Guy", 6 },
                    { new Guid("0f0c9115-56fa-4f82-b69e-de6981be5a32"), new Guid("0ede6111-ad59-4a97-934f-5d61431aa610"), 0, "303271556-3", 25m, 1988, "Outrage (Autoreiji)", 7 },
                    { new Guid("1020a13d-fa06-42ce-982e-27fc506dd1b5"), new Guid("b927ec44-cac5-4e04-bf0b-ab8b6e63d0d8"), 0, "934098541-9", 99m, 2005, "Snitch Cartel. The (El cartel de los sapos)", 12 },
                    { new Guid("1031440b-bff5-4185-bf35-983e948a548d"), new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), 1, "718588695-3", 90m, 1996, "Little Soldier. The (Petit soldat. Le)", 8 },
                    { new Guid("105cbd29-0765-472f-bc6f-271be1ea8dcd"), new Guid("b79722bb-068e-479f-bf3c-b214034a1e48"), 1, "824446698-7", 27m, 1992, "Visitor. The", 8 },
                    { new Guid("106995ad-7d86-495f-ab3e-6af07da4bf01"), new Guid("84e4ce3d-6234-4e46-93f1-cddb7624e95b"), 0, "728466120-8", 83m, 2006, "Carriers", 4 },
                    { new Guid("108fd7db-cbea-49df-aebc-130469936773"), new Guid("72ddafc0-9849-40cc-b04c-10050d485c26"), 0, "145390328-3", 5m, 2002, "Swing Vote", 4 },
                    { new Guid("10a1ffa3-013c-47c0-adce-1f9e938b0e30"), new Guid("3921fbaf-b6aa-41c6-9d4e-b06c1b251d95"), 0, "359208980-3", 89m, 1994, "Fantastic Planet. The (Planète sauvage. La)", 14 },
                    { new Guid("11208c53-7849-4101-a94b-792405cff1cb"), new Guid("ac1d0e46-93e9-4e8f-bd42-fd8776817650"), 1, "548729641-3", 9m, 2008, "First Kid", 14 },
                    { new Guid("112444fa-71bc-4407-97a3-47733a8613f4"), new Guid("0da6eb62-f87b-4b8d-8f56-84cf0ffcfdbc"), 1, "418741348-0", 33m, 1995, "Judgment in Berlin", 13 },
                    { new Guid("11720a7b-de57-41e5-901f-5276a8c5a70a"), new Guid("1a43890f-a96f-4b0f-bef3-be5b12f574bb"), 1, "380449722-5", 25m, 2012, "Verdict. The", 0 },
                    { new Guid("11b3675a-3e40-4018-adbb-bfc57e229ed2"), new Guid("c30d297c-daed-48ef-a4f1-8950291e56ff"), 1, "598410530-6", 89m, 2009, "Mondays in the Sun (Lunes al sol. Los)", 10 },
                    { new Guid("11bfc504-720b-4a7c-a07c-896dae1920fe"), new Guid("f845aa53-c634-4a31-a8f9-d71b14fbeffe"), 0, "918735499-3", 27m, 2004, "Girlhood", 5 },
                    { new Guid("11c66d5c-62f2-4246-9e45-8f318240f4a8"), new Guid("02089dca-80a6-4eeb-8f9f-e6b392f76f9d"), 1, "463511348-5", 61m, 1992, "Back In Action", 3 },
                    { new Guid("11e319fa-6b02-46aa-ad23-cd5ccad81182"), new Guid("82932cb1-0765-466d-940c-55c2bc0ae54e"), 0, "199853809-5", 37m, 2012, "Out for Justice", 5 },
                    { new Guid("12434bdf-e163-4a51-b89e-04d57cad1a6a"), new Guid("6c116e93-222e-4813-bd35-97af4e0626eb"), 1, "461461475-2", 47m, 1991, "Dracula Has Risen from the Grave", 3 },
                    { new Guid("1303cfd5-6e3a-44e6-85c3-0b2cb0c31790"), new Guid("37fad513-a1b0-4330-ba5c-37b735bcbeff"), 1, "510872697-X", 48m, 1997, "Fifth Commandment. The", 14 },
                    { new Guid("136d0e24-9483-48d0-8da5-97724d25b8bf"), new Guid("1b8a9a93-d1eb-4ef6-a4c2-dac636d6e3de"), 1, "028800869-3", 77m, 1995, "Eyes of the Mothman", 11 },
                    { new Guid("13b3b7d0-e6a3-4270-ba14-d6031e39222d"), new Guid("c3edc96c-896f-4475-a3c7-38fd3e4741a8"), 0, "342629683-7", 98m, 2000, "Carmen", 0 },
                    { new Guid("13e93a6e-3227-4293-9871-2b9500c1e8f9"), new Guid("1af6bab8-73c9-4ee7-b2bd-5a24daa9ffa2"), 0, "868197617-6", 94m, 1988, "Murders in the Rue Morgue", 0 },
                    { new Guid("1412462a-4e7f-4169-b618-e61778eb5fac"), new Guid("e9829cd2-b11e-4e81-8920-df37bec75c68"), 1, "718480400-7", 1m, 2011, "Requiem for a Dream", 3 },
                    { new Guid("14162e6c-344d-45bc-a962-ca3fdfa2a140"), new Guid("1e5a8cd3-90b4-4446-94bf-d3cbe087b2fd"), 0, "000078504-0", 92m, 2004, "Son of Batman", 5 },
                    { new Guid("143da1b4-df5d-4dd5-bdb4-56ad6b382b54"), new Guid("d1c444b8-aab3-4966-bebd-e8f98c51eb26"), 0, "967172833-2", 83m, 2011, "I Am Waiting (Ore wa matteru ze)", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("145e12c0-50f5-4316-ad62-2d2f87a01860"), new Guid("15a49315-552f-4f6a-9f25-001a5f13ce07"), 1, "249029498-9", 28m, 1993, "Rouge (Yin ji kau)", 12 },
                    { new Guid("1474043e-9db2-44b6-9619-8cc51c085d62"), new Guid("06c39c93-720b-45fb-9f20-cde1c13a709a"), 0, "177218517-5", 72m, 1996, "Destricted", 0 },
                    { new Guid("14e61742-e144-4882-a14f-9d3981fdce03"), new Guid("3f0365b6-2f2e-40c0-83a5-5eff7d3d09cf"), 1, "715285534-X", 96m, 2006, "Reeds. The", 4 },
                    { new Guid("14eec613-9c41-49b3-a21c-b033823757f2"), new Guid("09d8248f-b84f-4482-81ec-38e4bdde66a0"), 1, "530752565-6", 97m, 1986, "Catastroika", 0 },
                    { new Guid("14f0146a-92b7-4af5-9299-6cd4aa3729d6"), new Guid("e1402f0a-6f80-4867-9fbe-1672924d80ee"), 1, "268420430-6", 65m, 2001, "God Said 'Ha!'", 2 },
                    { new Guid("15afe9bc-6ce6-438d-8220-e24beb3e6294"), new Guid("371cdd5f-b1b9-484f-ab3d-e9122dd0779f"), 1, "515862916-1", 9m, 1998, "Once Upon a Forest", 0 },
                    { new Guid("161c364c-7657-4b2e-b2d3-eec660cff62a"), new Guid("72ddafc0-9849-40cc-b04c-10050d485c26"), 1, "313205497-6", 68m, 2010, "Chronicles of Riddick. The", 2 },
                    { new Guid("169f311d-d121-4c10-a7d8-772a56a15927"), new Guid("b8a88fec-cbca-408e-ae8f-46beccafa8f9"), 0, "910926642-9", 79m, 1987, "Herbie: Fully Loaded", 0 },
                    { new Guid("17361b7d-3568-475c-a4fe-7458b7f37db1"), new Guid("b5b0ae08-8e52-45ca-bf68-5a9ef7819577"), 0, "699434449-5", 26m, 2002, "Heartbeat", 13 },
                    { new Guid("17664e36-0424-426f-a112-bbc30f3bef46"), new Guid("fbd14cbb-a961-4de7-b7e3-c40c2cf65528"), 1, "552211191-7", 9m, 2004, "Project Moon Base", 0 },
                    { new Guid("176a9eb7-6ee3-476d-8d17-a6c1e60be467"), new Guid("666fdd39-a35e-40a5-b61f-52fbf324895b"), 0, "077812425-8", 18m, 2012, "Paddington", 4 },
                    { new Guid("176dde9f-dda4-4ab3-9227-0b229d473620"), new Guid("ace3e3d5-bf0c-4164-a962-d9e5ac5e8bd6"), 0, "052816009-5", 16m, 1992, "Galician Caress (Of Clay)", 8 },
                    { new Guid("17a33159-98e0-4605-860b-7ed98fb92054"), new Guid("d1c444b8-aab3-4966-bebd-e8f98c51eb26"), 0, "381308063-3", 96m, 1984, "Table 7", 14 },
                    { new Guid("17a4aa20-d960-4dac-96bf-ee9181ff3553"), new Guid("f87ea182-306a-448f-803f-d3c91f5a6dca"), 1, "999623775-3", 27m, 2000, "Asterix vs. Caesar (Astérix et la surprise de César)", 10 },
                    { new Guid("17abda69-46d9-4b14-b36c-93eff3a12c56"), new Guid("045ec6f1-6dc5-487b-94b4-359a852b3f00"), 1, "987120875-8", 64m, 1995, "Evil That Men Do. The", 3 },
                    { new Guid("17e8af1e-3de6-4c1a-a1d4-577d4f26f6ff"), new Guid("efaea93d-8add-41e5-8601-8521541c9b1f"), 1, "796040450-X", 50m, 2009, "Sleep Furiously", 11 },
                    { new Guid("18228689-1855-4423-88b3-64f937d84e1d"), new Guid("60cc65d0-a79d-4980-b433-343607cd3112"), 0, "447966429-7", 23m, 1997, "Revolver", 11 },
                    { new Guid("182e9c64-4bfa-4342-abd5-57dbf0c3537e"), new Guid("a1e54121-e8e2-4973-b49c-1f74c10ed69e"), 1, "907485161-4", 76m, 2011, "Barrier (Bariera)", 2 },
                    { new Guid("185f5b46-ced5-41db-bc9a-8a309d8ebd06"), new Guid("4a992285-9c76-4376-a679-b8f5ec61d400"), 0, "642916309-1", 96m, 1993, "Naked Prey. The", 6 },
                    { new Guid("18e6a454-ac64-49cc-b112-d052fcc373ea"), new Guid("099b4dc2-bb45-4315-97dc-cf885108c8a0"), 1, "059969689-3", 53m, 2009, "Isolation", 14 },
                    { new Guid("18e9efdc-7617-45a3-a1b8-c7c00ed40d15"), new Guid("48352e11-cf84-4d45-98be-4c9795501413"), 0, "379979324-0", 88m, 1994, "Fast Five (Fast and the Furious 5. The)", 8 },
                    { new Guid("19972302-e0e7-4b29-89e9-31fce62dc164"), new Guid("c9894e9c-9b66-427c-92f0-30648a1e5810"), 1, "835375481-9", 51m, 2011, "Desperate Hours", 11 },
                    { new Guid("19b65861-3f68-4a8d-b84d-7ae46134abad"), new Guid("60cc65d0-a79d-4980-b433-343607cd3112"), 1, "557927095-X", 34m, 2001, "Madagascar Skin", 10 },
                    { new Guid("19bedad3-a2d0-4045-8b49-7a465c09d07d"), new Guid("a678f50c-92eb-46d9-a079-99b86cd5cdf2"), 1, "922087376-1", 82m, 1996, "Against the Ropes", 8 },
                    { new Guid("1b15dafd-4ce9-4797-ad48-4342f04a341e"), new Guid("f3a7d97c-16be-4402-8c8a-978a85d6b254"), 0, "942020220-8", 56m, 1986, "Boys Love", 4 },
                    { new Guid("1b19a0bb-059e-43db-bb09-54280bb44be9"), new Guid("6e82bd0a-0023-42c7-9e46-6a5bb95b7484"), 1, "289514757-4", 95m, 1993, "Stagecoach", 14 },
                    { new Guid("1b20b823-4e56-4b09-b3d4-eb234b6a0120"), new Guid("09d8248f-b84f-4482-81ec-38e4bdde66a0"), 0, "704798038-5", 20m, 2009, "Crane World (Mundo grúa)", 2 },
                    { new Guid("1ba5ce05-21c3-4046-8d28-8c550b6dec96"), new Guid("7c4434be-d2f7-4d8d-9933-8e4a0e09cf75"), 0, "463899673-6", 41m, 2002, "Night Nurse", 12 },
                    { new Guid("1befc76d-f894-4cd6-b5fe-3b8087ee1849"), new Guid("4b9f8008-3206-48fa-a09a-c1b641ccf4b5"), 0, "332665467-7", 69m, 2010, "Capital (Le capital)", 5 },
                    { new Guid("1c1f3ec8-4529-4674-a6ac-94ee9ad2534d"), new Guid("cb68656a-1d75-47bb-a1fb-14a2ef54aa05"), 1, "331717707-1", 81m, 2006, "Playing from the Plate (Grajacy z talerza)", 10 },
                    { new Guid("1c3ea19e-6120-449b-80ad-e82f7525ffda"), new Guid("d08834f2-8e18-444f-a680-32c89b201ba3"), 0, "189249265-2", 53m, 1989, "Stark Raving Mad", 0 },
                    { new Guid("1c72349a-7d55-4685-bc29-331d2a248037"), new Guid("6e82bd0a-0023-42c7-9e46-6a5bb95b7484"), 1, "281397515-X", 48m, 2007, "Fortune. The", 12 },
                    { new Guid("1d1118b8-e5fa-4e4a-a8f2-b83314947cc1"), new Guid("9cce06ba-9a83-4c39-b49e-47be72ac656e"), 0, "692945701-9", 98m, 2003, "AmeriQua", 1 },
                    { new Guid("1d2254de-ec2f-480a-b0eb-8fc7cedfed35"), new Guid("852d7462-b700-4af6-b686-bf1e001de35b"), 1, "180826591-2", 99m, 1968, "Ride Beyond Vengeance", 0 },
                    { new Guid("1d43040e-0f75-46b0-8da4-11e01ae72533"), new Guid("099b4dc2-bb45-4315-97dc-cf885108c8a0"), 0, "152545688-1", 48m, 1998, "Jane Eyre", 14 },
                    { new Guid("1d519927-92b6-4873-99d7-9e6a5fe59866"), new Guid("2937fa44-1847-4019-8daf-f043717fadc4"), 1, "083938495-5", 97m, 2012, "The Diary of a Teenage Girl", 0 },
                    { new Guid("1d54df2b-1f27-4fa6-80a9-d8052d294efd"), new Guid("741323c4-4349-492d-aeb5-0d1877ea2383"), 0, "123091385-8", 36m, 1988, "GLOW: The Story of the Gorgeous Ladies of Wrestling", 6 },
                    { new Guid("1d79c44f-39c8-4365-981a-63231b42a880"), new Guid("25088fd5-59e3-4bab-a47a-d3773560a484"), 0, "748147115-0", 55m, 2005, "Son of Flubber", 13 },
                    { new Guid("1d8e043e-19a7-41f6-afe8-b26012a358dc"), new Guid("ec8e4ccd-bd7a-4690-827c-f75973e8d465"), 0, "425850244-8", 7m, 1997, "Wallace & Gromit: A Close Shave", 13 },
                    { new Guid("1daa3b2c-7265-4260-84a8-0bf6947c9a42"), new Guid("9d5b08b1-dee6-4e69-817e-a8bf92d81124"), 1, "115006749-7", 38m, 2004, "What to Expect When You're Expecting", 8 },
                    { new Guid("1db703a0-bad1-4445-bef2-9166bfd60cfd"), new Guid("21f89634-1e67-487b-b4c1-479f1ef43b52"), 1, "908824002-7", 32m, 2009, "Electric Dreams", 2 },
                    { new Guid("1dd0901c-944b-4bd6-9d70-3a9792e691eb"), new Guid("38509b37-9a4a-46e2-9941-87e047cfb7ac"), 0, "187625942-6", 33m, 1993, "Breaking the Rules", 13 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("1e01563e-2de9-46e1-b191-4ae633b77a3e"), new Guid("55d8b245-4396-4afb-811a-166e6dc1eccd"), 0, "119833860-1", 60m, 2005, "Tuxedo. The", 1 },
                    { new Guid("1e3d1ee4-bc7d-414b-a302-33a6acb4a93b"), new Guid("ed700c11-0c4a-4e26-b52e-fa295301c2d3"), 1, "665004775-9", 99m, 1994, "Blonde Ice", 12 },
                    { new Guid("1e7f4e35-fe42-4b78-804d-1c2b7cdfef5f"), new Guid("4695ed5b-6bde-476f-8064-ddf4e324b944"), 1, "884538351-2", 91m, 1990, "Barefoot Contessa. The", 1 },
                    { new Guid("1edb66e0-28aa-4bba-b27d-1a3f4a3ccbce"), new Guid("65059c5b-9872-49bb-b477-ce1c89bd0cce"), 1, "092036066-1", 36m, 2013, "Roman de gare", 9 },
                    { new Guid("1efa70d1-6d11-429d-a6c5-3eaa9c8952b1"), new Guid("f9306978-8fc1-47dc-ba7b-b2aed6f94a67"), 1, "895456611-1", 64m, 1992, "Special 26", 7 },
                    { new Guid("1f239296-5f81-49c2-9958-ef115f6316b3"), new Guid("fe69727f-3a9c-45b6-98ff-40e2fcabf918"), 1, "175551227-9", 28m, 2006, "Rigor Mortis (Geung si)", 14 },
                    { new Guid("1f54c8f0-c860-4673-858b-9a26c55baedc"), new Guid("d3b1c94b-b992-4ed7-b559-8e94f675137d"), 0, "120651423-X", 67m, 2009, "Journey of Natty Gann. The", 1 },
                    { new Guid("1f5b4847-d7bf-4b62-a174-7da6aa9b9880"), new Guid("7f9f6415-2a54-4e46-8886-af514168de43"), 1, "596880043-7", 57m, 1993, "Each Dawn I Die", 4 },
                    { new Guid("1f6df04d-7a28-41f3-9d4b-89fb3855a5a5"), new Guid("a588eb99-4369-4ba9-83a3-76d84a4bed74"), 1, "283537392-6", 95m, 1992, "Apartment 1303 3D", 2 },
                    { new Guid("202fec7e-3397-4dac-8b47-ce608e1ccfde"), new Guid("bdb31640-a03f-4d73-bcb8-ca9f07c27385"), 1, "294548532-X", 38m, 2009, "Recoil", 5 },
                    { new Guid("207315fa-4bb3-4e80-be0e-0a082c2a8181"), new Guid("82885a6f-ba33-4b00-9d73-0a808222a75d"), 0, "390949044-1", 65m, 2009, "Electric Horseman. The", 9 },
                    { new Guid("207ac310-4367-4a21-b9c0-3417c9f8f6ee"), new Guid("6e82bd0a-0023-42c7-9e46-6a5bb95b7484"), 1, "567662070-6", 98m, 2006, "Ju-on: The Curse 2", 1 },
                    { new Guid("20d900af-d9dc-4116-9fd9-424fef861b97"), new Guid("738ba564-a099-4749-8af6-f13e46b494d2"), 1, "888781625-5", 58m, 1969, "Truly Human (Et rigtigt menneske)", 7 },
                    { new Guid("20f6ffb4-a3a7-4261-b33a-6c4da477b0ac"), new Guid("65059c5b-9872-49bb-b477-ce1c89bd0cce"), 1, "844190416-2", 84m, 2008, "Chaser. The (Chugyeogja)", 8 },
                    { new Guid("2143ab27-13a5-4ba9-9896-ffa60c5df48a"), new Guid("69a396b6-43f2-416e-a00e-b3adfea00c88"), 1, "315342817-4", 47m, 1996, "City Lights", 13 },
                    { new Guid("2183d4c1-a1d3-474c-bf4b-d78c9cba45d1"), new Guid("d08834f2-8e18-444f-a680-32c89b201ba3"), 1, "156254833-6", 40m, 2011, "Kevin Hart: Let Me Explain", 1 },
                    { new Guid("220ad3d9-158d-4ec7-a815-97e90e38795d"), new Guid("3d87651d-5ad3-4d27-9f7c-cb805478c936"), 0, "866672887-6", 65m, 2012, "Great Sinner. The", 11 },
                    { new Guid("222c618a-7f4b-49cd-abac-7b9390c286aa"), new Guid("27c832f5-d940-4133-ac35-6349f6c4b59f"), 1, "047878105-9", 39m, 1992, "Lock. Stock & Two Smoking Barrels", 11 },
                    { new Guid("22d36ecb-206d-4285-9c36-d688e8368dc9"), new Guid("8744a906-2952-4236-b56d-f60d81c02330"), 1, "905111178-9", 54m, 1998, "The Vengeance of Fu Manchu", 9 },
                    { new Guid("22f17402-6252-4233-a988-a57df8b32752"), new Guid("44fca0fd-a199-40dd-91a0-c93ff17297cf"), 1, "867787162-4", 79m, 2003, "Sleep Furiously", 11 },
                    { new Guid("24607b23-ad1d-4512-859f-01b94ef89eed"), new Guid("157466fa-afb7-4076-ad21-530717018e26"), 0, "187512196-X", 44m, 2008, "Frogs for Snakes", 11 },
                    { new Guid("246f1c5a-bd96-4acf-9d60-8c05a16ab89f"), new Guid("1bd5a605-a9aa-4a11-91de-fe75aa18bb5f"), 0, "086322220-X", 45m, 1999, "Dragonheart 3: The Sorcerer's Curse", 1 },
                    { new Guid("24a80ff4-aa74-4489-94c2-24e2ce798510"), new Guid("9ea07d3d-fb8c-4593-a762-ed8f0ed73b5a"), 0, "953934580-4", 22m, 2012, "Tales of Vesperia: The First Strike (Teiruzu obu vesuperia: The first strike)", 2 },
                    { new Guid("24b65650-6092-4c56-8a7b-b2a6362ca606"), new Guid("232f5d75-8488-447f-8b6a-8de60c3673af"), 1, "487840087-0", 56m, 2008, "One Chance", 12 },
                    { new Guid("24ca388e-e960-440a-a62b-ed9379fa9594"), new Guid("a8aa50b5-fdf3-4655-8949-92fe84eb9f79"), 0, "767953005-X", 63m, 2009, "King's Faith", 4 },
                    { new Guid("24ea8d32-e255-4efd-8ebd-cc481394cf05"), new Guid("b332f0d9-946f-4d7d-b546-60bc208688d6"), 0, "150390666-3", 46m, 1987, "Castle Keep", 10 },
                    { new Guid("24ee2c62-ebb4-40a2-ad22-3e47d42af044"), new Guid("3a207398-ffb8-4fdf-973b-0858c6e96fb2"), 0, "283662721-2", 50m, 1995, "Savage Innocents. The", 10 },
                    { new Guid("24fca9fc-1e86-44ca-9b17-925bdec6257e"), new Guid("5d47bba2-ee33-4b27-8c81-15e59c1608e8"), 1, "260767151-5", 6m, 2009, "Viva Riva!", 9 },
                    { new Guid("25d26546-147a-459d-9bac-00d1d1341462"), new Guid("767be4eb-dc82-4a86-9c72-9938f0c1a54a"), 1, "785399204-1", 79m, 2011, "Stray Dog (Nora inu)", 6 },
                    { new Guid("25dc488f-1684-4d64-9c6e-6585d6ebb072"), new Guid("d5ca6334-a710-4952-9344-a3592a88d221"), 1, "154866737-4", 94m, 2009, "Will Penny", 10 },
                    { new Guid("25ebf71d-5e67-47bc-978e-0d1e6ad2339d"), new Guid("4af595bf-6ead-4e5a-a962-d53f372eafca"), 0, "957951614-6", 75m, 2007, "Kid. The", 3 },
                    { new Guid("2643a5a6-9148-43b2-97f7-9155d2a03123"), new Guid("4f5171c4-53c4-4d07-b73b-58cb27343ba6"), 0, "830536157-8", 85m, 1988, "Red Hook Summer", 12 },
                    { new Guid("26663e84-2066-4695-b6a1-c23f15a63458"), new Guid("71114bb2-2230-4e41-9533-6d3b34a213ee"), 1, "993912768-5", 13m, 2005, "Straight from the Heart", 0 },
                    { new Guid("26a71165-4a20-4458-80ed-26e3869f978f"), new Guid("e3edb88d-789e-4c88-87b1-0c9f6f0284db"), 0, "019858071-1", 88m, 2013, "Street Mobster (a.k.a. Modern Yakuza: Outlaw Killer) (Gendai yakuza: hito-kiri yota)", 11 },
                    { new Guid("26e17bda-f1c8-4774-84e9-45b120782159"), new Guid("794c30e1-5ab6-41c7-b562-0683c0b7875e"), 0, "740893449-9", 51m, 2012, "Handmaid's Tale. The", 10 },
                    { new Guid("26eabab7-e668-4dd1-b02c-bedb1794f9cf"), new Guid("efaea93d-8add-41e5-8601-8521541c9b1f"), 1, "266800887-5", 57m, 2002, "Snake in the Eagle's Shadow (Se ying diu sau)", 5 },
                    { new Guid("27bb507f-795f-4064-b442-3b0427b8b487"), new Guid("6770bc5b-adf0-4128-98eb-5467c5941bbe"), 1, "041118568-3", 44m, 2011, "American Pie Presents: The Book of Love (American Pie 7: The Book of Love)", 11 },
                    { new Guid("27d5f3fd-0c54-4fb7-a674-8affa6ebc724"), new Guid("5f7219c5-694a-4792-860a-852f7bfddfff"), 0, "004865469-8", 1m, 1998, "Deadline (Sprängaren)", 11 },
                    { new Guid("27f9f98f-382f-439e-8fc1-a1dc72c3d6eb"), new Guid("e6d2c155-9c3c-463c-98f3-0f7699e65c49"), 0, "007273832-4", 62m, 2010, "Advanced Style", 7 },
                    { new Guid("2857469a-4089-4a1c-bd9e-1df64ca3ff40"), new Guid("6fb52fae-c0ba-40aa-bdd6-86304d63a1e5"), 1, "214651886-3", 89m, 2001, "Eddie Izzard: Dress to Kill", 8 },
                    { new Guid("2892c8fc-577c-4b87-9a5d-5219a3e47732"), new Guid("65a7332c-313e-48e6-a284-76e83c40d9df"), 1, "854315507-X", 18m, 2000, "Green Berets. The", 14 },
                    { new Guid("2921bd32-d429-4a63-b0bf-14318adc79f0"), new Guid("f81a29bc-1557-4b3e-948e-bd604a683e1f"), 1, "077334061-0", 52m, 1997, "Every Other Week (Varannan vecka)", 5 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("2925ca76-fbaf-4fa5-996b-66bcd015f738"), new Guid("9196f1a3-d6d5-4a1d-a167-040c85293f4a"), 0, "757990250-8", 71m, 1989, "Mr. Conservative: Goldwater on Goldwater", 4 },
                    { new Guid("29752707-0924-4f70-8e26-ebeafee1530a"), new Guid("aae74c34-8c53-42d6-af9a-08d855388f1d"), 1, "263986526-9", 74m, 2012, "Shag", 1 },
                    { new Guid("299f0026-9201-472a-a989-e0b1e263a9fe"), new Guid("538191e8-5115-410a-8979-245eaf2ee054"), 0, "526897100-X", 32m, 1994, "Nick Carter. Master Detective", 7 },
                    { new Guid("29bfa62f-4e94-4dee-abad-eba54b2617a9"), new Guid("d013dfc1-9487-4ad2-8b83-63d752461ef8"), 0, "798748017-7", 48m, 1977, "How to Murder Your Wife", 9 },
                    { new Guid("29f12437-6c0e-4135-b372-3a93276817c7"), new Guid("aebf2bd6-1904-43fd-9b2f-c06fdc04f541"), 1, "816838085-1", 98m, 2003, "It's My Party", 3 },
                    { new Guid("2a4eac2b-fd78-46f3-a77d-6df7f610063c"), new Guid("6770bc5b-adf0-4128-98eb-5467c5941bbe"), 0, "138747959-8", 31m, 1992, "Keys to Tulsa", 8 },
                    { new Guid("2ab3a569-73ce-4dde-a8f5-7144132013cd"), new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), 1, "497095462-3", 4m, 2003, "Doing Time on Maple Drive", 1 },
                    { new Guid("2ab83c8a-b7bf-49cb-8e82-254066a3e255"), new Guid("dbb45e0d-e5fc-462e-b783-62a2c2dc8d87"), 0, "628685893-8", 34m, 2005, "Trouble in Mind", 6 },
                    { new Guid("2ac3ed42-9895-473b-8824-b4fb8b33f071"), new Guid("18d5a51c-632e-451d-a3e1-9ca5fb484154"), 0, "245164112-6", 87m, 1992, "Tales of Manhattan", 12 },
                    { new Guid("2b1b549d-e664-49d8-bb89-c5ec024ae0b6"), new Guid("35a17d4c-3203-4643-b237-4578b56c5877"), 1, "267025768-2", 96m, 1992, "Badge. The", 2 },
                    { new Guid("2b6c1508-d5b2-410c-955a-9e9abe4e36fa"), new Guid("620a9cd1-b46f-46a0-8989-25d4d2884537"), 1, "258542989-X", 15m, 1997, "Freddy vs. Jason", 12 },
                    { new Guid("2bf27897-fe68-4ce2-a6f3-d1e33cdf6954"), new Guid("ef7b31d4-5bd2-4689-abe2-6073c1f11a90"), 1, "886811191-8", 43m, 2004, "Captains of the Clouds", 5 },
                    { new Guid("2c8b370a-d198-41d7-a122-31a0ae24c34c"), new Guid("ac92d821-cfcb-447a-9b8e-db0cac64522a"), 0, "232643701-2", 46m, 1995, "Nothing's All Bad", 2 },
                    { new Guid("2cf134c3-4da4-446b-83b0-009ed7380cb8"), new Guid("aebf2bd6-1904-43fd-9b2f-c06fdc04f541"), 0, "893321237-X", 13m, 2003, "41", 7 },
                    { new Guid("2db7268d-56fa-48e1-8a55-cb40f706bf9b"), new Guid("e53a96e4-5c39-4739-94b2-cabdced13469"), 1, "385608349-9", 98m, 1997, "That's What I Am", 5 },
                    { new Guid("2e1016f9-a383-4245-afb0-65b3aed699a7"), new Guid("25b44da4-0905-40c9-8f98-1be78cb9a2cf"), 0, "147661192-0", 18m, 1989, "Pontiac Moon", 5 },
                    { new Guid("2e5d4f1d-4b7f-47af-9210-6d59e34ac3f5"), new Guid("383b0277-d263-4ca6-a895-2e83d2c6983e"), 1, "130119310-0", 20m, 2004, "Daredevil", 3 },
                    { new Guid("2f197ce6-7e9d-4de5-89d5-3194516f17be"), new Guid("167f9d00-6d9e-4aa8-a8b0-5b23b2d059bb"), 0, "030718948-1", 87m, 2011, "Red-Headed Woman", 4 },
                    { new Guid("2f1df018-6177-4966-aa98-b2958bbfb1d9"), new Guid("504a498e-074e-4ced-b80e-361475578816"), 1, "756581742-2", 71m, 2011, "Haunted Palace. The", 11 },
                    { new Guid("2f3d6847-59bb-4405-8228-73c0d11a6242"), new Guid("19fe27c7-6493-4426-9659-576f5fd3f56e"), 1, "416566530-4", 26m, 2000, "Funny Girl", 8 },
                    { new Guid("2f6fe725-aee5-47e3-9bf7-5ebfd28fd72f"), new Guid("24cc8724-f4c5-4971-95e3-413639453775"), 0, "265260921-1", 21m, 2002, "Drei Stunden", 5 },
                    { new Guid("2f8a935a-cb22-4a6d-9851-499aa9507dc2"), new Guid("61999025-8149-4529-bbd7-c82935d20bc8"), 1, "142297780-3", 68m, 1999, "Resurrecting the Champ", 0 },
                    { new Guid("2f9b668b-b062-4924-b03b-7179666a0319"), new Guid("caced371-71f9-4c30-bee7-c57932a9e55f"), 1, "396861553-0", 30m, 1996, "Expecting a Miracle", 9 },
                    { new Guid("301a7ba0-bc40-4982-a244-159863fa9264"), new Guid("edc1ba6b-4403-46f5-bc5d-1ee8ec9a353a"), 0, "266390710-3", 71m, 2004, "Che: Part One", 7 },
                    { new Guid("3084d9c0-58a4-430e-af68-0d033352f86f"), new Guid("72b841d4-68b1-4e9b-a767-fb498485e408"), 0, "719450396-4", 19m, 2007, "Inkheart", 12 },
                    { new Guid("30f01729-5404-4e3e-8132-c2e9f4f3d4b9"), new Guid("64fe9ab9-6403-43a8-a1d7-0cfc98c6657f"), 0, "586486615-6", 9m, 2008, "Sticky Fingers of Time. The", 1 },
                    { new Guid("310c635e-387e-4925-96a7-0b335234629d"), new Guid("0cf94f39-c58f-40de-b848-abb34fcdab11"), 1, "531998863-X", 23m, 2003, "The Sea Vultures", 6 },
                    { new Guid("311a8813-5122-45a7-8cc7-4692baba0886"), new Guid("a4fa69ca-095c-4f86-97eb-445be94e9a85"), 0, "764624778-2", 77m, 1995, "Camp Rock 2: The Final Jam", 8 },
                    { new Guid("315046f5-a28b-454d-aeb9-15ecea0ed087"), new Guid("c1e6f4e7-5bc8-4371-8064-5fb4223d8f44"), 1, "192629485-8", 2m, 2004, "On Moonlight Bay", 14 },
                    { new Guid("31faaf33-5807-4131-93bf-30e80bb3055b"), new Guid("ad1e5cb4-e2a4-437f-87c2-e76a78e4d0e5"), 0, "062048750-X", 10m, 2007, "14 Hours (Fourteen Hours)", 0 },
                    { new Guid("32418fce-08e4-4a46-9f30-1e486e4ab0f9"), new Guid("8b0997b9-5d4f-48d8-b9ac-7ea47e9ffdef"), 0, "298510772-5", 66m, 2004, "Death and Cremation", 0 },
                    { new Guid("32d0437a-e614-4ee0-bc01-eca37b625282"), new Guid("267cbc06-0ea5-4809-81e6-fd425fabc167"), 1, "206295684-3", 3m, 2001, "Seven Years Bad Luck", 13 },
                    { new Guid("32fbcad2-6bb1-4920-b5c0-88b021c9d98f"), new Guid("5d497ab4-fa1a-405e-9c7b-13d86705e5f5"), 0, "468690257-6", 11m, 2009, "Hello Herman", 13 },
                    { new Guid("333f945e-7a90-4267-9e26-d21b0b1541e8"), new Guid("3e9fde8a-0dd7-401b-9a87-fab3fab8fa55"), 1, "861180685-9", 44m, 1997, "A Girl Walks Home Alone at Night", 10 },
                    { new Guid("33a3537a-ffbe-4c40-a8a3-d3d470e14b6c"), new Guid("2d99176a-fc73-4fc7-a0d3-d46731af0e4c"), 0, "128266581-2", 86m, 2008, "Gainsbourg (Vie Héroïque)", 10 },
                    { new Guid("34d12da4-20d6-40a5-bd08-44d072908ff9"), new Guid("3cd90b43-7ca5-41b3-a60c-bdcdf3b005ff"), 1, "417045338-7", 5m, 2006, "Little Murders", 12 },
                    { new Guid("34f49e44-6d21-45db-bd7c-ff9b68c3a3dc"), new Guid("83d89db5-7204-46ef-93bf-fd6e9df782cd"), 1, "767853030-7", 96m, 2010, "League of Ordinary Gentlemen. A", 0 },
                    { new Guid("3568a9df-39aa-4866-b3c1-a73c226a8145"), new Guid("80506364-36c8-4cdd-8719-7a786f31f2a7"), 1, "114365345-9", 90m, 2003, "President's Man: A Line in the Sand. The", 8 },
                    { new Guid("35a02266-aa92-480c-b243-c03c47b1d8e4"), new Guid("08932960-8d61-42f1-952f-3ce019f67547"), 1, "562928794-X", 11m, 2009, "Lilith", 12 },
                    { new Guid("35e7a699-0076-49e2-8016-da5e03617d68"), new Guid("76d4abc7-148b-41fc-aab6-06f05c220f36"), 1, "642231743-3", 68m, 2006, "Hard. Fast and Beautiful", 9 },
                    { new Guid("364c6561-4d1c-4bd4-8414-2c65d9ec48d6"), new Guid("18fbea11-549c-41ea-907a-3c687ee0654f"), 0, "807403121-7", 77m, 2010, "Iron Man 2", 14 },
                    { new Guid("378ba433-f4fa-4fe5-9a62-dfba69dddbad"), new Guid("52b06a3d-6e38-4e84-9b33-01111f9d4502"), 0, "311373883-0", 49m, 2012, "Thing About My Folks. The", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("37bab301-4998-4246-b55e-5b2d30f45a39"), new Guid("f48e6883-2966-4822-8433-b18d619808ea"), 0, "488645013-X", 22m, 1996, "Sin of Madelon Claudet. The", 11 },
                    { new Guid("37f26fa6-f191-45a4-9d63-900d40e0c6ed"), new Guid("f3c84ba8-01c8-4fd2-a47c-0f213462fa28"), 0, "888357894-5", 25m, 2000, "Castle in the Desert (Charlie Chan in Castle in the Desert)", 8 },
                    { new Guid("383f5d39-764c-45c2-ba00-49d5ffbad806"), new Guid("4fb98fcc-c5bd-4d8d-ac3f-7cabf3954ac8"), 1, "294682213-3", 69m, 1993, "Shadow of the Holy Book (Pyhän kirjan varjo)", 3 },
                    { new Guid("384d64cd-5de9-4878-8bcc-90b073d2c9da"), new Guid("3de133f0-d8f0-4114-a2f5-83c51e166f2a"), 1, "682362698-4", 53m, 2004, "StreetDance 3D", 13 },
                    { new Guid("38a5c2e2-996b-4f4d-8581-f6e2628d1a55"), new Guid("b8c3d832-e24d-470d-8d87-e3ab5da9ee79"), 1, "595829860-7", 59m, 2005, "Prodigal Son. The (Tuhlaajapoika)", 14 },
                    { new Guid("38f41f36-f40f-4b40-a37a-806da1970f30"), new Guid("b56a5ef6-7988-4e61-9944-beb232f4e3e2"), 0, "141856029-4", 1m, 1996, "Thank Your Lucky Stars", 9 },
                    { new Guid("39160324-b2f0-426e-85d9-1a00cb351e82"), new Guid("079aafe1-97db-4416-8a2d-7e598149b737"), 0, "631607724-6", 5m, 1989, "Tough Enough (Knallhart)", 12 },
                    { new Guid("39248f1f-8e96-4fe2-88e6-4fb16fd33816"), new Guid("4ab0609d-4af7-43fa-9c0c-8c7cff1b8816"), 0, "100305524-9", 98m, 2009, "Narrow Margin. The", 5 },
                    { new Guid("392b713b-ee2b-4cfd-bae8-7bfd35a9ae8c"), new Guid("42ad2b90-d981-4f4a-a669-33d0a199be28"), 1, "759769714-7", 32m, 2004, "Streetcar Named Desire. A", 12 },
                    { new Guid("392dbc42-e48c-4a88-82af-9e3ee2f77cf0"), new Guid("0b933755-3929-4970-9e65-924c1ad9d427"), 0, "556132044-0", 65m, 1993, "Quarantine 2: Terminal", 7 },
                    { new Guid("395d5551-a7ac-43fb-aeb7-f3a97fd34c90"), new Guid("50067643-6f49-4dc7-b1ef-f16b78da8ad5"), 0, "236335378-1", 65m, 1984, "Kikujiro (Kikujirô no natsu)", 12 },
                    { new Guid("39c51439-955b-44a8-b600-c17f081d4bc8"), new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"), 0, "073931171-9", 25m, 2004, "Flash of Genius", 1 },
                    { new Guid("39e398d8-b806-445b-960d-ce63bae89272"), new Guid("c7739201-0190-4f2d-80d9-ddc77ccbb2ce"), 0, "468839249-4", 10m, 2009, "Room at the Top", 13 },
                    { new Guid("39fa0bf8-6089-429b-a78d-eee52fcb97df"), new Guid("4faa4f23-0f75-441f-8048-d9f0338101c0"), 1, "266748814-8", 15m, 1999, "Bashu. the Little Stranger (Bashu. gharibeye koochak)", 14 },
                    { new Guid("3b3fc461-81a9-4404-bcac-60fffae1307b"), new Guid("e940cd56-6009-4fff-a9fa-2aa0c1d1df4d"), 1, "823548248-7", 62m, 1997, "Charley Varrick", 1 },
                    { new Guid("3bb9bcb1-963c-452c-b3e2-e61a6f7f7161"), new Guid("8c2457e6-d528-4cca-9965-b47a47643d55"), 0, "978873381-6", 69m, 1986, "Company of Wolves. The", 9 },
                    { new Guid("3bd0ce31-c21d-4ea8-90d1-af3df110e997"), new Guid("2fdca055-7193-44bf-b351-e06794b8fb71"), 0, "517765360-9", 44m, 1999, "Cannibal Holocaust", 12 },
                    { new Guid("3c06f6d1-95f7-4326-9253-94beb2f3d77b"), new Guid("eadec3b1-2ad4-4b78-86a8-d56dd9247e64"), 0, "592878006-0", 96m, 1995, "Seagull's Laughter. The (Mávahlátur)", 14 },
                    { new Guid("3c458054-014c-46bf-a9c1-53d782541482"), new Guid("f48e6883-2966-4822-8433-b18d619808ea"), 1, "613949469-9", 84m, 1998, "14 Blades (Jin yi wei)", 6 },
                    { new Guid("3c903dd3-b61c-4bbb-8f67-4f2c24ccfbe5"), new Guid("3d7e2d73-9253-44d4-bb85-e5fc99eab549"), 1, "223578417-8", 69m, 1996, "Drunks", 8 },
                    { new Guid("3cab1023-c76a-45da-82b9-3655337be594"), new Guid("aafbe801-5353-4a9c-88b9-6844e8211e62"), 0, "917810314-2", 53m, 2010, "Destiny (a.k.a. Between Two Worlds) (Der müde Tod)", 3 },
                    { new Guid("3cdff34e-b4e2-47bd-90c2-84dea6589cbe"), new Guid("fd773f34-1f6b-4b48-994f-400d3850459f"), 0, "255198321-5", 51m, 2003, "An Evening with Robin Williams", 1 },
                    { new Guid("3d0f0b84-4b3a-4487-b863-1d6ff0abd9a5"), new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"), 1, "302186914-9", 71m, 2000, "Lion of the Desert", 13 },
                    { new Guid("3d170328-240b-4fd3-aac6-fdfa05facfcc"), new Guid("8bc2fbf2-b8be-420a-ab41-e49c44123753"), 0, "176684520-7", 9m, 2012, "Ryan's Daughter", 11 },
                    { new Guid("3d1ad74a-25a4-4c60-9d9d-20d29b988731"), new Guid("b08257b8-25a2-4afb-a578-9d7600243614"), 0, "949002185-7", 74m, 1994, "Man with Two Brains. The", 0 },
                    { new Guid("3db98a3d-252a-4ef6-9e50-36998751c878"), new Guid("71883c85-5cca-49b7-bf9d-ae437f3ba3c4"), 0, "809019460-5", 8m, 1970, "Mr. Jealousy", 4 },
                    { new Guid("3df3c7ca-6127-45a2-a872-e4b2b09eecbc"), new Guid("7bd14181-3064-45eb-8a57-735bbb4f3ee1"), 0, "752428500-0", 53m, 1997, "King of Jazz", 6 },
                    { new Guid("3e0665a4-e3e3-4176-b1cc-de4bbb0ae2e1"), new Guid("9f47d237-06e8-4131-be82-fa976f77ba89"), 0, "189814888-0", 30m, 2004, "Science of Sleep. The (La science des rêves)", 9 },
                    { new Guid("3e0f684a-86ad-4533-bd8d-deacaa61a34f"), new Guid("c8461714-1444-44df-99ac-584134223147"), 0, "112453631-0", 16m, 1994, "Smiley", 2 },
                    { new Guid("3e590d94-e108-4bcf-a9fc-a039ea68dfef"), new Guid("697085a0-dcc7-4d69-988c-6bb0e1ec1880"), 1, "742850039-7", 86m, 2007, "Canyons. The", 8 },
                    { new Guid("3e71601a-23c8-4ce8-8eb5-bdf6a1bbdf5b"), new Guid("a95c8910-d83a-4869-a4cf-08ee55be3f05"), 1, "812208642-X", 44m, 2008, "The Disappeared", 11 },
                    { new Guid("3ed87488-7c93-4dbe-8933-3d39d18a91dc"), new Guid("0cf94f39-c58f-40de-b848-abb34fcdab11"), 0, "099539348-6", 22m, 2005, "Buddy Holly Story. The", 7 },
                    { new Guid("3edf0e07-19e9-4882-891e-63fae5681223"), new Guid("03a5bd12-ef92-4d66-91bb-9da8d3666f82"), 0, "105233786-4", 77m, 1986, "Man in the Iron Mask. The", 6 },
                    { new Guid("3f8912dc-3e77-4992-998f-fa2433076f13"), new Guid("a43f4893-ee73-413d-9004-09c6cf5dfe6c"), 1, "712871580-0", 40m, 1997, "See What I'm Saying: The Deaf Entertainers Documentary", 2 },
                    { new Guid("3f9b8ec0-3d8f-4bb0-9575-36ce1f619f23"), new Guid("bdbfb312-e3f0-43da-8f7f-9f4de500cb37"), 0, "196421575-7", 44m, 2011, "Hocus Pocus", 0 },
                    { new Guid("40dde6af-3ee2-4cec-9515-ed928d58c346"), new Guid("ace68f80-9a57-4129-9e09-436ea1d736c2"), 0, "979451669-4", 31m, 1999, "Gung Ho! (Gung Ho!: The Story of Carlson's Makin Island Raiders)", 6 },
                    { new Guid("4114cb3f-9976-4145-936c-609799cd86c6"), new Guid("b509ccd3-ed6a-43f0-9222-c6f06303c6b5"), 0, "460770162-9", 2m, 1995, "American Movie", 2 },
                    { new Guid("411c4012-db10-4e9f-a39a-271854414dac"), new Guid("341a5b3b-f616-4bec-a433-50a0b13065b8"), 1, "771986467-0", 11m, 1992, "Le crocodile du Botswanga", 2 },
                    { new Guid("4139362b-2a06-4fcc-852f-26262b124efb"), new Guid("da68975d-212e-451c-b657-5bdafeb21a46"), 0, "402497698-2", 93m, 2009, "French Cancan", 7 },
                    { new Guid("41a8a6b8-1d08-4880-b369-7598513af6fb"), new Guid("6856ba53-2c1e-4512-a802-1f41f6477f07"), 0, "207062766-7", 50m, 2009, "Royal Scandal. The", 7 },
                    { new Guid("41bed6c4-460c-46a1-8a6a-e7aeb9cef997"), new Guid("f7986027-cfa1-4c10-8f34-bf95cb5b812c"), 1, "958525602-9", 68m, 1995, "Search and Destroy", 9 },
                    { new Guid("41ffd07b-6343-4f6a-be29-046816c55502"), new Guid("8736b406-20a0-431a-aa2c-69b69fe7f7a4"), 1, "056819428-4", 62m, 2004, "Harsh Times", 7 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("421f87f2-cea9-41b8-9399-ac826109680c"), new Guid("2a4361b4-782d-4a0e-8a50-1f9112da9434"), 0, "590815770-8", 40m, 2012, "Man on High Heels", 1 },
                    { new Guid("427d730d-d8e5-4642-ac7d-eda1e4d414b0"), new Guid("92dcb42a-2d2a-405b-b9f8-a43981b4e6c5"), 1, "313973297-X", 93m, 1999, "Warm Bodies", 9 },
                    { new Guid("42b319b1-438d-4f28-948f-f571741cdb0d"), new Guid("6deeb509-6c19-4323-b2f7-c86349a2b003"), 1, "836002333-6", 71m, 2002, "Desperate Hours. The", 14 },
                    { new Guid("42e29a18-054c-4316-b064-2ae977b19293"), new Guid("2937fa44-1847-4019-8daf-f043717fadc4"), 1, "925127912-8", 6m, 2009, "Our Modern Maidens", 9 },
                    { new Guid("42f96912-c0f5-4cde-9ca6-45c40598765d"), new Guid("78cc65b6-2bc6-4a36-87c7-6f0a5a375243"), 0, "125630708-4", 8m, 1988, "Bang Bang", 0 },
                    { new Guid("4343f8aa-5577-4208-b1d7-413eb427ba13"), new Guid("76d4abc7-148b-41fc-aab6-06f05c220f36"), 1, "381992581-3", 36m, 1989, "Let's Get Harry", 5 },
                    { new Guid("438c9d57-3f8d-4096-8bdc-8e84c8b37436"), new Guid("5380659f-2ce3-4bfe-a1db-003100941591"), 1, "564736922-7", 31m, 1989, "Space Movie. The", 11 },
                    { new Guid("443f3988-221a-44bf-b4eb-9de47f7698ad"), new Guid("138735b3-9b6a-407d-ad6b-3fe6bfd1eb83"), 1, "450636067-2", 36m, 1999, "Viva Zapata!", 13 },
                    { new Guid("4454462a-5c3f-4e3e-bf43-ece12d4ecb2c"), new Guid("5a431516-a853-4511-b84a-092c5e7a4fa7"), 0, "499156358-5", 95m, 2006, "Pajama Party", 13 },
                    { new Guid("449c7b23-0424-4b72-a992-4a6e3ca5adff"), new Guid("e52bd501-3258-4414-a396-b891f047dac9"), 0, "269456789-4", 9m, 2008, "Rusalochka (The Little Mermaid)", 3 },
                    { new Guid("45124dbc-ad26-4bc3-b1ad-38454f5a9aac"), new Guid("6770bc5b-adf0-4128-98eb-5467c5941bbe"), 0, "232891794-1", 61m, 2009, "Sex Ed", 10 },
                    { new Guid("451bf1ce-63ea-4505-8366-07184f460587"), new Guid("a5114f33-615c-4c6f-8e19-d1d06ca3ee9a"), 1, "123762886-5", 13m, 2003, "Much Ado About Something", 10 },
                    { new Guid("456336d0-63c3-4e3c-823d-6c33914aeb94"), new Guid("a62532c0-0ac2-4680-bfce-462ba0a5a924"), 0, "933184063-2", 41m, 2008, "In the Mood For Love (Fa yeung nin wa)", 4 },
                    { new Guid("456e067c-a86f-441a-9fd0-aa67fa9b173f"), new Guid("c7ce58f3-b2c6-4d5d-a91b-05c7e9ef5ae0"), 1, "186972612-X", 44m, 1993, "Lucky Break", 9 },
                    { new Guid("45a06d80-95fd-400c-82cf-ec9b5c3e540b"), new Guid("2ca0a633-a9d0-4acd-8441-de22f7bf1298"), 0, "043425673-0", 29m, 1996, "Window to Paris (Okno v Parizh)", 1 },
                    { new Guid("46131be1-1a44-40bb-be9f-7f616cafc56c"), new Guid("39c6d354-bbc8-4bfc-b956-57554d54af7d"), 1, "870555372-5", 94m, 1995, "Dead Heat", 3 },
                    { new Guid("46488edb-4270-44fb-a96d-69af98154f45"), new Guid("991640fc-0443-4c08-9a22-7dbce915318a"), 1, "211274924-2", 23m, 1991, "Day After. The", 4 },
                    { new Guid("465f8a89-1608-47cf-b3d0-e53d1b699e8a"), new Guid("a8aa50b5-fdf3-4655-8949-92fe84eb9f79"), 0, "640673954-X", 3m, 2000, "Yankee Doodle Dandy", 1 },
                    { new Guid("46d2c65c-024a-475f-a2ff-4eaf605fd7c4"), new Guid("8e3c13b0-12ad-4e03-a097-560841a5733e"), 1, "114750110-6", 44m, 2000, "Ten. The", 5 },
                    { new Guid("46ff4722-d04f-4e7e-83ad-02728aa447ba"), new Guid("c5526c67-3078-4eca-98c6-5e1ae428d9f8"), 1, "028605067-6", 16m, 1999, "Guilty Hands", 10 },
                    { new Guid("4774c59c-0a09-4786-bdd7-fdd60513e405"), new Guid("7d025fa4-0ce3-4792-bf95-d6362c98db02"), 1, "963225983-1", 62m, 2007, "Who Are the DeBolts? [And Where Did They Get 19 Kids?]", 2 },
                    { new Guid("477cd959-aff1-472d-bcb4-d4a32d8c1595"), new Guid("a1e54121-e8e2-4973-b49c-1f74c10ed69e"), 1, "849062923-4", 78m, 1995, "Chariots of the Gods (Erinnerungen an die Zukunft)", 6 },
                    { new Guid("47bfec53-66af-4f1f-8c5d-f4a6f5376e3c"), new Guid("73a57c91-2933-4f5b-9754-c542bd143feb"), 1, "216134894-9", 92m, 2012, "Crazy for Christmas", 3 },
                    { new Guid("47c4d01e-5761-4290-8e9c-64700833fdab"), new Guid("ee8e3c8c-a3df-430b-8e07-98267892abe7"), 0, "153931191-0", 11m, 2011, "Living with the Fosters", 13 },
                    { new Guid("48232cfc-f0be-43af-b824-e45e47ed03fc"), new Guid("9eaecb0c-d67b-4a3f-9295-28c30aaa7ba7"), 0, "641019043-3", 17m, 2005, "What If ...", 12 },
                    { new Guid("484fdd37-1ca8-47cb-ac74-26c2924c94b6"), new Guid("1087b4c4-fff3-4ebe-86b0-36ab5acd10cb"), 0, "926435581-2", 44m, 2001, "Desirée", 1 },
                    { new Guid("4850bdc5-5068-4dbd-a459-3f0edfdc07b5"), new Guid("836f5da6-02f6-401d-8b9e-68088a91dfad"), 1, "886648159-9", 99m, 2004, "Witchfinder General (Conquerer Worm. The)", 13 },
                    { new Guid("485441f0-3194-4e91-8cae-1c03d9af4938"), new Guid("0b933755-3929-4970-9e65-924c1ad9d427"), 1, "581601511-7", 48m, 2010, "Swell Season. The", 1 },
                    { new Guid("486275f3-bb34-44ec-a5a5-4bd27ccf35f6"), new Guid("b0c354b9-70e3-4f31-a6f4-a3d1da30d4a7"), 1, "492108322-3", 51m, 1994, "Sun Wind (Aurinkotuuli)", 6 },
                    { new Guid("4870fca7-cbeb-47f4-9e67-5e1d53761528"), new Guid("f8bb7e04-e493-45b0-b323-4db8818a4473"), 0, "049101538-0", 57m, 2004, "And the Band Played On", 7 },
                    { new Guid("48961460-fc9c-4b99-9386-b027dcb6a915"), new Guid("bb7396ad-9f1f-4e73-bd22-2a465dc1d957"), 1, "053730850-4", 60m, 2004, "New Country. The (Det nya landet)", 7 },
                    { new Guid("48dda679-6677-48db-9e3c-02e13433d712"), new Guid("da5c2227-bcee-4e5c-921b-89e0a4c20615"), 0, "887603623-7", 25m, 1998, "Crime of Father Amaro. The (Crimen del padre Amaro. El)", 5 },
                    { new Guid("48edb058-89b1-43ec-b212-6f1764fcb3e4"), new Guid("add8b096-6816-4e92-a968-2b4ddd795f1c"), 0, "365416452-8", 51m, 1992, "Chant of Jimmy Blacksmith. The", 0 },
                    { new Guid("49128022-7cf7-4456-a2c4-65fe5e251e82"), new Guid("5de4c448-dc13-496c-8858-8031eb4c71de"), 0, "629058998-9", 47m, 1995, "Passion of Mind", 0 },
                    { new Guid("492dcfac-808b-488c-8505-419e666343fc"), new Guid("8fe1c98e-5a98-4269-95c6-95c4ae010ce5"), 1, "041446652-7", 80m, 1992, "Friend Is a Treasure. A (Chi Trova Un Amico. Trova un Tesoro) (Who Finds a Friend Finds a Treasure)", 0 },
                    { new Guid("4941ffee-a2b8-483e-bfc4-f2a4aceabeb0"), new Guid("e8788c82-352f-46d1-ad4a-b793fb8fdd83"), 1, "093623189-0", 8m, 2004, "Yesterday's Enemy", 6 },
                    { new Guid("49e4bb29-9404-4e1b-ae2c-16e7ed24d2e2"), new Guid("fe7c3a03-2532-4d05-b18c-cfcc0138ef77"), 1, "547236796-4", 67m, 1995, "N Word. The", 8 },
                    { new Guid("4a400bfa-5726-40e8-8134-481671866aed"), new Guid("7aa41135-6051-486d-8eee-4ae624f43516"), 0, "209320848-2", 14m, 2007, "Grown Ups 2", 4 },
                    { new Guid("4ac4764b-970c-4c0b-90f1-6943ed465f5b"), new Guid("5ae767a4-63a4-4b2e-b342-857fa81f8377"), 0, "304516801-9", 9m, 1995, "Rasputin", 7 },
                    { new Guid("4af726e2-3aeb-4091-95e2-bf6355b9494e"), new Guid("28c0521f-97a0-4e21-a7bc-45028ef1eb09"), 1, "102300186-1", 98m, 1988, "Putney Swope", 8 },
                    { new Guid("4af949eb-8e80-4abc-93ba-67a21f83170c"), new Guid("e940cd56-6009-4fff-a9fa-2aa0c1d1df4d"), 0, "687215496-9", 86m, 2005, "Wise Guys", 5 },
                    { new Guid("4b56cd0e-b0bb-413e-a8c0-a67c6cf7ef1f"), new Guid("2db3fd3c-76ed-4f66-9561-9704b50c904d"), 0, "257463724-0", 92m, 2002, "Jackboots on Whitehall", 12 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("4b606c8f-d43f-4e9b-ab75-72db5e87be7e"), new Guid("ce6cca0b-4a61-4dcb-8f0d-f6f0d36df456"), 0, "373391628-X", 97m, 2008, "Ali G Indahouse", 2 },
                    { new Guid("4b99a13e-1a5b-40ac-a1ff-05ff2fac8ab6"), new Guid("bde49538-eadc-4a44-8565-cf835cb82819"), 0, "330112256-6", 19m, 2010, "Project Moon Base", 2 },
                    { new Guid("4babd9c3-9b43-457a-8560-43bea89c8340"), new Guid("60cc65d0-a79d-4980-b433-343607cd3112"), 1, "912369609-5", 93m, 1994, "Psycho II", 8 },
                    { new Guid("4bd5bb58-d4a2-45b8-af1b-29e63260d6e9"), new Guid("5380e8bf-636b-4486-9044-eb53527f2e05"), 0, "183622927-5", 19m, 1968, "Outskirts (Okraina)", 3 },
                    { new Guid("4bdb67dc-6ead-4a9a-b9fe-103d60608363"), new Guid("cdb9dfb7-70ab-4066-bf0a-a4efbccb1500"), 0, "969920385-4", 78m, 1985, "Flower Drum Song", 2 },
                    { new Guid("4bdbf7dc-6ead-4a9a-b9fe-103d60608363"), new Guid("1cb011e1-4010-48db-992f-0e990cdb0c14"), 1, "978-1098100964", 41m, 2022, "C# 9.0 in a Nutshell", 1 },
                    { new Guid("4c0cea4d-6191-4d31-a6d3-b854e60049a1"), new Guid("a95c8910-d83a-4869-a4cf-08ee55be3f05"), 0, "079061139-2", 54m, 1992, "Chronicle of the Years of Fire (Chronique des années de braise)", 10 },
                    { new Guid("4c2fdd0f-ef3b-4d75-96e6-8f207675467a"), new Guid("3c58eb92-fbd8-4b60-8565-eecde6a26a71"), 1, "940416192-6", 53m, 2007, "Angel", 11 },
                    { new Guid("4c3cd722-9a3f-4388-b94e-94a7d5bd0247"), new Guid("8b0997b9-5d4f-48d8-b9ac-7ea47e9ffdef"), 0, "154987265-6", 29m, 2000, "Raven. The", 9 },
                    { new Guid("4d06fa3d-c810-478d-a735-45404f3a2260"), new Guid("8222e14d-e58d-42f2-94f1-0f20706eb0ac"), 1, "370326297-4", 30m, 2006, "Librarian: Return to King Solomon's Mines. The", 2 },
                    { new Guid("4d44e30d-4a8a-421c-b36f-5030697911d8"), new Guid("e369fca0-2e05-447b-b86f-c322c81af86f"), 0, "275079588-5", 40m, 2004, "London After Midnight", 0 },
                    { new Guid("4d7b481b-3434-4032-9bee-32f79e7271c8"), new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"), 0, "164287752-2", 67m, 2001, "Suzanne's Career (La carrière de Suzanne)", 7 },
                    { new Guid("4d917442-592a-44ea-850f-c8446288d46c"), new Guid("b0c12556-4a63-4d58-8b36-c06a4bd04bb4"), 0, "548853808-9", 94m, 1990, "Baboona", 11 },
                    { new Guid("4d98db88-3d56-44c4-a291-7df408dad12e"), new Guid("936d84fc-1467-4857-979e-6908ec86a62f"), 1, "776436496-7", 74m, 2008, "Call Me Kuchu", 11 },
                    { new Guid("4db6432f-3b0d-4275-aff8-61a32b295555"), new Guid("fd9f2dda-7909-465c-b6f9-b93316a50bd9"), 1, "767092228-1", 3m, 2002, "Dickson Experimental Sound Film", 14 },
                    { new Guid("4dfae581-798c-486e-ab4c-8b18993cbb8f"), new Guid("1a43890f-a96f-4b0f-bef3-be5b12f574bb"), 0, "152315199-4", 23m, 1986, "Othello (Tragedy of Othello: The Moor of Venice. The)", 3 },
                    { new Guid("4e1dbde0-4171-4816-b06c-e2233f320542"), new Guid("eadec3b1-2ad4-4b78-86a8-d56dd9247e64"), 0, "787691651-1", 8m, 2009, "Gay Divorcee. The", 14 },
                    { new Guid("4e903f16-6d10-4807-8c9d-e1c90bfee622"), new Guid("1839b6d3-6a99-421d-b005-7e4bb9d8c01b"), 1, "535340792-X", 35m, 2010, "Children Who Chase Lost Voices from Deep Below (Hoshi o ou kodomo) (Journey to Agartha)", 3 },
                    { new Guid("4f2b8235-5cf5-45e2-94d4-ddec7ec87d9c"), new Guid("73a974f3-4c0a-4160-8832-631bdcf99123"), 1, "702243089-6", 28m, 1989, "La petite reine", 9 },
                    { new Guid("4f3294cf-87a6-462a-bf45-f3c40d7addcc"), new Guid("f3cc37bd-f9a5-49c3-88bf-ec360a245f6f"), 1, "374685074-6", 8m, 2005, "Bubba Ho-tep", 14 },
                    { new Guid("4f4bf2b3-65c3-4667-a3a0-9f15d58fafa6"), new Guid("8aaec912-0f85-4234-ab59-8b1a503684b6"), 0, "059617683-X", 29m, 2007, "Star Trek V: The Final Frontier", 6 },
                    { new Guid("4f6549d2-e36a-49c4-9a21-a62951d84445"), new Guid("9d863819-1a15-444a-9ba0-d32368d0a290"), 0, "817463022-8", 7m, 1999, "Change-Up. The", 12 },
                    { new Guid("4f6c6fa3-0786-4775-8fa1-ad0de40e0c37"), new Guid("14cdbcd0-aba0-4976-9935-3c320185257c"), 0, "289531630-9", 26m, 2006, "Joffrey: Mavericks of American Dance", 9 },
                    { new Guid("4f7a946b-c00a-48c7-acff-4084c66d8fad"), new Guid("5769ccb3-2d3a-4406-8ed5-74ea1f965053"), 1, "563296594-5", 32m, 1991, "Karthik Calling Karthik", 14 },
                    { new Guid("4fafea22-c24f-464a-8e2b-41c4902c3d51"), new Guid("f344d0a6-bd6e-41d2-8e8e-4ee6626cd34b"), 0, "250362257-7", 72m, 1970, "Inhuman Resources (Redd Inc.)", 2 },
                    { new Guid("4fb63107-da06-4d10-8655-d4099925de90"), new Guid("90fc885d-7fb1-46d0-8a1b-c77c9bd0dc58"), 0, "442457082-7", 37m, 1984, "Love and Other Catastrophes", 8 },
                    { new Guid("4fdf4a7e-7148-4159-8e44-4e20bd4fcddb"), new Guid("33de038c-80de-4beb-b44b-c6a129a9a2dc"), 1, "234464307-9", 61m, 1998, "Dirty", 0 },
                    { new Guid("5090a7f6-c9cf-4d07-9934-5efad19f1e31"), new Guid("f7781d83-6905-4865-aac2-ba841334fe0c"), 0, "668450981-X", 40m, 2010, "Hanzo the Razor: Sword of Justice (Goyôkiba)", 13 },
                    { new Guid("50f29f43-2adc-41c4-9cf5-535af58885fc"), new Guid("0a3f38b0-6c38-4a4c-b93f-92e97944e3b6"), 0, "722124383-2", 54m, 2000, "Soul Plane", 7 },
                    { new Guid("50fa4e5f-46cd-4b2d-a4ac-c757744dc864"), new Guid("66d8b486-0875-40cf-8227-d731fddc8694"), 0, "233850460-7", 62m, 2012, "American Ninja 4: The Annihilation", 1 },
                    { new Guid("512358ae-066d-483c-8c87-a58e4d183235"), new Guid("0177be2d-065e-4507-874c-82ce6135f402"), 0, "680613505-6", 71m, 1998, "Open Heart", 4 },
                    { new Guid("51320f1c-3655-4c8f-9480-347856ffb7c1"), new Guid("e80fd575-c9eb-408d-8f1d-cb9d434c7ea6"), 1, "061648713-4", 2m, 1997, "Vampire Bat. The", 10 },
                    { new Guid("515bcf9e-e3c2-4765-9cb1-0ea58a8a0144"), new Guid("8744a906-2952-4236-b56d-f60d81c02330"), 0, "223062722-8", 6m, 2004, "Cool School. The", 9 },
                    { new Guid("5165b1c9-760d-451a-b42f-07a75661a974"), new Guid("53433646-0e07-4145-bedb-0db50cb74707"), 0, "298768146-1", 22m, 2009, "Farewell to the King", 8 },
                    { new Guid("51793b75-3146-4df4-b321-95a7f6f64d5e"), new Guid("b6c36cb9-0939-417d-b2c9-2223332af34e"), 1, "751464420-2", 22m, 2005, "Mark Shoots First", 11 },
                    { new Guid("51a1c15d-36b9-457e-a8e7-f3d0804c8960"), new Guid("4ace9e98-1fd4-4e77-b8da-3c1f869cb6b2"), 0, "176104103-7", 75m, 1987, "Escape from New York", 2 },
                    { new Guid("51dd8846-2756-43f2-8d28-44f738547d26"), new Guid("0fc15f39-9ca1-45ef-9dc8-bc55ae19717a"), 1, "348199609-8", 43m, 2000, "Pride & Prejudice", 5 },
                    { new Guid("51ee8c5b-a632-45bf-b605-c44dd621b644"), new Guid("2a4361b4-782d-4a0e-8a50-1f9112da9434"), 1, "058406351-2", 83m, 1992, "State of Play", 8 },
                    { new Guid("527721c2-ba14-4207-86f5-11636321b19c"), new Guid("157466fa-afb7-4076-ad21-530717018e26"), 0, "676282050-6", 58m, 1998, "East Side Story", 11 },
                    { new Guid("528dab3d-4ed8-4e9f-ae3e-e93d0574d651"), new Guid("dbb45e0d-e5fc-462e-b783-62a2c2dc8d87"), 0, "137731060-4", 20m, 2008, "Up in Arms", 6 },
                    { new Guid("52f1df7e-563d-4312-9267-e037193a1e38"), new Guid("b30756ae-be0c-4f72-8e06-2d13237d55ca"), 0, "027425729-7", 81m, 1985, "Jesus of Montreal (Jésus de Montréal)", 9 },
                    { new Guid("52fc1caa-f04f-4db1-a606-3b62250ab881"), new Guid("de50ff19-01f2-49f1-9ea5-2e779b0486ac"), 0, "902440328-6", 71m, 2005, "Surviving Christmas", 5 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("538ac8b8-f963-495c-a483-6b3a3614f9e9"), new Guid("1cb011e1-4010-48db-992f-0e990cdb0c14"), 1, "580100529-3", 76m, 2009, "Golden Thread. The (Subarnarekha)", 14 },
                    { new Guid("53d13f75-c13c-468a-a2aa-548d4d2ae118"), new Guid("6b5226fe-b18e-4e81-a136-e5c8e6ad4f23"), 0, "134838655-X", 20m, 2006, "Elmer Gantry", 1 },
                    { new Guid("54941d72-f630-4cd3-8760-030dcae23c04"), new Guid("bec5d41c-ddfa-43b3-9d5f-ee594db919a6"), 0, "796755900-2", 46m, 1995, "Alexandra's Project", 14 },
                    { new Guid("54df09ee-6211-4f70-94ad-6c9ee6ea6fdf"), new Guid("88b01291-97a9-4c27-950c-40b66c115795"), 1, "183442705-3", 100m, 1998, "Babylon XX", 4 },
                    { new Guid("5570ae79-78b8-48a1-a6cb-de4a780759a2"), new Guid("bdb31640-a03f-4d73-bcb8-ca9f07c27385"), 1, "283908771-5", 62m, 2006, "Room in Rome (Habitación en Roma)", 3 },
                    { new Guid("5593e612-166c-44aa-ba3c-557ec841989b"), new Guid("aa1a2ded-0229-4f1a-ae8c-5f80d0cbee38"), 1, "255492145-8", 73m, 2002, "Jump Tomorrow", 12 },
                    { new Guid("55fa89c9-50d9-42a9-8318-6f7279daf533"), new Guid("dc7642e1-db94-4d35-b5e3-84706d0884af"), 1, "339514288-4", 91m, 2004, "Black", 13 },
                    { new Guid("560f1e56-cda6-4d73-95db-7d5af66976ac"), new Guid("2a4361b4-782d-4a0e-8a50-1f9112da9434"), 0, "592555082-X", 43m, 1998, "Mr Hublot", 4 },
                    { new Guid("5654f406-2574-47a2-b47a-dac9aac50605"), new Guid("a2f76f52-8aa5-4ce4-b11b-138586c1af09"), 1, "864939570-8", 49m, 2002, "Romeo and Juliet", 10 },
                    { new Guid("56a7e870-fc42-49e7-9760-42d2df4c4cf7"), new Guid("81de9bef-1643-4cb7-8700-10cb9b09cef4"), 1, "922929437-3", 61m, 1995, "Patience Stone. The", 0 },
                    { new Guid("5751bfd3-b4cc-4bbb-b314-0608cb6fad96"), new Guid("4b9f8008-3206-48fa-a09a-c1b641ccf4b5"), 0, "004179070-7", 69m, 1996, "Fugitives (Fugitivas)", 9 },
                    { new Guid("581d41a6-206a-4dec-a3b3-952b724bdbd0"), new Guid("1c698679-a452-4b49-b00c-0a7781948e64"), 0, "639537915-1", 42m, 2003, "Beowulf", 5 },
                    { new Guid("5863dae2-faf1-46d9-815c-ddcaba31dd07"), new Guid("1302068e-8d80-4358-8e25-160a6b4503b1"), 0, "785245851-3", 43m, 1999, "Victim", 4 },
                    { new Guid("58a0b26d-8971-4cf1-be7b-be6af73f2754"), new Guid("994545f1-93a4-4482-a9e1-98a76169206f"), 1, "695696349-3", 99m, 1993, "Alien Abduction", 14 },
                    { new Guid("58b00bbb-6d5f-44fe-aba3-c62d04a1d852"), new Guid("81a5b860-3cbf-42a8-948c-46e22d7d0d0b"), 1, "902332907-4", 76m, 1995, "Last Rites of Joe May. The", 10 },
                    { new Guid("58f51cc0-9faf-46ae-877d-377d1083aa83"), new Guid("5a431516-a853-4511-b84a-092c5e7a4fa7"), 1, "697972806-7", 69m, 2010, "Hamlet", 13 },
                    { new Guid("5910990c-cc94-47d6-9e92-69425f79a758"), new Guid("53c4b47d-9534-485f-a0ad-6a0c9cceba1a"), 1, "850142989-9", 80m, 2010, "Sacrifice (Zhao shi gu er)", 4 },
                    { new Guid("592d60aa-83bd-4f3f-b3e9-2179a8bb2e95"), new Guid("b443a348-9799-4c2b-9f05-95869e08f40d"), 0, "514986074-3", 97m, 2012, "Black Rain", 12 },
                    { new Guid("5959294e-2f19-428d-ac6e-729cfa193c0f"), new Guid("97b72887-c52f-4d19-ac99-6b772416e084"), 0, "179560814-5", 61m, 1992, "Craigslist Killer. The ", 6 },
                    { new Guid("5960a483-796c-451e-8a53-578db919de59"), new Guid("48352e11-cf84-4d45-98be-4c9795501413"), 0, "687421263-X", 84m, 2006, "Pulling Strings", 3 },
                    { new Guid("598ba175-3519-4a8d-9c94-5847ec6ae035"), new Guid("3bd9fb5b-8397-41a0-9705-c5d3e8ece4c6"), 0, "085327147-X", 91m, 1996, "Burrowing (Man tänker sitt)", 11 },
                    { new Guid("59cceef6-aa68-4a4c-bd7c-20dadc880bd1"), new Guid("af027d77-54e8-417e-b2b0-e40479c99b94"), 0, "959164280-6", 50m, 2012, "Batman and Robin", 14 },
                    { new Guid("59d9b05a-782b-4e94-a3ff-1bb6af4f0c71"), new Guid("349749c3-e70b-4fea-b33b-35b913726b2e"), 1, "025205425-3", 52m, 2001, "Zuzu Angel", 0 },
                    { new Guid("5a40d06a-cace-4856-ab1a-e54b139da056"), new Guid("1248c46b-9feb-4d57-99e2-8e6e5722dfd5"), 0, "488877860-4", 100m, 1994, "Traitor", 8 },
                    { new Guid("5a4d6c91-fe89-4511-a4b7-ab297b4c4cce"), new Guid("2a34e65f-7434-4e61-8409-bfd527d2b8b9"), 0, "310722767-6", 27m, 2005, "Cobra Verde", 3 },
                    { new Guid("5acc936e-c69a-4497-b3b6-62a4a5b1020f"), new Guid("f23e51a1-c7bc-48c0-ac59-1160a4ef636a"), 0, "468501000-0", 53m, 2009, "Baraka", 11 },
                    { new Guid("5b1b0057-62f1-461f-8246-308542f216cb"), new Guid("784b8758-1e5e-471c-a029-24b42a018a3b"), 0, "830618957-4", 27m, 1995, "Castle Keep", 8 },
                    { new Guid("5b3c1a51-ece4-4f33-ba6e-a5b256352f20"), new Guid("b0c354b9-70e3-4f31-a6f4-a3d1da30d4a7"), 1, "126656569-8", 91m, 2008, "Seven Years in Tibet", 5 },
                    { new Guid("5b61847f-c0d4-4399-90ec-cdb634153871"), new Guid("91ce4849-8394-4fd6-b4e0-22dba815f48e"), 1, "309631843-3", 15m, 2013, "Ai Weiwei: Never Sorry", 11 },
                    { new Guid("5b766194-a24b-4595-b561-c23a8fc7508d"), new Guid("794c30e1-5ab6-41c7-b562-0683c0b7875e"), 1, "047521619-9", 46m, 2008, "Hijacking Catastrophe: 9/11. Fear & the Selling of American Empire", 2 },
                    { new Guid("5be3abf4-9b49-4b42-a330-8c0711002062"), new Guid("767be4eb-dc82-4a86-9c72-9938f0c1a54a"), 0, "454991625-7", 75m, 2012, "Voodoo Tiger", 11 },
                    { new Guid("5c05a93b-21ca-41d8-a09f-8a193d1bf810"), new Guid("09399070-fd8f-4a0e-9d27-261fe7b3a288"), 1, "363992463-0", 12m, 2007, "Love. Money. Love", 14 },
                    { new Guid("5c881db1-20bb-4982-a7ea-dc8516920906"), new Guid("b7757b09-09fa-40cf-8ba0-09231500e6ac"), 0, "389891127-6", 54m, 1992, "In the Year of the Pig", 13 },
                    { new Guid("5cd58666-f6f4-48f3-94a9-dfe1afbb8b71"), new Guid("e5b35dcb-548d-45d2-93ba-41128094afab"), 0, "753666845-7", 92m, 1992, "Oldboy", 0 },
                    { new Guid("5d06b9f3-01f7-4915-9743-1163ba561841"), new Guid("06c4b13d-acd4-48a5-b197-f6ec2ddaad03"), 0, "738682658-3", 34m, 1996, "Little Drummer Boy. The", 7 },
                    { new Guid("5d14896e-0e97-42df-91e1-feb6934061c3"), new Guid("caced371-71f9-4c30-bee7-c57932a9e55f"), 0, "338204175-8", 68m, 2007, "Player. The", 14 },
                    { new Guid("5d6c6d94-9342-4ec9-bcf1-c3a142d94c85"), new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"), 1, "448106401-3", 32m, 2002, "Familia", 11 },
                    { new Guid("5d773525-966f-4a06-b079-f4ad420db2c5"), new Guid("8b97e58c-c963-4ff6-96fd-98165b7ddd57"), 0, "230434627-8", 16m, 1991, "Planet of Dinosaurs", 10 },
                    { new Guid("5dcd0c3e-673c-4098-adc1-42f593f88670"), new Guid("f8bb7e04-e493-45b0-b323-4db8818a4473"), 0, "848878219-5", 13m, 1974, "I Am", 8 },
                    { new Guid("5dd6c92a-ee5b-47af-a4cc-cebda1d7991c"), new Guid("532f0956-d9ac-48e0-9932-a552b774eac3"), 0, "614648340-0", 85m, 2010, "American Violet", 3 },
                    { new Guid("5ea72f70-5b37-44ff-a674-d55b5ab5a0fd"), new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"), 1, "124370634-1", 56m, 2006, "Payment Deferred", 8 },
                    { new Guid("5f1b78a9-9dc6-4acb-bdad-f8dc8ba0e9d5"), new Guid("ee8e3c8c-a3df-430b-8e07-98267892abe7"), 1, "577299318-6", 33m, 1993, "Farce of the Penguins", 4 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("5f3f4d2f-d815-435f-8dc0-7a210d578c24"), new Guid("ec4aa741-496b-4a52-822f-1099d218f328"), 0, "609284096-0", 5m, 2009, "Blue Collar Comedy Tour: The Movie", 12 },
                    { new Guid("5faf2d4f-3e98-4179-b42e-86da43cbb765"), new Guid("35a17d4c-3203-4643-b237-4578b56c5877"), 1, "321915595-2", 80m, 2007, "To Get to Heaven First You Have to Die (Bihisht faqat baroi murdagon)", 9 },
                    { new Guid("601d3ce3-12f5-4126-bc92-a3f945d8b9fa"), new Guid("44f1042a-a088-40ed-beb4-523704d4a286"), 0, "339998460-X", 71m, 1983, "Rabbit Test", 2 },
                    { new Guid("60345d14-8b0f-494a-af25-383c435bbb3d"), new Guid("fff80cde-6282-46a9-b2ad-9f92d546c8d3"), 0, "968018281-9", 77m, 2008, "Great Train Robbery. The (a.k.a. First Great Train Robbery. The)", 11 },
                    { new Guid("60464fdc-4068-4d68-aa0c-538d6ff20e7a"), new Guid("1a5d8925-407a-4ca7-bc00-66e78e78d0a1"), 0, "770127607-6", 97m, 1994, "Viva Cuba", 8 },
                    { new Guid("60a2e930-3177-4b83-a555-0017d38cd4cf"), new Guid("66d8b486-0875-40cf-8227-d731fddc8694"), 0, "734731557-3", 13m, 2010, "The Diary of a Teenage Girl", 3 },
                    { new Guid("60c2a218-6ef6-4202-ab80-8dc0a2a79b62"), new Guid("44f1042a-a088-40ed-beb4-523704d4a286"), 0, "999122219-7", 66m, 1997, "Third Wave. The (Tredje vågen. Den)", 7 },
                    { new Guid("60e4f31d-a470-49b1-9fb8-390b09fe11db"), new Guid("8a626998-9601-4e54-a607-3144cbc8c87f"), 1, "125330491-2", 44m, 2009, "Appleseed Alpha", 3 },
                    { new Guid("61381bd2-0529-436e-811a-69117c49207a"), new Guid("4fb98fcc-c5bd-4d8d-ac3f-7cabf3954ac8"), 1, "537000520-6", 22m, 1993, "Address Unknown (Suchwiin bulmyeong)", 2 },
                    { new Guid("621eedb1-81f7-4d75-9fa5-076e0bd65ff7"), new Guid("d8e0d053-6f19-4a44-9028-4353a001d71a"), 0, "073538130-5", 69m, 1994, "Suspect", 14 },
                    { new Guid("62865b32-e602-46e9-a321-54f2d0305ff4"), new Guid("4fb98fcc-c5bd-4d8d-ac3f-7cabf3954ac8"), 1, "931565794-2", 27m, 1993, "Place in the Sun. A (En plats i solen)", 5 },
                    { new Guid("62aad794-e24b-40eb-9d9c-839d8874f3d8"), new Guid("7b728c79-dc06-4871-aa28-aaad2a702afb"), 1, "951443930-9", 32m, 1999, "Smokin' Aces 2: Assassins' Ball", 6 },
                    { new Guid("62b8fc79-f3fe-4819-9a2f-5c62c2fef890"), new Guid("c7ce58f3-b2c6-4d5d-a91b-05c7e9ef5ae0"), 1, "458054116-2", 31m, 2006, "35 and Ticking", 9 },
                    { new Guid("630e1aa0-c75d-47a7-b142-fcf8064f68b5"), new Guid("da68975d-212e-451c-b657-5bdafeb21a46"), 0, "874559388-4", 19m, 2007, "Corvette Summer", 4 },
                    { new Guid("6365c638-9d71-498f-84ed-4ffaf2849d72"), new Guid("131b5100-5a51-4590-818b-b3512bfd116d"), 1, "512428150-2", 44m, 2006, "Bereavement", 8 },
                    { new Guid("63828545-4fda-43cf-b8e6-e3d23fdf996a"), new Guid("27c832f5-d940-4133-ac35-6349f6c4b59f"), 0, "417897556-0", 89m, 1998, "Dabangg 2", 7 },
                    { new Guid("639ec70f-4921-42d9-b6f4-e23d0b39cb7e"), new Guid("fbd14cbb-a961-4de7-b7e3-c40c2cf65528"), 0, "427738451-X", 88m, 2006, "Bohemian Life. The (La vie de bohème)", 3 },
                    { new Guid("64149ac4-c502-4691-90e2-0e8de7243be2"), new Guid("af027d77-54e8-417e-b2b0-e40479c99b94"), 0, "577033748-6", 10m, 2000, "Texas Chainsaw Massacre: The Beginning. The", 10 },
                    { new Guid("64440358-7a00-43ba-ab12-53a44afd5310"), new Guid("5d497ab4-fa1a-405e-9c7b-13d86705e5f5"), 0, "046389633-5", 78m, 1999, "Madagascar 3: Europe's Most Wanted", 1 },
                    { new Guid("6533e402-a0c2-42a1-bd74-584a1e40545e"), new Guid("b4b2e261-47f1-42fa-9571-439cb8214205"), 0, "152683260-7", 7m, 1985, "Curious George", 2 },
                    { new Guid("653cb903-8660-4d12-975c-13be75365f37"), new Guid("ef8cbeb8-2b81-4c0b-a651-8b5e485b29ed"), 1, "287980142-7", 34m, 1992, "Maiden's Cheek (To xylo vgike apo ton Paradeiso)", 6 },
                    { new Guid("659a8c58-d0f6-4c6f-ab40-33cd812dff61"), new Guid("59dd2652-6f89-428c-a402-bff4121455ab"), 0, "649934587-3", 60m, 1987, "Hunt for Red October. The", 3 },
                    { new Guid("65fff86a-6553-4288-a16b-8d3e391b9a1e"), new Guid("c1046597-72fa-4425-bbe4-1bd54f39436e"), 0, "813637180-6", 37m, 2003, "Bellissima", 1 },
                    { new Guid("6620c129-4582-490f-87a2-363b1ee9a91b"), new Guid("eba42403-dce5-470b-a1da-63687b6ed5f6"), 1, "814500294-X", 33m, 1999, "Chant of Jimmy Blacksmith. The", 5 },
                    { new Guid("6631ea21-596f-4703-8e52-c7f32f0ca8bb"), new Guid("341a5b3b-f616-4bec-a433-50a0b13065b8"), 0, "136860952-X", 27m, 2008, "Fighting Prince of Donegal. The", 7 },
                    { new Guid("6655a747-8ecd-4913-a4e8-410edd5a973e"), new Guid("ede20578-f3bb-4b60-aec8-208e6470772d"), 1, "300998134-1", 86m, 1993, "Kink", 13 },
                    { new Guid("669de602-f2ef-4580-a25a-f474dbb795d3"), new Guid("767be4eb-dc82-4a86-9c72-9938f0c1a54a"), 1, "035946483-1", 36m, 1994, "Flaming Star", 0 },
                    { new Guid("66dae181-9af9-4b98-a1e1-9813cece0383"), new Guid("bb7396ad-9f1f-4e73-bd22-2a465dc1d957"), 1, "545199865-5", 23m, 2003, "Ill-Fated Love (Doomed Love) (Amor de Perdição)", 12 },
                    { new Guid("670fbbe6-e15c-4715-8843-d255e0ff5426"), new Guid("22231497-c3c4-43c6-8764-e008fe5062dc"), 0, "455064693-4", 51m, 2004, "Groove Tube. The", 12 },
                    { new Guid("6719d3c9-11ee-4614-bb21-d39c3967a0d3"), new Guid("59416f28-e187-40ea-b26e-fc26dc0022ea"), 1, "394372389-5", 73m, 1992, "Angels in the Outfield", 9 },
                    { new Guid("676f9ec7-20ff-4287-8346-66b21c761c01"), new Guid("39c6d354-bbc8-4bfc-b956-57554d54af7d"), 1, "037098874-4", 60m, 2000, "Star Trek V: The Final Frontier", 14 },
                    { new Guid("67713314-29c0-4dc9-a6a7-f10411e760b5"), new Guid("a136d6b3-28a6-43b4-912a-7bd9c4fd48de"), 1, "450412298-7", 57m, 2002, "50 Children: The Rescue Mission of Mr. And Mrs. Kraus", 10 },
                    { new Guid("67922591-9945-4430-927d-8ec34d843fee"), new Guid("a163169f-2cae-4d36-a28c-dc3a3dece569"), 1, "418165107-X", 36m, 1992, "What Happens in Vegas...", 7 },
                    { new Guid("67a2f68a-db23-4735-9244-2a65347c9f4d"), new Guid("e1402f0a-6f80-4867-9fbe-1672924d80ee"), 0, "650777948-2", 80m, 1992, "Punk Syndrome. The (Kovasikajuttu)", 14 },
                    { new Guid("67bb0953-a4de-411f-ae18-4176fd5256a8"), new Guid("b8a88fec-cbca-408e-ae8f-46beccafa8f9"), 0, "690731236-0", 65m, 1998, "Merlusse", 4 },
                    { new Guid("67dfddce-5305-48a2-a7cb-1b93b92ae7d7"), new Guid("5f2c982d-53fd-4c4c-aaba-b79976b44c95"), 0, "665348172-7", 53m, 2010, "Devil. Probably. The (Diable probablement. Le)", 2 },
                    { new Guid("682a86aa-ee66-4d2c-925f-c1decae0ba79"), new Guid("e20ec806-ab19-45e5-a878-919cce82288f"), 0, "283614005-4", 16m, 2006, "Snow Angels", 6 },
                    { new Guid("6881d1a7-6b46-4da1-9ed7-56cddaaf467a"), new Guid("ee8f5d1f-564b-4c7f-afa7-9cd722d21fe9"), 1, "556906963-1", 7m, 2000, "American Werewolf in Paris. An", 12 },
                    { new Guid("69161cc7-32b0-4bce-906c-bd291f5f2c0a"), new Guid("b3d74b2b-99f2-4082-9d3d-e8ea53a6f7e6"), 0, "615700917-9", 25m, 2012, "Carrie", 0 },
                    { new Guid("691d48eb-02e8-4c15-8a3a-2cc5d2de402b"), new Guid("ea899a8e-0e39-4b1f-9e0b-6eb5934aca53"), 0, "057100706-6", 45m, 1997, "Torpedo Run", 13 },
                    { new Guid("69897ffe-5f86-4773-8d3a-3493eeee0335"), new Guid("e3e89c5e-d1e3-4e08-9e9f-2e3d6498196a"), 0, "103702125-8", 46m, 1990, "Hell (L'enfer)", 14 },
                    { new Guid("6a003b36-04e6-4db6-8f5a-0b00d56db593"), new Guid("ff733029-b575-43d4-b993-ffc9e0cf1feb"), 0, "786488326-5", 91m, 2002, "Two Girls and a Sailor", 10 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("6a30ca29-2332-40a8-bb8f-9e314eac39b2"), new Guid("6d97826a-b01a-483c-ad18-7b3b3da99f01"), 1, "757405546-7", 72m, 2004, "Teenage Mutant Ninja Turtles", 7 },
                    { new Guid("6ad44d24-d752-429d-b192-cf855433fb04"), new Guid("3509cb67-69dc-4549-8169-e4d6b06df798"), 0, "675613858-8", 51m, 2008, "Sex and Fury (Furyô anego den: Inoshika Ochô)", 14 },
                    { new Guid("6b118e92-79f4-47d5-8ece-1f9d4317efbb"), new Guid("e9829cd2-b11e-4e81-8920-df37bec75c68"), 1, "118694175-8", 60m, 1995, "Blonde Ambition", 1 },
                    { new Guid("6b1e3512-c053-4ee0-a80f-02514e3129e3"), new Guid("ce84a6d9-f560-45fb-ac5d-fe2d3b8f72ac"), 0, "361562843-8", 37m, 1990, "Judgement Day", 13 },
                    { new Guid("6b663829-eb85-414d-bf01-cc442f445264"), new Guid("3642ed63-03e4-4012-a8e9-fc206a02681d"), 1, "772646245-0", 78m, 1970, "Eila. Rampe and Likka", 1 },
                    { new Guid("6bdfc3dc-505e-4bfb-9a11-d8245f919d41"), new Guid("67f34eac-49bc-4026-9284-5c883217d957"), 1, "690732082-7", 76m, 1999, "Howling IV: The Original Nightmare", 7 },
                    { new Guid("6c044bb9-8569-476e-925a-d164f7006267"), new Guid("c30d297c-daed-48ef-a4f1-8950291e56ff"), 1, "798801295-9", 20m, 2006, "Zhou Yu's Train (Zhou Yu de huo che)", 3 },
                    { new Guid("6cf18df6-5540-44db-9cbd-bb0f22a826ef"), new Guid("7b728c79-dc06-4871-aa28-aaad2a702afb"), 1, "090873273-2", 38m, 1996, "Stakeout", 4 },
                    { new Guid("6d01bae0-dbda-4a26-8779-bef25f3aead0"), new Guid("0d685706-c9a5-412c-b296-4e4f99d25500"), 0, "760737372-1", 70m, 2004, "Funny Games U.S.", 2 },
                    { new Guid("6d0801e8-1d1a-404d-b5eb-e5a17f1972b6"), new Guid("0ae2a8e7-e3d7-40d2-b5de-f8827665d132"), 1, "304327360-5", 100m, 2007, "Busses Roar (Buses Roar)", 6 },
                    { new Guid("6d5b0dc2-0a00-4035-923c-e5bae2b13873"), new Guid("11ecfdac-364e-4f75-b894-e9f5472c2fa4"), 0, "903159122-X", 46m, 1995, "My Giant", 9 },
                    { new Guid("6dd4611b-235e-43c8-828d-2f1963f9382b"), new Guid("9f928a8b-4416-48ec-a03f-3c6df811724b"), 1, "375898408-4", 81m, 1993, "Wildflowers", 10 },
                    { new Guid("6ddfba3a-f6aa-4eaa-9344-b638dacc92f5"), new Guid("697085a0-dcc7-4d69-988c-6bb0e1ec1880"), 0, "910205973-8", 39m, 1996, "All About Steve", 2 },
                    { new Guid("6de27734-e6aa-4bc1-83da-9c0629dd5294"), new Guid("020c5e81-7f10-431e-9c35-a9529f348081"), 1, "870260819-7", 6m, 2004, "Instructions Not Included (No se Aceptan Devoluciones)", 13 },
                    { new Guid("6e284c94-a48c-469a-bd6a-d0e6f558e86b"), new Guid("95b96ad3-3c42-4563-a5fa-7642b9b9a706"), 1, "596344517-5", 24m, 1999, "Decoy Bride. The", 9 },
                    { new Guid("6e3c5a3c-bd76-47df-a1bb-57b7027c91a3"), new Guid("bb7396ad-9f1f-4e73-bd22-2a465dc1d957"), 1, "646163386-3", 48m, 1998, "Analyze That", 2 },
                    { new Guid("6ee0ecca-399f-489c-ab83-423334e4d03c"), new Guid("c95a0c28-04b3-416b-8315-533b24625c62"), 1, "092282994-2", 44m, 2003, "Babette Goes to War", 4 },
                    { new Guid("6eec0b9c-cd39-49fd-9396-2ea76c1a25e3"), new Guid("d1366bc9-d394-4617-a7da-855969af4d93"), 1, "091056216-4", 78m, 1992, "Mummy. The", 9 },
                    { new Guid("6effca11-84a2-43f6-9186-0c09c9444b6f"), new Guid("439741a8-1697-4aec-92a1-1dbf2cb3ea18"), 1, "173502997-1", 31m, 1988, "When I Grow Up. I'll Be a Kangaroo (Kad porastem bicu Kengur)", 10 },
                    { new Guid("6f3cc12d-2e2a-4e6c-a317-874ea27dd7cd"), new Guid("1cdafbde-7fb3-4e75-91c9-c2b69ccdc54d"), 1, "554020185-X", 91m, 2002, "Ringu 0: Bâsudei", 0 },
                    { new Guid("6ff211ca-7f36-4517-acc1-92879bbf18e9"), new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"), 0, "472824965-4", 51m, 2007, "House I Live In. The", 3 },
                    { new Guid("704a0b58-e420-4772-af3c-2ea64f3cd00d"), new Guid("87fe015d-8af6-45b2-bc90-7fcd7e5a4d68"), 1, "958688726-X", 78m, 1971, "Mercury Rising", 3 },
                    { new Guid("7076840a-23e3-437a-9425-3bafc5877f3c"), new Guid("a5496f8d-e857-4ea5-bf27-8e7b533bb0e4"), 0, "543178447-1", 78m, 2005, "Dara Ó Briain Talks Funny: Live in London", 6 },
                    { new Guid("709d7ea6-1d8d-48e8-97de-3e456b0c251a"), new Guid("8c3cb427-b57f-4700-aee0-42ab7e62cb98"), 0, "067799304-8", 2m, 1992, "Red Scorpion", 5 },
                    { new Guid("70ef3a77-1fc0-45a9-a007-94084f2403c4"), new Guid("27979bf2-f76e-43b6-b1a3-00f018bc28f9"), 0, "846461187-0", 83m, 1960, "Israeli Intelligence (Hamosad Hasagur)", 10 },
                    { new Guid("716dcea8-cf5b-4636-ac4d-ba90cf66520c"), new Guid("b1f1c10e-7853-47cd-9718-517038b33496"), 0, "649701629-5", 68m, 2000, "Anna: 6-18 (Anna: Ot shesti do vosemnadtsati)", 2 },
                    { new Guid("7181c7b7-cf97-409f-ac68-4cca531aeaa2"), new Guid("6ec740d7-b9cf-46a0-8c42-2c83d3f030b4"), 0, "001910869-9", 13m, 1993, "Blood. Guts. Bullets and Octane", 2 },
                    { new Guid("72103dd6-a36e-46bb-8122-9ef0057cd52f"), new Guid("3658895a-82dc-4179-94ef-700fdb6d98de"), 1, "014399790-4", 54m, 2006, "Birdcage Inn (Paran daemun)", 3 },
                    { new Guid("72e8fe9e-49ca-4676-95a6-e934a91cac29"), new Guid("15a49315-552f-4f6a-9f25-001a5f13ce07"), 1, "737441476-5", 52m, 1998, "Bridesmaid. The (Demoiselle d'honneur. La)", 12 },
                    { new Guid("72ff7892-4770-43a0-ae83-06bcb94eecda"), new Guid("f1e93272-da66-4117-b84f-21a4c154ee71"), 1, "081106938-9", 79m, 1987, "Eddie Murphy Delirious", 8 },
                    { new Guid("730462d1-cfb2-468d-a008-a057dd1188aa"), new Guid("3bcc229e-c552-40d7-b152-9c42eb013fe7"), 1, "889703253-2", 65m, 2002, "Deal. The", 1 },
                    { new Guid("730b67e5-6fc9-42be-8783-c251d45a3259"), new Guid("61df6d79-e875-4971-b333-787a5bc6043c"), 1, "814110499-3", 75m, 2009, "Elstree Calling", 5 },
                    { new Guid("7378cf72-3ff1-4f27-a590-c93c4309cc57"), new Guid("9fad2647-6ef9-45d0-9a84-7b97aa226c7e"), 0, "251449229-7", 12m, 1999, "Operation Ganymed", 6 },
                    { new Guid("7378f0d2-4a5c-45d8-9d2c-8410ee3aa205"), new Guid("5ae767a4-63a4-4b2e-b342-857fa81f8377"), 0, "448321852-2", 46m, 2001, "Harriet the Spy", 3 },
                    { new Guid("737dac8e-0ac6-4feb-aea5-51af75f7b2fc"), new Guid("f3a7d97c-16be-4402-8c8a-978a85d6b254"), 0, "332140259-9", 27m, 1998, "The Fabulous Baron Munchausen", 3 },
                    { new Guid("7384251d-dd11-4be8-9fd2-b9efb0704b28"), new Guid("e3254490-0e4e-4b4c-b6ef-4616256790a4"), 1, "586216020-5", 73m, 1988, "Panda! Go Panda! Rainy Day Circus", 0 },
                    { new Guid("73b4e285-5b12-49e6-acdc-0554bc85d93a"), new Guid("f1e93272-da66-4117-b84f-21a4c154ee71"), 0, "754093221-X", 24m, 2010, "Hardcore", 4 },
                    { new Guid("73c8b75c-779a-4c71-a2e2-c97dc8a2c33e"), new Guid("aa1a2ded-0229-4f1a-ae8c-5f80d0cbee38"), 0, "227772868-3", 53m, 2010, "Ambush (Rukajärven tie)", 10 },
                    { new Guid("74855039-e23c-42e5-8ef1-aabab72b55aa"), new Guid("add8b096-6816-4e92-a968-2b4ddd795f1c"), 0, "857643949-2", 83m, 1996, "Camarón: When Flamenco Became Legend", 6 },
                    { new Guid("74a6c4ae-7b44-4d9b-a17d-e12c58e6bcd8"), new Guid("abda4420-2bce-41c4-afbc-17fe3add6235"), 0, "501627195-X", 2m, 2009, "Alien Nation: Millennium", 5 },
                    { new Guid("74b5a96d-f775-45ed-9f41-1a71d4326e9f"), new Guid("ec431d1f-308a-49a9-88ef-4f97349a9a6a"), 1, "800749127-9", 31m, 1990, "Machete Kills (Machete 2)", 14 },
                    { new Guid("74b5dfef-b9d5-425d-bf9c-b10862ddb4ed"), new Guid("b6492e83-2cc9-4841-828b-4e195b88325e"), 0, "570591254-4", 75m, 2004, "Single Shot. A", 8 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("74d0fa83-be01-4760-88de-5b558b0b53d6"), new Guid("83aa75c9-fafe-43e2-adf7-5e0acb1977e7"), 0, "598694630-8", 100m, 1994, "Wonderful and Loved by All (Underbar och älskad av alla)", 10 },
                    { new Guid("74f29667-5299-4c81-aa97-cb3bb7fe8139"), new Guid("b0bcd89e-c1a5-4178-a26d-71439538c3f4"), 0, "310294346-2", 22m, 2003, "Ghoulies", 1 },
                    { new Guid("754e8621-aec4-44d8-a3c8-21c7da313cd3"), new Guid("232f5d75-8488-447f-8b6a-8de60c3673af"), 0, "565076141-8", 5m, 2008, "Mission Bloody Mary", 4 },
                    { new Guid("7584c97b-d702-4db1-ae1c-b15d14a5e7d4"), new Guid("fa9a2f64-0908-49c8-8afe-d2fc45a83df4"), 0, "453023011-2", 98m, 2006, "Mexican Hayride", 6 },
                    { new Guid("75d79c16-d8de-4843-923f-2d63cc745566"), new Guid("ec266772-d14c-4450-a84f-4425483a41f4"), 0, "257511124-2", 49m, 2007, "Utopia", 11 },
                    { new Guid("7638c5e5-c1c4-426c-9e17-0d3610194624"), new Guid("8744a906-2952-4236-b56d-f60d81c02330"), 1, "538467088-6", 40m, 1991, "Seven Years in Tibet", 0 },
                    { new Guid("76730646-59af-4926-b475-532023f8bd46"), new Guid("dc08d55d-bfc3-458b-8ad7-3bd5e9e9d7da"), 0, "353172900-4", 55m, 2010, "Getting It Right", 8 },
                    { new Guid("76a4f827-7687-4ff0-aee9-12508bb1c36b"), new Guid("37fad513-a1b0-4330-ba5c-37b735bcbeff"), 0, "495303060-5", 73m, 1998, "Skyscraper Souls", 7 },
                    { new Guid("77615d5d-ae66-46aa-8ea9-01e329d258fe"), new Guid("44f1042a-a088-40ed-beb4-523704d4a286"), 0, "237125739-7", 37m, 2012, "American Tail: Fievel Goes West. An", 10 },
                    { new Guid("77b1e2a5-35ca-4dc2-92dc-2f690ddbf82c"), new Guid("1fd4846d-b277-4efe-b9af-04ff8d7e8697"), 0, "651080534-0", 99m, 1994, "Thawing Out (La fonte des neiges) ", 13 },
                    { new Guid("77b6a896-a5e5-47bf-b9ac-434850afd3a6"), new Guid("19fe27c7-6493-4426-9659-576f5fd3f56e"), 1, "713383423-5", 78m, 1968, "Julie Johnson", 0 },
                    { new Guid("77cb14fc-16fe-42a7-b941-09c808c483af"), new Guid("325fe720-a257-4bb1-9e29-eb8d8a67965f"), 1, "235144847-2", 10m, 1994, "Table No.21", 6 },
                    { new Guid("77e077e1-4909-4237-94a6-ec0ccebf89c7"), new Guid("85f36fb3-82f1-4955-9850-77c4b336cc5e"), 0, "231083906-X", 96m, 1995, "Happy We (Två killar och en tjej)", 3 },
                    { new Guid("77f4554f-8d13-4c7f-a897-1e799407204e"), new Guid("64d755cc-f6d2-44dd-a7c4-9e55610a81c4"), 1, "594762763-9", 12m, 1996, "1990: The Bronx Warriors (1990: I guerrieri del Bronx)", 1 },
                    { new Guid("77fbb415-c2d7-4b4f-8b5c-e68ae67a5ccb"), new Guid("6ed19bdd-2cb4-43d9-b830-420cfbe2c180"), 1, "427171070-9", 13m, 2006, "Hotel Hell Vacation", 5 },
                    { new Guid("781ca1ad-1444-4b14-ba6e-9595d7c60d85"), new Guid("5aef495f-a566-46f1-aae2-66d7c497630e"), 1, "400128478-2", 40m, 1998, "Ménage (Tenue de soirée)", 7 },
                    { new Guid("7826f16c-0d0b-4f6d-9831-92376c039438"), new Guid("2f9afb16-d08e-4cb5-9b1e-69a0a4d55491"), 1, "629707761-4", 57m, 1992, "Scattered Clouds (Midaregumo)", 4 },
                    { new Guid("787bfda6-d9b4-4f89-9db2-454a212d1355"), new Guid("4fb98fcc-c5bd-4d8d-ac3f-7cabf3954ac8"), 0, "329576993-1", 59m, 1995, "Breakfast on Pluto", 9 },
                    { new Guid("78dafc67-1665-4abd-bcc9-769f56b968af"), new Guid("0ecb8f16-d362-47aa-bd8f-aba5cb67891e"), 1, "329777455-X", 31m, 2005, "Loose Cannons (Mine vaganti)", 2 },
                    { new Guid("78e64e8c-fdea-448a-ac64-3dde32317134"), new Guid("95b96ad3-3c42-4563-a5fa-7642b9b9a706"), 1, "224309655-2", 8m, 2004, "Bebe's Kids", 7 },
                    { new Guid("792213ff-99b1-4519-93ef-0416a417f981"), new Guid("cb2bbd63-0980-4ee8-beab-c0f7ab872383"), 1, "052063509-4", 77m, 1997, "Walkabout", 14 },
                    { new Guid("79486d75-f890-40b2-98bb-f6b5c0b8b59d"), new Guid("2911d037-b839-4428-8fcc-e15ea3474c7e"), 0, "756759054-9", 52m, 2012, "Aftermath: Population Zero", 3 },
                    { new Guid("79638971-a257-467b-8159-ed74828a2b8a"), new Guid("22094962-1789-45e3-8249-c6859c8fbcad"), 1, "697836202-6", 9m, 2007, "Dinner Guest. The (L'invité)", 12 },
                    { new Guid("79bed9a6-4d82-4146-90e7-e46dcf0ec243"), new Guid("a6e9a2da-b223-44d9-be33-1d1f3ef18b2e"), 0, "381298316-8", 44m, 1992, "One Night with the King", 14 },
                    { new Guid("79c2b8ba-3d9f-4cef-973f-fddea7cbcd43"), new Guid("a59d0611-a60b-479c-b95e-d49076a61694"), 1, "881136404-3", 39m, 1993, "Holy Land. The", 2 },
                    { new Guid("7a0b748a-8669-4239-98f0-f5cbfae46035"), new Guid("ea0c9879-b19b-4e47-8879-1b1ac5b9536b"), 0, "363498640-9", 73m, 1997, "Painted Skin", 10 },
                    { new Guid("7a1cdaca-7828-45b7-9674-8c51675302a8"), new Guid("91a2908f-52e1-4282-87f6-c740f6497403"), 0, "815442408-8", 90m, 2000, "Untouchables. The", 3 },
                    { new Guid("7a768c47-f63c-429c-818a-08697dd41fc0"), new Guid("ceab4e73-213b-494e-b74c-4dc371eff1aa"), 0, "361182872-6", 24m, 1987, "Hunk", 10 },
                    { new Guid("7b1a8f0e-f0cf-4956-b5d0-255d24071e47"), new Guid("3db30207-0111-4b34-8697-15e686b8ab44"), 1, "648090620-9", 93m, 2010, "Goodbye World", 0 },
                    { new Guid("7bb900ef-b2f3-4d78-86ca-d3b35a07dbf5"), new Guid("a37d1a36-2bfe-4673-9811-5337c1231fd2"), 1, "131202032-6", 63m, 2006, "All Over Me", 13 },
                    { new Guid("7bc6e961-c011-4b61-baac-98cdbf37cf73"), new Guid("bedc959a-ea91-4220-8b7e-71dff6e099bc"), 0, "995119552-0", 56m, 2005, "Another 48 Hrs.", 2 },
                    { new Guid("7c1c697e-a543-4e69-9c89-bb678334120c"), new Guid("00d9a9b2-5d08-4bd3-b854-28228db24210"), 0, "448344006-3", 63m, 1994, "Witch's Night Out", 1 },
                    { new Guid("7c23702e-dec7-45a6-9d0d-2a395cb04378"), new Guid("5eba6825-745d-4bf9-ae68-5216f0e7d617"), 1, "256536910-7", 33m, 2012, "Undercover Brother", 12 },
                    { new Guid("7c2517da-c26c-4a26-a07d-d0e844e90251"), new Guid("a62532c0-0ac2-4680-bfce-462ba0a5a924"), 1, "047497638-6", 72m, 2000, "Beyond the Gates of Splendor", 9 },
                    { new Guid("7ca49834-d4cc-4cfb-ac9a-179668aceb0f"), new Guid("64fe9ab9-6403-43a8-a1d7-0cfc98c6657f"), 1, "729586068-1", 65m, 2004, "It Follows", 8 },
                    { new Guid("7cb417fa-5338-4446-9e72-54fb33b6b642"), new Guid("e28f015d-7c7c-4811-9f57-bedbbccc1cbd"), 1, "663801940-6", 71m, 1990, "Helvetica", 8 },
                    { new Guid("7d0ace3b-9685-4654-87fa-d6c6883368a2"), new Guid("8af7a947-e742-4f20-93c1-56c546a3aed2"), 1, "666958827-5", 53m, 1996, "At the River I Stand", 1 },
                    { new Guid("7d1e01e4-0e3b-45a7-b60d-b55244070521"), new Guid("a5496f8d-e857-4ea5-bf27-8e7b533bb0e4"), 1, "285693051-4", 16m, 1999, "Carol for Another Christmas", 12 },
                    { new Guid("7d3fdf61-8091-41e2-9ead-eb6a61c7cc98"), new Guid("3514789e-51e1-4e7e-9cd3-7ca5a3896a00"), 0, "462645450-X", 81m, 2006, "Seven Swords (Chat gim)", 0 },
                    { new Guid("7d4eede7-6c8d-4696-972b-2314cd2fb272"), new Guid("794c30e1-5ab6-41c7-b562-0683c0b7875e"), 0, "338741425-0", 45m, 1990, "Tell No One (Ne le dis à personne)", 9 },
                    { new Guid("7d50adc3-22f7-4bb2-96e9-81bbcd84fd83"), new Guid("3de133f0-d8f0-4114-a2f5-83c51e166f2a"), 0, "743939457-7", 39m, 1999, "Paris Trout", 4 },
                    { new Guid("7d8d1481-70ce-4301-8156-1285a0c7a203"), new Guid("aafbe801-5353-4a9c-88b9-6844e8211e62"), 1, "810138035-3", 4m, 1994, "Harmonists. The", 8 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("7d8f4819-6b7d-4671-ac89-b780f591b1f0"), new Guid("056cf996-5b34-438f-a9d9-e6d8d32bc285"), 0, "889687612-5", 3m, 2010, "Jönssonligan får guldfeber", 2 },
                    { new Guid("7e22d526-9d25-4aaa-967c-814a0f9959d8"), new Guid("7745a287-443b-411e-85a1-97ca5a4ecd48"), 0, "180495003-3", 79m, 2001, "Potiche", 9 },
                    { new Guid("7e4bbd3c-9831-4a4e-8c00-6ba1a090dcf6"), new Guid("04bac9d9-63bd-45c5-8499-dbf7fa5e0f31"), 0, "133386688-7", 45m, 2006, "Adrift (À Deriva)", 12 },
                    { new Guid("7e669fc2-35b1-46bc-ade7-202ac5e8fdd9"), new Guid("4452c6c0-a983-4da0-bcc5-181563d50429"), 1, "788245536-9", 4m, 1990, "Black Girl (La noire de...)", 2 },
                    { new Guid("7e77ee23-7cca-41d6-9a6d-cd0bea4f6eb5"), new Guid("df3a8976-6ee1-4af4-88b3-4592271df72e"), 1, "359491178-0", 55m, 2012, "Masks (Masques)", 12 },
                    { new Guid("7f70a7ca-666e-4a81-bd84-c0a17bb4d4a2"), new Guid("3cae8445-8772-461b-955f-4e2533a663da"), 1, "574021822-5", 50m, 2007, "Clouds of May (Mayis sikintisi)", 1 },
                    { new Guid("80114622-715c-404c-ba66-49114a77fe97"), new Guid("de50ff19-01f2-49f1-9ea5-2e779b0486ac"), 1, "950696746-6", 58m, 1997, "The Devil Thumbs a Ride", 8 },
                    { new Guid("80652c6d-7d7f-4ca8-92ef-cf25e09a07b1"), new Guid("e61caebe-1e1d-444e-9273-3d6cc9b00293"), 0, "301301552-7", 55m, 2012, "Long Kiss Goodnight. The", 13 },
                    { new Guid("80756613-b5b3-4151-b69f-c4d33e152404"), new Guid("5cf81ef7-3334-4fd4-b443-da781fa1bfe9"), 0, "050336927-6", 81m, 1994, "9 1/2 Weeks (Nine 1/2 Weeks)", 6 },
                    { new Guid("8110132d-eee2-4516-a52b-b4c92c27b656"), new Guid("f219697e-0a19-466d-9afe-1bc6802dbb6a"), 1, "539420907-3", 87m, 2010, "Gallowwalkers", 1 },
                    { new Guid("8229afa3-7eea-4dbe-99ca-4cc0472a63e0"), new Guid("73bfa88b-6da0-41d0-8e7f-2b344dcc75b2"), 1, "833942268-5", 67m, 2004, "Enemies: A Love Story", 0 },
                    { new Guid("825177e4-7865-47b4-bebd-434b0dad971c"), new Guid("9c06d170-1d58-4df3-bed9-072b992f086e"), 0, "793753521-0", 84m, 2008, "Crack-Up", 12 },
                    { new Guid("8251898a-e74b-478c-b635-bd6cebcb320c"), new Guid("0085af40-772e-43d4-a744-781e8ac7ade1"), 1, "835107754-2", 68m, 1992, "Beasts of the Southern Wild", 3 },
                    { new Guid("82665894-2072-47e0-a67e-178f99b3dab9"), new Guid("6fcb4eaa-f56c-4565-99ae-6c2d42b448ce"), 0, "909984122-1", 87m, 2007, "London", 14 },
                    { new Guid("82678d2f-9fe6-413d-8869-b6d7920705c2"), new Guid("91cf8bd5-b2a7-49a9-8166-95b73559ad5a"), 1, "380975325-4", 34m, 2007, "Canciones de amor en Lolita's Club", 5 },
                    { new Guid("82aaff03-4fd7-4edc-8782-123ce2e0c46f"), new Guid("5ae767a4-63a4-4b2e-b342-857fa81f8377"), 0, "226532219-9", 47m, 2003, "Bandolero!", 0 },
                    { new Guid("83179c48-b056-419a-97db-734c33eafa90"), new Guid("a5359350-4d68-4343-be09-afe4b4f0e42d"), 1, "496973764-9", 48m, 2006, "Flame and the Arrow. The", 10 },
                    { new Guid("838f2277-0f56-481a-b6a8-34d5e64ccef8"), new Guid("90fc885d-7fb1-46d0-8a1b-c77c9bd0dc58"), 0, "669060269-9", 38m, 2006, "The Fool", 9 },
                    { new Guid("841e4c5e-11fc-4ac1-85eb-bfbb4833785c"), new Guid("7177638d-3369-4b4d-b812-408159198a4f"), 1, "218714345-7", 32m, 1994, "New Leaf. A", 4 },
                    { new Guid("843edd4e-1d1d-40a3-b948-46892715d182"), new Guid("09c7e67f-0a4d-49ae-9267-ec26fe174214"), 0, "232729641-2", 79m, 2002, "Phenomena (a.k.a. Creepers)", 10 },
                    { new Guid("84508837-4b5d-4f71-ab40-b2d605095d39"), new Guid("0f417ffa-764e-44c1-b64f-85d8a7bef5db"), 0, "501451383-2", 28m, 1995, "C.H.O.M.P.S.", 9 },
                    { new Guid("846e7dea-1aae-49e7-b04c-33842ec0f4f1"), new Guid("7177638d-3369-4b4d-b812-408159198a4f"), 1, "546686000-X", 63m, 2004, "Child Bride", 14 },
                    { new Guid("84754c79-61d4-42e9-bfdc-d4eb0094e80a"), new Guid("c56f9194-091d-4166-ba46-b6d9cbfb608f"), 1, "881837020-0", 49m, 2008, "Haunted Honeymoon", 5 },
                    { new Guid("84ff9062-60ed-4712-9e81-7f39d0d90914"), new Guid("c56f9194-091d-4166-ba46-b6d9cbfb608f"), 0, "587348243-8", 5m, 1985, "Quickie. The", 13 },
                    { new Guid("860cce53-4c00-459b-b33a-a6ec9abda00c"), new Guid("0fc15f39-9ca1-45ef-9dc8-bc55ae19717a"), 0, "378646003-5", 85m, 2006, "Hiding Out", 11 },
                    { new Guid("862f68c8-732e-4d3f-9699-f8850686d205"), new Guid("f48e6883-2966-4822-8433-b18d619808ea"), 1, "047925179-7", 46m, 1988, "U Turn", 0 },
                    { new Guid("865a8627-8057-4b76-a17e-59c4d28ab4a4"), new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"), 1, "393987886-3", 99m, 2000, "Herbie Goes to Monte Carlo", 5 },
                    { new Guid("87150a28-be3a-4517-adb3-e1d511b0be53"), new Guid("8736b406-20a0-431a-aa2c-69b69fe7f7a4"), 0, "541866436-0", 77m, 1999, "I'm Starting From Three (Ricomincio da Tre)", 1 },
                    { new Guid("873e2828-3036-4770-9681-300ba7af91fa"), new Guid("7177638d-3369-4b4d-b812-408159198a4f"), 0, "568150415-8", 66m, 2006, "Room 666 (Chambre 666)", 11 },
                    { new Guid("87878b25-ac0a-48b2-bcbc-e82d716ca8a4"), new Guid("523558b3-2f92-4869-85d6-99d47981492c"), 1, "833302749-0", 11m, 2003, "Far Cry", 7 },
                    { new Guid("87a7e4e8-0f0c-447c-8c94-c873b5ada7a9"), new Guid("27f5d1db-4c36-40ac-bbc2-abf4ff04c750"), 0, "572505859-X", 71m, 2012, "Rudo y Cursi (Rough and Vulgar)", 7 },
                    { new Guid("87d74207-3d61-47dd-926d-7c1e9fa7e2e8"), new Guid("90b53bcd-c664-4424-870e-f26a379f38fc"), 1, "030519447-X", 65m, 2012, "President's Man. The", 0 },
                    { new Guid("87f5bcc8-31f6-41c7-9105-fd100ca778cb"), new Guid("3de047cf-aa52-4347-be26-027bd8ee3bc5"), 1, "520469188-X", 12m, 1993, "Day in the Country. A (Partie de campagne)", 9 },
                    { new Guid("880a3cb8-d016-4f24-80dd-ac45bcf87ab5"), new Guid("267cbc06-0ea5-4809-81e6-fd425fabc167"), 0, "915762136-5", 20m, 1988, "Chance", 2 },
                    { new Guid("88880a82-9141-4a7a-9c06-feaecb5e7477"), new Guid("b294c6c8-d7b7-424c-a33b-2be6ebc9f87a"), 0, "599004655-3", 63m, 1998, "Separation. A (Jodaeiye Nader az Simin)", 4 },
                    { new Guid("88f7d7bf-ba00-4baa-8073-128d990d73ef"), new Guid("fbbffb5e-56cf-44cd-815a-d1a00a0eafa9"), 1, "118210693-5", 40m, 1992, "Your Friends and Neighbors", 2 },
                    { new Guid("897939c5-203e-4e6b-9dd5-8b9602208afe"), new Guid("9ea07d3d-fb8c-4593-a762-ed8f0ed73b5a"), 0, "149053027-4", 75m, 1968, "Shut Up and Play the Hits", 11 },
                    { new Guid("898cd88b-3d38-407b-ba03-7e5a3ab1eb7a"), new Guid("f27a9091-2656-4dab-bea3-4053184a42d3"), 1, "603934935-2", 36m, 2004, "25 Watts", 11 },
                    { new Guid("89b3f845-0292-4791-831b-f623177dfb03"), new Guid("c7739201-0190-4f2d-80d9-ddc77ccbb2ce"), 0, "401337485-4", 76m, 2000, "The Nativity", 7 },
                    { new Guid("89d59a29-3672-44be-be68-6af170edadf1"), new Guid("7cbe2473-2c54-43f1-9e26-f8cb6c345898"), 0, "928772639-6", 80m, 2006, "Anything Else", 6 },
                    { new Guid("8a2b34a3-b079-4fdd-9e43-fec6785c2439"), new Guid("6b751a89-1e62-43ca-b754-2a4123355c9f"), 0, "303863672-X", 23m, 2004, "Satan's Little Helper", 6 },
                    { new Guid("8a936d09-aafc-4e55-8ea1-0d27713defd8"), new Guid("5380e8bf-636b-4486-9044-eb53527f2e05"), 0, "465365926-5", 62m, 1997, "Open Season", 8 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("8aaf373c-e8a6-4c87-9bc3-d5224177eec1"), new Guid("9ffc0977-37fd-4219-add9-9a25b073a10d"), 1, "976268902-X", 95m, 1997, "Earth Dies Screaming. The", 11 },
                    { new Guid("8b1e9bb5-4d92-4132-89d7-0068c2733d46"), new Guid("7c9d8b2b-cec8-401f-ac51-d35b2fbe0a59"), 1, "233570030-8", 26m, 2012, "Hammer. The", 5 },
                    { new Guid("8b5c9c34-8968-4707-ae52-fa0799aedad6"), new Guid("bde49538-eadc-4a44-8565-cf835cb82819"), 0, "303501549-X", 28m, 1986, "State Fair", 14 },
                    { new Guid("8bac8134-0f58-4542-80ba-2feef215dc8a"), new Guid("3e9fde8a-0dd7-401b-9a87-fab3fab8fa55"), 1, "985719466-4", 77m, 1985, "Annie Get Your Gun", 14 },
                    { new Guid("8be29514-0452-4aee-a4da-e74de178a1ee"), new Guid("f3a2d422-e9ce-4bda-93b1-6c6c05d9bb1e"), 0, "806156633-8", 53m, 1998, "Murphy's Law", 11 },
                    { new Guid("8c3ac1a1-a8f8-4f6e-83ed-b6d01dba3015"), new Guid("1fc9d5bc-6f28-405b-8a9e-1dcc73e883d6"), 0, "184659943-1", 51m, 2003, "Pruitt-Igoe Myth. The", 2 },
                    { new Guid("8cf18dc2-cb1d-4e47-9bb3-f06b7ad9c289"), new Guid("4a89df1e-4263-4bd3-b3f5-ec47d399ef7f"), 1, "912344677-3", 9m, 1996, "Pinocchio", 4 },
                    { new Guid("8d2ab99a-7db7-43a4-8a39-a0f2199540b7"), new Guid("8bbcf7a2-58b9-44b6-8195-4607a4ace18a"), 1, "208988944-6", 31m, 2006, "Aglaya", 9 },
                    { new Guid("8d4493af-305c-4bdf-a707-570d7f7c88c5"), new Guid("28c0521f-97a0-4e21-a7bc-45028ef1eb09"), 1, "616509042-7", 43m, 1985, "Manhattan", 5 },
                    { new Guid("8d62f72f-996d-4808-a39c-e7f9a23dd07e"), new Guid("81de9bef-1643-4cb7-8700-10cb9b09cef4"), 1, "344781658-9", 87m, 2003, "Texas Chainsaw Massacre. The", 7 },
                    { new Guid("8d6abc9c-0342-47e7-b54d-2919659f9186"), new Guid("12eaf5da-5225-450b-8e2c-aa2c07209f8f"), 0, "187020466-2", 46m, 2002, "Presentation. or Charlotte and Her Steak (Présentation ou Charlotte et son steak)", 1 },
                    { new Guid("8db2bc36-92b7-4c5f-892b-d6f458c8b0ff"), new Guid("2b2cf338-5bdc-48d4-9cf9-80126702734d"), 0, "357909546-3", 54m, 1995, "And Life Goes On (a.k.a. Life and Nothing More) (Zendegi va digar hich)", 13 },
                    { new Guid("8e054fea-f065-4928-9c35-20e8cfea50ca"), new Guid("55d8d918-c387-4b88-b778-01c183d4d854"), 1, "930665746-3", 62m, 1995, "Don't Blink", 13 },
                    { new Guid("8e4a1999-8e14-41a2-a016-bbb863033cbd"), new Guid("bc5c6376-48e7-4814-97c8-ccb63d2b47d6"), 1, "926898782-1", 86m, 2004, "Blonde Ambition", 14 },
                    { new Guid("8e6659dd-d91f-4904-957c-518b8ad8f8c6"), new Guid("8fd75b4f-e4c5-4e9e-83be-1e239089f8b9"), 1, "404830063-6", 49m, 2000, "Behind the Sun (Abril Despedaçado)", 12 },
                    { new Guid("8e81a04a-40a3-426f-969a-e35f81737653"), new Guid("18792222-9315-474a-9dc7-cc10354b7b18"), 0, "383287879-3", 64m, 2010, "Jungle Man-Eaters", 8 },
                    { new Guid("8e94bc5f-5738-4a80-a2f3-0bc8774a5f8e"), new Guid("67cd07fc-a2c7-4630-9512-fd8a0a807b14"), 1, "643754329-9", 75m, 1993, "Star Chamber. The", 3 },
                    { new Guid("8e9c5981-121b-4ca7-a3e9-17d68bb6d880"), new Guid("fe5d6a86-54ea-4fd8-826e-4b95cb093b4d"), 1, "111303772-5", 43m, 2006, "Suspended Animation", 7 },
                    { new Guid("8edd81df-422d-419c-b6fb-c660e9d2ab65"), new Guid("90fc885d-7fb1-46d0-8a1b-c77c9bd0dc58"), 0, "927735748-7", 6m, 2012, "Red Beret. The", 12 },
                    { new Guid("8eed7e0d-b0b1-4cbd-8e6d-54300fe153c6"), new Guid("2c928f36-1aa2-4e1f-8cda-b48b1a695b4c"), 1, "275322074-3", 94m, 2009, "Prayer for the Dying. A", 12 },
                    { new Guid("8ef689ad-a478-4f89-9297-60794c1dfde7"), new Guid("22231497-c3c4-43c6-8764-e008fe5062dc"), 0, "208657300-6", 65m, 2000, "Insidious", 0 },
                    { new Guid("8f1e407b-7078-4e7f-803e-c7536dbcec7a"), new Guid("33f626ac-032d-4421-8550-7f459134496b"), 1, "605938414-5", 75m, 2008, "Hi Tessa (Czesc Tereska)", 14 },
                    { new Guid("8fe438ad-209b-406f-be46-52a49a32ff0e"), new Guid("48ca3dda-0ab9-4a6b-825b-8b839212ace8"), 0, "379635252-9", 47m, 1992, "Fantastic Voyage", 12 },
                    { new Guid("8ff86aaf-18b9-44c7-a2e5-6f1846876e48"), new Guid("f6e1ed45-6cd2-41f2-985d-8c144810f820"), 1, "773492900-1", 38m, 2003, "Greyfriars Bobby (a.k.a. Greyfriars Bobby: The True Story of a Dog)", 12 },
                    { new Guid("90065e5d-8308-40b0-941c-7e08aa5d317d"), new Guid("ff5f61e3-2bf2-4fa9-b9c4-a3af97670bfb"), 0, "792771873-8", 99m, 2008, "Mister Buddwing", 12 },
                    { new Guid("90375566-3dea-4747-8588-78b56f8424cf"), new Guid("3bcc229e-c552-40d7-b152-9c42eb013fe7"), 0, "165067278-0", 76m, 2010, "Why Worry?", 14 },
                    { new Guid("90744394-fe99-4ec7-af77-6104ca40639e"), new Guid("69a396b6-43f2-416e-a00e-b3adfea00c88"), 0, "186584630-9", 71m, 1987, "Voodoo Tiger", 0 },
                    { new Guid("90e716fe-513a-41b6-a0ee-51f00a2dfba5"), new Guid("b332f0d9-946f-4d7d-b546-60bc208688d6"), 1, "952229597-3", 66m, 1995, "Harvard Man", 0 },
                    { new Guid("9111a475-dfd3-4631-8254-7962ac722d8b"), new Guid("ace68f80-9a57-4129-9e09-436ea1d736c2"), 0, "894617461-7", 10m, 2002, "Games People Play: New York", 3 },
                    { new Guid("913315cd-90db-4fb9-8e65-3551133da5b2"), new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), 1, "278850836-0", 83m, 1986, "Strip Nude for Your Killer (Nude per l'assassino)", 6 },
                    { new Guid("91715ac5-685b-460a-82b5-a8d2e625e56f"), new Guid("16460b51-2fcf-470c-bb00-276ba2bade53"), 1, "182828645-1", 57m, 1993, "Damned. The (La Caduta degli dei)", 5 },
                    { new Guid("91cb8f69-ae71-42b7-bd46-8e43124ac681"), new Guid("b8a0c27d-d0d5-4daa-a960-5f1b595a55ca"), 0, "032298242-1", 88m, 2003, "Dragon Ball Z: Bojack Unbound (Doragon bôru Z 9: Ginga girigiri!! Butchigiri no sugoi yatsu)", 6 },
                    { new Guid("91df0a8b-8544-407b-a509-5f2e92bb89e3"), new Guid("b39bc32c-dd43-4027-b289-dad680195b2e"), 0, "227773554-X", 69m, 1997, "Robin and Marian", 4 },
                    { new Guid("9256f68f-061a-43cc-85de-d97080c8983f"), new Guid("10e2d254-60a5-4300-a66e-25b9aa678b23"), 0, "813190263-3", 22m, 2013, "Short Circuit 2", 3 },
                    { new Guid("92b90fe5-ebd7-4bc1-92c1-f8b76b6dc981"), new Guid("f5010ba3-bb59-464d-8e72-ee74f7b08868"), 0, "492696158-X", 96m, 2010, "Children of the Decree (Das Experiment 770 - Gebären auf Befehl)", 2 },
                    { new Guid("92f20245-03d1-44d8-ab59-1179384fdb7f"), new Guid("bb96be95-e286-4bd8-b7d7-640bc350018f"), 1, "086106907-2", 88m, 1984, "Uncle Marin. the Billionaire (Nea Marin miliardar) (Uncle Martin. the Multimillionaire)", 9 },
                    { new Guid("93005f7b-6f51-4da4-a60a-cfd1d16d0f21"), new Guid("14a25339-ec69-4e6a-a2c5-df9a233a70fa"), 1, "572138885-4", 45m, 2004, "Songwriter", 8 },
                    { new Guid("94506ed9-6e90-491b-94e3-891c6e0965c9"), new Guid("bd9e488f-ec59-459b-98f8-cec2351d2982"), 1, "909947497-0", 84m, 1997, "Michael", 10 },
                    { new Guid("94678d52-bfe0-45ec-8f72-89412dc21994"), new Guid("3910cab4-adc0-410f-ba56-90626ba23684"), 1, "547425699-X", 35m, 1998, "Decoy Bride. The", 8 },
                    { new Guid("947f80ae-b3e1-4a54-ad9d-11eb1caff1ea"), new Guid("e23c6d4a-94aa-4bda-8a09-4f3a00c1d2a8"), 1, "771876702-7", 3m, 2011, "Great Train Robbery. The (a.k.a. First Great Train Robbery. The)", 1 },
                    { new Guid("94a28cd2-59b7-454b-a3e9-421ca59691c4"), new Guid("ec8e4ccd-bd7a-4690-827c-f75973e8d465"), 0, "384033465-9", 56m, 2001, "As You Like It", 5 },
                    { new Guid("958b699c-09cf-45a5-b3b7-2ce072ba5aed"), new Guid("be5902e9-595e-4743-8004-bb0e46b60b7a"), 0, "996324070-4", 17m, 2012, "8MM 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("95a35e3a-2397-4b77-8319-b64bb990413d"), new Guid("9196f1a3-d6d5-4a1d-a167-040c85293f4a"), 1, "491238717-7", 96m, 1995, "Stick", 4 },
                    { new Guid("962e2c12-0f46-4c80-922c-486adc14ebfd"), new Guid("83aa75c9-fafe-43e2-adf7-5e0acb1977e7"), 1, "783676970-4", 64m, 2012, "Budz House", 9 },
                    { new Guid("9633ae65-5aac-4b83-9b57-944ba139cca4"), new Guid("c663e806-ddba-462a-a1c7-5b2a4c197de7"), 0, "282241664-8", 86m, 1993, "Redes (Fishermen's Nets) (Wave. The)", 14 },
                    { new Guid("96bfacf7-a807-4ee5-b7c0-a7927c62b47a"), new Guid("e5928360-c189-4a52-b461-ebe0ec2507d5"), 0, "393260481-4", 88m, 1990, "Looking for Hortense (Cherchez Hortense) ", 13 },
                    { new Guid("971dfac2-becd-478e-8981-16446d79152d"), new Guid("2ca0a633-a9d0-4acd-8441-de22f7bf1298"), 1, "760261301-5", 70m, 1985, "Fuck You. Goethe (Fack Ju Göhte)", 4 },
                    { new Guid("97fb818b-6c89-4856-8500-f2beef6b0de1"), new Guid("d098e30a-0cd8-45fa-b30b-d2b5d6cc028c"), 0, "443122559-5", 48m, 2009, "Advertising and the End of the World", 14 },
                    { new Guid("981f86bd-c775-49fc-958d-fd0d910c02fe"), new Guid("6c116e93-222e-4813-bd35-97af4e0626eb"), 1, "944797055-9", 65m, 2003, "Home Before Dark", 8 },
                    { new Guid("98bf76fc-bf82-4a29-8f96-782eacc84ff1"), new Guid("956dfc48-c43b-4e91-9353-9105e1860300"), 0, "288875218-2", 6m, 1996, "Look. Up in the Sky! The Amazing Story of Superman", 9 },
                    { new Guid("98c82cc2-2a45-48fd-bdcc-1d93cd3330a3"), new Guid("1281db96-f078-4e2a-8489-9a052b33aab3"), 0, "576184623-3", 14m, 2008, "No Way to Treat a Lady", 11 },
                    { new Guid("98d33a25-ca52-4217-a315-0ea64c0109fa"), new Guid("67454c28-8495-457f-8b7e-37afc6ca598f"), 0, "266352429-8", 88m, 1993, "Countdown to Zero", 14 },
                    { new Guid("98e65290-049d-4297-8568-584f08fde5d0"), new Guid("a03622bc-f35f-440f-9cc4-cb1076fe2528"), 1, "246725859-9", 57m, 2000, "They Live by Night", 4 },
                    { new Guid("9952e9de-aa77-462e-8e4d-f86107dbbb3d"), new Guid("f3bf4c79-af62-4b46-9113-eda5243d5701"), 1, "172538208-3", 31m, 1996, "Red Heat", 2 },
                    { new Guid("9a49ee63-e497-4e21-9918-5014d5ab30ca"), new Guid("b1f1c10e-7853-47cd-9718-517038b33496"), 1, "511124623-1", 4m, 1990, "Flight of Dragons. The", 13 },
                    { new Guid("9aa0aa1d-b61e-4253-ae58-2b077aaebe64"), new Guid("349749c3-e70b-4fea-b33b-35b913726b2e"), 1, "247994339-9", 91m, 2008, "Miss Potter", 11 },
                    { new Guid("9b56a153-e00e-448d-9a7f-26a13042a1b7"), new Guid("09d8248f-b84f-4482-81ec-38e4bdde66a0"), 1, "438754474-0", 37m, 1989, "Communion", 5 },
                    { new Guid("9bc6b56e-255d-487c-a68e-f5ac8692dc15"), new Guid("03a5bd12-ef92-4d66-91bb-9da8d3666f82"), 0, "086793285-6", 13m, 2011, "Good Dick", 13 },
                    { new Guid("9bf3ef2e-d02e-4aef-bf93-77ef47df8236"), new Guid("bde49538-eadc-4a44-8565-cf835cb82819"), 0, "094829843-X", 23m, 2001, "Taxi Driver", 3 },
                    { new Guid("9c03e4cb-ac95-4701-9b80-58a6ae1fe407"), new Guid("34b4c9ac-5700-4e88-914a-e2da78e1b8bd"), 0, "187356730-8", 71m, 2002, "Ape. The (Apan)", 8 },
                    { new Guid("9c380fed-8b16-4cb7-803b-57372612f3b7"), new Guid("8bc2fbf2-b8be-420a-ab41-e49c44123753"), 1, "653267987-9", 97m, 2003, "Away with Words (San tiao ren)", 1 },
                    { new Guid("9c65bfe7-c253-4616-a16e-296f4cd8c911"), new Guid("0ceed50a-7558-4742-baf6-d1a2d9f834ef"), 1, "054494596-4", 91m, 2004, "Anaconda", 12 },
                    { new Guid("9c6ccecc-0ce1-445f-8eb0-e5a645e9787a"), new Guid("e625ce4e-cec8-433c-bb00-38923eab6db5"), 1, "596749580-0", 88m, 2006, "Half Baked", 7 },
                    { new Guid("9cb5ccdc-607d-49ed-af81-af5f5c4f3fdc"), new Guid("b443a348-9799-4c2b-9f05-95869e08f40d"), 1, "753763499-8", 38m, 1996, "Promises", 1 },
                    { new Guid("9cff2c6d-2529-4040-b511-2f49256b43e5"), new Guid("7177638d-3369-4b4d-b812-408159198a4f"), 1, "621745886-1", 59m, 2009, "Philadelphia Story. The", 13 },
                    { new Guid("9d5edbf0-e09a-4d1a-a466-2af553ae48c4"), new Guid("6b5226fe-b18e-4e81-a136-e5c8e6ad4f23"), 0, "303644200-6", 75m, 1994, "Tell", 5 },
                    { new Guid("9d6c69b4-506c-4f93-b8c2-07fee26db97a"), new Guid("7745a287-443b-411e-85a1-97ca5a4ecd48"), 0, "090550624-3", 55m, 1991, "Thor: Tales of Asgard", 0 },
                    { new Guid("9dc2d075-451b-4233-96ec-35ebe05081ef"), new Guid("a7ff2067-4b59-4e9a-8a89-a328132c95f5"), 1, "262802097-1", 94m, 2008, "Madonna of the Seven Moons", 11 },
                    { new Guid("9dd416e8-715e-4603-bba7-2a67166f53eb"), new Guid("bc65bda2-f50a-4cd8-a1c4-ede9e5b53b99"), 0, "734883394-2", 52m, 1996, "Decision Before Dawn", 13 },
                    { new Guid("9e0b9083-adfd-461e-9dfa-0b8414257b84"), new Guid("4fd76409-8e66-43aa-9261-da0cb238c689"), 1, "064600963-X", 100m, 1998, "American Bandits: Frank and Jesse James", 2 },
                    { new Guid("9e117f59-6ec6-4f4e-9a23-827a6c297cfd"), new Guid("f27a9091-2656-4dab-bea3-4053184a42d3"), 0, "306237306-7", 31m, 2002, "Nightwing", 7 },
                    { new Guid("9e35879f-5999-4d75-9803-e91ee039e745"), new Guid("956dfc48-c43b-4e91-9353-9105e1860300"), 1, "427085902-4", 15m, 2010, "Sergeant. The", 8 },
                    { new Guid("9e35f857-a3e2-41c2-86d6-e5743a6fc661"), new Guid("dc0553d6-4402-4148-81c5-2d0d228c3902"), 0, "462793401-7", 66m, 2001, "Don Is Dead. The", 9 },
                    { new Guid("9e890873-3eff-4443-b5d8-e63355b6b065"), new Guid("6d53ec25-c1e2-4bf8-8881-b51b5117e43d"), 1, "151801112-8", 23m, 2004, "Basketball Diaries. The", 6 },
                    { new Guid("9e9eca05-45bc-42bc-865d-e1c67ee79978"), new Guid("f87ea182-306a-448f-803f-d3c91f5a6dca"), 0, "938281696-8", 38m, 2002, "Study in Scarlet. A", 6 },
                    { new Guid("9eac727f-c64a-4f98-a106-320956af3c47"), new Guid("0ec95507-4f2c-4f67-97fb-83d41b418265"), 0, "657781836-3", 7m, 2005, "British Intelligence", 11 },
                    { new Guid("9f2bcb24-0e94-43b7-8d72-e740e965c4ec"), new Guid("b8a0c27d-d0d5-4daa-a960-5f1b595a55ca"), 0, "905496226-7", 88m, 2003, "April Fool's Day", 5 },
                    { new Guid("9f469277-b4e7-4d5b-94bb-d63c632995fa"), new Guid("a59d0611-a60b-479c-b95e-d49076a61694"), 1, "614169587-6", 89m, 2008, "Pine Flat", 3 },
                    { new Guid("9f7a2342-fa0b-417d-ad6c-54e47aae0d19"), new Guid("ea0c9879-b19b-4e47-8879-1b1ac5b9536b"), 0, "466410953-9", 36m, 2003, "Grotesque", 14 },
                    { new Guid("9f949e0a-6f61-44e6-aa5e-306c8dd98c38"), new Guid("15a49315-552f-4f6a-9f25-001a5f13ce07"), 1, "558897437-9", 76m, 2006, "They Live by Night", 4 },
                    { new Guid("9f9f9710-c90b-4001-9a7d-aee3c7dc39c1"), new Guid("bd936aea-5632-4ec9-9bde-ce8eca0fb7e4"), 0, "592540034-8", 95m, 1992, "Global Metal", 12 },
                    { new Guid("9fc00830-d4c0-497e-b33c-086679fc6d1e"), new Guid("f23e51a1-c7bc-48c0-ac59-1160a4ef636a"), 1, "632868201-8", 31m, 1997, "Algiers", 14 },
                    { new Guid("9fff131e-f77b-4944-b60b-db060dbe2b1f"), new Guid("91cf8bd5-b2a7-49a9-8166-95b73559ad5a"), 0, "998905973-X", 50m, 1998, "Stargate: Continuum", 8 },
                    { new Guid("a062f27c-f03f-4051-bae5-77dfbace52b1"), new Guid("a0712bbe-47b4-4ddb-a39a-fa82d285db15"), 1, "761134238-X", 15m, 2005, "Where the Red Fern Grows", 10 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("a08c59fb-d67d-4672-9578-5b4f59fb72b7"), new Guid("1af6bab8-73c9-4ee7-b2bd-5a24daa9ffa2"), 1, "830458874-9", 44m, 2000, "Flesh", 0 },
                    { new Guid("a0b7a8f6-61a8-4683-b248-7eb9eb44e01f"), new Guid("fa9a2f64-0908-49c8-8afe-d2fc45a83df4"), 0, "868114642-4", 63m, 2004, "Death Race 3: Inferno", 5 },
                    { new Guid("a1104236-4c74-4d91-8efd-4a247126e512"), new Guid("ace3e3d5-bf0c-4164-a962-d9e5ac5e8bd6"), 0, "985317372-7", 21m, 2013, "Fay Grim", 5 },
                    { new Guid("a141a76b-5d9f-4561-9916-22da6f212899"), new Guid("2e795847-4b82-493d-981f-aa0aecbaf839"), 1, "921349451-3", 93m, 2003, "Akira", 1 },
                    { new Guid("a15f156e-ecbc-4a35-a4c8-8ccf029af21c"), new Guid("e23c6d4a-94aa-4bda-8a09-4f3a00c1d2a8"), 1, "331950844-X", 37m, 2012, "Gabriel", 12 },
                    { new Guid("a1c9bb20-6e99-4ad9-b522-44bd89d052ec"), new Guid("e5b35dcb-548d-45d2-93ba-41128094afab"), 1, "219451497-X", 55m, 1994, "Lady in the Water", 10 },
                    { new Guid("a1dbcfbd-7148-4395-b18f-758605200780"), new Guid("cb081f39-a330-43f8-bf31-8fa8d4b23320"), 0, "289204835-4", 67m, 2012, "Peter & the Wolf", 11 },
                    { new Guid("a20d42ba-ad39-4403-8ef3-75103e491d10"), new Guid("383b0277-d263-4ca6-a895-2e83d2c6983e"), 1, "709927888-6", 82m, 1993, "The Hunchback of Paris", 8 },
                    { new Guid("a22fd2c0-cfb3-44a5-b786-668f04da0479"), new Guid("c50a4572-f75c-4f89-8725-27d22731d2d7"), 1, "363751281-5", 27m, 1994, "Vali", 12 },
                    { new Guid("a2c877c1-4a92-4e4d-a050-c7090c5a6fd5"), new Guid("6cb305f3-eb38-473b-ae50-2e968e995935"), 0, "237438473-X", 87m, 1985, "Slipper and the Rose. The", 4 },
                    { new Guid("a300a551-a55d-45fa-8d97-fd1cbed11f58"), new Guid("88b01291-97a9-4c27-950c-40b66c115795"), 0, "903295475-X", 64m, 1990, "Mickey's Twice Upon a Christmas", 5 },
                    { new Guid("a3336ea1-22cc-483b-8e84-8167f57611be"), new Guid("b09e3406-dd10-4ff6-adf1-ba651a14e7a5"), 1, "751146888-8", 82m, 2007, "Aashiqui 2", 3 },
                    { new Guid("a36a7aed-4097-46bd-8011-2c8933922946"), new Guid("d632f5b1-a7a1-4d4a-8dd5-40f20cafaede"), 1, "262020712-6", 84m, 2011, "Shadow People", 4 },
                    { new Guid("a380c54a-c9b3-494e-a508-bc242376835a"), new Guid("8744a906-2952-4236-b56d-f60d81c02330"), 0, "872824355-2", 76m, 1988, "Indian Summer (a.k.a. The Professor) (La prima notte di quiete)", 2 },
                    { new Guid("a3e49668-bfeb-4551-9470-bbcabcb7d449"), new Guid("20b52943-cc85-4aca-846f-79f990d0a7b1"), 1, "096696666-X", 82m, 1998, "Ikigami", 13 },
                    { new Guid("a3fab001-180b-4a42-913b-6086d83da06b"), new Guid("ea0c9879-b19b-4e47-8879-1b1ac5b9536b"), 1, "472738573-2", 46m, 1992, "Takeshis'", 13 },
                    { new Guid("a40de08a-4d03-4846-9371-0bce38c1fe3a"), new Guid("a329886f-2f4c-423e-a779-3ccb89e61080"), 0, "514466173-4", 41m, 1997, "Deliver Us from Evil", 12 },
                    { new Guid("a4136089-8fff-4ffb-81dc-10084675a8cd"), new Guid("15f10e87-dc54-4e4b-91f6-a67402891ca9"), 1, "994097294-6", 82m, 2004, "Billy Bathgate", 9 },
                    { new Guid("a42d1fe2-f8b3-46b7-b442-bafed1fbe407"), new Guid("5a46e5ca-65b6-4a88-affe-1e0a14bd2429"), 1, "847998102-4", 55m, 1995, "How to Eat Fried Worms", 4 },
                    { new Guid("a53a9a8f-e0b1-49cb-a167-2763359b4cbd"), new Guid("18895baf-1493-463f-8c5a-690cd89b3232"), 1, "742279909-9", 83m, 1998, "Chill Factor", 11 },
                    { new Guid("a5c516bc-b0ac-4ac7-bad1-e77897ea659a"), new Guid("5f2c982d-53fd-4c4c-aaba-b79976b44c95"), 1, "563272802-1", 88m, 2010, "Wanted", 13 },
                    { new Guid("a5f3998b-a3be-410d-99f5-ca94b052b41a"), new Guid("a1ceb583-6417-4664-aac4-193be893832b"), 0, "788899915-8", 51m, 2005, "Quicksand", 11 },
                    { new Guid("a63c1f24-cfb7-4adb-9142-b149a1dd622f"), new Guid("e5c5d7d3-25cf-4f74-a202-75ac70a95a42"), 1, "801961150-9", 9m, 1993, "City of Women. The (Città delle donne. La)", 14 },
                    { new Guid("a6bf4221-4938-4ba2-b0a6-2fc697a8a69e"), new Guid("a0b4c6dd-b63e-4341-8f10-2cbcd0bda92a"), 1, "801233070-9", 59m, 1997, "Thieves. The (Dodookdeul)", 1 },
                    { new Guid("a7016eb6-90c1-4de9-984e-c4f322558901"), new Guid("84e31a7b-7d34-4849-9767-a0acde0bc8d0"), 1, "153145467-4", 25m, 2003, "X-Men", 5 },
                    { new Guid("a734b0dc-cacf-44c5-b492-132bcc6ad0ef"), new Guid("079aafe1-97db-4416-8a2d-7e598149b737"), 1, "098294916-2", 91m, 2005, "This Thing With Sarah", 1 },
                    { new Guid("a7450032-98fe-4aab-b913-eceb59338128"), new Guid("68a44f88-d6b2-4874-bf57-3cbcae869b15"), 1, "431035769-5", 14m, 1989, "Promised Land", 11 },
                    { new Guid("a7da7909-21a6-479c-9661-2768fd75f0de"), new Guid("ad1e5cb4-e2a4-437f-87c2-e76a78e4d0e5"), 1, "850924489-8", 30m, 2009, "Pyx. The", 1 },
                    { new Guid("a8325bd3-a66f-4083-bfd0-defd2067f005"), new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"), 0, "085413745-9", 43m, 1994, "We're Not Dressing", 13 },
                    { new Guid("a850003c-27c8-47c2-8896-1035b4432b0d"), new Guid("6deeb509-6c19-4323-b2f7-c86349a2b003"), 0, "858983468-9", 6m, 2000, "Method. The (Método. El)", 4 },
                    { new Guid("a92d1718-8d89-44ca-b4a0-225b40155cca"), new Guid("32f68714-7d03-46c1-9ae9-3230ab1015a1"), 1, "610353777-0", 93m, 2004, "Tinker Tailor Soldier Spy", 6 },
                    { new Guid("a9644120-1921-48ef-95f3-6390f7bcc910"), new Guid("dc7642e1-db94-4d35-b5e3-84706d0884af"), 1, "470188544-4", 24m, 2010, "Up in Smoke", 4 },
                    { new Guid("a9984c8b-0e13-4047-b726-0b0bd0e782b5"), new Guid("a10a0a76-ecda-4236-b6db-cb91c89ac080"), 0, "126292420-0", 30m, 2009, "Mickey", 9 },
                    { new Guid("a9c3014e-5f5b-4bde-acc5-eaa017a1a896"), new Guid("34b4c9ac-5700-4e88-914a-e2da78e1b8bd"), 1, "751681102-5", 72m, 2004, "Sorority Babes in the Slimeball Bowl-O-Rama", 11 },
                    { new Guid("aa062d1b-21f6-4643-b94e-e6a7ab3a74e7"), new Guid("35f2624c-ea35-4a3c-af63-4715ff521161"), 1, "902706832-1", 50m, 1996, "Teddy Bear (Mis)", 3 },
                    { new Guid("aa316613-bf2f-4976-9b60-bfa15400c93b"), new Guid("1d7920d7-15ce-4044-8504-1751bfbe535b"), 0, "976677278-9", 84m, 1994, "Hell Is Sold Out", 6 },
                    { new Guid("aa44ce8b-4e6e-4c23-a5c1-1471661e1370"), new Guid("c623c617-f77b-4bdb-b49c-9caaa774480b"), 1, "740704011-7", 12m, 2002, "Psycho Beach Party", 0 },
                    { new Guid("aa5b9346-a38f-4e4b-9471-3e05b1134d11"), new Guid("f3c84ba8-01c8-4fd2-a47c-0f213462fa28"), 0, "822043032-X", 96m, 1993, "51 Birch Street", 10 },
                    { new Guid("aa62e995-b10b-4789-b621-703baf59232e"), new Guid("0b1719df-a53d-4a59-960e-2b319cb4da9f"), 0, "810564028-7", 34m, 2010, "Return to Peyton Place", 11 },
                    { new Guid("aa9396a5-e762-46a5-9132-c1f51fc7ea45"), new Guid("28c0521f-97a0-4e21-a7bc-45028ef1eb09"), 0, "934232693-5", 14m, 1994, "Thirst for Love. The (Ai no kawaki)", 14 },
                    { new Guid("aaa2de82-07d2-4255-baa0-29532bc41e70"), new Guid("394b5eca-1ebd-4ea2-a9ac-b03cbaa71e07"), 1, "818184221-9", 21m, 1994, "At Sea", 4 },
                    { new Guid("aab3f658-45ee-418a-90a0-ce24c3ec34b9"), new Guid("2dbd7137-b243-4c35-b500-3f08fab32dea"), 0, "131320320-3", 96m, 1998, "You Don't Mess with the Zohan", 14 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("aabc0790-f0e6-4c86-8177-57ee2eb08e6e"), new Guid("df8d9830-ffbb-422e-b69c-6c3014088345"), 0, "681468807-7", 64m, 2012, "Selena", 8 },
                    { new Guid("aac06671-241a-40c4-869f-5d635598670f"), new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"), 1, "633733943-6", 98m, 1985, "Caroline?", 7 },
                    { new Guid("ab02a4e8-e8a7-42e0-83d5-15abe67aa2e5"), new Guid("ad533211-4ff4-4ce9-828d-082346666f62"), 1, "260292940-9", 20m, 2001, "Repulsion", 2 },
                    { new Guid("ab3d9671-6483-4d0b-abdf-0f3b1d499a2e"), new Guid("9d5b08b1-dee6-4e69-817e-a8bf92d81124"), 0, "968898887-1", 62m, 1989, "Ward. The", 8 },
                    { new Guid("ab8e5876-cf82-495c-ac8d-92ec9a0fcb53"), new Guid("1cb011e1-4010-48db-992f-0e990cdb0c14"), 1, "441419159-9", 69m, 2008, "My Name is Juani (Yo soy la Juani)", 6 },
                    { new Guid("abe19194-247d-47c3-b048-f6e703291b7e"), new Guid("59416f28-e187-40ea-b26e-fc26dc0022ea"), 0, "736358402-8", 64m, 2004, "Close Encounters of the Third Kind", 5 },
                    { new Guid("ac2529a6-6abd-4352-b7a3-a193cdf4e8fc"), new Guid("cb2bbd63-0980-4ee8-beab-c0f7ab872383"), 0, "879383176-5", 95m, 2000, "Grace", 4 },
                    { new Guid("ac5f2f6b-8af1-47aa-ad3d-3cf4b2ae1445"), new Guid("e9ec1912-5d14-4338-a6eb-68a554e18720"), 1, "054508421-0", 100m, 1988, "Tony", 4 },
                    { new Guid("ac796ebe-8bb2-40ca-9188-48b32ec71b8f"), new Guid("c41f1dc4-f199-498a-b4a8-0786fb4fbc79"), 0, "167195137-9", 18m, 1998, "Under the Flag of the Rising Sun", 9 },
                    { new Guid("ac941fdb-6c3e-48d1-9c4d-bf9823d82240"), new Guid("0b511322-90cd-4686-afdc-aa7aac98b223"), 1, "750470420-2", 32m, 1993, "The Girl from the Marsh Croft", 11 },
                    { new Guid("ad4c0dec-a87d-4cc5-8f56-57885a4258b2"), new Guid("ce32cece-a2aa-4783-85c9-4a9932d9a571"), 0, "773046883-2", 16m, 1998, "Mahler", 12 },
                    { new Guid("adbe3021-d5e4-46ea-bd1e-590eeaf18927"), new Guid("19fe27c7-6493-4426-9659-576f5fd3f56e"), 1, "888313934-8", 86m, 2009, "Sun on the Horizon", 7 },
                    { new Guid("add7b318-8dcb-437d-9ed9-dcc031d3541a"), new Guid("fba0c2f7-a70d-4d0e-b8f9-cab54c5e4752"), 0, "837687638-4", 41m, 2004, "Cry of the Banshee", 5 },
                    { new Guid("adf66c06-0f74-447f-84d2-107f7fa07a42"), new Guid("e23c6d4a-94aa-4bda-8a09-4f3a00c1d2a8"), 0, "831317779-9", 23m, 1992, "Critical Condition", 4 },
                    { new Guid("ae5aa398-e9d2-43c1-9974-7aa2daeb8063"), new Guid("b8c3d832-e24d-470d-8d87-e3ab5da9ee79"), 1, "093247982-0", 31m, 1986, "Bliss", 9 },
                    { new Guid("aea8f583-7ff9-4a17-9824-5f67fb5e4605"), new Guid("371a9bc8-1fd8-40fb-980d-735602eae2dd"), 0, "312777780-9", 74m, 1992, "Gate of Flesh (Nikutai no mon)", 7 },
                    { new Guid("aeac8e4a-8870-4744-bb9a-0cbd95bdeea2"), new Guid("27f5d1db-4c36-40ac-bbc2-abf4ff04c750"), 0, "570658461-3", 28m, 2002, "Street Thief", 14 },
                    { new Guid("af00565d-d57c-48ea-b12d-1c81e96396b0"), new Guid("f3a7d97c-16be-4402-8c8a-978a85d6b254"), 0, "306865943-4", 72m, 2011, "Hells Angels on Wheels", 9 },
                    { new Guid("af28cbb8-5505-4549-8097-91e1058decd9"), new Guid("06c4b13d-acd4-48a5-b197-f6ec2ddaad03"), 1, "320860914-0", 83m, 2006, "Indie Game: The Movie", 9 },
                    { new Guid("af7ff106-15ed-46cc-8416-a6b2bcd27ebb"), new Guid("f9306978-8fc1-47dc-ba7b-b2aed6f94a67"), 0, "434996008-2", 66m, 2005, "Asfour Stah", 2 },
                    { new Guid("afccb9b4-7202-49da-98e7-245f1c627d95"), new Guid("0fe2def8-3847-4d6b-8c1d-d5d589df242b"), 0, "831731145-7", 59m, 2009, "Leonard Part 6", 6 },
                    { new Guid("afcd9d27-bbf8-43d2-8e89-2e90bcdd09e0"), new Guid("1025d60f-045d-4d18-bf8b-b55c79d4a9d1"), 1, "032901454-4", 56m, 1987, "Cobra Verde", 7 },
                    { new Guid("affefeb6-8c8e-46b7-bb62-fb2769138773"), new Guid("ca619031-f834-451a-bb11-b9af6c099ebb"), 0, "482426857-5", 97m, 2003, "Nas: Time Is Illmatic", 6 },
                    { new Guid("b005778e-a4be-48bc-a4d3-ae9410243a4c"), new Guid("95063ef9-dfb2-482c-8b95-2d990034e231"), 0, "122432153-7", 98m, 2010, "White Nights", 9 },
                    { new Guid("b07a8f41-0bbe-43d0-8ff5-5dca27b10a90"), new Guid("acd774db-b92d-4b71-a6a9-462262f6bd94"), 0, "354605593-4", 22m, 2009, "Boy Interrupted", 4 },
                    { new Guid("b07d4e0e-c8bf-4f44-ba29-7fbf3bb8feee"), new Guid("e23c6d4a-94aa-4bda-8a09-4f3a00c1d2a8"), 0, "276724060-1", 95m, 2001, "B.F.'s Daughter", 2 },
                    { new Guid("b1903fc1-9756-4c9f-913b-62168d97dc29"), new Guid("2145fbbf-8504-4e49-9a46-7748608fef9d"), 0, "097673289-0", 71m, 2009, "Marion Bridge", 1 },
                    { new Guid("b1954b5e-de4e-4156-8a3b-c666d74e91ff"), new Guid("9499012b-9ded-443e-9a92-5166d7d9adc7"), 0, "771463234-8", 62m, 1991, "Hart of London. The", 7 },
                    { new Guid("b1f6893d-c913-4494-b370-dd0e179fe70c"), new Guid("44fca0fd-a199-40dd-91a0-c93ff17297cf"), 0, "850485241-5", 18m, 2009, "United 93", 9 },
                    { new Guid("b2652783-41c9-4ea9-924d-a8a7ee56de2c"), new Guid("5a46e5ca-65b6-4a88-affe-1e0a14bd2429"), 0, "754332646-9", 61m, 2001, "Mikey and Nicky", 10 },
                    { new Guid("b27f1cd6-ca45-432d-976c-ba8fcc630bfc"), new Guid("66950e8a-cbd7-4a3e-bde7-3acfe719c9b1"), 1, "330383845-3", 97m, 1993, "Strawberries in the Supermarket (Jagoda u supermarketu) ", 13 },
                    { new Guid("b29cef2c-c377-4194-89d3-9b26d09e6418"), new Guid("02089dca-80a6-4eeb-8f9f-e6b392f76f9d"), 0, "127626080-6", 37m, 2000, "Coward. The (Kapurush)", 2 },
                    { new Guid("b2a65f66-c53f-47b6-bd92-eb69ff2a040e"), new Guid("2be92935-580e-4f3e-b46b-c3c456f44655"), 0, "053088873-4", 60m, 1993, "Chuck Norris vs Communism", 4 },
                    { new Guid("b2f18523-9f70-4a5d-b17f-b60fdd540419"), new Guid("a44875d4-7608-4c3b-837b-bc7d912760b9"), 1, "225272361-0", 54m, 2009, "Big Game", 9 },
                    { new Guid("b36c0cb0-60d0-46a7-86da-7e3160202519"), new Guid("b6492e83-2cc9-4841-828b-4e195b88325e"), 1, "707616190-7", 54m, 1997, "Ladybug Ladybug ", 12 },
                    { new Guid("b37a9147-0062-476e-a8fb-7379f5b57872"), new Guid("587c4769-f9f4-4071-a4aa-5657ff07f98d"), 0, "358908477-4", 87m, 2012, "Belly of the Beast", 5 },
                    { new Guid("b38e13c0-eaa8-4525-ba35-63428a114c28"), new Guid("2eefb633-abad-4f17-83a1-ff1e8cd24f4d"), 1, "067718579-0", 89m, 1991, "28 Days", 4 },
                    { new Guid("b39081ca-114f-43ce-97ca-d7c450345aee"), new Guid("025dc1c9-55c4-48ef-b265-7ac3a06628eb"), 0, "452584064-1", 80m, 1995, "Daughter of the Nile (Ni luo he nu er)", 11 },
                    { new Guid("b3f5d98d-1654-4960-9cdb-6e677744942b"), new Guid("ec4aa741-496b-4a52-822f-1099d218f328"), 0, "534993933-5", 24m, 1988, "Comanche Moon", 9 },
                    { new Guid("b4118a44-b066-405d-ae54-71d8870ca929"), new Guid("0713193a-10bb-4d6d-99f5-81e8261f06f3"), 1, "255966850-5", 27m, 2011, "Uncommon Valor", 1 },
                    { new Guid("b428f340-b404-4cb3-b33a-20001ab01527"), new Guid("84e31a7b-7d34-4849-9767-a0acde0bc8d0"), 1, "663671919-2", 8m, 2010, "Next Friday", 6 },
                    { new Guid("b4480e15-a7c1-41d0-889a-cb860966bbdc"), new Guid("c52fbd37-2cb3-44ce-b647-757eb53a1573"), 0, "284309542-5", 24m, 1997, "Gods and Generals", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("b461bbf4-40fa-4a06-8304-c24c5a4b764b"), new Guid("cb68656a-1d75-47bb-a1fb-14a2ef54aa05"), 1, "272940025-7", 25m, 2001, "Two Can Play That Game", 4 },
                    { new Guid("b46e778a-371c-4e8a-9001-d749e62bf036"), new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"), 0, "384269136-X", 58m, 1997, "Captain Video: Master of the Stratosphere", 6 },
                    { new Guid("b49d14cc-b3cb-4691-9d74-771431a14e26"), new Guid("75068271-5119-49f7-8c2a-c8aafe5db994"), 0, "903165195-8", 26m, 1983, "Alexander and the Terrible. Horrible. No Good. Very Bad Day", 13 },
                    { new Guid("b4a6460e-5383-44f8-8b58-3c6acc6e02ae"), new Guid("ee7ac866-ac0a-4e21-8a39-f9819fb2f33d"), 0, "442733783-X", 100m, 2002, "9 Star Hotel (Malon 9 Kochavim)", 7 },
                    { new Guid("b4b46739-c1f7-405b-b4ec-536053c4d3dd"), new Guid("f6e1ed45-6cd2-41f2-985d-8c144810f820"), 1, "383083248-6", 46m, 2008, "I Am Bruce Lee", 8 },
                    { new Guid("b4eb6451-03e2-4785-92db-f8b53f61b043"), new Guid("27c832f5-d940-4133-ac35-6349f6c4b59f"), 0, "068699257-1", 54m, 1994, "First Case. Second Case (Ghazieh-e Shekl-e Aval. Ghazieh-e Shekl-e Dou Wom)", 4 },
                    { new Guid("b55345ef-40e0-4348-af91-5acba89a23f4"), new Guid("666fdd39-a35e-40a5-b61f-52fbf324895b"), 1, "018565386-3", 57m, 1989, "Project A 2 ('A' gai wak juk jap)", 7 },
                    { new Guid("b579b84f-7294-4419-b60f-d14d7c137fce"), new Guid("cb081f39-a330-43f8-bf31-8fa8d4b23320"), 1, "166118634-3", 50m, 2004, "Little Girl (La pivellina)", 1 },
                    { new Guid("b58d62d7-6bad-4366-b6b9-f1c479241aa9"), new Guid("8222e14d-e58d-42f2-94f1-0f20706eb0ac"), 0, "038261635-9", 48m, 1997, "Baby. the Rain Must Fall", 1 },
                    { new Guid("b58fb25f-820a-48d9-bf7c-025d7c6ddfe1"), new Guid("7e150311-319a-49a9-83c2-192c32b1363b"), 0, "776228015-4", 54m, 2002, "Along the Sungari River (Song hua jiang shang)", 10 },
                    { new Guid("b70bdebf-1b41-4b3e-b14d-d4f536a6bacc"), new Guid("503981ad-b428-4fe9-bc56-a1a96ebd17f0"), 1, "349224351-7", 18m, 2003, "Another Woman", 10 },
                    { new Guid("b788a2bc-0446-4052-9465-709debc57c84"), new Guid("e9ec1912-5d14-4338-a6eb-68a554e18720"), 0, "610587979-2", 82m, 1999, "This World. Then the Fireworks", 10 },
                    { new Guid("b7ed9f10-13b8-480b-9618-f79a569536ca"), new Guid("561bd8c4-a03d-4be9-a2e8-78ed46ca4274"), 0, "204494117-1", 68m, 2011, "Institute. The", 12 },
                    { new Guid("b80f460d-af38-4956-8f45-481a9c2cbeec"), new Guid("15a49315-552f-4f6a-9f25-001a5f13ce07"), 1, "668174386-2", 96m, 2003, "Roots", 13 },
                    { new Guid("b84e1bcb-fffb-4e59-9cc0-e98b93188eed"), new Guid("edc1ba6b-4403-46f5-bc5d-1ee8ec9a353a"), 0, "852392684-4", 53m, 1999, "Ogre. The (Unhold. Der)", 14 },
                    { new Guid("b86467d6-9530-4c62-90de-46248b214c8b"), new Guid("e1402f0a-6f80-4867-9fbe-1672924d80ee"), 1, "750582939-4", 23m, 2004, "Pekka ja Pätkä Suezilla", 12 },
                    { new Guid("b86ec31d-33d6-482c-9b0c-795bcede8456"), new Guid("82932cb1-0765-466d-940c-55c2bc0ae54e"), 0, "179141328-5", 41m, 2006, "Ruby Cairo", 9 },
                    { new Guid("b8968f08-ed0c-42b6-8cd5-ab09e4e56d85"), new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"), 1, "074351787-3", 77m, 2004, "Pentagon Wars. The", 5 },
                    { new Guid("b91e46f9-74b4-45cf-8d45-53fda87678f0"), new Guid("73bfa88b-6da0-41d0-8e7f-2b344dcc75b2"), 0, "411652952-4", 68m, 2006, "Superman IV: The Quest for Peace", 2 },
                    { new Guid("b923b053-9f21-4746-811e-4097e86ecce3"), new Guid("0d9e7fb6-7bcf-4d62-99c4-8e7a80d6de1a"), 1, "997201045-7", 49m, 2005, "Perfect Murder. The", 7 },
                    { new Guid("b9591666-73e4-4c1b-9ff3-be790bf12830"), new Guid("a7a7194e-dc36-496c-81c4-cd1a4ab2c12f"), 1, "207828133-6", 78m, 2006, "Broken Lullaby (a.k.a. The Man I Killed)", 7 },
                    { new Guid("b95cca0b-bec9-495f-995f-622228b1b9d6"), new Guid("36aea91c-acb2-4370-911f-21ba7e1bdcc7"), 1, "294183924-0", 35m, 2012, "Tall Man. The", 6 },
                    { new Guid("b9b263a3-8c2d-4338-8d2c-25f865d2dd28"), new Guid("013a3381-b4bc-43ab-9298-bbb8baa91078"), 0, "460847397-2", 1m, 2006, "Brothers McMullen. The", 10 },
                    { new Guid("b9bda8fe-33c0-48ac-ad61-32c4ad2b7d4b"), new Guid("a43f4893-ee73-413d-9004-09c6cf5dfe6c"), 1, "408488931-8", 21m, 2012, "Quigley Down Under", 10 },
                    { new Guid("b9e451a4-5a25-4b76-9817-401d87b6358f"), new Guid("25088fd5-59e3-4bab-a47a-d3773560a484"), 0, "346797876-2", 76m, 1994, "Love Crime (Crime d'amour)", 12 },
                    { new Guid("ba05f39f-21e1-4d37-b09b-7150aa1e24e7"), new Guid("053e626e-3b2e-44b7-8740-d69df744a58d"), 0, "318950699-X", 32m, 1999, "Charge of the Light Brigade. The", 13 },
                    { new Guid("ba44dc0d-d9f6-47a9-8dec-bdfa3ba2abc8"), new Guid("05365b7d-37f5-4893-bac9-536e00a91350"), 1, "869118424-8", 76m, 2012, "Babylon", 0 },
                    { new Guid("bb884438-3581-4ba0-b901-51b47a7a3684"), new Guid("e6d2c155-9c3c-463c-98f3-0f7699e65c49"), 1, "178527703-0", 53m, 2004, "Attenberg", 4 },
                    { new Guid("bbd40ec4-cf65-4cf0-90bc-d47d3b11c5c8"), new Guid("06c39c93-720b-45fb-9f20-cde1c13a709a"), 0, "581119230-4", 64m, 2009, "Left Behind", 11 },
                    { new Guid("bcbeb8e9-a0d4-4db0-883e-3f9d5e6f4d07"), new Guid("2720957e-ba8f-4a82-9e53-48813dc91b3b"), 0, "419389383-9", 25m, 2011, "Repatriation", 2 },
                    { new Guid("bd539d32-3b86-405e-8f94-5eb641ce909b"), new Guid("01c064e1-88aa-48c6-be0e-b12ea47cab70"), 0, "915914312-6", 85m, 2006, "Great Gatsby. The", 13 },
                    { new Guid("bda75216-e77c-467c-9d0e-3531feec5039"), new Guid("222d1b79-8267-4798-b881-bab5f6813f71"), 0, "086659594-5", 75m, 2010, "Wild Hearts Can't Be Broken", 2 },
                    { new Guid("bdb8399d-3d13-4001-b218-591034cd7912"), new Guid("0d9e7fb6-7bcf-4d62-99c4-8e7a80d6de1a"), 0, "394878030-7", 91m, 1999, "Posse", 5 },
                    { new Guid("be163664-4597-43f3-bd34-5f775ac56c18"), new Guid("6250a70d-db50-4fe2-9eb0-9220dc1a68ac"), 0, "083661415-1", 100m, 1984, "Three Kings", 9 },
                    { new Guid("be188499-1f23-488b-9f2b-e5dae30f05d4"), new Guid("f3b7ee80-0c64-4e01-a409-ef6a88cc9cfb"), 0, "020445998-2", 99m, 2001, "Nobel Son", 4 },
                    { new Guid("be4392c5-9523-4712-a7d0-b8ea82bbea05"), new Guid("a588eb99-4369-4ba9-83a3-76d84a4bed74"), 0, "685095797-X", 99m, 1990, "Color of Money. The", 8 },
                    { new Guid("be5428ee-f550-41f2-a5aa-8ee33b24f5fd"), new Guid("876412d0-5548-4a28-ab47-e97e5b02876c"), 0, "932817485-6", 89m, 2002, "Suspiria", 3 },
                    { new Guid("be72b837-8835-4434-9859-1f0495bb4f5f"), new Guid("aafbe801-5353-4a9c-88b9-6844e8211e62"), 1, "978656977-6", 96m, 1993, "River Wild. The", 5 },
                    { new Guid("bf2d09ee-ea9c-4e25-a5ed-784067cab09e"), new Guid("6df697c7-6939-4f33-a82e-0dcc75fdca4f"), 1, "911299186-4", 51m, 2006, "Martin Lawrence Live: Runteldat", 4 },
                    { new Guid("bfb1f4ee-d7ef-42ae-9134-04d67ff39e8c"), new Guid("71114bb2-2230-4e41-9533-6d3b34a213ee"), 1, "385501450-7", 23m, 1994, "Louisiana Story", 4 },
                    { new Guid("bfdebe84-ce4d-4f9d-943a-0bbb23e6868b"), new Guid("76393834-3cfc-4e90-86a9-f2ca27953f07"), 0, "470752722-1", 59m, 1999, "Blue Spring (Aoi haru)", 7 },
                    { new Guid("c03200d6-9feb-44b5-afb0-6434c68a34ef"), new Guid("e5928360-c189-4a52-b461-ebe0ec2507d5"), 1, "500416318-9", 94m, 1968, "Extremely Goofy Movie. An", 5 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("c0441877-99fc-42b4-bc8b-f3e748e38409"), new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), 0, "504059500-X", 67m, 1995, "Taken", 12 },
                    { new Guid("c05701dc-ab9b-4337-a4f8-501eeac7bec1"), new Guid("53433646-0e07-4145-bedb-0db50cb74707"), 0, "372586035-1", 43m, 2009, "Bukowski: Born into This", 3 },
                    { new Guid("c1102edf-c8d6-447b-9982-0a321f882ce8"), new Guid("4efcad9f-201a-49c5-a612-e6fd0f8d6c31"), 0, "921606505-2", 15m, 1985, "This American Journey", 7 },
                    { new Guid("c1e5b4eb-697f-4fc3-9231-68e235b7f15a"), new Guid("523558b3-2f92-4869-85d6-99d47981492c"), 1, "350036898-0", 15m, 2004, "Life After Tomorrow", 7 },
                    { new Guid("c1f7d063-3681-45af-b07e-f4ebf076e550"), new Guid("b72ed5a4-9f8e-476a-800f-003e445eb4fd"), 0, "638437056-5", 24m, 2008, "Cloudy with a Chance of Meatballs 2", 11 },
                    { new Guid("c1fc769d-f904-49f6-9510-3bee328f5288"), new Guid("858e6f78-5fe3-484a-b874-7289abb29a4a"), 0, "009674804-4", 83m, 2005, "Green Dolphin Street", 3 },
                    { new Guid("c1ff46ac-6008-48ce-b17f-f7e86bdacde2"), new Guid("52b06a3d-6e38-4e84-9b33-01111f9d4502"), 0, "911423421-1", 68m, 2009, "Purple Rose of Cairo. The", 14 },
                    { new Guid("c2259d67-5927-4e3e-98ae-79e09ab45772"), new Guid("acd774db-b92d-4b71-a6a9-462262f6bd94"), 0, "766925836-5", 91m, 2006, "Broom-Stick Bunny", 14 },
                    { new Guid("c3171133-154b-4eb8-9869-b4468259c9b4"), new Guid("93bb9671-13f7-4d67-82a6-fcaa7d85951a"), 1, "176649538-9", 74m, 1988, "Pumpkin Eater. The", 9 },
                    { new Guid("c38cf1ba-3c11-4d3e-a42c-fb44449b7475"), new Guid("2dc83419-8e8e-4dc1-acef-20ecc8af7807"), 0, "430886165-9", 96m, 2003, "Turn of the Screw. The", 1 },
                    { new Guid("c3fd924d-6327-4ace-b4e7-01b6ad6bc56c"), new Guid("0d5ffc92-f835-466a-b57b-bb5539613e8b"), 0, "332073897-6", 26m, 2009, "Rocketeer. The", 3 },
                    { new Guid("c5337733-8130-44f7-a27a-63fd4f345a49"), new Guid("2f9afb16-d08e-4cb5-9b1e-69a0a4d55491"), 1, "314407863-8", 31m, 2000, "Cochochi", 10 },
                    { new Guid("c5d0398c-ebea-4940-9a60-2aa7c09f23dd"), new Guid("1acdd02d-b47f-4259-ae8c-a39fe7028d02"), 1, "507485673-6", 22m, 2004, "Captain Ron", 14 },
                    { new Guid("c5d89533-b702-4420-8c4b-55916b70e27e"), new Guid("dec7cdcf-a00a-4776-9bff-b7e63fe38b2f"), 1, "449225417-X", 49m, 2006, "Super Mario Bros.", 0 },
                    { new Guid("c6281de4-4897-4084-82e4-686bf1dfffe2"), new Guid("2eefb633-abad-4f17-83a1-ff1e8cd24f4d"), 0, "519796920-2", 39m, 1988, "H.H. Holmes: America's First Serial Killer", 10 },
                    { new Guid("c677b561-9c6d-41df-81d4-03ccfb521a1f"), new Guid("a6e9a2da-b223-44d9-be33-1d1f3ef18b2e"), 1, "337114887-4", 99m, 1996, "Leprechaun in the Hood", 6 },
                    { new Guid("c6a33391-8f3f-46bc-9918-089f43110c7d"), new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"), 0, "519742931-3", 69m, 2011, "Jodorowsky's Dune", 0 },
                    { new Guid("c6ddd7bd-e5e7-438a-bfea-ad8ee2fed1bc"), new Guid("bc5c6376-48e7-4814-97c8-ccb63d2b47d6"), 0, "382647371-X", 86m, 1986, "Sgt. Pepper's Lonely Hearts Club Band", 14 },
                    { new Guid("c720b839-86a1-42b2-9414-ea221c50fd96"), new Guid("7cbe2473-2c54-43f1-9e26-f8cb6c345898"), 1, "737357796-2", 4m, 2000, "Blue Velvet", 10 },
                    { new Guid("c7234cb7-5116-4a78-9da3-b5277e428545"), new Guid("690ae88c-955a-42d6-8bae-cb437f7ffe58"), 0, "777851465-6", 70m, 2001, "Charm School (Niñas mal)", 8 },
                    { new Guid("c7ae13f7-f556-4a15-bf58-1fa541f6a41f"), new Guid("24878f0f-b893-41d7-a296-c054d1b26475"), 0, "337590816-4", 94m, 2006, "Dear Me", 12 },
                    { new Guid("c7c300df-73db-44fa-b5c1-42f497568fd4"), new Guid("7859aa81-14a9-4735-b1f8-f00960d3b342"), 0, "075801686-7", 71m, 1994, "Under Suspicion", 13 },
                    { new Guid("c7c9fe9d-2818-4293-870b-7dc16186a46b"), new Guid("358b3e0c-5255-429b-b66f-060aba39988d"), 1, "177083834-1", 54m, 2012, "Amanece. que no es poco", 3 },
                    { new Guid("c7ff61c2-de02-4627-981b-90142b5ac173"), new Guid("497cd05c-cd43-44bf-9df8-3876ffebd95d"), 1, "538582437-2", 52m, 2001, "Rosalie Goes Shopping", 8 },
                    { new Guid("c8013d86-9baf-4edf-9f93-bb93dd8a5c47"), new Guid("3c58eb92-fbd8-4b60-8565-eecde6a26a71"), 0, "827745956-4", 99m, 1997, "FBI Story. The", 0 },
                    { new Guid("c8551696-ca2e-4254-ad19-6afd3688c667"), new Guid("a47af692-2999-45c7-88a5-75f81a07256f"), 1, "009662152-4", 93m, 2006, "House of Sand (Casa de Areia)", 11 },
                    { new Guid("c8c23d9a-44b1-4605-ba7d-1898365d3e1a"), new Guid("c5526c67-3078-4eca-98c6-5e1ae428d9f8"), 1, "376829070-0", 85m, 1992, "Sensation of Sight. The", 3 },
                    { new Guid("c8d5576a-8e88-444a-9e8c-a93a9505e45b"), new Guid("8bc2fbf2-b8be-420a-ab41-e49c44123753"), 0, "215266294-6", 49m, 2010, "G.I. Joe: Operation Dragonfire", 1 },
                    { new Guid("c95b49f2-ac24-4196-94b6-9f18a9e2d436"), new Guid("a136d6b3-28a6-43b4-912a-7bd9c4fd48de"), 0, "339216826-2", 98m, 2006, "Will Success Spoil Rock Hunter?", 6 },
                    { new Guid("c9c4df72-4dcf-48db-98cf-1c7ab5bc9a2e"), new Guid("b67bf06c-e412-494e-88e9-e4744e067843"), 0, "308364096-X", 75m, 2004, "The Story of Robin Hood and His Merrie Men", 6 },
                    { new Guid("c9cc5f4e-0571-4864-b9de-ea3a9e7ea13b"), new Guid("93b68c62-977c-4fe1-be91-347a8fdb5c65"), 0, "825850294-8", 70m, 2007, "Steve Jobs: The Lost Interview", 10 },
                    { new Guid("ca01c616-6afe-4c32-9da9-644ccef2bcb6"), new Guid("5274cc8f-58b7-46e6-94db-26bc98c974a0"), 1, "659480690-4", 21m, 1989, "Genocide", 3 },
                    { new Guid("caa9c159-3a24-4419-a6dc-d41f8db2325d"), new Guid("a1ceb583-6417-4664-aac4-193be893832b"), 0, "794465986-8", 100m, 2009, "Princess and the Pirate. The", 1 },
                    { new Guid("caf5f1d3-ef25-4757-ba97-585e92d0c26e"), new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"), 1, "047978133-8", 85m, 1996, "Bekas", 4 },
                    { new Guid("cb0ba315-eace-472e-a0f5-af04095eef89"), new Guid("afdc2c84-da2b-4484-9418-19a304712224"), 1, "811651998-0", 62m, 2004, "Hellsinki (Rööperi)", 13 },
                    { new Guid("cbb29bcf-7ab8-430a-a415-c02e038ea8a7"), new Guid("5cf81ef7-3334-4fd4-b443-da781fa1bfe9"), 0, "734401749-0", 22m, 2005, "Miami Vice", 3 },
                    { new Guid("cbfd4d4e-bc49-4116-8a03-c6c86ae6eacf"), new Guid("fa9a2f64-0908-49c8-8afe-d2fc45a83df4"), 1, "549986074-2", 77m, 1993, "Blonde Ambition", 5 },
                    { new Guid("cc03d442-3185-4107-a388-ec989cd2e38f"), new Guid("53c4b47d-9534-485f-a0ad-6a0c9cceba1a"), 1, "134490524-2", 81m, 2003, "Xtro 2: The Second Encounter", 10 },
                    { new Guid("cc3c0270-639a-4b7f-81cf-61ec246fb5c9"), new Guid("fbfecfaa-f915-4006-ae69-6960f7bd5a0f"), 0, "842072068-2", 86m, 2012, "Helen of Troy", 13 },
                    { new Guid("cc8db674-7b5a-40d1-8200-b81dbb07e57a"), new Guid("d1c444b8-aab3-4966-bebd-e8f98c51eb26"), 1, "178514599-1", 26m, 2004, "One for the Money", 9 },
                    { new Guid("ccba83db-1cf5-4ff1-8919-3d4c06576040"), new Guid("04a51c1b-ad90-4882-9acd-377c0ed077c6"), 1, "328907660-1", 10m, 1997, "The Lost Prince", 5 },
                    { new Guid("ccbf04f3-9a8f-4f31-8842-09930e65a1f0"), new Guid("d8e0d053-6f19-4a44-9028-4353a001d71a"), 0, "275714338-7", 62m, 1989, "Tracy Morgan: Black and Blue", 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("ccc53188-406d-450a-99d3-2248f661adb4"), new Guid("71883c85-5cca-49b7-bf9d-ae437f3ba3c4"), 1, "557007359-0", 82m, 1984, "Ice Poison", 12 },
                    { new Guid("ccd60f7d-6bd8-472c-a657-a7a543cda0a9"), new Guid("eb7e4fca-a451-4452-a2dd-7b83e372311a"), 1, "758694375-3", 80m, 2002, "World Without End", 0 },
                    { new Guid("ccfab881-6d99-43ea-a529-4e3cf180ff4e"), new Guid("0cbf4fbf-23c7-4390-b013-dda8b87e6753"), 1, "068928310-5", 83m, 2003, "White Sands", 6 },
                    { new Guid("ccfb2633-d1bd-44ba-9704-427b5ea6ed31"), new Guid("9a497959-c231-4b93-a051-d2d3f921ee41"), 0, "931197593-1", 37m, 1995, "Air Doll (Kûki ningyô)", 5 },
                    { new Guid("cd20dccf-ccb1-486b-a3c7-a97deb4171a2"), new Guid("42ad2b90-d981-4f4a-a669-33d0a199be28"), 1, "567165015-1", 5m, 2004, "Leaving (Partir)", 2 },
                    { new Guid("cd82fbd0-17a6-47dd-95d7-f9534ae135af"), new Guid("24878f0f-b893-41d7-a296-c054d1b26475"), 0, "385797744-2", 66m, 1997, "The Fabulous Baron Munchausen", 0 },
                    { new Guid("cd9442c4-3e42-4995-b08e-f817c9cda0df"), new Guid("00d9a9b2-5d08-4bd3-b854-28228db24210"), 0, "715896740-9", 81m, 2009, "Fateless (Sorstalanság)", 7 },
                    { new Guid("cda1cc3d-ff8d-4e20-96a6-aac26cdafe43"), new Guid("d1cc6af7-d846-479e-8b2d-afc96327c3f7"), 0, "729668561-1", 10m, 2004, "Cradle of Fear", 12 },
                    { new Guid("cdb655df-a528-4170-9d8b-1a78afa5e573"), new Guid("c691ae42-7764-47df-a354-1ed5df0230a3"), 0, "928031393-2", 75m, 2005, "Stand-In", 0 },
                    { new Guid("cdc8822a-e6e9-458b-9b57-1a76dd408b83"), new Guid("e940cd56-6009-4fff-a9fa-2aa0c1d1df4d"), 0, "198208213-5", 96m, 1993, "Midway", 6 },
                    { new Guid("ce123961-4f75-4213-a4a8-86cc537317da"), new Guid("509a3022-49d7-4a78-ac78-ae17f4246dc5"), 0, "810077254-1", 5m, 2009, "Dry Summer (Susuz yaz) (Reflections)", 2 },
                    { new Guid("ce1ae567-7101-4d67-bb34-c18ca5437e7b"), new Guid("1fd4846d-b277-4efe-b9af-04ff8d7e8697"), 1, "639947131-1", 23m, 2005, "Parkland", 13 },
                    { new Guid("ce32a641-7f87-418b-b74f-b2a396b5ac55"), new Guid("a44875d4-7608-4c3b-837b-bc7d912760b9"), 1, "148680121-8", 14m, 1998, "Goldene Zeiten", 5 },
                    { new Guid("ce4c7a28-f541-4a6d-8553-2a793b263a67"), new Guid("991fc667-d805-4de6-9cb3-3081766f90ac"), 1, "998926875-4", 47m, 1993, "Road to Morocco", 8 },
                    { new Guid("ce9c9b81-2b02-4f11-be70-e08ed04afbcf"), new Guid("f23e51a1-c7bc-48c0-ac59-1160a4ef636a"), 1, "021391135-3", 56m, 2010, "Stepford Wives. The", 9 },
                    { new Guid("cea93247-0ebb-40c0-bcc5-0a551588c952"), new Guid("666fdd39-a35e-40a5-b61f-52fbf324895b"), 1, "541464089-0", 37m, 1992, "Riot On!", 12 },
                    { new Guid("cec363b8-5bd7-4d13-81a6-fd681de79107"), new Guid("2eefb633-abad-4f17-83a1-ff1e8cd24f4d"), 0, "478361153-X", 99m, 2009, "Alien Abduction", 8 },
                    { new Guid("cef461c0-de70-494f-ad12-69b0a4302c1e"), new Guid("9ad9a6eb-7a2f-4eec-89a5-eb7500e746cf"), 1, "174830080-6", 33m, 2001, "Stop! Or My Mom Will Shoot", 13 },
                    { new Guid("cf26891a-8415-4555-a563-5ab5ddc2e2ed"), new Guid("97b72887-c52f-4d19-ac99-6b772416e084"), 1, "819232967-4", 95m, 2000, "Last Man Standing", 2 },
                    { new Guid("cf84b90e-bb2f-4bef-a38e-ae93489b9787"), new Guid("5a5738b3-0076-4100-9a95-4a0bc0b0e837"), 0, "040739254-8", 13m, 2006, "Quitting (Zuotian)", 4 },
                    { new Guid("cff33d88-fcc3-4978-8b20-dcd99cc1b1c9"), new Guid("538191e8-5115-410a-8979-245eaf2ee054"), 0, "510046661-8", 77m, 2011, "Mine Games", 6 },
                    { new Guid("d002219a-aab9-457d-841d-f0ebe0f2bf08"), new Guid("a2f76f52-8aa5-4ce4-b11b-138586c1af09"), 0, "950289853-2", 84m, 1992, "Secret Beyond the Door", 13 },
                    { new Guid("d02f0a8b-b309-44bc-b42b-bb8b3a3ca9bf"), new Guid("8e172b22-464d-4821-9e44-42930a56bba8"), 1, "948728718-3", 74m, 2012, "Savage Grace", 2 },
                    { new Guid("d03dd4f7-7b18-49ec-95be-611c59b75eaa"), new Guid("69a396b6-43f2-416e-a00e-b3adfea00c88"), 1, "049396704-4", 78m, 2001, "Such Is Life (Así es la vida...)", 0 },
                    { new Guid("d094e32b-7219-412b-965a-597ce4c87485"), new Guid("ea2797dd-7097-4cd1-8ff5-ee735807634e"), 0, "310904449-8", 11m, 2004, "Michael Shayne: Private Detective", 12 },
                    { new Guid("d0baf860-e31a-40bf-b566-0cf6a2a2c93e"), new Guid("f3bf4c79-af62-4b46-9113-eda5243d5701"), 0, "163624874-8", 41m, 1998, "Two Men in Manhattan (Deux hommes dans Manhattan)", 10 },
                    { new Guid("d0d1ead0-cc71-4045-852c-3f5ffcc27b74"), new Guid("fe7c3a03-2532-4d05-b18c-cfcc0138ef77"), 1, "385503632-2", 25m, 2012, "Immortals", 13 },
                    { new Guid("d1a082f7-3abf-4d22-8849-ee57b7dcab39"), new Guid("70139c7a-6c13-4bdb-87d4-c1694e025026"), 0, "800100115-6", 19m, 2012, "Kind Lady", 2 },
                    { new Guid("d1ba7da7-0299-4b0a-83d1-2aa87d501e1f"), new Guid("ac92d821-cfcb-447a-9b8e-db0cac64522a"), 0, "393729560-7", 88m, 2004, "Hunger Games: Catching Fire. The", 14 },
                    { new Guid("d1d0f1a6-ca02-4921-ae47-ddbe40416647"), new Guid("ed3a8060-b3db-4a19-8c33-20be4acb9208"), 0, "124768235-8", 89m, 1999, "Other Woman. The", 11 },
                    { new Guid("d1e5474d-3ee4-4f00-9f61-1e735c788ee4"), new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"), 0, "772834303-3", 78m, 2002, "Winter's Bone", 8 },
                    { new Guid("d2864754-1341-4495-83c1-d934e678c582"), new Guid("683f62ac-33ee-45f8-8a5e-721d1b0fbd56"), 0, "855478553-3", 42m, 2009, "Canadian Bacon", 8 },
                    { new Guid("d297b5fb-f053-4543-8c16-9d42d8f5f9b3"), new Guid("c1c5bb1b-8d69-4598-b93c-a4bf48066d24"), 1, "535674046-8", 66m, 2000, "These Amazing Shadows", 7 },
                    { new Guid("d2be970e-c38e-4665-bf3a-f1bd2faf22ab"), new Guid("5153f2b1-06af-4b0b-a683-38adda2bd667"), 1, "915653800-6", 30m, 1996, "Iceberg. L'", 6 },
                    { new Guid("d2ce471a-d64c-4fe9-9ef3-c9f6d0488f16"), new Guid("356b1cdb-dc3e-43c8-bf59-633b1679855d"), 1, "963090704-6", 62m, 1986, "I Was Monty's Double", 7 },
                    { new Guid("d2dbd92d-0d13-4738-b76c-23f8d53626fd"), new Guid("4e2a968f-ca49-4ba1-8f4d-550092163bc5"), 1, "483942274-5", 87m, 1995, "Old Dark House. The", 4 },
                    { new Guid("d3124e22-717c-4b39-b8b9-04d385081204"), new Guid("25b79ec2-1697-4225-8c1b-300f80dc54b2"), 0, "303438820-9", 45m, 1995, "Osterman Weekend. The", 13 },
                    { new Guid("d3370780-ee8d-4740-8c4b-1736dbfc2e1e"), new Guid("e8e1e594-ab50-4f08-9a3b-50e404969608"), 0, "995788709-2", 2m, 1999, "The Emperor of California", 0 },
                    { new Guid("d3cbb0a2-91c1-4dc1-b244-3fecddfae382"), new Guid("6b8771aa-7664-4f7b-87f6-b3457b68374a"), 1, "331488880-5", 74m, 2002, "Chronicle", 6 },
                    { new Guid("d3cd69ca-d42d-4b77-9d30-68d17a8be611"), new Guid("b39bc32c-dd43-4027-b289-dad680195b2e"), 1, "601076678-8", 76m, 1999, "Gun in Betty Lou's Handbag. The", 10 },
                    { new Guid("d433eb44-114a-4daa-82f1-b940c8121d4f"), new Guid("20b52943-cc85-4aca-846f-79f990d0a7b1"), 1, "932604289-8", 62m, 2009, "Like Mike", 3 },
                    { new Guid("d43e6548-a6b2-4454-a70e-89a116296417"), new Guid("fbd14cbb-a961-4de7-b7e3-c40c2cf65528"), 1, "360411768-2", 45m, 2012, "Macon County Line", 3 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("d4593fd1-7d68-404b-82e8-c7f7f8189717"), new Guid("16ff18f0-4057-4958-8507-3c9771cc9c58"), 0, "221039379-5", 17m, 2007, "She's So Lovely", 12 },
                    { new Guid("d496c5ee-0415-4d11-9163-5362da48a78c"), new Guid("c3edc96c-896f-4475-a3c7-38fd3e4741a8"), 1, "667358568-4", 61m, 2007, "Bear with Me", 7 },
                    { new Guid("d4a25134-ff1a-4c0f-b00a-c5e26fdd527f"), new Guid("8e3c13b0-12ad-4e03-a097-560841a5733e"), 1, "728323093-9", 94m, 1999, "Something Ventured", 3 },
                    { new Guid("d50a62c3-611f-4caf-a566-9f7d1330da7a"), new Guid("f3a2d422-e9ce-4bda-93b1-6c6c05d9bb1e"), 1, "142037426-5", 36m, 1997, "Series 7: The Contenders", 4 },
                    { new Guid("d53ff9cb-ef3b-423f-b0dd-48e4f0a6fdf7"), new Guid("3c58eb92-fbd8-4b60-8565-eecde6a26a71"), 0, "983127117-3", 16m, 1992, "PT 109", 11 },
                    { new Guid("d543985c-192d-48c0-a473-c44bb10def6d"), new Guid("476fe0f7-149c-4156-b46d-519d01fa7bb1"), 0, "968526796-0", 97m, 1993, "Osama", 11 },
                    { new Guid("d587480d-d368-4671-a0eb-a7e13f8aaddd"), new Guid("f27a9091-2656-4dab-bea3-4053184a42d3"), 1, "027080114-6", 68m, 2005, "Lovely Bones. The", 1 },
                    { new Guid("d65d27a1-220f-4a7e-99e7-8d86298f63d8"), new Guid("76e57b14-7f0c-4110-9fe5-ae82a426fa1a"), 0, "468971922-5", 71m, 1992, "Megacities", 9 },
                    { new Guid("d67532d9-e190-40d9-9467-48347492d3e1"), new Guid("8fd75b4f-e4c5-4e9e-83be-1e239089f8b9"), 0, "854166766-9", 72m, 1997, "Zero Tolerance (Noll tolerans)", 11 },
                    { new Guid("d6cfa3f6-8061-4828-a787-8c157fad5c11"), new Guid("7d761b80-085d-43e6-bb2c-effe2393d35f"), 0, "224843276-3", 12m, 1993, "Planet of Dinosaurs", 8 },
                    { new Guid("d711ecc5-f307-4636-9192-fc7e7f85e7e0"), new Guid("36175c6b-85bd-4615-bb1f-456391811718"), 0, "636581219-1", 67m, 1986, "Pecker", 10 },
                    { new Guid("d72a41c0-bc18-4bd6-8042-65f15959bf22"), new Guid("5a5738b3-0076-4100-9a95-4a0bc0b0e837"), 1, "832913444-X", 47m, 1999, "Carandiru", 4 },
                    { new Guid("d7c281d4-0f2e-432a-ace3-c8273ea34aba"), new Guid("e625ce4e-cec8-433c-bb00-38923eab6db5"), 1, "071070726-6", 53m, 2011, "Date and Switch", 3 },
                    { new Guid("d7c5792c-063a-4ea3-bc1b-1a0c2ba066f0"), new Guid("131b5100-5a51-4590-818b-b3512bfd116d"), 1, "368832808-6", 95m, 2011, "Kiss Me Deadly", 1 },
                    { new Guid("d7dcf94b-3e7f-485b-baf9-ad31c9e82193"), new Guid("63d55e93-538b-4c21-84b9-9d51a8e0ffff"), 0, "176334935-7", 74m, 1997, "Guardian. The", 4 },
                    { new Guid("d80ad946-d1a9-4ab3-a8cb-fb12fc714e78"), new Guid("cb081f39-a330-43f8-bf31-8fa8d4b23320"), 1, "908034511-3", 74m, 2000, "On the Line", 3 },
                    { new Guid("d831c1ce-4eaa-4ef9-8df7-bbf37b8c0466"), new Guid("994545f1-93a4-4482-a9e1-98a76169206f"), 1, "834637148-9", 100m, 2011, "Harvard Beats Yale 29-29", 13 },
                    { new Guid("d846c10e-1d12-44f8-a9a5-82ee9b932e34"), new Guid("73bfa88b-6da0-41d0-8e7f-2b344dcc75b2"), 0, "460903392-5", 8m, 2004, "Brightness (Yeelen)", 10 },
                    { new Guid("d862b4c9-5c07-40d0-8038-a8b68b8d533a"), new Guid("3220ed37-c604-47ae-a724-fd7b68bd6e83"), 1, "225920520-8", 56m, 1993, "Alive", 7 },
                    { new Guid("d86cc588-9a26-4197-9e83-c9b1e3c53929"), new Guid("34b4c9ac-5700-4e88-914a-e2da78e1b8bd"), 1, "873675686-5", 87m, 1997, "Alone in the Dark", 2 },
                    { new Guid("d8b25f0d-e17f-4a23-a31f-df2001d77b28"), new Guid("356b1cdb-dc3e-43c8-bf59-633b1679855d"), 0, "787130561-1", 7m, 1992, "China Seas", 11 },
                    { new Guid("d95c1c89-ec25-4844-b6be-d4bd4fa270b6"), new Guid("58426ca4-5446-47d5-b91a-d317fbfdc525"), 0, "293373661-6", 90m, 2001, "Savages. The", 9 },
                    { new Guid("d9fcad8f-90e4-4330-970a-b7dac30e920b"), new Guid("67d73496-4831-4b92-a231-4ac7866fc28e"), 1, "532544560-X", 74m, 2010, "G.I. Joe: Operation Dragonfire", 11 },
                    { new Guid("da56d9b0-8026-412e-9321-337c7c74f16c"), new Guid("18d5a51c-632e-451d-a3e1-9ca5fb484154"), 1, "863492663-X", 32m, 2006, "Auntie from Chicago. The (I theia apo to Chicago)", 12 },
                    { new Guid("dab6d798-769b-4d23-8a22-ef25cbeda1e5"), new Guid("dbe83457-7531-455f-b744-3d3a84708905"), 1, "293849095-X", 39m, 1985, "Bleach: Fade to Black (Bur&#299;chi Fade to Black Kimi no Na o Yobu)", 3 },
                    { new Guid("db4ccf50-e33d-406e-bc40-308f237e5811"), new Guid("e52bd501-3258-4414-a396-b891f047dac9"), 1, "530930469-X", 24m, 1999, "Camel Spiders", 1 },
                    { new Guid("db5de08e-2190-4779-8607-22f9a5d828fa"), new Guid("c4f3e616-6dde-4be6-a88b-e49a1b290833"), 1, "571194126-7", 61m, 1995, "Open Your Eyes (Abre los ojos)", 5 },
                    { new Guid("db6a42d4-8361-4fd8-82e3-ccf769d9632c"), new Guid("7380d008-4710-45ee-aff4-9b69627d8fa0"), 0, "116544000-8", 13m, 2009, "Once Upon a Time in Mexico", 13 },
                    { new Guid("dbea7539-07eb-45ed-8ac8-855c49ed35f5"), new Guid("1cdafbde-7fb3-4e75-91c9-c2b69ccdc54d"), 1, "459249149-1", 18m, 1997, "Shutter", 1 },
                    { new Guid("dbeb763d-a3f4-43ce-b7ca-187f3d31ae9a"), new Guid("a5114f33-615c-4c6f-8e19-d1d06ca3ee9a"), 1, "786302222-3", 80m, 2009, "Era of Vampires. The", 10 },
                    { new Guid("dc019e37-a099-4959-a95d-bcd3d9cbeb36"), new Guid("dd0d613b-d3d8-4bd4-b2c0-35cc5aeb3309"), 1, "169530096-3", 29m, 2006, "Rudderless", 9 },
                    { new Guid("dc370814-a550-416f-b44c-d5c2cfeae529"), new Guid("be5902e9-595e-4743-8004-bb0e46b60b7a"), 1, "134646898-2", 92m, 2004, "Ismael", 9 },
                    { new Guid("dd839038-2a2a-4a8b-9601-9162ec5e2299"), new Guid("0ecb8f16-d362-47aa-bd8f-aba5cb67891e"), 1, "349178006-3", 22m, 2008, "Treeless Mountain", 10 },
                    { new Guid("ddc92b4f-b392-41f2-a530-b061e713eafc"), new Guid("a1e54121-e8e2-4973-b49c-1f74c10ed69e"), 1, "929741454-0", 80m, 1994, "Black Moon", 11 },
                    { new Guid("dde927af-5ef2-4e8b-8c15-b42c4db6d086"), new Guid("b5175300-5141-40a8-beb3-0e0cc8c6fd91"), 1, "356995155-3", 3m, 2011, "Arranged", 1 },
                    { new Guid("de6d607c-2851-45a1-9f3e-ad49f867023f"), new Guid("689130df-80ce-4f32-b945-4e0ce3ed0c02"), 1, "942291198-2", 28m, 1996, "Steel Magnolias", 11 },
                    { new Guid("de830292-bc87-4beb-9f60-34b4b6c52b39"), new Guid("af862d57-03a2-4c61-8839-02eb30a1b1b1"), 0, "797752663-8", 62m, 2008, "Trapped in Paradise", 4 },
                    { new Guid("dec97035-c62d-4be6-80b8-a9d815b35899"), new Guid("85f36fb3-82f1-4955-9850-77c4b336cc5e"), 1, "388354085-4", 37m, 2002, "My Way Home (Így jöttem) ", 7 },
                    { new Guid("df0b97fb-2129-4347-8e5b-aaa39bfea324"), new Guid("b7757b09-09fa-40cf-8ba0-09231500e6ac"), 0, "410361301-7", 32m, 1996, "Choices", 8 },
                    { new Guid("df0ea970-7759-4277-83b8-ede5ae1d19ad"), new Guid("6362ec8b-4798-4485-9d78-09a367dbd7ae"), 1, "013997173-4", 61m, 2008, "Boy. Did I Get a Wrong Number!", 1 },
                    { new Guid("df26b26b-6fa0-4cc3-aec4-141726f120a8"), new Guid("d4d2e293-5511-4e22-9df3-b688af486135"), 1, "057510443-0", 91m, 2010, "Patterns", 8 },
                    { new Guid("df2c78c7-856c-4df9-bad0-2cad48926562"), new Guid("c30d297c-daed-48ef-a4f1-8950291e56ff"), 1, "388844783-6", 82m, 2011, "Find Love", 7 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("df81cfdf-0eb5-46cb-918f-51843568a5f7"), new Guid("7aa41135-6051-486d-8eee-4ae624f43516"), 0, "839517593-0", 49m, 1994, "Green Wave. The", 14 },
                    { new Guid("dfb85d5f-7acf-4252-8108-9873eea8406b"), new Guid("90b53bcd-c664-4424-870e-f26a379f38fc"), 0, "659132382-1", 71m, 2008, "Patch Adams", 11 },
                    { new Guid("dfecae39-fd44-4057-80cb-6a528ebe6a1b"), new Guid("4a89df1e-4263-4bd3-b3f5-ec47d399ef7f"), 1, "252846268-9", 77m, 1999, "Dolemite", 1 },
                    { new Guid("e03bc2cf-6b43-4fff-b5a0-af912b6c2db3"), new Guid("27e4a68f-3394-4846-963b-e4fead16dedb"), 0, "998019544-4", 49m, 2012, "Wing Commander", 7 },
                    { new Guid("e03ea270-36f6-4590-a1f7-417b306f307e"), new Guid("ff54134d-ee85-4c4f-b8f6-60d704d65ecf"), 1, "480572671-7", 97m, 2005, "Tammy and the Bachelor", 13 },
                    { new Guid("e07c67e2-7c42-42bc-ac82-cb3d6d7eb105"), new Guid("82932cb1-0765-466d-940c-55c2bc0ae54e"), 1, "577372936-9", 82m, 1989, "We Have a Pope (Habemus Papam)", 1 },
                    { new Guid("e0c3a90f-a6fd-476a-aa27-84ab785eaa17"), new Guid("ee8e3c8c-a3df-430b-8e07-98267892abe7"), 0, "799965347-0", 84m, 2013, "What to Expect When You're Expecting", 6 },
                    { new Guid("e105bf9f-352c-4117-bb5c-439b4c419e03"), new Guid("76393834-3cfc-4e90-86a9-f2ca27953f07"), 0, "957671586-5", 74m, 2011, "Rise of Catherine the Great. The", 5 },
                    { new Guid("e1b2a8d0-38eb-43e2-a5a8-e00ab7c98e89"), new Guid("ad5bcddb-97d2-44fa-92f9-d052bd6c04b7"), 1, "233185671-0", 26m, 1999, "Society", 14 },
                    { new Guid("e2367659-8f27-476c-8ae6-4ba3acd75ad4"), new Guid("6727637f-0d96-41bb-8a71-3ed377bff5bf"), 0, "764749100-8", 27m, 1997, "Touchback", 1 },
                    { new Guid("e23b0061-8492-4d42-8233-cc6414fbc2c3"), new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), 0, "932953454-6", 21m, 2008, "Carbine Williams", 8 },
                    { new Guid("e25c9eb4-5cd6-4e6f-9b76-11e160f95c9d"), new Guid("3509cb67-69dc-4549-8169-e4d6b06df798"), 1, "801001383-8", 50m, 2010, "New Leaf. A", 9 },
                    { new Guid("e2a2e5fb-785f-42ee-acc9-d2a43e512e5f"), new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"), 1, "516528737-8", 50m, 1993, "Spellbound", 13 },
                    { new Guid("e2d969e9-25d2-4d44-844a-46e13e25eb92"), new Guid("af027d77-54e8-417e-b2b0-e40479c99b94"), 1, "754352088-5", 64m, 2009, "Notes on a Scandal", 2 },
                    { new Guid("e2e81502-9a18-4b85-af0e-4f229313a782"), new Guid("b164b077-7332-44dc-a1ab-ada58c3bcb0c"), 1, "530276510-1", 37m, 2000, "America 3000", 2 },
                    { new Guid("e3011400-8e92-4177-8108-31e33166d5d1"), new Guid("8a626998-9601-4e54-a607-3144cbc8c87f"), 1, "833808758-0", 5m, 2010, "Locke", 12 },
                    { new Guid("e316fc38-72e8-4764-96b6-fbfec7e893d7"), new Guid("fabd77ff-2ad4-4544-b230-3d126e61d213"), 0, "611919050-3", 12m, 1994, "What a Girl Wants", 9 },
                    { new Guid("e3273abc-e169-4857-97f3-ea510f7c02cc"), new Guid("3509cb67-69dc-4549-8169-e4d6b06df798"), 1, "667244611-7", 14m, 1992, "Kwaidan (Kaidan)", 5 },
                    { new Guid("e32ed32d-4bfb-4bad-ab44-5181fbe081e9"), new Guid("5153f2b1-06af-4b0b-a683-38adda2bd667"), 1, "954356390-X", 4m, 1988, "Evidence", 14 },
                    { new Guid("e34f0a64-697c-4e48-9693-01bae181fa98"), new Guid("f9fba363-d267-4248-955f-f9bc632d6737"), 0, "685675445-0", 7m, 1995, "3some (Castillos de cartón)", 10 },
                    { new Guid("e3753375-2b84-46f9-a7ee-c6bde4b289fa"), new Guid("5d925066-b8ce-4bba-b3d4-7d179a339e13"), 0, "951793669-9", 66m, 2009, "Henry & June", 1 },
                    { new Guid("e3e54b58-765a-4328-b9fe-7453f40bde4a"), new Guid("c7df2366-2784-450c-b014-d58ed22de0a7"), 0, "327214942-2", 8m, 1995, "Head On", 5 },
                    { new Guid("e40467c0-d718-4127-bdee-e9e0daea01d9"), new Guid("84f921ca-680a-4203-8346-9e8972ebb1a3"), 0, "539105534-2", 17m, 2006, "Goemon", 0 },
                    { new Guid("e4149b95-0378-485d-8fc4-f66d8188178a"), new Guid("75219ab1-3a27-46dd-b651-797b6a6f20d9"), 1, "351741357-7", 36m, 1998, "5th Day of Peace (Dio è con noi)", 2 },
                    { new Guid("e443b3a0-8590-46fb-a355-c1404e6e2530"), new Guid("aa1a2ded-0229-4f1a-ae8c-5f80d0cbee38"), 0, "043933009-2", 93m, 2006, "Sinister", 1 },
                    { new Guid("e454781c-f7a6-4a37-90cd-4070369f3d46"), new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"), 1, "384292141-1", 12m, 2011, "No Way to Treat a Lady", 12 },
                    { new Guid("e47b8f48-6e58-4ab2-a1a2-15a4232ba13b"), new Guid("e80fd575-c9eb-408d-8f1d-cb9d434c7ea6"), 0, "037548804-9", 37m, 1994, "Just Like Brothers (Comme des frères)", 6 },
                    { new Guid("e495cd30-50ec-4379-afd8-11dd34d30745"), new Guid("25b44da4-0905-40c9-8f98-1be78cb9a2cf"), 1, "772181027-2", 90m, 1997, "Broken Sky (El cielo dividido)", 14 },
                    { new Guid("e4d89323-ce60-4445-94e4-4b91abf38f7b"), new Guid("1a5d8925-407a-4ca7-bc00-66e78e78d0a1"), 1, "980295761-5", 47m, 1998, "Ted Bundy", 11 },
                    { new Guid("e4fcb02c-8bdf-4b5a-8a3b-ae147bb3310f"), new Guid("05a64888-2a8f-43e6-8920-3b4591773c9d"), 1, "602597488-8", 2m, 1989, "Foreign Affair. A", 5 },
                    { new Guid("e5ec7d00-3c78-48ba-b862-6e4f72ee80d1"), new Guid("8eb3b3ab-dc56-4722-8307-63aeaab37f60"), 0, "665255721-5", 92m, 2001, "Say It Isn't So", 1 },
                    { new Guid("e61dfbf2-648d-44c1-99db-18c507cafc44"), new Guid("a6e9a2da-b223-44d9-be33-1d1f3ef18b2e"), 0, "206237926-9", 12m, 1999, "Long Walk Home. The", 14 },
                    { new Guid("e62da17d-1520-4fae-8903-a919c9303953"), new Guid("f9f5f912-3053-4fd6-af8b-82aab72026b8"), 1, "231517263-2", 45m, 2006, "Exterminator. The", 6 },
                    { new Guid("e657819c-78c1-49f9-b705-f038711f4cc5"), new Guid("67454c28-8495-457f-8b7e-37afc6ca598f"), 0, "613638106-0", 95m, 2005, "Point Blank (À bout portant)", 3 },
                    { new Guid("e71ad76f-ce89-4937-a0c2-1ec3055b3786"), new Guid("86ed9210-beca-4454-8457-15c80ef05071"), 1, "339272776-8", 76m, 2001, "Stage Fright", 6 },
                    { new Guid("e77de915-a3a4-4be6-aaaa-ba178319d51c"), new Guid("d63bbf5d-554d-4a1a-a33f-6b249925f6a8"), 1, "431862441-2", 71m, 1990, "Korczak", 1 },
                    { new Guid("e79466c8-31bc-41d5-a37e-25b5b421abbd"), new Guid("3658895a-82dc-4179-94ef-700fdb6d98de"), 1, "236444509-4", 72m, 1998, "Halloween 4: The Return of Michael Myers", 10 },
                    { new Guid("e83d28a4-4228-4750-903f-975c6df29935"), new Guid("eb5c449a-303e-4f73-a386-cd79ea2e5d88"), 1, "865887866-X", 84m, 2004, "Thérèse: The Story of Saint Thérèse of Lisieux", 11 },
                    { new Guid("e8761e11-33c2-41e8-9217-929451996ab7"), new Guid("55d8b245-4396-4afb-811a-166e6dc1eccd"), 1, "650603034-8", 64m, 2011, "Snow Queen", 13 },
                    { new Guid("e96060f7-8673-415e-9c5e-c0ce6d20d281"), new Guid("d22a10fa-799e-4002-8f44-114d84f49a1f"), 1, "746675857-6", 52m, 1992, "Stroker Ace", 11 },
                    { new Guid("e979719d-143e-4d34-b6a8-39289fecff45"), new Guid("ef76794a-1c1b-4b5f-aea6-66120cdd4c87"), 1, "295406565-6", 98m, 1988, "Faraway. So Close (In weiter Ferne. so nah!)", 5 },
                    { new Guid("e9b82c06-6484-43e3-81f0-824d7c0ecd86"), new Guid("6c116e93-222e-4813-bd35-97af4e0626eb"), 0, "560589408-0", 61m, 2011, "Music From Another Room", 10 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("ea213838-3f39-4661-bb61-c2a3ad7d6f0b"), new Guid("7380d008-4710-45ee-aff4-9b69627d8fa0"), 1, "369939049-7", 68m, 1962, "Valet. The (La doublure)", 3 },
                    { new Guid("ea9a90e9-03bc-4815-9e92-1079a93f1746"), new Guid("aebf2bd6-1904-43fd-9b2f-c06fdc04f541"), 1, "569961546-6", 55m, 1994, "Autumn Spring (Babí léto)", 7 },
                    { new Guid("ebe37393-ee97-4f08-936a-c1216717735f"), new Guid("ec4aa741-496b-4a52-822f-1099d218f328"), 0, "105768475-9", 22m, 1994, "Man Who Wasn't There. The", 6 },
                    { new Guid("ebfc1e4c-f4f9-464c-affa-1a27f5ec901e"), new Guid("620a9cd1-b46f-46a0-8989-25d4d2884537"), 1, "638338952-1", 94m, 1989, "Wonderful Crook. The (Pas si méchant que ça)", 1 },
                    { new Guid("ec553e43-855b-4bab-928e-99b099eda37f"), new Guid("99771a9f-d0de-49cd-a9b0-c84e9b4bdf8a"), 0, "040081946-5", 64m, 2006, "American Outlaws", 7 },
                    { new Guid("ec808924-7747-4d33-9712-2019136e22eb"), new Guid("8e172b22-464d-4821-9e44-42930a56bba8"), 1, "453895162-5", 31m, 2001, "Lion in Winter. The", 6 },
                    { new Guid("ed3ec982-a171-47fd-b51a-baf3cd74a69b"), new Guid("020c5e81-7f10-431e-9c35-a9529f348081"), 1, "451974263-3", 73m, 2012, "Crackerjack", 6 },
                    { new Guid("ed4c1f34-c2cb-4819-a86c-a148e9091ef1"), new Guid("c1edd66b-8a9b-47e1-9e05-f38b31f6a079"), 1, "828593803-4", 11m, 2009, "Wartorn: 1861-2010", 10 },
                    { new Guid("ed62fd24-eb63-4b51-bed6-d54c58d37602"), new Guid("37fad513-a1b0-4330-ba5c-37b735bcbeff"), 0, "935382154-1", 87m, 1988, "Free Samples", 9 },
                    { new Guid("edbaf184-fd09-457b-874d-40f4b90b3301"), new Guid("8d325859-3e3a-4f81-a33d-222d73760e31"), 1, "530986222-6", 44m, 2006, "Ghost Rider", 0 },
                    { new Guid("edd81c9f-a17a-4304-8e59-587f57da3f3b"), new Guid("4c538209-246d-4705-ae9e-415a4779fdec"), 1, "229462259-6", 53m, 1966, "Awful Dr. Orlof. The (Gritos en la Noche)", 6 },
                    { new Guid("ee220529-b02c-4f38-84a1-a5dd3fe1ef66"), new Guid("9bba696d-9d79-4338-a1ab-e214d32254a0"), 1, "607279434-3", 57m, 1998, "Godard's Passion (Passion)", 9 },
                    { new Guid("eefd25d4-1308-4542-a19c-eec71c618cb0"), new Guid("ff733029-b575-43d4-b993-ffc9e0cf1feb"), 0, "889867700-6", 80m, 2000, "East. West. East: The Final Sprint", 13 },
                    { new Guid("efc7a569-7219-435d-b385-dc22537c8979"), new Guid("f48e6883-2966-4822-8433-b18d619808ea"), 0, "435193628-2", 47m, 1994, "For the Bible Tells Me So", 8 },
                    { new Guid("efd12544-51ea-45e6-a214-bc999caeef24"), new Guid("49a1dc0e-6bc2-4289-80b3-4c61a85dd633"), 0, "058872852-7", 64m, 2004, "Death Takes a Holiday", 3 },
                    { new Guid("f0985f73-82bd-4e3b-89ae-94591e306a17"), new Guid("5a7ea557-47a8-4b28-be39-90b80c104170"), 1, "387835327-8", 2m, 1987, "Love God?. The", 0 },
                    { new Guid("f0c94851-8e4c-4c35-9360-a5d513a5c2bf"), new Guid("cdb9dfb7-70ab-4066-bf0a-a4efbccb1500"), 0, "835478909-8", 93m, 2004, "Slaughter Rule. The", 6 },
                    { new Guid("f0edc3c3-1916-4dff-8b30-6ad977ca6c5b"), new Guid("d8e9849e-557f-4593-b9e5-d4e6b0198199"), 0, "559830187-3", 15m, 2006, "Strangers When We Meet", 13 },
                    { new Guid("f15eba83-1b2e-4e03-940b-192331b7830a"), new Guid("fe7c3a03-2532-4d05-b18c-cfcc0138ef77"), 0, "771213887-7", 54m, 1997, "Little Dorrit", 5 },
                    { new Guid("f17763ad-9dfb-4436-90b9-db2273f16e96"), new Guid("dd0d613b-d3d8-4bd4-b2c0-35cc5aeb3309"), 1, "773120524-X", 56m, 2005, "Dinner for Schmucks", 0 },
                    { new Guid("f177c48f-bf3e-4ef4-af79-97c3544ff967"), new Guid("fe69727f-3a9c-45b6-98ff-40e2fcabf918"), 0, "868925474-9", 38m, 1995, "Uptown Saturday Night", 7 },
                    { new Guid("f2508e98-dd3c-474f-98bf-17fa9744ec5e"), new Guid("c04bbafd-405b-4d69-85ce-3675e5d36372"), 1, "816868379-X", 71m, 1992, "Same Old Song (On connaît la chanson)", 13 },
                    { new Guid("f2e733de-a39c-4815-a8bd-b391877aed4e"), new Guid("25b79ec2-1697-4225-8c1b-300f80dc54b2"), 1, "051456800-3", 20m, 2003, "Employees' Entrance", 6 },
                    { new Guid("f33e9a05-c164-4fd1-ac4f-c6225c9c2ac2"), new Guid("b332f0d9-946f-4d7d-b546-60bc208688d6"), 0, "025365719-9", 98m, 1990, "Whore", 8 },
                    { new Guid("f3cf83af-afc4-4d6e-bf5d-c3a46f159ac9"), new Guid("99aa0c17-bd53-4170-a9c3-b8405978d00f"), 1, "656406801-8", 92m, 2000, "Mr. Saturday Night", 13 },
                    { new Guid("f475ca8c-34f7-461c-b272-3e56b0bcc931"), new Guid("689130df-80ce-4f32-b945-4e0ce3ed0c02"), 0, "701164596-9", 53m, 1989, "Mortal Kombat", 14 },
                    { new Guid("f4788c50-c1a5-4d1e-9770-e0c94764e5b6"), new Guid("9fad2647-6ef9-45d0-9a84-7b97aa226c7e"), 1, "213715863-9", 69m, 2009, "Detour", 14 },
                    { new Guid("f4833dae-74bb-4d59-b344-a0c8e6039670"), new Guid("af027d77-54e8-417e-b2b0-e40479c99b94"), 1, "880396054-6", 55m, 2010, "Chelsea on the Rocks", 2 },
                    { new Guid("f4bb710e-6ab4-42a5-99b0-fd2b97fe1900"), new Guid("d1c444b8-aab3-4966-bebd-e8f98c51eb26"), 1, "476244771-4", 16m, 2010, "Syrinx", 6 },
                    { new Guid("f4d4e147-3f70-4591-8271-d44aae8700d3"), new Guid("5eba6825-745d-4bf9-ae68-5216f0e7d617"), 0, "163441510-8", 55m, 2010, "Pontypool", 4 },
                    { new Guid("f4f86abf-78e2-4499-987c-1c8d43fd0ed7"), new Guid("75068271-5119-49f7-8c2a-c8aafe5db994"), 1, "036796407-4", 19m, 1984, "No Time For Sergeants", 8 },
                    { new Guid("f4fafe2b-f558-4b52-818d-591ff0f5c26a"), new Guid("858e6f78-5fe3-484a-b874-7289abb29a4a"), 1, "509863034-7", 83m, 2006, "Winslow Boy. The", 13 },
                    { new Guid("f510e4ae-26c5-4a3c-a460-323b86e9172f"), new Guid("5d497ab4-fa1a-405e-9c7b-13d86705e5f5"), 0, "179964905-9", 100m, 1993, "Beau Serge. Le", 8 },
                    { new Guid("f52678d5-3a99-4c91-af4f-4c67f2f8d7c1"), new Guid("8e4ca83c-b184-4f17-a313-218ebb721134"), 0, "523716852-3", 9m, 2012, "Gods Must Be Crazy III. The (a.k.a. Crazy Safari) (Fei zhou he shang)", 4 },
                    { new Guid("f528ad0f-de2a-45ba-82db-dbb463a21ecf"), new Guid("b39bc32c-dd43-4027-b289-dad680195b2e"), 1, "385079932-8", 76m, 1989, "Elstree Calling", 7 },
                    { new Guid("f532db27-28fc-4ffe-b820-47ddddf2b325"), new Guid("0d685706-c9a5-412c-b296-4e4f99d25500"), 0, "165304135-8", 35m, 2009, "Problem Child 2", 0 },
                    { new Guid("f583b94d-4ccb-44f0-b683-c5439af1b70d"), new Guid("994545f1-93a4-4482-a9e1-98a76169206f"), 0, "122895873-4", 36m, 2009, "Bicycle. Spoon. Apple (Bicicleta. cullera. poma)", 9 },
                    { new Guid("f5dc651e-1fe8-42d7-aa95-ca1b1bb409c7"), new Guid("ace68f80-9a57-4129-9e09-436ea1d736c2"), 0, "111635647-3", 42m, 1988, "Brothers Karamazov. The", 0 },
                    { new Guid("f5ec98c7-999c-40eb-9de4-25065cf7a31e"), new Guid("09e76b31-202b-49d4-b117-e28c6e21a6db"), 0, "751854111-4", 6m, 2008, "Hunt for Red October. The", 1 },
                    { new Guid("f5edcea0-fbc4-43d4-9af8-30a2a44197f4"), new Guid("f3b7ee80-0c64-4e01-a409-ef6a88cc9cfb"), 1, "367340501-2", 9m, 2001, "Steve Jobs: The Lost Interview", 2 },
                    { new Guid("f635cac4-cd24-4d95-aa7a-efcc01c7835f"), new Guid("2952c40c-a21f-464b-9cc2-94e1d06ab28c"), 1, "867850297-5", 28m, 1986, "Voyage to Cythera (Taxidi sta Kythira)", 4 },
                    { new Guid("f66d0c5b-c33c-48ea-a45d-79a913cf3326"), new Guid("44fca0fd-a199-40dd-91a0-c93ff17297cf"), 1, "197146841-X", 63m, 2002, "Ladrones", 7 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Condition", "ISBN", "Price", "PublicationYear", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("f673a647-5bdc-4082-a3aa-5c1e951f21cd"), new Guid("093dfc93-5266-4d68-bf48-163fde59163b"), 0, "179970716-4", 19m, 2004, "Joe Strummer: The Future Is Unwritten", 5 },
                    { new Guid("f6efb1e6-5bbe-4121-b87f-3035409c81a9"), new Guid("7d025fa4-0ce3-4792-bf95-d6362c98db02"), 0, "837997841-2", 63m, 2002, "Agony (a.k.a. Rasputin) (Agoniya)", 7 },
                    { new Guid("f70cab60-576f-4305-9c1c-8da67818d1a2"), new Guid("7380d008-4710-45ee-aff4-9b69627d8fa0"), 1, "984088184-1", 36m, 2009, "Satin Rouge", 9 },
                    { new Guid("f7160a9b-5624-4982-8acf-eb11819baac8"), new Guid("5aef495f-a566-46f1-aae2-66d7c497630e"), 0, "610697703-8", 23m, 1988, "Harvest (Stadt Land Fluss)", 0 },
                    { new Guid("f775803f-193c-48cf-8ab5-742e5227d047"), new Guid("95063ef9-dfb2-482c-8b95-2d990034e231"), 0, "159344724-8", 46m, 1993, "Love and Lemons (Små citroner gula)", 0 },
                    { new Guid("f78f91b2-f352-438f-b6c1-1e7ee869cf7c"), new Guid("c70ba4b6-6477-4542-a5e1-eacf1a011afd"), 1, "428881454-5", 95m, 2002, "Foo Fighters: Back and Forth", 5 },
                    { new Guid("f7ae4d98-be0e-4b0e-81e0-4df87469d252"), new Guid("53d20252-1c2e-4146-ba5c-f5f192bd3bfd"), 1, "436325379-7", 44m, 2002, "Down to Earth", 0 },
                    { new Guid("f7cf360e-b861-4d86-882d-f98b4629e547"), new Guid("67cd07fc-a2c7-4630-9512-fd8a0a807b14"), 1, "660298487-X", 1m, 1996, "Frequencies", 6 },
                    { new Guid("f7edccba-e6f1-4eed-b05f-3af5814db3d2"), new Guid("8744a906-2952-4236-b56d-f60d81c02330"), 1, "411188857-7", 15m, 2005, "Madigan", 3 },
                    { new Guid("f7eefbcc-91dd-4b6f-875c-208ec0c415e3"), new Guid("6b751a89-1e62-43ca-b754-2a4123355c9f"), 1, "216588655-4", 64m, 1999, "Panic in Year Zero!", 11 },
                    { new Guid("f894a279-23d5-4756-89dd-2b5853ff3771"), new Guid("c95a5b6e-2c40-41a5-b044-0351e979eb24"), 0, "013537816-8", 73m, 1996, "Man of Iron (Czlowiek z Zelaza)", 3 },
                    { new Guid("f89cf8ce-380c-4ce2-8684-04107f073f16"), new Guid("3c9796ad-61d6-4007-a9bc-f3216873d9fc"), 0, "269033278-7", 76m, 1996, "Beaver. The", 1 },
                    { new Guid("f8b2e169-b0b8-4a27-9e9b-3b97d14959f2"), new Guid("476fe0f7-149c-4156-b46d-519d01fa7bb1"), 1, "991600271-1", 85m, 2005, "Blood Wedding (Bodas de sangre)", 2 },
                    { new Guid("f8b4b1a7-0a91-4a0a-ae3a-6ba0bde9e1dc"), new Guid("689130df-80ce-4f32-b945-4e0ce3ed0c02"), 1, "592357556-6", 12m, 2009, "Owl and the Pussycat. The", 7 },
                    { new Guid("f9021ec2-3b15-4717-96ac-7703d97406fd"), new Guid("4a89df1e-4263-4bd3-b3f5-ec47d399ef7f"), 1, "238232225-X", 5m, 2004, "Fugitive Kind. The", 7 },
                    { new Guid("f94e7367-cb99-4d31-ac60-8a8e7242f2db"), new Guid("8b7497a2-eced-4fa7-a661-90d5dd230d44"), 1, "513627880-3", 98m, 1996, "Good Morning. Miss Dove", 9 },
                    { new Guid("f96d4c9c-f31a-48ad-8dfa-5c358793dcfa"), new Guid("4a11fb02-8185-4c0e-bce0-bf56db2436ec"), 0, "542275393-3", 9m, 2010, "Overlord", 12 },
                    { new Guid("f97529c3-9645-4491-896f-6d3c941b4b6b"), new Guid("213aa447-ee90-4a85-80b8-355431d61d95"), 1, "867584547-2", 87m, 2011, "Wallace & Gromit: The Best of Aardman Animation", 2 },
                    { new Guid("fa7b4cee-d870-4270-a586-ea11681e8131"), new Guid("e940cd56-6009-4fff-a9fa-2aa0c1d1df4d"), 1, "387309925-X", 39m, 2008, "Best Laid Plans", 3 },
                    { new Guid("fb4cc097-3621-4f92-b3ad-aaa9e2840375"), new Guid("a4262159-a8c9-4350-8f70-4a09698a6a0d"), 0, "450348073-1", 100m, 1979, "X-Men: The Last Stand", 8 },
                    { new Guid("fb4ede79-2f27-423e-bb52-e5123e69f758"), new Guid("1d7920d7-15ce-4044-8504-1751bfbe535b"), 0, "720187729-1", 100m, 2004, "Turning. The", 2 },
                    { new Guid("fb8df363-8020-4128-ac9b-a261777609c1"), new Guid("a1ceb583-6417-4664-aac4-193be893832b"), 1, "685137749-7", 11m, 2010, "Extraordinary Measures", 12 },
                    { new Guid("fbb10980-c5a8-4545-b696-fe88d09fda70"), new Guid("991fc667-d805-4de6-9cb3-3081766f90ac"), 0, "255542988-3", 21m, 2000, "Blondes at Work", 5 },
                    { new Guid("fbc3bd8b-5c0e-440b-834d-093bd0fe9c9c"), new Guid("433e73be-034b-4d0a-9c6e-ca790e39da25"), 0, "516676087-5", 60m, 1990, "We're Back! A Dinosaur's Story", 12 },
                    { new Guid("fbcd3516-17eb-4a38-98be-3e8e2b4781dc"), new Guid("0ecb8f16-d362-47aa-bd8f-aba5cb67891e"), 1, "367691946-7", 40m, 2005, "Morvern Callar", 11 },
                    { new Guid("fc16b634-9618-48d6-ab9a-712146509524"), new Guid("69a396b6-43f2-416e-a00e-b3adfea00c88"), 0, "432300829-5", 88m, 2005, "D.C.H. (Dil Chahta Hai)", 8 },
                    { new Guid("fc5ea883-7b4e-4436-a39c-369a40c86d4a"), new Guid("58d8058e-ba3b-43b6-ad64-efceeff7caf5"), 1, "914001928-4", 100m, 2006, "Dirty Filthy Love", 7 },
                    { new Guid("fcf80f08-cc0a-4b83-a3ba-edf9eeb035d5"), new Guid("4c538209-246d-4705-ae9e-415a4779fdec"), 0, "459737542-2", 74m, 1985, "Vendetta", 0 },
                    { new Guid("fd0f695b-ab2a-4650-8078-9bd33bded3d1"), new Guid("6250a70d-db50-4fe2-9eb0-9220dc1a68ac"), 1, "951014455-X", 68m, 2011, "Red Beard (Akahige)", 11 },
                    { new Guid("fe1472cb-9ab9-40d9-9b97-54151aa04c04"), new Guid("5de4c448-dc13-496c-8858-8031eb4c71de"), 1, "944499803-7", 67m, 1985, "Reindeerspotting - Pako joulumaasta", 14 },
                    { new Guid("fe36fa9f-3922-4d3a-ab65-b02c97b1bf48"), new Guid("83aa75c9-fafe-43e2-adf7-5e0acb1977e7"), 1, "823910319-7", 35m, 1996, "Aziz Ansari: Live at Madison Square Garden", 10 },
                    { new Guid("fecc6a98-73e9-4fa5-866a-5198ba8c21da"), new Guid("5f60403f-58da-4f23-9b17-66a4f26aff24"), 0, "982528339-4", 34m, 2012, "Last Exorcism Part II. The", 3 },
                    { new Guid("fef091c3-2840-47b8-adf4-842df645a514"), new Guid("6c0a9641-7993-45c5-a852-d3268ac224f2"), 1, "628543995-8", 95m, 2000, "Tuvalu", 6 },
                    { new Guid("ff2dfc22-b260-4a07-b367-c66ef56bf427"), new Guid("3220ed37-c604-47ae-a724-fd7b68bd6e83"), 1, "325730765-9", 96m, 2011, "Death Rides a Horse (Da uomo a uomo)", 8 },
                    { new Guid("ff9b117c-5336-4844-9db7-9588678240bd"), new Guid("746ae46b-0158-4ccb-ae3a-4e5a0f76a1c4"), 1, "556973032-X", 82m, 2000, "Nazi Officer's Wife. The", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("00816f3c-710f-4fce-8b8b-694aa62bf2c0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("04b7cc90-df69-4d6d-afe1-7e164354ddbc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("05b3f385-b1fc-43ce-bd6d-a26e54b8c9fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("05d0f14e-1751-4aba-8edb-191c74e42643"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("05d49ba6-ec42-4d3c-b113-dbb22bc64d74"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("06f039be-bfad-4af7-8f6a-586cefe656cc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0714e1e9-744c-4789-8f3b-c2e82f2370d4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("075bf738-c0bc-489e-8645-bdb671aab4f5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("089a6b64-5114-4c56-902e-fe2fbd8df7ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("08fc654a-4ce7-43ea-bed1-17e42473c8b0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09fb7285-88de-43b4-8581-ddf8c748ab4b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a3e68b8-cf73-4ccb-bf6c-ad3c6423163f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0b7d3b5a-89dc-4204-8bc7-5e0c36fa5cd1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0c6cc63a-5f5a-4ca5-a554-1efa8ee2b26f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0caf8876-db7b-46a8-92d6-051d3eea8492"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0d58b3e0-a68f-4f3b-b29e-772ec822bc5c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0d59cbda-6661-4c32-ad19-91e1fe7a71d4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0d7ae1b5-0102-4baf-8737-986b483b50e7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0dac362a-1165-4e88-9be0-e55bdb044a6a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0e55e315-750c-4df9-a03e-d1e073851bb0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0eaf9d32-8a14-4fe6-976d-fb9038f41908"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0f4c7d67-67dd-454e-a5db-9c1130586739"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("12a0e90d-070c-497a-a73f-2e9d898f5208"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("12d34635-3f95-4e86-9234-3a40e388cc0a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("12fd54e3-89da-45e6-bf8c-327e1b0a67c5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("134b63da-10c7-47e2-bffc-d9e99a4024fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("13bdcc94-9328-45bc-b159-2961df06d42a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("14df66ca-3089-4fbd-8eeb-896a46ff93b8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1514bec2-cfcb-4d94-be36-672110cc179e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1515ffc8-490c-4321-a8d3-db551e56e3d7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("152a58d8-76ac-43d1-9fcc-ad5a524c8ce2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("15de9758-2ea5-4d54-8fa0-4c12dbad4f1c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("162cf5c3-1c9a-431c-b077-9b33c9b224ec"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("16a44947-d397-431f-8435-e515f5820b02"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("17720fce-3f27-4378-b9ee-6894e41e52ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("17c501fe-3fbe-4b4b-b9ea-b7d854aaa76b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("18213b33-c03e-4116-963d-0eef7df6eb1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("183d095f-9bea-4436-a306-81d396201c95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1baac1e0-8286-4bcc-9052-f00e443893af"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1ccffb1f-9a1c-4638-87c5-5c2c550de5e8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1d3986e7-7cf7-4ba5-aa56-0c54870bc6c3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1d8155f9-dcd6-4fd0-97b1-969ad9798e77"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1e335e2a-e61b-40e1-82bf-09ba0aa86177"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1e3a8a89-44b4-4d29-890c-e23c910e6685"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1e7e5813-9339-4efd-b20a-11f9b29156f6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f86b4a1-d352-489d-825a-37236dcbed23"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20206b09-011c-4284-bb73-c69919062c7a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("21968877-5f38-4f92-b81d-5cb9a7a9ab0f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("228ae30e-cfed-4656-afd7-8dfe93e0ae84"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("235398bd-d54e-4f55-b134-3f2b2b5efaba"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("23a5465f-f6dc-4d8c-a9cd-b93146938735"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("23bccf95-eecf-467e-b675-1b6a3e9d1b79"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("247a16b3-599b-43f3-949c-f1b87758891c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24add69c-3868-4d74-9824-66a915cd9044"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24bfb9c5-10cd-494a-9749-4f4fa3b42baa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("25505d2f-a02a-48ab-a65f-22976eeb59f2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2640240e-6ecc-435f-b3a4-b18cd07e35e6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("26b4373c-35d5-4274-b8f5-590785de3a88"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("274308b0-313a-4a35-96e2-9b64a633f169"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("28d902f4-3165-458a-9f9c-3293035f1381"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("29844e4c-916d-4b4f-a837-a12d8ef9ba3b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("29d8ddaa-49cc-44aa-bf86-c9d8d6118375"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2a7a38f8-86ed-4624-9ef6-cbd38b764b54"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2badfc36-6962-4324-ba12-be4bbc4117a4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2c6ecb2e-93ac-4488-a27f-94e1e3c102b6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2cc1f126-5932-4d44-afd3-72f90be1be82"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2ce550aa-3863-40af-bccf-d04b52b65334"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2ec7f4df-06b1-4018-8435-d6c4cbb8b29f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("305e2668-f54d-4e67-b930-2164c75eb94a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("30813594-a5fb-4ba2-8148-90387fa5c107"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("31733822-f95a-4803-8b75-472e7ba84b7a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3290f419-20f9-4364-aaff-2279b09abe4d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("330c2709-1b56-457f-bd1e-1c5bb27cda53"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("35fc9aec-1fc0-4244-85e8-cca3e336a731"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("36145858-c78b-4ad6-a4bd-5a798e488495"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3644c802-73b7-4f56-8412-1baf23ca1244"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("370d0b40-5b28-48de-b0b6-e24fd817d873"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("374715bf-08ee-4a85-ad2b-3fb4da8d99bf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("37473f61-a6c9-4c13-84e6-05645f6554a9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("379ee703-1eab-44d6-891a-45e9d3fc2217"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("385601f4-44e9-48b5-87fa-58391eedfdaa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("387b13a1-f1f2-4684-9b2c-64c45234258a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("38c88310-d2d4-4503-965c-e679f83b87cc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("39fdd714-0017-43e9-9610-4d750008a7fa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3a9d347a-b343-4b5d-a379-66546b1d7b69"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3c7e8b86-0230-4938-8f76-67c099167185"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3d4edeb6-3baf-447e-bae8-d8ee8655b1bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3d6a3581-5b67-44da-a0db-effa4d1bd91b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3d78729b-0a4f-4e86-a707-15d5be2e328e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3e361ce1-6757-4b44-844a-4d4da9b40abe"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3f97f8fc-0010-4b5b-92f7-e8b37a295be0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40c60bfa-4f66-40fb-b6cd-01dc4ed76aa6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4196a6be-f3b9-4bb5-a7f6-8c97cd627cf3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("41e33482-b76d-45b7-a5fb-8b1e9e891895"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("423541fd-c7ae-4a69-95a8-b2e79e738b66"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("42fc2e5a-e070-48cf-b745-9a24952184cb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("43ff06a8-3279-409a-a9b4-2ac91b1fa6b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("44276ff4-d34d-4aaf-82c3-97e66c20e6ec"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("457fd473-fb7b-4c01-acbf-664cd679f4a8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("481e43ff-7810-4116-bc5f-9b268f2b76c7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("482f6dd8-d1d5-445d-8212-4aa87065958d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("49f0344a-8b7f-4753-a7b4-7e7c66adfe94"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ae04aad-e4d4-4ca9-9e4d-4be17f55f3a8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4afb4e18-de8f-44f7-bde6-422d9dacec45"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4b3fa199-ecd1-4625-8f9d-079ecd2fc0f5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ba66e69-3930-44a2-b803-cecb3cee3097"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4c0edd26-bedc-4870-b288-62221a0d5652"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ce4ce9b-9e65-4e56-94d6-958b404eaab9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4cf0792f-472e-467b-8bd0-32451ed50579"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4df3514a-e3e2-429e-9f96-4adf3b3872f7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4f9796dc-a434-418a-b96a-03b9b5af3475"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4fd2d3fc-0528-446e-afb3-ccc29bca2a35"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5057382f-432b-44db-a982-e6cb06a028d2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5254d9b7-7a75-4c43-a74c-6f8a0f450099"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("52b5af62-ca26-428e-9815-bc5800c6cbce"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("53b5046d-795f-434b-89c8-7a8c7d3087de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("541f723f-f1e7-40cd-98f4-31c16306cde0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("54648055-58e3-4fc6-85f7-717b68affa82"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("54eb640f-d92b-45de-b45b-afbe3e6d36ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("554a5b67-3cde-4096-8085-d5c87c86515e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("55b8b7d9-5078-4e2e-9a0f-bbace7d2ba4b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("55e42d75-f0bc-4547-a313-97e33359f669"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5607be63-ecb4-40f0-82ad-dcac05d2826a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5718aa57-4dca-446b-84da-827670e66495"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5954eb33-a4fc-462e-b69a-c4b35b2d23b4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("59925d21-b3e0-40a3-9c3e-47ec00ca09c8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5a3b9687-1549-4621-ad51-4636f86394fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5aaced39-ca84-49f5-9c8a-ca860048d28b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5be3f749-a4f7-41c8-b624-f8efac62bdcc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5ca106d7-50f8-47df-9a69-300ab6c1530c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5d57707b-c549-4e16-8198-210e6540eea7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5da160eb-89a8-404c-b939-ce802b541766"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5da62672-34c8-4dac-9284-39f4a3970123"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5e4fc82e-3f7d-42e2-ba87-eb965f69c078"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f2473f9-6856-49e5-acef-f4a50d346d2e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f3cf3d6-a7db-46b8-abd2-96ece5ebf854"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f913e8d-0608-4065-950d-e15db08fcdfd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5fe724a4-5c20-42b4-8b11-44f965dba446"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("607c1b35-4a88-41c8-ae7f-f044b90330da"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60c76f03-5291-4455-a0d6-f45def618472"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60e941b1-867d-4475-9821-b11f97b8481c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60fef97d-b154-4e77-8ed3-a6279306bb6d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("619f0308-56f1-4a69-8153-146abac23621"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("61b67117-c535-4c4e-8e48-05d59cb76ad7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("623cc4dc-88d3-4e98-bad1-deea8652ddda"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("62822695-503e-4e61-85ad-8e19d7bbc2d3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("646c41f6-2b19-4daa-abc9-f0c268f910ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64ee323f-e840-493b-bfaf-cdab9400466d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("65214b58-0906-4204-bdec-0d4128324bb4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6525bcaa-77c5-4154-9729-c72d64a06d71"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6619fec9-914f-40c6-8fc6-1610dc8a2564"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("661a88a2-7a90-4349-b093-dce3b409d450"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("66cb2283-2b80-45fb-9418-3867cb2af3d5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("67196654-85c4-4562-9e22-8f48353d1177"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("672b28a5-1143-41ce-a548-128fedebbe25"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("680a3b2a-4b5c-4888-a511-a2d91c501804"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("68906ff8-ef6e-4d26-8534-7601ad9b0fcd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6b7ca30b-d7af-4952-8e4e-2a9fe020eda9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6b98801c-0e77-48cb-b9c3-0a1fbf103f53"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6bf33252-eb9b-4b3a-914b-c05a1a74d4d6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6c29785f-2e10-4cff-93e5-d0b57852cf95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6cfb8b0f-4343-4357-b2e4-55d75b510f38"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6e4ba9be-2758-4b3b-857d-6bb5d3f815fa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6fcf8b1c-e7a0-496b-a86a-c8c6222a2e98"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6ff2f920-c56c-419e-bdf5-789e30e08605"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70775228-96a5-4e00-af62-c230349def0f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("71ed4c21-9db1-4a27-b2ba-abbf9baf89f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("726c8369-0e31-4509-b56f-933e165dd42c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72794b1d-5453-47ac-96e8-bb37f6e483eb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7304daf2-8df7-451e-b35d-56e6cc94d092"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7394db23-0068-4c8b-9c51-8106f9a7731a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("73aebb7c-0cd6-4af3-8fc8-51b3355c8501"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("74b56546-b19f-4d74-97cc-c73c6f7055fa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("755a51dd-260e-4cc7-88cb-0d7efd06ca45"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("76057b1c-a66f-45ab-ac1d-c4747aab6c4b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("76b85efc-72bf-4480-bef3-e80c4a3c3617"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("78d3412c-6e99-4217-805a-51c60a6e5242"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("78e11718-4856-4720-9590-c7b7d1d4b413"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7956045e-3602-448a-862c-336200d8df8e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("79fd3b14-3e12-4d26-a6d3-ef93f0aa8be0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7a0b2670-2351-46f0-9e4e-545685bdbf24"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7b304e1b-e26c-4448-a5e4-aedf31c439a9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7b930168-81b1-4535-a095-c9d7d86e53c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7cbe3881-44c6-4a91-96ab-9acafa35f716"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7cede0b5-02ca-4398-913c-54c50bbf4cfd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d0729ab-628c-437a-9b0c-d4386076caa6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d27004e-7607-4591-ad14-71f4504b044d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d3ef2f1-b0a7-492d-bd40-e5194229ce2b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d55c58f-59b0-4a25-9592-ed64c2b4e8ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d8d17aa-6d08-4a17-a703-953a180e2ccb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7e11d767-ea63-4a2e-9aea-77f04bb39b83"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7e38a4c3-5fcd-412e-ad26-2caf8d60b5cf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7e6bcbed-066d-4a21-858d-44e864ee2280"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7eb7f2e8-ad00-4e34-a20c-2ceaddaee834"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7f60ac25-699a-4e94-8529-4e4e2649e4ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7fd9d8ba-dbd0-45aa-8459-ac3e049912c3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7fed3ea5-9f37-4543-a2c1-64718dac6142"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("80b82dd4-245c-4c16-afb1-df3b54d52d3d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("816e54ab-c013-4211-82dd-4c7cf3c5f5b3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("823a039d-8fad-45c2-b7e3-51fa4bb63afa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8396720b-3f4e-412a-8b5a-1053cfa69961"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8591b231-6db6-4249-9461-4bbaf0a1aa95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("865234d8-9947-4df8-9883-6079fba39957"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("86fc3e99-46c5-4df5-90fb-651d673a831e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8707f668-e06e-4352-97a2-a573054ca001"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8788e433-0f31-4de0-a887-6e1e8e88a9ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("881b2f04-5fd0-4d33-9d04-f91f6780391b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("888f4e1a-d257-4352-b778-0844eae5bdea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("889ef92f-5075-477b-a2e9-2e844824e416"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("88e7f720-a7e7-467d-a261-9915cc1772fd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8a14e59a-fb73-45e6-8d47-682aa5f20285"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8a92accf-e38a-40fb-baa4-2287dcf88d61"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8b09f7ee-f33a-4e45-a7c7-1b50743f9ace"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8b89fda6-c83d-432e-be22-d212bd97e6de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8d6350f3-2a44-4db3-8181-8147e830fbea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8dd79e82-1d71-4b5d-bba7-7528558497ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8e327be4-3ed7-43ff-8c05-6dbaa197a0f7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8e96d060-1f56-496e-a327-467a75d663af"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8febbd9c-e667-47c8-a486-495b3f4a49f6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("90215e51-afaf-46f1-8559-0afd4052b8b7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("904e3806-0725-427b-b997-d746feebfb6a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9058208b-65e0-4908-a6b9-f5d1c5bc867c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9080b474-faaa-44ea-8c3d-66cbcc59c686"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("908f231f-dfb5-456d-847a-a2959286b9ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("90dff086-d88e-483d-bf30-8d535f84b21f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9150f2b1-ae54-42a7-b70c-c9c1bf768ba3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("92428c0e-a8be-442c-ae47-1127aaf2f5de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("927cb894-93d9-42bd-bcd7-ff508507030f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9415ada1-b693-4542-9f42-cd7ece208df1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("94ce3336-7efc-423a-8242-1ac0168b4d47"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("95432bd9-5969-437c-b45d-939e6a3114b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("95736e11-e4eb-4cdc-810b-a7aa18ff212c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("95d596b1-15d9-4ed4-975d-14c571a12a24"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("962e6ef8-9552-4e43-9a2d-7eccbeaef6d5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("96813ea2-1794-4df1-86e0-640f94734e5d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("983c17af-b529-482f-8334-38e66884d9c6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9850d853-a4ee-4886-a453-d9a1c5f59adf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9865dd11-ee6d-4395-99b7-72165467ea93"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("987950eb-5ff5-4be8-8328-495ad2cf7a68"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("99cdb186-3402-4bb5-8322-06008018c667"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9ab2d015-bca6-4ef4-9772-bd7fcb4e2c85"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9b72a576-6ff8-40e1-aeeb-6740223e9a77"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9b7ff001-51a8-4076-9c0d-66aa23171398"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9bb405db-a1e2-4a9d-be4b-d2680922068f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9d5149ef-0c19-4db1-8c79-40121d5d7e21"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9ebc83e7-1f11-4aa5-8404-ebb078632f29"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9fdac1dc-cdbe-4e69-9eff-8cf64d570eeb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a170014a-f0ea-438e-abda-dc4076c93a6a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a185dc5f-bec3-434e-8b92-44113233ff39"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a24f5065-0904-4ac8-8d98-30979ee24fd9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a255f733-b873-4c45-8d80-ee885b918755"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a2694f20-9b07-4ce2-8933-d83180ff8e2f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a3611cbc-276a-4874-b226-e3c31d91610f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a3bcc27e-daa4-45dd-bc82-5e6711d8e425"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a41acf41-2425-429a-8bc3-d47574f1dc82"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a47b7a85-b2fd-4ead-bc91-22a6c68f4363"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a576b36e-56fc-4347-8d67-2898a18a047f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a736f98a-bd72-42cb-bfc6-c9e9dd56490a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a8716f3a-676a-4e2a-a028-604b8ba2af4c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a900d174-abb0-4072-9fce-61a249bac951"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aa904e6a-473f-464e-97bd-74c58ff115c6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aad272d6-59a0-47c6-944e-58fc5dd8ba0e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ab65ff79-1d13-4682-b804-f37ffbff5317"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("abd82b74-0280-4b2d-9877-cf13fbcac533"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac8bc911-2e4b-4c26-8f73-1e3bee913b24"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("af118cbd-3803-4e0a-a6ce-62ac0e32fd34"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b04e2b34-77da-4cee-960f-af5210956e72"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b2dd0d9b-02d7-4549-96cd-c0350e9f28a5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b38cbbbe-6a26-4b6f-adde-28d0db595c87"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b38d2732-a57c-43fa-b4a2-d0d2eda608ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b39e93b0-2b2a-4aae-acf2-1dc9f5955151"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b45fe7f9-7bbe-48f2-864e-520814d0628e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b6512279-6547-4ed2-87fc-c77ab6abef87"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b692b225-621b-40b3-965a-91d9b4931ba7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b6b28f2c-b552-4d7c-9e16-39404a01f374"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b77e350a-0e9c-43cf-9cbd-b8b0d4ca029b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b7b4b1f0-135c-44c7-9eea-e7dc75c051bc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b86e04b9-9004-4bee-b812-83971e671945"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b9095f71-97c5-4d8c-8f9b-69b11d459a38"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bbfb9626-f9f1-4837-8c72-fbbd4e5d49ad"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bcf9085b-d4e1-423b-9276-d89d520aeb82"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("be11a97e-53b4-4c38-8731-1a2ea714a27f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfc6616c-448f-4347-a108-3e2bc25e3b6c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c061d7e5-4b72-41b4-8c19-8835f83a3e45"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c076d896-0ef2-4c15-9990-9617ca805457"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c08aec6f-289a-4bdc-aff2-a454cf2b0e97"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c1aa4f4b-b64d-448f-a23a-9b71528541b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c218b30b-d85b-4c81-b63e-42c0fa14107b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c4dc1d58-a9be-4a62-96c4-ac463860f179"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c555b899-cda9-4422-a2a6-2713973199bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5698bf9-f96c-4df8-aa13-3df76a2cb879"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c7a255f8-61a6-4738-bd62-225887638aa4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c81f9470-e030-4c03-9473-11f887816e16"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c82d6da0-3934-410a-ae20-cfb9dfbb0aec"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c9cc59b9-915e-4c4b-8400-d7eac6f724f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cbb1171f-85e2-439c-8518-73a89fc94ec8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cc9ec432-7cda-4aec-954a-c61e80b62f92"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cdff4303-21bf-4d90-a886-6335de74f006"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ce0335a6-7aaa-4a48-8060-030b77484b3b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ce4c8ea0-afab-453a-8211-88636888940e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d1fc24de-dca0-46dc-b6e6-f93704434293"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d202b471-780e-48f2-951d-5eff11f6c5c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d411c9c1-4b5f-47c1-b9bb-1adbfdb4966d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d44986d3-cdf8-43bb-8e86-a74826170ec5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d48b87a8-75e5-4161-8f28-5cae1dfa0c22"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d4bded3a-e447-420d-9769-0bd2a7f1f583"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d518d01c-9858-447d-858a-9d69fd9c45a4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d5c90918-40ef-414e-9aad-d424a395b95b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d62abc74-1046-407b-b009-84458788871a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d685d683-feb2-41ef-a3de-36399b342371"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d6f4586d-0a34-4775-bc5f-c5a4c5d29e9b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d7f6c836-8b85-4391-93a4-d3a9e7ac2888"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d9165e31-be69-48aa-82e5-23c8b75e6949"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d985943d-8277-460d-8c71-708f9093fb3f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("da54428c-88c4-4f90-9406-476c66a66dde"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("db1d1a4b-eb62-4326-8a80-4c89565eaa8c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dcda500f-6c1a-4a52-ab83-38a6c437f55c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("de4b219a-bdb4-4477-9deb-9586b48c1045"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("debcaea6-d40d-4fe7-9d7c-9bf0aeded429"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("df56863e-741c-4633-b28b-5b9246e1857f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dfd42b4c-7722-41b8-96f3-fece9dedf0e9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dfde4eb9-101f-4eed-a857-1ac43ff5be27"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dfefe5e8-a2e4-4e86-aead-0a32f2f118fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dff52e48-ba03-46a1-a2a4-e346fdb52b1c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e107a237-8154-4ef5-9557-843e1f486af6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e2647342-e8fd-4f39-98e6-7a01b82683e6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e32e909d-9766-4659-8656-be448c2ce8df"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e3f10016-7502-4a71-bdc0-9c22cf6a5bd8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e4b031df-f012-4bab-884f-df14decc7f16"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e50d82e5-c38c-49fe-aef4-4f54d0e75951"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e69428c6-d43f-4e1f-bb3a-b95aaa0642ea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e6f25aa2-1e44-4a96-84af-8c2840980f8b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8359f44-1a23-43a4-924a-8cf59a84a3a1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e900592c-8ffa-4c84-90b4-ae353b292558"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e9773d5e-d00e-4a3e-854c-6ced5a41ca60"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ea6064fb-bd57-435f-a88d-f9b36ecdc366"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eb024ae4-629f-4f49-a420-27c6e5c354ed"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ebaa6cfc-6263-43c8-98a3-ffde8195c21d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ebc99ac8-f30f-4b67-b09a-0a5af6bf6dc7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ec7c2556-312d-4658-ab4a-cba11638f75d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ecdd311d-8fde-46b4-82c2-3505281d8c33"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ed535116-8f89-4908-a7eb-ccd855dfa020"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ee1423ed-70c0-4621-bb0c-e01c043a7197"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ee4227c5-ee55-4a41-b8e2-f68c4ff24908"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eefaccd4-7127-4085-88bc-6a27306b7ab8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eefb6f8b-75e3-4bb3-80f2-97bfbe76c4aa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("effd3f5a-67b3-40c0-8126-bd22a3012ef4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f0598ad7-cab3-4ed1-a011-d813a8e38769"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f0c7c138-352f-4efe-953f-87acb4782acf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f16a91ae-51db-4475-910e-c03a1d35d225"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f22a03fb-97ad-45d2-9e53-a6f7da00cc13"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f395f87d-59a7-4559-b33e-ffd6db9dc3b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f4d81451-d91b-488e-b971-c7a88411d61b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f4e8c5d0-6100-4be5-9750-9f23679b9c1d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f4f7b50b-338f-4dba-9b86-69291c154f66"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f56d177d-ecbb-4c89-a471-1fe563e170ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f5e7a255-e954-42cd-a2b4-6cd8508bb20e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f6e096c7-976b-4659-8b1b-19e99fce4cea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7136f79-d7ca-4cc7-b807-06c874736a5e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7adf1dc-1cdc-4bc9-bc5e-cc5f3caaa2dc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7fffbc2-345e-4c2e-a748-ffba11a2d367"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f80135ad-8130-4f9c-b9b1-f32613c74b43"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f809364e-a8b1-4540-8b15-f870cd80026b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f8e2e376-bf17-435d-925c-69570dc1311b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f95d7010-b4a9-4323-ae24-6ae08f6c8973"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("faecf514-a004-4871-a454-2495cb150348"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fb315e98-151b-4164-9e0a-fea62de9253b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fc5d433e-16f2-49e8-96fc-46d1ebdacd59"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fcab4449-d994-4b52-b97a-d2e5ac311fc3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fcb3c996-c794-454a-9a16-4a2565f65288"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fe5b31a6-ab2d-41e0-94e8-b39659490107"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ff1a42cd-0526-42cc-9308-15f2d60709c3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ffcdf6aa-9382-4a22-a21e-3b65a984e28f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("005d39dc-c7f9-4fdd-abb9-2c6ae12874c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("005f19a3-fb37-4680-bcd5-e3dba13a9aab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("006b7334-164c-47c8-ba44-6b60ecf6192f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("008f49eb-7d4d-4d74-9250-b4290d519718"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00dd680e-95a4-4e59-bbc7-b989c0852a23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00e066b7-10e7-46e0-8539-aacdb35d412f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00e7f6bc-f8a8-4bfb-ad68-6848c87c971a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0133f5b4-af09-4af6-8fde-093335e2a027"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("01da40bc-8c4a-4036-a1af-7643f3ce3057"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("01e4aee4-6126-45a5-9135-5c3db3af386b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0229e1ed-54bc-4d08-9932-c835af5a3bb3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("022b9ae9-64c3-4b82-9ae0-6a6bb5e2cd12"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("02453b3e-1d51-4f41-b6df-7a678da90bfe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("02936ebc-4df7-4271-9478-fbbdcd537f9f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0294c444-6b39-42f4-90eb-029dbcfd45b0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("043fb5d8-b194-4c3c-ac89-0648f718cf0f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04456375-4711-41b5-96ad-f4f92b4f174e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("045956ae-06b6-4e77-9a6d-ac3ffe1caebb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04ad5574-7b1c-41c3-8b78-f3ed04f2d8a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04cb2b5d-e4d0-4c16-a943-4af86ccbee9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04ee5d9d-f5f2-4a81-99f4-692d4ff7df30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0587cabf-f146-4761-b62c-31be16b7cc3e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05a54480-ebfc-4c6f-85ba-0f3f5dd26dd8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05b77698-54d6-4eab-83b6-db58a4f810cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05bd86ce-fb08-4318-8349-c8b101f85ea8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05cd042b-5a2f-40dc-8cea-211857dd10a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06016b2f-bbdd-4629-b988-c61608b70a61"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("062a6998-b339-4e57-baa8-fb4446ab6daa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06681220-7877-4329-81ea-2c8afb24c371"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0681684c-3688-405c-9e8c-9fddd5a1e26c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0682d919-a7ab-4401-9106-ed27765e0db6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06b35d72-2fc9-4d4d-8765-03e15d8a2294"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06c196ca-4a1a-4d10-ab76-3e94433e4058"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06f0e7b9-4d0f-43c9-9bec-c88c93a77abb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("07120b63-921e-43a9-b67b-cfc45d08355b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("07197013-60ba-4006-8b72-e0cf0eb26712"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("073568ea-0832-4f95-af6f-cb6d594619b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("07bdaeec-3a2f-4ac9-a8d3-458f10a9aab8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("07d03a25-1aae-4284-a166-06d8ee6bd358"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("08199b71-e045-4e06-ac09-12568cf1c4e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("087c206f-d31c-4852-85a5-af7172b5ad3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("09176063-7f52-4ce3-945d-b5309218c95a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("091fb77a-26d8-4bdf-84e1-8f6f1a6ea162"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("093dc345-56ed-4b48-a8bb-5753cc6fdd9e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("09830c99-8900-486b-86c6-dd0153489340"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0a1fba26-7176-4593-a320-3fd48765d7f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ad77d8d-456a-49a9-8cca-2f2c5973eee0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0afd8264-82b5-4c1d-9eb1-54d7c7100329"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b534599-a0dc-4ce2-82fd-f4aac0e6cb06"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b9b70b6-4d46-4d03-a8c2-f5db494f698a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0bc7793e-c405-4309-8ea6-c986cb2c0895"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c08b845-ae0c-40cb-a83a-b90138d328eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c2471a0-5cae-4ec6-bc5d-2612fd7c7d90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c536162-10ce-48b7-9058-24dc070ead93"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c90e866-2409-488d-bfcb-33f2db891f22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c93dc7c-2424-4099-a6c8-40f4c5a70b30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c9df34f-715b-47f0-8535-f5c86ef121a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0cae6f49-1a4e-4514-aa60-246e1823e794"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0d9f08de-75ca-4432-ab73-36ba33b79f64"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e54e324-3e5f-4e6c-8c2d-ceb25bfdc6bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e894f50-a12b-43be-a230-0a1013115532"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e93e52e-f579-42d1-adfb-96d0845d9e61"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f0c9115-56fa-4f82-b69e-de6981be5a32"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1020a13d-fa06-42ce-982e-27fc506dd1b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1031440b-bff5-4185-bf35-983e948a548d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("105cbd29-0765-472f-bc6f-271be1ea8dcd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("106995ad-7d86-495f-ab3e-6af07da4bf01"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("108fd7db-cbea-49df-aebc-130469936773"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("10a1ffa3-013c-47c0-adce-1f9e938b0e30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11208c53-7849-4101-a94b-792405cff1cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("112444fa-71bc-4407-97a3-47733a8613f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11720a7b-de57-41e5-901f-5276a8c5a70a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11b3675a-3e40-4018-adbb-bfc57e229ed2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11bfc504-720b-4a7c-a07c-896dae1920fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11c66d5c-62f2-4246-9e45-8f318240f4a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("11e319fa-6b02-46aa-ad23-cd5ccad81182"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12434bdf-e163-4a51-b89e-04d57cad1a6a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1303cfd5-6e3a-44e6-85c3-0b2cb0c31790"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("136d0e24-9483-48d0-8da5-97724d25b8bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("13b3b7d0-e6a3-4270-ba14-d6031e39222d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("13e93a6e-3227-4293-9871-2b9500c1e8f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1412462a-4e7f-4169-b618-e61778eb5fac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14162e6c-344d-45bc-a962-ca3fdfa2a140"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("143da1b4-df5d-4dd5-bdb4-56ad6b382b54"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("145e12c0-50f5-4316-ad62-2d2f87a01860"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1474043e-9db2-44b6-9619-8cc51c085d62"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14e61742-e144-4882-a14f-9d3981fdce03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14eec613-9c41-49b3-a21c-b033823757f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14f0146a-92b7-4af5-9299-6cd4aa3729d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("15afe9bc-6ce6-438d-8220-e24beb3e6294"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("161c364c-7657-4b2e-b2d3-eec660cff62a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("169f311d-d121-4c10-a7d8-772a56a15927"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17361b7d-3568-475c-a4fe-7458b7f37db1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17664e36-0424-426f-a112-bbc30f3bef46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("176a9eb7-6ee3-476d-8d17-a6c1e60be467"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("176dde9f-dda4-4ab3-9227-0b229d473620"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17a33159-98e0-4605-860b-7ed98fb92054"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17a4aa20-d960-4dac-96bf-ee9181ff3553"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17abda69-46d9-4b14-b36c-93eff3a12c56"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17e8af1e-3de6-4c1a-a1d4-577d4f26f6ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18228689-1855-4423-88b3-64f937d84e1d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("182e9c64-4bfa-4342-abd5-57dbf0c3537e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("185f5b46-ced5-41db-bc9a-8a309d8ebd06"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18e6a454-ac64-49cc-b112-d052fcc373ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18e9efdc-7617-45a3-a1b8-c7c00ed40d15"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19972302-e0e7-4b29-89e9-31fce62dc164"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19b65861-3f68-4a8d-b84d-7ae46134abad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19bedad3-a2d0-4045-8b49-7a465c09d07d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b15dafd-4ce9-4797-ad48-4342f04a341e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b19a0bb-059e-43db-bb09-54280bb44be9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b20b823-4e56-4b09-b3d4-eb234b6a0120"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1ba5ce05-21c3-4046-8d28-8c550b6dec96"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1befc76d-f894-4cd6-b5fe-3b8087ee1849"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1c1f3ec8-4529-4674-a6ac-94ee9ad2534d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1c3ea19e-6120-449b-80ad-e82f7525ffda"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1c72349a-7d55-4685-bc29-331d2a248037"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d1118b8-e5fa-4e4a-a8f2-b83314947cc1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d2254de-ec2f-480a-b0eb-8fc7cedfed35"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d43040e-0f75-46b0-8da4-11e01ae72533"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d519927-92b6-4873-99d7-9e6a5fe59866"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d54df2b-1f27-4fa6-80a9-d8052d294efd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d79c44f-39c8-4365-981a-63231b42a880"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d8e043e-19a7-41f6-afe8-b26012a358dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1daa3b2c-7265-4260-84a8-0bf6947c9a42"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1db703a0-bad1-4445-bef2-9166bfd60cfd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1dd0901c-944b-4bd6-9d70-3a9792e691eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1e01563e-2de9-46e1-b191-4ae633b77a3e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1e3d1ee4-bc7d-414b-a302-33a6acb4a93b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1e7f4e35-fe42-4b78-804d-1c2b7cdfef5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1edb66e0-28aa-4bba-b27d-1a3f4a3ccbce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1efa70d1-6d11-429d-a6c5-3eaa9c8952b1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f239296-5f81-49c2-9958-ef115f6316b3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f54c8f0-c860-4673-858b-9a26c55baedc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f5b4847-d7bf-4b62-a174-7da6aa9b9880"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f6df04d-7a28-41f3-9d4b-89fb3855a5a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("202fec7e-3397-4dac-8b47-ce608e1ccfde"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("207315fa-4bb3-4e80-be0e-0a082c2a8181"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("207ac310-4367-4a21-b9c0-3417c9f8f6ee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20d900af-d9dc-4116-9fd9-424fef861b97"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20f6ffb4-a3a7-4261-b33a-6c4da477b0ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2143ab27-13a5-4ba9-9896-ffa60c5df48a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2183d4c1-a1d3-474c-bf4b-d78c9cba45d1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("220ad3d9-158d-4ec7-a815-97e90e38795d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("222c618a-7f4b-49cd-abac-7b9390c286aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22d36ecb-206d-4285-9c36-d688e8368dc9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22f17402-6252-4233-a988-a57df8b32752"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24607b23-ad1d-4512-859f-01b94ef89eed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("246f1c5a-bd96-4acf-9d60-8c05a16ab89f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24a80ff4-aa74-4489-94c2-24e2ce798510"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24b65650-6092-4c56-8a7b-b2a6362ca606"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24ca388e-e960-440a-a62b-ed9379fa9594"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24ea8d32-e255-4efd-8ebd-cc481394cf05"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24ee2c62-ebb4-40a2-ad22-3e47d42af044"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24fca9fc-1e86-44ca-9b17-925bdec6257e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("25d26546-147a-459d-9bac-00d1d1341462"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("25dc488f-1684-4d64-9c6e-6585d6ebb072"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("25ebf71d-5e67-47bc-978e-0d1e6ad2339d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2643a5a6-9148-43b2-97f7-9155d2a03123"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26663e84-2066-4695-b6a1-c23f15a63458"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26a71165-4a20-4458-80ed-26e3869f978f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26e17bda-f1c8-4774-84e9-45b120782159"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26eabab7-e668-4dd1-b02c-bedb1794f9cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("27bb507f-795f-4064-b442-3b0427b8b487"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("27d5f3fd-0c54-4fb7-a674-8affa6ebc724"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("27f9f98f-382f-439e-8fc1-a1dc72c3d6eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2857469a-4089-4a1c-bd9e-1df64ca3ff40"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2892c8fc-577c-4b87-9a5d-5219a3e47732"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2921bd32-d429-4a63-b0bf-14318adc79f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2925ca76-fbaf-4fa5-996b-66bcd015f738"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29752707-0924-4f70-8e26-ebeafee1530a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("299f0026-9201-472a-a989-e0b1e263a9fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29bfa62f-4e94-4dee-abad-eba54b2617a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29f12437-6c0e-4135-b372-3a93276817c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2a4eac2b-fd78-46f3-a77d-6df7f610063c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ab3a569-73ce-4dde-a8f5-7144132013cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ab83c8a-b7bf-49cb-8e82-254066a3e255"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ac3ed42-9895-473b-8824-b4fb8b33f071"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b1b549d-e664-49d8-bb89-c5ec024ae0b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b6c1508-d5b2-410c-955a-9e9abe4e36fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2bf27897-fe68-4ce2-a6f3-d1e33cdf6954"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2c8b370a-d198-41d7-a122-31a0ae24c34c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2cf134c3-4da4-446b-83b0-009ed7380cb8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2db7268d-56fa-48e1-8a55-cb40f706bf9b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e1016f9-a383-4245-afb0-65b3aed699a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e5d4f1d-4b7f-47af-9210-6d59e34ac3f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f197ce6-7e9d-4de5-89d5-3194516f17be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f1df018-6177-4966-aa98-b2958bbfb1d9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f3d6847-59bb-4405-8228-73c0d11a6242"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f6fe725-aee5-47e3-9bf7-5ebfd28fd72f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f8a935a-cb22-4a6d-9851-499aa9507dc2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f9b668b-b062-4924-b03b-7179666a0319"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("301a7ba0-bc40-4982-a244-159863fa9264"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3084d9c0-58a4-430e-af68-0d033352f86f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30f01729-5404-4e3e-8132-c2e9f4f3d4b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("310c635e-387e-4925-96a7-0b335234629d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("311a8813-5122-45a7-8cc7-4692baba0886"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("315046f5-a28b-454d-aeb9-15ecea0ed087"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31faaf33-5807-4131-93bf-30e80bb3055b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32418fce-08e4-4a46-9f30-1e486e4ab0f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32d0437a-e614-4ee0-bc01-eca37b625282"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32fbcad2-6bb1-4920-b5c0-88b021c9d98f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("333f945e-7a90-4267-9e26-d21b0b1541e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("33a3537a-ffbe-4c40-a8a3-d3d470e14b6c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("34d12da4-20d6-40a5-bd08-44d072908ff9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("34f49e44-6d21-45db-bd7c-ff9b68c3a3dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3568a9df-39aa-4866-b3c1-a73c226a8145"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("35a02266-aa92-480c-b243-c03c47b1d8e4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("35e7a699-0076-49e2-8016-da5e03617d68"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("364c6561-4d1c-4bd4-8414-2c65d9ec48d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("378ba433-f4fa-4fe5-9a62-dfba69dddbad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("37bab301-4998-4246-b55e-5b2d30f45a39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("37f26fa6-f191-45a4-9d63-900d40e0c6ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("383f5d39-764c-45c2-ba00-49d5ffbad806"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("384d64cd-5de9-4878-8bcc-90b073d2c9da"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38a5c2e2-996b-4f4d-8581-f6e2628d1a55"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38f41f36-f40f-4b40-a37a-806da1970f30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("39160324-b2f0-426e-85d9-1a00cb351e82"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("39248f1f-8e96-4fe2-88e6-4fb16fd33816"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("392b713b-ee2b-4cfd-bae8-7bfd35a9ae8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("392dbc42-e48c-4a88-82af-9e3ee2f77cf0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("395d5551-a7ac-43fb-aeb7-f3a97fd34c90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("39c51439-955b-44a8-b600-c17f081d4bc8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("39e398d8-b806-445b-960d-ce63bae89272"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("39fa0bf8-6089-429b-a78d-eee52fcb97df"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3b3fc461-81a9-4404-bcac-60fffae1307b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3bb9bcb1-963c-452c-b3e2-e61a6f7f7161"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3bd0ce31-c21d-4ea8-90d1-af3df110e997"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c06f6d1-95f7-4326-9253-94beb2f3d77b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c458054-014c-46bf-a9c1-53d782541482"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c903dd3-b61c-4bbb-8f67-4f2c24ccfbe5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3cab1023-c76a-45da-82b9-3655337be594"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3cdff34e-b4e2-47bd-90c2-84dea6589cbe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d0f0b84-4b3a-4487-b863-1d6ff0abd9a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d170328-240b-4fd3-aac6-fdfa05facfcc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d1ad74a-25a4-4c60-9d9d-20d29b988731"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3db98a3d-252a-4ef6-9e50-36998751c878"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3df3c7ca-6127-45a2-a872-e4b2b09eecbc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e0665a4-e3e3-4176-b1cc-de4bbb0ae2e1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e0f684a-86ad-4533-bd8d-deacaa61a34f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e590d94-e108-4bcf-a9fc-a039ea68dfef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e71601a-23c8-4ce8-8eb5-bdf6a1bbdf5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3ed87488-7c93-4dbe-8933-3d39d18a91dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3edf0e07-19e9-4882-891e-63fae5681223"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3f8912dc-3e77-4992-998f-fa2433076f13"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3f9b8ec0-3d8f-4bb0-9575-36ce1f619f23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40dde6af-3ee2-4cec-9515-ed928d58c346"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4114cb3f-9976-4145-936c-609799cd86c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("411c4012-db10-4e9f-a39a-271854414dac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4139362b-2a06-4fcc-852f-26262b124efb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41a8a6b8-1d08-4880-b369-7598513af6fb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41bed6c4-460c-46a1-8a6a-e7aeb9cef997"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41ffd07b-6343-4f6a-be29-046816c55502"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("421f87f2-cea9-41b8-9399-ac826109680c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("427d730d-d8e5-4642-ac7d-eda1e4d414b0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42b319b1-438d-4f28-948f-f571741cdb0d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42e29a18-054c-4316-b064-2ae977b19293"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42f96912-c0f5-4cde-9ca6-45c40598765d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4343f8aa-5577-4208-b1d7-413eb427ba13"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("438c9d57-3f8d-4096-8bdc-8e84c8b37436"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("443f3988-221a-44bf-b4eb-9de47f7698ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4454462a-5c3f-4e3e-bf43-ece12d4ecb2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("449c7b23-0424-4b72-a992-4a6e3ca5adff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("45124dbc-ad26-4bc3-b1ad-38454f5a9aac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("451bf1ce-63ea-4505-8366-07184f460587"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("456336d0-63c3-4e3c-823d-6c33914aeb94"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("456e067c-a86f-441a-9fd0-aa67fa9b173f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("45a06d80-95fd-400c-82cf-ec9b5c3e540b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46131be1-1a44-40bb-be9f-7f616cafc56c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46488edb-4270-44fb-a96d-69af98154f45"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("465f8a89-1608-47cf-b3d0-e53d1b699e8a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46d2c65c-024a-475f-a2ff-4eaf605fd7c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46ff4722-d04f-4e7e-83ad-02728aa447ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4774c59c-0a09-4786-bdd7-fdd60513e405"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("477cd959-aff1-472d-bcb4-d4a32d8c1595"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47bfec53-66af-4f1f-8c5d-f4a6f5376e3c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47c4d01e-5761-4290-8e9c-64700833fdab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48232cfc-f0be-43af-b824-e45e47ed03fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("484fdd37-1ca8-47cb-ac74-26c2924c94b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4850bdc5-5068-4dbd-a459-3f0edfdc07b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("485441f0-3194-4e91-8cae-1c03d9af4938"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("486275f3-bb34-44ec-a5a5-4bd27ccf35f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4870fca7-cbeb-47f4-9e67-5e1d53761528"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48961460-fc9c-4b99-9386-b027dcb6a915"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48dda679-6677-48db-9e3c-02e13433d712"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48edb058-89b1-43ec-b212-6f1764fcb3e4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49128022-7cf7-4456-a2c4-65fe5e251e82"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("492dcfac-808b-488c-8505-419e666343fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4941ffee-a2b8-483e-bfc4-f2a4aceabeb0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49e4bb29-9404-4e1b-ae2c-16e7ed24d2e2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4a400bfa-5726-40e8-8134-481671866aed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4ac4764b-970c-4c0b-90f1-6943ed465f5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4af726e2-3aeb-4091-95e2-bf6355b9494e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4af949eb-8e80-4abc-93ba-67a21f83170c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b56cd0e-b0bb-413e-a8c0-a67c6cf7ef1f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b606c8f-d43f-4e9b-ab75-72db5e87be7e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b99a13e-1a5b-40ac-a1ff-05ff2fac8ab6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4babd9c3-9b43-457a-8560-43bea89c8340"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4bd5bb58-d4a2-45b8-af1b-29e63260d6e9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4bdb67dc-6ead-4a9a-b9fe-103d60608363"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4bdbf7dc-6ead-4a9a-b9fe-103d60608363"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c0cea4d-6191-4d31-a6d3-b854e60049a1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c2fdd0f-ef3b-4d75-96e6-8f207675467a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c3cd722-9a3f-4388-b94e-94a7d5bd0247"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d06fa3d-c810-478d-a735-45404f3a2260"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d44e30d-4a8a-421c-b36f-5030697911d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d7b481b-3434-4032-9bee-32f79e7271c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d917442-592a-44ea-850f-c8446288d46c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d98db88-3d56-44c4-a291-7df408dad12e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4db6432f-3b0d-4275-aff8-61a32b295555"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4dfae581-798c-486e-ab4c-8b18993cbb8f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e1dbde0-4171-4816-b06c-e2233f320542"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e903f16-6d10-4807-8c9d-e1c90bfee622"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f2b8235-5cf5-45e2-94d4-ddec7ec87d9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f3294cf-87a6-462a-bf45-f3c40d7addcc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f4bf2b3-65c3-4667-a3a0-9f15d58fafa6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f6549d2-e36a-49c4-9a21-a62951d84445"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f6c6fa3-0786-4775-8fa1-ad0de40e0c37"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f7a946b-c00a-48c7-acff-4084c66d8fad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4fafea22-c24f-464a-8e2b-41c4902c3d51"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4fb63107-da06-4d10-8655-d4099925de90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4fdf4a7e-7148-4159-8e44-4e20bd4fcddb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5090a7f6-c9cf-4d07-9934-5efad19f1e31"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("50f29f43-2adc-41c4-9cf5-535af58885fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("50fa4e5f-46cd-4b2d-a4ac-c757744dc864"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("512358ae-066d-483c-8c87-a58e4d183235"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51320f1c-3655-4c8f-9480-347856ffb7c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("515bcf9e-e3c2-4765-9cb1-0ea58a8a0144"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5165b1c9-760d-451a-b42f-07a75661a974"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51793b75-3146-4df4-b321-95a7f6f64d5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51a1c15d-36b9-457e-a8e7-f3d0804c8960"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51dd8846-2756-43f2-8d28-44f738547d26"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51ee8c5b-a632-45bf-b605-c44dd621b644"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("527721c2-ba14-4207-86f5-11636321b19c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("528dab3d-4ed8-4e9f-ae3e-e93d0574d651"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52f1df7e-563d-4312-9267-e037193a1e38"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52fc1caa-f04f-4db1-a606-3b62250ab881"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("538ac8b8-f963-495c-a483-6b3a3614f9e9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53d13f75-c13c-468a-a2aa-548d4d2ae118"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("54941d72-f630-4cd3-8760-030dcae23c04"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("54df09ee-6211-4f70-94ad-6c9ee6ea6fdf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5570ae79-78b8-48a1-a6cb-de4a780759a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5593e612-166c-44aa-ba3c-557ec841989b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55fa89c9-50d9-42a9-8318-6f7279daf533"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("560f1e56-cda6-4d73-95db-7d5af66976ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5654f406-2574-47a2-b47a-dac9aac50605"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("56a7e870-fc42-49e7-9760-42d2df4c4cf7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5751bfd3-b4cc-4bbb-b314-0608cb6fad96"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("581d41a6-206a-4dec-a3b3-952b724bdbd0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5863dae2-faf1-46d9-815c-ddcaba31dd07"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58a0b26d-8971-4cf1-be7b-be6af73f2754"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58b00bbb-6d5f-44fe-aba3-c62d04a1d852"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58f51cc0-9faf-46ae-877d-377d1083aa83"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5910990c-cc94-47d6-9e92-69425f79a758"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("592d60aa-83bd-4f3f-b3e9-2179a8bb2e95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5959294e-2f19-428d-ac6e-729cfa193c0f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5960a483-796c-451e-8a53-578db919de59"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("598ba175-3519-4a8d-9c94-5847ec6ae035"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("59cceef6-aa68-4a4c-bd7c-20dadc880bd1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("59d9b05a-782b-4e94-a3ff-1bb6af4f0c71"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5a40d06a-cace-4856-ab1a-e54b139da056"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5a4d6c91-fe89-4511-a4b7-ab297b4c4cce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5acc936e-c69a-4497-b3b6-62a4a5b1020f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1b0057-62f1-461f-8246-308542f216cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b3c1a51-ece4-4f33-ba6e-a5b256352f20"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b61847f-c0d4-4399-90ec-cdb634153871"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b766194-a24b-4595-b561-c23a8fc7508d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5be3abf4-9b49-4b42-a330-8c0711002062"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5c05a93b-21ca-41d8-a09f-8a193d1bf810"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5c881db1-20bb-4982-a7ea-dc8516920906"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5cd58666-f6f4-48f3-94a9-dfe1afbb8b71"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d06b9f3-01f7-4915-9743-1163ba561841"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d14896e-0e97-42df-91e1-feb6934061c3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d6c6d94-9342-4ec9-bcf1-c3a142d94c85"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d773525-966f-4a06-b079-f4ad420db2c5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5dcd0c3e-673c-4098-adc1-42f593f88670"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5dd6c92a-ee5b-47af-a4cc-cebda1d7991c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5ea72f70-5b37-44ff-a674-d55b5ab5a0fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f1b78a9-9dc6-4acb-bdad-f8dc8ba0e9d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f3f4d2f-d815-435f-8dc0-7a210d578c24"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5faf2d4f-3e98-4179-b42e-86da43cbb765"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("601d3ce3-12f5-4126-bc92-a3f945d8b9fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60345d14-8b0f-494a-af25-383c435bbb3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60464fdc-4068-4d68-aa0c-538d6ff20e7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60a2e930-3177-4b83-a555-0017d38cd4cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60c2a218-6ef6-4202-ab80-8dc0a2a79b62"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60e4f31d-a470-49b1-9fb8-390b09fe11db"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("61381bd2-0529-436e-811a-69117c49207a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("621eedb1-81f7-4d75-9fa5-076e0bd65ff7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("62865b32-e602-46e9-a321-54f2d0305ff4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("62aad794-e24b-40eb-9d9c-839d8874f3d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("62b8fc79-f3fe-4819-9a2f-5c62c2fef890"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("630e1aa0-c75d-47a7-b142-fcf8064f68b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6365c638-9d71-498f-84ed-4ffaf2849d72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("63828545-4fda-43cf-b8e6-e3d23fdf996a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("639ec70f-4921-42d9-b6f4-e23d0b39cb7e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("64149ac4-c502-4691-90e2-0e8de7243be2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("64440358-7a00-43ba-ab12-53a44afd5310"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6533e402-a0c2-42a1-bd74-584a1e40545e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("653cb903-8660-4d12-975c-13be75365f37"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("659a8c58-d0f6-4c6f-ab40-33cd812dff61"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65fff86a-6553-4288-a16b-8d3e391b9a1e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6620c129-4582-490f-87a2-363b1ee9a91b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6631ea21-596f-4703-8e52-c7f32f0ca8bb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6655a747-8ecd-4913-a4e8-410edd5a973e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("669de602-f2ef-4580-a25a-f474dbb795d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("66dae181-9af9-4b98-a1e1-9813cece0383"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("670fbbe6-e15c-4715-8843-d255e0ff5426"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6719d3c9-11ee-4614-bb21-d39c3967a0d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("676f9ec7-20ff-4287-8346-66b21c761c01"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67713314-29c0-4dc9-a6a7-f10411e760b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67922591-9945-4430-927d-8ec34d843fee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67a2f68a-db23-4735-9244-2a65347c9f4d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67bb0953-a4de-411f-ae18-4176fd5256a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67dfddce-5305-48a2-a7cb-1b93b92ae7d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("682a86aa-ee66-4d2c-925f-c1decae0ba79"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6881d1a7-6b46-4da1-9ed7-56cddaaf467a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("69161cc7-32b0-4bce-906c-bd291f5f2c0a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("691d48eb-02e8-4c15-8a3a-2cc5d2de402b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("69897ffe-5f86-4773-8d3a-3493eeee0335"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6a003b36-04e6-4db6-8f5a-0b00d56db593"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6a30ca29-2332-40a8-bb8f-9e314eac39b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6ad44d24-d752-429d-b192-cf855433fb04"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6b118e92-79f4-47d5-8ece-1f9d4317efbb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6b1e3512-c053-4ee0-a80f-02514e3129e3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6b663829-eb85-414d-bf01-cc442f445264"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6bdfc3dc-505e-4bfb-9a11-d8245f919d41"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c044bb9-8569-476e-925a-d164f7006267"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6cf18df6-5540-44db-9cbd-bb0f22a826ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d01bae0-dbda-4a26-8779-bef25f3aead0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d0801e8-1d1a-404d-b5eb-e5a17f1972b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d5b0dc2-0a00-4035-923c-e5bae2b13873"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6dd4611b-235e-43c8-828d-2f1963f9382b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6ddfba3a-f6aa-4eaa-9344-b638dacc92f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6de27734-e6aa-4bc1-83da-9c0629dd5294"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e284c94-a48c-469a-bd6a-d0e6f558e86b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e3c5a3c-bd76-47df-a1bb-57b7027c91a3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6ee0ecca-399f-489c-ab83-423334e4d03c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6eec0b9c-cd39-49fd-9396-2ea76c1a25e3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6effca11-84a2-43f6-9186-0c09c9444b6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f3cc12d-2e2a-4e6c-a317-874ea27dd7cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6ff211ca-7f36-4517-acc1-92879bbf18e9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("704a0b58-e420-4772-af3c-2ea64f3cd00d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7076840a-23e3-437a-9425-3bafc5877f3c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("709d7ea6-1d8d-48e8-97de-3e456b0c251a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("70ef3a77-1fc0-45a9-a007-94084f2403c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("716dcea8-cf5b-4636-ac4d-ba90cf66520c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7181c7b7-cf97-409f-ac68-4cca531aeaa2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("72103dd6-a36e-46bb-8122-9ef0057cd52f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("72e8fe9e-49ca-4676-95a6-e934a91cac29"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("72ff7892-4770-43a0-ae83-06bcb94eecda"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("730462d1-cfb2-468d-a008-a057dd1188aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("730b67e5-6fc9-42be-8783-c251d45a3259"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7378cf72-3ff1-4f27-a590-c93c4309cc57"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7378f0d2-4a5c-45d8-9d2c-8410ee3aa205"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("737dac8e-0ac6-4feb-aea5-51af75f7b2fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7384251d-dd11-4be8-9fd2-b9efb0704b28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("73b4e285-5b12-49e6-acdc-0554bc85d93a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("73c8b75c-779a-4c71-a2e2-c97dc8a2c33e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74855039-e23c-42e5-8ef1-aabab72b55aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74a6c4ae-7b44-4d9b-a17d-e12c58e6bcd8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74b5a96d-f775-45ed-9f41-1a71d4326e9f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74b5dfef-b9d5-425d-bf9c-b10862ddb4ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74d0fa83-be01-4760-88de-5b558b0b53d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74f29667-5299-4c81-aa97-cb3bb7fe8139"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("754e8621-aec4-44d8-a3c8-21c7da313cd3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7584c97b-d702-4db1-ae1c-b15d14a5e7d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("75d79c16-d8de-4843-923f-2d63cc745566"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7638c5e5-c1c4-426c-9e17-0d3610194624"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76730646-59af-4926-b475-532023f8bd46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76a4f827-7687-4ff0-aee9-12508bb1c36b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77615d5d-ae66-46aa-8ea9-01e329d258fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77b1e2a5-35ca-4dc2-92dc-2f690ddbf82c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77b6a896-a5e5-47bf-b9ac-434850afd3a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77cb14fc-16fe-42a7-b941-09c808c483af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77e077e1-4909-4237-94a6-ec0ccebf89c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77f4554f-8d13-4c7f-a897-1e799407204e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77fbb415-c2d7-4b4f-8b5c-e68ae67a5ccb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("781ca1ad-1444-4b14-ba6e-9595d7c60d85"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7826f16c-0d0b-4f6d-9831-92376c039438"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("787bfda6-d9b4-4f89-9db2-454a212d1355"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78dafc67-1665-4abd-bcc9-769f56b968af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78e64e8c-fdea-448a-ac64-3dde32317134"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("792213ff-99b1-4519-93ef-0416a417f981"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79486d75-f890-40b2-98bb-f6b5c0b8b59d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79638971-a257-467b-8159-ed74828a2b8a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79bed9a6-4d82-4146-90e7-e46dcf0ec243"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79c2b8ba-3d9f-4cef-973f-fddea7cbcd43"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7a0b748a-8669-4239-98f0-f5cbfae46035"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7a1cdaca-7828-45b7-9674-8c51675302a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7a768c47-f63c-429c-818a-08697dd41fc0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b1a8f0e-f0cf-4956-b5d0-255d24071e47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7bb900ef-b2f3-4d78-86ca-d3b35a07dbf5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7bc6e961-c011-4b61-baac-98cdbf37cf73"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c1c697e-a543-4e69-9c89-bb678334120c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c23702e-dec7-45a6-9d0d-2a395cb04378"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c2517da-c26c-4a26-a07d-d0e844e90251"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7ca49834-d4cc-4cfb-ac9a-179668aceb0f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7cb417fa-5338-4446-9e72-54fb33b6b642"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d0ace3b-9685-4654-87fa-d6c6883368a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d1e01e4-0e3b-45a7-b60d-b55244070521"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d3fdf61-8091-41e2-9ead-eb6a61c7cc98"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d4eede7-6c8d-4696-972b-2314cd2fb272"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d50adc3-22f7-4bb2-96e9-81bbcd84fd83"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d8d1481-70ce-4301-8156-1285a0c7a203"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d8f4819-6b7d-4671-ac89-b780f591b1f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e22d526-9d25-4aaa-967c-814a0f9959d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e4bbd3c-9831-4a4e-8c00-6ba1a090dcf6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e669fc2-35b1-46bc-ade7-202ac5e8fdd9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e77ee23-7cca-41d6-9a6d-cd0bea4f6eb5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7f70a7ca-666e-4a81-bd84-c0a17bb4d4a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80114622-715c-404c-ba66-49114a77fe97"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80652c6d-7d7f-4ca8-92ef-cf25e09a07b1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80756613-b5b3-4151-b69f-c4d33e152404"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8110132d-eee2-4516-a52b-b4c92c27b656"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8229afa3-7eea-4dbe-99ca-4cc0472a63e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("825177e4-7865-47b4-bebd-434b0dad971c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8251898a-e74b-478c-b635-bd6cebcb320c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("82665894-2072-47e0-a67e-178f99b3dab9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("82678d2f-9fe6-413d-8869-b6d7920705c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("82aaff03-4fd7-4edc-8782-123ce2e0c46f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("83179c48-b056-419a-97db-734c33eafa90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("838f2277-0f56-481a-b6a8-34d5e64ccef8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("841e4c5e-11fc-4ac1-85eb-bfbb4833785c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("843edd4e-1d1d-40a3-b948-46892715d182"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84508837-4b5d-4f71-ab40-b2d605095d39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("846e7dea-1aae-49e7-b04c-33842ec0f4f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84754c79-61d4-42e9-bfdc-d4eb0094e80a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84ff9062-60ed-4712-9e81-7f39d0d90914"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("860cce53-4c00-459b-b33a-a6ec9abda00c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("862f68c8-732e-4d3f-9699-f8850686d205"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("865a8627-8057-4b76-a17e-59c4d28ab4a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87150a28-be3a-4517-adb3-e1d511b0be53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("873e2828-3036-4770-9681-300ba7af91fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87878b25-ac0a-48b2-bcbc-e82d716ca8a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87a7e4e8-0f0c-447c-8c94-c873b5ada7a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87d74207-3d61-47dd-926d-7c1e9fa7e2e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87f5bcc8-31f6-41c7-9105-fd100ca778cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("880a3cb8-d016-4f24-80dd-ac45bcf87ab5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("88880a82-9141-4a7a-9c06-feaecb5e7477"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("88f7d7bf-ba00-4baa-8073-128d990d73ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("897939c5-203e-4e6b-9dd5-8b9602208afe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("898cd88b-3d38-407b-ba03-7e5a3ab1eb7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("89b3f845-0292-4791-831b-f623177dfb03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("89d59a29-3672-44be-be68-6af170edadf1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a2b34a3-b079-4fdd-9e43-fec6785c2439"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a936d09-aafc-4e55-8ea1-0d27713defd8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8aaf373c-e8a6-4c87-9bc3-d5224177eec1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8b1e9bb5-4d92-4132-89d7-0068c2733d46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8b5c9c34-8968-4707-ae52-fa0799aedad6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8bac8134-0f58-4542-80ba-2feef215dc8a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8be29514-0452-4aee-a4da-e74de178a1ee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8c3ac1a1-a8f8-4f6e-83ed-b6d01dba3015"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8cf18dc2-cb1d-4e47-9bb3-f06b7ad9c289"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d2ab99a-7db7-43a4-8a39-a0f2199540b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d4493af-305c-4bdf-a707-570d7f7c88c5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d62f72f-996d-4808-a39c-e7f9a23dd07e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d6abc9c-0342-47e7-b54d-2919659f9186"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8db2bc36-92b7-4c5f-892b-d6f458c8b0ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e054fea-f065-4928-9c35-20e8cfea50ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e4a1999-8e14-41a2-a016-bbb863033cbd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e6659dd-d91f-4904-957c-518b8ad8f8c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e81a04a-40a3-426f-969a-e35f81737653"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e94bc5f-5738-4a80-a2f3-0bc8774a5f8e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e9c5981-121b-4ca7-a3e9-17d68bb6d880"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8edd81df-422d-419c-b6fb-c660e9d2ab65"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8eed7e0d-b0b1-4cbd-8e6d-54300fe153c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8ef689ad-a478-4f89-9297-60794c1dfde7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f1e407b-7078-4e7f-803e-c7536dbcec7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8fe438ad-209b-406f-be46-52a49a32ff0e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8ff86aaf-18b9-44c7-a2e5-6f1846876e48"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90065e5d-8308-40b0-941c-7e08aa5d317d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90375566-3dea-4747-8588-78b56f8424cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90744394-fe99-4ec7-af77-6104ca40639e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90e716fe-513a-41b6-a0ee-51f00a2dfba5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9111a475-dfd3-4631-8254-7962ac722d8b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("913315cd-90db-4fb9-8e65-3551133da5b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91715ac5-685b-460a-82b5-a8d2e625e56f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91cb8f69-ae71-42b7-bd46-8e43124ac681"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91df0a8b-8544-407b-a509-5f2e92bb89e3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9256f68f-061a-43cc-85de-d97080c8983f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("92b90fe5-ebd7-4bc1-92c1-f8b76b6dc981"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("92f20245-03d1-44d8-ab59-1179384fdb7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("93005f7b-6f51-4da4-a60a-cfd1d16d0f21"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94506ed9-6e90-491b-94e3-891c6e0965c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94678d52-bfe0-45ec-8f72-89412dc21994"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("947f80ae-b3e1-4a54-ad9d-11eb1caff1ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94a28cd2-59b7-454b-a3e9-421ca59691c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("958b699c-09cf-45a5-b3b7-2ce072ba5aed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("95a35e3a-2397-4b77-8319-b64bb990413d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("962e2c12-0f46-4c80-922c-486adc14ebfd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9633ae65-5aac-4b83-9b57-944ba139cca4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("96bfacf7-a807-4ee5-b7c0-a7927c62b47a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("971dfac2-becd-478e-8981-16446d79152d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97fb818b-6c89-4856-8500-f2beef6b0de1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("981f86bd-c775-49fc-958d-fd0d910c02fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98bf76fc-bf82-4a29-8f96-782eacc84ff1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98c82cc2-2a45-48fd-bdcc-1d93cd3330a3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98d33a25-ca52-4217-a315-0ea64c0109fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98e65290-049d-4297-8568-584f08fde5d0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9952e9de-aa77-462e-8e4d-f86107dbbb3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a49ee63-e497-4e21-9918-5014d5ab30ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9aa0aa1d-b61e-4253-ae58-2b077aaebe64"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b56a153-e00e-448d-9a7f-26a13042a1b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9bc6b56e-255d-487c-a68e-f5ac8692dc15"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9bf3ef2e-d02e-4aef-bf93-77ef47df8236"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c03e4cb-ac95-4701-9b80-58a6ae1fe407"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c380fed-8b16-4cb7-803b-57372612f3b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c65bfe7-c253-4616-a16e-296f4cd8c911"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c6ccecc-0ce1-445f-8eb0-e5a645e9787a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9cb5ccdc-607d-49ed-af81-af5f5c4f3fdc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9cff2c6d-2529-4040-b511-2f49256b43e5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d5edbf0-e09a-4d1a-a466-2af553ae48c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d6c69b4-506c-4f93-b8c2-07fee26db97a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9dc2d075-451b-4233-96ec-35ebe05081ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9dd416e8-715e-4603-bba7-2a67166f53eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e0b9083-adfd-461e-9dfa-0b8414257b84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e117f59-6ec6-4f4e-9a23-827a6c297cfd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e35879f-5999-4d75-9803-e91ee039e745"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e35f857-a3e2-41c2-86d6-e5743a6fc661"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e890873-3eff-4443-b5d8-e63355b6b065"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e9eca05-45bc-42bc-865d-e1c67ee79978"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9eac727f-c64a-4f98-a106-320956af3c47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f2bcb24-0e94-43b7-8d72-e740e965c4ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f469277-b4e7-4d5b-94bb-d63c632995fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f7a2342-fa0b-417d-ad6c-54e47aae0d19"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f949e0a-6f61-44e6-aa5e-306c8dd98c38"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f9f9710-c90b-4001-9a7d-aee3c7dc39c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9fc00830-d4c0-497e-b33c-086679fc6d1e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9fff131e-f77b-4944-b60b-db060dbe2b1f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a062f27c-f03f-4051-bae5-77dfbace52b1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a08c59fb-d67d-4672-9578-5b4f59fb72b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a0b7a8f6-61a8-4683-b248-7eb9eb44e01f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1104236-4c74-4d91-8efd-4a247126e512"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a141a76b-5d9f-4561-9916-22da6f212899"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a15f156e-ecbc-4a35-a4c8-8ccf029af21c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1c9bb20-6e99-4ad9-b522-44bd89d052ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1dbcfbd-7148-4395-b18f-758605200780"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a20d42ba-ad39-4403-8ef3-75103e491d10"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a22fd2c0-cfb3-44a5-b786-668f04da0479"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a2c877c1-4a92-4e4d-a050-c7090c5a6fd5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a300a551-a55d-45fa-8d97-fd1cbed11f58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a3336ea1-22cc-483b-8e84-8167f57611be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a36a7aed-4097-46bd-8011-2c8933922946"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a380c54a-c9b3-494e-a508-bc242376835a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a3e49668-bfeb-4551-9470-bbcabcb7d449"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a3fab001-180b-4a42-913b-6086d83da06b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a40de08a-4d03-4846-9371-0bce38c1fe3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4136089-8fff-4ffb-81dc-10084675a8cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a42d1fe2-f8b3-46b7-b442-bafed1fbe407"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a53a9a8f-e0b1-49cb-a167-2763359b4cbd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5c516bc-b0ac-4ac7-bad1-e77897ea659a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5f3998b-a3be-410d-99f5-ca94b052b41a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a63c1f24-cfb7-4adb-9142-b149a1dd622f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6bf4221-4938-4ba2-b0a6-2fc697a8a69e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7016eb6-90c1-4de9-984e-c4f322558901"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a734b0dc-cacf-44c5-b492-132bcc6ad0ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7450032-98fe-4aab-b913-eceb59338128"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7da7909-21a6-479c-9661-2768fd75f0de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8325bd3-a66f-4083-bfd0-defd2067f005"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a850003c-27c8-47c2-8896-1035b4432b0d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a92d1718-8d89-44ca-b4a0-225b40155cca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9644120-1921-48ef-95f3-6390f7bcc910"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9984c8b-0e13-4047-b726-0b0bd0e782b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9c3014e-5f5b-4bde-acc5-eaa017a1a896"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa062d1b-21f6-4643-b94e-e6a7ab3a74e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa316613-bf2f-4976-9b60-bfa15400c93b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa44ce8b-4e6e-4c23-a5c1-1471661e1370"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa5b9346-a38f-4e4b-9471-3e05b1134d11"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa62e995-b10b-4789-b621-703baf59232e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa9396a5-e762-46a5-9132-c1f51fc7ea45"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aaa2de82-07d2-4255-baa0-29532bc41e70"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aab3f658-45ee-418a-90a0-ce24c3ec34b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aabc0790-f0e6-4c86-8177-57ee2eb08e6e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aac06671-241a-40c4-869f-5d635598670f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab02a4e8-e8a7-42e0-83d5-15abe67aa2e5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab3d9671-6483-4d0b-abdf-0f3b1d499a2e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab8e5876-cf82-495c-ac8d-92ec9a0fcb53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("abe19194-247d-47c3-b048-f6e703291b7e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ac2529a6-6abd-4352-b7a3-a193cdf4e8fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ac5f2f6b-8af1-47aa-ad3d-3cf4b2ae1445"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ac796ebe-8bb2-40ca-9188-48b32ec71b8f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ac941fdb-6c3e-48d1-9c4d-bf9823d82240"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ad4c0dec-a87d-4cc5-8f56-57885a4258b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("adbe3021-d5e4-46ea-bd1e-590eeaf18927"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("add7b318-8dcb-437d-9ed9-dcc031d3541a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("adf66c06-0f74-447f-84d2-107f7fa07a42"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ae5aa398-e9d2-43c1-9974-7aa2daeb8063"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aea8f583-7ff9-4a17-9824-5f67fb5e4605"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aeac8e4a-8870-4744-bb9a-0cbd95bdeea2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("af00565d-d57c-48ea-b12d-1c81e96396b0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("af28cbb8-5505-4549-8097-91e1058decd9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("af7ff106-15ed-46cc-8416-a6b2bcd27ebb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("afccb9b4-7202-49da-98e7-245f1c627d95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("afcd9d27-bbf8-43d2-8e89-2e90bcdd09e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("affefeb6-8c8e-46b7-bb62-fb2769138773"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b005778e-a4be-48bc-a4d3-ae9410243a4c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b07a8f41-0bbe-43d0-8ff5-5dca27b10a90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b07d4e0e-c8bf-4f44-ba29-7fbf3bb8feee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1903fc1-9756-4c9f-913b-62168d97dc29"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1954b5e-de4e-4156-8a3b-c666d74e91ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1f6893d-c913-4494-b370-dd0e179fe70c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2652783-41c9-4ea9-924d-a8a7ee56de2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b27f1cd6-ca45-432d-976c-ba8fcc630bfc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b29cef2c-c377-4194-89d3-9b26d09e6418"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2a65f66-c53f-47b6-bd92-eb69ff2a040e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2f18523-9f70-4a5d-b17f-b60fdd540419"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b36c0cb0-60d0-46a7-86da-7e3160202519"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b37a9147-0062-476e-a8fb-7379f5b57872"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b38e13c0-eaa8-4525-ba35-63428a114c28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b39081ca-114f-43ce-97ca-d7c450345aee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3f5d98d-1654-4960-9cdb-6e677744942b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4118a44-b066-405d-ae54-71d8870ca929"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b428f340-b404-4cb3-b33a-20001ab01527"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4480e15-a7c1-41d0-889a-cb860966bbdc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b461bbf4-40fa-4a06-8304-c24c5a4b764b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b46e778a-371c-4e8a-9001-d749e62bf036"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b49d14cc-b3cb-4691-9d74-771431a14e26"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4a6460e-5383-44f8-8b58-3c6acc6e02ae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4b46739-c1f7-405b-b4ec-536053c4d3dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4eb6451-03e2-4785-92db-f8b53f61b043"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b55345ef-40e0-4348-af91-5acba89a23f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b579b84f-7294-4419-b60f-d14d7c137fce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b58d62d7-6bad-4366-b6b9-f1c479241aa9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b58fb25f-820a-48d9-bf7c-025d7c6ddfe1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b70bdebf-1b41-4b3e-b14d-d4f536a6bacc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b788a2bc-0446-4052-9465-709debc57c84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b7ed9f10-13b8-480b-9618-f79a569536ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b80f460d-af38-4956-8f45-481a9c2cbeec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b84e1bcb-fffb-4e59-9cc0-e98b93188eed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b86467d6-9530-4c62-90de-46248b214c8b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b86ec31d-33d6-482c-9b0c-795bcede8456"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b8968f08-ed0c-42b6-8cd5-ab09e4e56d85"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b91e46f9-74b4-45cf-8d45-53fda87678f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b923b053-9f21-4746-811e-4097e86ecce3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9591666-73e4-4c1b-9ff3-be790bf12830"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b95cca0b-bec9-495f-995f-622228b1b9d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9b263a3-8c2d-4338-8d2c-25f865d2dd28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9bda8fe-33c0-48ac-ad61-32c4ad2b7d4b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9e451a4-5a25-4b76-9817-401d87b6358f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba05f39f-21e1-4d37-b09b-7150aa1e24e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba44dc0d-d9f6-47a9-8dec-bdfa3ba2abc8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb884438-3581-4ba0-b901-51b47a7a3684"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bbd40ec4-cf65-4cf0-90bc-d47d3b11c5c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bcbeb8e9-a0d4-4db0-883e-3f9d5e6f4d07"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bd539d32-3b86-405e-8f94-5eb641ce909b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bda75216-e77c-467c-9d0e-3531feec5039"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bdb8399d-3d13-4001-b218-591034cd7912"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be163664-4597-43f3-bd34-5f775ac56c18"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be188499-1f23-488b-9f2b-e5dae30f05d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be4392c5-9523-4712-a7d0-b8ea82bbea05"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be5428ee-f550-41f2-a5aa-8ee33b24f5fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be72b837-8835-4434-9859-1f0495bb4f5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bf2d09ee-ea9c-4e25-a5ed-784067cab09e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bfb1f4ee-d7ef-42ae-9134-04d67ff39e8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bfdebe84-ce4d-4f9d-943a-0bbb23e6868b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c03200d6-9feb-44b5-afb0-6434c68a34ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c0441877-99fc-42b4-bc8b-f3e748e38409"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c05701dc-ab9b-4337-a4f8-501eeac7bec1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1102edf-c8d6-447b-9982-0a321f882ce8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1e5b4eb-697f-4fc3-9231-68e235b7f15a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1f7d063-3681-45af-b07e-f4ebf076e550"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1fc769d-f904-49f6-9510-3bee328f5288"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c1ff46ac-6008-48ce-b17f-f7e86bdacde2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c2259d67-5927-4e3e-98ae-79e09ab45772"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c3171133-154b-4eb8-9869-b4468259c9b4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c38cf1ba-3c11-4d3e-a42c-fb44449b7475"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c3fd924d-6327-4ace-b4e7-01b6ad6bc56c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5337733-8130-44f7-a27a-63fd4f345a49"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5d0398c-ebea-4940-9a60-2aa7c09f23dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c5d89533-b702-4420-8c4b-55916b70e27e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c6281de4-4897-4084-82e4-686bf1dfffe2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c677b561-9c6d-41df-81d4-03ccfb521a1f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c6a33391-8f3f-46bc-9918-089f43110c7d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c6ddd7bd-e5e7-438a-bfea-ad8ee2fed1bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c720b839-86a1-42b2-9414-ea221c50fd96"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c7234cb7-5116-4a78-9da3-b5277e428545"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c7ae13f7-f556-4a15-bf58-1fa541f6a41f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c7c300df-73db-44fa-b5c1-42f497568fd4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c7c9fe9d-2818-4293-870b-7dc16186a46b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c7ff61c2-de02-4627-981b-90142b5ac173"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8013d86-9baf-4edf-9f93-bb93dd8a5c47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8551696-ca2e-4254-ad19-6afd3688c667"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8c23d9a-44b1-4605-ba7d-1898365d3e1a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8d5576a-8e88-444a-9e8c-a93a9505e45b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c95b49f2-ac24-4196-94b6-9f18a9e2d436"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c9c4df72-4dcf-48db-98cf-1c7ab5bc9a2e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c9cc5f4e-0571-4864-b9de-ea3a9e7ea13b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ca01c616-6afe-4c32-9da9-644ccef2bcb6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("caa9c159-3a24-4419-a6dc-d41f8db2325d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("caf5f1d3-ef25-4757-ba97-585e92d0c26e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cb0ba315-eace-472e-a0f5-af04095eef89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbb29bcf-7ab8-430a-a415-c02e038ea8a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbfd4d4e-bc49-4116-8a03-c6c86ae6eacf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc03d442-3185-4107-a388-ec989cd2e38f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc3c0270-639a-4b7f-81cf-61ec246fb5c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc8db674-7b5a-40d1-8200-b81dbb07e57a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccba83db-1cf5-4ff1-8919-3d4c06576040"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccbf04f3-9a8f-4f31-8842-09930e65a1f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccc53188-406d-450a-99d3-2248f661adb4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccd60f7d-6bd8-472c-a657-a7a543cda0a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccfab881-6d99-43ea-a529-4e3cf180ff4e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ccfb2633-d1bd-44ba-9704-427b5ea6ed31"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd20dccf-ccb1-486b-a3c7-a97deb4171a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd82fbd0-17a6-47dd-95d7-f9534ae135af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd9442c4-3e42-4995-b08e-f817c9cda0df"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cda1cc3d-ff8d-4e20-96a6-aac26cdafe43"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cdb655df-a528-4170-9d8b-1a78afa5e573"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cdc8822a-e6e9-458b-9b57-1a76dd408b83"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce123961-4f75-4213-a4a8-86cc537317da"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce1ae567-7101-4d67-bb34-c18ca5437e7b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce32a641-7f87-418b-b74f-b2a396b5ac55"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce4c7a28-f541-4a6d-8553-2a793b263a67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce9c9b81-2b02-4f11-be70-e08ed04afbcf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cea93247-0ebb-40c0-bcc5-0a551588c952"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cec363b8-5bd7-4d13-81a6-fd681de79107"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cef461c0-de70-494f-ad12-69b0a4302c1e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cf26891a-8415-4555-a563-5ab5ddc2e2ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cf84b90e-bb2f-4bef-a38e-ae93489b9787"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cff33d88-fcc3-4978-8b20-dcd99cc1b1c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d002219a-aab9-457d-841d-f0ebe0f2bf08"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d02f0a8b-b309-44bc-b42b-bb8b3a3ca9bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d03dd4f7-7b18-49ec-95be-611c59b75eaa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d094e32b-7219-412b-965a-597ce4c87485"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d0baf860-e31a-40bf-b566-0cf6a2a2c93e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d0d1ead0-cc71-4045-852c-3f5ffcc27b74"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1a082f7-3abf-4d22-8849-ee57b7dcab39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1ba7da7-0299-4b0a-83d1-2aa87d501e1f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d0f1a6-ca02-4921-ae47-ddbe40416647"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1e5474d-3ee4-4f00-9f61-1e735c788ee4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2864754-1341-4495-83c1-d934e678c582"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d297b5fb-f053-4543-8c16-9d42d8f5f9b3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2be970e-c38e-4665-bf3a-f1bd2faf22ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2ce471a-d64c-4fe9-9ef3-c9f6d0488f16"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2dbd92d-0d13-4738-b76c-23f8d53626fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3124e22-717c-4b39-b8b9-04d385081204"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3370780-ee8d-4740-8c4b-1736dbfc2e1e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3cbb0a2-91c1-4dc1-b244-3fecddfae382"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3cd69ca-d42d-4b77-9d30-68d17a8be611"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d433eb44-114a-4daa-82f1-b940c8121d4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d43e6548-a6b2-4454-a70e-89a116296417"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d4593fd1-7d68-404b-82e8-c7f7f8189717"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d496c5ee-0415-4d11-9163-5362da48a78c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d4a25134-ff1a-4c0f-b00a-c5e26fdd527f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d50a62c3-611f-4caf-a566-9f7d1330da7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d53ff9cb-ef3b-423f-b0dd-48e4f0a6fdf7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d543985c-192d-48c0-a473-c44bb10def6d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d587480d-d368-4671-a0eb-a7e13f8aaddd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d65d27a1-220f-4a7e-99e7-8d86298f63d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d67532d9-e190-40d9-9467-48347492d3e1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6cfa3f6-8061-4828-a787-8c157fad5c11"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d711ecc5-f307-4636-9192-fc7e7f85e7e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d72a41c0-bc18-4bd6-8042-65f15959bf22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d7c281d4-0f2e-432a-ace3-c8273ea34aba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d7c5792c-063a-4ea3-bc1b-1a0c2ba066f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d7dcf94b-3e7f-485b-baf9-ad31c9e82193"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d80ad946-d1a9-4ab3-a8cb-fb12fc714e78"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d831c1ce-4eaa-4ef9-8df7-bbf37b8c0466"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d846c10e-1d12-44f8-a9a5-82ee9b932e34"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d862b4c9-5c07-40d0-8038-a8b68b8d533a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d86cc588-9a26-4197-9e83-c9b1e3c53929"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8b25f0d-e17f-4a23-a31f-df2001d77b28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d95c1c89-ec25-4844-b6be-d4bd4fa270b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d9fcad8f-90e4-4330-970a-b7dac30e920b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("da56d9b0-8026-412e-9321-337c7c74f16c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dab6d798-769b-4d23-8a22-ef25cbeda1e5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db4ccf50-e33d-406e-bc40-308f237e5811"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db5de08e-2190-4779-8607-22f9a5d828fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db6a42d4-8361-4fd8-82e3-ccf769d9632c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dbea7539-07eb-45ed-8ac8-855c49ed35f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dbeb763d-a3f4-43ce-b7ca-187f3d31ae9a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc019e37-a099-4959-a95d-bcd3d9cbeb36"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dc370814-a550-416f-b44c-d5c2cfeae529"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dd839038-2a2a-4a8b-9601-9162ec5e2299"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ddc92b4f-b392-41f2-a530-b061e713eafc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dde927af-5ef2-4e8b-8c15-b42c4db6d086"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("de6d607c-2851-45a1-9f3e-ad49f867023f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("de830292-bc87-4beb-9f60-34b4b6c52b39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dec97035-c62d-4be6-80b8-a9d815b35899"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df0b97fb-2129-4347-8e5b-aaa39bfea324"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df0ea970-7759-4277-83b8-ede5ae1d19ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df26b26b-6fa0-4cc3-aec4-141726f120a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df2c78c7-856c-4df9-bad0-2cad48926562"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df81cfdf-0eb5-46cb-918f-51843568a5f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dfb85d5f-7acf-4252-8108-9873eea8406b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dfecae39-fd44-4057-80cb-6a528ebe6a1b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e03bc2cf-6b43-4fff-b5a0-af912b6c2db3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e03ea270-36f6-4590-a1f7-417b306f307e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e07c67e2-7c42-42bc-ac82-cb3d6d7eb105"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0c3a90f-a6fd-476a-aa27-84ab785eaa17"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e105bf9f-352c-4117-bb5c-439b4c419e03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e1b2a8d0-38eb-43e2-a5a8-e00ab7c98e89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2367659-8f27-476c-8ae6-4ba3acd75ad4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e23b0061-8492-4d42-8233-cc6414fbc2c3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e25c9eb4-5cd6-4e6f-9b76-11e160f95c9d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2a2e5fb-785f-42ee-acc9-d2a43e512e5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2d969e9-25d2-4d44-844a-46e13e25eb92"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2e81502-9a18-4b85-af0e-4f229313a782"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3011400-8e92-4177-8108-31e33166d5d1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e316fc38-72e8-4764-96b6-fbfec7e893d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3273abc-e169-4857-97f3-ea510f7c02cc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e32ed32d-4bfb-4bad-ab44-5181fbe081e9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e34f0a64-697c-4e48-9693-01bae181fa98"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3753375-2b84-46f9-a7ee-c6bde4b289fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3e54b58-765a-4328-b9fe-7453f40bde4a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e40467c0-d718-4127-bdee-e9e0daea01d9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4149b95-0378-485d-8fc4-f66d8188178a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e443b3a0-8590-46fb-a355-c1404e6e2530"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e454781c-f7a6-4a37-90cd-4070369f3d46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e47b8f48-6e58-4ab2-a1a2-15a4232ba13b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e495cd30-50ec-4379-afd8-11dd34d30745"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4d89323-ce60-4445-94e4-4b91abf38f7b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4fcb02c-8bdf-4b5a-8a3b-ae147bb3310f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5ec7d00-3c78-48ba-b862-6e4f72ee80d1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e61dfbf2-648d-44c1-99db-18c507cafc44"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e62da17d-1520-4fae-8903-a919c9303953"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e657819c-78c1-49f9-b705-f038711f4cc5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e71ad76f-ce89-4937-a0c2-1ec3055b3786"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e77de915-a3a4-4be6-aaaa-ba178319d51c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e79466c8-31bc-41d5-a37e-25b5b421abbd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e83d28a4-4228-4750-903f-975c6df29935"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8761e11-33c2-41e8-9217-929451996ab7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e96060f7-8673-415e-9c5e-c0ce6d20d281"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e979719d-143e-4d34-b6a8-39289fecff45"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e9b82c06-6484-43e3-81f0-824d7c0ecd86"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea213838-3f39-4661-bb61-c2a3ad7d6f0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea9a90e9-03bc-4815-9e92-1079a93f1746"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ebe37393-ee97-4f08-936a-c1216717735f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ebfc1e4c-f4f9-464c-affa-1a27f5ec901e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec553e43-855b-4bab-928e-99b099eda37f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec808924-7747-4d33-9712-2019136e22eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed3ec982-a171-47fd-b51a-baf3cd74a69b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed4c1f34-c2cb-4819-a86c-a148e9091ef1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed62fd24-eb63-4b51-bed6-d54c58d37602"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("edbaf184-fd09-457b-874d-40f4b90b3301"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("edd81c9f-a17a-4304-8e59-587f57da3f3b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ee220529-b02c-4f38-84a1-a5dd3fe1ef66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eefd25d4-1308-4542-a19c-eec71c618cb0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("efc7a569-7219-435d-b385-dc22537c8979"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("efd12544-51ea-45e6-a214-bc999caeef24"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f0985f73-82bd-4e3b-89ae-94591e306a17"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f0c94851-8e4c-4c35-9360-a5d513a5c2bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f0edc3c3-1916-4dff-8b30-6ad977ca6c5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f15eba83-1b2e-4e03-940b-192331b7830a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f17763ad-9dfb-4436-90b9-db2273f16e96"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f177c48f-bf3e-4ef4-af79-97c3544ff967"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f2508e98-dd3c-474f-98bf-17fa9744ec5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f2e733de-a39c-4815-a8bd-b391877aed4e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f33e9a05-c164-4fd1-ac4f-c6225c9c2ac2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f3cf83af-afc4-4d6e-bf5d-c3a46f159ac9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f475ca8c-34f7-461c-b272-3e56b0bcc931"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4788c50-c1a5-4d1e-9770-e0c94764e5b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4833dae-74bb-4d59-b344-a0c8e6039670"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4bb710e-6ab4-42a5-99b0-fd2b97fe1900"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4d4e147-3f70-4591-8271-d44aae8700d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4f86abf-78e2-4499-987c-1c8d43fd0ed7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4fafe2b-f558-4b52-818d-591ff0f5c26a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f510e4ae-26c5-4a3c-a460-323b86e9172f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f52678d5-3a99-4c91-af4f-4c67f2f8d7c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f528ad0f-de2a-45ba-82db-dbb463a21ecf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f532db27-28fc-4ffe-b820-47ddddf2b325"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f583b94d-4ccb-44f0-b683-c5439af1b70d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5dc651e-1fe8-42d7-aa95-ca1b1bb409c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5ec98c7-999c-40eb-9de4-25065cf7a31e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5edcea0-fbc4-43d4-9af8-30a2a44197f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f635cac4-cd24-4d95-aa7a-efcc01c7835f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f66d0c5b-c33c-48ea-a45d-79a913cf3326"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f673a647-5bdc-4082-a3aa-5c1e951f21cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6efb1e6-5bbe-4121-b87f-3035409c81a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f70cab60-576f-4305-9c1c-8da67818d1a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7160a9b-5624-4982-8acf-eb11819baac8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f775803f-193c-48cf-8ab5-742e5227d047"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f78f91b2-f352-438f-b6c1-1e7ee869cf7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7ae4d98-be0e-4b0e-81e0-4df87469d252"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7cf360e-b861-4d86-882d-f98b4629e547"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7edccba-e6f1-4eed-b05f-3af5814db3d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7eefbcc-91dd-4b6f-875c-208ec0c415e3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f894a279-23d5-4756-89dd-2b5853ff3771"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f89cf8ce-380c-4ce2-8684-04107f073f16"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f8b2e169-b0b8-4a27-9e9b-3b97d14959f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f8b4b1a7-0a91-4a0a-ae3a-6ba0bde9e1dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f9021ec2-3b15-4717-96ac-7703d97406fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f94e7367-cb99-4d31-ac60-8a8e7242f2db"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f96d4c9c-f31a-48ad-8dfa-5c358793dcfa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f97529c3-9645-4491-896f-6d3c941b4b6b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa7b4cee-d870-4270-a586-ea11681e8131"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb4cc097-3621-4f92-b3ad-aaa9e2840375"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb4ede79-2f27-423e-bb52-e5123e69f758"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb8df363-8020-4128-ac9b-a261777609c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fbb10980-c5a8-4545-b696-fe88d09fda70"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fbc3bd8b-5c0e-440b-834d-093bd0fe9c9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fbcd3516-17eb-4a38-98be-3e8e2b4781dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fc16b634-9618-48d6-ab9a-712146509524"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fc5ea883-7b4e-4436-a39c-369a40c86d4a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fcf80f08-cc0a-4b83-a3ba-edf9eeb035d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fd0f695b-ab2a-4650-8078-9bd33bded3d1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fe1472cb-9ab9-40d9-9b97-54151aa04c04"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fe36fa9f-3922-4d3a-ab65-b02c97b1bf48"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fecc6a98-73e9-4fa5-866a-5198ba8c21da"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fef091c3-2840-47b8-adf4-842df645a514"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff2dfc22-b260-4a07-b367-c66ef56bf427"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff9b117c-5336-4844-9db7-9588678240bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0085af40-772e-43d4-a744-781e8ac7ade1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("00d9a9b2-5d08-4bd3-b854-28228db24210"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("013a3381-b4bc-43ab-9298-bbb8baa91078"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0177be2d-065e-4507-874c-82ce6135f402"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("01c064e1-88aa-48c6-be0e-b12ea47cab70"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("02089dca-80a6-4eeb-8f9f-e6b392f76f9d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("020c5e81-7f10-431e-9c35-a9529f348081"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("025dc1c9-55c4-48ef-b265-7ac3a06628eb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("031938d9-385e-4e78-bddc-ee7720f60ec2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("03a5bd12-ef92-4d66-91bb-9da8d3666f82"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("045ec6f1-6dc5-487b-94b4-359a852b3f00"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("04a51c1b-ad90-4882-9acd-377c0ed077c6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("04bac9d9-63bd-45c5-8499-dbf7fa5e0f31"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("05365b7d-37f5-4893-bac9-536e00a91350"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("053e626e-3b2e-44b7-8740-d69df744a58d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("056cf996-5b34-438f-a9d9-e6d8d32bc285"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("05a64888-2a8f-43e6-8920-3b4591773c9d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("069bf751-30ca-4d11-b39d-6c60d55ee78d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("06c39c93-720b-45fb-9f20-cde1c13a709a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("06c4b13d-acd4-48a5-b197-f6ec2ddaad03"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0713193a-10bb-4d6d-99f5-81e8261f06f3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("079aafe1-97db-4416-8a2d-7e598149b737"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("08932960-8d61-42f1-952f-3ce019f67547"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09399070-fd8f-4a0e-9d27-261fe7b3a288"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("093dfc93-5266-4d68-bf48-163fde59163b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("099b4dc2-bb45-4315-97dc-cf885108c8a0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09c7e67f-0a4d-49ae-9267-ec26fe174214"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09d8248f-b84f-4482-81ec-38e4bdde66a0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("09e76b31-202b-49d4-b117-e28c6e21a6db"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a3f38b0-6c38-4a4c-b93f-92e97944e3b6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0ae2a8e7-e3d7-40d2-b5de-f8827665d132"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0b1719df-a53d-4a59-960e-2b319cb4da9f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0b511322-90cd-4686-afdc-aa7aac98b223"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0b933755-3929-4970-9e65-924c1ad9d427"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0cbf4fbf-23c7-4390-b013-dda8b87e6753"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0ceed50a-7558-4742-baf6-d1a2d9f834ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0cf94f39-c58f-40de-b848-abb34fcdab11"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0d5ffc92-f835-466a-b57b-bb5539613e8b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0d685706-c9a5-412c-b296-4e4f99d25500"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0d9e7fb6-7bcf-4d62-99c4-8e7a80d6de1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0da6eb62-f87b-4b8d-8f56-84cf0ffcfdbc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0ec95507-4f2c-4f67-97fb-83d41b418265"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0ecb8f16-d362-47aa-bd8f-aba5cb67891e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0ede6111-ad59-4a97-934f-5d61431aa610"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0f417ffa-764e-44c1-b64f-85d8a7bef5db"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0fc15f39-9ca1-45ef-9dc8-bc55ae19717a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0fd926b9-6943-41db-ac79-0973843f33bf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0fe2def8-3847-4d6b-8c1d-d5d589df242b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1025d60f-045d-4d18-bf8b-b55c79d4a9d1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1087b4c4-fff3-4ebe-86b0-36ab5acd10cb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("10e2d254-60a5-4300-a66e-25b9aa678b23"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("11ecfdac-364e-4f75-b894-e9f5472c2fa4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1248c46b-9feb-4d57-99e2-8e6e5722dfd5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1281db96-f078-4e2a-8489-9a052b33aab3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("12eaf5da-5225-450b-8e2c-aa2c07209f8f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1302068e-8d80-4358-8e25-160a6b4503b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("131b5100-5a51-4590-818b-b3512bfd116d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("138735b3-9b6a-407d-ad6b-3fe6bfd1eb83"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("14a25339-ec69-4e6a-a2c5-df9a233a70fa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("14c27e44-1b6b-4a1d-95fc-7334b67264f7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("14cdbcd0-aba0-4976-9935-3c320185257c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("157466fa-afb7-4076-ad21-530717018e26"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("15a49315-552f-4f6a-9f25-001a5f13ce07"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("15f10e87-dc54-4e4b-91f6-a67402891ca9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("16460b51-2fcf-470c-bb00-276ba2bade53"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("167f9d00-6d9e-4aa8-a8b0-5b23b2d059bb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("16ff18f0-4057-4958-8507-3c9771cc9c58"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1839b6d3-6a99-421d-b005-7e4bb9d8c01b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("18792222-9315-474a-9dc7-cc10354b7b18"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("18895baf-1493-463f-8c5a-690cd89b3232"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("18d5a51c-632e-451d-a3e1-9ca5fb484154"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("18fbea11-549c-41ea-907a-3c687ee0654f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("19fe27c7-6493-4426-9659-576f5fd3f56e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1a43890f-a96f-4b0f-bef3-be5b12f574bb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1a5d8925-407a-4ca7-bc00-66e78e78d0a1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1abaaf66-3244-437d-ab52-41f4ce76d36e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1acdd02d-b47f-4259-ae8c-a39fe7028d02"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1af6bab8-73c9-4ee7-b2bd-5a24daa9ffa2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1b8a9a93-d1eb-4ef6-a4c2-dac636d6e3de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1bd5a605-a9aa-4a11-91de-fe75aa18bb5f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1c698679-a452-4b49-b00c-0a7781948e64"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1cb011e1-4010-48db-992f-0e990cdb0c14"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1cdafbde-7fb3-4e75-91c9-c2b69ccdc54d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1d7920d7-15ce-4044-8504-1751bfbe535b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1e5a8cd3-90b4-4446-94bf-d3cbe087b2fd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1fc9d5bc-6f28-405b-8a9e-1dcc73e883d6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1fd4846d-b277-4efe-b9af-04ff8d7e8697"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("20b52943-cc85-4aca-846f-79f990d0a7b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("213aa447-ee90-4a85-80b8-355431d61d95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2145fbbf-8504-4e49-9a46-7748608fef9d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("21f89634-1e67-487b-b4c1-479f1ef43b52"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("22094962-1789-45e3-8249-c6859c8fbcad"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("22231497-c3c4-43c6-8764-e008fe5062dc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("222d1b79-8267-4798-b881-bab5f6813f71"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("232f5d75-8488-447f-8b6a-8de60c3673af"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24878f0f-b893-41d7-a296-c054d1b26475"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24cc8724-f4c5-4971-95e3-413639453775"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("25088fd5-59e3-4bab-a47a-d3773560a484"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("25758eb3-93ba-486c-adc6-5695cb1c1873"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("25b44da4-0905-40c9-8f98-1be78cb9a2cf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("25b79ec2-1697-4225-8c1b-300f80dc54b2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("267cbc06-0ea5-4809-81e6-fd425fabc167"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2720957e-ba8f-4a82-9e53-48813dc91b3b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("27979bf2-f76e-43b6-b1a3-00f018bc28f9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("27c832f5-d940-4133-ac35-6349f6c4b59f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("27e4a68f-3394-4846-963b-e4fead16dedb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("27f5d1db-4c36-40ac-bbc2-abf4ff04c750"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("28c0521f-97a0-4e21-a7bc-45028ef1eb09"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2911d037-b839-4428-8fcc-e15ea3474c7e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2937fa44-1847-4019-8daf-f043717fadc4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2952c40c-a21f-464b-9cc2-94e1d06ab28c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2a34e65f-7434-4e61-8409-bfd527d2b8b9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2a4361b4-782d-4a0e-8a50-1f9112da9434"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2af7736a-a2ec-40a6-95b1-522d6da0c69e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2b2cf338-5bdc-48d4-9cf9-80126702734d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2b43a6b1-51dc-41ec-8525-6f9fc8e73da7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2be92935-580e-4f3e-b46b-c3c456f44655"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bf8eb10-b658-4b7c-8f3f-0c83afc6f851"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2c928f36-1aa2-4e1f-8cda-b48b1a695b4c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2ca0a633-a9d0-4acd-8441-de22f7bf1298"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2d99176a-fc73-4fc7-a0d3-d46731af0e4c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2db3fd3c-76ed-4f66-9561-9704b50c904d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2dbd7137-b243-4c35-b500-3f08fab32dea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2dc83419-8e8e-4dc1-acef-20ecc8af7807"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e358a53-53f0-42ae-b5fb-1efcc26a831f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e795847-4b82-493d-981f-aa0aecbaf839"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2eefb633-abad-4f17-83a1-ff1e8cd24f4d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2f9afb16-d08e-4cb5-9b1e-69a0a4d55491"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2fdca055-7193-44bf-b351-e06794b8fb71"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3220ed37-c604-47ae-a724-fd7b68bd6e83"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("325fe720-a257-4bb1-9e29-eb8d8a67965f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("32f68714-7d03-46c1-9ae9-3230ab1015a1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33de038c-80de-4beb-b44b-c6a129a9a2dc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33f626ac-032d-4421-8550-7f459134496b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("341a5b3b-f616-4bec-a433-50a0b13065b8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("349749c3-e70b-4fea-b33b-35b913726b2e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("34b4c9ac-5700-4e88-914a-e2da78e1b8bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3509cb67-69dc-4549-8169-e4d6b06df798"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3514789e-51e1-4e7e-9cd3-7ca5a3896a00"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("356b1cdb-dc3e-43c8-bf59-633b1679855d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("358b3e0c-5255-429b-b66f-060aba39988d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("35a17d4c-3203-4643-b237-4578b56c5877"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("35f2624c-ea35-4a3c-af63-4715ff521161"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("36175c6b-85bd-4615-bb1f-456391811718"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3642ed63-03e4-4012-a8e9-fc206a02681d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3658895a-82dc-4179-94ef-700fdb6d98de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("36aea91c-acb2-4370-911f-21ba7e1bdcc7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("371a9bc8-1fd8-40fb-980d-735602eae2dd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("371cdd5f-b1b9-484f-ab3d-e9122dd0779f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("37e8cbcd-1202-4e31-9505-589f60e2cd8a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("37fad513-a1b0-4330-ba5c-37b735bcbeff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("383b0277-d263-4ca6-a895-2e83d2c6983e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("38509b37-9a4a-46e2-9941-87e047cfb7ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3868539d-b516-43d0-8b14-5153d2b034bb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3910cab4-adc0-410f-ba56-90626ba23684"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3921fbaf-b6aa-41c6-9d4e-b06c1b251d95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("394b5eca-1ebd-4ea2-a9ac-b03cbaa71e07"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("39c6d354-bbc8-4bfc-b956-57554d54af7d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3a207398-ffb8-4fdf-973b-0858c6e96fb2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3bcc229e-c552-40d7-b152-9c42eb013fe7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3bd9fb5b-8397-41a0-9705-c5d3e8ece4c6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3c58eb92-fbd8-4b60-8565-eecde6a26a71"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3c9796ad-61d6-4007-a9bc-f3216873d9fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3cae8445-8772-461b-955f-4e2533a663da"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3cd90b43-7ca5-41b3-a60c-bdcdf3b005ff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3d3119d2-49b5-4360-93f8-a48b28e1bae2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3d7e2d73-9253-44d4-bb85-e5fc99eab549"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3d87651d-5ad3-4d27-9f7c-cb805478c936"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3db30207-0111-4b34-8697-15e686b8ab44"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3de047cf-aa52-4347-be26-027bd8ee3bc5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3de133f0-d8f0-4114-a2f5-83c51e166f2a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3e9fde8a-0dd7-401b-9a87-fab3fab8fa55"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("3f0365b6-2f2e-40c0-83a5-5eff7d3d09cf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("42ad2b90-d981-4f4a-a669-33d0a199be28"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("433e73be-034b-4d0a-9c6e-ca790e39da25"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("439741a8-1697-4aec-92a1-1dbf2cb3ea18"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("43ba9cdb-cd9f-4186-949d-7e826615e6cf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4452c6c0-a983-4da0-bcc5-181563d50429"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("44f1042a-a088-40ed-beb4-523704d4a286"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("44fca0fd-a199-40dd-91a0-c93ff17297cf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4695ed5b-6bde-476f-8064-ddf4e324b944"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("476fe0f7-149c-4156-b46d-519d01fa7bb1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("48352e11-cf84-4d45-98be-4c9795501413"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("48ca3dda-0ab9-4a6b-825b-8b839212ace8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("497cd05c-cd43-44bf-9df8-3876ffebd95d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("49964dad-e5c5-46d7-8baf-7d75dd8676df"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("49a1dc0e-6bc2-4289-80b3-4c61a85dd633"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4a11fb02-8185-4c0e-bce0-bf56db2436ec"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4a89df1e-4263-4bd3-b3f5-ec47d399ef7f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4a992285-9c76-4376-a679-b8f5ec61d400"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ab0609d-4af7-43fa-9c0c-8c7cff1b8816"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4ace9e98-1fd4-4e77-b8da-3c1f869cb6b2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4af595bf-6ead-4e5a-a962-d53f372eafca"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4b9f8008-3206-48fa-a09a-c1b641ccf4b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4c538209-246d-4705-ae9e-415a4779fdec"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4e2a968f-ca49-4ba1-8f4d-550092163bc5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4efcad9f-201a-49c5-a612-e6fd0f8d6c31"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4f5171c4-53c4-4d07-b73b-58cb27343ba6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4faa4f23-0f75-441f-8048-d9f0338101c0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4fb98fcc-c5bd-4d8d-ac3f-7cabf3954ac8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4fd76409-8e66-43aa-9261-da0cb238c689"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("50067643-6f49-4dc7-b1ef-f16b78da8ad5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("503981ad-b428-4fe9-bc56-a1a96ebd17f0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("504a498e-074e-4ced-b80e-361475578816"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("509a3022-49d7-4a78-ac78-ae17f4246dc5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5153f2b1-06af-4b0b-a683-38adda2bd667"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("51e6b040-8c0e-4b6c-b643-a08fb84cafdf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("523558b3-2f92-4869-85d6-99d47981492c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5274cc8f-58b7-46e6-94db-26bc98c974a0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("52b06a3d-6e38-4e84-9b33-01111f9d4502"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("532f0956-d9ac-48e0-9932-a552b774eac3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("53433646-0e07-4145-bedb-0db50cb74707"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5380659f-2ce3-4bfe-a1db-003100941591"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5380e8bf-636b-4486-9044-eb53527f2e05"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("538191e8-5115-410a-8979-245eaf2ee054"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("53c4b47d-9534-485f-a0ad-6a0c9cceba1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("53d20252-1c2e-4146-ba5c-f5f192bd3bfd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("55d8b245-4396-4afb-811a-166e6dc1eccd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("55d8d918-c387-4b88-b778-01c183d4d854"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("561bd8c4-a03d-4be9-a2e8-78ed46ca4274"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5769ccb3-2d3a-4406-8ed5-74ea1f965053"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("58426ca4-5446-47d5-b91a-d317fbfdc525"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("587c4769-f9f4-4071-a4aa-5657ff07f98d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("58d8058e-ba3b-43b6-ad64-efceeff7caf5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("59416f28-e187-40ea-b26e-fc26dc0022ea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("59dd2652-6f89-428c-a402-bff4121455ab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5a431516-a853-4511-b84a-092c5e7a4fa7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5a46e5ca-65b6-4a88-affe-1e0a14bd2429"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5a5738b3-0076-4100-9a95-4a0bc0b0e837"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5a7ea557-47a8-4b28-be39-90b80c104170"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5ae767a4-63a4-4b2e-b342-857fa81f8377"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5aef495f-a566-46f1-aae2-66d7c497630e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5cf81ef7-3334-4fd4-b443-da781fa1bfe9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5d47bba2-ee33-4b27-8c81-15e59c1608e8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5d497ab4-fa1a-405e-9c7b-13d86705e5f5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5d925066-b8ce-4bba-b3d4-7d179a339e13"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5de4c448-dc13-496c-8858-8031eb4c71de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5eba6825-745d-4bf9-ae68-5216f0e7d617"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f2c982d-53fd-4c4c-aaba-b79976b44c95"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f60403f-58da-4f23-9b17-66a4f26aff24"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5f7219c5-694a-4792-860a-852f7bfddfff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("60cc65d0-a79d-4980-b433-343607cd3112"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("61999025-8149-4529-bbd7-c82935d20bc8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("61df6d79-e875-4971-b333-787a5bc6043c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("620a9cd1-b46f-46a0-8989-25d4d2884537"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6250a70d-db50-4fe2-9eb0-9220dc1a68ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("62cb760c-f45e-4b29-8937-cb84398e32a7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("634d9fa0-566a-4ffb-a490-072d970b866b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6362ec8b-4798-4485-9d78-09a367dbd7ae"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("63d55e93-538b-4c21-84b9-9d51a8e0ffff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64d755cc-f6d2-44dd-a7c4-9e55610a81c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64fe9ab9-6403-43a8-a1d7-0cfc98c6657f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("65059c5b-9872-49bb-b477-ce1c89bd0cce"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("65a7332c-313e-48e6-a284-76e83c40d9df"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("666fdd39-a35e-40a5-b61f-52fbf324895b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("66950e8a-cbd7-4a3e-bde7-3acfe719c9b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("66d8b486-0875-40cf-8227-d731fddc8694"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6727637f-0d96-41bb-8a71-3ed377bff5bf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("67454c28-8495-457f-8b7e-37afc6ca598f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6770bc5b-adf0-4128-98eb-5467c5941bbe"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("67cd07fc-a2c7-4630-9512-fd8a0a807b14"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("67d73496-4831-4b92-a231-4ac7866fc28e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("67f34eac-49bc-4026-9284-5c883217d957"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("683f62ac-33ee-45f8-8a5e-721d1b0fbd56"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6856ba53-2c1e-4512-a802-1f41f6477f07"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("689130df-80ce-4f32-b945-4e0ce3ed0c02"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("68a44f88-d6b2-4874-bf57-3cbcae869b15"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("690ae88c-955a-42d6-8bae-cb437f7ffe58"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("697085a0-dcc7-4d69-988c-6bb0e1ec1880"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("69a396b6-43f2-416e-a00e-b3adfea00c88"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6b5226fe-b18e-4e81-a136-e5c8e6ad4f23"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6b751a89-1e62-43ca-b754-2a4123355c9f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6b8771aa-7664-4f7b-87f6-b3457b68374a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6c0a9641-7993-45c5-a852-d3268ac224f2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6c116e93-222e-4813-bd35-97af4e0626eb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6cb305f3-eb38-473b-ae50-2e968e995935"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6d53ec25-c1e2-4bf8-8881-b51b5117e43d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6d97826a-b01a-483c-ad18-7b3b3da99f01"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6deeb509-6c19-4323-b2f7-c86349a2b003"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6df697c7-6939-4f33-a82e-0dcc75fdca4f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6e82bd0a-0023-42c7-9e46-6a5bb95b7484"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6ec740d7-b9cf-46a0-8c42-2c83d3f030b4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6ed19bdd-2cb4-43d9-b830-420cfbe2c180"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6f8c9362-a796-4179-9707-638ee0ea0ec1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6fb52fae-c0ba-40aa-bdd6-86304d63a1e5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("6fcb4eaa-f56c-4565-99ae-6c2d42b448ce"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("70139c7a-6c13-4bdb-87d4-c1694e025026"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("71114bb2-2230-4e41-9533-6d3b34a213ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7177638d-3369-4b4d-b812-408159198a4f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("71883c85-5cca-49b7-bf9d-ae437f3ba3c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72b841d4-68b1-4e9b-a767-fb498485e408"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("72ddafc0-9849-40cc-b04c-10050d485c26"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7380d008-4710-45ee-aff4-9b69627d8fa0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("738ba564-a099-4749-8af6-f13e46b494d2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("73a57c91-2933-4f5b-9754-c542bd143feb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("73a974f3-4c0a-4160-8832-631bdcf99123"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("73bfa88b-6da0-41d0-8e7f-2b344dcc75b2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("741323c4-4349-492d-aeb5-0d1877ea2383"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("746ae46b-0158-4ccb-ae3a-4e5a0f76a1c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("75068271-5119-49f7-8c2a-c8aafe5db994"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("75219ab1-3a27-46dd-b651-797b6a6f20d9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("76393834-3cfc-4e90-86a9-f2ca27953f07"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("767be4eb-dc82-4a86-9c72-9938f0c1a54a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("76d4abc7-148b-41fc-aab6-06f05c220f36"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("76e57b14-7f0c-4110-9fe5-ae82a426fa1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7745a287-443b-411e-85a1-97ca5a4ecd48"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("784b8758-1e5e-471c-a029-24b42a018a3b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7859aa81-14a9-4735-b1f8-f00960d3b342"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("78cc65b6-2bc6-4a36-87c7-6f0a5a375243"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("794c30e1-5ab6-41c7-b562-0683c0b7875e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7aa41135-6051-486d-8eee-4ae624f43516"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7b728c79-dc06-4871-aa28-aaad2a702afb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7bd14181-3064-45eb-8a57-735bbb4f3ee1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7c4434be-d2f7-4d8d-9933-8e4a0e09cf75"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7c9d8b2b-cec8-401f-ac51-d35b2fbe0a59"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7cbe2473-2c54-43f1-9e26-f8cb6c345898"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d025fa4-0ce3-4792-bf95-d6362c98db02"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d761b80-085d-43e6-bb2c-effe2393d35f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7de4bc97-05f9-48e2-a848-f1971a19706a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7e150311-319a-49a9-83c2-192c32b1363b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7f9f6415-2a54-4e46-8886-af514168de43"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("80506364-36c8-4cdd-8719-7a786f31f2a7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("81a5b860-3cbf-42a8-948c-46e22d7d0d0b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("81de9bef-1643-4cb7-8700-10cb9b09cef4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8222e14d-e58d-42f2-94f1-0f20706eb0ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("82885a6f-ba33-4b00-9d73-0a808222a75d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("82932cb1-0765-466d-940c-55c2bc0ae54e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("836f5da6-02f6-401d-8b9e-68088a91dfad"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("83aa75c9-fafe-43e2-adf7-5e0acb1977e7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("83d89db5-7204-46ef-93bf-fd6e9df782cd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("84e31a7b-7d34-4849-9767-a0acde0bc8d0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("84e4ce3d-6234-4e46-93f1-cddb7624e95b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("84f921ca-680a-4203-8346-9e8972ebb1a3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("852d7462-b700-4af6-b686-bf1e001de35b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("858e6f78-5fe3-484a-b874-7289abb29a4a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("85f36fb3-82f1-4955-9850-77c4b336cc5e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("86ed9210-beca-4454-8457-15c80ef05071"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8736b406-20a0-431a-aa2c-69b69fe7f7a4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8744a906-2952-4236-b56d-f60d81c02330"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("876412d0-5548-4a28-ab47-e97e5b02876c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("87fe015d-8af6-45b2-bc90-7fcd7e5a4d68"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("88b01291-97a9-4c27-950c-40b66c115795"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8a626998-9601-4e54-a607-3144cbc8c87f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8aaec912-0f85-4234-ab59-8b1a503684b6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8af7a947-e742-4f20-93c1-56c546a3aed2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8b0997b9-5d4f-48d8-b9ac-7ea47e9ffdef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8b7497a2-eced-4fa7-a661-90d5dd230d44"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8b97e58c-c963-4ff6-96fd-98165b7ddd57"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8bbcf7a2-58b9-44b6-8195-4607a4ace18a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8bc2fbf2-b8be-420a-ab41-e49c44123753"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8c2457e6-d528-4cca-9965-b47a47643d55"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8c3cb427-b57f-4700-aee0-42ab7e62cb98"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8d325859-3e3a-4f81-a33d-222d73760e31"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8e172b22-464d-4821-9e44-42930a56bba8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8e3c13b0-12ad-4e03-a097-560841a5733e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8e4ca83c-b184-4f17-a313-218ebb721134"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8eb3b3ab-dc56-4722-8307-63aeaab37f60"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8fd75b4f-e4c5-4e9e-83be-1e239089f8b9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8fe1c98e-5a98-4269-95c6-95c4ae010ce5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9085c603-b419-420c-8cfe-79d7b016daeb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("90b53bcd-c664-4424-870e-f26a379f38fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("90fc885d-7fb1-46d0-8a1b-c77c9bd0dc58"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9196f1a3-d6d5-4a1d-a167-040c85293f4a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("91a2908f-52e1-4282-87f6-c740f6497403"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("91ce4849-8394-4fd6-b4e0-22dba815f48e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("91cf8bd5-b2a7-49a9-8166-95b73559ad5a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("92dcb42a-2d2a-405b-b9f8-a43981b4e6c5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("936d84fc-1467-4857-979e-6908ec86a62f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("93b68c62-977c-4fe1-be91-347a8fdb5c65"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("93bb9671-13f7-4d67-82a6-fcaa7d85951a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9499012b-9ded-443e-9a92-5166d7d9adc7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("95063ef9-dfb2-482c-8b95-2d990034e231"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("956dfc48-c43b-4e91-9353-9105e1860300"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("95b96ad3-3c42-4563-a5fa-7642b9b9a706"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("97b72887-c52f-4d19-ac99-6b772416e084"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("991640fc-0443-4c08-9a22-7dbce915318a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("991fc667-d805-4de6-9cb3-3081766f90ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("994545f1-93a4-4482-a9e1-98a76169206f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("99771a9f-d0de-49cd-a9b0-c84e9b4bdf8a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("99aa0c17-bd53-4170-a9c3-b8405978d00f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9a497959-c231-4b93-a051-d2d3f921ee41"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9ad9a6eb-7a2f-4eec-89a5-eb7500e746cf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9bba696d-9d79-4338-a1ab-e214d32254a0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9c06d170-1d58-4df3-bed9-072b992f086e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9c9eb9df-a946-4a61-8ea7-51c5520c10ad"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9cce06ba-9a83-4c39-b49e-47be72ac656e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9d5b08b1-dee6-4e69-817e-a8bf92d81124"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9d863819-1a15-444a-9ba0-d32368d0a290"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9ea07d3d-fb8c-4593-a762-ed8f0ed73b5a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9eaecb0c-d67b-4a3f-9295-28c30aaa7ba7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9f47d237-06e8-4131-be82-fa976f77ba89"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9f928a8b-4416-48ec-a03f-3c6df811724b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9fad2647-6ef9-45d0-9a84-7b97aa226c7e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("9ffc0977-37fd-4219-add9-9a25b073a10d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a03622bc-f35f-440f-9cc4-cb1076fe2528"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a0712bbe-47b4-4ddb-a39a-fa82d285db15"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a0b4c6dd-b63e-4341-8f10-2cbcd0bda92a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a10a0a76-ecda-4236-b6db-cb91c89ac080"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a136d6b3-28a6-43b4-912a-7bd9c4fd48de"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a163169f-2cae-4d36-a28c-dc3a3dece569"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a1ceb583-6417-4664-aac4-193be893832b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a1e54121-e8e2-4973-b49c-1f74c10ed69e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a2f76f52-8aa5-4ce4-b11b-138586c1af09"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a329886f-2f4c-423e-a779-3ccb89e61080"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a37d1a36-2bfe-4673-9811-5337c1231fd2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a4262159-a8c9-4350-8f70-4a09698a6a0d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a43f4893-ee73-413d-9004-09c6cf5dfe6c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a44875d4-7608-4c3b-837b-bc7d912760b9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a47af692-2999-45c7-88a5-75f81a07256f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a4fa69ca-095c-4f86-97eb-445be94e9a85"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a5114f33-615c-4c6f-8e19-d1d06ca3ee9a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a5359350-4d68-4343-be09-afe4b4f0e42d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a5496f8d-e857-4ea5-bf27-8e7b533bb0e4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a588eb99-4369-4ba9-83a3-76d84a4bed74"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a59d0611-a60b-479c-b95e-d49076a61694"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a62532c0-0ac2-4680-bfce-462ba0a5a924"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a678f50c-92eb-46d9-a079-99b86cd5cdf2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a6e9a2da-b223-44d9-be33-1d1f3ef18b2e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a7a7194e-dc36-496c-81c4-cd1a4ab2c12f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a7ff2067-4b59-4e9a-8a89-a328132c95f5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a8aa50b5-fdf3-4655-8949-92fe84eb9f79"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a95c8910-d83a-4869-a4cf-08ee55be3f05"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aa1a2ded-0229-4f1a-ae8c-5f80d0cbee38"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aae74c34-8c53-42d6-af9a-08d855388f1d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aafbe801-5353-4a9c-88b9-6844e8211e62"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("abda4420-2bce-41c4-afbc-17fe3add6235"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac1d0e46-93e9-4e8f-bd42-fd8776817650"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac92d821-cfcb-447a-9b8e-db0cac64522a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("acd774db-b92d-4b71-a6a9-462262f6bd94"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ace3e3d5-bf0c-4164-a962-d9e5ac5e8bd6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ace68f80-9a57-4129-9e09-436ea1d736c2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ad1e5cb4-e2a4-437f-87c2-e76a78e4d0e5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ad533211-4ff4-4ce9-828d-082346666f62"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ad5bcddb-97d2-44fa-92f9-d052bd6c04b7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("add8b096-6816-4e92-a968-2b4ddd795f1c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("aebf2bd6-1904-43fd-9b2f-c06fdc04f541"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("af027d77-54e8-417e-b2b0-e40479c99b94"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("af862d57-03a2-4c61-8839-02eb30a1b1b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("afdc2c84-da2b-4484-9418-19a304712224"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b08257b8-25a2-4afb-a578-9d7600243614"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b09e3406-dd10-4ff6-adf1-ba651a14e7a5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b0bcd89e-c1a5-4178-a26d-71439538c3f4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b0c12556-4a63-4d58-8b36-c06a4bd04bb4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b0c354b9-70e3-4f31-a6f4-a3d1da30d4a7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b164b077-7332-44dc-a1ab-ada58c3bcb0c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b1f1c10e-7853-47cd-9718-517038b33496"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b294c6c8-d7b7-424c-a33b-2be6ebc9f87a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b30756ae-be0c-4f72-8e06-2d13237d55ca"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b332f0d9-946f-4d7d-b546-60bc208688d6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b39bc32c-dd43-4027-b289-dad680195b2e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b3d74b2b-99f2-4082-9d3d-e8ea53a6f7e6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b443a348-9799-4c2b-9f05-95869e08f40d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b4b2e261-47f1-42fa-9571-439cb8214205"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b509ccd3-ed6a-43f0-9222-c6f06303c6b5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5175300-5141-40a8-beb3-0e0cc8c6fd91"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b56a5ef6-7988-4e61-9944-beb232f4e3e2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5b0ae08-8e52-45ca-bf68-5a9ef7819577"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b6492e83-2cc9-4841-828b-4e195b88325e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b67bf06c-e412-494e-88e9-e4744e067843"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b6c36cb9-0939-417d-b2c9-2223332af34e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b72ed5a4-9f8e-476a-800f-003e445eb4fd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b7757b09-09fa-40cf-8ba0-09231500e6ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b79722bb-068e-479f-bf3c-b214034a1e48"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b8a0c27d-d0d5-4daa-a960-5f1b595a55ca"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b8a88fec-cbca-408e-ae8f-46beccafa8f9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b8c3d832-e24d-470d-8d87-e3ab5da9ee79"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b927ec44-cac5-4e04-bf0b-ab8b6e63d0d8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b961a7c6-29e1-4642-8802-dbbda19a809c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bb14916a-0ff3-42c5-a08f-e5dcf7653dc6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bb7396ad-9f1f-4e73-bd22-2a465dc1d957"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bb954696-fb7c-4349-a554-8c5f629aff19"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bb96be95-e286-4bd8-b7d7-640bc350018f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bc5c6376-48e7-4814-97c8-ccb63d2b47d6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bc65bda2-f50a-4cd8-a1c4-ede9e5b53b99"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bd936aea-5632-4ec9-9bde-ce8eca0fb7e4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bd9e488f-ec59-459b-98f8-cec2351d2982"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bdb31640-a03f-4d73-bcb8-ca9f07c27385"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bdbfb312-e3f0-43da-8f7f-9f4de500cb37"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bde49538-eadc-4a44-8565-cf835cb82819"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("be5902e9-595e-4743-8004-bb0e46b60b7a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bec5d41c-ddfa-43b3-9d5f-ee594db919a6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bedc959a-ea91-4220-8b7e-71dff6e099bc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c04bbafd-405b-4d69-85ce-3675e5d36372"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c1046597-72fa-4425-bbe4-1bd54f39436e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c1c5bb1b-8d69-4598-b93c-a4bf48066d24"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c1e6f4e7-5bc8-4371-8064-5fb4223d8f44"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c1edd66b-8a9b-47e1-9e05-f38b31f6a079"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c30d297c-daed-48ef-a4f1-8950291e56ff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c3df19ea-6117-4897-8002-2a5290491803"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c3edc96c-896f-4475-a3c7-38fd3e4741a8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c41f1dc4-f199-498a-b4a8-0786fb4fbc79"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c4f3e616-6dde-4be6-a88b-e49a1b290833"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c50a4572-f75c-4f89-8725-27d22731d2d7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c52fbd37-2cb3-44ce-b647-757eb53a1573"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5526c67-3078-4eca-98c6-5e1ae428d9f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c56f9194-091d-4166-ba46-b6d9cbfb608f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c623c617-f77b-4bdb-b49c-9caaa774480b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c663e806-ddba-462a-a1c7-5b2a4c197de7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c691ae42-7764-47df-a354-1ed5df0230a3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c70ba4b6-6477-4542-a5e1-eacf1a011afd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c7739201-0190-4f2d-80d9-ddc77ccbb2ce"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c7ce58f3-b2c6-4d5d-a91b-05c7e9ef5ae0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c7df2366-2784-450c-b014-d58ed22de0a7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c8461714-1444-44df-99ac-584134223147"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c95a0c28-04b3-416b-8315-533b24625c62"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c95a5b6e-2c40-41a5-b044-0351e979eb24"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c9894e9c-9b66-427c-92f0-30648a1e5810"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ca619031-f834-451a-bb11-b9af6c099ebb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("caced371-71f9-4c30-bee7-c57932a9e55f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cb081f39-a330-43f8-bf31-8fa8d4b23320"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cb2bbd63-0980-4ee8-beab-c0f7ab872383"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cb68656a-1d75-47bb-a1fb-14a2ef54aa05"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("cdb9dfb7-70ab-4066-bf0a-a4efbccb1500"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ce32cece-a2aa-4783-85c9-4a9932d9a571"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ce6cca0b-4a61-4dcb-8f0d-f6f0d36df456"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ce84a6d9-f560-45fb-ac5d-fe2d3b8f72ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ceab4e73-213b-494e-b74c-4dc371eff1aa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d013dfc1-9487-4ad2-8b83-63d752461ef8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d08834f2-8e18-444f-a680-32c89b201ba3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d098e30a-0cd8-45fa-b30b-d2b5d6cc028c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d1366bc9-d394-4617-a7da-855969af4d93"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d1c444b8-aab3-4966-bebd-e8f98c51eb26"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d1cc6af7-d846-479e-8b2d-afc96327c3f7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d22a10fa-799e-4002-8f44-114d84f49a1f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d3b1c94b-b992-4ed7-b559-8e94f675137d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d4d2e293-5511-4e22-9df3-b688af486135"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d5ca6334-a710-4952-9344-a3592a88d221"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d632f5b1-a7a1-4d4a-8dd5-40f20cafaede"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d63bbf5d-554d-4a1a-a33f-6b249925f6a8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d8e0d053-6f19-4a44-9028-4353a001d71a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d8e9849e-557f-4593-b9e5-d4e6b0198199"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("da5c2227-bcee-4e5c-921b-89e0a4c20615"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("da68975d-212e-451c-b657-5bdafeb21a46"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dbb45e0d-e5fc-462e-b783-62a2c2dc8d87"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dbe83457-7531-455f-b744-3d3a84708905"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dc0553d6-4402-4148-81c5-2d0d228c3902"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dc08d55d-bfc3-458b-8ad7-3bd5e9e9d7da"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dc355786-5053-47f3-a4f3-1f485701f484"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dc7642e1-db94-4d35-b5e3-84706d0884af"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dd0d613b-d3d8-4bd4-b2c0-35cc5aeb3309"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("de50ff19-01f2-49f1-9ea5-2e779b0486ac"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("dec7cdcf-a00a-4776-9bff-b7e63fe38b2f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("df3a8976-6ee1-4af4-88b3-4592271df72e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("df8d9830-ffbb-422e-b69c-6c3014088345"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e1402f0a-6f80-4867-9fbe-1672924d80ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e20ec806-ab19-45e5-a878-919cce82288f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e23c6d4a-94aa-4bda-8a09-4f3a00c1d2a8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e28f015d-7c7c-4811-9f57-bedbbccc1cbd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e3254490-0e4e-4b4c-b6ef-4616256790a4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e369fca0-2e05-447b-b86f-c322c81af86f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e3e89c5e-d1e3-4e08-9e9f-2e3d6498196a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e3edb88d-789e-4c88-87b1-0c9f6f0284db"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e52bd501-3258-4414-a396-b891f047dac9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e53a96e4-5c39-4739-94b2-cabdced13469"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e5928360-c189-4a52-b461-ebe0ec2507d5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e5b35dcb-548d-45d2-93ba-41128094afab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e5c5d7d3-25cf-4f74-a202-75ac70a95a42"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e61caebe-1e1d-444e-9273-3d6cc9b00293"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e625ce4e-cec8-433c-bb00-38923eab6db5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e6d2c155-9c3c-463c-98f3-0f7699e65c49"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e80fd575-c9eb-408d-8f1d-cb9d434c7ea6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8788c82-352f-46d1-ad4a-b793fb8fdd83"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e1e594-ab50-4f08-9a3b-50e404969608"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e940cd56-6009-4fff-a9fa-2aa0c1d1df4d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e9829cd2-b11e-4e81-8920-df37bec75c68"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e9ec1912-5d14-4338-a6eb-68a554e18720"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ea0c9879-b19b-4e47-8879-1b1ac5b9536b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ea2797dd-7097-4cd1-8ff5-ee735807634e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ea899a8e-0e39-4b1f-9e0b-6eb5934aca53"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eadec3b1-2ad4-4b78-86a8-d56dd9247e64"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eb5c449a-303e-4f73-a386-cd79ea2e5d88"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eb7e4fca-a451-4452-a2dd-7b83e372311a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("eba42403-dce5-470b-a1da-63687b6ed5f6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ec266772-d14c-4450-a84f-4425483a41f4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ec431d1f-308a-49a9-88ef-4f97349a9a6a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ec4aa741-496b-4a52-822f-1099d218f328"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ec8e4ccd-bd7a-4690-827c-f75973e8d465"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ed3a8060-b3db-4a19-8c33-20be4acb9208"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ed700c11-0c4a-4e26-b52e-fa295301c2d3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ed8fcd57-ffda-47db-8107-65c730b642f3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("edc1ba6b-4403-46f5-bc5d-1ee8ec9a353a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ede20578-f3bb-4b60-aec8-208e6470772d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ee7ac866-ac0a-4e21-8a39-f9819fb2f33d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ee8e3c8c-a3df-430b-8e07-98267892abe7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ee8f5d1f-564b-4c7f-afa7-9cd722d21fe9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ef76794a-1c1b-4b5f-aea6-66120cdd4c87"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ef7b31d4-5bd2-4689-abe2-6073c1f11a90"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ef8cbeb8-2b81-4c0b-a651-8b5e485b29ed"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("efaea93d-8add-41e5-8601-8521541c9b1f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f1e93272-da66-4117-b84f-21a4c154ee71"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f219697e-0a19-466d-9afe-1bc6802dbb6a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f23e51a1-c7bc-48c0-ac59-1160a4ef636a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f27a9091-2656-4dab-bea3-4053184a42d3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f344d0a6-bd6e-41d2-8e8e-4ee6626cd34b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f3a2d422-e9ce-4bda-93b1-6c6c05d9bb1e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f3a7d97c-16be-4402-8c8a-978a85d6b254"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f3b7ee80-0c64-4e01-a409-ef6a88cc9cfb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f3bf4c79-af62-4b46-9113-eda5243d5701"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f3c84ba8-01c8-4fd2-a47c-0f213462fa28"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f3cc37bd-f9a5-49c3-88bf-ec360a245f6f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f48e6883-2966-4822-8433-b18d619808ea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f5010ba3-bb59-464d-8e72-ee74f7b08868"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f6e1ed45-6cd2-41f2-985d-8c144810f820"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7781d83-6905-4865-aac2-ba841334fe0c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7986027-cfa1-4c10-8f34-bf95cb5b812c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f81a29bc-1557-4b3e-948e-bd604a683e1f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f845aa53-c634-4a31-a8f9-d71b14fbeffe"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f87ea182-306a-448f-803f-d3c91f5a6dca"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f8bb7e04-e493-45b0-b323-4db8818a4473"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f9306978-8fc1-47dc-ba7b-b2aed6f94a67"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f9f5f912-3053-4fd6-af8b-82aab72026b8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f9fba363-d267-4248-955f-f9bc632d6737"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fa9a2f64-0908-49c8-8afe-d2fc45a83df4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fabd77ff-2ad4-4544-b230-3d126e61d213"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fba0c2f7-a70d-4d0e-b8f9-cab54c5e4752"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fbbffb5e-56cf-44cd-815a-d1a00a0eafa9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fbd14cbb-a961-4de7-b7e3-c40c2cf65528"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fbfecfaa-f915-4006-ae69-6960f7bd5a0f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fcb9f33c-06d2-4c1a-8673-5d6f62342a4b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fd773f34-1f6b-4b48-994f-400d3850459f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fd9f2dda-7909-465c-b6f9-b93316a50bd9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fe5d6a86-54ea-4fd8-826e-4b95cb093b4d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fe69727f-3a9c-45b6-98ff-40e2fcabf918"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fe7c3a03-2532-4d05-b18c-cfcc0138ef77"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ff54134d-ee85-4c4f-b8f6-60d704d65ecf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ff5f61e3-2bf2-4fa9-b9c4-a3af97670bfb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ff733029-b575-43d4-b993-ffc9e0cf1feb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("fff80cde-6282-46a9-b2ad-9f92d546c8d3"));

            migrationBuilder.AddColumn<decimal>(
                name: "_price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
