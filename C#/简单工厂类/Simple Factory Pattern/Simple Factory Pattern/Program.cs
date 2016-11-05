using System;

namespace Simple_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Chart chart;
            chart = ChartFactory.getChart("pie");
            chart.display();

            Console.ReadKey();
        }
    }

    public abstract class Chart
    {
        public abstract void display();
    }

    class HistogramChart : Chart
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图");
        }

        public override void display()
        {
            Console.WriteLine("显示柱状图");     
        }
    }

    class PieChart : Chart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图");
        }

        public override void display()
        {
            Console.WriteLine("显示饼状图");
        }
    }

    class LineChart : Chart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图");
        }

        public override void display()
        {
            Console.WriteLine("显示折线图");
        }
    }

    class ChartFactory
    {
        public static Chart getChart(String type)
        {
            Chart chart = null;
            if (type.Equals("histogram"))
            {
                chart = new HistogramChart();
            }else if(type.Equals("pie"))
            {
                chart = new PieChart();
            }else if (type.Equals("line"))
            {
                chart = new LineChart();
            }

            return chart;
        }
    }
        
}
