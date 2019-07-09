using System;
using System.Collections.Generic;

namespace randall_car_lot_csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            {   //VEHICLES
                Console.WriteLine("Vehicles:");
                Console.WriteLine("");
                {
                    //Vehicle
                    Console.WriteLine("vehicle:");
                    Console.WriteLine("");
                    Dictionary<string, string> vehicle = new Dictionary<string, string>() {
                    {"year", "2008"},
                    {"model", "damfresh"},
                    {"make", "Biotraxquote"},
                    {"color", "sky magenta"}
                };
                    foreach (KeyValuePair<string, string> item in vehicle)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                    //Sales Agent
                    Console.WriteLine("salesAgent:");
                    Console.WriteLine("");
                    Dictionary<string, string> salesAgent = new Dictionary<string, string>() {
                    {"mobile", "(896) 478-6975"},
                    {"lastName", "damfresh"},
                    {"firstName", "Biotraxquote"}
                };
                    foreach (KeyValuePair<string, string> kvp in salesAgent)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }

                    //Credit
                    Console.WriteLine("credit:");
                    Console.WriteLine("");
                    Dictionary<string, string> credit = new Dictionary<string, string>(){
                    {"credit_provider", "J.P.Morgan Chase & Co" },
                    {"account", "601109582720302"}
                };
                    foreach (KeyValuePair<string, string> kvp in credit)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
                {
                    //Vehicle
                    Console.WriteLine("vehicle:");
                    Console.WriteLine("");
                    Dictionary<string, string> vehicle = new Dictionary<string, string>() {
                    {"year", "2010"},
                    {"model", "Hotquadtrax"},
                    {"make", "Transtintechno"},
                    {"color", "robin egg blue"}
                };
                    foreach (KeyValuePair<string, string> item in vehicle)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                    //Sales Agent
                    Console.WriteLine("salesAgent:");
                    Console.WriteLine("");
                    Dictionary<string, string> salesAgent = new Dictionary<string, string>() {
                    {"mobile", "562.300.2912"},
                    {"lastName", "Davis"},
                    {"firstName", "Gerardo"}
                };
                    foreach (KeyValuePair<string, string> kvp in salesAgent)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }

                    //Credit
                    Console.WriteLine("credit:");
                    Console.WriteLine("");
                    Dictionary<string, string> credit = new Dictionary<string, string>(){
                    {"credit_provider", "PNC Financial Services" },
                    {"account", "34578280562836"}
                };
                    foreach (KeyValuePair<string, string> kvp in credit)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
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
