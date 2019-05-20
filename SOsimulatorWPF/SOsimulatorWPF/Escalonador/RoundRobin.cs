using SOsimulatorWPF.Components;
using System.Threading;

namespace SOsimulatorWPF.Escalonador
{
    public class RoundRobin
    {
        private bool controlador = true;
        private int quantum = 3;

        public void StartAlgoritmo()
        {
            while (controlador)
            {
                if (RAM.Processos.Count > 1)
                {
                    var processo = RAM.Processos[1];

                    if (processo.Nome != "Windows 10")
                    {
                        MMU.AdicionarProcesso(processo);
                        Thread.Sleep(1000);
                        CPU.AdicionarProcesso(processo);
                        Thread.Sleep(quantum * 1000);
                        processo.TempoExecucao = processo.TempoExecucao - quantum;
                        if(processo.TempoExecucao <= 0)
                        {
                            CPU.RemoverProcesso();
                        }
                        else
                        {
                            CPU.VoltarProcesso(processo);
                        }                        
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
