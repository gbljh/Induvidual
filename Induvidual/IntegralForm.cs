using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jace;

namespace Induvidual
{
    public partial class IntegralForm : Form
    {
        LibIntegral.Integral integral;
        public IntegralForm(LibIntegral.Integral integral)
        {
            InitializeComponent();
            this.integral = integral;
            IntegralBindingSource.DataSource = integral;
            IntegralBindingSource.BindingComplete += CarBindingSource_BindingComplete;

           
        }

        private void CarBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteState != BindingCompleteState.Success)
            {
                MessageBox.Show(e.ErrorText);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(integral.Formula))
            {
                DialogResult = DialogResult.OK;
                string formula = textBoxFormula.Text;
                double xmin = double.Parse(textBoxXmin.Text);
                double xmax = double.Parse(textBoxXmax.Text);
                double dx = double.Parse(textBoxDx.Text);
                integral.Xmin = xmin;
                integral.Xmax = xmax;
                integral.Dx = dx;
                if (checkBoxLeftRectangle.Checked == true)
                {
                    integral.LeftRectangle = Math.Round(IntegralLeftRectangle(xmin, xmax, dx, formula), 2);
                }
                if (checkBoxRightRectangle.Checked == true)
                {
                    integral.RightRectangle = Math.Round(IntegralRightRectangle(xmin, xmax, dx, formula), 2);
                }
                if (checkBoxTrap.Checked == true)
                {
                    integral.Trap = Math.Round((IntegralLeftRectangle(xmin, xmax, dx, formula) + IntegralRightRectangle(xmin, xmax, dx, formula)) / 2, 2);
                }
                if (checkBoxSimpson.Checked == true)
                {
                    integral.Simpson = Math.Round(IntegralSimpson(xmin, xmax, dx, formula), 2);
                }
            }
            else
            {
                MessageBox.Show("Fields are empty");
            }
        }
        private double IntegralLeftRectangle(double a, double b, double step, string formula)
        {
            double result = 0;
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", a);
            CalculationEngine engine = new CalculationEngine();
            double function = engine.Calculate(formula, variables);
            for (double x = a; x < b; x += step)
            {
                variables.Remove("x");
                variables.Add("x", x);
                function = engine.Calculate(formula, variables);
                result += function * step;
            }
            return result;
        }
        private double IntegralRightRectangle(double a, double b, double step, string formula)
        {
            double result = 0;
            Dictionary<string, double> variables = new Dictionary<string, double>();
            variables.Add("x", a+step);
            CalculationEngine engine = new CalculationEngine();
            double function = engine.Calculate(formula, variables);
            for (double x = a; x < b; x += step)
            {
                variables.Remove("x");
                variables.Add("x", x+step);
                function = engine.Calculate(formula, variables);
                result += function * step;
            }
            return result;
        }
        private double IntegralSimpson(double a, double b, double step, string formula)
        {
            double result = 0;
            int n = (int)((b - a) / step);
            double h = step;
            Dictionary<string, double> variables = new Dictionary<string, double>();
            CalculationEngine engine = new CalculationEngine();
            variables.Add("x", a);
            for (int i = 0; i < n-1; i++)
            {
                variables.Remove("x");
                variables.Add("x", a + h * i);
                double f_h_i = engine.Calculate(formula, variables);
                variables.Remove("x");
                variables.Add("x", a + h * (i + 0.5));
                double f_a_h_i_05 = engine.Calculate(formula, variables);
                variables.Remove("x");
                variables.Add("x", a + h * (i + 1));
                double f_a_h_i_1 = engine.Calculate(formula, variables);
                result += (f_h_i + 4* f_a_h_i_05 + f_a_h_i_1)*h / 6;
            }
            return result;
        }
    }

 }
