namespace Exercise_Cellphone
{
    public class cellphone
    {
        public string cor = "Sunset Purple";
        public string modelo = "Iphone";
        public string Tamanho = "6.53 Polegadas";
        private bool ligado = false;

        public bool Ligar(){
            ligado = true;
            return(true);
        }
        public bool Desligar(){
            ligado = false;
            return(false);
        }
        public void Ligacao(){

        }
        public void EnviarMensagem(){

        }
    }
}