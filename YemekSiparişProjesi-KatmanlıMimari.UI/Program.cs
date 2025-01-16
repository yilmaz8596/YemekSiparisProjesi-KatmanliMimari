using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;

namespace YemekSiparişProjesi_KatmanlıMimari.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Custom setup for dependencies and logging
            try
            {
                // Perform application setup
                InitializeApplication();
                Application.EnableVisualStyles();


                // Start the application
                //Application.Run(new Register());
                Application.Run(new Main1());
            }
            catch (Exception ex)
            {
                // Log the exception and show an error message
                Console.WriteLine($"Application error: {ex.Message}");
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void InitializeApplication()
        {
            // Example: Test the database connection
            using (var dbContext = new ApplicationDBContext())
            {
                if (!dbContext.Database.CanConnect())
                {
                    throw new InvalidOperationException("Unable to connect to the database. Please check your connection string.");
                }
            }

            // Any additional application-level initialization can go here
            Console.WriteLine("Application initialized successfully.");
        }
    }
}
