using SOsimulatorWPF.Components;
using System.Threading;

namespace SOsimulatorWPF.Escalonador
{
    public class FIFO
    {
        private bool controlador = true;

        public void StartAlgoritmo()
        {
            while (controlador)
            {
                if(RAM.Processos.Count > 1)
                {
                    var processo = RAM.Processos[1];

                    if (processo.Nome != "Windows 10")
                    {
                        MMU.AdicionarProcesso(processo);
                        Thread.Sleep(1000);
                        CPU.AdicionarProcesso(processo);
                        Thread.Sleep(processo.TempoExecucao * 1000);
                        CPU.RemoverProcesso();
                    }                    
                }      
            }
        }

        public void StopThread()
        {
            controlador = false;
        }
    }
}
