using SOsimulatorWPF.Models;
using System.Collections.Generic;

namespace SOsimulatorWPF.Components
{
    public static class RAM
    {
        private static int Tamanho { get; set; } = 1024;
        private static List<Processo> Processos { get; set; } = new List<Processo>();

        static RAM()
        {
            var systemProcess = new Processo();
            systemProcess.Nome = "Windows 10";
            systemProcess.Tamanho = 100;
            Processos.Add(systemProcess);
        }

        public static void AdicionarProcesso(Processo processo)
        {
            Processos.Add(processo);
        }

        public static void RemoverProcesso(Processo processo)
        {
            Processos.Remove(processo);
        }

        public static void ExecutarProcesso(Processo processo)
        {

        }
    }
}
