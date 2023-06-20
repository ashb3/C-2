using System;

namespace CSharpAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Repository<User> userRepository = new Repository<User>();
            string addUser = userRepository.Add(new User());
            Console.WriteLine(addUser);

            string updateUser = userRepository.Update(new User());
            Console.WriteLine(updateUser);

            string deleteUser = userRepository.Delete(new User());
            Console.WriteLine(deleteUser);

            string getallUser = userRepository.GetAll();
            Console.WriteLine(getallUser);

         
        }
    }
}