# Iluminación
Busca información sobre los siguiente términos, explica brevemente en qué consisten. Determina para cada uno de ellos, alguna vía de incorporarlo en tu proyecto.
## Light mapping
Proceso de calcular la luminosidad de superficies de la escena 3D y almacenarlas en memoria para usarlas más tarde en repetidas ocasiones si es necesario. Las estructuras de memoria donde se guardan estos datos se llaman **lightmaps** que viene siendo una textura de luces.

Unity nos permite modificar las opciones generales del Lightmapping en **Window > Rendering > Lighting Settings** además de poder activar su uso (o no) para cada malla de la escena en el inspector de objetos.
## Bump mapping
Técnica de gráficos computacionales 3D creada por James F. Blinn en 1978 cuyo objetivo es simular superficies con aspectos rugosos.
Consiste en modificar las direcciones de los vectores normales de la superficie sin cambiar su geometría, de esta manera se consigue modificar la intensidad luminosa en los diferentes puntos de la superficie obteniendo un efecto, aunque con menos detalle, similar al deseado sin aumentar su coste computacional.

## Normal mapping
El Bump mapping consiste en manipular las normales de la malla, esto lo limita ya que si una malla esta formada por 4 polígonos solo se podrán modificar 4 vectores normales, por otro lado el Normal mapping extiende la técnica de manera que a una malla le puedas aplicar un mapa de *X* número de normales independientemente de su número de polígonos.

En Unity podemos encontrar esta técnica como **Normal Map** en las opciones de los materiales. Cada texel representa una desviación de la dirección del vector normal a la superficie.

Unity no implementa **Bump Map** porque se puede obtener el mismo efecto usando un Normal Map.
## Sky Box
## Enviroment mapping
## Iluminación global
