using SOsimulatorWPF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SOsimulatorWPF.Components
{
    public static class RAM
    {
        public static int Tamanho { get; set; } = 1024;
        public static ObservableCollection<Processo> Processos { get; set; } = new ObservableCollection<Processo>();

        static RAM()
        {
            var systemProcess = new Processo();
            systemProcess.Nome = "Windows 10";
            systemProcess.Tamanho = 100;
            Processos.Add(systemProcess);
        }

        public static void AdicionarProcesso(Processo processo)
        {                    
            if(Tamanho - processo.Tamanho < 0)
            {
                throw new System.Exception("Memória cheia");
            }
            Processos.Add(processo);
            Tamanho = Tamanho - processo.Tamanho;
        }

        public static void RemoverProcesso(Processo processo)
        {
            if(Processos.Count == 0)
            {
                throw new System.Exception("Memória vazia");
            }
            Processos.Remove(processo);
            Tamanho = Tamanho + processo.Tamanho;
        }

        public static void ExecutarProcesso(Processo processo)
        {

        }
    }
}
