using System.Collections.Generic;

namespace LoopsAndInstancesExample
{
    public class ListaDeEmails
    {
        public IEnumerable<string> Buscar()
        {
            for (int i = 0; i < 1000000; i++)
                yield return $"email{i}@outlook.com.br";
        }
    }
}
