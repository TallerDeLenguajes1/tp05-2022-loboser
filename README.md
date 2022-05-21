# tp05-2022-loboser

### Ejercicio 4:

* **¿String es un tipo por valor o un tipo por referencia?**

El tipo string representa una secuencia de cero o más caracteres Unicode. string es un alias de System.String en .NET.

Aunque string es un tipo de referencia, se definen los operadores de igualdad == y != para comparar los valores de los objetos string, no las referencias.

* **¿Qué secuencias de escape tiene el tipo string?**


\'	Comilla simple

\"	Comillas doble

\\	Slash inverso

\0	Nulo

\a	Alerta

\b	Retroceso

\f	Alimentación de Formulario

\n	Nueva linea

\r	Retorno de carro

\t	Tabulación Horizontal

\v	Tabulación Vertical

\u	Unicode (UTF-16)

\U	Unicode (UTF-32)

\x	Unicode (similar a \u excepto con variable de longitud)


* **¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?**

Toma el simbolo y no utiliza secuencias de escape.

### Ejercicio 5:

* **Busque en diferentes bibliografías que son y cómo funcionan las expresiones regulares.**

* **¿Funcionan únicamente en C#?**

No, tambien funcionan en C++, Python, Java, Javascript, PHP, entre otros.

* **¿En qué casos le parecen útiles? Enuncie al menos 3.**

Nos permite verificar algo de forma automatica, para confirmar una parte de validez

Filtrar textos

Buscar en textos

* **¿Cómo se hace uso de estas en C#?**

Se utiliza mediante la libreria System.Text.RegularExpressions mediante la clase Regex