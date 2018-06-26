using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabPOO
{
    public delegate void restringirCompra(Product producto);    // Definimos delegate
    public delegate void pedidoCompleto(bool pagar);            // Definimos delegate

    class Program
    {
        public static restringirCompra RestringirCompra;        // Inicializamos delegate
        public static pedidoCompleto PedidoCompleto;            // Inicializamos delegate
        public static HermanaMayor hermana;                     // Inicializamos variable de clase hermana
        public static List<Product> cart;                       // Inicializamos Lista de productos(Carro de compras)
        public static List<Product> market;                     // Inicializamos Lista de productos (Productos del supermercado) 
        public static bool PedidoRealizado;

      
        //***************************************************************************************************************************************************************************//
        //------------------------------------------------------------------------- Codigo dado -------------------------------------------------------------------------------------------//
        //****************************************************************************************************************************************************************//

        static void Main(string[] args)
        {
            // ----------------------------------------------------------------- Agregado -----------------------------------------------------------------------------------------//
            //*********************************************************************************************************************************************************************//

            RestringirCompra = new restringirCompra(Comprobar);         // Creamos el delagate "RestringirCompra"  y definimos la funcion a utilizar
            PedidoCompleto = new pedidoCompleto(ListaVacia);            // Creamos el delagate "RestringirCompra"  y definimos la funcion a utilizar
            try
            {
                cart = Cargar("datosCart");                             // Cargamos datos del archivo y los agregamos al carro
            }
            catch                                                       // En caso que falle la carga (No existe el archivo)
            {
                cart = new List<Product>();                             // Creamos un nuevo carro
            }
     
            hermana = new HermanaMayor(PedidoCompleto);         // Creamos una nueva "HermanaMayor"

            //*********************************************************************************************************************************************************************//
            market = new List<Product>();
            SupplyStore();
            while (true)
            {
                PrintHeader();
                Console.WriteLine("¿Que quieres hacer?\n");
                Console.WriteLine("\t1. Ver Receta");
                Console.WriteLine("\t2. Comprar");
                Console.WriteLine("\t3. Ver carrito");
                Console.WriteLine("\t4. Pagar");
                Console.WriteLine("\t5. Salir");
                while (true)
                {
                    String answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        ShowRecipe();
                        break;
                    }
                    else if (answer == "2")
                    {
                        WalkAround();
                        break;
                    }
                    else if (answer == "3")
                    {
                        PrintCart();
                        break;
                    }
                    else if (answer == "4")
                    {
                        // ------------------------------------------------------------- Agregado ----------------------------------------------------------------------//
                        //**********************************************************************************************************************************************//
                        if (PedidoRealizado)    // La variable cambia de valor mediante el método "ListaVacia" del delegate "PedidoRealizado"
                        {
                            Pay();              // Esta función ya venia definida
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Faltan cosas por comprar");
                            Console.WriteLine("\n\nPresiona ENTER para volver al supermercado...");
                            Console.ReadLine();
                        }
                        break;
                        //**********************************************************************************************************************************************//
                    }
                    else if (answer == "5")
                    {
                        Guardar();
                        Environment.Exit(1);
                    }
                }
            }
        }

        public static void Pay()
        {
            PrintHeader();
            int total = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                total += cart[i].Price;
            }
            Console.WriteLine("El total de tu compra es: $" + total.ToString());
            Console.Write("Este programa se cerrará en ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i.ToString() + " ");
                Thread.Sleep(1000);
            }
            // ----------------------------------------------------------------- Agregado -----------------------------------------------------------------------------------------//
            //*********************************************************************************************************************************************************************//

            hermana = new HermanaMayor(PedidoCompleto);                                         // Sobre escribimos la variable hermana (Borramos los datos) 

            //*********************************************************************************************************************************************************************//
            cart.Clear();
        }

        public static void WalkAround()
        {
            PrintHeader();
            Console.WriteLine("¿Que deseas comprar?\n\n");
            for (int i = 0; i < market.Count(); i++)
            {
                PrintProduct(i, market[i]);
            }
            while (true)
            {
                try
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer >= market.Count())
                    {
                        continue;
                    }
                    // ----------------------------------------------------------------- Agregado -----------------------------------------------------------------------------------------//
                    //*********************************************************************************************************************************************************************//

                    hermana.Validar(RestringirCompra, market[answer]);              // Llamamos al método "Validar" de la clase "HermanaMayor" (De esta forma enviamos el delegate "restringirCompra" a la clase)

                    //*********************************************************************************************************************************************************************//

                    // ----------------------------------------- Eliminado -----------------------------------------------//
                    //AddToCart(market[answer]); 

                    break;
                }
                catch
                {
                    continue;
                }
            }
        }

        public static void PrintCart()
        {
            PrintHeader();
            Console.WriteLine("Su carrito:\n\n");
            for (int i = 0; i < cart.Count(); i++)
            {
                PrintProduct(i, cart[i]);
            }
            Console.WriteLine("\n\nPresiona ENTER para volver al supermercado...");
            ConsoleKeyInfo response = Console.ReadKey(true);
            while (response.Key != ConsoleKey.Enter)
            {
                response = Console.ReadKey(true);
            }
        }


        public static void PrintProduct(int index, Product product)
        {
            Console.WriteLine(String.Format("{0}. {1}\n\tPrecio: ${2}\t{3}\tStock: {4}\n", index.ToString(), product.Name, product.Price, product.Unit, product.Stock));
        }

        public static void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("\t\t LIDER\n");
        } 

        public static bool AddToCart(Product product)
        {
            return product.Agregar(cart);
        }

        public static void SupplyStore()
        {
            market.Add(new Product("Leche Entera", 820, 89, "1L")); //ingrediente receta
            market.Add(new Product("Gomitas Flipy", 720, 12, "100g"));
            market.Add(new Product("Mantequilla", 850, 12, "125g")); //ingrediente receta
            market.Add(new Product("Crema para hemorroides", 4990, 7, "300cc"));
            market.Add(new Product("Pimienta", 430, 84, "15g")); //ingrediente receta
            market.Add(new Product("Vino Sauvignon Blanc Reserva Botella", 4150, 23, "750cc")); //ingrediente receta
            market.Add(new Product("Sal Lobos", 330, 150, "1kg")); //ingrediente receta
            market.Add(new Product("Cuaderno Mi Pequeño Pony", 1290, 50, "1un"));
            market.Add(new Product("Láminas de Lasaña", 1250, 85, "400g")); //ingrediente receta
            market.Add(new Product("Tomate", 1290, 200, "1kg"));
            market.Add(new Product("Harina", 890, 43, "1kg")); //ingrediente receta
            market.Add(new Product("Audifonos Samsung", 5990, 40, "1un"));
            market.Add(new Product("Pisco Alto del Carmen", 5990, 120, "1L"));
            market.Add(new Product("Carne Molida", 4390, 15, "500g")); // ingrediente receta
            market.Add(new Product("Aceite de Oliva", 1790, 77, "250g")); //ingrediente receta
            market.Add(new Product("Sal parrillera", 840, 50, "750g"));
            market.Add(new Product("Cable HDMI 1m", 3990, 25, "1un"));
            market.Add(new Product("Queso Rallado Parmesano", 499, 102, "40g"));
            market.Add(new Product("Vino Blanco Caja", 2790, 84, "2L"));
            market.Add(new Product("Malla de Cebollas", 1090, 91, "1kg")); //ingrediente receta
            market.Add(new Product("Tomates Pelados en lata", 700, 48, "540g")); //ingrediente receta
            market.Add(new Product("Queso Parmesano", 3790, 41, "200g")); //ingrediente receta
            market.Add(new Product("Bolsa de Zanahorias", 890, 74, "1un")); //ingrediente receta
        }

        public static void ShowRecipe()
        {
            Console.Clear();
            Console.WriteLine("\t\t===> Lasagne alla bolognese <===\n");
            Console.WriteLine("Ingredientes básicos:");
            Console.WriteLine("\t12 láminas de Lasaña");
            Console.WriteLine("\t70 gramos de parmesano rallado");
            Console.WriteLine("\tMantequilla\n");
            Console.WriteLine("Para el relleno:");
            Console.WriteLine("\t300 gramos de carne picada (queda más jugosa con mezcla de cerdo y ternera)");
            Console.WriteLine("\tMedio vaso de vino blanco");
            Console.WriteLine("\t250 gramos de tomate entero pelado de lata");
            Console.WriteLine("\t1 zanahoria");
            Console.WriteLine("\t1 cebolla");
            Console.WriteLine("\tAceite de oliva");
            Console.WriteLine("\tSal");
            Console.WriteLine("\tPimienta\n");
            Console.WriteLine("Para la bechamel:");
            Console.WriteLine("\t50 gramos de mantequilla");
            Console.WriteLine("\t50 gramos de harina");
            Console.WriteLine("\tMedio litro de leche");
            Console.WriteLine("\tSal");
            Console.WriteLine("\tPimienta\n\n");
            Console.WriteLine("Presiona ENTER para volver al supermercado...");
            ConsoleKeyInfo response = Console.ReadKey(true);
            while (response.Key != ConsoleKey.Enter)
            {
                response = Console.ReadKey(true);
            }
        }

    //*********************************************************************************************************************************************************************************************//
    // -------------------------------------------------------------------- Funciones Agregadas ---------------------------------------------------------------------------------------------------//     
    //*********************************************************************************************************************************************************************************************//


        public static void ListaVacia(bool pagar)        // Definimos variable utilizada por el delegate "pedidoCompleto"
        {
            if (pagar)
            {
                Console.WriteLine("¡¡ATENCION!!");
                Console.WriteLine("\n\nSe a comprado todo lo de la lista");
                Console.WriteLine("\n\nPresiona ENTER para continuar...");
                Console.ReadLine();
                PedidoRealizado = true;
            }
        }

        public static void Comprobar(Product producto)     // Definimos variable utilizada por el delegate "restringirCompra"
        {
            if (producto != null)
            {
                AddToCart(producto);
            }
        }

        public static void Guardar()            // Función para guardar
        {
            FileStream fs = new FileStream("datosCart", FileMode.Create);   // Creamos o editamos archivo 
            IFormatter formatter = new BinaryFormatter();                   // Definimos el formato (En este caso binario)
            formatter.Serialize(fs, cart);                                  // Serializamos la variable "cart" y la guardamos en el archivo definido  "fs" 
            fs.Close();                                                     // Cerramos archivo "fs"
        }

        private static List<Product> Cargar(string direccion)                   // Función para cargar dato del tipo "List<Product>"
        {
            FileStream fs = new FileStream(direccion, FileMode.Open);           // Abrimos el archivo
            IFormatter formatter = new BinaryFormatter();                       // Definimos el formato en el que esta escrito (En este caso binario)
            List<Product> cart = formatter.Deserialize(fs) as List<Product>;     // Deserializamos el archivo y lo guardamos en la variable "cart"
            fs.Close();                                                         // Cerramos archivo "fs"
            return cart;                                                        // retornamos la variable creada
        }
    }
}
