using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS3;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sin5x_with_five_args_checkY() // y = 0 + 1*sin(5x) x from 1 to 5, check list y
        {
            Panel result_panel = new Panel();
            Chart chart = new Chart();
            double a = 0;
            double b = 1;
            double c = 5;
            double d = 0;
            double left_border = 1;
            double right_border = 5;
            double step = 1;

            List<double> LIST_Y = new List<double> { -0.95892, -0.54402, 0.65029, 0.91295, -0.13235  };
            Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, true);

            CollectionAssert.AreEqual(LIST_Y, Algorithm.list_y);
        }

        [TestMethod]
        public void Sin5x_with_five_args_checkX() // y = 0 + 1*sin(5x) x from 1 to 5, check list x
        {
            Panel result_panel = new Panel();
            Chart chart = new Chart();
            double a = 0;
            double b = 1;
            double c = 5;
            double d = 0;
            double left_border = 1;
            double right_border = 5;
            double step = 1;

            List<double> LIST_X = new List<double> { 1, 2, 3, 4, 5 };
            Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, true);

            CollectionAssert.AreEqual(LIST_X, Algorithm.list_x);
        }

        [TestMethod]
        public void Sin0x_with_five_args_checkY() // y = 0 + 1*sin(0x) x from 1 to 5, check list y
        {
            Panel result_panel = new Panel();
            Chart chart = new Chart();
            double a = 0;
            double b = 1;
            double c = 0;
            double d = 0;
            double left_border = 1;
            double right_border = 5;
            double step = 1;

            List<double> LIST_Y = new List<double> { 0, 0, 0, 0, 0 };
            Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, true);

            CollectionAssert.AreEqual(LIST_Y, Algorithm.list_y);
        }

        [TestMethod]
        public void Direct_with_five_args_checkY() // Direct y = 2, check list y
        {
            Panel result_panel = new Panel();
            Chart chart = new Chart();
            double a = 2;
            double b = 0;
            double c = 0;
            double d = 0;
            double left_border = 1;
            double right_border = 5;
            double step = 1;

            List<double> LIST_Y = new List<double> { 2, 2, 2, 2, 2 };
            Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, true);

            CollectionAssert.AreEqual(LIST_Y, Algorithm.list_y);
        }

        [TestMethod]
        public void Step_not_equal_one_sin5x_five_args_checkY() // step = 0.5, y = 0 + 1*sin(5x) x from 1 to 5,
                                                                // check list y
        {
            Panel result_panel = new Panel();
            Chart chart = new Chart();
            double a = 0;
            double b = 1;
            double c = 5;
            double d = 0;
            double left_border = 1;
            double right_border = 5;
            double step = 0.5;

            List<double> LIST_Y = new List<double> { -0.95892, 0.938,
                                                    -0.54402, -0.06632,
                                                    0.65029, -0.97563,
                                                    0.91295, -0.48717,
                                                    -0.13235 
                                                    };
            Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, true);

            CollectionAssert.AreEqual(LIST_Y, Algorithm.list_y);
        }
    }
}
