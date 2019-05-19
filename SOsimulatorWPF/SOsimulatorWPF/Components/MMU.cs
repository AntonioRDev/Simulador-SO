using SOsimulatorWPF.Models;
using System.Collections.ObjectModel;

namespace SOsimulatorWPF.Components
{
    public static class MMU
    {
        public static ObservableCollection<Processo> Processos { get; set; } = new ObservableCollection<Processo>();

        public static void AdicionarProcesso(Processo processo)
        {

        }

        public static void RemoverProcesso()
        {
                     
        }
    }
}
