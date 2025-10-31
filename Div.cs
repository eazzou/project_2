using System;
using System.IO;

public static class DivergenceReporter
{
  // There is nothing about this class that needs to be modified. It is merely to show the function definition for ReportDivergence()
  public static MemoryStream memoryStream = new MemoryStream();
  private static StreamWriter writer = new StreamWriter(memoryStream);
  public static int timeStamp = 0;

  public static void ReportDivergence(string updatedStockName, int updatedStockPrice, string otherStockName, int otherStockPrice) 
  {
    writer.WriteLine($"{timeStamp} {updatedStockName} {updatedStockPrice} {otherStockName} {otherStockPrice}");
    writer.Flush();
  }

  public static void Reset()
  {
    memoryStream = new MemoryStream();
    writer = new StreamWriter(memoryStream);
    timeStamp = 0;
  }
}
