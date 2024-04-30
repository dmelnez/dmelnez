using dmelnez.Dtos;
using dmelnez.Servicios;

namespace dmelnez.Controladores;

class Program
{

    public static void Main(string[] args)
    {
        List<PacienteDtos> listaPacientes = new List<PacienteDtos>();

        MenuInterfaz me = new MenuImplementacion();

        OperativaInterfaz op = new OperativaImplementacion();

        FicherosInterfaz fi = new FicherosImplementacion();

        DateTime fechaHoy = DateTime.Now;
        fi.cargaInicial(listaPacientes);


        string ruta = ("C:\\Users\\dmelnez\\Desktop\\" + fechaHoy.ToString("dd-MM-yyyy"));


        bool esCerrarAplicacion = false;


        do
        {
       

            int seleccionPrincipal = me.menuPrincipal();
            switch (seleccionPrincipal)
            {
                case 0:
                    esCerrarAplicacion = true;
                    break;
                case 1:
                    op.registroLlegada(listaPacientes);


                    try
                    {
                        using (StreamWriter sw = new StreamWriter(ruta, true))
                        {

                            sw.WriteLine("Registro Llegada.");

                        }
                    }

                    catch (IOException io)
                    {

                        using (StreamWriter sw = new StreamWriter(ruta, true))
                        {

                            sw.WriteLine(io.ToString());

                        }

                    }



                    break;
                case 2:

                    try
                    {
                        using (StreamWriter sw = new StreamWriter(ruta, true))
                        {

                            sw.WriteLine("Listado Consultas.");

                        }
                    }

                    catch(IOException io)
                    {

                        using (StreamWriter sw = new StreamWriter(ruta, true))
                        {

                            sw.WriteLine(io.ToString());

                        }

                    }
                    
                   op.listadoConsultas(listaPacientes);
              
                    break;

                case 3:
                    DateTime fecha1 = DateTime.Now;

                    DateTime fechaPedida = Convert.ToDateTime(Console.ReadLine());
                    DateTime fechaPedida2 = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine(fecha1);
                    Console.WriteLine(fechaPedida);
                    Console.WriteLine(fecha1.Equals(fechaPedida2));

                    break;

                default:

                    try
                    {
                        using (StreamWriter sw = new StreamWriter(ruta, true))
                        {

                            Console.WriteLine("[ALERTA] -> Seleccion no valida");

                        }
                    }

                    catch (IOException io)
                    {

                        using (StreamWriter sw = new StreamWriter(ruta, true))
                        {

                            sw.WriteLine(io.ToString());

                        }

                    }
                    break;




            }

        }

        while (!esCerrarAplicacion);




    }


}
