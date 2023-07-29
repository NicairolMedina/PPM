#include <stdio.h>

#define MAX_SIZE 10

int main() {
    int matriz[MAX_SIZE][MAX_SIZE];  // Declaraci�n de una matriz utilizando un arreglo bidimensional
    int filas, columnas;

    printf("Ingrese el n�mero de filas de la matriz: ");
    scanf("%d", &filas);  // Lectura del n�mero de filas desde la entrada est�ndar

    printf("Ingrese el n�mero de columnas de la matriz: ");
    scanf("%d", &columnas);  // Lectura del n�mero de columnas desde la entrada est�ndar

    printf("Ingrese los elementos de la matriz:\n");
    for (int i = 0; i < filas; i++) {  // Bucle para recorrer las filas de la matriz
        for (int j = 0; j < columnas; j++) {  // Bucle para recorrer las columnas de la matriz
            scanf("%d", &matriz[i][j]);  // Lectura de los elementos de la matriz desde la entrada est�ndar
        }
    }

    printf("La matriz ingresada es:\n");
    for (int i = 0; i < filas; i++) {  // Bucle para recorrer las filas de la matriz
        for (int j = 0; j < columnas; j++) {  // Bucle para recorrer las columnas de la matriz
            printf("%d ", matriz[i][j]);  // Impresi�n de los elementos de la matriz en la salida est�ndar
        }
        printf("\n");  // Impresi�n de un salto de l�nea para separar las filas de la matriz
    }

    return 0;  // Finalizaci�n del programa y retorno de 0 para indicar que se ejecut� correctamente
}
// En resumen, el c�digo permite al usuario ingresar una matriz y muestra la matriz ingresada. Puede ser �til para verificar si los elementos de la matriz se 
//ingresaron correctamente o para realizar operaciones adicionales en la matriz m�s adelante en el programa.
