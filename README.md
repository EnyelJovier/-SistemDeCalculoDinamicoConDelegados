# SistemDeCalculoDinamicoConDelegados

## Explicación del problema
Este proyecto consiste en desarrollar una aplicación de consola en C# que permita realizar operaciones matemáticas básicas (suma, resta, multiplicación y división).  
El objetivo principal es ejecutar estas operaciones de forma dinámica utilizando delegados, evitando el uso de estructuras condicionales como "if" o "switch".

##  ¿Qué es un delegado?
Un delegado en C# es un tipo que permite almacenar referencias a métodos.  
Esto significa que una variable puede apuntar a un método y ejecutarlo posteriormente.

En este proyecto, el delegado se utiliza para almacenar diferentes operaciones matemáticas y ejecutarlas según la opción seleccionada por el usuario.

## ¿Por que usar delegados en vez de llamar metodos directamente?

En mi opinión, usar delegados hace que el programa sea más flexible y fácil de manejar. En vez de estar usando muchos "if" o "switch" para decidir qué operación ejecutar, simplemente se puede asignar el método directamente y ejecutarlo.

Además, siento que el código se ve más organizado y limpio, ya que no se repite lógica innecesaria. También es más fácil agregar nuevas operaciones en el futuro sin tener que modificar todo el programa, solo se añade el método y ya.

En general, aunque al principio puede ser un poco difícil de entender, los delegados ayudan a que el programa sea más dinámico y mejor estructurado.

##  ¿Cómo se implementaron en el proyecto?

1. Se creo un delegado que recibe dos numeros y retorna un resultado.
2. Se implementaron los métodos matemáticos (Sumar, Restar, Multiplicar y Dividir).
3. Se utilizó un diccionario para relacionar cada opción con un método.
4. El usuario selecciona una operación.
5. Se asigna el método al delegado.
6. Se ejecuta el delegado para obtener el resultado.

## Ejemplo de uso

**Entrada:**

Ingrese el primer numero: 10
Ingrese el segundo numero: 5

Seleccione el tipo de operacion:
1.Sumar
2.Restar
3.Multiplicar
4.Dividir

Opcion: 4

**Salida:**
Resultado: 2

## Capturas del programa en ejecución en distintos escenarios.

1.Suma

<img width="535" height="299" alt="image" src="https://github.com/user-attachments/assets/da2eef54-449a-4805-b9b8-209cfdb064bc" />

2.Resta

<img width="569" height="284" alt="image" src="https://github.com/user-attachments/assets/6f63b047-e9b2-4397-b7e0-a90020045874" />

3.Multiplicacion

<img width="538" height="292" alt="image" src="https://github.com/user-attachments/assets/eaab1b7b-6cec-4d6c-986c-4c4815e29a9f" />

4.Division

<img width="537" height="286" alt="image" src="https://github.com/user-attachments/assets/a1604f37-4ca7-4d2b-8429-d614735794f5" />
