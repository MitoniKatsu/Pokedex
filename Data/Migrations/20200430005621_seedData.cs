using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonSpecies_Type_PrimaryTypeID",
                table: "PokemonSpecies");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonSpecies_Type_SecondaryTypeID",
                table: "PokemonSpecies");

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "TypeID", "TypeName" },
                values: new object[,]
                {
                    { 1, "normal" },
                    { 16, "dragon" },
                    { 15, "ice" },
                    { 14, "psychic" },
                    { 13, "electric" },
                    { 12, "grass" },
                    { 11, "water" },
                    { 10, "fire" },
                    { 9, "steel" },
                    { 8, "ghost" },
                    { 7, "bug" },
                    { 6, "rock" },
                    { 5, "ground" },
                    { 4, "poison" },
                    { 3, "flying" },
                    { 2, "fighting" },
                    { 17, "dark" },
                    { 18, "fairy" }
                });

            migrationBuilder.InsertData(
                table: "PokemonSpecies",
                columns: new[] { "SpeciesID", "PrimaryTypeID", "SecondaryTypeID", "SpeciesDescription", "SpeciesName" },
                values: new object[,]
                {
                    { 19, 1, null, "Bites anything when it attacks. Small and very quick, it is a common sight in many places.", "Rattata" },
                    { 25, 13, null, "When several of these pokèmon gather, their electricity could build and cause lightning storms.", "Pikachu" },
                    { 26, 13, null, "Its long tail serves as a ground to protect itself from its own high voltage power.", "Raichu" },
                    { 81, 13, 9, "Uses anti-gravity to stay suspended. Appears without warning and uses THUNDER WAVE and similar moves.", "Magnemite" },
                    { 82, 13, 9, "Formed by several MAGNEMITEs linked together. They frequently appear when sunspots flare up.", "Magneton" },
                    { 100, 13, null, "Usually found in power plants. Easily mistaken for a POKé BALL, they have zapped many people.", "Voltorb" },
                    { 101, 13, null, "It stores electric energy under very high pressure. It often explodes with little or no provocation.", "Electrode" },
                    { 125, 13, null, "Normally found near power plants, they can wander away and cause major blackouts in cities.", "Electabuzz" },
                    { 135, 13, null, "It accumulates negative ions in the atmosphere to blast out 10000- volt lightning bolts.", "Jolteon" },
                    { 711, 8, 12, "Singing in eerie voices, they wander town streets on the night of the new moon. Anyone who hears their song is cursed.", "Gourgeist-average" },
                    { 145, 13, 3, "A legendary bird pokèmon that is said to appear from clouds while dropping enormous lightning bolts.", "Zapdos" },
                    { 171, 11, 13, "The light it emits is so bright that it can illuminate the sea's surface from a depth of over three miles.", "Lanturn" },
                    { 172, 13, null, "It is not yet skilled at storing electricity. It may send out a jolt if amused or startled.", "Pichu" },
                    { 179, 13, null, "If static elec­ tricity builds in its body, its fleece doubles in volume. Touching it will shock you.", "Mareep" },
                    { 180, 13, null, "As a result of storing too much electricity, it developed patches where even downy wool won't grow.", "Flaaffy" },
                    { 181, 13, null, "The tail's tip shines brightly and can be seen from far away. It acts as a beacon for lost people.", "Ampharos" },
                    { 239, 13, null, "It rotates its arms to generate electricity, but it tires easily, so it charges up only a little bit.", "Elekid" },
                    { 243, 13, null, "The rain clouds it carries let it fire thunderbolts at will. They say that it descended with lightning.", "Raikou" },
                    { 309, 13, null, "ELECTRIKE stores electricity in its long body hair. This pokèmon stimulates its leg muscles with electric charges. These jolts of power give its legs explosive acceleration performance.", "Electrike" },
                    { 170, 11, 13, "It shoots positive and negative elec­ tricity between the tips of its two antennae and zaps its enemies.", "Chinchou" },
                    { 310, 13, null, "MANECTRIC is constantly discharging electricity from its mane. The sparks sometimes ignite forest fires. When it enters a battle, this pokèmon creates thunderclouds.", "Manectric" },
                    { 710, 8, 12, "The pumpkin body is inhabited by a spirit trapped in this world. As the sun sets, it becomes restless and active.", "Pumpkaboo-average" },
                    { 708, 8, 12, "These Pokémon are created when spirits possess rotten tree stumps. They prefer to live in abandoned forests.", "Phantump" },
                    { 540, 7, 12, "Leavanny dress it in clothes they made for it when it hatched. It hides its head in its hood while it is sleeping.", "Sewaddle" },
                    { 541, 7, 12, "Forests where Swadloon live have superb foliage because the nutrients they make from fallen leaves nourish the plant life.", "Swadloon" },
                    { 542, 7, 12, "Upon finding a small Pokémon, it weaves clothing for it from leaves, using the cutters on its arms and sticky silk.", "Leavanny" },
                    { 548, 12, null, "The leaves on its head are very bitter. Eating one of these leaves is known to refresh a tired body.", "Petilil" },
                    { 549, 12, null, "Even veteran Trainers face a challenge in getting its beautiful flower to bloom. This Pokémon is popular with celebrities.", "Lilligant" },
                    { 556, 12, null, "It uses an up-tempo song and dance to drive away the bird Pokémon that prey on its flower seeds.", "Maractus" },
                    { 585, 1, 12, "The color and scent of their fur changes to match the mountain grass. When they sense hostility, they hide in the grass.", "Deerling" },
                    { 586, 1, 12, "They migrate according to the seasons. People can tell the season by looking at Sawsbuck’s horns.", "Sawsbuck" },
                    { 709, 8, 12, "It can control trees at will. It will trap people who harm the forest, so they can never leave.", "Trevenant" },
                    { 590, 12, 4, "It lures people in with its Poké Ball pattern, then releases poison spores. Why it resembles a Poké Ball is unknown.", "Foongus" },
                    { 597, 12, 9, "When threatened, it attacks by shooting a barrage of spikes, which gives it a chance to escape by rolling away.", "Ferroseed" },
                    { 598, 12, 9, "It fights by swinging around its three spiky feelers. A hit from these steel spikes can reduce a boulder to rubble.", "Ferrothorn" },
                    { 640, 12, 2, "This Pokémon fought humans in order to protect its friends. Legends about it continue to be passed down.", "Virizion" },
                    { 650, 12, null, "The quills on its head are usually soft. When it flexes them, the points become so hard and sharp that they can pierce rock.", "Chespin" },
                    { 651, 12, null, "It relies on its sturdy shell to deflect predators’ attacks. It counterattacks with its sharp quills.", "Quilladin" },
                    { 652, 12, 2, "Its Tackle is forceful enough to flip a 50-ton tank. It shields its allies from danger with its own body.", "Chesnaught" },
                    { 672, 12, null, "Thought to be one of the first Pokémon to live in harmony with humans, it has a placid disposition.", "Skiddo" },
                    { 673, 12, null, "It can tell how its Trainer is feeling by subtle shifts in the grip on its horns. This empathic sense lets them run as if one being.", "Gogoat" },
                    { 591, 12, 4, "It lures prey close by dancing and waving its arm caps, which resemble Poké Balls, in a swaying motion.", "Amoonguss" },
                    { 311, 13, null, "PLUSLE always acts as a cheerleader for its partners. Whenever a teammate puts out a good effort in battle, this pokèmon shorts out its body to create the crackling noises of sparks to show its joy.", "Plusle" },
                    { 312, 13, null, "MINUN is more concerned about cheering on its partners than its own safety. It shorts out the electricity in its body to create brilliant showers of sparks to cheer on its teammates.", "Minun" },
                    { 403, 13, null, "All of its fur dazzles if danger is sensed. It flees while the foe is momentarily blinded.", "Shinx" },
                    { 96, 14, null, "Puts enemies to sleep then eats their dreams. Occasionally gets sick from eating bad dreams.", "Drowzee" },
                    { 97, 14, null, "When it locks eyes with an enemy, it will use a mix of PSI moves such as HYPNOSIS and CONFUSION.", "Hypno" },
                    { 102, 12, 14, "Often mistaken for eggs. When disturbed, they quickly gather and attack in swarms.", "Exeggcute" },
                    { 103, 12, 14, "Legend has it that on rare occasions, one of its heads will drop off and continue on as an EXEGGCUTE.", "Exeggutor" },
                    { 121, 11, 14, "Its central core glows with the seven colors of the rainbow. Some people value the core as a gem.", "Starmie" },
                    { 150, 14, null, "It was created by a scientist after years of horrific gene splicing and DNA engineering experiments.", "Mewtwo" },
                    { 151, 14, null, "So rare that it is still said to be a mirage by many experts. Only a few people have seen it worldwide.", "Mew" },
                    { 177, 14, 3, "Because its wings aren't yet fully grown, it has to hop to get around. It is always star­ ing at something.", "Natu" },
                    { 80, 11, 14, "The SHELLDER that is latched onto SLOWPOKE's tail is said to feed on the host's left over scraps.", "Slowbro" },
                    { 178, 14, 3, "They say that it stays still and quiet because it is seeing both the past and future at the same time.", "Xatu" },
                    { 199, 11, 14, "It has incredible intellect and in­ tuition. Whatever the situation, it remains calm and collected.", "Slowking" },
                    { 201, 14, null, "Their shapes look like hieroglyphs on ancient tab­ lets. It is said that the two are somehow related.", "Unown" },
                    { 202, 14, null, "It hates light and shock. If attack­ ed, it inflates its body to pump up its counter­ strike.", "Wobbuffet" },
                    { 203, 1, 14, "Its tail has a small brain of its own. Beware! If you get close, it may react to your scent and bite.", "Girafarig" },
                    { 249, 14, 3, "It is said that it quietly spends its time deep at the bottom of the sea because its powers are too strong.", "Lugia" },
                    { 251, 14, 12, "This pokèmon wan­ ders across time. Grass and trees flourish in the forests in which it has appeared.", "Celebi" },
                    { 307, 2, 14, "MEDITITE undertakes rigorous mental training deep in the mountains. However, whenever it meditates, this pokèmon always loses its concentration and focus. As a result, its training never ends.", "Meditite" },
                    { 308, 2, 14, "It is said that through meditation, MEDICHAM heightens energy inside its body and sharpens its sixth sense. This pokèmon hides its presence by merging itself with fields and mountains.", "Medicham" },
                    { 196, 14, null, "It uses the fine hair that covers its body to sense air currents and predict its ene­ my's actions.", "Espeon" },
                    { 79, 11, 14, "Incredibly slow and dopey. It takes 5 seconds for it to feel pain when under attack.", "Slowpoke" },
                    { 65, 14, null, "Its brain can out­ perform a super­ computer. Its intelligence quotient is said to be 5,000.", "Alakazam" },
                    { 64, 14, null, "It emits special alpha waves from its body that induce headaches just by being close by.", "Kadabra" },
                    { 404, 13, null, "Its claws loose electricity with enough amperage to cause fainting. They live in small groups.", "Luxio" },
                    { 405, 13, null, "It has eyes that can see through anything. It spots and captures prey hiding behind objects.", "Luxray" },
                    { 417, 13, null, "It makes fur balls that crackle with static electricity. It stores them with berries in tree holes.", "Pachirisu" },
                    { 462, 13, 9, "It evolved from exposure to a special magnetic field. Three units generate magnetism.", "Magnezone" },
                    { 466, 13, null, "It pushes the tips of its two tails against the foe, then lets loose with over 20,000 volts of power.", "Electivire" },
                    { 479, 13, 8, "Its body is composed of plasma. It is known to infiltrate electronic devices and wreak havoc.", "Rotom" },
                    { 522, 13, null, "Its mane shines when it discharges electricity. They use their flashing manes to communicate with one another.", "Blitzle" },
                    { 523, 13, null, "They have lightning-like movements. When Zebstrika run at full speed, the sound of thunder reverberates.", "Zebstrika" },
                    { 587, 13, 3, "The energy made in its cheeks’ electric pouches is stored inside its membrane and released while it is gliding.", "Emolga" },
                    { 595, 7, 13, "Joltik that live in cities have learned a technique for sucking electricity from the outlets in houses.", "Joltik" },
                    { 596, 7, 13, "When attacked, they create an electric barrier by spitting out many electrically charged threads.", "Galvantula" },
                    { 602, 13, null, "While one alone doesn’t have much power, a chain of many Tynamo can be as powerful as lightning.", "Tynamo" },
                    { 603, 13, null, "They coil around foes and shock them with electricity-generating organs that seem simply to be circular patterns.", "Eelektrik" },
                    { 604, 13, null, "They crawl out of the ocean using their arms. They will attack prey on shore and immediately drag it into the ocean.", "Eelektross" },
                    { 618, 5, 13, "Its skin is very hard, so it is unhurt even if stepped on by sumo wrestlers. It smiles when transmitting electricity.", "Stunfisk" },
                    { 642, 13, 3, "Countless charred remains mar the landscape of places through which Thundurus has passed.", "Thundurus-incarnate" },
                    { 694, 13, 1, "They make their home in deserts. They can generate their energy from basking in the sun, so eating food is not a requirement. ", "Helioptile" },
                    { 695, 13, 1, "They flare their frills and generate energy. A single Heliolisk can generate sufficient electricity to power a skyscraper.", "Heliolisk" },
                    { 63, 14, null, "Using its ability to read minds, it will identify impending danger and TELEPORT to safety.", "Abra" },
                    { 512, 12, null, "Ill tempered, it fights by swinging its barbed tail around wildly. The leaf growing on its head is very bitter.", "Simisage" },
                    { 511, 12, null, "This Pokémon dwells deep in the forest. Eating a leaf from its head whisks weariness away as if by magic.", "Pansage" },
                    { 497, 12, null, "It can stop its opponents’ movements with just a glare. It takes in solar energy and boosts it internally.", "Serperior" },
                    { 496, 12, null, "It moves along the ground as if sliding. Its swift movements befuddle its foes, and it then attacks with a vine whip.", "Servine" },
                    { 564, 11, 6, "Restored from a fossil, this Pokémon can dive to depths beyond half a mile.", "Tirtouga" },
                    { 565, 11, 6, "They can live both in the ocean and on land. A slap from one of them is enough to open a hole in the bottom of a tanker.", "Carracosta" },
                    { 580, 11, 3, "These bird Pokémon are excellent divers. They swim around in the water eating their favorite food--peat moss.", "Ducklett" },
                    { 581, 11, 3, "Swanna start to dance at dusk. The one dancing in the middle is the leader of the flock.", "Swanna" },
                    { 592, 11, 8, "With its thin, veil-like arms wrapped around the body of its opponent, it sinks to the ocean floor.", "Frillish" },
                    { 593, 11, 8, "The fate of the ships and crew that wander into Jellicent’s habitat: all sunken, all lost, all vanished.", "Jellicent" },
                    { 594, 11, null, "The special membrane enveloping Alomomola has the ability to heal wounds.", "Alomomola" },
                    { 647, 11, 2, "By blasting water from its hooves, it can glide across water. It excels at using leg moves while battling.", "Keldeo-ordinary" },
                    { 550, 11, null, "Red and blue Basculin get along so poorly, they’ll start fighting instantly. These Pokémon are very hostile.", "Basculin-red-striped" },
                    { 656, 11, null, "It secretes flexible bubbles from its chest and back. The bubbles reduce the damage it would otherwise take when attacked.", "Froakie" },
                    { 688, 6, 11, "Two Binacle live together on one rock. When they fight, one of them will move to a different rock.", "Binacle" },
                    { 689, 6, 11, "When they evolve, two Binacle multiply into seven. They fight with the power of seven Binacle.", "Barbaracle" },
                    { 690, 4, 11, "Camouflaged as rotten kelp, they spray liquid poison on prey that approaches unawares and then finish it off.", "Skrelp" },
                    { 692, 11, null, "They knock down flying prey by firing compressed water from their massive claws like shooting a pistol.", "Clauncher" },
                    { 693, 11, null, "Their enormous claws launch cannonballs of water powerful enough to pierce tanker hulls.", "Clawitzer" },
                    { 1, 12, 4, "A strange seed was planted on its back at birth. The plant sprouts and grows with this pokèmon.", "Bulbasaur" },
                    { 2, 12, 4, "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", "Ivysaur" },
                    { 3, 12, 4, "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", "Venusaur" },
                    { 657, 11, null, "It can throw bubble-covered pebbles with precise control, hitting empty cans up to a hundred feet away.", "Frogadier" },
                    { 537, 11, 5, "They shoot paralyzing liquid from their head bumps. They use vibration to hurt their opponents.", "Seismitoad" },
                    { 536, 11, 5, "When they vibrate the bumps on their heads, they can make waves in water or earthquake-like vibrations on land.", "Palpitoad" },
                    { 535, 11, null, "They warn others of danger by vibrating their cheeks to create a high-pitched sound.", "Tympole" },
                    { 382, 11, null, "KYOGRE has the power to create massive rain clouds that cover the entire sky and bring about torrential downpours. This pokèmon saved people who were suffering from droughts.", "Kyogre" },
                    { 393, 11, null, "Because it is very proud, it hates accepting food from people. Its thick down guards it from cold.", "Piplup" },
                    { 394, 11, null, "It lives alone, away from others. Apparently, every one of them believes it is the most important.", "Prinplup" },
                    { 395, 11, 9, "The three horns that extend from its beak attest to its power. The leader has the biggest horns.", "Empoleon" },
                    { 400, 1, 11, "It makes its nest by damming streams with bark and mud. It is known as an industrious worker.", "Bibarel" },
                    { 418, 11, null, "It has a flotation sac that is like an inflatable collar. It floats on water with its head out.", "Buizel" },
                    { 419, 11, null, "It floats using its well-developed flotation sac. It assists in the rescues of drowning people.", "Floatzel" },
                    { 422, 11, null, "Its colors and shapes differ from region to region. In the Sinnoh region, two types are confirmed.", "Shellos" },
                    { 423, 11, 5, "It has a pliable body without any bones. If any part of its body is torn off, it grows right back.", "Gastrodon" },
                    { 456, 11, null, "After long exposure to sunlight, the patterns on its tail fins shine vividly when darkness arrives.", "Finneon" },
                    { 457, 11, null, "It lives on the deep-sea floor. It attracts prey by flashing the patterns on its four tail fins.", "Lumineon" },
                    { 458, 11, 3, "A friendly Pokémon that captures the subtle flows of seawater using its two antennae.", "Mantyke" },
                    { 489, 11, null, "A Pokémon that lives in warm seas. It inflates the flotation sac on its head to drift and search for food.", "Phione" },
                    { 490, 11, null, "Born on a cold seafloor, it will swim great distances to return to its birthplace.", "Manaphy" },
                    { 501, 11, null, "It fights using the scalchop on its stomach. In response to an attack, it retaliates immediately by slashing.", "Oshawott" },
                    { 502, 11, null, "Strict training is how it learns its flowing double-scalchop technique.", "Dewott" },
                    { 503, 11, null, "One swing of the sword incorporated in its armor can fell an opponent. A simple glare from one of them quiets everybody.", "Samurott" },
                    { 515, 11, null, "The water stored inside the tuft on its head is full of nutrients. Plants that receive its water grow large.", "Panpour" },
                    { 516, 11, null, "The tuft on its head holds water. When the level runs low, it replenishes the tuft by siphoning up water with its tail.", "Simipour" },
                    { 43, 12, 4, "During the day, it keeps its face buried in the ground. At night, it wanders around sowing its seeds.", "Oddish" },
                    { 325, 14, null, "SPOINK bounces around on its tail. The shock of its bouncing makes its heart pump. As a result, this pokèmon cannot afford to stop bouncing - if it stops, its heart will stop.", "Spoink" },
                    { 44, 12, 4, "The fluid that oozes from its mouth isn't drool. It is a nectar that is used to attract prey.", "Gloom" },
                    { 46, 7, 12, "Burrows to suck tree roots. The mushrooms on its back grow by draw­ ing nutrients from the bug host.", "Paras" },
                    { 315, 12, 4, "ROSELIA shoots sharp thorns as projectiles at any opponent that tries to steal the flowers on its arms. The aroma of this pokèmon brings serenity to living things.", "Roselia" },
                    { 331, 12, null, "CACNEA lives in arid locations such as deserts. It releases a strong aroma from its flower to attract prey. When prey comes near, this pokèmon shoots sharp thorns from its body to bring the victim down.", "Cacnea" },
                    { 345, 6, 12, "LILEEP became extinct approximately a hundred million years ago. This ancient pokèmon attaches itself to a rock on the seafloor and catches approaching prey using tentacles shaped like flower petals.", "Lileep" },
                    { 346, 6, 12, "CRADILY roams around the ocean floor in search of food. This pokèmon freely extends its tree trunk-like neck and captures unwary prey using its eight tentacles.", "Cradily" },
                    { 357, 12, 3, "The bunches of fruit around TROPIUS’s neck are very popular with children. This pokèmon loves fruit, and eats it continuously. Apparently, its love for fruit resulted in its own outgrowth of fruit.", "Tropius" },
                    { 387, 12, null, "Made from soil, the shell on its back hardens when it drinks water. It lives along lakes.", "Turtwig" },
                    { 388, 12, null, "It lives along water in forests. In the daytime, it leaves the forest to sunbathe its treed shell.", "Grotle" },
                    { 389, 12, 5, "Small Pokémon occasionally gather on its unmoving back to begin building their nests.", "Torterra" },
                    { 286, 12, 2, "BRELOOM closes in on its foe with light and sprightly footwork, then throws punches with its stretchy arms. This pokèmon’s fighting technique puts boxers to shame.", "Breloom" },
                    { 406, 12, 4, "Over the winter, it closes its bud and endures the cold. In spring, the bud opens and releases pollen.", "Budew" },
                    { 413, 7, 12, "When BURMY evolved, its cloak became a part of this Pokémon’s body. The cloak is never shed.", "Wormadam-plant" },
                    { 420, 12, null, "The small ball holds the nutrients needed for evolution. Apparently, it is very sweet and tasty.", "Cherubi" },
                    { 421, 12, null, "It blooms during times of strong sunlight. It tries to make up for everything it endured as a bud.", "Cherrim" },
                    { 455, 12, null, "It attracts prey with its sweet- smelling saliva, then chomps down. It takes a whole day to eat prey.", "Carnivine" },
                    { 465, 12, null, "It ensnares prey by extending arms made of vines. Losing arms to predators does not trouble it.", "Tangrowth" },
                    { 470, 12, null, "Just like a plant, it uses photosynthesis. As a result, it is always enveloped in clear air.", "Leafeon" },
                    { 492, 12, null, "It lives in flower patches and avoids detection by curling up to look like a flowering plant.", "Shaymin-land" },
                    { 495, 12, null, "It is very intelligent and calm. Being exposed to lots of sunlight makes its movements swifter.", "Snivy" },
                    { 407, 12, 4, "It attracts prey with a sweet aroma, then downs it with thorny whips hidden in its arms.", "Roserade" },
                    { 285, 12, null, "SHROOMISH live in damp soil in the dark depths of forests. They are often found keeping still under fallen leaves. This pokèmon feeds on compost that is made up of fallen, rotted leaves.", "Shroomish" },
                    { 273, 12, null, "SEEDOT attaches itself to a tree branch using the top of its head. It sucks moisture from the tree while hanging off the branch. The more water it drinks, the glossier this pokèmon’s body becomes.", "Seedot" },
                    { 272, 11, 12, "LUDICOLO begins dancing as soon as it hears cheerful, festive music. This pokèmon is said to appear when it hears the singing of children on hiking outings.", "Ludicolo" },
                    { 47, 7, 12, "A host-parasite pair in which the parasite mushroom has taken over the host bug. Prefers damp places.", "Parasect" },
                    { 69, 12, 4, "A carnivorous pokèmon that traps and eats bugs. It uses its root feet to soak up needed moisture.", "Bellsprout" },
                    { 70, 12, 4, "It spits out POISONPOWDER to immobilize the enemy and then finishes it with a spray of ACID.", "Weepinbell" },
                    { 71, 12, 4, "Said to live in huge colonies deep in jungles, although no one has ever returned from there.", "Victreebel" },
                    { 114, 12, null, "The whole body is swathed with wide vines that are similar to sea­ weed. Its vines shake as it walks.", "Tangela" },
                    { 152, 12, null, "A sweet aroma gently wafts from the leaf on its head. It is docile and loves to soak up the sun's rays.", "Chikorita" },
                    { 153, 12, null, "The scent of spices comes from around its neck. Somehow, sniffing it makes you want to fight.", "Bayleef" },
                    { 154, 12, null, "The aroma that rises from its petals contains a substance that calms aggressive feelings.", "Meganium" },
                    { 182, 12, null, "BELLOSSOM gather at times and appear to dance. They say that the dance is a ritual to summon the sun.", "Bellossom" },
                    { 187, 12, 3, "To keep from being blown away by the wind, they gather in clusters. They do enjoy gentle breezes, though.", "Hoppip" },
                    { 188, 12, 3, "The bloom on top of its head opens and closes as the temperature fluc­ tuates up and down.", "Skiploom" },
                    { 189, 12, 3, "Once it catches the wind, it deft­ ly controls its cotton-puff spores to float, even around the world.", "Jumpluff" },
                    { 191, 12, null, "It may drop out of the sky suddenly. If attacked by a SPEAROW, it will violently shake its leaves.", "Sunkern" },
                    { 192, 12, null, "It converts sun­ light into energy. In the darkness after sunset, it closes its petals and becomes still.", "Sunflora" },
                    { 252, 12, null, "TREECKO has small hooks on the bottom of its feet that enable it to scale vertical walls. This pokèmon attacks by slamming foes with its thick tail.", "Treecko" },
                    { 253, 12, null, "The leaves growing out of GROVYLE’s body are convenient for camouflaging it from enemies in the forest. This pokèmon is a master at climbing trees in jungles.", "Grovyle" },
                    { 254, 12, null, "The leaves growing on SCEPTILE’s body are very sharp edged. This pokèmon is very agile - it leaps all over the branches of trees and jumps on its foe from above or behind.", "Sceptile" },
                    { 270, 11, 12, "LOTAD live in ponds and lakes, where they float on the surface. It grows weak if its broad leaf dies. On rare occasions, this pokèmon travels on land in search of clean water.", "Lotad" },
                    { 271, 11, 12, "LOMBRE is nocturnal - it will get active after dusk. It is also a mischief-maker. When this pokèmon spots anglers, it tugs on their fishing lines from beneath the surface and enjoys their consternation.", "Lombre" },
                    { 45, 12, 4, "The larger its petals, the more toxic pollen it contains. Its big head is heavy and hard to hold up.", "Vileplume" },
                    { 326, 14, null, "GRUMPIG uses the black pearls on its body to amplify its psychic power waves for gaining total control over its foe. When this pokèmon uses its special power, its snorting breath grows labored.", "Grumpig" },
                    { 337, 6, 14, "LUNATONE was discovered at a location where a meteorite fell. As a result, some people theorize that this pokèmon came from space. However, no one has been able to prove this theory so far.", "Lunatone" },
                    { 338, 6, 14, "SOLROCK is a new species of pokèmon that is said to have fallen from space. It floats in air and moves silently. In battle, this pokèmon releases intensely bright light.", "Solrock" },
                    { 332, 12, 17, "During the daytime, CACTURNE remains unmoving so that it does not lose any moisture to the harsh desert sun. This pokèmon becomes active at night when the temperature drops.", "Cacturne" },
                    { 342, 11, 17, "CRAWDAUNT has an extremely violent nature that compels it to challenge other living things to battle. Other life-forms refuse to live in ponds inhabited by this pokèmon, making them desolate places.", "Crawdaunt" },
                    { 359, 17, null, "Every time ABSOL appears before people, it is followed by a disaster such as an earthquake or a tidal wave. As a result, it came to be known as the disaster pokèmon.", "Absol" },
                    { 430, 17, 3, "Becoming active at night, it is known to swarm with numerous MURKROW in tow.", "Honchkrow" },
                    { 434, 4, 17, "It protects itself by spraying a noxious fluid from its rear. The stench lingers for 24 hours.", "Stunky" },
                    { 435, 4, 17, "It sprays a vile-smelling fluid from the tip of its tail to attack. Its range is over 160 feet.", "Skuntank" },
                    { 442, 8, 17, "A Pokémon that was formed by 108 spirits. It is bound to a fissure in an odd keystone.", "Spiritomb" },
                    { 452, 4, 17, "It has the power in its clawed arms to make scrap of a car. The tips of its claws release poison.", "Drapion" },
                    { 319, 11, 17, "Nicknamed “the bully of the sea,” SHARPEDO is widely feared. Its cruel fangs grow back immediately if they snap off. Just one of these pokèmon can thoroughly tear apart a supertanker.", "Sharpedo" },
                    { 461, 17, 15, "They live in cold regions, forming groups of four or five that hunt prey with impressive coordination.", "Weavile" },
                    { 509, 17, null, "They steal from people for fun, but their victims can’t help but forgive them. Their deceptively cute act is perfect.", "Purrloin" },
                    { 510, 17, null, "These Pokémon vanish and appear unexpectedly. Many Trainers are drawn to their beautiful form and fur.", "Liepard" },
                    { 551, 5, 17, "They live buried in the sands of the desert. The sun-warmed sands prevent their body temperature from dropping.", "Sandile" },
                    { 552, 5, 17, "They live in groups of a few individuals. Protective membranes shield their eyes from sandstorms.", "Krokorok" },
                    { 553, 5, 17, "They never allow prey to escape. Their jaws are so powerful, they can crush the body of an automobile.", "Krookodile" },
                    { 559, 17, 2, "Its skin has a rubbery elasticity, so it can reduce damage by defensively pulling its skin up to its neck.", "Scraggy" },
                    { 560, 17, 2, "Groups of them beat up anything that enters their territory. Each can spit acidic liquid from its mouth.", "Scrafty" },
                    { 570, 17, null, "It changes into the forms of others to surprise them. Apparently, it often transforms into a silent child.", "Zorua" },
                    { 491, 17, null, "It can lull people to sleep and make them dream. It is active during nights of the new moon.", "Darkrai" },
                    { 318, 11, 17, "CARVANHA’s strongly developed jaws and its sharply pointed fangs pack the destructive power to rip out boat hulls. Many boats have been attacked and sunk by this pokèmon.", "Carvanha" },
                    { 302, 17, 8, "SABLEYE lead quiet lives deep inside caverns. They are feared, however, because these pokèmon are thought to steal the spirits of people when their eyes burn with a sinister glow in the darkness.", "Sableye" },
                    { 275, 12, 17, "SHIFTRY is a mysterious pokèmon that is said to live atop towering trees dating back over a thousand years. It creates terrific windstorms with the fans it holds.", "Shiftry" },
                    { 646, 16, 15, "It generates a powerful, freezing energy inside itself, but its body became frozen when the energy leaked out.", "Kyurem" },
                    { 691, 4, 16, "Their poison is strong enough to eat through the hull of a tanker, and they spit it indiscriminately at anything that enters their territory.", "Dragalge" },
                    { 696, 6, 16, "This Pokémon was restored from a fossil. If something happens that it doesn’t like, it throws a tantrum and runs wild.", "Tyrunt" },
                    { 697, 6, 16, "Thanks to its gargantuan jaws, which could shred thick metal plates as if they were paper, it was invincible in the ancient world it once inhabited.", "Tyrantrum" },
                    { 704, 16, null, "The weakest Dragon-Type Pokémon, it lives in damp, shady places, so its body doesn’t dry out.", "Goomy" },
                    { 705, 16, null, "It drives away opponents by excreting a sticky liquid that can dissolve anything. Its eyes devolved, so it can’t see anything. ", "Sliggoo" },
                    { 706, 16, null, "This very friendly Dragon-type Pokémon will hug its beloved trainer, leaving that trainer covered in sticky slime", "Goodra" },
                    { 714, 3, 16, "They live in pitch-black caves. Their enormous ears can emit ultrasonic waves of 200,000 hertz.", "Noibat" },
                    { 715, 3, 16, "They fly around on moonless nights and attack careless prey. Nothing can beat them in a battle in the dark.", "Noivern" },
                    { 718, 16, 5, "When the Kalos region’s ecosystem falls into disarray, it appears and reveals its secret power. ", "Zygarde" },
                    { 197, 17, null, "When agitated, this pokèmon pro­ tects itself by spraying poisonous sweat from its pores.", "Umbreon" },
                    { 198, 17, 3, "Feared and loathed by many, it is believed to bring misfortune to all those who see it at night.", "Murkrow" },
                    { 215, 17, 15, "Its paws conceal sharp claws. If attacked, it sud­ denly extends the claws and startles its enemy.", "Sneasel" },
                    { 228, 17, 10, "It uses different kinds of cries for communicating with others of its kind and for pursuing its prey.", "Houndour" },
                    { 229, 17, 10, "If you are burned by the flames it shoots from its mouth, the pain will never go away.", "Houndoom" },
                    { 248, 6, 17, "Its body can't be harmed by any sort of attack, so it is very eager to make challenges against enemies.", "Tyranitar" },
                    { 261, 17, null, "At first sight, POOCHYENA takes a bite at anything that moves. This pokèmon chases after prey until the victim becomes exhausted. However, it may turn tail if the prey strikes back.", "Poochyena" },
                    { 262, 17, null, "MIGHTYENA gives obvious signals when it is preparing to attack. It starts to growl deeply and then flattens its body. This pokèmon will bite savagely with its sharply pointed fangs.", "Mightyena" },
                    { 274, 12, 17, "NUZLEAF live in densely overgrown forests. They occasionally venture out of the forest to startle people. This pokèmon dislikes having its long nose pinched.", "Nuzleaf" },
                    { 571, 17, null, "Bonds between these Pokémon are very strong. It protects the safety of its pack by tricking its opponents.", "Zoroark" },
                    { 644, 16, 13, "Concealing itself in lightning clouds, it flies throughout the Unova region. It creates electricity in its tail.", "Zekrom" },
                    { 624, 17, 9, "Blades comprise this Pokémon’s entire body. If battling dulls the blades, it sharpens them on stones by the river.", "Pawniard" },
                    { 629, 17, 3, "Its wings are too tiny to allow it to fly. As the time approaches for it to evolve, it discards the bones it was wearing.", "Vullaby" },
                    { 281, 14, 18, "It is said that a KIRLIA that is exposed to the positive emotions of its TRAINER grows beautiful. This pokèmon controls psychokinetic powers with its highly developed brain.", "Kirlia" },
                    { 282, 14, 18, "GARDEVOIR has the ability to read the future. If it senses impending danger to its TRAINER, this pokèmon is said to unleash its psychokinetic energy at full power.", "Gardevoir" },
                    { 298, 1, 18, "AZURILL spins its tail as if it were a lasso, then hurls it far. The momentum of the throw sends its body flying, too. Using this unique action, one of these pokèmon managed to hurl itself a record 33 feet.", "Azurill" },
                    { 303, 9, 18, "MAWHILE’s huge jaws are actually steel horns that have been transformed. Its docile-looking face serves to lull its foe into letting down its guard. When the foe least expects it, MAWHILE chomps it with its gaping jaws.", "Mawile" },
                    { 439, 14, 18, "It habitually mimics foes. Once mimicked, the foe cannot take its eyes off this Pokémon.", "Mime-jr" },
                    { 468, 18, 3, "It will never appear where there is strife. Its sightings have become rare recently.", "Togekiss" },
                    { 546, 12, 18, "When attacked, it escapes by shooting cotton from its body. The cotton serves as a decoy to distract the attacker.", "Cottonee" },
                    { 547, 12, 18, "Like the wind, it can slip through any gap, no matter how small. It leaves balls of white fluff behind.", "Whimsicott" },
                    { 280, 14, 18, "RALTS senses the emotions of people using the horns on its head. This pokèmon rarely appears before people. But when it does, it draws closer if it senses that the person has a positive disposition.", "Ralts" },
                    { 669, 18, null, "It draws out and controls the hidden power of flowers. The flower Flabébé holds is most likely part of its body.", "Flabebe" },
                    { 671, 18, null, "It claims exquisite flower gardens as its territory, and it obtains power from basking in the energy emitted by flowering plants.", "Florges" },
                    { 682, 18, null, "It emits a scent that enraptures those who smell it. This fragance changes depending on what it has eaten.", "Spritzee" },
                    { 683, 18, null, "It devises various scents, pleasant and unpleasant, and emits scents that its enemies dislike in order to gain an edge in battle.", "Aromatisse" },
                    { 684, 18, null, "To entangle its opponents in battle, it extrudes white threads as sweet and sticky as cotton candy.", "Swirlix" },
                    { 685, 18, null, "It can distinguish the faintest of scents. It puts its sensitive sense of smell to use by helping pastry chefs in their work.", "Slurpuff" },
                    { 700, 18, null, "It sends a soothing aura from its ribbonlike feelers to calm fights.", "Sylveon" },
                    { 702, 13, 18, "Its whiskers serve as antennas. By sending and receiving electrical waves, it can communicate with others over vast distances.", "Dedenne" },
                    { 703, 6, 18, "Born from the temperatures and pressures deep underground, it fires beams from the stone in its head.", "Carbink" },
                    { 670, 18, null, "It flutters around fields of flowers and cares for flowers that are starting to wilt. It draws out the hidden power of flowers to battle.", "Floette" },
                    { 210, 18, null, "It is actually timid and easily spooked. If at­ tacked, it flails about to fend off its attacker.", "Granbull" },
                    { 209, 18, null, "Although it looks frightening, it is actually kind and affectionate. It is very popular among women.", "Snubbull" },
                    { 184, 11, 18, "By keeping still and listening in­ tently, it can tell what is in even wild, fast- moving rivers.", "Azumarill" },
                    { 630, 17, 3, "It makes a nest out of bones it finds. It grabs weakened prey in its talons and hauls it to its nest of bones.", "Mandibuzz" },
                    { 633, 17, 16, "It tends to bite everything, and it is not a picky eater. Approaching it carelessly is dangerous.", "Deino" },
                    { 634, 17, 16, "After it has eaten up all the food in its territory, it moves to another area. Its two heads do not get along.", "Zweilous" },
                    { 635, 17, 16, "This brutal Pokémon travels the skies on its six wings. Anything that moves seems like a foe to it, triggering its attack.", "Hydreigon" },
                    { 658, 11, 17, "It creates throwing stars out of compressed water. When it spins them and throws them at high speed, these stars can split metal in two.", "Greninja" },
                    { 675, 2, 17, "Although it posses a violent temperament, it won’t put up with bullying. It uses the leaf in its mouth to sense the movements of its enemies.", "Pangoro" },
                    { 686, 17, 14, "Opponents who stare at the flashing of the light-emitting spots on its body become dazed and lose their will to fight.", "Inkay" },
                    { 687, 17, 14, "It wields the most compelling hypnotic powers of any Pokémon, and it forces others to do whatever it wants.", "Malamar" },
                    { 717, 17, 3, "When this legendary Pokémon’s wings and tail feathers spread wide and glow red, it absorbs the life force of living creatures.", "Yveltal" },
                    { 35, 18, null, "Its magical and cute appeal has many admirers. It is rare and found only in certain areas.", "Clefairy" },
                    { 36, 18, null, "A timid fairy pokèmon that is rarely seen. It will run and hide the moment it senses people.", "Clefable" },
                    { 39, 1, 18, "When its huge eyes light up, it sings a mysteriously soothing melody that lulls its enemies to sleep.", "Jigglypuff" },
                    { 40, 1, 18, "The body is soft and rubbery. When angered, it will suck in air and inflate itself to an enormous size.", "Wigglytuff" },
                    { 122, 14, 18, "If interrupted while it is miming, it will slap around the offender with its broad hands.", "Mr-mime" },
                    { 173, 18, null, "Because of its unusual, star-like silhouette, people believe that it came here on a meteor.", "Cleffa" },
                    { 174, 1, 18, "It has a very soft body. If it starts to roll, it will bounce all over and be impossible to stop.", "Igglybuff" },
                    { 175, 18, null, "The shell seems to be filled with joy. It is said that it will share good luck when treated kindly.", "Togepi" },
                    { 176, 18, 3, "They say that it will appear before kindhearted, car­ ing people and shower them with happiness.", "Togetic" },
                    { 183, 11, 18, "The tip of its tail, which con­ tains oil that is lighter than wa­ ter, lets it swim without drowning.", "Marill" },
                    { 625, 17, 9, "It leads a group of Pawniard. It battles to become the boss, but will be driven from the group if it loses.", "Bisharp" },
                    { 370, 11, null, "LUVDISC live in shallow seas in the tropics. This heart-shaped pokèmon earned its name by swimming after loving couples it spotted in the ocean’s waves.", "Luvdisc" },
                    { 643, 16, 10, "This Pokémon appears in legends. It sends flames into the air from its tail, burning up everything around it.", "Reshiram" },
                    { 612, 16, null, "They are kind but can be relentless when defending territory. They challenge foes with tusks that can cut steel.", "Haxorus" },
                    { 574, 14, null, "Their ribbonlike feelers increase their psychic power. They are always staring at something.", "Gothita" },
                    { 575, 14, null, "They use hypnosis to control people and Pokémon. Tales of Gothorita leading people astray are told in every corner.", "Gothorita" },
                    { 576, 14, null, "Starry skies thousands of light-years away are visible in the space distorted by their intense psychic power.", "Gothitelle" },
                    { 577, 14, null, "They drive away attackers by unleashing psychic power. They can use telepathy to talk with others.", "Solosis" },
                    { 578, 14, null, "Since they have two divided brains, at times they suddenly try to take two different actions at once.", "Duosion" },
                    { 579, 14, null, "When Reuniclus shake hands, a network forms between their brains, increasing their psychic power.", "Reuniclus" },
                    { 605, 14, null, "It uses its strong psychic power to squeeze its opponent’s brain, causing unendurable headaches.", "Elgyem" },
                    { 606, 14, null, "It can manipulate an opponent’s memory. Apparently, it communicates by flashing its three different-colored fingers.", "Beheeyem" },
                    { 561, 14, 3, "They never vary the route they fly, because their memories of guarding an ancient city remain steadfast.", "Sigilyph" },
                    { 648, 1, 14, "Its melodies are sung with a special vocalization method that can control the feelings of those who hear it.", "Meloetta-aria" },
                    { 677, 14, null, "The organ that emits its intense psychic power is sheltered by its ears to keep power from leaking out.", "Espurr" },
                    { 678, 14, null, "When in danger, it raises its ears and releases enough psychic power to grind a 10-ton truck into dust.", "Meowstic-male" },
                    { 87, 11, 15, "Stores thermal energy in its body. Swims at a steady 8 knots even in intensely cold waters.", "Dewgong" },
                    { 91, 11, 15, "When attacked, it launches its horns in quick volleys. Its innards have never been seen.", "Cloyster" },
                    { 124, 15, 14, "It seductively wiggles its hips as it walks. It can cause people to dance in unison with it.", "Jynx" },
                    { 131, 11, 15, "A pokèmon that has been over­ hunted almost to extinction. It can ferry people across the water.", "Lapras" },
                    { 144, 15, 3, "A legendary bird pokèmon that is said to appear to doomed people who are lost in icy mountains.", "Articuno" },
                    { 220, 15, 5, "It rubs its snout on the ground to find and dig up food. It sometimes discovers hot springs.", "Swinub" },
                    { 655, 10, 14, "It gazes into the flame at the tip of its branch to achieve a focused state, which allows it to see into the future.", "Delphox" },
                    { 528, 14, 3, "It emits sound waves of various frequencies from its nose, including some powerful enough to destroy rocks.", "Swoobat" },
                    { 527, 14, 3, "Its habitat is dark forests and caves. It emits ultrasonic waves from its nose to learn about its surroundings.", "Woobat" },
                    { 518, 14, null, "The mist emanating from their foreheads is packed with the dreams of people and Pokémon.", "Musharna" },
                    { 343, 5, 14, "BALTOY moves while spinning around on its one foot. Primitive wall paintings depicting this pokèmon living among people were discovered in some ancient ruins.", "Baltoy" },
                    { 344, 5, 14, "CLAYDOL are said to be dolls of mud made by primitive humans and brought to life by exposure to a mysterious ray. This pokèmon moves about while levitating.", "Claydol" },
                    { 358, 14, null, "CHIMECHO makes its cries echo inside its hollow body. When this pokèmon becomes enraged, its cries result in ultrasonic waves that have the power to knock foes flying.", "Chimecho" },
                    { 360, 14, null, "WYNAUT can always be seen with a big, happy smile on its face. Look at its tail to determine if it is angry. When angered, this pokèmon will be slapping the ground with its tail.", "Wynaut" },
                    { 374, 9, 14, "Instead of blood, a powerful magnetic force courses throughout BELDUM’s body. This pokèmon communicates with others by sending controlled pulses of magnetism.", "Beldum" },
                    { 375, 9, 14, "When two BELDUM fuse together, METANG is formed. The brains of the BELDUM are joined by a magnetic nervous system. By linking its brains magnetically, this pokèmon generates strong psychokinetic power.", "Metang" },
                    { 376, 9, 14, "METAGROSS has four brains in total. Combined, the four brains can breeze through difficult calculations faster than a supercomputer. This pokèmon can float in the air by tucking in its four legs.", "Metagross" },
                    { 385, 9, 14, "A legend states that JIRACHI will make true any wish that is written on notes attached to its head when it awakens. If this pokèmon senses danger, it will fight without awakening.", "Jirachi" },
                    { 386, 14, null, "The DNA of a space virus underwent a sudden mutation upon exposure to a laser beam and resulted in DEOXYS. The crystalline organ on this pokèmon’s chest appears to be its brain.", "Deoxys-normal" },
                    { 433, 14, null, "It emits cries by agitating an orb at the back of its throat. It moves with flouncing hops.", "Chingling" },
                    { 436, 9, 14, "Implements shaped like it were discovered in ancient tombs. It is unknown if they are related.", "Bronzor" },
                    { 437, 9, 14, "One caused a news sensation when it was dug up at a construction site after a 2,000-year sleep.", "Bronzong" },
                    { 475, 14, 2, "A master of courtesy and swordsmanship, it fights using extending swords on its elbows.", "Gallade" },
                    { 480, 14, null, "Known as “The Being of Knowledge.” It is said that it can wipe out the memory of those who see its eyes.", "Uxie" },
                    { 481, 14, null, "Known as “The Being of Emotion.” It taught humans the nobility of sorrow, pain, and joy.", "Mesprit" },
                    { 482, 14, null, "Known as “The Being of Willpower.” It sleeps at the bottom of a lake to keep the world in balance.", "Azelf" },
                    { 488, 14, null, "Shiny particles are released from its wings like a veil. It is said to represent the crescent moon.", "Cresselia" },
                    { 494, 14, 10, "This Pokémon brings victory. It is said that Trainers with Victini always win, regardless of the type of encounter.", "Victini" },
                    { 517, 14, null, "Munna always float in the air. People whose dreams are eaten by them forget what the dreams had been about.", "Munna" },
                    { 221, 15, 5, "Because the long hair all over its body obscures its sight, it just keeps charging repeatedly.", "Piloswine" },
                    { 621, 16, null, "It warms its body by absorbing sunlight with its wings. When its body temperature falls, it can no longer move.", "Druddigon" },
                    { 225, 15, 3, "It carries food all day long. There are tales about lost people who were saved by the food it had.", "Delibird" },
                    { 361, 15, null, "SNORUNT live in regions with heavy snowfall. In seasons without snow, such as spring and summer, this pokèmon steals away to live quietly among stalactites and stalagmites deep in caverns.", "Snorunt" },
                    { 230, 11, 16, "It is said that it usually hides in underwater caves. It can create whirlpools by yawning.", "Kingdra" },
                    { 329, 5, 16, "To make prey faint, VIBRAVA generates ultrasonic waves by vigorously making its two wings vibrate. This pokèmon’s ultrasonic waves are so powerful, they can bring on headaches in people.", "Vibrava" },
                    { 330, 5, 16, "FLYGON is nicknamed “the elemental spirit of the desert.” Because its flapping wings whip up a cloud of sand, this pokèmon is always enveloped in a sandstorm while flying.", "Flygon" },
                    { 334, 16, 3, "ALTARIA dances and wheels through the sky among billowing, cotton-like clouds. By singing melodies in its crystal-clear voice, this pokèmon makes its listeners experience dreamy wonderment.", "Altaria" },
                    { 371, 16, null, "BAGON has a dream of one day soaring in the sky. In doomed efforts to fly, this pokèmon hurls itself off cliffs. As a result of its dives, its head has grown tough and as hard as tempered steel.", "Bagon" },
                    { 372, 16, null, "Inside SHELGON’s armor-like shell, cells are in the midst of transformation to create an entirely new body. This pokèmon’s shell is extremely heavy, making its movements sluggish.", "Shelgon" },
                    { 373, 16, 3, "SALAMENCE came about as a result of a strong, long-held dream of growing wings. It is said that this powerful desire triggered a sudden mutation in this pokèmon’s cells, causing it to sprout its magnificent wings.", "Salamence" },
                    { 380, 16, 14, "LATIAS is highly sensitive to the emotions of people. If it senses any hostility, this pokèmon ruffles the feathers all over its body and cries shrilly to intimidate the foe.", "Latias" },
                    { 149, 16, 3, "An extremely rarely seen marine pokèmon. Its intelligence is said to match that of humans.", "Dragonite" },
                    { 381, 16, 14, "LATIOS has the ability to make its foe see an image of what it has seen or imagines in its head. This pokèmon is intelligent and understands human speech.", "Latios" },
                    { 443, 16, 5, "It nests in small, horizontal holes in cave walls. It pounces to catch prey that stray too close.", "Gible" },
                    { 444, 16, 5, "There is a long-held belief that medicine made from its scales will heal even incurable illnesses.", "Gabite" },
                    { 445, 16, 5, "When it folds up its body and extends its wings, it looks like a jet plane. It flies at sonic speed.", "Garchomp" },
                    { 483, 9, 16, "It has the power to control time. It appears in Sinnoh-region myths as an ancient deity.", "Dialga" },
                    { 484, 11, 16, "It has the ability to distort space. It is described as a deity in Sinnoh-region mythology.", "Palkia" },
                    { 487, 8, 16, "A Pokémon that is said to live in a world on the reverse side of ours. It appears in an ancient cemetery.", "Giratina-altered" },
                    { 610, 16, null, "They use their tusks to crush the berries they eat. Repeated regrowth makes their tusks strong and sharp.", "Axew" },
                    { 611, 16, null, "Since a broken tusk will not grow back, they diligently sharpen their tusks on river rocks after they’ve been fighting.", "Fraxure" },
                    { 384, 16, 3, "RAYQUAZA lived for hundreds of millions of years in the earth’s ozone layer, never descending to the ground. This pokèmon appears to feed on water and particles in the atmosphere.", "Rayquaza" },
                    { 148, 16, null, "A mystical pokèmon that exudes a gentle aura. Has the ability to change climate conditions.", "Dragonair" },
                    { 147, 16, null, "Long considered a mythical pokèmon until recently when a small colony was found living underwater.", "Dratini" },
                    { 713, 15, null, "Its ice-covered body is as hard as steel. Its cumbersome frame crushes anything that stands in its way.", "Avalugg" },
                    { 362, 15, null, "GLALIE has a body made of rock, which it hardens with an armor of ice. This pokèmon has the ability to freeze moisture in the atmosphere into any shape it desires.", "Glalie" },
                    { 363, 15, 11, "SPHEAL is much faster rolling than walking to get around. When groups of this pokèmon eat, they all clap at once to show their pleasure. Because of this, their mealtimes are noisy.", "Spheal" },
                    { 364, 15, 11, "SEALEO has the habit of always juggling on the tip of its nose anything it sees for the first time. This pokèmon occasionally entertains itself by balancing and rolling a SPHEAL on its nose.", "Sealeo" },
                    { 365, 15, 11, "WALREIN’s two massively developed tusks can totally shatter blocks of ice weighing ten tons with one blow. This pokèmon’s thick coat of blubber insulates it from subzero temperatures.", "Walrein" },
                    { 378, 15, null, "REGICE’s body was made during an ice age. The deep-frozen body can’t be melted, even by fire. This pokèmon controls frigid air of minus 328 degrees F.", "Regice" },
                    { 459, 12, 15, "It lives on snowy mountains. Having had little contact with humans, it is boldly inquisitive.", "Snover" },
                    { 460, 12, 15, "It whips up blizzards in mountains that are always buried in snow. It is the abominable snowman.", "Abomasnow" },
                    { 471, 15, null, "As a protective technique, it can completely freeze its fur to make its hairs stand like needles.", "Glaceon" },
                    { 473, 15, 5, "Its impressive tusks are made of ice. The population thinned when it turned warm after the ice age.", "Mamoswine" },
                    { 478, 15, 8, "It freezes foes with an icy breath nearly -60 degrees F. What seems to be its body is actually hollow.", "Froslass" },
                    { 582, 15, null, "The temperature of their breath is -58° F. They create snow crystals and make snow fall in the areas around them.", "Vanillite" },
                    { 583, 15, null, "Snowy mountains are this Pokémon’s habitat. During an ancient ice age, they moved to southern areas.", "Vanillish" },
                    { 584, 15, null, "Swallowing large amounts of water, they make snow clouds inside their bodies and attack their foes with violent blizzards.", "Vanilluxe" },
                    { 613, 15, null, "When it is not feeling well, its mucus gets watery and the power of its Ice-type moves decreases.", "Cubchoo" },
                    { 614, 15, null, "It can make its breath freeze at will. Very able in the water, it swims around in northern seas and catches prey.", "Beartic" },
                    { 615, 15, null, "When its body temperature goes up, it turns into steam and vanishes. When its temperature lowers, it returns to ice.", "Cryogonal" },
                    { 698, 6, 15, "This ancient Pokémon was restored from part of its body that had been frozen in ice for over 100 million years.", "Amaura" },
                    { 699, 6, 15, "The diamond-shaped crystals on its body expel air as cold as -240 degrees Fahrenheit, surrounding its enemies and encasing them in ice.", "Aurorus" },
                    { 712, 15, null, "It blocks opponents’ attacks with the ice that shields its body. it uses cold air to repair any cracks with new ice.", "Bergmite" },
                    { 238, 15, 14, "Its lips are the most sensitive parts on its body. It always uses its lips first to examine things.", "Smoochum" },
                    { 369, 11, 6, "RELICANTH is a pokèmon species that existed for a hundred million years without ever changing its form. This ancient pokèmon feeds on microscopic organisms with its toothless mouth.", "Relicanth" },
                    { 368, 11, null, "GOREBYSS lives in the southern seas at extreme depths. Its body is built to withstand the enormous pressure of water at incredible depths. Because of this, this pokèmon’s body is unharmed by ordinary attacks.", "Gorebyss" },
                    { 367, 11, null, "HUNTAIL’s presence went unnoticed by people for a long time because it lives at extreme depths in the sea. This pokèmon’s eyes can see clearly even in the murky dark depths of the ocean.", "Huntail" },
                    { 89, 4, null, "Thickly covered with a filthy, vile sludge. It is so toxic, even its footprints contain poison.", "Muk" },
                    { 109, 4, null, "Because it stores several kinds of toxic gases in its body, it is prone to exploding without warning.", "Koffing" },
                    { 110, 4, null, "Where two kinds of poison gases meet, 2 KOFFINGs can fuse into a WEEZING over many years.", "Weezing" },
                    { 169, 4, 3, "It flies so si­ lently through the dark on its four wings that it may not be noticed even when nearby.", "Crobat" },
                    { 316, 4, null, "Virtually all of GULPIN’s body is its stomach. As a result, it can swallow something its own size. This pokèmon’s stomach contains a special fluid that digests anything.", "Gulpin" },
                    { 317, 4, null, "When SWALOT spots prey, it spurts out a hideously toxic fluid from its pores and sprays the target. Once the prey has weakened, this pokèmon gulps it down whole with its cavernous mouth.", "Swalot" },
                    { 336, 4, null, "SEVIPER shares a generations-long feud with ZANGOOSE. The scars on its body are evidence of vicious battles. This pokèmon attacks using its sword- edged tail.", "Seviper" },
                    { 453, 4, 2, "Its cheeks hold poison sacs. It tries to catch foes off guard to jab them with toxic fingers.", "Croagunk" },
                    { 88, 4, null, "Appears in filthy areas. Thrives by sucking up polluted sludge that is pumped out of factories.", "Grimer" },
                    { 454, 4, 2, "Its knuckle claws secrete a toxin so vile that even a scratch could prove fatal.", "Toxicroak" },
                    { 569, 4, null, "It clenches opponents with its left arm and finishes them off with foul-smelling poison gas belched from its mouth.", "Garbodor" },
                    { 27, 5, null, "Burrows deep underground in arid locations far from water. It only emerges to hunt for food.", "Sandshrew" },
                    { 28, 5, null, "Curls up into a spiny ball when threatened. It can roll while curled up to attack or escape.", "Sandslash" },
                    { 31, 4, 5, "Its hard scales provide strong protection. It uses its hefty bulk to execute powerful moves.", "Nidoqueen" },
                    { 34, 4, 5, "It uses its powerful tail in battle to smash, constrict, then break the prey's bones.", "Nidoking" },
                    { 50, 5, null, "Lives about one yard underground where it feeds on plant roots. It sometimes appears above ground.", "Diglett" },
                    { 51, 5, null, "A team of DIGLETT triplets. It triggers huge earthquakes by burrowing 60 miles underground.", "Dugtrio" },
                    { 104, 5, null, "Because it never removes its skull helmet, no one has ever seen this pokèmon's real face.", "Cubone" },
                    { 568, 4, null, "Inhaling the gas they belch will make you sleep for a week. They prefer unsanitary places.", "Trubbish" },
                    { 42, 4, 3, "Once it strikes, it will not stop draining energy from the victim even if it gets too heavy to fly.", "Golbat" },
                    { 41, 4, 3, "Forms colonies in perpetually dark places. Uses ultrasonic waves to identify and approach targets.", "Zubat" },
                    { 33, 4, null, "An aggressive pokèmon that is quick to attack. The horn on its head secretes a powerful venom.", "Nidorino" },
                    { 277, 1, 3, "SWELLOW flies high above our heads, making graceful arcs in the sky. This pokèmon dives at a steep angle as soon as it spots its prey. The hapless prey is tightly grasped by SWELLOW’s clawed feet, preventing escape.", "Swellow" },
                    { 333, 1, 3, "SWABLU has light and fluffy wings that are like cottony clouds. This pokèmon is not frightened of people. It lands on the heads of people and sits there like a cotton-fluff hat.", "Swablu" },
                    { 396, 1, 3, "They flock in great numbers. Though small, they flap their wings with great power.", "Starly" },
                    { 397, 1, 3, "It flies around forests and fields in search of bug Pokémon. It stays within a huge flock.", "Staravia" },
                    { 398, 1, 3, "It has a savage nature. It will courageously challenge foes that are much larger.", "Staraptor" },
                    { 441, 1, 3, "It can learn and speak human words. If they gather, they all learn the same saying.", "Chatot" },
                    { 519, 1, 3, "Each follows its Trainer’s orders as best it can, but they sometimes fail to understand complicated commands.", "Pidove" },
                    { 520, 1, 3, "It can return to its Trainer’s location regardless of the distance separating them.", "Tranquill" },
                    { 521, 1, 3, "Males swing their head plumage to threaten opponents. The females’ flying abilities surpass those of the males.", "Unfezant" },
                    { 627, 1, 3, "They crush berries with their talons. They bravely stand up to any opponent, no matter how strong it is.", "Rufflet" },
                    { 628, 1, 3, "They fight for their friends without any thought about danger to themselves. One can carry a car while flying.", "Braviary" },
                    { 641, 3, null, "The lower half of its body is wrapped in a cloud of energy. It zooms through the sky at 200 mph.", "Tornadus-incarnate" },
                    { 661, 1, 3, "These friendly Pokémon send signals to one another with beautiful chirps and tail-feather movements.", "Fletchling" },
                    { 701, 2, 3, "Although its body is small, its proficient fighting skills enable it to keep up with big bruisers like Machamp and Hariyama.", "Hawlucha" },
                    { 23, 4, null, "Moves silently and stealthily. Eats the eggs of birds, such as PIDGEY and SPEAROW, whole.", "Ekans" },
                    { 24, 4, null, "It is rumored that the ferocious warning markings on its belly differ from area to area.", "Arbok" },
                    { 29, 4, null, "Although small, its venomous barbs render this pokèmon dangerous. The female has smaller horns.", "Nidoran-f" },
                    { 30, 4, null, "The female's horn develops slowly. Prefers physical attacks such as clawing and biting.", "Nidorina" },
                    { 32, 4, null, "Stiffens its ears to sense danger. The larger its horns, the more powerful its secreted venom.", "Nidoran-m" },
                    { 105, 5, null, "The bone it holds is its key weapon. It throws the bone skillfully like a boomerang to KO targets.", "Marowak" },
                    { 276, 1, 3, "TAILLOW courageously stands its ground against foes, however strong they may be. This gutsy pokèmon will remain defiant even after a loss. On the other hand, it cries loudly if it becomes hungry.", "Taillow" },
                    { 207, 5, 3, "It flies straight at its target's face then clamps down on the star­ tled victim to inject poison.", "Gligar" },
                    { 232, 5, null, "It has sharp, hard tusks and a rugged hide. Its TACKLE is strong enough to knock down a house.", "Donphan" },
                    { 464, 5, 6, "It puts rocks in holes in its palms and uses its muscles to shoot them. GEODUDE are shot at rare times.", "Rhyperior" },
                    { 524, 6, null, "Its ear is hexagonal in shape. Compressed underground, its body is as hard as steel.", "Roggenrola" },
                    { 525, 6, null, "When it overflows with power, the orange crystal on its body glows. It looks for underground water in caves.", "Boldore" },
                    { 526, 6, null, "Compressing the energy from its internal core lets it fire off an attack capable of blowing away a mountain.", "Gigalith" },
                    { 566, 6, 3, "Said to be an ancestor of bird Pokémon, they were unable to fly and moved about by hopping from one branch to another.", "Archen" },
                    { 567, 6, 3, "They are intelligent and will cooperate to catch prey. From the ground, they use a running start to take flight.", "Archeops" },
                    { 639, 6, 2, "This Pokémon came to the defense of Pokémon that had lost their homes in a war among humans.", "Terrakion" },
                    { 10, 7, null, "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", "Caterpie" },
                    { 438, 6, null, "It looks as if it is always crying. It is actually adjusting its body’s fluid levels by eliminating excess.", "Bonsly" },
                    { 11, 7, null, "This pokèmon is vulnerable to attack while its shell is soft, exposing its weak and tender body.", "Metapod" },
                    { 13, 7, 4, "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", "Weedle" },
                    { 14, 7, 4, "Almost incapable of moving, this pokèmon can only harden its shell to protect itself from predators.", "Kakuna" },
                    { 15, 7, 4, "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", "Beedrill" },
                    { 48, 7, 4, "Lives in the shadows of tall trees where it eats insects. It is attracted by light at night.", "Venonat" }
                });

            migrationBuilder.InsertData(
                table: "PokemonSpecies",
                columns: new[] { "SpeciesID", "PrimaryTypeID", "SecondaryTypeID", "SpeciesDescription", "SpeciesName" },
                values: new object[,]
                {
                    { 49, 7, 4, "The dust-like scales covering its wings are color coded to indicate the kinds of poison it has.", "Venomoth" },
                    { 123, 7, 3, "With ninja-like agility and speed, it can create the illusion that there is more than one.", "Scyther" },
                    { 127, 7, null, "If it fails to crush the victim in its pincers, it will swing it around and toss it hard.", "Pinsir" },
                    { 165, 7, 3, "It is very timid. It will be afraid to move if it is alone. But it will be active if it is in a group.", "Ledyba" },
                    { 12, 7, 3, "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", "Butterfree" },
                    { 409, 6, null, "Its powerful head butt has enough power to shatter even the most durable things upon impact.", "Rampardos" },
                    { 408, 6, null, "It lived in jungles around 100 million years ago. Its skull is as hard as iron.", "Cranidos" },
                    { 377, 6, null, "REGIROCK was sealed away by people long ago. If this pokèmon’s body is damaged in battle, it is said to seek out suitable rocks on its own to repair itself.", "Regirock" },
                    { 328, 5, null, "TRAPINCH’s nest is a sloped, bowl-like pit dug in sand. This pokèmon patiently waits for prey to tumble down the pit. Its giant jaws have enough strength to crush even boulders.", "Trapinch" },
                    { 383, 5, null, "GROUDON has long been described in mythology as the pokèmon that raised lands and expanded continents. This pokèmon took to sleep after a cataclysmic battle with KYOGRE.", "Groudon" },
                    { 449, 5, null, "It lives in arid places. Instead of perspiration, it expels grainy sand from its body.", "Hippopotas" },
                    { 450, 5, null, "It blasts internally stored sand from ports on its body to create a towering twister for attack.", "Hippowdon" },
                    { 472, 5, 3, "It observes prey while hanging inverted from branches. When the chance presents itself, it swoops!", "Gliscor" },
                    { 529, 5, null, "It can dig through the ground at a speed of 30 mph. It could give a car running aboveground a good race.", "Drilbur" },
                    { 645, 5, 3, "Lands visited by Landorus grant such bountiful crops that it has been hailed as “The Guardian of the Fields.”", "Landorus-incarnate" },
                    { 660, 1, 5, "With their powerful ears, they can heft boulders of a ton or more with ease. They can be a big help at construction sites.", "Diggersby" },
                    { 74, 6, 5, "Found in fields and mountains. Mistaking them for boulders, people often step or trip on them.", "Geodude" },
                    { 75, 6, 5, "Rolls down slopes to move. It rolls over any obstacle without slowing or changing its direction.", "Graveler" },
                    { 76, 6, 5, "Its boulder-like body is extremely hard. It can easily withstand dynamite blasts without damage.", "Golem" },
                    { 95, 6, 5, "As it grows, the stone portions of its body harden to become similar to a diamond, but colored black.", "Onix" },
                    { 111, 5, 6, "Its massive bones are 1000 times harder than human bones. It can easily knock a trailer flying.", "Rhyhorn" },
                    { 112, 5, 6, "Protected by an armor-like hide, it is capable of living in molten lava of 3,600 degrees.", "Rhydon" },
                    { 142, 6, 3, "A ferocious, pre­ historic pokèmon that goes for the enemy's throat with its serrated saw-like fangs.", "Aerodactyl" },
                    { 185, 6, null, "Although it always pretends to be a tree, its composi­ tion appears to be closer to a rock than a plant.", "Sudowoodo" },
                    { 246, 6, 5, "It feeds on soil. After it has eaten a large mountain, it will fall asleep so it can grow.", "Larvitar" },
                    { 247, 6, 5, "Its shell is as hard as sheet rock, and it is also very strong. Its THRASHING can topple a mountain.", "Pupitar" },
                    { 299, 6, null, "NOSEPASS’s magnetic nose is always pointed to the north. If two of these pokèmon meet, they cannot turn their faces to each other when they are close because their magnetic noses repel one another.", "Nosepass" },
                    { 231, 5, null, "It swings its long snout around play­ fully, but because it is so strong, that can be dan­ gerous.", "Phanpy" },
                    { 166, 7, 3, "When the stars flicker in the night sky, it flutters about, scattering a glowing powder.", "Ledian" },
                    { 164, 1, 3, "Its eyes are specially adapted. They concentrate even faint light and enable it to see in the dark.", "Noctowl" },
                    { 85, 1, 3, "Uses its three brains to execute complex plans. While two heads sleep, one head stays awake.", "Dodrio" },
                    { 264, 1, null, "LINOONE always runs full speed and only in straight lines. If facing an obstacle, it makes a right-angle turn to evade it. This pokèmon is very challenged by gently curving roads.", "Linoone" },
                    { 287, 1, null, "SLAKOTH lolls around for over twenty hours every day. Because it moves so little, it does not need much food. This pokèmon’s sole daily meal consists of just three leaves.", "Slakoth" },
                    { 288, 1, null, "VIGOROTH is always itching and agitated to go on a wild rampage. It simply can’t tolerate sitting still for even a minute. This pokèmon’s stress level rises if it can’t be moving constantly.", "Vigoroth" },
                    { 289, 1, null, "SLAKING spends all day lying down and lolling about. It eats grass growing within its reach. If it eats all the grass it can reach, this pokèmon reluctantly moves to another spot.", "Slaking" },
                    { 293, 1, null, "Normally, WHISMUR’s voice is very quiet - it is barely audible even if one is paying close attention. However, if this pokèmon senses danger, it starts crying at an earsplitting volume.", "Whismur" },
                    { 294, 1, null, "LOUDRED’s bellowing can completely decimate a wood-frame house. It uses its voice to punish its foes. This pokèmon’s round ears serve as loudspeakers.", "Loudred" },
                    { 295, 1, null, "EXPLOUD triggers earthquakes with the tremors it creates by bellowing. If this pokèmon violently inhales from the ports on its body, it’s a sign that it is preparing to let loose a huge bellow.", "Exploud" },
                    { 300, 1, null, "SKITTY has the habit of becoming fascinated by moving objects and chasing them around. This pokèmon is known to chase after its own tail and become dizzy.", "Skitty" },
                    { 263, 1, null, "ZIGZAGOON restlessly wanders everywhere at all times. This pokèmon does so because it is very curious. It becomes interested in anything that it happens to see.", "Zigzagoon" },
                    { 301, 1, null, "DELCATTY prefers to live an unfettered existence in which it can do as it pleases at its own pace. Because this pokèmon eats and sleeps whenever it decides, its daily routines are completely random.", "Delcatty" },
                    { 335, 1, null, "Memories of battling its arch-rival SEVIPER are etched into every cell of ZANGOOSE’s body. This pokèmon adroitly dodges attacks with incredible agility.", "Zangoose" },
                    { 351, 1, null, "CASTFORM’s appearance changes with the weather. This pokèmon gained the ability to use the vast power of nature to protect its tiny body.", "Castform" },
                    { 352, 1, null, "KECLEON is capable of changing its body colors at will to blend in with its surroundings. There is one exception - this pokèmon can’t change the zigzag pattern on its belly.", "Kecleon" },
                    { 399, 1, null, "With nerves of steel, nothing can perturb it. It is more agile and active than it appears.", "Bidoof" },
                    { 424, 1, null, "To eat, it deftly shucks nuts with its two tails. It rarely uses its arms now.", "Ambipom" },
                    { 427, 1, null, "It slams foes by sharply uncoiling its rolled ears. It stings enough to make a grown-up cry in pain.", "Buneary" },
                    { 428, 1, null, "An extremely cautious Pokémon. It cloaks its body with its fluffy ear fur when it senses danger.", "Lopunny" },
                    { 431, 1, null, "It claws if displeased and purrs when affectionate. Its fickleness is very popular among some.", "Glameow" },
                    { 327, 1, null, "All the SPINDA that exist in the world are said to have utterly unique spot patterns. The shaky, tottering steps of this pokèmon give it the appearance of dancing.", "Spinda" },
                    { 242, 1, null, "Anyone who takes even one bite of BLISSEY's egg be­ comes unfailingly caring and pleas­ ant to everyone.", "Blissey" },
                    { 241, 1, null, "Its milk is packed with nutrition, making it the ultimate beverage for the sick or weary.", "Miltank" },
                    { 235, 1, null, "A special fluid oozes from the tip of its tail. It paints the fluid everywhere to mark its territory.", "Smeargle" },
                    { 20, 1, null, "It uses its whis­ kers to maintain its balance. It apparently slows down if they are cut off.", "Raticate" },
                    { 52, 1, null, "Adores circular objects. Wanders the streets on a nightly basis to look for dropped loose change.", "Meowth" },
                    { 53, 1, null, "Although its fur has many admirers, it is tough to raise as a pet because of its fickle meanness.", "Persian" },
                    { 108, 1, null, "Its tongue can be extended like a chameleon's. It leaves a tingling sensation when it licks enemies.", "Lickitung" },
                    { 113, 1, null, "A rare and elusive pokèmon that is said to bring happiness to those who manage to get it.", "Chansey" },
                    { 115, 1, null, "The infant rarely ventures out of its mother's protective pouch until it is 3 years old.", "Kangaskhan" },
                    { 128, 1, null, "When it targets an enemy, it charges furiously while whipping its body with its long tails.", "Tauros" },
                    { 132, 1, null, "Capable of copying an enemy's genetic code to instantly transform itself into a duplicate of the enemy.", "Ditto" },
                    { 133, 1, null, "Its genetic code is irregular. It may mutate if it is exposed to radiation from element STONEs.", "Eevee" },
                    { 137, 1, null, "A pokèmon that consists entirely of programming code. Capable of moving freely in cyberspace.", "Porygon" },
                    { 143, 1, null, "Very lazy. Just eats and sleeps. As its rotund bulk builds, it becomes steadily more slothful.", "Snorlax" },
                    { 161, 1, null, "A very cautious pokèmon, it raises itself up using its tail to get a better view of its surroundings.", "Sentret" },
                    { 162, 1, null, "It makes a nest to suit its long and skinny body. The nest is impossible for other pokèmon to enter.", "Furret" },
                    { 190, 1, null, "Its tail is so powerful that it can use it to grab a tree branch and hold itself up in the air.", "Aipom" },
                    { 206, 1, null, "When spotted, this pokèmon escapes backward by furi­ ously boring into the ground with its tail.", "Dunsparce" },
                    { 216, 1, null, "If it finds honey, its crescent mark glows. It always licks its paws because they are soaked with honey.", "Teddiursa" },
                    { 217, 1, null, "Although it is a good climber, it prefers to snap trees with its forelegs and eat fallen BERRIES.", "Ursaring" },
                    { 233, 1, null, "This upgraded version of PORYGON is designed for space exploration. It can't fly, though.", "Porygon2" },
                    { 234, 1, null, "The curved antlers subtly change the flow of air to create a strange space where real­ ity is distorted.", "Stantler" },
                    { 432, 1, null, "It is a brazen brute that barges its way into another Pokémon’s nest and claims it as its own.", "Purugly" },
                    { 163, 1, 3, "It always stands on one foot. It changes feet so fast, the movement can rarely be seen.", "Hoothoot" },
                    { 440, 1, null, "It loves round white things. It carries an egg-shaped rock in imitation of CHANSEY.", "Happiny" },
                    { 463, 1, null, "It wraps things with its extensible tongue. Getting too close to it will leave you soaked with drool.", "Lickilicky" },
                    { 296, 2, null, "MAKUHITA is tenacious - it will keep getting up and attacking its foe however many times it is knocked down. Every time it gets back up, this pokèmon stores more energy in its body for evolving.", "Makuhita" },
                    { 297, 2, null, "HARIYAMA practices its straight-arm slaps in any number of locations. One hit of this pokèmon’s powerful, openhanded, straight-arm punches could snap a telephone pole in two.", "Hariyama" },
                    { 447, 2, null, "The aura that emanates from its body intensifies to alert others if it is afraid or sad.", "Riolu" },
                    { 532, 2, null, "It fights by swinging a piece of lumber around. It is close to evolving when it can handle the lumber without difficulty.", "Timburr" },
                    { 533, 2, null, "This Pokémon is so muscular and strongly built that even a group of wrestlers could not make it budge an inch.", "Gurdurr" },
                    { 534, 2, null, "It is thought that Conkeldurr taught humans how to make concrete more than 2,000 years ago.", "Conkeldurr" },
                    { 538, 2, null, "When it tightens its belt, it becomes stronger. Wild Throh use vines to weave their own belts.", "Throh" },
                    { 539, 2, null, "The sound of Sawk punching boulders and trees can be heard all the way from the mountains where they train.", "Sawk" },
                    { 237, 2, null, "If you become enchanted by its smooth, elegant, dance-like kicks, you may get drilled hard.", "Hitmontop" },
                    { 619, 2, null, "In fights, they dominate with onslaughts of flowing, continuous attacks. With their sharp claws, they cut enemies.", "Mienfoo" },
                    { 674, 2, null, "It does its best to be taken seriously by its enemies, but its glare is not sufficiently intimidating. Chewing on a leaf is its trademark.", "Pancham" },
                    { 16, 1, 3, "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.", "Pidgey" },
                    { 17, 1, 3, "Very protective of its sprawling territorial area, this pokèmon will fiercely peck at any intruder.", "Pidgeotto" },
                    { 18, 1, 3, "When hunting, it skims the surface of water at high speed to pick off unwary prey such as MAGIKARP.", "Pidgeot" },
                    { 21, 1, 3, "Eats bugs in grassy areas. It has to flap its short wings at high speed to stay airborne.", "Spearow" },
                    { 22, 1, 3, "With its huge and magnificent wings, it can keep aloft without ever having to land for rest.", "Fearow" },
                    { 83, 1, 3, "The sprig of green onions it holds is its weapon. It is used much like a metal sword.", "Farfetchd" },
                    { 84, 1, 3, "A bird that makes up for its poor flying with its fast foot speed. Leaves giant footprints.", "Doduo" },
                    { 620, 2, null, "It wields the fur on its arms like a whip. Its arm attacks come with such rapidity that they cannot even be seen.", "Mienshao" },
                    { 236, 2, null, "It is always bursting with en­ ergy. To make it­ self stronger, it keeps on fighting even if it loses.", "Tyrogue" },
                    { 107, 2, null, "While apparently doing nothing, it fires punches in lightning fast volleys that are impossible to see.", "Hitmonchan" },
                    { 106, 2, null, "When in a hurry, its legs lengthen progressively. It runs smoothly with extra long, loping strides.", "Hitmonlee" },
                    { 474, 1, null, "Additional software was installed to make it a better Pokémon. It began acting oddly, however.", "Porygon-z" },
                    { 486, 1, null, "There is an enduring legend that states this Pokémon towed continents with ropes.", "Regigigas" },
                    { 493, 1, null, "It is described in mythology as the Pokémon that shaped the universe with its 1,000 arms.", "Arceus" },
                    { 504, 1, null, "Using food stored in cheek pouches, they can keep watch for days. They use their tails to communicate with others.", "Patrat" },
                    { 505, 1, null, "When they see an enemy, their tails stand high, and they spit the seeds of berries stored in their cheek pouches.", "Watchog" },
                    { 506, 1, null, "It faces strong opponents with great courage. But, when at a disadvantage in a fight, this intelligent Pokémon flees.", "Lillipup" },
                    { 507, 1, null, "It has black, cape-like fur that is very hard and decreases the amount of damage it receives.", "Herdier" },
                    { 508, 1, null, "It rescues people stranded by blizzards in the mountains. Its shaggy fur shields it from the cold.", "Stoutland" },
                    { 531, 1, null, "It touches others with the feelers on its ears, using the sound of their heartbeats to tell how they are feeling.", "Audino" },
                    { 572, 1, null, "They greet one another by rubbing each other with their tails, which are always kept well groomed and clean.", "Minccino" },
                    { 573, 1, null, "Their white fur is coated in a special oil that makes it easy for them to deflect attacks.", "Cinccino" },
                    { 626, 1, null, "Their fluffy fur absorbs damage, even if they strike foes with a fierce headbutt.", "Bouffalant" },
                    { 659, 1, null, "They use their large ears to dig burrows. They will dig the whole night through.", "Bunnelby" },
                    { 676, 1, null, "Trimming its fluffy fur not only makes it more elegant but also increases the swiftness of its movements.", "Furfrou" },
                    { 56, 2, null, "Extremely quick to anger. It could be docile one moment then thrashing away the next instant.", "Mankey" },
                    { 57, 2, null, "Always furious and tenacious to boot. It will not abandon chasing its quarry until it is caught.", "Primeape" },
                    { 66, 2, null, "Loves to build its muscles. It trains in all styles of martial arts to become even stronger.", "Machop" },
                    { 67, 2, null, "Its muscular body is so powerful, it must wear a power save belt to be able to regulate its motions.", "Machoke" },
                    { 68, 2, null, "Using its heavy muscles, it throws powerful punches that can send the victim clear over the horizon.", "Machamp" },
                    { 446, 1, null, "It wolfs down its weight in food once a day, swallowing food whole with almost no chewing.", "Munchlax" },
                    { 707, 9, 18, "These key collectors threaten any attackers by fiercely jingling their keys at them.", "Klefki" },
                    { 167, 7, 4, "It lies still in the same pose for days in its web, waiting for its unsuspecting prey to wander close.", "Spinarak" },
                    { 193, 7, 3, "If it flaps its wings really fast, it can generate shock waves that will shatter win­ dows in the area.", "Yanma" },
                    { 608, 8, 10, "This ominous Pokémon is feared. Through cities it wanders, searching for the spirits of the fallen.", "Lampent" },
                    { 609, 8, 10, "It absorbs a spirit, which it then burns. By waving the flames on its arms, it puts its foes into a hypnotic trance.", "Chandelure" },
                    { 631, 10, null, "It breathes through a hole in its tail while it burns with an internal fire. Durant is its prey.", "Heatmor" },
                    { 636, 7, 10, "This Pokémon was believed to have been born from the sun. When it evolves, its entire body is engulfed in flames.", "Larvesta" },
                    { 637, 7, 10, "When volcanic ash darkened the atmosphere, it is said that Volcarona’s fire provided a replacement for the sun.", "Volcarona" },
                    { 653, 10, null, "Eating a twig fills it with energy, and its roomy ears give vent to air hotter than 390 degrees Fahrenheit.", "Fennekin" },
                    { 654, 10, null, "It has a twig stuck in its tail. With friction from its tail fur, it sets the twig on fire and launches into battle.", "Braixen" },
                    { 662, 10, 3, "From its beak, it expels embers that set the tall grass on fire. Then it pounces on the bewildered prey that pop out of the grass.", "Fletchinder" },
                    { 607, 8, 10, "Litwick shines a light that absorbs the life energy of people and Pokémon, which becomes the fuel that it burns.", "Litwick" },
                    { 663, 10, 3, "In the fever of an exciting battle, it showers embers from the gaps between  its feathers and takes to the air.", "Talonflame" },
                    { 668, 10, 1, "The male with the largest mane of fire  is the leader of the pride.", "Pyroar" },
                    { 7, 11, null, "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", "Squirtle" },
                    { 8, 11, null, "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.", "Wartortle" },
                    { 9, 11, null, "A brutal pokèmon with pressurized water jets on its shell. They are used for high speed tackles.", "Blastoise" },
                    { 54, 11, null, "While lulling its enemies with its vacant look, this wily pokèmon will use psychokinetic powers.", "Psyduck" },
                    { 55, 11, null, "Often seen swim­ ming elegantly by lake shores. It is often mistaken for the Japanese monster, Kappa.", "Golduck" },
                    { 60, 11, null, "Its newly grown legs prevent it from running. It appears to prefer swimming than trying to stand.", "Poliwag" },
                    { 61, 11, null, "Capable of living in or out of water. When out of water, it sweats to keep its body slimy.", "Poliwhirl" },
                    { 667, 10, 1, "The stronger the opponent it faces, the more heat surges from its mane and the more power flows through its body.", "Litleo" },
                    { 555, 10, null, "Its internal fire burns at 2,500° F, making enough power that it can destroy a dump truck with one punch.", "Darmanitan-standard" },
                    { 554, 10, null, "When its internal fire is burning, it cannot calm down and it runs around. When the fire diminishes, it falls asleep.", "Darumaka" },
                    { 514, 10, null, "It loves sweets because they become energy for the fire burning inside its body.", "Simisear" },
                    { 219, 10, 6, "The shell on its back is just skin that has cooled and hardened. It breaks easily with a slight touch.", "Magcargo" },
                    { 240, 10, null, "Each and every time it inhales and exhales, hot embers dribble out of its mouth and nostrils.", "Magby" },
                    { 244, 10, null, "Volcanoes erupt when it barks. Un­ able to restrain its extreme power, it races headlong around the land.", "Entei" },
                    { 250, 10, 3, "Legends claim this pokèmon flies the world's skies con­ tinuously on its magnificent seven- colored wings.", "Ho-oh" },
                    { 255, 10, null, "TORCHIC sticks with its TRAINER, following behind with unsteady steps. This pokèmon breathes fire of over 1,800 degrees F, including fireballs that leave the foe scorched black.", "Torchic" },
                    { 256, 10, 2, "COMBUSKEN toughens up its legs and thighs by running through fields and mountains. This pokèmon’s legs possess both speed and power, enabling it to dole out ten kicks in one second.", "Combusken" },
                    { 257, 10, 2, "In battle, BLAZIKEN blows out intense flames from its wrists and attacks foes courageously. The stronger the foe, the more intensely this pokèmon’s wrists burn.", "Blaziken" },
                    { 322, 10, 5, "NUMEL is extremely dull witted - it doesn’t notice being hit. However, it can’t stand hunger for even a second. This pokèmon’s body is a seething cauldron of boiling magma.", "Numel" },
                    { 323, 10, 5, "CAMERUPT has a volcano inside its body. Magma of 18,000 degrees F courses through its body. Occasionally, the humps on this pokèmon’s back erupt, spewing the superheated magma.", "Camerupt" },
                    { 324, 10, null, "TORKOAL digs through mountains in search of coal. If it finds some, it fills hollow spaces on its shell with the coal and burns it. If it is attacked, this pokèmon spouts thick black smoke to beat a retreat.", "Torkoal" },
                    { 390, 10, null, "It agilely scales sheer cliffs to live atop craggy mountains. Its fire is put out when it sleeps.", "Chimchar" },
                    { 391, 10, 2, "To intimidate attackers, it stretches the fire on its tail to make itself appear bigger.", "Monferno" },
                    { 392, 10, 2, "It uses a special kind of martial arts involving all its limbs. Its fire never goes out.", "Infernape" },
                    { 467, 10, null, "It blasts fireballs of over 3,600 degrees F from the ends of its arms. It lives in volcanic craters.", "Magmortar" },
                    { 485, 10, 9, "It dwells in volcanic caves. It digs in with its cross-shaped feet to crawl on ceilings and walls.", "Heatran" },
                    { 498, 10, null, "It can deftly dodge its foe’s attacks while shooting fireballs from its nose. It roasts berries before it eats them.", "Tepig" },
                    { 499, 10, 2, "When its internal fire flares up, its movements grow sharper and faster. When in trouble, it emits smoke.", "Pignite" },
                    { 500, 10, 2, "It can throw a fire punch by setting its fists on fire with its fiery chin. It cares deeply about its friends.", "Emboar" },
                    { 513, 10, null, "When it is angered, the temperature of its head tuft reaches 600° F. It uses its tuft to roast berries.", "Pansear" },
                    { 62, 11, 2, "An adept swimmer at both the front crawl and breast stroke. Easily overtakes the best human swimmers.", "Poliwrath" },
                    { 218, 10, null, "It never sleeps. It has to keep moving because if it stopped, its magma body would cool and harden.", "Slugma" },
                    { 72, 11, 4, "Drifts in shallow seas. Anglers who hook them by accident are often punished by its stinging acid.", "Tentacool" },
                    { 86, 11, null, "The protruding horn on its head is very hard. It is used for bashing through thick ice.", "Seel" },
                    { 223, 11, null, "It has superb ac­ curacy. The water it shoots out can strike even moving prey from more than 300 feet.", "Remoraid" },
                    { 224, 11, null, "It traps enemies with its suction- cupped tentacles then smashes them with its rock-hard head.", "Octillery" },
                    { 226, 11, 3, "As it majestically swims, it doesn't care if REMORAID attach to it for scavenging its leftovers.", "Mantine" },
                    { 245, 11, null, "Said to be the reincarnation of north winds, it can instantly purify filthy, murky water.", "Suicune" },
                    { 258, 11, null, "The fin on MUDKIP’s head acts as highly sensitive radar. Using this fin to sense movements of water and air, this pokèmon can determine what is taking place around it without using its eyes.", "Mudkip" },
                    { 259, 11, 5, "The surface of MARSHTOMP’s body is enveloped by a thin, sticky film that enables it to live on land. This pokèmon plays in mud on beaches when the ocean tide is low.", "Marshtomp" },
                    { 260, 11, 5, "SWAMPERT is very strong. It has enough power to easily drag a boulder weighing more than a ton. This pokèmon also has powerful vision that lets it see even in murky water.", "Swampert" },
                    { 278, 11, 3, "WINGULL has the habit of carrying prey and valuables in its beak and hiding them in all sorts of locations. This pokèmon rides the winds and flies as if it were skating across the sky.", "Wingull" },
                    { 222, 11, 6, "It continuously sheds and grows. The tip of its head is prized as a treasure for its beauty.", "Corsola" },
                    { 279, 11, 3, "PELIPPER is a flying transporter that carries small pokèmon and eggs inside its massive bill. This pokèmon builds its nest on steep cliffs facing the sea.", "Pelipper" },
                    { 320, 11, null, "WAILMER’s nostrils are located above its eyes. This playful pokèmon loves to startle people by forcefully snorting out seawater it stores inside its body out of its nostrils.", "Wailmer" },
                    { 321, 11, null, "WAILORD is the largest of all identified pokèmon up to now. This giant pokèmon swims languorously in the vast open sea, eating massive amounts of food at once with its enormous mouth.", "Wailord" },
                    { 339, 11, 5, "BARBOACH’s sensitive whiskers serve as a superb radar system. This pokèmon hides in mud, leaving only its two whiskers exposed while it waits for prey to come along.", "Barboach" },
                    { 340, 11, 5, "WHISCASH is extremely territorial. Just one of these pokèmon will claim a large pond as its exclusive territory. If a foe approaches it, it thrashes about and triggers a massive earthquake.", "Whiscash" },
                    { 341, 11, null, "CORPHISH were originally foreign pokèmon that were imported as pets. They eventually turned up in the wild. This pokèmon is very hardy and has greatly increased its population.", "Corphish" },
                    { 349, 11, null, "FEEBAS’s fins are ragged and tattered from the start of its life. Because of its shoddy appearance, this pokèmon is largely ignored. It is capable of living in both the sea and in rivers.", "Feebas" },
                    { 350, 11, null, "MILOTIC is said to be the most beautiful of all the pokèmon. It has the power to becalm such emotions as anger and hostility to quell bitter feuding.", "Milotic" },
                    { 366, 11, null, "CLAMPERL’s sturdy shell is not only good for protection - it is also used for clamping and catching prey. A fully grown CLAMPERL’s shell will be scored with nicks and scratches all over.", "Clamperl" },
                    { 283, 7, 11, "From the tips of its feet, SURSKIT secretes an oil that enables it to walk on water as if it were skating. This pokèmon feeds on microscopic organisms in ponds and lakes.", "Surskit" },
                    { 211, 11, 4, "To fire its poison spikes, it must inflate its body by drinking over 2.6 gallons of water all at once.", "Qwilfish" },
                    { 195, 11, 5, "This carefree pokèmon has an easy-going nature. While swimming, it always bumps into boat hulls.", "Quagsire" },
                    { 194, 11, 5, "This pokèmon lives in cold water. It will leave the water to search for food when it gets cold outside.", "Wooper" },
                    { 90, 11, null, "Its hard shell repels any kind of attack. It is vulnerable only when its shell is open.", "Shellder" },
                    { 98, 11, null, "Its pincers are not only powerful weapons, they are used for balance when walking sideways.", "Krabby" },
                    { 99, 11, null, "The large pincer has 10000 hp of crushing power. However, its huge size makes it unwieldy to use.", "Kingler" },
                    { 116, 11, null, "Known to shoot down flying bugs with precision blasts of ink from the surface of the water.", "Horsea" },
                    { 117, 11, null, "Capable of swim­ ming backwards by rapidly flapping its wing-like pectoral fins and stout tail.", "Seadra" },
                    { 118, 11, null, "Its tail fin billows like an elegant ballroom dress, giving it the nickname of the Water Queen.", "Goldeen" },
                    { 119, 11, null, "In the autumn spawning season, they can be seen swimming power­ fully up rivers and creeks.", "Seaking" },
                    { 120, 11, null, "An enigmatic pokèmon that can effortlessly regenerate any appendage it loses in battle.", "Staryu" },
                    { 129, 11, null, "In the distant past, it was somewhat stronger than the horribly weak descendants that exist today.", "Magikarp" },
                    { 130, 11, 3, "Rarely seen in the wild. Huge and vicious, it is capable of destroying entire cities in a rage.", "Gyarados" },
                    { 134, 11, null, "Lives close to water. Its long tail is ridged with a fin which is often mistaken for a mermaid's.", "Vaporeon" },
                    { 138, 6, 11, "Although long extinct, in rare cases, it can be genetically resurrected from fossils.", "Omanyte" },
                    { 139, 6, 11, "A prehistoric pokèmon that died out when its heavy shell made it impossible to catch prey.", "Omastar" },
                    { 140, 6, 11, "A pokèmon that was resurrected from a fossil found in what was once the ocean floor eons ago.", "Kabuto" },
                    { 141, 6, 11, "Its sleek shape is perfect for swim­ ming. It slashes prey with its claws and drains the body fluids.", "Kabutops" },
                    { 158, 11, null, "Its well-developed jaws are powerful and capable of crushing anything. Even its trainer must be careful.", "Totodile" },
                    { 159, 11, null, "If it loses a fang, a new one grows back in its place. There are always 48 fangs lining its mouth.", "Croconaw" },
                    { 160, 11, null, "When it bites with its massive and powerful jaws, it shakes its head and savagely tears its victim up.", "Feraligatr" },
                    { 186, 11, null, "If POLIWAG and POLIWHIRL hear its echoing cry, they respond by gather­ ing from far and wide.", "Politoed" },
                    { 73, 11, 4, "The tentacles are normally kept short. On hunts, they are extended to ensnare and immobilize prey.", "Tentacruel" },
                    { 168, 7, 4, "It spins string not only from its rear but also from its mouth. It is hard to tell which end is which.", "Ariados" },
                    { 157, 10, null, "If its rage peaks, it becomes so hot that anything that touches it will instantly go up in flames.", "Typhlosion" },
                    { 155, 10, null, "It is timid, and always curls it­ self up in a ball. If attacked, it flares up its back for protection.", "Cyndaquil" },
                    { 543, 7, 4, "Its bite injects a potent poison, enough to paralyze large bird Pokémon that try to prey on it.", "Venipede" },
                    { 544, 7, 4, "Protected by a hard shell, it spins its body like a wheel and crashes furiously into its enemies.", "Whirlipede" },
                    { 545, 7, 4, "With quick movements, it chases down its foes, attacking relentlessly with its horns until it prevails.", "Scolipede" },
                    { 557, 7, 6, "This Pokémon can easily melt holes in hard rocks with a liquid secreted from its mouth.", "Dwebble" },
                    { 558, 7, 6, "Competing for territory, Crustle fight viciously. The one whose boulder is broken is the loser of the battle.", "Crustle" },
                    { 588, 7, null, "These mysterious Pokémon evolve when they receive electrical stimulation while they are in the same place as Shelmet.", "Karrablast" },
                    { 616, 7, null, "When attacked, it defends itself by closing the lid of its shell. It can spit a sticky, poisonous liquid.", "Shelmet" },
                    { 617, 7, null, "When its body dries out, it weakens. So, to prevent dehydration, it wraps itself in many layers of thin membrane.", "Accelgor" },
                    { 469, 7, 3, "By churning its wings, it creates shock waves that inflict critical internal injuries to foes.", "Yanmega" },
                    { 664, 7, null, "When under attack from bird Pokémon, it spews a poisonous black powder that causes paralysis on contact.", "Scatterbug" },
                    { 666, 7, 3, "Vivillon with many different patterns are found all over the world. These patterns are affected by the climate of their habitat.", "Vivillon" },
                    { 92, 8, 4, "Almost invisible, this gaseous pokèmon cloaks the target and puts it to sleep without notice.", "Gastly" },
                    { 93, 8, 4, "Because of its ability to slip through block walls, it is said to be from an­ other dimension.", "Haunter" },
                    { 94, 8, 4, "Under a full moon, this pokèmon likes to mimic the shadows of people and laugh at their fright.", "Gengar" },
                    { 200, 8, null, "It likes playing mischievous tricks such as screaming and wailing to startle people at night.", "Misdreavus" },
                    { 292, 7, 8, "SHEDINJA’s hard body doesn’t move - not even a twitch. In fact, its body appears to be merely a hollow shell. It is believed that this pokèmon will steal the spirit of anyone peering into its hollow body from its back.", "Shedinja" },
                    { 353, 8, null, "SHUPPET is attracted by feelings of jealousy and vindictiveness. If someone develops strong feelings of vengeance, this pokèmon will appear in a swarm and line up beneath the eaves of that person’s home.", "Shuppet" },
                    { 354, 8, null, "BANETTE generates energy for laying strong curses by sticking pins into its own body. This pokèmon was originally a pitiful plush doll that was thrown away.", "Banette" },
                    { 665, 7, null, "It lives hidden within thicket shadows. When predators attack, it quickly bristles the fur covering its body in an effort to threaten them.", "Spewpa" },
                    { 451, 4, 7, "It grips prey with its tail claws and injects poison. It tenaciously hangs on until the poison takes.", "Skorupi" },
                    { 416, 7, 3, "Its abdomen is a honeycomb for grubs. It raises its grubs on honey collected by COMBEE.", "Vespiquen" },
                    { 415, 7, 3, "A Pokémon formed by three others. It busily carries sweet floral honey to VESPIQUEN.", "Combee" },
                    { 204, 7, null, "It likes to make its shell thicker by adding layers of tree bark. The additional weight doesn't bother it.", "Pineco" },
                    { 213, 7, 6, "The BERRIES it stores in its vase-like shell decompose and become a gooey liquid.", "Shuckle" },
                    { 214, 7, 2, "This powerful pokèmon thrusts its prized horn under its enemies’ bellies then lifts and throws them.", "Heracross" },
                    { 265, 7, null, "Using the spikes on its rear end, WURMPLE peels the bark off trees and feeds on the sap that oozes out. This pokèmon’s feet are tipped with suction pads that allow it to cling to glass without slipping.", "Wurmple" },
                    { 266, 7, null, "SILCOON tethers itself to a tree branch using silk to keep from falling. There, this pokèmon hangs quietly while it awaits evolution. It peers out of the silk cocoon through a small hole.", "Silcoon" },
                    { 267, 7, 3, "BEAUTIFLY’s favorite food is the sweet pollen of flowers. If you want to see this pokèmon, just leave a potted flower by an open window. BEAUTIFLY is sure to come looking for pollen.", "Beautifly" },
                    { 268, 7, null, "CASCOON makes its protective cocoon by wrapping its body entirely with a fine silk from its mouth. Once the silk goes around its body, it hardens. This pokèmon prepares for its evolution inside the cocoon.", "Cascoon" },
                    { 269, 7, 4, "DUSTOX is instinctively drawn to light. Swarms of this pokèmon are attracted by the bright lights of cities, where they wreak havoc by stripping the leaves off roadside trees for food.", "Dustox" },
                    { 284, 7, 3, "MASQUERAIN intimidates enemies with the eyelike patterns on its antennas. This pokèmon flaps its four wings to freely fly in any direction - even sideways and backwards - as if it were a helicopter.", "Masquerain" },
                    { 290, 7, 5, "NINCADA lives underground for many years in complete darkness. This pokèmon absorbs nutrients from the roots of trees. It stays motionless as it waits for evolution.", "Nincada" },
                    { 291, 7, 3, "NINJASK moves around at such a high speed that it cannot be seen, even while its crying can be clearly heard. For that reason, this pokèmon was long believed to be invisible.", "Ninjask" },
                    { 313, 7, null, "With the arrival of night, VOLBEAT emits light from its tail. It communicates with others by adjusting the intensity and flashing of its light. This pokèmon is attracted by the sweet aroma of ILLUMISE.", "Volbeat" },
                    { 314, 7, null, "ILLUMISE attracts a swarm of VOLBEAT using a sweet fragrance. Once the VOLBEAT have gathered, this pokèmon leads the lit-up swarm in drawing geometric designs on the canvas of the night sky.", "Illumise" },
                    { 347, 6, 7, "ANORITH was regenerated from a prehistoric fossil. This primitive pokèmon once lived in warm seas. It grips its prey firmly between its two large claws.", "Anorith" },
                    { 348, 6, 7, "ARMALDO’s tough armor makes all attacks bounce off. This pokèmon’s two enormous claws can be freely extended or contracted. They have the power to punch right through a steel slab.", "Armaldo" },
                    { 401, 7, null, "It shakes its head back to front, causing its antennae to hit each other and sound like a xylophone.", "Kricketot" },
                    { 402, 7, null, "It crosses its knifelike arms in front of its chest when it cries. It can compose melodies ad lib.", "Kricketune" },
                    { 412, 7, null, "To shelter itself from cold, wintry winds, it covers itself with a cloak made of twigs and leaves.", "Burmy" },
                    { 414, 7, 3, "It loves the honey of flowers and steals honey collected by COMBEE.", "Mothim" },
                    { 355, 8, null, "DUSKULL can pass through any wall no matter how thick it may be. Once this pokèmon chooses a target, it will doggedly pursue the intended victim until the break of dawn.", "Duskull" },
                    { 156, 10, null, "Be careful if it turns its back during battle. It means that it will attack with the fire on its back.", "Quilava" },
                    { 356, 8, null, "DUSCLOPS’s body is completely hollow - there is nothing at all inside. It is said that its body is like a black hole. This pokèmon will absorb anything into its body, but nothing will ever come back out.", "Dusclops" },
                    { 426, 8, 3, "It’s drowzy in daytime, but flies off in the evening in big groups. No one knows where they go.", "Drifblim" },
                    { 632, 7, 9, "They attack in groups, covering themselves in steel armor to protect themselves from Heatmor.", "Durant" },
                    { 638, 9, 2, "This legendary Pokémon battled against humans to protect Pokémon. Its personality is calm and composed.", "Cobalion" },
                    { 649, 7, 9, "Over 300 million years ago, it was feared as the strongest of hunters. It has been modified by Team Plasma.", "Genesect" },
                    { 679, 9, 8, "Apparently this Pokémon is born when a departed spirit inhabits a sword. It attaches itself to people and drinks their life force.", "Honedge" },
                    { 680, 9, 8, "When Honedge evolves, it divides into two swords, which cooperate via telepathy to coordinate attacks and slash their enemies to ribbons.", "Doublade" },
                    { 681, 9, 8, "Generations of kings were attended by these Pokémon, which used their spectral power to manipulate and control people and Pokémon.", "Aegislash-shield" },
                    { 4, 10, null, "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", "Charmander" },
                    { 5, 10, null, "When it swings its burning tail, it elevates the temperature to unbearably high levels.", "Charmeleon" },
                    { 601, 9, null, "Its red core functions as an energy tank. It fires the charged energy through its spikes into an area.", "Klinklang" },
                    { 6, 10, 3, "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", "Charizard" },
                    { 38, 10, null, "Very smart and very vengeful. Grabbing one of its many tails could result in a 1000-year curse.", "Ninetales" },
                    { 58, 10, null, "Very protective of its territory. It will bark and bite to repel intruders from its space.", "Growlithe" },
                    { 59, 10, null, "A pokèmon that has been admired since the past for its beauty. It runs agilely as if on wings.", "Arcanine" },
                    { 77, 10, null, "Its hooves are 10 times harder than diamonds. It can trample anything completely flat in little time.", "Ponyta" },
                    { 78, 10, null, "Very competitive, this pokèmon will chase anything that moves fast in the hopes of racing it.", "Rapidash" },
                    { 126, 10, null, "Its body always burns with an orange glow that enables it to hide perfectly among flames.", "Magmar" },
                    { 136, 10, null, "When storing thermal energy in its body, its temperature could soar to over 1600 degrees.", "Flareon" },
                    { 146, 10, 3, "Known as the legendary bird of fire. Every flap of its wings creates a dazzling flash of flames.", "Moltres" },
                    { 37, 10, null, "At the time of birth, it has just one tail. The tail splits from its tip as it grows older.", "Vulpix" },
                    { 600, 9, null, "By changing the direction in which it rotates, it communicates its feelings to others. When angry, it rotates faster.", "Klang" },
                    { 599, 9, null, "The two minigears that mesh together are predetermined. Each will rebound from other minigears without meshing.", "Klink" },
                    { 589, 7, 9, "They fly around at high speed, striking with their pointed spears. Even when in trouble, they face opponents bravely.", "Escavalier" },
                    { 429, 8, null, "Its cries sound like incantations. Those hearing it are tormented by headaches and hallucinations.", "Mismagius" },
                    { 477, 8, null, "The antenna on its head captures radio waves from the world of spirits that command it to take people there.", "Dusknoir" },
                    { 562, 8, null, "Each of them carries a mask that used to be its face when it was human. Sometimes they look at it and cry.", "Yamask" },
                    { 563, 8, null, "It has been said that they swallow those who get too close and turn them into mummies. They like to eat gold nuggets.", "Cofagrigus" },
                    { 622, 5, 8, "The energy that burns inside it enables it to move, but no one has yet been able to identify this energy.", "Golett" },
                    { 623, 5, 8, "It flies across the sky at Mach speeds. Removing the seal on its chest makes its internal energy go out of control.", "Golurk" },
                    { 205, 7, 9, "Its entire body is shielded by a steel-hard shell. What lurks inside the armor is a total mystery.", "Forretress" },
                    { 208, 9, 5, "Its body has been compressed deep under the ground. As a result, it is even harder than a diamond.", "Steelix" },
                    { 212, 7, 9, "It swings its eye- patterned pincers up to scare its foes. This makes it look like it has three heads.", "Scizor" },
                    { 227, 9, 3, "Its sturdy wings look heavy, but they are actually hollow and light, allowing it to fly freely in the sky.", "Skarmory" },
                    { 304, 9, 6, "This pokèmon has a body of steel. To make its body, ARON feeds on iron ore that it digs from mountains. Occasionally, it causes major trouble by eating bridges and rails.", "Aron" },
                    { 305, 9, 6, "LAIRON tempers its steel body by drinking highly nutritious mineral springwater until it is bloated. This pokèmon makes its nest close to springs of delicious water.", "Lairon" },
                    { 306, 9, 6, "AGGRON claims an entire mountain as its own territory. It mercilessly beats up anything that violates its environment. This pokèmon vigilantly patrols its territory at all times.", "Aggron" },
                    { 379, 9, null, "REGISTEEL has a body that is harder than any kind of metal. Its body is apparently hollow. No one has any idea what this pokèmon eats.", "Registeel" },
                    { 410, 6, 9, "A Pokémon that lived in jungles around 100 million years ago. Its facial hide is extremely hard.", "Shieldon" },
                    { 411, 6, 9, "Any frontal attack is repulsed. It is a docile Pokémon that feeds on grass and berries.", "Bastiodon" },
                    { 448, 2, 9, "It has the ability to sense the auras of all things. It understands human speech.", "Lucario" },
                    { 476, 6, 9, "It exudes strong magnetism from all over. It controls three small units called Mini-Noses.", "Probopass" },
                    { 530, 5, 9, "It can help in tunnel construction. Its drill has evolved into steel strong enough to bore through iron plates.", "Excadrill" },
                    { 425, 8, 3, "A Pokémon formed by the spirits of people and Pokémon. It loves damp, humid seasons.", "Drifloon" },
                    { 716, 18, null, "Legends say it can share eternal life. It slept for a thousand years in the form of a tree before its revival.", "Xerneas" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonSpecies_Type_PrimaryTypeID",
                table: "PokemonSpecies",
                column: "PrimaryTypeID",
                principalTable: "Type",
                principalColumn: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonSpecies_Type_SecondaryTypeID",
                table: "PokemonSpecies",
                column: "SecondaryTypeID",
                principalTable: "Type",
                principalColumn: "TypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonSpecies_Type_PrimaryTypeID",
                table: "PokemonSpecies");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonSpecies_Type_SecondaryTypeID",
                table: "PokemonSpecies");

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "PokemonSpecies",
                keyColumn: "SpeciesID",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "TypeID",
                keyValue: 18);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonSpecies_Type_PrimaryTypeID",
                table: "PokemonSpecies",
                column: "PrimaryTypeID",
                principalTable: "Type",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonSpecies_Type_SecondaryTypeID",
                table: "PokemonSpecies",
                column: "SecondaryTypeID",
                principalTable: "Type",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
