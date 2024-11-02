using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.WindowsForms;
using NCalc;
using System.Windows.Forms;
using OxyPlot.Series;
using OxyPlot;
using System.Text.RegularExpressions;

namespace Parcial_2
{
    internal class funciones
    {
        private int a, b, c;
        public void asignarValores(int a, int b, int c) {
            this.a = a; this.b = b; this.c = c;
        }

        public PlotView graficarF(PlotView p) {
            double y;
            double x;
            string funcion= $"{a}*Pow(x,2) + {b}*x + {c}", fun1 = $"{a}*x^2 + {b}*x + {c}";//en esta variable guardo la funcion para imprimirla
            //valida que esta la funcion bien escrita
            if (string.IsNullOrWhiteSpace(funcion))
            {
                MessageBox.Show("Por favor, ingrese una función válida.");

            }
            
            var plotModel = new PlotModel { Title = $"Gráfico de la función: {fun1}" };
            var lineSeries = new LineSeries { MarkerType = MarkerType.None };
            for ( x = -300; x <= 300; x += 1)
            {
                // Crear una expresión NCalc 
                var expression = new Expression(funcion);
                expression.Parameters["x"] = x;
                //valida la funcion en y
                 y = 0;
                try
                {
                    y = Convert.ToDouble(expression.Evaluate());
                    lineSeries.Points.Add(new DataPoint(x, y));
                }
                catch (Exception)
                {
                    MessageBox.Show("La función ingresada no es válida.");
                    x = 301;
                }
            }

            plotModel.Series.Clear();
            plotModel.Series.Add(lineSeries);
            
            // Configurar límites en los ejes para hacer zoom en valores pequeños
            plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
              Position = OxyPlot.Axes.AxisPosition.Bottom,
              Minimum = -10,                
              Maximum = 10,                 
              PositionAtZeroCrossing = true, 
              AxislineStyle = LineStyle.Solid, 
              AxislineColor = OxyColors.Black });

            plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis{
              Position = OxyPlot.Axes.AxisPosition.Left,
              Minimum = -10,                
              Maximum = 10,                 
              PositionAtZeroCrossing = true, 
              AxislineStyle = LineStyle.Solid,  
              AxislineColor = OxyColors.Black});

            p.BackColor = System.Drawing.Color.White;
            p.Model = plotModel;
            return p; 
        }

        public String calcularRaices()
        {
            double raiz1, raiz2;
            string resul="";
            try
            {
                if (a > 0 || a < 0)
                {
                    raiz1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                    raiz2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                    if (Double.IsNaN(raiz1) || Double.IsNaN(raiz2)) { 
                         resul= "no tiene soluciones";
                    }
                    else
                    {
                        resul = $"Las Raices de La ecuacion cuadratia son {raiz1} y {raiz2}";
                    }
                }
                else if (a == 0 && b!=0)
                {
                    raiz1 = -c / b;
                    resul = $"Las Raices de La ecuacion lineal es {raiz1}";
                }
                else if (a == 0 && b == 0)
                {
                    resul = $"Las Raices de La ecuacion Constante es 0";
                }
            }
            catch (Exception ex) {
                resul = "no tiene soluciones";
            }
            return resul;
        }
        public int getA() {  return a; }
        public int getB() { return b; }
        public int getC() { return c; } 
       
    }
}
