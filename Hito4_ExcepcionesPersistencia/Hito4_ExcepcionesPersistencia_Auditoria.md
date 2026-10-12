# Bitácora de Auditoría — Hito 4: Excepciones y Persistencia
**Estudiante: O. Yahir Santoyo Sanchez
**Número de Control: 23531082

### 1. Jerarquía de Excepciones Propias
*¿Por qué es preferible crear excepciones de dominio en lugar de lanzar System.Exception genérico?*
>R = En este caso mi respuesta se basa en lo siguiente que son Las excepciones propias (por ejemplo, ArchivoNoEncontradoException, PersistenciaException, ValidacionFormatoException) describen exactamente qué falló, lo que facilita entender el problema sin inspeccionar el mensaje de texto y Al definir una jerarquía de excepciones, la API comunica a los consumidores qué errores pueden ocurrir y cómo deben reaccionar con Contratos claros y Las pruebas unitarias pueden verificar que se lanza la excepción específica esperada; los logs y alertas pueden agruparse por tipo de excepción para análisis y métricas que den Mantenibilidad y pruebas claras.

### 2. Manejo de Recursos y Persistencia I/O
*¿Qué riesgos existen al interactuar con el disco sin estructuras try/catch/finally?*
> R = En mi conocimento adquirido los riesgos que existen pueden ser los siguientes Fugas de recursos,Corrupción de datos,Bloqueos y deadlocks,Excepciones no controladas,Pérdida de trazabilidad al interactuar con archivos y dispositivos de almacenamiento sin un manejo explícito de excepciones y sin asegurar la liberación de recursos expone al sistema a fallos operativos, pérdidas de datos y problemas de seguridad. A continuación tienes una explicación clara, organizada y con recomendaciones prácticas.

### 3. Evidencia de Ejecución
Pega la salida completa de dotnet run con las 4 pruebas en verde.
