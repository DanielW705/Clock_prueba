namespace Clock_prueba
{
    public class Timer
    {
        //Esta es la funcion de cuando pase cierto tiempo
        public void OnSecondPassed(object source, EventArgs e)
        {
            //Se inciara una variable que obtendra el tiempo de manera actual
            DateTime date = DateTime.Now;
            //Limpiara la consola 
            Console.Clear();
            //Escribira de nuevo el tiempo actual
            Console.WriteLine($"{date.ToString("HH:mm:ss")}");
        }
    }
}