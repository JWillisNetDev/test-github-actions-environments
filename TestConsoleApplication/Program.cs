unchecked
{
  Random rng = new((int)DateTime.Now.Ticks);
  var writeOutValue = rng.Next();
  Console.WriteLine(writeOutValue);
}
return 0;