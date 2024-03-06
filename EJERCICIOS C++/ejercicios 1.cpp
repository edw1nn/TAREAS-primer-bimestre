#include <iostream>
#include <vector>

using namespace std;

void calcularEstadisticas(const vector<int>& vec) {
    int total = 0;
    for (int valor : vec) {
        total += valor;
    }
    double promedioTotal = static_cast<double>(total) / vec.size();
    int cantidad25Percent = static_cast<int>(0.25 * vec.size());
    int suma25Percent = 0;
    for (int i = 0; i < cantidad25Percent; ++i) {
        suma25Percent += vec[i];
    }
    double promedio25Percent = static_cast<double>(suma25Percent) / cantidad25Percent;
    cout << "Total del vector: " << total << endl;
    cout << "Promedio total de valores: " << promedioTotal << endl;
    cout << "Promedio del 25% de los valores: " << promedio25Percent << endl;
}

int main() {
    
    vector<int> miVector = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
    calcularEstadisticas(miVector);

    return 0;
}

