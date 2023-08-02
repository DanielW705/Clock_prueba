namespace Clock_prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se inicializa el reloj
            Clock clock = new Clock();
            //Se inizializa el temporizador
            Timer timer = new Timer();
            //Se pasa la funcion que se accionara con el evento
            clock.Tick += timer.OnSecondPassed;
            //Se mantendra en bucle para que este siempre muestre el tiempo
            while (true)
                clock.SecondPassed();
        }
    }
}