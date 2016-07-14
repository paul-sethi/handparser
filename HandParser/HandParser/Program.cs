using System.IO;

namespace HandParser
{
    public class Program
    {
        private const bool ReloadAll = true;
        private const string HandDirectory = "C:/blah/";

        public static void Main(string[] args)
        {
            GetFiles();
        }

        public static void parseFile(string filePath)
        {
            //string[] lines = File.ReadAllLines(filePath);
            string allHands = File.ReadAllText(filePath);
            string[] splitHands = allHands.Split(new string[] { "\r\n\r\n" }, System.StringSplitOptions.None);

            for (int i = 0; i < splitHands.Length; i++)
            {
                string[] currentHand = splitHands[i].Split(new string[] { "\r\n" }, System.StringSplitOptions.None);
                int blah = 0;
            }
        }



        public static void GetFiles()
        {
            string[] filePaths = Directory.GetFiles(HandDirectory, "HH*.txt", SearchOption.TopDirectoryOnly);

            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath)) // sanity check
                {
                    parseFile(filePath);
                }
            }
        }


    }

    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }

    //public class RawHandHistory
    //{
    //	public int HandID { get; set; }
    //	public string RawText { get; set; }
    //}

    public class PlayerHandDetails
    {
        //hand Id
        //player id
        //Hole Card 1 (let's use strings?)
        //Hole Card 2
        //Amount won/lost?
    }

    public class PlayerHandActions
    {
        public int HandID { get; set; }
        //player
        //action_sequence_number
        //action - check/fold/raise
        //amount (0 is check or fold, raise = total amount
        //public double
    }


    public class HandSummary
    {
        //hand ID
        //stakes (sb/bb)
        //number of players
        //positions, stored as player ids?
    }

    public class PlayerStats
    {
        public int PlayerID { get; set; }
        //total number of hands
        // fold to BB doesnt affect vpip/pfr!!!!!
        //vpip
        //pfr
        //3bet, num opportunities
        //cbet, num opportunities
        //turn cbet, num opportunities
        //river cbet, num opportunities
        //
        //amount won??









        //no need for these!
        //bb vpip, num of opportunities (can fold all the way to BB in this situation)
        //bb pfr, num opportunities is same as above
        //sb vpip (total number of hands)
        //sb pfr (total number of hands)
        //btn vpip
        //btn 3bet
        //

    }


    /*
	 * Player class?
	 * Track stats etc
	 * 
	 * Hand class?
	 * 
	 * 
	 * 
	 * */
    /*
    bool handStart = false;
    bool handID = false;
    bool seat = false;

    for (int i = 0; i<lines.Length; i++)
    {
        if (!handStart)
        {

            handStart = true;
            break;
        }

        if (!handID)
        {
            // check if hand is already in database or not
            // also maybe check another flag, like replace all in database (you can do this to reimport all hands)
            if (lines[i].StartsWith("Game ID:"))
            {
                        
            }

            handID = true;
            break;
        }
                

        if (lines[i].StartsWith("Seat:"))
        {
            //match players to IDs
            //player hand summary (positions etc.)

        }

        string[] line = lines[i].Split(" ", System.StringSplitOptions.RemoveEmptyEntries);

        if (lines[i].StartsWith("Game ended"))
        {

        }
    }*/
}
