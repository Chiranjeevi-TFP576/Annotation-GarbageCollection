using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public class AnnotationTest
    {
        ///<summary>
        ///Display the instance.
        ///</summary>
        public static void Display()
        {
            Console.WriteLine("Employee Class Validation");
            Console.WriteLine("=========================");
            Employee employee = new Employee();
            employee.Name = "Chiranjeevi";
            employee.Age = 21;
            employee.PhoneNumber = "1234565";
            employee.EmailAddress = "Chiranjeevi@123gmail.com";

            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> resuls = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, resuls, true);
            ///conditions if the fields are not valid
            if (!valid)
            {
                ///foreach loop is used to transverse the data if error occour prints the error messege in different colours
                foreach (ValidationResult totalresult in resuls)
                {
                    Console.WriteLine("Member Name : {0}", totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg :: {0}", totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name :" + employee.Name + "\n" + "Age:" + employee.Age + "\n" + "PhnNumber:" + employee.PhoneNumber
                    + "\n" + "Email:" + employee.EmailAddress);
            }
            ///To print the console in our wish colour
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
