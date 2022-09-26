namespace DotNetDockerPostgres.Data
{
    public class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ConversionRateDBContext>());
            }
        }

        private static void SeedData(ConversionRateDBContext context)
        {
            if (!context.Units.Any())
            {
                System.Console.WriteLine("Seeding data ...");
                context.Units.AddRange(
                    new Data.Unit()
                    {
                        MetricUnits = "centimetersToInches",
                        MetricValue = "2.54"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "inchesToCentimeteres",
                        MetricValue = "2.54"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "gramsToOunces",
                        MetricValue = "28.35"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "ouncesToGrams",
                        MetricValue = "28.35"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "litresToPints",
                        MetricValue = "1.76"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "pintsToLitres",
                        MetricValue = "1.76"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "CelsiusToFahrenheit",
                        MetricValue = "32"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "FahrenheitToCelsius",
                        MetricValue = "32"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "MilesToKilometer",
                        MetricValue = "1.609344"
                    },
                    new Data.Unit()
                    {
                        MetricUnits = "KilometerToMiles",
                        MetricValue = "1.6"
                    });
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data");
            }
        }
    }
}
