Inicio del programa

Definir clase Mascota

    Atributos privados:
        - nombre (cadena)
        - edad (entero)
        - tipo (cadena) // Puede ser "perro", "gato", "pajaro", etc.
        - sonido (cadena) // El sonido que emite la mascota

    Método Constructor Mascota(nom, ed, tip, son)
        Asignar nom a nombre
        Asignar ed a edad
        Asignar tip a tipo
        Asignar son a sonido

    Método EmitirSonido()
        Imprimir sonido // Imprime el sonido característico de la mascota

    Método MostrarInformacion()
        Imprimir "Nombre: " + nombre
        Imprimir "Edad: " + edad + " años"
        Imprimir "Tipo: " + tipo
        Imprimir "Sonido: " + sonido

Fin clase Mascota

Definir clase principal Program
    Método Main()
        // Crear objeto miMascota de tipo Mascota con valores:
        Crear objeto miMascota de tipo Mascota con valores:
            - nombre = "Firulais"
            - edad = 3
            - tipo = "perro"
            - sonido = "Guau guau!"

        // Llamar a los métodos de miMascota
        Llamar al método EmitirSonido() del objeto miMascota
        Llamar al método MostrarInformacion() del objeto miMascota

Fin clase Program

Fin del programa