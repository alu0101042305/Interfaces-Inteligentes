# Físicas en Unity
El objetivo de esta práctica es aprender a usar las físicas de Unity así como su funcionamiento, usando conceptos como eventos (estos ya los habíamos usado en prácticas anteriores), RigidBody y Colliders. Para ello implementamos una escena con los siguientes elementos:

* Un personaje que además de poder desplazarse con I, J, L, M respondiera a la física (Ethan en mi caso).
* Dos esferas con físicas que contabilizaran las colisiones con el personaje: una fija y otra rodando aleatoriamente.
* Varios cilindros que cambien su color cuando colisionan contra ellos.

Los scripts implementados fueron:
* [CollisionColor](/p3/CollisionColor.cs) para cambiar el color según lso eventos de colisión
* [CollisionCount](/p3/CollisionCount.cs) para contar colisiones (incrementa una variable estática).
* [Movement](/p3/Movement.cs) implementa el movimiento de Ethan.
* [RandomMovement](/p3/RandomMovement.cs) implementa el movimiento de la esfera.

![Gif](/p3/gif.gif)
