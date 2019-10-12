1. Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados.

Todos los GameObject tienen ligada una instancia de la clase Transform (accesible desde la propiedad transform). Los métodos de esta clase nos permiten realizar transformaciones al sistema de referencia de un objeto: Translate (para trasladar), Rotate (para rotar) y la propiedad localScale que podemos modificar para cambiar la escala local de un objeto.

2. ¿Cómo duplicarías el tamaño de un objeto en en un script?.

```cs
transform.localScale *= 2
```
3. Cómo situarías un objeto en la posición (3,5,1).

```cs
transform.position = new Vector3(3, 5, 1);
```
4. Como trasladarías 3 metros en cada uno de los ejes y luego lo rotas 30º alrededor del eje Y?

```cs
transform.translate(Vector3.one * 3);
transform.rotate(Vector3.up * 30);
```
5. Como rotarías un objeto sobre el eje (1,1,1)

```cs
transform.translate(Vector3.one);
transform.rotate(vectorDeRotacion);
transform.translate(-Vector3.one);
```
6. Rota un objeto alrededor del eje Y 30ª y desplázalo 3 metros en cada uno de los ejes. ¿Obtendrías el mismo resultado que en 4?

No obtenemos el mismo resultado, porque al trasladar los ejes sin aplicarles ninguna transformación, estos se desplazan 3 metros respecto a la posición inicial del objeto, pero si los rotamos primero se desplazarán 3 metros respecto a la posición de los ejes resultante de la rotación, que no es la misma que la original.

7. Como puedes obtener la distancia al plano cerca del volumen de vista

Accesible en la propiedad **Camera.nearClipPlane**.

8. Como puedes realizar la proyección al espacio 2D

```cs
camera.WorldToViewportPoint(point);
```

9. Investiga qué son los quaternion.

Los quaternion (cuaterniones en español) son un cojunto numérico que extiende a los reales en el que cada elemento es un ℝ-espacio vectorial de dimensión 4 formado por los componentes: 1, i, j y k; siendo los 3 últimos imaginarios.
Sus componentes, igual que los números imaginarios (donde i<sup>2</sup> = -1), tienen una tabla de multiplicación propia.

|  | 1 | i  | j  | k  |
|---|---|----|----|----|
| **1** | 1 | i  | j  | k  |
| **i** | 1 | -1 | k  | -j |
| **j** | j | -k | -1 | i  |
| **k** | k | j  | -i | -1 |

10. Analiza la documentación de la cámara en Unity 3D: [Link 1](https://docs.unity3d.com/es/current/Manual/CamerasOverview.html) [Link 2](https://docs.unity3d.com/es/current/Manual/class-Camera.html) e identifica los conceptos explicados respecto a la cámara.

Los conceptos explicados respecto a la cámara son:

 * Dos **tipos de proyecciones** que implementa Unity: en perspectiva y ortogonal
 * La **región (o volumen) de vista**. Equivale a una pirámide truncada para la proyección en perspectiva o a un rectángulo en la ortogona.
 * El **fondo de la vista** de una cámara. Este se suele rellenar con algún color entero o usando diferentes técnicas, por ejemplo usar un [SkyBox](https://docs.unity3d.com/es/current/Manual/class-Skybox.html).
 * Definición del objeto Camara. Es un GameObject más de la escena con parámetros, componentes y pueden coexistir varias en la misma escena.
    
11. ¿Como puedes averiguar la matriz de proyección que se ha usado para proyectar la escena al último frame renderizado?.

Accesible en la propiedad **Camera.previousViewProjectionMatrix**.

12. ¿Cómo puedes obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?.

Accesible en la propiedad **Transform.localToWorldMatrix**.

13. ¿Como puedes calcular las coordenadas del sistema de referencia de un objeto con las siguientes propiedades del Transform: Position (3, 1, 1), Rotation (45, 0, 45)?
```cs
transform.position = new Vector3(3, 1, 1);
transform.Rotate(45, 0, 45);
print(transform.TransformPoint(Vector3.zero));
```
