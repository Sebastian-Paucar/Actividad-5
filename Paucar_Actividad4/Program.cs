using System;

namespace Paucar_Actividad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;
            string name;
            string departamento;

            // Empleado
            Console.WriteLine("Ingres el nombre del Empleado:");
            name = Console.ReadLine();
            Console.WriteLine("Ingres el salario Mensual del empleado:");
            salary = Convert.ToDouble(Console.ReadLine());
            Empleado empleado = new Empleado(name, salary);

            // Gerente
            Console.WriteLine("\nIngres el nombre del Gerente:");
            name = Console.ReadLine();
            Console.WriteLine("Ingres el salario Mensual del Gerente:");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingres el nombre del Departamento:");
            departamento = Console.ReadLine();
            Gerente gerente = new Gerente(name, salary, departamento);
            MostrarInformacionEmpleado(empleado);
            MostrarInformacionEmpleado(gerente);
        }
        static void MostrarInformacionEmpleado(IMostrarInformacion empleado)
        {
            empleado.MostrarInformacion();
        }
    }
    // Clase Interfase
    interface IMostrarInformacion
    {
        void MostrarInformacion();
    }
    // Clase Empleado
    public class Empleado : IMostrarInformacion
    {
        public Empleado()
        {
        }

        public Empleado(string name, double monthSalary)
        {
            Name = name;
            MonthSalary = monthSalary;
        }

        public string Name { get; set; }
        public double MonthSalary { get; set; }

        public double GetMonthSalary()
        {
            return MonthSalary;
        }

        public double SalaryCalculation(double monthSalary)
        {
            return monthSalary * 12;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0} Salario: {1}", Name, SalaryCalculation(GetMonthSalary()));
        }
    }
    // Clase Gerente
    public class Gerente : Empleado, IMostrarInformacion
    {
        public Gerente(string name, double salary, string departament) : base(name, salary)
        {
            this.Departament = departament;
        }

        public string Departament { get; set; }

        public new void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0} Departamento: {1} Salario: {2}", Name, Departament, SalaryCalculation(GetMonthSalary()));
        }
    }
}
