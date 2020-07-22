using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public class PuestoTaller
    {
        private int id;
        private int estado;
        private Patrulla patrulla;
        private int proxFinReparacion;
        private double rnd;
        private int tReparacion;


        public PuestoTaller(int id)
        {
            Id = id;
            Estado = 0;
            Patrulla = null;
            ProxFinReparacion = 0;
            Rnd = 0;
            TReparacion = 0;
        }

        public int Id { get => id; set => id = value; }
        public Patrulla Patrulla { get => patrulla; set => patrulla = value; }
        public int Estado { get => estado; set => estado = value; }
        public int ProxFinReparacion { get => proxFinReparacion; set => proxFinReparacion = value; }
        public double Rnd { get => rnd; set => rnd = value; }
        public int TReparacion { get => tReparacion; set => tReparacion = value; }

        public String getEstadoString()
        {
            switch (estado)
            {
                case 0:
                    return "Libre";
                case 1:
                    return "Ocupado";
                default:
                    return "";
            }
        }
        public int calcularProxFinReparacion(int reloj, Random random)
        {
            double rnd = Math.Truncate(100 * (random.NextDouble() * (1 - 0) + 0)) / 100;
            Rnd = rnd;
            int tReparacion = (int)(rnd * (Form1.tiempoReparacionSup + 1 - Form1.tiempoReparacionInf) + Form1.tiempoReparacionInf);
            TReparacion = tReparacion;
            proxFinReparacion = tReparacion + reloj;
            return proxFinReparacion;
        }

        public int getPatrulla()
        {
            return patrulla != null ? patrulla.Id : 0;

        }

        public void puestoString()
        {
            Console.WriteLine("{Puesto " + id.ToString() + ", Estado: " + getEstadoString() + ", ProxFinReparacion: " + proxFinReparacion + ", Patrulla: " + getPatrulla() + "}");
        }
    }
}
