Inicio del programa

Definir clase Mascota

    Atributos privados:
        - nombre (cadena)
        - edad (entero)
        - tipo (cadena)
        - sonido (cadena)

    Método Constructor Mascota(nom, ed, tip, son)
        Asignar nom a nombre
        Asignar ed a edad
        Asignar tip a tipo
        Asignar son a sonido

    Método getEdad()
        Retornar edad

    Método setEdad(nuevaEdad)
        Si nuevaEdad es mayor o igual a 0 ENTONCES
            Asignar nuevaEdad a edad
        SINO
            Imprimir "Error: La edad no puede ser negativa."
        Fin Si

    Método calcularEdadHumana()
        edadHumana = edad * 7
        Retornar edadHumana

    Método EmitirSonido()
        Imprimir sonido

    Método MostrarInformacion()
        Imprimir "Nombre: " + nombre
        Imprimir "Edad: " + edad + " años"
        Imprimir "Tipo: " + tipo
        Imprimir "Sonido: " + sonido

Fin clase Mascota

Definir clase principal Program
    Método Main()
        Crear objeto miMascota de tipo Mascota con valores:
            - nombre = "Firulais"
            - edad = 3
            - tipo = "perro"
            - sonido = "Guau guau!"

        Llamar al método EmitirSonido() del objeto miMascota
        Llamar al método MostrarInformacion() del objeto miMascota

        Imprimir "--- Nuevos métodos ---"

        Imprimir "La edad actual de " + miMascota.nombre + " es: " + miMascota.getEdad() + " años."

        Imprimir "La edad de " + miMascota.nombre + " en años humanos sería: " + miMascota.calcularEdadHumana() + " años."

        Llamar al método setEdad(5) del objeto miMascota
        Imprimir "Se ha actualizado la edad de " + miMascota.nombre + " a " + miMascota.getEdad() + " años."

        Llamar al método MostrarInformacion() del objeto miMascota
        Imprimir "La nueva edad de " + miMascota.nombre + " en años humanos sería: " + miMascota.calcularEdadHumana() + " años."

        Imprimir "--- Probando edad inválida ---"
        Llamar al método setEdad(-2) del objeto miMascota
        Imprimir "Edad después de intento inválido: " + miMascota.getEdad() + " años."

Fin clase Program

Fin del programa