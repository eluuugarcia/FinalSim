using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Variables
        private int reloj = 0;
        private String evento = "Inicio";

        private int cantidadPatrullas;
        private int capacidadTaller;

        private Random random = new Random();

        private List<Patrulla> patrullas = new List<Patrulla>();

        //Patrullas ordenadas por prox rotura
        private List<Patrulla> patrullasOrdenadas = new List<Patrulla>();
        private List<Patrulla> cola = new List<Patrulla>();

        private List<PuestoTaller> puestosTaller = new List<PuestoTaller>();
        private List<PuestoTaller> puestosLibres = new List<PuestoTaller>();
        private List<PuestoTaller> puestosOcupados = new List<PuestoTaller>();

        private int patrullasEnCondiciones;
        private int acPatrullasEnCondiciones;
        private double promPatrullasEnCondiciones;
        private int tMaxPatrullaRota = 0;
        private int cantidadReparaciones = 0;
        private int tAcReparaciones = 0;
        private double promTReparacion;
        private int tiempoOciosoTaller = 0;
        private int colaMaxima = 0;




        private void consolePatrullasOrdenadas()
        {
            for (int i = 0; i < patrullasOrdenadas.Count; i++)
            {
                patrullasOrdenadas[i].patrullaString();
            }

        }

        private void crearPatrullas()
        {

            for (int i = 0; i < cantidadPatrullas; i++)
            {
                Patrulla patrulla = new Patrulla(i + 1, random);
                patrullas.Add(patrulla);
                if (patrullasOrdenadas.Count == 0)
                {
                    patrullasOrdenadas.Add(patrulla);

                }
                else if (patrulla.ProxRotura < patrullasOrdenadas[0].ProxRotura)
                {

                    patrullasOrdenadas.Insert(0, patrulla);
                }
                else if (patrulla.ProxRotura >= patrullasOrdenadas[i - 1].ProxRotura)
                {

                    patrullasOrdenadas.Add(patrulla);
                }
                else
                {

                    int index = 0;
                    for (int j = 0; j < patrullasOrdenadas.Count; j++)
                    {
                        if (patrulla.ProxRotura < patrullasOrdenadas[j].ProxRotura)
                        {
                            index = j;
                            break;
                        }
                    }

                    patrullasOrdenadas.Insert(index, patrulla);
                }
            }





        }

        private void crearPuestosTaller()
        {

            for (int i = 0; i < capacidadTaller; i++)
            {
                PuestoTaller puesto = new PuestoTaller(i + 1);
                puestosTaller.Add(puesto);
                puestosLibres.Add(puesto);
            }
        }




        private void renderPatrullas(int iteracion)
        {
            DataGridViewRow row = (DataGridViewRow)this.dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = iteracion;
            row.Cells[1].Value = evento;
            row.Cells[2].Value = reloj;

            for (int i = 3; i < patrullas.Count * 4 + 1; i += 4)
            {
                Patrulla patrulla = patrullas[i / 4];
                row.Cells[i].Value = patrulla.getEstadoString();
                row.Cells[i + 1].Value = patrulla.Rnd != 0 ? patrulla.Rnd.ToString() : "-";
                row.Cells[i + 2].Value = patrulla.ProxRotura != 0 ? "Día " + patrulla.ProxRotura : "-";
                row.Cells[i + 3].Value = patrulla.DiaRotura != 0 ? patrulla.DiaRotura.ToString() : "-";

            }
            this.dataGridView1.Rows.Add(row);

        }
        private void renderPuestos(int iteracion)
        {
            DataGridViewRow row = (DataGridViewRow)this.dataGridView3.Rows[0].Clone();
            row.Cells[0].Value = iteracion;
            row.Cells[1].Value = evento;
            row.Cells[1].Value = evento;
            row.Cells[2].Value = reloj;

            for (int i = 3; i < puestosTaller.Count * 5; i += 5)
            {
                PuestoTaller puesto = puestosTaller[i / 5];
                row.Cells[i].Value = puesto.getEstadoString();
                row.Cells[i + 1].Value = puesto.Rnd != 0 ? puesto.Rnd.ToString() : "-";
                row.Cells[i + 2].Value = puesto.TReparacion != 0 ? puesto.TReparacion.ToString() : "-";

                row.Cells[i + 3].Value = puesto.ProxFinReparacion == 0 ? "-" : "Día " + puesto.ProxFinReparacion;
                String patrulla = puesto.getPatrulla() != 0 ? "Patrulla " + puesto.getPatrulla().ToString() : "-";
                row.Cells[i + 4].Value = patrulla;


            }
            this.dataGridView3.Rows.Add(row);

        }

        private void renderVectorDeEstado(int iteracion)
        {
            DataGridViewRow row = (DataGridViewRow)this.dataGridView.Rows[0].Clone();


            row.Cells[0].Value = iteracion;
            row.Cells[1].Value = evento;
            row.Cells[2].Value = reloj;
            row.Cells[3].Value = "Día " + patrullasOrdenadas[0].ProxRotura;
            row.Cells[4].Value = "Patrulla " + patrullasOrdenadas[0].Id;

            row.Cells[5].Value = puestosOcupados.Count > 0 ? "Día " + puestosOcupados[0].ProxFinReparacion : "-";
            row.Cells[6].Value = puestosOcupados.Count > 0 ? "Puesto " + puestosOcupados[0].Id : "-";

            row.Cells[7].Value = cola.Count;
            row.Cells[8].Value = patrullasEnCondiciones;
            row.Cells[9].Value = acPatrullasEnCondiciones;
            row.Cells[10].Value = promPatrullasEnCondiciones;
            row.Cells[11].Value = tMaxPatrullaRota != 0 ? tMaxPatrullaRota.ToString() : "-";
            row.Cells[12].Value = cantidadReparaciones;
            row.Cells[13].Value = tAcReparaciones;
            row.Cells[14].Value = Math.Truncate(100 * promTReparacion) / 100;
            row.Cells[15].Value = tiempoOciosoTaller;
            row.Cells[16].Value = colaMaxima;


            this.dataGridView.Rows.Add(row);


        }
        private void ordenarPuestoOcupado(PuestoTaller puesto)
        {
            if (puestosOcupados.Count == 0 || puesto.ProxFinReparacion >= puestosOcupados[puestosOcupados.Count - 1].ProxFinReparacion)
            {
                puestosOcupados.Add(puesto);

            }
            else
            {

                for (int i = 0; i < puestosOcupados.Count; i++)
                {
                    if (puesto.ProxFinReparacion < puestosOcupados[i].ProxFinReparacion)
                    {
                        puestosOcupados.Insert(i, puesto);
                        break;

                    }

                }
            }
        }

        private void ocuparPuesto(PuestoTaller puesto, Patrulla patrulla)
        {
            patrulla.Estado = 2;
            patrulla.ProxRotura = 0;
            patrulla.Rnd = 0;

            int finReparacion = puesto.calcularProxFinReparacion(reloj, random);
            puesto.Estado = 1;
            puesto.Patrulla = patrulla;
            ordenarPuestoOcupado(puesto);

        }

        private void liberarPatrulla(Patrulla patrulla)
        {
            patrulla.Estado = 0;
            patrulla.calcularProxRotura(reloj, random);
            patrullasOrdenadas.Add(patrulla);
            int tiempoRota = reloj - patrulla.DiaRotura;
            if (tMaxPatrullaRota == 0 || tiempoRota > tMaxPatrullaRota)
            {
                tMaxPatrullaRota = tiempoRota;
            }
            cantidadReparaciones++;
            tAcReparaciones += tiempoRota;
            promTReparacion = (double)tAcReparaciones / cantidadReparaciones;
            patrulla.DiaRotura = 0;
        }
        private void liberarPuesto(PuestoTaller puesto)
        {
            puesto.Estado = 0;
            puesto.ProxFinReparacion = 0;
            puesto.Patrulla = null;
            puestosLibres.Add(puesto);
        }
        private void eventoFinReparacion()
        {
            reloj = puestosOcupados[0].ProxFinReparacion;
            evento = "Fin reparación";
            PuestoTaller puestoDesocupado = puestosOcupados[0];
            Patrulla patrullaRecuperada = puestoDesocupado.Patrulla;
            liberarPatrulla(patrullaRecuperada);

            puestosOcupados.RemoveAt(0);

            //Si hay cola
            if (cola.Count > 0)
            {

                ocuparPuesto(puestoDesocupado, cola[0]);
                cola.RemoveAt(0);
            }
            //Si no hay cola
            else
            {
                liberarPuesto(puestoDesocupado);
            }


        }
        private void eventoLlegaPatrulla()
        {
            reloj = patrullasOrdenadas[0].ProxRotura;
            evento = "Rotura patrulla";
            Patrulla patrulla = patrullasOrdenadas[0];
            patrullasOrdenadas.RemoveAt(0);
            patrulla.DiaRotura = reloj;

            //Si hay puestos libres
            if (puestosLibres.Count > 0)
            {

                PuestoTaller puesto = puestosLibres[0];
                ocuparPuesto(puesto, patrulla);
                puestosLibres.RemoveAt(0);
            }
            //Si no hay puestos libres
            else
            {
                patrulla.Estado = 1;
                patrulla.ProxRotura = 0;
                cola.Add(patrulla);
                if (colaMaxima == 0 || cola.Count > colaMaxima)
                {
                    colaMaxima = cola.Count;
                }
            }
        }

        private void consignas(int proxDia)
        {

            if (reloj != 0 & reloj != proxDia)
            {
                patrullasEnCondiciones = patrullasOrdenadas.Count;
                acPatrullasEnCondiciones = acPatrullasEnCondiciones + patrullasEnCondiciones;
                promPatrullasEnCondiciones = Math.Truncate((double)acPatrullasEnCondiciones / proxDia * 100) / 100;
                tiempoOciosoTaller += puestosLibres.Count;

            }
        }
        private void proximoEvento()
        {
            int proxEvento = reloj;
            if (puestosOcupados.Count == 0 || patrullasOrdenadas[0].ProxRotura <= puestosOcupados[0].ProxFinReparacion)
            {
                //Sigue una patrulla rota
                proxEvento = patrullasOrdenadas[0].ProxRotura;
                consignas(proxEvento);
                eventoLlegaPatrulla();

            }
            else
            {
                //Sigue un fin reparacion
                proxEvento = puestosOcupados[0].ProxFinReparacion;
                consignas(proxEvento);

                eventoFinReparacion();
            }







        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cantidadPatrullas = Form1.cantidadPatrullas;
            capacidadTaller = Form1.capacidadTaller;
            int diasEntreServicios = Form1.diasEntreServicios;
            int tiempoReparacionInf = Form1.tiempoReparacionInf;
            int tiempoReparacionSup = Form1.tiempoReparacionSup;
            int primeraReparacionInf = Form1.primeraRoturaInf;
            int primeraReparacionSup = Form1.primeraRoturaSup;
            int cantDiasSimulacion = Form1.cantDiasSimulacion;
            int cantIteraciones = Form1.cantIteraciones;
            int diaInicio = Form1.diaInicio;
            bool mostrarPatrullas = Form1.mostrarPatrullas;

            patrullasEnCondiciones = cantidadPatrullas;
            acPatrullasEnCondiciones = cantidadPatrullas;
            promPatrullasEnCondiciones = cantidadPatrullas;



            crearPatrullas();
            //consolePatrullasOrdenadas();
            crearColumnasPatrullas();
            crearColumnasPuestos();
            crearPuestosTaller();


            int iteracion = 0;
            int diaInicioRender = 0;

            //renderPatrullas(0);
            //renderVectorDeEstado(0);
            //renderPuestos(0);

            while (reloj <= cantDiasSimulacion)
            {
                //Console.WriteLine("reloj " + reloj);
                //Console.WriteLine("iteracion " + iteracion);
                //Console.WriteLine("diaInicio" + diaInicio);
                //Console.WriteLine("cantIteraciones: " + cantIteraciones);
                //Console.WriteLine("diaInicioRender: " + diaInicioRender);

                if ((reloj >= diaInicio & diaInicioRender <= cantIteraciones))
                {
                    renderPatrullas(diaInicioRender);
                    renderVectorDeEstado(diaInicioRender);
                    renderPuestos(diaInicioRender);
                    diaInicioRender++;
                }
                
                proximoEvento();
             
                iteracion++;
            }

            DataGridViewRow row = (DataGridViewRow)this.dataGridView.Rows[0].Clone();
            DataGridViewRow row1 = (DataGridViewRow)this.dataGridView1.Rows[0].Clone();
            DataGridViewRow row2 = (DataGridViewRow)this.dataGridView3.Rows[0].Clone();

            dataGridView.Rows.Add(row);
            dataGridView1.Rows.Add(row1);
            dataGridView3.Rows.Add(row2);

            renderPatrullas(iteracion);
            renderVectorDeEstado(iteracion);
            renderPuestos(iteracion);

            if (!mostrarPatrullas)
            {

                this.dataGridView1.Hide();
            }





        }


        //Columnas Tabla Patrullas

        private void crearColumnasPatrullas()
        {
            //dataGridView.RowHeadersVisible = false;
            //dataGridView1.RowHeadersVisible = false;
            //dataGridView3.RowHeadersVisible = false;

            this.dataGridView1.Columns.Add("Id3", "#");
            this.dataGridView1.Columns.Add("Evento3", "Evento");
            this.dataGridView1.Columns.Add("Reloj3", "Reloj (días)");


            for (int i = 0; i < cantidadPatrullas; i++)
            {
                this.dataGridView1.Columns.Add("Estado" + (i + 1), "Estado");
                this.dataGridView1.Columns.Add("RNDProxRotura" + (i + 1), "RND Próx Rotura");
                this.dataGridView1.Columns.Add("ProxRotura" + (i + 1), "Próx Rotura");
                this.dataGridView1.Columns.Add("DRotura" + (i + 1), "Día rotura");



            }
            for (int j = 0; j < this.dataGridView1.ColumnCount; j++)
            {
                this.dataGridView1.Columns[j].Width = 80;
            }

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 4;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);

            this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);



            this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

            this.dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);


        }
        void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)

        {

            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;

            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 4;

            this.dataGridView1.Invalidate(rtHeader);

        }
        void dataGridView1_Scroll(object sender, ScrollEventArgs e)

        {

            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;

            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 4;

            this.dataGridView1.Invalidate(rtHeader);

        }
        void dataGridView1_Paint(object sender, PaintEventArgs e)

        {

            for (int j = 3; j < cantidadPatrullas * 4 + 2;)

            {
                Rectangle r1 = this.dataGridView1.GetCellDisplayRectangle(j, -1, true);

                int w2 = this.dataGridView1.GetCellDisplayRectangle(j + 1, -1, true).Width;
                int w3 = this.dataGridView1.GetCellDisplayRectangle(j + 2, -1, true).Width;
                int w4 = this.dataGridView1.GetCellDisplayRectangle(j + 3, -1, true).Width;


                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 + w3 + w4 - 4;
                r1.Height = r1.Height / 4 - 4;

                e.Graphics.FillRectangle(new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor), r1);

                StringFormat format = new StringFormat();

                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString("Patrulla " + ((j / 4 + 1)),

                    this.dataGridView1.ColumnHeadersDefaultCellStyle.Font,

                    new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),

                    r1,

                    format);

                j += 4;

            }



        }
        void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)

        {
            //if (e.RowIndex == -1 && e.ColumnIndex > -1)
            //{
            //    Rectangle r2 = e.CellBounds;
            //    r2.Y += e.CellBounds.Height / 2;
            //    r2.Height = e.CellBounds.Height / 2;
            //    e.PaintBackground(r2, true);
            //    e.PaintContent(r2);
            //    e.Handled = true;
            //}

        }


        //Columnas Tabla Puestos Taller 

        private void crearColumnasPuestos()
        {

            this.dataGridView3.Columns.Add("Id4", "#");
            this.dataGridView3.Columns.Add("Evento4", "Evento");
            this.dataGridView3.Columns.Add("Reloj4", "Reloj (días)");

            for (int i = 0; i < capacidadTaller; i++)
            {
                this.dataGridView3.Columns.Add("EstadoPuesto" + (i + 1), "Estado");
                this.dataGridView3.Columns.Add("FinReparacion" + (i + 1), "RND reparación");
                this.dataGridView3.Columns.Add("FinReparacion" + (i + 1), "T. de reparación");
                this.dataGridView3.Columns.Add("FinReparacion" + (i + 1), "Fin reparación");
                this.dataGridView3.Columns.Add("IDPatrulla" + (i + 1), "Patrulla");

            }
            for (int j = 0; j < this.dataGridView3.ColumnCount; j++)
            {
                this.dataGridView3.Columns[j].Width = 80;
            }

            this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dataGridView3.ColumnHeadersHeight = this.dataGridView3.ColumnHeadersHeight * 5;

            this.dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            this.dataGridView3.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView3_CellPainting);

            this.dataGridView3.Paint += new PaintEventHandler(dataGridView3_Paint);



            this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);

            this.dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);


        }

        void dataGridView3_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)

        {

            Rectangle rtHeader = this.dataGridView3.DisplayRectangle;

            rtHeader.Height = this.dataGridView3.ColumnHeadersHeight / 5;

            this.dataGridView3.Invalidate(rtHeader);

        }
        void dataGridView3_Scroll(object sender, ScrollEventArgs e)

        {

            Rectangle rtHeader = this.dataGridView3.DisplayRectangle;

            rtHeader.Height = this.dataGridView3.ColumnHeadersHeight / 5;

            this.dataGridView3.Invalidate(rtHeader);

        }
        void dataGridView3_Paint(object sender, PaintEventArgs e)

        {


            for (int j = 3; j < capacidadTaller * 5 + 2;)

            {

                Rectangle r1 = this.dataGridView3.GetCellDisplayRectangle(j, -1, true);

                int w2 = this.dataGridView3.GetCellDisplayRectangle(j + 1, -1, true).Width;

                int w3 = this.dataGridView3.GetCellDisplayRectangle(j + 2, -1, true).Width;
                int w4 = this.dataGridView3.GetCellDisplayRectangle(j + 3, -1, true).Width;
                int w5 = this.dataGridView3.GetCellDisplayRectangle(j + 4, -1, true).Width;


                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + w2 + w3 + w4 + w5 - 3;
                r1.Height = r1.Height / 5 - 5;

                e.Graphics.FillRectangle(new SolidBrush(this.dataGridView3.ColumnHeadersDefaultCellStyle.BackColor), r1);

                StringFormat format = new StringFormat();

                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString("Puesto " + (j / 5 + 1),

                    this.dataGridView3.ColumnHeadersDefaultCellStyle.Font,

                    new SolidBrush(this.dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor),

                    r1,

                    format);

                j += 5;

            }



        }
        void dataGridView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)

        {


        }


    }
}
