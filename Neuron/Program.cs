using Neuron.Program_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiećNeuronowa
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tworzenie sieci i wpisanie wag
            var Siec = new List<Neuron.Neuron>()
            {
                new Neuron.Neuron(),
                new Neuron.Neuron(),
                new Neuron.Neuron(),
            };

            Siec[0]._weights = new List<double>() { 1, 2, 0 };
            Siec[1]._weights = new List<double>() { 0, -1, 2 };
            Siec[2]._weights = new List<double>() { 1, 3, -1 };
            #endregion

            #region Tworzenie wejść
            var X = new List<List<double>>[3];
            X[0].Add(new List<double>{ 10, 2, -1 });
            X[1].Add(new List<double> { 2, -5, -1 });
            X[2].Add(new List<double> { -5, 5, -1 });
            #endregion

            #region Tworzenie ocen
            var D = new List<List<double>>();

            D.Add(new List<double>() { 1, -1, -1 });
            D.Add(new List<double>() { -1, 1, -1 });
            D.Add(new List<double>() { -1, -1, 1 });
            #endregion

            Console.WriteLine(new ProgramLogic().Execute(Siec,X,D).Result);
    
        }
    }
}