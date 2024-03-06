#include <iostream>
#include <vector>

using namespace std;

int main() {
    const int tamano_vector = 20;
    vector<int> datos_originales(tamano_vector);
    vector<int> datos_mejorados(tamano_vector);

    cout << "Ingrese 20 valores:" << endl;
    for (int i = 0; i < tamano_vector; ++i) {
        cin >> datos_originales[i];

        if (datos_originales[i] % 2 == 0) {
            
            datos_mejorados[i] = datos_originales[i] + 1;
        } else {
        
            datos_mejorados[i] = datos_originales[i] * 2;
        }

        if (datos_mejorados[i] < 0) {
            datos_mejorados[i] = 0;
        }
    }

    cout << "\nDatos Originales:\n";
    for (int valor : datos_originales) {
        cout << valor << " ";
    }

    cout << "\nDatos Mejorados:\n";
    for (int valor : datos_mejorados) {
        cout << valor << " ";
    }

    return 0;
}

