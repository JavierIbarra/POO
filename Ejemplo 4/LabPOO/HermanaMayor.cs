using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    [Serializable]
    class HermanaMayor
    {
        public event restringirCompra restringirCompra;     // Inicializamos el evento igual al delegate 
        public event pedidoCompleto pedidoCompleto;         // Inicializamos el evento igual al delegate 
        private Product productoValido;                     // Inicializamos un producto 
        private List<Product> Pedido;                       // Inicializamos pedido (Receta de compra)

        public HermanaMayor(pedidoCompleto PedidoCompleto)  // Constructor
        {
            pedidoCompleto = PedidoCompleto;                // Igualamos el evento al delegate para utilizarlo
            Pedido =null;
            try
            {
                Pedido = Cargar("datosPedidos");            // Cargamos archivo
            }
            catch                                           // En caso de error
            {
                Pedido = new List<Product>();               // Creamos un nuevo pedido
                Receta(Pedido);                             // Agregamos los productos al pedido
            }
        }

        public void Validar(restringirCompra RestingirCompra, Product producto)   // Metodo en el cual se obtiene el delegate
        {
            restringirCompra = RestingirCompra;         // igualamos el delegate al evento
            productoValido = producto;                  // guardamos la variable producto en una variable valida para cualquier método de HermanaMayor
            Console.Clear();
            int valor = -1;
            if (Pedido.Count() == 0)                    // Vemos si se a comprado todo
            {
                restringirCompra(null);                 // Enviamos un valor nulo a la función del delegate "Comprobar"
                pedidoCompleto(true);                   // Enviamos un valor true a la función del delegate "ListaVacia"
            }
            else
            {
                for (int i = 0; i < Pedido.Count(); i++)        // Recorremos el pedido
                {
                    if (String.Compare(Pedido[i].Name, productoValido.Name, true) == 0)     // Comprobamos si el producto esta en la lista de compra
                    {
                        restringirCompra(productoValido);           // Enviamos el producto a la función del delegate "Comprobar"
                        Pedido.RemoveAt(i);                         // Removemos el producto
                        Guardar();                                  // Utilizamos el método Guardar
                        valor = 0;                                  
                    }
                }
                if (valor != 0)                                    // En el caso que el producto no este en la lista
                {
                    restringirCompra(null);                         // Enviamos un valor nulo a la función del delegate "Comprobar"
                    Console.WriteLine("Producto invalido");
                    Console.WriteLine("\n\nPresiona ENTER para volver al supermercado...");
                    Console.ReadLine();
                }
            }
        }

        private void Receta(List<Product> receta)               // Creamos el pedido de la Receta
        {
            receta.Add(new Product("Leche Entera", 820, 89, "1L")); //ingrediente receta
            receta.Add(new Product("Mantequilla", 850, 12, "125g")); //ingrediente receta
            receta.Add(new Product("Pimienta", 430, 84, "15g")); //ingrediente receta
            receta.Add(new Product("Vino Sauvignon Blanc Reserva Botella", 4150, 23, "750cc")); //ingrediente receta
            receta.Add(new Product("Sal Lobos", 330, 150, "1kg")); //ingrediente receta
            receta.Add(new Product("Láminas de Lasaña", 1250, 85, "400g")); //ingrediente receta
            receta.Add(new Product("Harina", 890, 43, "1kg")); //ingrediente receta
            receta.Add(new Product("Carne Molida", 4390, 15, "500g")); // ingrediente receta
            receta.Add(new Product("Aceite de Oliva", 1790, 77, "250g")); //ingrediente receta
            receta.Add(new Product("Malla de Cebollas", 1090, 91, "1kg")); //ingrediente receta
            receta.Add(new Product("Tomates Pelados en lata", 700, 48, "540g")); //ingrediente receta
            receta.Add(new Product("Queso Parmesano", 3790, 41, "200g")); //ingrediente receta
            receta.Add(new Product("Bolsa de Zanahorias", 890, 74, "1un")); //ingrediente receta
        }

        public void Guardar()       // Funcion para guardar
        {
            FileStream fs = new FileStream("datosPedidos", FileMode.Create);    // Creamos o editamos archivo 
            IFormatter formatter = new BinaryFormatter();                       // Definimos el formato (En este caso binario)
            formatter.Serialize(fs, Pedido);                                    // Serializamos la variable "cart" y la guardamos en el archivo definido  "fs"
            fs.Close();                                                         // Cerramos archivo "fs"
        }

        private List<Product> Cargar(string direccion)      // Funcion para cargar dato de tipo "List<Product>"
        {
            FileStream fs = new FileStream(direccion, FileMode.Open);               // Abrimos archivo 
            IFormatter formatter = new BinaryFormatter();                           // Definimos el formato (En este caso binario)
            List<Product> Pedido = formatter.Deserialize(fs) as List<Product>;      // Deserializamos el archivo y lo guardamos en la variable "Pedido"
            fs.Close();                                                             // Cerramos archivo "fs"
            return Pedido;                                                          // retornamos la variable creada
        }
    }
}
