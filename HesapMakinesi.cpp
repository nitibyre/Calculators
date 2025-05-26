#include <iostream>
#include <cmath>

using namespace std;

void toplama() {
    double a, b;
    cout << "\nBirinci sayıyı girin: ";
    cin >> a;
    cout << "\nİkinci sayıyı girin: ";
    cin >> b;
    cout << "\nSonuç: " << a << " + " << b << " = " << a + b << endl;
}

void cikarma() {
    double a, b;
    cout << "\nBirinci sayıyı girin: ";
    cin >> a;
    cout << "\nİkinci sayıyı girin: ";
    cin >> b;
    cout << "\nSonuç: " << a << " - " << b << " = " << a - b << endl;
}

void carpma() {
    double a, b;
    cout << "\nBirinci sayıyı girin: ";
    cin >> a;
    cout << "\nİkinci sayıyı girin: ";
    cin >> b;
    cout << "\nSonuç: " << a << " * " << b << " = " << a * b << endl;
}

void bolme() {
    double a, b;
    cout << "\nBirinci sayıyı girin: ";
    cin >> a;
    cout << "\nİkinci sayıyı girin: ";
    cin >> b;
    if (b != 0)
        cout << "\nSonuç: " << a << " / " << b << " = " << a / b << endl;
    else
        cout << "\nBir sayıyı 0'a bölemezsiniz.\n";
}

void kare_alma() {
    double x;
    cout << "\nSayınızı girin: ";
    cin >> x;
    cout << x << "² = " << x * x << endl;
}

void karekok() {
    double x;
    cout << "\nSayınızı girin: ";
    cin >> x;
    if (x >= 0)
        cout << "√" << x << " = " << sqrt(x) << endl;
    else
        cout << "\nNegatif sayıların karekökü alınamaz.\n";
}

void geometrik_hesaplamalar() {
    char secim;
    cout << "\nGeometrik Şekiller:\na. Daire\nb. Dikdörtgen\nc. Üçgen (alan)\nŞekil seçin (a/b/c): ";
    cin >> secim;

    if (secim == 'a') {
        double r;
        cout << "\nYarıçapı girin: ";
        cin >> r;
        if (r <=0){
            cout << "\nÇap 0 veya negatif olamaz";
        }
        else{
            cout << "\nDaire Alanı: " << M_PI * r * r << ", Çevresi: " << 2 * M_PI * r << endl;
        }
    } else if (secim == 'b') {
        double a, b;
        cout << "\nKısa kenar: ";
        cin >> a;
        cout << "\nUzun kenar: ";
        cin >> b;
        if (a > b || a<=0 || b<=0)
            cout << "\nHatalı veri girişi\n";
        else if (a == b)
            cout << "\nBu bir kare\n";
        else
            cout << "\nDikdörtgen Alanı: " << a * b << ", Çevresi: " << 2 * (a + b) << endl;
    } else if (secim == 'c') {
        double taban, yukseklik;
        cout << "\nTaban uzunluğu: ";
        cin >> taban;
        cout << "\nYükseklik: ";
        cin >> yukseklik;
        if (taban <= 0 || yukseklik <= 0){
            cout << "\nHatali veri girişi";
        }
        else{
            cout << "\nÜçgen Alanı: " << (taban * yukseklik) / 2 << endl;
        }
        
    } else {
        cout << "\nGeçersiz seçim.\n";
    }
}

int main() {
    string secim;

    while (true) {
        cout << "\n\nMavera Hesap Makinesi\nYapmak istediğiniz işlemi seçin:\n";
        cout << "1. Toplama\n2. Çıkarma\n3. Çarpma\n4. Bölme\n";
        cout << "5. Kare alma (x^2)\n6. Karekök alma (√x)\n7. Geometrik hesaplamalar\n0. Çıkış\n";
        cout << "Seçiminiz (0-7): ";
        cin >> secim;

        if (secim == "0") {
            cout << "Çıkılıyor...\n";
            break;
        } else if (secim == "1") toplama();
        else if (secim == "2") cikarma();
        else if (secim == "3") carpma();
        else if (secim == "4") bolme();
        else if (secim == "5") kare_alma();
        else if (secim == "6") karekok();
        else if (secim == "7") geometrik_hesaplamalar();
        else cout << "Geçersiz seçim.\n";
    }

    return 0;
}
