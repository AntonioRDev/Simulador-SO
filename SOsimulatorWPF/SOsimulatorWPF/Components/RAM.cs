using SOsimulatorWPF.Models;
using System.Collections.ObjectModel;

namespace SOsimulatorWPF.Components
{
    public static class RAM
    {
        public static int Tamanho { get; set; } = 1024;
        public static ObservableCollectionEx<Processo> Processos { get; set; } = new ObservableCollectionEx<Processo>();
        private static int EnderecoAtual { get; set; } = 0;

        static RAM()
        {
            var systemProcess = new Processo();
            systemProcess.Nome = "Windows 10";
            systemProcess.Tamanho = 300;
            systemProcess.EnderecoMemoria = EnderecoAtual++;
            Processos.Add(systemProcess);
        }

        public static void AdicionarProcesso(Processo processo)
        {                    
            if(Tamanho - processo.Tamanho < 0)
            {
                throw new System.Exception("Memória cheia");
            }
            processo.EnderecoMemoria = EnderecoAtual++;
            Processos.Add(processo);
            Tamanho = Tamanho - processo.Tamanho;
        }

        public static void RemoverProcesso(Processo processo)
        {
            if(Processos.Count == 0)
            {
                throw new System.Exception("Memória vazia");
            }
            processo.EnderecoMemoria = null;
            Processos.Remove(processo);
            Tamanho = Tamanho + processo.Tamanho;
        }

        public static void ExecutarProcesso(Processo processo)
        {

        }
    }
}
