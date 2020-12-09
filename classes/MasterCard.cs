namespace AulaPOO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        //Atributos
        private int parcelas;

        //Get e Set

        public int Parcelas{
            get{ return parcelas;} // pegar dados - Leitura
            set{ parcelas = value;} // inserir dados - Escrita

        }

        //Métodos
        public string CompraComDesconto(){

            return "";
        }
    }
}