using Animals;
using DataAccess;
using Employees;
using Logic.Interfaces;

namespace Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IAnimal animalRepository = new AnimalRepository();
            ILocation locationRepository = new LocationRepository();
            Application.Run(new Login());
        }
    }
}