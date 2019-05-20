using SOsimulatorWPF.Models;
using System.Linq;

namespace SOsimulatorWPF.Components
{
    public static class MMU
    {
        public static ObservableCollectionEx<Processo> Processos { get; set; } = new ObservableCollectionEx<Processo>();
        private static int EnderecoAtual { get; set; } = 1000;

        public static void AdicionarProcesso(Processo processo)
        {
            RAM.RemoverProcesso(RAM.Processos.Where(p => p == processo).FirstOrDefault());
            processo.EnderecoMemoria = EnderecoAtual + 1;
            Processos.Add(processo);
        }

        public static void RemoverProcesso(Processo processo)
        {
            Processos.Remove(processo);
            EnderecoAtual = EnderecoAtual - 1;
        }

        public static void Clear()
        {
            foreach (var processo in Processos)
                RemoverProcesso(processo);
        }
    }
}
