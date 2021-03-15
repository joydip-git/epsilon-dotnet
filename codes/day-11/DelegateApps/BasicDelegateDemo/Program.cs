using System;

namespace BasicDelegateDemo
{
    //1. declaration of delegate
    //2. the declaration should have same signature of that of the function you are trying to invoke
    delegate void CalDel(int a, int b);
    delegate string OperationDel(string siteUrl);
    delegate void StatusDel(string result);

    class Program
    {
        static void Main()
        {


            //3. invoke the delegate to invoke the method(s)
            //calDelAdd.Invoke(12, 13);
            //or
            //calDelMulti(12, 13);

            Downloader downloader = new Downloader();
            //downloader.Download;
            OperationDel downloadDel = new OperationDel(downloader.Download);
            StatusDel successDel = new StatusDel(Program.NotifyOnSuccess);
            StatusDel failureDel = new StatusDel(Program.NotifyOnFailure);
            Operate(downloadDel, "http://www.google.com", successDel, failureDel);

            //2. creat an instance of the delegate
            Calculation calculation = new Calculation();
            //InvokeCalculationMethods(calculation);

            CalDel calDelAdd = new CalDel(calculation.Add);
            InvokeCalculationMethods(calDelAdd);

            CalDel calDelMulti = new CalDel(Calculation.Multiply);
            InvokeCalculationMethods(calDelMulti);
        }
        static void InvokeCalculationMethods(CalDel cd)//address to the function
        {
            //callback mechanism
            cd(12, 13);
        }

        static void Operate(OperationDel operationDel, string url, StatusDel success, StatusDel failure)
        {
            string data = operationDel(url);
            if (data != null && data != string.Empty)
            {
                success(data);
            }
            else
            {
                failure("could not get data...check the url");
            }
        }
        static void NotifyOnSuccess(string data)
        {
            Console.WriteLine(data);
        }
        static void NotifyOnFailure(string error)
        {
            Console.WriteLine(error);
        }
    }
}
