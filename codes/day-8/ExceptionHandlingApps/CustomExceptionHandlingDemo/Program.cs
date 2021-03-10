using System;

namespace CustomExceptionHandlingDemo
{
    class Program
    {
        static void Main()
        {
            DrivingLicenseApplication drivingLicenseApplication = null;

            try
            {
                drivingLicenseApplication = new DrivingLicenseApplication();

                Console.Write("Name: ");
                drivingLicenseApplication.Name = Console.ReadLine();

                Console.Write("Age: ");
                drivingLicenseApplication.Age = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                DisplayError(ex);
            }
            catch (AgeLessThanEighteenException ex)
            {
                DisplayError(ex);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }

            //try
            //{
            //    try { } catch (Exception ex) { } finally { }
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{

            //}
        }
        static void DisplayError(Exception ex)
        {
            Console.WriteLine($"Exception Type: {ex.GetType().Name}");
            Console.WriteLine($"Message:{ex.Message}");
            Console.WriteLine($"Method:{ex.TargetSite}");
            Console.WriteLine($"Application:{ex.Source}");
            Console.WriteLine($"Details:{ex.StackTrace}");
        }
    }
}
