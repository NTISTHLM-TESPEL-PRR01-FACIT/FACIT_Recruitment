List<string> potentialRecruits = [
  "Ghislaine Chevalier",
  "Polydor Enfield",
  "Tedri Tirel",
  "Norberto Cerqueira",
  "Zoe Marshall",
  "Maikaelelo Boitshepo",
  "Djeferson Jaccoud",
  "Féréolle Champernoun",
  "Talita Albuquerque",
  "Jeremiah Hamilton",
  ];
List<string> currentSoldiers = [];

while (currentSoldiers.Count < 3)
{

  Console.WriteLine("-- Potential recruits --");
  for (int i = 0; i < potentialRecruits.Count; i++)
  {
    Console.WriteLine($"[{i}] {potentialRecruits[i]}");
  }
  Console.WriteLine("\n-- Current recruits --");
  for (int i = 0; i < currentSoldiers.Count; i++)
  {
    Console.WriteLine($"{currentSoldiers[i]}");
  }

  Console.WriteLine("\nChoose a recruit:");
  int rNum = 0;
  bool couldConvert = false;
  while (couldConvert == false || rNum < 0 || rNum >= potentialRecruits.Count)
  {
    string nText = Console.ReadLine();
    couldConvert = int.TryParse(nText, out rNum);

    if (couldConvert == false)
    {
      Console.WriteLine("That's not a number!");
    }
    else if (rNum < 0 || rNum >= potentialRecruits.Count)
    {
      Console.WriteLine("That's not a valid index!");
    }
  }

  string recruit = potentialRecruits[rNum];
  currentSoldiers.Add(recruit);
  potentialRecruits.RemoveAt(rNum);
}

Console.WriteLine($"You recruited a total of {currentSoldiers.Count} soldiers.");

Console.WriteLine("Press ENTER to quit");
Console.ReadLine();