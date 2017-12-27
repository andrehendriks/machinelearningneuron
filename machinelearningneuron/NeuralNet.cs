using System;
using System.Collections.Generic;
using System.Text;

namespace machinelearningneuron
{
    public class NeuralNet
    {
        public void LayerNet1(object H, int input, int hidden1, int hidden2, int output)
        {
            input = 4;
            hidden1 = 0;
            hidden2 = 0;
            output = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    H = i * j;
                    H = i + 1 * j + 1;
                }
            }
        }

        public void MatrixX(object X)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int j2 = 0; j2 < 1; j2++)
                {
                    X = i2 * j2;
                    X = i2 + 1 * j2 + 1;
                }
            }
        }

        public void MatrixTrain(object T)
        {
            for (int i1 = 0; i1 < 4; i1++)
            {
                for (int j1 = 0; j1 < 1; j1++)
                {
                    T = i1 * j1;
                    T = i1 + 1 * j1 + 1;
                }
            }
        }
    }
}
