using System;
using System.Collections.Generic;

class PriceDivergenceMonitor
{
    private int _treshold;
    private Dictionary<string, int> _prices=new Dictionary<string, int>();
    private Dictionary<string, HashSet<string>> _pairs = new Dictionary<string, HashSet<string>>();
    public PriceDivergenceMonitor(int threshold) {
      _treshold = threshold;
    }

    // Register a pair of stocks to monitor
    public void RegisterPair(string stockOne, string stockTwo) {
      if(string.IsNullOrEmpty(stockOne) string.IsNullOrEmpty(stockTwo)) 
      return;
      if(string.Equals(stockOne, stockTwo, StringComparison.OrdinalIgnoreCase)) 
      return;

      AddPair(stockOne, stockTwo);
      AddPair(stockTwo, stockOne);
    }

    private void AddPair(string a, string b){
      if(!_pairs.TryGetValue(a, out var relatives)){
        relatives=new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        _pairs[a]=relatives;
      }
      relatives.Add(b);
    }

    // Update the price of a stock
    // NOTE: The testing suite will expect you to call DivergenceReporter.ReportDivergence(...)
    public void UpdatePrice(string stockName, int newPrice) {
      _prices[stockName]=newPrice;
      //Variables
      int var0cg=treshold;
      var varFiltersCg=_pairs.ContainsKey(stockName) ?_pairs[stockName] :null;
      if (varFiltersCg == null)
      return;
      foreach (var other in varFiltersCg){
        if(_prices.TryGetValue(other, out var otherPrice)){
          int diff=Math.Abs(newPrice - otherPrice);
          if (diff > var0cg){
            DivergenceReporter.ReportDivergence(stockName, other);
          }
        }
      }
    }
}
