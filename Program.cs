using System;

namespace P3_Tarea1
{
    class Program
    {
        //ANGEL E. REYNOSO DUARTE 2020-03508
        static void Main(string[] args)
        {
            claUapa profe1 = new claUapa();
            profe1.id = 1;
            profe1.nombre = "Pedro";
            profe1.apPaterno = "Rodriguez";
            profe1.cargo = "Maestro de Fisica";
            profe1.sueldo = 35000;

            Console.WriteLine( profe1.mostrarDatos());
            Console.ReadLine();
        }
    }
}
