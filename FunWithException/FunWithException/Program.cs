using FunWithException.Infrastructure;
using FunWithException.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    RangeArray range1 = new RangeArray(-5, 5);
                    RangeArray range2 = new RangeArray(1, 10);

                    for (int i = -5; i < 5; i++)
                    {
                        range1[i] = i;
                    }

                    int div = 0;
                    int divResult = 10 / div;

                    for (int i = 1; i < 10; i++)
                    {
                        range2[i] = i;
                    }

                    var result = range1;

                    foreach (var item in result)
                    {
                        Console.WriteLine(item);
                    }


                    RangeArray exceptionRange = new RangeArray(12, 2);
                }
                catch (CustomRangeArrayException exception)
                {
                    Console.WriteLine($"Class defining member: {exception.TargetSite.DeclaringType}");
                    Console.WriteLine($"Member Name: {exception.TargetSite}");
                    Console.WriteLine($"Message: {exception.Message}");
                    Console.WriteLine($"Source {exception.Source}");
                    throw;
                }
                catch (DivideByZeroException exception)
                {
                    Console.WriteLine($"Class defining member: {exception.TargetSite.DeclaringType}");
                    Console.WriteLine($"Member Name: {exception.TargetSite}");
                    Console.WriteLine($"Message: {exception.Message}");
                    Console.WriteLine($"Source {exception.Source}");
                    throw;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("sadfsdfsad");                
            }
            
            finally
            {
                Console.WriteLine("This is finally block");
            }
            #region
            //RangeArray rangeArray = new RangeArray(-5, 5);

            //for (int i = -5; i < rangeArray.LengthForLoop; i++)
            //{
            //    rangeArray[i] = i;
            //}
            //foreach (var item in rangeArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
