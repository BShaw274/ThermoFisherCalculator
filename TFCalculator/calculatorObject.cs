using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TFCalculator
{
    public enum Operation
    {
        addition = 0,
        subtraction = 1,
        multiplication = 2,
        division = 3
    }

    public class CalculatorObject
    {
        
        public CalculatorObject() 
        {
            result = 0;
            nums = new List<double>();
        }
        public double result;
        public List<double> nums;
        Operation operand;

        public void setNums(double num)
        {

            nums.Add(num);
        }

        public void setOperand(Operation inOp)
        {
            operand = inOp;

        }
        //calculates the results using the internal operation enum
        public string results()
        {
            double results = 0;
            switch (operand)
            {
                case Operation.addition:
                    results = nums[0] + nums[1];
                    break;
                case Operation.subtraction:
                    results = nums[0] - nums[1];
                    break;
                case Operation.multiplication:
                    results = nums[0] * nums[1];
                    break;
                case Operation.division:
                    results = nums[0] / nums[1];
                    break;
            }
            //clears the numbers saved internally
            nums.Clear();
            return results.ToString();

        }
    }

}
