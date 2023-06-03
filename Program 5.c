#include <stdio.h>
#include <math.h>

/* Volumen y �rea del cilindro */

/*El programa, al recibir como datos el radio y la altura de un cilindro,
calcula su �rea y su volumen.
RAD, ALT, VOL y ARE: variables de tipo real. */

void main() {
  float RAD, ALT, VOL, ARE;

  /* Solicitamos al usuario que ingrese el radio y la altura del cilindro*/

  printf("Ingrese el radio y la altura del cilindro: ");
  scanf("%f %f", &RAD, &ALT);

  /* Calculamos el volumen y el �rea del cilindro*/

  VOL = M_PI * RAD * RAD * ALT;
  ARE = 2 * M_PI * RAD * (RAD + ALT);
  printf("\nEl volumen es: %6.2f \t El �rea es: %6.2f\n", VOL, ARE);
}
