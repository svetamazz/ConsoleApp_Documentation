using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Documentation
{
    /// <summary>
    /// My Logic Class with some methods
    /// </summary>
    public class Logic
    {
        /// <summary>
        /// This is my property
        /// </summary>
        public int MyProperty { get; set; }

        /// <summary>
        /// This method check param for current year
        /// <para> Second Paragraph</para>
        /// <para> Last Paragraph</para>
        /// </summary>
        /// <param name="year">Integer value for year</param>
        /// <param name="month">Integer value for month</param>
        /// <exception cref="ArgumentOutOfRangeException">Якщо дані під рік та місяць від'ємні</exception>
        /// <seealso cref="Console"/>
        /// <returns>True if year is year is current, False if not</returns>
        public bool checkYear(int year,int month)
        {
            return year == DateTime.Now.Year && month==DateTime.Now.Month;
        }
        /// <summary>
        /// This method performs division
        /// </summary>
        /// <param name="x">Integer value for x(divider)</param>
        /// <param name="y">Integer value for y(dividend)</param>
        /// <exception cref="ArgumentException">If y(dividend) = 0</exception>
        /// <returns>Result of division</returns>
        public double division(int x,int y)
        {
            if (y == 0) throw new ArgumentException("Can't divite on 0.");

            return x / y;
        }
    }
}
