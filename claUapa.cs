using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Tarea1
{   //ANGEL E. REYNOSO DUARTE 2020-03508
    public class claUapa
    {
        public int id;
        public string nombre;
        public string apPaterno;
        public string cargo;
        public double sueldo;

        //METODO PARA MOSTRAR LOS DATOS 
        public string mostrarDatos()
        {
           return "ID: " +this.id+ "\nNombre y apellido: "+ this.nombre +" "
                   +this.apPaterno+"\nCargo: "+this.cargo +"\nSueldo: "+this.sueldo;
        } 
    }
}
