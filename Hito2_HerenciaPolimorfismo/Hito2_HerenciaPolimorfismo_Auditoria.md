# Bitácora de Auditoría — Hito 2: Herencia y Polimorfismo
**Estudiante:**  
**Número de Control:**  

### 1. Clases Abstractas vs. Interfaces
*¿Por qué FiguraGeometrica es una clase abstracta mientras que IDibujable es una interfaz?*
> Yo pienso en base a lo que eh visto en este curso y Tareas/Actividades que eh realizado,una clase abstracta como FiguraGeometrica representa un concepto general que sirve de base para construir objetos más específicos. No se trata de algo que pueda existir por sí mismo, sino de un molde que asegura que todas las figuras compartan atributos comunes (color, posición, dimensiones). Además, me permite definir métodos que pueden estar parcialmente implementados y otros que obligan a las subclases a dar su propia versión.
Por otro lado, una interfaz como IDibujable no busca compartir atributos ni lógica, sino establecer un contrato: cualquier clase que la implemente debe garantizar que puede ser dibujada. Esto es útil porque incluso objetos de familias distintas pueden compartir esa capacidad. En resumen, la clase abstracta organiza y da coherencia a una jerarquía, mientras que la interfaz abre la puerta a la flexibilidad y la interoperabilidad.

### 2. Ligadura Dinámica (override)
*Explica cómo el programa sabe qué método CalcularArea() ejecutar al iterar List<FiguraGeometrica>:*
> Lo fascinante del polimorfismo en lo que entendí en este caso es que el programa no necesita saber de antemano qué tipo de objeto está recorriendo en la lista. Cuando invoco CalcularArea(), el sistema utiliza la ligadura dinámica para decidir en tiempo de ejecución qué versión del método corresponde. Si el objeto es un círculo, se ejecuta la fórmula del círculo; si es un rectángulo, la del rectángulo.
Esto me parece poderoso porque refleja cómo en la vida real tratamos a los objetos por lo que son, sin necesidad de preguntar constantemente “¿qué tipo eres?”. El código se vuelve más limpio y extensible, y cada clase se responsabiliza de su propio comportamiento.

### 3. Evidencia de Ejecución
Pega la salida completa de dotnet run con las 4 pruebas en verde.
