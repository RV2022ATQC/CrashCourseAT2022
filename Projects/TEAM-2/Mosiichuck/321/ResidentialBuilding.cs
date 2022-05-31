using System;
using System.Globalization;

namespace _321
{
    public class ResidentialBuilding : Building
    {
        private int numberOfApartments;
        private double dwellingPlace;
        private int numberOfFlors;
        public double DwellingPlace
        {
            get
            {
                return dwellingPlace;
            }
            set
            {
                if (value > 0)
                    dwellingPlace = value;
                else
                    dwellingPlace = 0;
            }
        }
        public int NumberOfApartments
        {
            get
            {
                return numberOfApartments;
            }
            set
            {
                if (value > 0)
                    numberOfApartments = value;
                else
                    numberOfApartments = 0;
            }
        }
        public int NumberOfFlors
        {
            get
            {
                return numberOfFlors;
            }
            set
            {
                if (value > 0)
                    numberOfFlors = value;
                else
                    numberOfFlors = 0;
            }
        }

        public ResidentialBuilding(string address, string dateOfCommissioning, double dwellingPlace, int numberOfApartments, int numberOfFlors) : base(address, dateOfCommissioning)
        {
            DwellingPlace = dwellingPlace;
            NumberOfApartments = numberOfApartments;
            NumberOfFlors = numberOfFlors;
        }
        public ResidentialBuilding() : base()
        {
            DwellingPlace = 0;
            NumberOfApartments = 0;
            NumberOfFlors = 0;
        }

        public override void Input()
        {
            try
            {
                Console.Write("Enter address: ");
                Address = Console.ReadLine();

                Console.Write("Enter date of commissioning: ");
                DateOfCommissioning = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter number of flors: ");
                NumberOfFlors = Int32.Parse(Console.ReadLine());

                Console.Write("Enter number of apartmens: ");
                NumberOfApartments = Int32.Parse(Console.ReadLine());


                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = ",";
                Console.Write("Enter dwelling place: ");
                DwellingPlace = Convert.ToDouble(Console.ReadLine(), provider);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.WriteLine();
        }

        public override void Output()
        {
            Console.WriteLine($"Building was created in {DateOfCommissioning.ToString("dd.MM.yyyy")} at address {Address}. It has {NumberOfFlors} floors, with {NumberOfApartments} total number of apartments, dwelling place of each is {DwellingPlace} m^2");
        }
    }
}
