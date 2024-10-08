
using Examen02CodigoClase15.Clases;
using Examen02CodigoClase15.Interfaces;



    List<EmpleadoBase> empleados = new List<EmpleadoBase>();

    Gerente gerente = new Gerente
    {
        IdEmpleado = 1,
        Nombre = "Luis Montero",
        Puesto = "Gerente Desarrollo"
    };
    Desarrollador desarrollador = new Desarrollador
    {
        IdEmpleado = 2,
        Nombre = "Joel Arroyo",
        Puesto = "Desarrollador Senior"
    };
    GerenteRRHH gerenteRRHH = new GerenteRRHH
    {
        IdEmpleado = 3,
        Nombre = "José Cárdenas",
        Puesto = "Gerente RRHH"
    };
    ConsultorExterno consultorExterno = new ConsultorExterno
    {
        IdEmpleado = 4,
        Nombre = "Romulo Meregido",
        Puesto = "Desarrollador Senior"
    };

    empleados.Add(gerente);
    empleados.Add(desarrollador);
    empleados.Add(gerenteRRHH);
    empleados.Add(consultorExterno);



void menu()
{
    Console.WriteLine("SELECCIONE UNA OPCION");
    Console.WriteLine("==================================");
    Console.WriteLine("Ingresar Empleado            ==> A");
    Console.WriteLine("Mostrar Listado de Empleado  ==> B");
    Console.WriteLine("Salir                        ==> C");

    Console.WriteLine("==>Ingresa Opcion:");
    string opcion = Console.ReadLine().ToUpper();
    switch (opcion)
    {
        case "A":
            Console.WriteLine("Deberas de ingresa un empleado ya existente");
            buscarEmpleado();
            break;
        case "B":
            mostrarListado();
            break;
        case "C":
            Environment.Exit(0);
            break;
        default:
            break;
    }
}


void buscarEmpleado()
{
    Console.WriteLine("==>Ingresa Numero");
    int IdBuscarEmpleado = int.Parse(Console.ReadLine());
    EmpleadoBase EmpleadoEncontrado = empleados.FirstOrDefault(e => e.IdEmpleado == IdBuscarEmpleado);
    if (EmpleadoEncontrado == null)
    {
        Console.WriteLine("Empleado no encontrado en el sistema");
        Console.WriteLine("I: Desea Ingresar Empleado ya Existente o S: Para regresar al MENU.");
        if (Console.ReadLine().ToUpper() == "S")
        {
           menu();
        }
        else
        {
            buscarEmpleado();
        }
        
    }
    else
    {
        EmpleadoEncontrado.MostrarDetalle();

        if (EmpleadoEncontrado is ISueldoBonificable empleadoBonificable)
        {
            Console.WriteLine("La bonificacion del empleado es:");
            Console.WriteLine(empleadoBonificable.CalcularBonificacion());
        }
        if (EmpleadoEncontrado is IDescuentoImpuesto empleadoDescuento)
        {
            Console.WriteLine("El descuento del empleado es:");
            Console.WriteLine(empleadoDescuento.DescontarSueldo());
        }
        Console.WriteLine("La sueldo total del empleado es:");
        Console.WriteLine(EmpleadoEncontrado.CalcularSueldo());
        Console.WriteLine("==================================");
    }

    Console.WriteLine("Ingresar Otro Empleado:I, Regresar al MENU: M, salir del sistema: S");

    string opcion = Console.ReadLine().ToUpper();

    switch (opcion)
    {
        case "I":
            Console.Clear();
            Console.WriteLine("Ingresar Empleado");
            buscarEmpleado();
            break;
        case "M":
             Console.Clear();
            menu();
            break;
        default:
            Environment.Exit(0);
            break;
    }

}

void mostrarListado()
{
    int trabajadores = 0;
    double SumaSueldo = 0;
    foreach (var empleado in empleados)
    {
        empleado.MostrarDetalle();

        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            Console.WriteLine("La bonificacion del empleado es:");
            Console.WriteLine(empleadoBonificable.CalcularBonificacion());
        }

        if (empleado is IDescuentoImpuesto empleadoDescuento)
        {
            Console.WriteLine("El descuento del empleado es:");
            Console.WriteLine(empleadoDescuento.DescontarSueldo());
        }
        Console.WriteLine("La sueldo total del empleado es:");
        Console.WriteLine(empleado.CalcularSueldo());
        SumaSueldo += empleado.CalcularSueldo();
        trabajadores = trabajadores + 1;

    }
    Console.WriteLine("========================================================");
    Console.WriteLine($"Total de Empleados:{trabajadores} ");
    Console.WriteLine("========================================================");
    Console.WriteLine("========================================================");
    Console.WriteLine($"Suma total de Sueldos al mes: {SumaSueldo} Nuevos Soles");
    Console.WriteLine("========================================================");
    Console.WriteLine("Deseas Regresar al MENU:(S/N)");
    if (Console.ReadLine().ToUpper() == "S")
    {
        Console.Clear();
        menu();

    }
    else
    {
        Environment.Exit(0);
    }
}


menu();

    Console.Read();



