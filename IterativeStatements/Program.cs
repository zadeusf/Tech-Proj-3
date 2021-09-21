using System;

namespace IterativeStatements
{
	public class Program
	{
		public static void Main()
		{

			//we will just init this so we can use it in the loop
			double miles;
			int userInput = 0;

			// Get user input for increment value, must be between 10 and 25. Loop if not within 10-25.
			// Grab user input inside the conditional of the if loop using Console.ReadLine()
			//int.Try Parse will cast string as an int, if successful will put value inside userInput
			// Checks to see if the value is less thant 10 or greater than 25, and if so will keep looping until value is valid
			while (userInput >= 25 || userInput <= 10)
			{
				Console.Write("Please enter an increment value between 10 and 25:");


				if (!int.TryParse(Console.ReadLine(), out userInput) || (userInput < 10 || userInput > 25))

					
				{
					Console.WriteLine("The value must be an integer between 10 and 25, try again: ");
					//Users can determine if they want to input another grade.

				}
				else
				{

					Console.WriteLine("KM\tMi");
					//loop from 0 to 200, incrementing by 10 each time
					for (int i = 0; i <= 200; i += userInput)
					{
						//convert km to mi, 1 km=0.6214 miles, save it in our variable we initialized earlier
						miles = i * 0.621371;

						//now we print out the row, since we have both km (our I value) and our miles conversion (in the "miles" variable)
						Console.WriteLine(i + "\t" + miles);
					}

					}

				}		
			}
		}
	}

