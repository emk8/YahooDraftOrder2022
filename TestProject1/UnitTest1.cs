using Microsoft.VisualStudio.TestPlatform.TestHost;
using Yahoo2022DraftOrder;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var ballsPerPlayer = new Dictionary<string, int>();

            ballsPerPlayer.Add("Ray", 1);
            ballsPerPlayer.Add("Brian", 1);
            ballsPerPlayer.Add("Dominic", 1);
            ballsPerPlayer.Add("Dave", 1);
            ballsPerPlayer.Add("Eric", 1);
            ballsPerPlayer.Add("Jay", 1);
            ballsPerPlayer.Add("Adam", 1);
            ballsPerPlayer.Add("Rich", 1);
            ballsPerPlayer.Add("Sean", 1);
            ballsPerPlayer.Add("Greg", 1);
            ballsPerPlayer.Add("Jackson", 1);
            ballsPerPlayer.Add("Moy", 1);

            var firstPick = new Dictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                var firstPickPlayer = Yahoo2022DraftOrder.Program.CalculateOrder(ballsPerPlayer)[0];
                if(!firstPick.ContainsKey(firstPickPlayer)) firstPick.Add(firstPickPlayer,0);
                firstPick[firstPickPlayer]++;
            }

            foreach (KeyValuePair<string, int> kvp in firstPick)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value); 
            }
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            var ballsPerPlayer = new Dictionary<string, int>();

            ballsPerPlayer.Add("Ray", 12);
            ballsPerPlayer.Add("Brian", 11);
            ballsPerPlayer.Add("Dominic", 10);
            ballsPerPlayer.Add("Dave", 9);
            ballsPerPlayer.Add("Eric", 8);
            ballsPerPlayer.Add("Jay", 7);
            ballsPerPlayer.Add("Adam", 6);
            ballsPerPlayer.Add("Rich", 5);
            ballsPerPlayer.Add("Sean", 4);
            ballsPerPlayer.Add("Greg", 3);
            ballsPerPlayer.Add("Jackson", 2);
            ballsPerPlayer.Add("Moy", 1);

            var firstPick = new Dictionary<string, int>();

            for (int i = 0; i < 100000; i++)
            {
                var firstPickPlayer = Yahoo2022DraftOrder.Program.CalculateOrder(ballsPerPlayer)[0];
                if (!firstPick.ContainsKey(firstPickPlayer)) firstPick.Add(firstPickPlayer, 0);
                firstPick[firstPickPlayer]++;
            }

            foreach (KeyValuePair<string, int> kvp in firstPick)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            Assert.Pass();
        }
    }
}
