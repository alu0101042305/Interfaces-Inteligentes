# Delegados, Eventos
El objetivo de esta práctica es famirializarnos con el funcionamiento de los eventos en Unity utilizando conceptos como: delegados,
el controlador de escena, el patrín singleton... Incorporamos los siguientes elementos en la escena:

* Un personaje desplazable por el jugador.
* Dos tipos de objetos diferenciados: los objeto de tipo A incrementan el poder del personaje cuando detectan una colisión;
los del tipo B análogamente decrementan el poder y además cambian todos de a un color cuando se produce el evento de colisión con 
cualquiera de ellos.
* Una luz en forma de foco que se pueda apagar y encender pulsando una tecla.

Los scripts implementados para esta práctica son:
* [GameController](/p4/GameController.cs) se corresponde con el controlador de la escena.
* [LightController](/p4/LightController.cs) implementa la funcionalidad para desactivar y activar el componente Light de un GameObject.
* [Movement](/p4/Movement.cs) implementa el movimiento de un GameObject con el teclado usando la física de Unity.
* [PlayerBehaviour](/p4/PlayerBehaviour.cs) asigna los listeners al objeto jugador (para aumentar y decrementar su poder).
* [SquareBehaviour](/p4/SquareBehaviour.cs) dispara el evento de la colisión con un cuadrado.
* [SphereBehaviour](/p4/SphereBehaviour.cs) dispara el evento de colisión con una esfera y además escucha ese mismo evento, cambiando de color el material
cuando se dispara.

![](/p4/gif.gif)
