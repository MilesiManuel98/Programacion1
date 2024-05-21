using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiasDeVida();
        //ImprimirMinimoDe4();
        //TipoDeTriangulo();
        //FechaValida();
        //HorasDeTrabajo();
        //CalcularValorPago();
        //PruebaDeObjetoSplit();
        //PruebaDeObjetoPersonas();
        //PruebaPavaElectrica();
        PruebaEsterio();
    }

    private static void PruebaEsterio()
    {
        Estereo miEstereo = new Estereo("Pioneer","Negro","Plastico");
        miEstereo.PresionarBotonEncendido();
        miEstereo.CambiarModo(ModoEstereoEnum.Auxiliar);
    }

    private static void PruebaPavaElectrica()
    {
        PavaElectrica miPava = new PavaElectrica("Liliana", "Plateado", "Acero inoxidable");
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Maximo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");
        Thread.Sleep( 2000 );
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Minimo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");
    }

    private static void PruebaDeObjetoPersonas()
    {
        Persona albert = new Persona("Alvert Einstein", "9 de Julio 2222", 1879);
        Persona robert = new Persona("Robert Oppenheimer", "Manhttan 1111", 1904);

        robert.Decir("Albert, sabes como se despiden los quimicos?");
        albert.Decir("no, ni idea");
        robert.Decir("acido un placer");
    }

    private static void PruebaDeObjetoSplit()
    {
        Split miSplit = new Split("Blanco",3000,"Marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PrecionarBotonEncendido();
        miSplit.CambiarModo("Deshumificacion");
        miSplit.SubirTemperatura();
        Console.WriteLine("El modo definido del split es: " + miSplit.modo);
    }

    // Calcular valor de la cuota
    private static void CalcularValorPago()
    {
        double valorCuota;
        int nroDia;

        Console.Write("Ingrese el valor de la cuota: ");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("Ingrese del dia de pago: ");
        nroDia = int.Parse(Console.ReadLine());

        switch (nroDia)
        {
            case < 3:
                valorCuota -= valorCuota * 0.03;
                break;

            case >= 6 and <= 10:
                valorCuota += valorCuota * 0.1;
                break;

            case >= 11 and <= 20:
                valorCuota += valorCuota * 0.12;
                break;

            case >= 21 and <= 31:
                valorCuota += valorCuota * 0.15;
                break;
        }
        Console.WriteLine($"El valor de la cuota para el dia de pago es: {valorCuota}");
    }

    // Horas lavorales 
    private static void HorasDeTrabajo()
    {
        int HorasTrabajadas, HorasFaltantes;
        string Dia;

        Console.Write("Ingrese las horas trabajadas: ");
        HorasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el día de la semana (en minuscula): ");
        Dia = Console.ReadLine();

        HorasFaltantes = 5 - HorasTrabajadas;

        if (Dia == "jueves")
            HorasFaltantes += 2;

        Console.WriteLine("Horas faltantes para completar la jornada: " + HorasFaltantes);
    }

    // Numero minimo de 4
    private static void ImprimirMinimoDe4()
    {
        int num1, num2, num3, num4;

        Console.Write("Ingresar el primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el tercer numero: ");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el cuarto numero: ");
        num4 = int.Parse(Console.ReadLine());

        if (num1 < num2 && num1 < num3 && num1 < num4)
            Console.WriteLine($"el numero con el valos minimo el {num1}");
        else if (num2 < num3 && num2 < num4)
            Console.WriteLine($"el numero con el valos minimo el {num2}");
        else if (num3 < num4)
            Console.WriteLine($"el numero con el valos minimo el {num3}");
        else
            Console.WriteLine($"el numero con el valos minimo el {num4}");
        
    }

    // Tipo de triangunlo
    private static void TipoDeTriangulo()
    {
        int lado1, lado2, lado3;

        Console.Write("Ingresar el primer lado: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el segundo lado: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el tercer lado: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
            Console.WriteLine("El triángulo es equilátero.");
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            Console.WriteLine("El triángulo es isósceles.");
        else
            Console.WriteLine("El triángulo es escaleno.");

    }

    // Fecha valida o no
    private static void FechaValida()
    {
        int dia, mes, año;

        Console.Write("Ingresar el dia: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingresar el año: ");
        año = int.Parse(Console.ReadLine());


        if (año > 0 && mes >= 1 && mes <= 12)
        {
            if ((dia >= 1 && dia <= 28) || (dia == 29 && año % 4 == 0))
                Console.WriteLine("La fecha es valida");

            else if ((dia == 29 || dia == 30) && mes != 2)
                Console.WriteLine("La fecha es valida");

            else if (dia == 31 && (mes != 2 || mes != 4 || mes != 6 || mes != 9 || mes != 11))
                Console.WriteLine("La fecha es valida");

            else
            {
                Console.WriteLine("La fecha es no valida");
                FechaValida();
            }
        }
        else
        {
            Console.WriteLine("La fecha es no valida");
            FechaValida();
        }
    }

    //Creamos un metodo que pida el nombre y apellido del usuario
    // y posteriormente lo ssalude con "Bienvenido [Apellido], [Nombre]"

    private static void PedirNombreYSaludar()
    {
        //Declaramos las variables
        string nombre,apellido;

        Console.Write("Ingrese su Nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su Apellido: ");
        apellido = Console.ReadLine();

        //Console.WriteLine("Bienvenido "+nombre+", "+apellido);
        Console.WriteLine($"Bienvenido {nombre}, {apellido}");
    }

    /* Creamos un metodo que nos pida los años, meses y dias de vida
    y muestre al final la cantidad totil de dias de vida 
    */

    private static void CalcularDiasDeVida()
    {
        int años, meses, dias, diasTotales;

        Console.Write("Ingresar años: ");
        años = int.Parse (Console.ReadLine());

        Console.Write("Ingresar meses: ");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingresar dias: ");
        dias = int.Parse(Console.ReadLine());

        diasTotales = años * 365 + meses * 30 + dias;

        Console.WriteLine($"Sus dias de vida son {diasTotales}");

    }


}