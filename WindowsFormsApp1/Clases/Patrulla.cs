using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    public class Patrulla
    {
        private int id;
        private double rnd;
        private int proxRotura;
        private int estado;
        private int diaRotura;


        public Patrulla(int id, Random random)
        {
            Estado = 0;
            ProxRotura = calcularProxRotura(0, random);
            this.Id = id;
            DiaRotura = 0;


        }

        //Getters y Setters
        public int Id { get => id; set => id = value; }
        public int ProxRotura { get => proxRotura; set => proxRotura = value; }
        public int Estado { get => estado; set => estado = value; }
        public double Rnd { get => rnd; set => rnd = value; }
        public int DiaRotura { get => diaRotura; set => diaRotura = value; }

        public int calcularProxRotura(int reloj, Random random)
        {
            int proxRotura;
            if (reloj == 0)
            {
                double rnd = Math.Truncate(100 * (random.NextDouble() * (1 - 0) + 0)) / 100;
                Rnd = rnd;
                proxRotura = (int)(rnd * (Form1.primeraRoturaSup + 1 - Form1.primeraRoturaInf) + Form1.primeraRoturaInf);
            }
            else
            {
                proxRotura = reloj + Form1.diasEntreServicios;
            }
            ProxRotura = proxRotura;
            return proxRotura;
        }


        public String getEstadoString()
        {
            switch (estado)
            {
                case 0:
                    return "En funcionamiento";
                case 1:
                    return "En cola";
                case 2:
                    return "En reparación";
                default:
                    return "";
            }
        }
        public void patrullaString()
        {
            Console.WriteLine("{Patrulla " + id.ToString() + ", Prox Rotura: " + proxRotura.ToString() + ", Estado: " + getEstadoString() + "}");
        }


    }
}
