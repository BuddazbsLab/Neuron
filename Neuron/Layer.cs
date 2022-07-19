

namespace NeuralNetworks
{
    public class Layer
    {
        #region Поля класса
        public int NeuronCount => Neurons?.Count ?? 0;
        public NeuronType Type;
        #endregion

        #region Конструктор
        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            // TODO: проверить все входные нейроны на соответствие типу

            Neurons = neurons;
            Type = type;
        }
        #endregion

        #region Свойства
        public List<Neuron> Neurons { get; }
        #endregion

        #region Методы
        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach (var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }

        public override string ToString()
        {
            return Type.ToString();
        }
        #endregion
    }
}
