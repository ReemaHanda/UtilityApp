using System.Runtime.InteropServices.JavaScript;
using UtilityApp.Models;

namespace UtilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "", path = "";

            Common com = new Common();
            List<UserModel> userList = new List<UserModel>();
            try
            {
                userList = com.GetApiData();

                if(userList != null && userList.Count >0)
                {
                    Console.WriteLine("Enter Format: ");
                    format = Console.ReadLine();
                    Console.WriteLine("Enter path where to store: ");
                    path = Console.ReadLine();
                    com.GenerateFile(userList, path, format);

                    Console.WriteLine("Total Number of Users : " + userList.Count);
                    Console.WriteLine("File stored in UserFolder at the path provided by you. ");
                }
                else
                {
                    Console.WriteLine("No Data Found!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong :" + ex.Message);
            }
        }
    }
}
