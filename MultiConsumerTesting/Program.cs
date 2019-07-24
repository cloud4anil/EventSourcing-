using Banking.Web.Models.DTO;
using Banking.Web.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MultiConsumerTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferService transferService = new TransferService(new System.Net.Http.HttpClient());

            TransferDto transferDto = new TransferDto();
            //transferDto.FromAccount = 1;
            //transferDto.ToAccount = 2;
            //transferDto.TeansferAmmount = 156; ;
            //transferService.Transfer(transferDto);

           Console.WriteLine(DateTime.Now);

           Parallel.ForEach(Enumerable.Range(1, 200), (index) =>
            {
              
                transferDto.AccountFrom = 1;
                transferDto.AccountTo = 2;
                transferDto.TransferAmmount = 1 + index;
                transferService.Transfer(transferDto);
            });



            //Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}
