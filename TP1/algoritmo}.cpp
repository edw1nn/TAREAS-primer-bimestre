//Algoritmo para hallar el mayor de 3 números y ver si el numero es impar o par//

#include <iostream>
using namespace std;

int main() {
    int numero1, numero2, numero3;   
    cout << "Ingrese el primer numero: ";
    cin >> numero1;
    cout << "Ingrese el segundo numero: ";
    cin >> numero2;
    cout << "Ingrese el tercer numero: ";
    cin >> numero3;
  
    int mayor = numero1;
    if (numero2 > mayor) {
        mayor = numero2;
    }
    if (numero3 > mayor) {
        mayor = numero3;
    }
    
    if (mayor % 2 == 0) {
        cout << "El mayor de los tres numeros es: " << mayor << " numero par." << endl;
    } else {
        cout << "El mayor de los tres numeros es: " << mayor << "  numero impar." << endl;
        
    }
    
    return 0;
}
;
