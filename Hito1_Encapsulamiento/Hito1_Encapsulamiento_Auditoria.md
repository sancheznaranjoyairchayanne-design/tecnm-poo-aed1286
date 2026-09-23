# Bitácora de Auditoría — Hito 1: Encapsulamiento y Constructores
**Estudiante:**  
**Número de Control:**  

### 1. Principio de Encapsulamiento
*¿Por qué los campos internos deben ser privados y exponerse mediante propiedades controladas?*
- R=En mi experiencia como estudiante de POO los campos internos deben ser privados y gestionarse mediante propiedades controladas porque representan el núcleo de la identidad de un objeto. Si se permitiera el acceso directo, cualquier parte externa podría alterar su estado sin restricciones, lo que generaría inconsistencias y errores difíciles de rastrear además de eso el encapsulamiento no es solo una regla técnica, sino una forma de disciplinar la interacción con los datos al protegerlos, es decir en pocas palabras el encapsular es como poner un candado inteligente: no bloquea el acceso, pero lo regula para que solo se use de manera correcta y segura como se le haya programado .

### 2. Delegación de Constructores con : this(...)
*Explica el beneficio de reutilizar constructores encadenados en lugar de copiar código de inicialización:*
-R= Personalmente, lo veo yo como un ejemplo de pensar en el futuro ya que reutilizar constructores encadenados es una práctica que refleja madurez en el diseño orientado a objetos. En lugar de repetir la misma lógica en varios constructores, se centraliza en uno solo y los demás delegan hacia él, Y tomando en cuenta lo anteriormente dicho aquí mismo a que hoy puede parecer un detalle menor, pero cuando el proyecto crece y se añaden nuevas reglas, esa delegación evita errores y simplifica la vida y el trabajo del programador.

### 3. Evidencia de Ejecución
Pega la salida completa de dotnet run con las 4 pruebas en verde.
<img width="992" height="158" alt="image" src="https://github.com/user-attachments/assets/c55a8f45-e61e-42da-932f-f1f9920ec7d7" />


