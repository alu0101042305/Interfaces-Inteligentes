# Iluminación
Busca información sobre los siguiente términos, explica brevemente en qué consisten. Determina para cada uno de ellos, alguna vía de incorporarlo en tu proyecto.
## Light mapping
Proceso de calcular la luminosidad de superficies de la escena 3D y almacenarlas en memoria para usarlas más tarde en repetidas ocasiones si es necesario. Las estructuras de memoria donde se guardan estos datos se llaman **lightmaps** que viene siendo una textura de luces.

Unity nos permite modificar las opciones generales del Lightmapping en **Window > Rendering > Lighting Settings** además de poder activar su uso (o no) para cada malla de la escena en el inspector de objetos.
## Bump mapping y Normal mapping
**Bump mapping** es una técnica de gráficos computacionales 3D creada por James F. Blinn en 1978 cuyo objetivo es simular superficies con aspectos rugosos.
Consiste en alterar los vectores normales de la superficie sin cambiar su geometría, de esta manera se consigue modificar la intensidad luminosa en los diferentes puntos de la superficie obteniendo un efecto, aunque con menos detalle, similar al deseado  y sin aumentar su coste computacional.

**Normal Mapping** extiende la técnica de Bump mapping de manera que las normales de una superficie pueden ser transformadas en sus 3 componentes (en Bump mapping solo se modifica el componente que representa altura, aunque a veces ambos términos se utilizan indistintamente).

En Unity podemos encontrar en las opciones de los materiales **Normal Map** para aplicar un mapa de normales. Cada texel de la textura representa una desviación de la dirección del vector normal a la superficie.

En la actualidad los **Bump Map** están en deshuso ya que es posible conseguir el mismo o mejor resultado con un Normal Map, aunque a veces se siguen utilizando por eficiencia al contar con 1 sola componente. En Unity los Shaders del tipo Bumped se encuentran en **Legacy Shaders** aunque también en **Mobile** ya que los materiales en movimientos requieren mayor cantidad de cálculos que quizás es necesario optimizar.
## Sky Box
Método normalmente ligado a los videojuegos para crear fondos en la escena y que esta luzca visualmente mayor o incluso sin límites. Consiste en encapsular la escena con un una imagen como textura, este encapsulamiento puede tener diferentes formas, las más cómunes son un cubo o una esfera (esta última se le denomina Skydome).

Unity nos permite definir SkyBox en forma de materiales y podemos asignarlos a una escena (SkyBox por defector) en **Window > Rendering > Lighting Settings**, o también podemos asignarle un SkyBox a una cámara en particular.
## Enviroment mapping
También concocido como Reflection mapping es una técnica que consiste en simular el aspecto de una superficie reflectiva mapeando sobre ella una textura que normalmente suele ser una imagen del entorno alrededor del objeto.

Los Shaders del tipo **Standard** ya incluyen esta funcionalidad usando el Sky Box como textura para mapear en función de su grado de **Metallic y Smoothness**.
## Iluminación global
Modelo de iluminación en el que se calcula la intensidad de luz de la superficie de un objeto en función de una o más fuentes de luz y
además por la luz que reflejan los restantes objetos de la escena.

Unity usa por defecto este modelo para iluminar la escena.
