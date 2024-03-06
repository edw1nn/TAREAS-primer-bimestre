#include <iostream>
#include <string>

int main() {
    using namespace std;
    string numero;
    cout << "Ingrese valores: ";
    cin >> numero;

    
    int longitud = numero.length();
    for (int a = 0; a < longitud / 2; ++a) {
        char temp = numero[a];
        numero[a] = numero[longitud - 1 - a];
        numero[longitud - 1 - a] = temp;
    }

    
    cout << "el numero que fue cambiado es: " << numero << std::endl;

    return 0;
}

