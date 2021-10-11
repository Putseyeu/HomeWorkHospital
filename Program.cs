using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int totalPeople;
            Console.Write("Введите кол-во старушек:");
            totalPeople = Convert.ToInt32(Console.ReadLine());

            int timeOnePatient = 10;
            int minutesPerHour = 60;

            int timeAllWaiting = totalPeople * timeOnePatient;
            int hourWaiting = timeAllWaiting / minutesPerHour;
            int minutesWaiting = timeAllWaiting % minutesPerHour;

            Console.Write($"Вы должны отстоять в очереди {hourWaiting} часа и {minutesWaiting} минут.");
        }
    }
}
