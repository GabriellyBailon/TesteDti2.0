namespace TestePratico
{
    class IPetshop
    {
        //Nome do Petshop
        public string Nome { get; set; }
        public double Distancia { get; protected set; }
        public double TaxaBanhoDiaDeSemana_P { get; protected set; }
        public double TaxaBanhoDiaDeSemana_G { get; protected set; }
        public double TaxaBanhoFimDeSemana_P { get; protected set; }
        public double TaxaBanhoFimDeSemana_G { get; protected set; }
        public double Custo { get; protected set;}


        //Construtor
        public IPetshop()
        {
        }

        public virtual void SetCusto(int diaDaSemana, int quantidadeCaesP, int quantidadeCaesG)
        {
            double custoTotal;

            //Cálculo feito para pesquisa de segunda a sexta
            //Era um if/else
            custoTotal = (diaDaSemana > 0 && diaDaSemana < 6) ?
                (TaxaBanhoDiaDeSemana_P * quantidadeCaesP) + (TaxaBanhoDiaDeSemana_G * quantidadeCaesG) :
                (TaxaBanhoFimDeSemana_P * quantidadeCaesP) + (TaxaBanhoFimDeSemana_G * quantidadeCaesG);

            Custo = custoTotal;
        }
    }
}
