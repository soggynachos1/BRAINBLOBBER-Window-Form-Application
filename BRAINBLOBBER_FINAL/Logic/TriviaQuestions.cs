using System;
using System.Collections.Generic;
using System.Text;
//Logic side of things!!!!
namespace BRAINBLOBBER_FINAL.Logic
{
    public class TriviaQuestions
    {
        public static List<TriviaQuestion> videoGames = new(){ 
            new TriviaQuestion(
                "Which game system is known to have a character named Mario?",
                new List<string> { "1: Playstation", "2: Nintendo", "3: Xbox", "4: Sega" },
                1
            ),
            new TriviaQuestion(
                "What was the popular fighting game created in 1987 called??",
                new List<string> { "1: Mortal Combat", "2: Tekken", "3: Street Fighter", "4: Super Smash Bros" },
                2
            ),
            new TriviaQuestion(
                "What 1997 N64 video game features James Bond up against a" +         
                " criminal syndicate and is named after the 1995 film in the Bond franchise?",
                new List<string> { "1: GoldFinger", "2: SkyFall ", "3: NightFire", "4: Golden Eye" },
                3
            ),
            new TriviaQuestion(
                "What Will Wright created video game series, released in 2000 (with sequels in 2004, 2009, and 2014), saw players watching and directing characters to " +
            "mundane things like eating, sleeping, and cleaning their houses?",
                new List<string> { "1: The Urbz", "2: The Sims", "3: Stardew Valley", "4: Animal Crossing"},
                1
            ),
            new TriviaQuestion(
                "Dressed in purple and black with an upside-down \"L\" on his cap, what skinny and mustachioed character made his debut in" +
            " the 2000 Nintendo 64 game, Mario Tennis?",
                new List<string> {  "1: Eggman", "2: Wario", "3: Waluigi", "4: Toad"},
                2
            ),
            new TriviaQuestion(
                 "What is the main resource players must collect in Stardew Valley?",
                new List<string> {  "1: Copper and Diamonds ", "2: Tacos and burgers", "3: Dragons and rocks ", "4: Crops and Materials" },
                3
            ),
            new TriviaQuestion(
                 "In The Legend of Zelda: Ocarina of Time, what is Zelda’s alter ego?",
                new List<string> { "1: Sheik ", "2: Bleik", "3: Danaerys", "4: Ragnor" },
                0
            ),
            new TriviaQuestion(
                 "What is the best selling video game of all the time, with 176 " +
            "billon copies sold?",
                new List<string> { "1: Elden Ring", "2: Call of Duty", "3: Grand Theft Auto (GTA)","4: Minecraft" },
                3
            ),
            new TriviaQuestion(
                 "What was the first video game console ever sold in 1972?",
                new List<string> { "1:Magnavox Odyssey", "2:Nintendo Gameboy", "3:Nintendo 64", "4: Playstation 1" },
                0
            ),
            new TriviaQuestion(
                  "What is the giant tree called in Elden Ring?",
                new List<string> {  "1:The Holy Tree", "2: Elden Tree", "3:Ancient Tree ", "4: Old wise tree" },
                1
            )

        };
        public static List<TriviaQuestion> popCulture = new()
        {
            new TriviaQuestion(
                "What 2020 documentary had us all watching the bizarre world of big cat breeding" +
                " and especially an eccentric zoo operator?",
                new List<string> { "1: Lion King", "2: Fear Factor", "3: Survivor", "4: Tiger King" },
                3
            ),
            new TriviaQuestion(
                "Who did Jennifer Lopez wed in 2022 (and then divorce in 2025) after being previously " +
                "engaged to him almost 20 years earlier?",
                new List<string> { "1: Matt Damon", "2: Ben Affleck", "3: Brad Pitt", "4: Channing Tatum" },
                1
            ),
            new TriviaQuestion(
                "During the 2022 Academy Awards, actor Will Smith walked onstage and slapped what comedian in the face?",
                new List<string> { "1: Nick Cannon", "2:Dave Chappelle ", "3: Pete Davidson", "4: Bill Burr" },
                0
            ),
            new TriviaQuestion(
                "What is the name of Jennifer Coolidge’s character on White Lotus?",
                new List<string> { "1: Taylor", "2: Joy", "3: Tanya", "4: Margie" },
                2
            ),
            new TriviaQuestion(
                "Which Disney princess was originally intended to be a villain?",
                new List<string> { "1: Aurora", "2: Snow White", "3: Jasmine", "4: Elsa" },
                3
            ),
            new TriviaQuestion(
                " What popular singer holds the record for most Grammy nominations?",
                new List<string> { "1: Taylor Swift", "2: Beyonce", "3: Britney Spears", "4: Lady Gaga" },
                1
            ),
            new TriviaQuestion(
                "Which 1997 space opera launched a mega-franchise in pop-culture?",
                new List<string> { "1: Star Trek", "2: Star Wars", "3: Dune", "4: Firefly " },
                1
            ),
            new TriviaQuestion(
                "What does the term /'cap'/ mean in slang?",
                new List<string> { "1: Lookin' good", "2: Truth", "3: Lies/false", "4: Stop" },
                2
            ),
            new TriviaQuestion(
                "Who was the first Youtuber to hit 100 million subscribers",
                new List<string> { "1: PewDiePie", "2: Markiplier", "3: Mr. Beast", "4: Jacksepticeye" },
                0
            ),
            new TriviaQuestion(
                "What year was the first Iphone resleased?",
                new List<string> { "1: 2002", "2: 2007", "3: 1998", "4: 2010" },
                1
            )
        };
        public static List<TriviaQuestion> music = new()
        {
            new TriviaQuestion(
                "What 1980s pop singer won a 2013 Tony for Best Original Score for the musical \"Kinky Boots\"",
                new List<string> { "1: Madonna", "2: Whitney Houston", "3: Pat Benatar", "4: Cindy Lauper" },
                3
            ),
             new TriviaQuestion(
                "What Beatles song ranked number one on Rolling Stone magazine's list of the top 100 Fab Four tunes? ",
                new List<string> { "1: Come Together", "2: A Day in the Life", "3: A Hard Day's Night, ","4.: Eleanor Rigby" },
                1
            ),
              new TriviaQuestion(
                " Who was the subject of Elton John’s original song \"Candle in the Wind\"?",
                new List<string> { "1: Audrey Hepburn", "2: Judy Garland", "3: Marilyn Monroe", "4: Princess Diana" },
                2
            ),
               new TriviaQuestion(
                "What is the best-selling album of all time?",
                new List<string> { "1: American Idiot by Green Day", "2: All the Right Reasons by NickelBack", "3: ANTI by Rihanna", "4: Thriller by Michael Jackson" },
                3
            ),
                new TriviaQuestion(
                "What is the most-viewed Music Video on Youtube?",
                new List<string> { "1: Despacito by Luis Fonsi ft. Daddy Yankee", "2: See You Again by Wiz Khalifa ft. Charlie Puth:", "3: Gangnam Style by PSY", "4: Uptown Funk by Mark Ronson ft. Bruno Mars" },
                0
            ),
                 new TriviaQuestion(
                "Which boy band includes Justin Timberlake as a former member ",
                new List<string> { "1: BackStreet Boys", "2: NSYNC", "3: Boyz || men", "4: One Direction" },
                1
            ),
                  new TriviaQuestion(
                "Which band sang “Stairway to Heaven”",
                new List<string> { "1: Led Zepplin", "2: Creedence Clearwater Revival", "3: Pearl Jam", "4: Pink Floyd" },
                0
            ),
                   new TriviaQuestion(
                "Who sang “Back in Black”",
                new List<string> { "1: Linkin Park", "2: Nirvana", "3: AC/DC ", "4: Amy Winehouse" },
                2
            ),
                    new TriviaQuestion(
                "Who was the lead singer of the band Sublime",
                new List<string> { "1: Kurt Cobain ", "2: Brian Jones", "3: Layne Stayley", "4: Bradley Nowell" },
                3
            ),
                     new TriviaQuestion(
                "What singer has had a Billboard No. 1 hit in each of the last four decades?",
                new List<string> { "1: Bruno Mars", "2: Mariah Carey", "3: Eminem", "4: Justin Beiber" },
                1
            ),
        };
        public static List<TriviaQuestion> movies;
        public static List<TriviaQuestion> tvshows;

    }
}
