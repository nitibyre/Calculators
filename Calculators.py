import math

def input_float(mesaj):
    try:
        deger = float(input(mesaj))
        if deger <= 0:
            print("\nSayi sifirdan buyuk olmalidir.")
            return None
        return deger
    except ValueError:
        print("\nGecerli bir sayi girin.")
        return None

def dort_islem(secim):
    sayi1 = input_float("Birinci sayiyi girin: ")
    if sayi1 is None:
        return
    sayi2 = input_float("Ikinci sayiyi girin: ")
    if sayi2 is None:
        return

    if secim == '1':
        print(f"Sonuc: {sayi1} + {sayi2} = {sayi1 + sayi2}")
    elif secim == '2':
        print(f"Sonuc: {sayi1} - {sayi2} = {sayi1 - sayi2}")
    elif secim == '3':
        print(f"Sonuc: {sayi1} * {sayi2} = {sayi1 * sayi2}")
    elif secim == '4':
        if sayi2 != 0:
            print(f"Sonuc: {sayi1} / {sayi2} = {sayi1 / sayi2}")
        else:
            print("Bir sayiyi 0'a bolemezsiniz.")

def kare_al():
    sayi = input_float("Sayinizi girin: ")
    if sayi is not None:
        print(f"{sayi}^2 = {sayi ** 2}")

def karekok_al():
    sayi = input_float("Sayinizi girin: ")
    if sayi is None:
        return
    if sayi < 0:
        print("Negatif sayilarin karekoku alinamaz.")
    else:
        print(f"√{sayi} = {math.sqrt(sayi)}")

def daire_hesapla():
    r = input_float("\nYaricapi girin: ")
    if r is not None:
        alan = math.pi * r ** 2
        cevre = 2 * math.pi * r
        print(f"\nDaire Alani: {alan:.2f}, Cevresi: {cevre:.2f}")

def dikdortgen_hesapla():
    a = input_float("\nKisa kenar: ")
    if a is None:
        return
    b = input_float("\nUzun kenar: ")
    if b is None:
        return
    if a > b:
        print("\nHatali veri girisi")
    elif a == b:
        print("Bu bir kare")
    else:
        alan = a * b
        cevre = 2 * (a + b)
        print(f"\nDikdortgen Alani: {alan}, Cevresi: {cevre}")

def ucgen_hesapla():
    taban = input_float("\nTaban uzunlugu: ")
    if taban is None:
        return
    yukseklik = input_float("\nYukseklik: ")
    if yukseklik is None:
        return
    alan = (taban * yukseklik) / 2
    print(f"\nUcgen Alani: {alan}")

def geometrik_hesaplamalar():
    print("\nGeometrik Sekiller:")
    print("a. Daire")
    print("b. Dikdortgen")
    print("c. Ucgen (alan)")

    geo_secim = input("Sekil secin (a/b/c): ").lower()

    if geo_secim == 'a':
        daire_hesapla()
    elif geo_secim == 'b':
        dikdortgen_hesapla()
    elif geo_secim == 'c':
        ucgen_hesapla()
    else:
        print("Gecersiz secim.")

def hesap_makinesi():
    while True:
        print("\nMavera Hesap Makinesi\nYapmak istediginiz islemi secin:\n1. Toplama\n2. Cikarma\n3. Carpma\n4. Bolme\n5. Kare alma (x^2)\n6. Karekok alma (√x)\n7. Geometrik hesaplamalar\n0. Cikis")

        secim = input("Seciminiz (0-7): ")

        if secim == '0':
            print("Cikiliyor...")
            break
        elif secim in ('1', '2', '3', '4'):
            dort_islem(secim)
        elif secim == '5':
            kare_al()
        elif secim == '6':
            karekok_al()
        elif secim == '7':
            geometrik_hesaplamalar()
        else:
            print("Gecersiz secim.")

# Programi calistir
hesap_makinesi()
