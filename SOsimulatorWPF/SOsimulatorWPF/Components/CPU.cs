using SOsimulatorWPF.Models;

namespace SOsimulatorWPF.Components
{
    public static class CPU
    {
        public static Processo Processo { get; set; }

        public static void AdicionarProcesso(Processo processo)
        {

        }

        public static void RemoverProcesso()
        {
            RAM.AdicionarProcesso(Processo);
            Processo = null;
        }
    }
}
