#include <stdio.h>

#define MAX_SIZE 10

int findMaxElement(int matriz[MAX_SIZE][MAX_SIZE], int filas, int columnas);

int main() {
    int filas, columnas;
    int matriz[MAX_SIZE][MAX_SIZE];

    printf("Ingrese el n�mero de filas: ");
    scanf("%d", &filas);  // Lectura del n�mero de filas desde la entrada est�ndar

    printf("Ingrese el n�mero de columnas: ");
    scanf("%d", &columnas);  // Lectura del n�mero de columnas desde la entrada est�ndar

    printf("Ingrese los elementos de la matriz:\n");
    for (int i = 0; i < filas; i++) {  // Bucle para recorrer las filas de la matriz
        for (int j = 0; j < columnas; j++) {  // Bucle para recorrer las columnas de la matriz
            scanf("%d", &matriz[i][j]);  // Lectura de los elementos de la matriz desde la entrada est�ndar
        }
    }

    int maxElement = findMaxElement(matriz, filas, columnas);  // Llamada a la funci�n para encontrar el elemento m�ximo

    printf("El elemento m�ximo en la matriz es: %d\n", maxElement);  // Impresi�n del elemento m�ximo en la salida est�ndar

    return 0;  // Finalizaci�n del programa y retorno de 0 para indicar que se ejecut� correctamente
}

int findMaxElement(int matriz[MAX_SIZE][MAX_SIZE], int filas, int columnas) {
    int maxElement = matriz[0][0];  // Inicializaci�n del m�ximo con el primer elemento de la matriz

    // Recorrido de cada elemento de la matriz
    for (int i = 0; i < filas; i++) {  // Bucle para recorrer las filas de la matriz
        for (int j = 0; j < columnas; j++) {  // Bucle para recorrer las columnas de la matriz
            // Si el elemento actual es mayor que el m�ximo actual, actualizar el m�ximo
            if (matriz[i][j] > maxElement) {
                maxElement = matriz[i][j];
            }
        }
    }

    return maxElement;  // Retorno del elemento m�ximo encontrado
}

