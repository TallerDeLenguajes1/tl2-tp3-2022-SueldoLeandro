namespace tp3{
    class Cadeteria
    {
       public string Nombre;
       public long Telefono;
       public List<Cadete> ListadoDeCadetes = new List<Cadete>();

       public Cadeteria(string Nombre, long Telefono)
       {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
       } 
    }
}