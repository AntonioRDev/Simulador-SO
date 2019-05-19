namespace SOsimulatorWPF.Models
{
    public class Processo
    {
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public int TempoExecucao { get; set; }
        public int TempoCPU { get; set; }
        public int? EnderecoMemoria { get; set; }
    }
}
