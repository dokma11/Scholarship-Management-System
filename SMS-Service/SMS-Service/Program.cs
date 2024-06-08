using SMS_Service.Contract;
using System;
using System.ServiceModel;

namespace SMS_Service
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost studentHost = new ServiceHost(typeof(StudentContract)),
                              scholarshipHost = new ServiceHost(typeof(ScholarshipContract)),
                              scholarshipApplicationHost = new ServiceHost(typeof(ScholarshipApplicationContract)))
            {
                try
                {
                    studentHost.Open();
                    scholarshipHost.Open();
                    scholarshipApplicationHost.Open();

                    Console.WriteLine("Services are running...");
                    Console.WriteLine("Press Enter to terminate the services.");
                    Console.ReadLine();

                    studentHost.Close();
                    scholarshipHost.Close();
                    scholarshipApplicationHost.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

    }
}
