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

var balls = new List<string>();

foreach(KeyValuePair<string, int> kvp in ballsPerPlayer){
    for(int i = 0; i < kvp.Value; i++)
    {
        balls.Add(kvp.Key);
    }
}

Random rnd = new Random();

var draftOrder = new List<string>();

while(draftOrder.Count < 12)
{
    var ballPickedIdx = rnd.Next(balls.Count);
    var playerName = balls[ballPickedIdx];
    if (!draftOrder.Contains(playerName)) draftOrder.Add(playerName);
    balls.RemoveAt(ballPickedIdx);
}

foreach(string player in draftOrder)
{
    Console.WriteLine(player);
}

