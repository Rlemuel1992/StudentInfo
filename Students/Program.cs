using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
	class Program
	{
		static void Main()
		{


			List<string> students = new List<string>
			{
				"1. Jim", "2. Sarah", "3. Jerry",
				"4. Kyle", "5. Erica", "6. Kim",
				"7. Joey", "8. Andrew", "9. Mike",
				"10. Ashley", "11. Carl", "12. Courtney",
				"13. Quinton", "14. Jayson", "15. Christine"

			};

			List<string> favFoods = new List<string>
			{
				"Coney Dogs", "Kale Shakes", "Ribs",
				"BLT", "Hamburgers", "Cookies and Cream ice cream",
				"pop rocks", "Vitners hot chips", "Italian Sausage",
				"Brautwurst", "spanish peanuts", "pork roast",
				"Steak", "chicken nuggets", "Turkey"

			};

			List<string> homeTown = new List<string>
			{
				"Detroit", "Rochester", "Detroit",
				"Riverview", "Wyandotte", "Saginaw",
				"Detroit", "Chicago", "New York",
				"Lincoln Park", "Miami", "Fayetteville",
				"Detroit", "Woodhaven", "Monroe"

			};

			foreach (string i in students)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Chose someone from the list above to learn more about them!");
			
			bool choicesName = true;
			int numInput = 0;
			string userInput; 
			while (choicesName == true)
			{
				userInput = Console.ReadLine();

				int.TryParse(userInput, out numInput);

				if (numInput < 1 || numInput > 15)
				{
					Console.WriteLine("Wrong choice, please chose from 1-15");
					choicesName = true;

				}

				else 
				{
					
						Console.WriteLine("You picked " + students[numInput - 1]);
						choicesName = false;
				}

			}

				Console.WriteLine("Would you like to know about their hometown, or favorite food? " +
								  "type 'food' or 'hometown'");

				bool run = true;
				while (run == true)
				{

					string input = Console.ReadLine().ToLower();

				if (input == "food")
				{
					Console.WriteLine("Their favorite food is " + favFoods[numInput - 1]);
					run = false;
					Console.WriteLine("Would you like to know about their hometown? 'y' or 'n'");
					bool foodRun = true;
					while (foodRun == true)
					{

						string cont = Console.ReadLine().ToLower();
						if (cont == "y")
						{
							Console.WriteLine("They were raised in " + homeTown[numInput - 1]);
							foodRun = false;
							Again();
						}
						else if (cont == "n")
						{
							foodRun = false;
							Again();
						}
						else
						{
							Console.WriteLine("I didn't understand, can you try again?");
							foodRun = true;
						}

					}
				}
				else if (input == "hometown")
				{
					Console.WriteLine("They were raised in " + homeTown[numInput - 1]);
					run = false;
					Console.WriteLine("Would you like to know about their favorite food? 'y' or 'n'");
					bool homeRun = true;
					while (homeRun == true)
					{

						string cont = Console.ReadLine().ToLower();
						if (cont == "y")
						{
							Console.WriteLine("Their favorite food is " + favFoods[numInput - 1]);
							homeRun = false;
							Again();
						}
						else if (cont == "n")
						{
							homeRun = false;
							Again();
						}
						else
						{
							Console.WriteLine("I didn't understand, can you try again?");
							homeRun = true;
						}
					}
				}

				else
				{
					Console.WriteLine("I didn't catch that, try again 'food' or 'hometown'");
					run = true;
				}
				}
			
	

		}



		public static void Again()
		{
			Console.WriteLine("Would you like to learn about another person? 'y' or 'n'");
			string finalInput = Console.ReadLine().ToLower();

			if (finalInput == "y")
			{
				Main();
			}

			else if (finalInput == "n")
			{
				Console.WriteLine("Alright, goodbye!");
				Console.Beep();
				Console.Beep();
				Environment.Exit(1);
			}
			else
				Console.WriteLine("Sorry didn't catch that, try again.");
			Again();
		}
	}
}
