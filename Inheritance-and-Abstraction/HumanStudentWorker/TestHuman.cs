using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class TestHuman
    {
        public static void Main()
        {
            Student ani = new Student("Ani", "Angelova", "2134OP");
            Student hari = new Student("Hari", "Peshov", "TO90KL");
            Student kiro = new Student("Kiril", "Atanasov", "974OP");
            Student pesho = new Student("Petar", "Kirkov", "674PIP");
            Student tania = new Student("Tania", "Angelova", "9134OI");
            Student harlapmpi = new Student("Halampir", "Kirkov", "T876KL");
            Student atanas = new Student("Atanas", "Adimov", "2344OP");
            Student krasimir = new Student("Krasimir", "Ivanov", "POL4PIP");
            Student spiro = new Student("Spiridon", "Atanasov", "754OP");
            Student masha = new Student("Masha", "Anova", "ABPIP");

            List<Student> Students = new List<Student>(){
                ani,
                hari,
                kiro,
                pesho,
                tania,
                harlapmpi,
                atanas, 
                krasimir,
                spiro, 
                masha};

            var sortStudents = from st in Students
                               orderby st.FacultyNumber ascending
                               select st;
            Console.WriteLine("Sorted  students by fac numberulty in ascending order:" + "\n");
            foreach (var item in sortStudents)
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            Worker anichka = new Worker("Anichka", "Angelova", 2000, 8);
            Worker andrey = new Worker("Andrey", "Vasilev", 500, 4);
            Worker kifla = new Worker("Kifla", "Stoyanova", 1000, 10);
            Worker vesko = new Worker("Veselin", "Kovachev", 2000, 4);
            Worker deian = new Worker("Danail", "Dirovmit", 1500, 8);
            Worker stoyan = new Worker("Stoyan", "Stoyanov", 1000, 10);
            Worker menda = new Worker("Menda", "Stoyanova", 100, 2);
            Worker kiril = new Worker("Kiril", "Spasov", 1800, 4);
            Worker petko = new Worker("Petko", "Petkov", 1200, 8);
            Worker gosho = new Worker("George", "Lilov", 1400, 10);

            List<Worker> Workers = new List<Worker>(){
                anichka,
                andrey,
                kifla,
                vesko,
                deian,
                stoyan,
                menda,
                kiril,
                petko,
                gosho
            };
            var sortedWorkers =
                from worker in Workers
                orderby worker.MoneyPerHour(4) descending
                select worker;
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + string.Format(", hourly rate: {0:N2}", worker.MoneyPerHour(4) + "\n"));
            }
            Console.WriteLine("\nSorted Humans: ");
            List<Human> humans = new List<Human>();
            humans.AddRange(Students);
            humans.AddRange(Workers);

            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
