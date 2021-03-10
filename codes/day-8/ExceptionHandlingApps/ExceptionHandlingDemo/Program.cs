using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static int Multiply(int a, int b)
        {
            return (a * b);
        }
        static int Divide()
        {
            int a = 10;
            int b = 0;
            int res = 0;
            try
            {
                res = a / b;
                return res;
            }
            catch(DivideByZeroException ex)
            {
                Logger.LogError(ex, DateTime.Now);
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        static void Main()
        {
            //Console.WriteLine(Multiply(2,3));
           

            //public void TryToFindError()
            try
            {
                //local to the try block, can't access "res" outside try block
                //int res = 0;
                Divide();           
            }
            //public void CatchExceptionReference(DivideByZeroException ex)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"Message: {ex.Message}");
            //    Console.WriteLine($"Method: {ex.TargetSite}");
            //    Console.WriteLine($"Source: {ex.Source}");
            //    Console.WriteLine($"Details: {ex.StackTrace}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Message: {ex.Message}");
            //    Console.WriteLine($"Method: {ex.TargetSite}");
            //    Console.WriteLine($"Source: {ex.Source}");
            //    Console.WriteLine($"Details: {ex.StackTrace}");
            //}
            //public void CatchExceptionReference(Exception ex)
            catch (Exception ex)
            {
                //if(ex is DivideByZeroException)
                //{
                //    DivideByZeroException dex = ex as DivideByZeroException;

                //}
                Console.WriteLine($"Actual Exception Type: {ex.GetType().Name}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            //public void FinallyExecute()
            finally
            {
                Console.WriteLine(res);
                //close database or file connection
            }
        }
    }
}
