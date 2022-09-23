namespace tp3{
    class Cadete:Persona{
        public List<Pedido> ListadoDePedidos = new List<Pedido>();
        public float JornalACobrar(){
            float total = 0;
            foreach (var Pedido in ListadoDePedidos)
            {
                if(Pedido.Estado == true)
                {
                    total = total + 300;
                }
            }
            return total;
        }
    

    }
    
}