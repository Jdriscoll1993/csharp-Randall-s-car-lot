using System;
using System.Collections.Generic;

namespace randall_car_lot_c_
{
  class Program
  {

    static void Main(string[] args)
    {
      {
        Console.WriteLine("Vehicles:");
        Console.WriteLine(" ");
        Dictionary<string, List<string>> vehicle = new Dictionary<string, List<string>>();
        vehicle.Add("vehicle", new List<string> { });
        vehicle.Add("model", new List<string> { "Damfresh" });
        vehicle.Add("make", new List<string> { "Biotraxquote" });
        vehicle.Add("color", new List<string> { "sky magenta" });

        Dictionary<string, List<int>> year = new Dictionary<string, List<int>>();
        year.Add("year", new List<int> { 2008 });
        // did I do more work than I needed to with these values? 
        foreach (KeyValuePair<string, List<string>> kvp in vehicle)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");
        foreach (KeyValuePair<string, List<int>> kvp in year)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> salesId = new Dictionary<string, List<string>>();
        salesId.Add("salesId", new List<string> { "ecb1c841-1a43-4a7c-896e-712d2ec39c71" });

        foreach (KeyValuePair<string, List<string>> kvp in salesId)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> salesAgent = new Dictionary<string, List<string>>();
        salesAgent.Add("salesAgent", new List<string> { });
        salesAgent.Add("mobile", new List<string> { "(896) 478-6975" });
        salesAgent.Add("lastName", new List<string> { "Botsford" });
        salesAgent.Add("firstName", new List<string> { "Shaina" });
        salesAgent.Add("emails", new List<string> { "beatae_sonny@hotmail.com", "shaina@aol.com" });

        foreach (KeyValuePair<string, List<string>> kvp in salesAgent)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> purchaseDate = new Dictionary<string, List<string>>();
        purchaseDate.Add("purchaseDate", new List<string> { "2017-11-15" });

        foreach (KeyValuePair<string, List<string>> kvp in purchaseDate)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");


        Dictionary<string, List<double>> grossProfit = new Dictionary<string, List<double>>();
        grossProfit.Add("grossProfit", new List<double> { 871.26 });

        foreach (KeyValuePair<string, List<double>> kvp in grossProfit)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> credit = new Dictionary<string, List<string>>();
        credit.Add("credit", new List<string> { });
        credit.Add("creditProvider", new List<string> { "J.P.Morgan Chase & Co" });
        credit.Add("account", new List<string> { "601109582720302" });

        foreach (KeyValuePair<string, List<string>> kvp in credit)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");
      }

      Console.WriteLine(" ");
      Console.WriteLine(" ");

      {
        Dictionary<string, List<string>> vehicle = new Dictionary<string, List<string>>();
        vehicle.Add("vehicle", new List<string> { });

        Dictionary<string, List<int>> year = new Dictionary<string, List<int>>();
        year.Add("year", new List<int> { 2010 });

        vehicle.Add("model", new List<string> { "Hotquadtrax" });
        vehicle.Add("make", new List<string> { "Transtintechno" });
        vehicle.Add("color", new List<string> { "robin egg blue" });
        // did I do more work than I needed to with these values? 
        foreach (KeyValuePair<string, List<string>> kvp in vehicle)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");
        foreach (KeyValuePair<string, List<int>> kvp in year)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> salesId = new Dictionary<string, List<string>>();
        salesId.Add("salesId", new List<string> { "a2f80554-bd9d-4ea1-8229-01fd4cf220a8" });

        foreach (KeyValuePair<string, List<string>> kvp in salesId)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> salesAgent = new Dictionary<string, List<string>>();
        salesAgent.Add("salesAgent", new List<string> { });
        salesAgent.Add("mobile", new List<string> { "562.300.2912" });
        salesAgent.Add("lastName", new List<string> { "Davis" });
        salesAgent.Add("firstName", new List<string> { "Gerardo" });
        salesAgent.Add("emails", new List<string> { "girl70@hotmail.com", "jova43@gmail.com" });

        foreach (KeyValuePair<string, List<string>> kvp in salesAgent)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> purchaseDate = new Dictionary<string, List<string>>();
        purchaseDate.Add("purchaseDate", new List<string> { "2017-04-28" });

        foreach (KeyValuePair<string, List<string>> kvp in purchaseDate)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<double>> grossProfit = new Dictionary<string, List<double>>();
        grossProfit.Add("grossProfit", new List<double> { 156.02 });

        foreach (KeyValuePair<string, List<double>> kvp in grossProfit)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");

        Console.WriteLine(" ");

        Dictionary<string, List<string>> credit = new Dictionary<string, List<string>>();
        credit.Add("credit", new List<string> { });
        credit.Add("creditProvider", new List<string> { "PNC Financial Services" });
        credit.Add("account", new List<string> { "34578280562836" });

        foreach (KeyValuePair<string, List<string>> kvp in credit)
          Console.WriteLine($"{kvp.Key}: {String.Join(" ", kvp.Value)}");
      }
    }
  }
}



/* CONVERT THE JAVASCRIPT DATASTRUCTURE INTO DICTIONARIES AND LISTS IN C# */
// "vehicles": [
//     {
//         "vehicle": {
//             "year": 2008,
//             "model": "Damfresh",
//             "make": "Biotraxquote",
//             "color": "sky magenta"
//         },
//         "sales_id": "ecb1c841-1a43-4a7c-896e-712d2ec39c71",
//         "sales_agent": {
//             "mobile": "(896) 478-6975",
//             "last_name": "Botsford",
//             "first_name": "Shaina",
//             "emails": ["beatae_sonny@hotmail.com", "shaina@aol.com"]
//         },
//         "purchase_date": "2017-11-15",
//         "gross_profit": 871.26,
//         "credit": {
//             "credit_provider": "J.P.Morgan Chase & Co",
//             "account": "601109582720302"
//         }
//     },
//     {
//         "vehicle": {
//             "year": 2010,
//             "model": "Hotquadtrax",
//             "make": "Transtintechno",
//             "color": "robin egg blue"
//         },
//         "sales_id": "a2f80554-bd9d-4ea1-8229-01fd4cf220a8",
//         "sales_agent": {
//             "mobile": "562.300.2912",
//             "last_name": "Davis",
//             "first_name": "Gerardo",
//             "emails": ["girl70@hotmail.com", "jova43@gmail.com"]
//         },
//         "purchase_date": "2017-04-28",
//         "gross_profit": 156.02,
//         "credit": {
//             "credit_provider": "PNC Financial Services",
//             "account": "34578280562836"
//         }
//     }
// ]
