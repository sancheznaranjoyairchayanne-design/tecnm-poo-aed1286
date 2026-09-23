# Lección 2: Jerarquías, Contratos y Polimorfismo
**Asignatura:** Programación Orientada a Objetos (AED-1286)  
**Nivel:** Conceptos Fundamentales desde Cero  

---

## 1. El Problema del Código Duplicado

En el Hito 1 modelaste entidades aisladas. Ahora imagina que te piden modelar un software de dibujo vectorial:
* Tienes un `Circulo` (con color, posición y radio).
* Tienes un `Rectangulo` (con color, posición, base y altura).
* Tienes un `Triangulo` (con color, posición, base y altura).

Si creas tres clases independientes sin conexión:
1. Repetirás los mismos atributos (`Color`, `PosicionX`, `PosicionY`) tres veces.
2. Si cambias cómo se maneja la posición, tendrás que editar tres archivos distintos.
3. Lo peor: no podrás guardar todos tus objetos dentro de una sola lista unificada porque para la computadora son tipos completamente incompatibles.

Para resolver esto existen dos pilares del paradigma: **Herencia** y **Polimorfismo**.

---

## 2. Herencia: La Relación "Es-Un"

La **Herencia** permite definir una clase base (padre) con los atributos y comportamientos comunes, para que otras clases derivadas (hijas) los adopten automáticamente.

### La regla de oro: La prueba "Es-Un" (*Is-A*)
Antes de heredar, hazte siempre esta pregunta:  
* ¿Un Círculo **es una** Figura Geométrica? **Sí.** (Herencia válida).  
* ¿Un Automóvil **es un** Motor? **No.** Un automóvil *tiene un* motor, no *es* un motor. (Herencia inválida; esto es composición).

---

## 3. Clases Abstractas: La Idea Incompleta

¿Cómo se calcula el área de una "Figura Geométrica"?  
La pregunta no tiene sentido: no puedes calcular el área de un concepto abstracto. Necesitas saber si es un círculo, un cuadrado o un triángulo.

* Una **Clase Abstracta** es una clase que representa un concepto genérico e incompleto.
* **Regla estricta:** **Jamás se puede instanciar directamente** (no puedes hacer `new FiguraGeometrica()`).
* Su propósito es servir de base arquitectónica y obligar a las clases hijas a definir los métodos abstractos (los métodos que solo tienen nombre pero no cuerpo de código).

---

## 4. Polimorfismo: Muchas Formas bajo un Mismo Nombre

La palabra **Polimorfismo** viene del griego y significa *"muchas formas"*. 

En software, es la capacidad de tratar a un grupo de objetos distintos como si fueran del mismo tipo base, y que cada uno responda de manera particular al recibir la misma orden.

```text
               ┌───────────────────────┐
               │ FiguraGeometrica (Abs)│
               │   CalcularArea()      │
               └───────────┬───────────┘
                           │
           ┌───────────────┴───────────────┐
           ▼                               ▼
  ┌──────────────────┐           ┌──────────────────┐
  │     Circulo      │           │    Rectangulo    │
  │ CalcularArea() = │           │ CalcularArea() = │
  │    π * r²        │           │    base * altura │
  └──────────────────┘           └──────────────────┘
```

Si tienes una colección heterogénea:

```text
List<FiguraGeometrica> lienzo = [ Circulo, Rectangulo, Circulo ];
```
Puedes recorrer la lista con un solo ciclo y ordenar a todos: figura.CalcularArea().

El compilador y la máquina virtual se encargarán en tiempo de ejecución (ligadura dinámica) de ejecutar la fórmula matemática correcta para cada objeto individual sin usar if ni switch.

## 5. Interfaces: Los Contratos de Capacidad
Una Interfaz no describe qué es el objeto, sino qué sabe hacer (una capacidad o contrato).

Diferencia crucial: Clase Abstracta vs. Interfaz
- Clase Abstracta ("Qué es"): Identidad y parentesco. Un Circulo es una FiguraGeometrica. Comparte atributos físicos protegidos (como el nombre o el color).

- Interfaz ("Qué puede hacer"): Un contrato estricto.

  Imagina la interfaz IDibujable con la orden Dibujar().

    - Un Circulo se puede dibujar.

    - Un Rectangulo se puede dibujar.

    - Un BotonDePantalla se puede dibujar (¡pero no es una figura geométrica!).

    - Un Texto se puede dibujar (¡tampoco es una figura geométrica!).

    - Una clase solo puede tener un padre biológico (herencia simple), pero puede firmar y cumplir múltiples contratos (interfaces).

## 6. Preguntas de Autoevaluación
1. Si una clase abstracta no se puede instanciar con new, ¿para qué sirve programarla?
-  R= Su utilidad está en que me permite definir un marco común. Es como un plano arquitectónico: no vivo en el plano, pero gracias a él puedo construir casas distintas con una base coherente. Así, las subclases heredan atributos y métodos que les dan consistencia, y al mismo tiempo se ven obligadas a implementar lo que la clase abstracta dejó pendiente.

3. ¿Por qué es una mala práctica abusar de condicionales if (tipo == "Circulo") en lugar de usar polimorfismo?
- R= Ya que cuando el código está lleno de condicionales como if (tipo == "Círculo") como lo entiendo, se vuelve rígido y difícil de mantener. Cada vez que agrego una nueva figura, debo modificar esos condicionales, lo que rompe el principio de que el software debe estar abierto a extenderse pero cerrado a cambios innecesarios, Y también Tomando en Cuenta el polimorfismo su Funcion evita esa fragilidad; cada clase sabe cómo comportarse y el programa simplemente confía en que el método correcto se ejecutará. Para mí ya para acabar este apartado (Punto 3), esto es como delegar responsabilidades en lugar de que un único bloque de código decida todo, cada objeto se hace cargo de sí mismo.

5. Da un ejemplo real donde dos objetos de familias totalmente distintas compartan la misma interfaz.
- R = Un ejemplo que me gustaría poner aquí en este apartado es la interfaz IImprimible. Como una Factura y una Fotografía son objetos de mundos totalmente distintos, uno pertenece al ámbito contable y otro al artístico. Sin embargo, ambos pueden implementar la misma interfaz porque comparten la capacidad de ser impresos.
Esto demuestra que las interfaces son puentes entre realidades distintas, y que lo importante no es la naturaleza del objeto, sino la acción que pueden llegar a realizar.
