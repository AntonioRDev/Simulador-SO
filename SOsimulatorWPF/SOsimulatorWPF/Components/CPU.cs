using SOsimulatorWPF.Models;
using System.Linq;

namespace SOsimulatorWPF.Components
{
    public static class CPU
    {        
        public static ObservableCollectionEx<Processo> Processo { get; set; } = new ObservableCollectionEx<Processo>();

        public static void AdicionarProcesso(Processo processo)
        {
            if(Processo.Count == 0)
            {
                MMU.RemoverProcesso(MMU.Processos.Where(p => p == processo).FirstOrDefault());
                Processo.Add(processo);
            }            
        }

        public static void RemoverProcesso()
        {
            Processo.Clear();
        }

        public static void VoltarProcesso(Processo processo)
        {            
            RemoverProcesso();
            RAM.AdicionarProcesso(processo);
        }
    }
}
