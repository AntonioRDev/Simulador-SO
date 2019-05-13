using SOsimulatorWinForms.Model;
using System.Collections.Generic;

namespace SOsimulatorWinForms.Componentes
{
    public static class RAM
    {
        private static int Tamanho { get; set; } = 1024;
        private static List<Aplicação> Aplicações { get; set; } = new List<Aplicação>();

        public static void AdicionarProcesso(Aplicação app)
        {
            Aplicações.Add(app);
        }

        public static void RemoverProcesso(Aplicação app)
        {
            Aplicações.Remove(app);
        }

        public static void ExecutarProcesso(Aplicação app)
        {

        }
    }
}
