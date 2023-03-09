using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potolin_Perceptron
{
    //place all perceptron calculations here
    public class Perceptron
    {
        //initialize wieghts and bias to 0
        private double w1 = 0, w2 = 0, b = 0, learn;
        //x1 data
        private double[] x1Data = {1, 1, -1, -1};
        //x2 data
        private double[] x2Data = {1, -1, 1, -1 };
        //NOR target data 
        private double[] yData = { -1, -1, -1, 1  };
        //store trained y data
        private double[] trainedData;
       

        public Perceptron(double w1, double w2, double b, double learn)
        {
            this.w1 = w1;
            this.w2 = w2;
            this.b = b;
            this.learn = learn;
        }

        public Perceptron(){
            trainedData = new double[4];
        }

        public void Train()
        {
            //y = x1*w1 + x2*w2 + bias
            for (int i = 0; i < 4; i++)
            {
                double y = 0.0;
                //compute for y'
                y = (x1Data[i] * w1) + (x2Data[i] * w2) + b;

                //hard limit y'
                if (y <= 0) { y = -1; } else { y = 1; }

                //compare actual y val vs target y val
                if (y != yData[i])
                {
                    //update weights if y does not equal y'
                    double w1New = w1 + (learn * yData[i] * x1Data[i]);
                    double w2New = w2 + (learn * yData[i] * x2Data[i]);
                    //set value of old weights = new weights
                    w1 = w1New;
                    w2 = w2New;                    
                }
                //place actual y values in an array
                trainedData[i] = y;
            }     
        }

        public void setW1(double w1)
        {
            this.w1 = w1;
        }

        public void setW2(double w2)
        {
            this.w2 = w2;
        }

        public double getW1()
        {
            return w1;
        }

        public double getW2()
        {
            return w2;
        }

        public void setBias(double b)
        {
            this.b = b; ;
        }
        public void setLearnRate(double learn)
        {
            this.learn = learn;
        }

        public double[] DisplayTrainedData()
        {
            return trainedData;
        }
    }
                
}
