using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWorkWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentBanks paymentBanks = new();
            //paymentBanks.GetNumberAccount();
            //paymentBanks.GetBalanceAccount();
            //paymentBanks.GetTypeAccount();
            paymentBanks.GetTransferMoney();
        }
    }        
    class PaymentBanks
    {
        int _FirstNumberAccount { get; set; }
        int _SecondNumberAccount { get; set; }
        int _BalanceAccount { get; set; }
        string _TypeAccount { get; set; }
        int _SumTransferMoney { get; set; }
        /// <summary>
        /// получение номера банковского счета
        /// </summary>
        /// <param name="numberAccount"></param>
        public void GetNumbersAccount(int firstNumberAccount)
        {
            _ = _FirstNumberAccount;
            
        }
        /// <summary>
        /// получение баланса счета
        /// </summary>
        /// <param name="balanceAccount"></param>
        public void GetBalanceAccount(int balanceAccount)
        {
            _ = _BalanceAccount;
        }
        /// <summary>
        /// получение типа банковского счета
        /// </summary>
        /// <param name="typeAccount"></param>
        public void GetTypeAccount(string typeAccount)
        {
            _ = _TypeAccount;
        }
        /// <summary>
        /// метод, который переводит деньги с одного счета на другой
        /// </summary>
        /// <param name="transferMoney"></param>
        public void GetTransferMoney()
        {
            int sumTransferMoney = _SumTransferMoney;
            int firstNumberAccount = _FirstNumberAccount;
            //int secondNumberAccount = _SecondNumberAccount;
            firstNumberAccount = 8696;
            PaymentBanks paymentBanks = new();
            paymentBanks.GetNumbersAccount(firstNumberAccount);

            
            sumTransferMoney = 3000000;
            Console.WriteLine("На счет {0} поступило {1} рублей",firstNumberAccount,sumTransferMoney);

        }
    }
}
/*1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой. 
 * У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма*/