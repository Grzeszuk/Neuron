using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuron
{
    public class Neuron : iNeuron
    {
        public double[] _weights { get; set; }

        public Neuron()
        {

        }

        public Neuron(double[] _weights)
        {
            this._weights = _weights;
        }

        public async Task<double> FunctionU(double[ arg)
        {
            return await Task.Run(() =>
            {
                var temp = 0.0;

                foreach (var item in arg.Select((value, index) => new { value, index }))
                {
                    temp += _weights[item.index] * item.value;
                }

                return temp;
            });
        }

        public double Signum(double U) => U < 0 ? -1 : 1;
    }
}
