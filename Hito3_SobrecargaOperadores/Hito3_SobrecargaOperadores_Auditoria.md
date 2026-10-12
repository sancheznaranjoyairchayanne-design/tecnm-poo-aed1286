# Bitácora de Auditoría — Hito 3: Sobrecarga de Operadores
**Estudiante: O. Yahir Santoyo Sanchez.
**Número de Control: 23531082

### 1. Semántica de Sobrecarga de Operadores
*¿Por qué en C# los métodos de sobrecarga de operadores (operator +) deben ser public static?*
> R = En el lenguaje C#, eh visto que los métodos que implementan la sobrecarga de operadores deben ser public static porque los operadores se definen como funciones de tipo (no de instancia) que actúan sobre los operandos y deben ser accesibles desde fuera de la clase sin requerir una instancia; además el lenguaje exige la firma estática para mantener coherencia semántica y evitar ambigüedades en la resolución de llamadas.

### 2. Inmutabilidad y Nuevas Instancias
*Cuando se ejecuta c = a + b, ¿por qué debe retornarse una nueva instancia de Matriz2D?*
> R = En este caso de el a + b debe devolver una nueva instancia porque así se preserva la inmutabilidad de los operandos, se evitan efectos secundarios inesperados y se facilita el razonamiento sobre el código (especialmente en contextos concurrentes o cuando otras referencias apuntan a las mismas matrices) , así se evita efectos secundarios no deseados y facilita pruebas y depuración con seguridad en concurrencia.

### 3. Evidencia de Ejecución
Pega la salida completa de dotnet run con las 4 pruebas en verde.
<img width="466" height="110" alt="image" src="https://github.com/user-attachments/assets/f4005dbe-bb2c-4b6e-871a-d400e10fc5a9" />
<img width="367" height="49" alt="image" src="https://github.com/user-attachments/assets/b6e10252-56a5-42ac-9afb-64db8fa68ac8" />
