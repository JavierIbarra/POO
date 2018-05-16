Como Crear y Utilizar una Libreria(.dll):

- Para crear una libreria debes crear un nuevo proyecto del tipo "Biblioteca de clases(.NET Framework)" y agreagarlo a la solucion.

- Para utilizar la libreria debes compilar el proyecto de la libreria y agregarla en la referencia de tu proyecto principal.

- Cada vez que quieras hacer un cambio en la libreria "Registro" se debe compilar la libreria y luego ejecutar el programa 

Ejemplo 2:

La idea de este ejemplo es calcular su un rut es valido. (https://es.wikipedia.org/wiki/Rol_%C3%9Anico_Tributario)

La solucion "Ejemplo2" contiene 2 proyectos ("Ejemplo2" y "Registro") de los cuales uno es una libreria.

El proyectro "Ejemplo2" utiliza la libreria "Registro".

En la libreria "Registro" se encuentra la clase "Persona" que contiene el metodo "VerificarRut".

