# Experiencia de Usuario en Realidad Virtual

Cuando diseñamos una aplicación de realidad virtual uno de los puntos a tener en cuenta es garantizar el confort del usuario. 
Normalmente la cámara en las aplicaciones VR se controla con la rotación de la cabeza del usuario, por ello una buena aplicación
de VR tendrá su interfaz dispuesta de manera que todas sus funciones sean accesibles a través de la menor rotación de la cámara posible.

## Rotación de confort

Si tuvieramos un sistema de referencia en la cabeza en el que el eje X fuera paralelo al suelo, el Y apuntara al cielo y el Z fuera 
perpendicular a ambos, unos posibles límites de rotación serían:

|                        | Rotación confortable | Máxima rotación |
|-------------------------|----------------------|-----------------|
| Eje X (horizontal) | 10º                  | 50º             |
| Eje Y (vertical)        | 30º                  | 55º             |
|          Eje Z          | 0º                   | 30º             |

*Para clarificar: el eje X equivaldría a girar la cabeza para mirar hacia arriba o abajo; el Y mirar hacia la izquierda o la derecha;
y el Z equivaldría a inclinar la cabeza (sin mirar) a izquierda o derecha.*

El usuario debe sentir que tiene acceso a toda la interfaz en una rotación confortable y quizás deba rotar aún más las cabeza (sin pasar 
el máximo) en momentos puntuales de la aplicación.

## Zona de confort

En las aplicaciones VR también es usual establecer una zona de confort. Como ya hemos explicado antes es recomendable evitar en la medida
de lo posible la rotación de la cabeza del usuario y por ello la vista del usuario podemos separarla en 4 partes:

* **No Zone**. Radio de medio metro alrededor del usuario en el que no hay objetos.
* **Zona de confort**. Estará formada por 140º (70º a la izquierda y otros 70º a la derecha) y centrada en el centro de la vista del usuario.
* **Peripheral Zone**. Laterales de la vista. Sin objetos interactivos. Pueden haber objetos decorativos que no llamen la atención.
* **Curiosity Zone**. Parte trasera de la vista. Sin objetos interactivos. Sin objetos decorativos.

En la **zona de confort** debe estár concentrada la atención del usuario así como los objetos interactivos, de manera que cuanto más peso 
tenga en la escena un objeto, más cerca del usuario debería estar, siendo los objetos más alejados parte del fondo de la escena.

## Cardboard Design Lab

Algunos buenos diseños de VR que implementa Cardboard Design Lab son:
* **Zona de Confort**. Cada vez que se inicia una escena nueva la vista es centrada en la zona de confort.
* No tiene mensajes estáticos, sino que todos acompañan a la escena y cuando la aplicación no tiene claro si el usuario está en una posición confortable (ej: al iniciar la aplicación), crea cuatro mensajes idénticos envolviendo el entorno en un cuadrado, de manera que el usuario tenga que realizar el menor giro posible.
* Los cambios de escena o la aparición de objetos no son instantáneos, sino que aparecen de manera gradual desvaneciéndose.
* Pinta una retícula para que el usuario sea consciente de donde está el centro de la vista en todo momento y pueda reaccionar en consecuencia.
* Usa sonidos como un grado de inmersión más en la realidad virtual.
